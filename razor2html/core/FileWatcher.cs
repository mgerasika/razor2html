using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpToHtml;

namespace razor2html.core
{
    public class FileWatcher
    {
        public static FileWatcher Inst = new FileWatcher();
        private FileWatcher() {
            
        }

        public void Init() {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = SettingsManager.Inst.GetModel().InFolder;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += watcher_Changed;
            watcher.Created += watcher_Created;
            watcher.Deleted += watcher_Deleted;
            watcher.Renamed += watcher_Renamed;

            watcher.EnableRaisingEvents = true;
        }

        void watcher_Renamed(object sender, RenamedEventArgs e) {
            ApplyChanges(e);
        }

        void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            ApplyChanges(e);
        }

        void watcher_Created(object sender, FileSystemEventArgs e)
        {
            ApplyChanges(e);
        }

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            ApplyChanges(e);
        }

        private void ApplyChanges(FileSystemEventArgs e) {
             do {
                LogManager.Inst.Log("File Changed:" + e.FullPath);
                Razor2HtmlConverter.Inst.ConvertSingle(e.FullPath);

            } while (false);
        }

        
    }
}
