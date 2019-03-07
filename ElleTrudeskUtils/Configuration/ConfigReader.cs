using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ElleTrudeskUtils.Configuration
{
    public static class ConfigReader
    {
        public static Config GetConfig()
        {
            Config ret = null;
            try
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
                ret = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ret;
        }

    }
}
