using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Config
    {
        private static Config conf = null;

        public string paramGlobal { get; set; }

        private Config()
        {

        }

        public static Config GetInstance() {

            if (conf == null)
                conf = new Config();

            return conf;
        }

    }
}
