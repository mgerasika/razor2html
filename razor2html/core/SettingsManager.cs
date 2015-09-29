using System;
using System.IO;
using Newtonsoft.Json;

namespace razor2html
{
    public class SettingsManager
    {
        private const string _fileName = "settings.json";
        public static SettingsManager Inst = new SettingsManager();
        private SettingsModel _model = null;
        private static object _lockObj = new object();

        private SettingsManager() {
        }

        public SettingsModel GetModel() {
            if (_model == null) {
                if (_model == null) {
                    Load();
                    Save();
                }
            }
            return _model;
        }

        private void Load() {

            lock (_lockObj) {
                if (File.Exists(_fileName)) {
                    var serializer = new JsonSerializer();
                    using (StreamReader sr = new StreamReader(_fileName)) {
                        JsonReader reader = new JsonTextReader(sr);
                        _model = serializer.Deserialize<SettingsModel>(reader);
                    }
                }
                else {
                    _model = new SettingsModel();
                }
            }
        }

        public void Save()
        {
            lock (_lockObj) {
                var serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(_fileName)) {
                    JsonWriter writer = new JsonTextWriter(sw);
                    serializer.Serialize(writer, _model);
                }
            }
        }
    }
}