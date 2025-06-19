namespace c__z9_webAPI
{
    public static class ForOtherFiles   // но здесь нигде нет проверки на то, есть ли соответствующте разделы в файле appsettings.json))
    {
        private static IConfiguration _configuration;

        public static void ForOtherFilesSetConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string getAPI()
        {
            string urlAPI = _configuration["RandomAPI"];
            return urlAPI;
        }
        public static string[] getBlackList()
        {
            string[] BlackList = _configuration.GetSection("Settings:BlackList").Get<string[]>();
            if (BlackList == null)
            {
                BlackList = new string[0];
                return BlackList;
            }
            return BlackList;
        }
        public static int getParallelLimit()
        {
            int ParallelLimit = _configuration.GetSection("Settings:ParallelLimit").Get<int>();
            return ParallelLimit;
        }
    }
}
