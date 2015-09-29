using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpToHtml;
using razor2html.core;

namespace razor2html
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void _txtInput_TextChanged(object sender, EventArgs e) {
            SettingsManager.Inst.GetModel().InFolder = _txtInput.Text;
            SettingsManager.Inst.Save();
        }

        private void _txtUrl_TextChanged(object sender, EventArgs e)
        {
            SettingsManager.Inst.GetModel().Url = _txtUrl.Text;
            SettingsManager.Inst.Save();
        }

        private void _txtOutput_TextChanged(object sender, EventArgs e)
        {
            SettingsManager.Inst.GetModel().OutFolder = _txtOutput.Text;
            SettingsManager.Inst.Save();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            SettingsModel model = SettingsManager.Inst.GetModel();
            _txtInput.Text = model.InFolder;
            _txtOutput.Text = model.OutFolder;
            _txtUrl.Text = model.Url;

            LogManager.Inst.Subscribe(delegate(LogEventArgs args) {
                _txtLog.Invoke(new Action(() => _txtLog.Text = args.Logs));
            });
            FileWatcher.Inst.Init();
        }

        private void _inBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(_txtInput.Text) && Directory.Exists(_txtInput.Text)) {
            }
            if (DialogResult.OK == dialog.ShowDialog()) {
                _txtInput.Text = dialog.SelectedPath;
            }
        }

        private void _outBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
           
            if (DialogResult.OK == dialog.ShowDialog())
            {
                _txtOutput.Text = dialog.SelectedPath;
            }
        }

        private void _btnConvert_Click(object sender, EventArgs e) {
            do {
                
                Razor2HtmlConverter.Inst.ConvertAll();

            } while (false);
        }

       
    }
}
