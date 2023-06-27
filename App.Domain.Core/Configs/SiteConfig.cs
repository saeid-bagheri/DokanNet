using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Configs
{
    public class SiteConfig
    {
    }
    public class Rootobject
    {
        public Logging Logging { get; set; }
        public MedalConfig MedalConfig { get; set; }
        public string ConnectionString { get; set; }
        public string AllowedHosts { get; set; }
    }

    public class Logging
    {
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }

    public class MedalConfig
    {
        public int FeePercentageDefault { get; set; }
        public int FeePercentageBronze { get; set; }
        public int FeePercentageSilver { get; set; }
        public int FeePercentageGold { get; set; }
        public int BronzePrice { get; set; }
        public int SilverPrice { get; set; }
        public int GoldPrice { get; set; }
    }

}
