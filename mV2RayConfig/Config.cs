using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mV2RayConfig
{
    public class Config
    {
        public class ServerInfo
        {
            public dynamic log { get; set; }
            public dynamic inbound { get; set; }
            public dynamic outbound { get; set; }
        }

        public class Log
        {
            public string access { get; set; }
            public string error { get; set; }
            public string loglevel { get; set; }
        }

        public class Inbound
        {
            public int port { get; set; }
            public string protocol { get; set; }
            public dynamic settings { get; set; }
        }

        public class Outbound
        {
            public string protocol { get; set; }
            public dynamic settings { get; set; }
        }

        public class Setting
        {
            //空。
        }

        public class InBoundSetting
        {
            public JArray clients { get; set; }
        }
    }
}
