using System;
using System.IO;
using System.Net;
using System.Text;
using razor2html;

namespace CsharpToHtml
{
    public class Razor2HtmlConverter
    {
        private static readonly Razor2HtmlConverter _inst = new Razor2HtmlConverter();

        private static readonly string[] _ignoreList = {
            ".dll",
            ".pdb",
            ".cshtml",
            ".aspx"
        };

        private DirectoryInfo _inputDirectory;
        private DirectoryInfo _outputDirectory;
        private string _virtualDirectory;
        private static object _lockObject = new object();

        private Razor2HtmlConverter() {
        }

        public static Razor2HtmlConverter Inst {
            get {
                _inst.Init();
                return _inst;
            }
        }

        public string MobilePlatformName { get; set; }
        public string OutputFolderPath { get; set; }

        public bool IsValid() {
            var res = false;

            do {
                var model = SettingsManager.Inst.GetModel();
                if (string.IsNullOrEmpty(model.InFolder) || !Directory.Exists(model.InFolder)) {
                    break;
                }

                if (string.IsNullOrEmpty(model.OutFolder) || !Directory.Exists(model.OutFolder)) {
                    break;
                }
                if (false) {
                    break;
                }

                res = true;
            } while (false);

            return res;
        }

        private void Init() {
            if (IsValid()) {
                var model = SettingsManager.Inst.GetModel();
                _inputDirectory = new DirectoryInfo(model.InFolder);
                _outputDirectory = new DirectoryInfo(model.OutFolder);
                _virtualDirectory = model.Url;
            }
        }

        public void ConvertAll() {
            if (IsValid()) {
                lock (_lockObject) {
                    DeleteSubDir(_outputDirectory);

                    CopyServerPage(_inputDirectory, ".aspx");
                    CopyServerPage(_inputDirectory, ".cshtml");
                    CopyFiles(_inputDirectory);

                    CopyDirRecursive(_inputDirectory);
                }
            }
        }

        public void ConvertSingle(string path) {
            if (IsValid()) {
                ConvertAll();
            }
        }

        protected void DeleteSubDir(DirectoryInfo dir) {
            foreach (var subDir in dir.GetDirectories()) {
                subDir.Delete(true);
            }
            foreach (var file in dir.GetFiles()) {
                if (!file.Extension.Contains(".docx")) {
                    file.Delete();
                }
            }
        }

        protected void CopyDirRecursive(DirectoryInfo dir) {
            foreach (var subDir in dir.GetDirectories()) {
                if (subDir.Name.IndexOf('_') != 0) {
                    CopyDir(subDir);

                    if (subDir.GetDirectories().Length > 0) {
                        CopyDirRecursive(subDir);
                    }
                }
            }
        }

        protected void CopyDir(DirectoryInfo dir) {
            var dirName = GetFileNameFromPath(dir.FullName);
            var newDir = new DirectoryInfo(_outputDirectory.FullName + @"\" + dirName);
            if (!Directory.Exists(newDir.FullName)) {
                newDir.Create();
            }

            CopyServerPage(dir, ".aspx");
            CopyServerPage(dir, ".cshtml");
            CopyFiles(dir);
        }

        private void CopyFiles(DirectoryInfo dir) {
            foreach (var subFile in dir.GetFiles()) {
                if (CanCopyFile(subFile)) {
                    if (subFile.Name.IndexOf('_') != 0) {
                        var fileName = GetFileNameFromPath(subFile.FullName);

                        subFile.CopyTo(_outputDirectory.FullName + @"\" + fileName, true);
                    }
                }
            }
        }

        private bool CanCopyFile(FileInfo subFile) {
            var res = true;
            foreach (var ext in _ignoreList) {
                if (subFile.Extension.Equals(ext, StringComparison.OrdinalIgnoreCase)) {
                    res = false;
                    break;
                }
            }
            return res;
        }

        private void CopyServerPage(DirectoryInfo dir, string ext) {
            foreach (var subFile in dir.GetFiles("*" + ext)) {
                if (subFile.Name.IndexOf('_') != 0) {
                    var fileName = GetFileNameFromPath(subFile.FullName);
                    var url =
                        String.Format(_virtualDirectory + fileName + "?mobile=true&platform=" +
                                      MobilePlatformName);
                    Utils.Log("web url=" + url);
                    var lRequest = WebRequest.Create(url);
                    lRequest.Credentials = CredentialCache.DefaultCredentials;
                    var response = (HttpWebResponse) lRequest.GetResponse();
                    var dataStream = response.GetResponseStream();
                    var reader = new StreamReader(dataStream, Encoding.UTF8);
                    var responseFromServer = reader.ReadToEnd();
                    responseFromServer = responseFromServer.Replace("\n\n", "").Replace("\n\r", "");
                    reader.Close();

                    var lNewHtmlFileName = GetFileNameFromPath(subFile.FullName);
                    lNewHtmlFileName = _outputDirectory.FullName +  @"\" + lNewHtmlFileName.Replace(ext, ".html");
                    using (var sw = new StreamWriter(lNewHtmlFileName, false, Encoding.UTF8)) {
                        sw.Write(responseFromServer);
                    }
                }
            }
        }

        private string GetFileNameFromPath(String fullName) {
            var idx = fullName.LastIndexOf(_inputDirectory.FullName);
            var relativeName = fullName.Remove(0, idx + _inputDirectory.FullName.Length + 1);
            return relativeName;
        }
    }
}