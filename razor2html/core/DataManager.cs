namespace razor2html
{
    public class SettingsModel
    {
        public string InFolder { get; set; }
        public string OutFolder { get; set; }
        public string Url { get; set; }
    }

    public class DataManager
    {
        public static DataManager Inst = new DataManager();

        private DataManager() {
        }
    }
}