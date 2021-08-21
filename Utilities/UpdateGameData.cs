using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidSideloader.Utilities
{
    class UpdateGameData
    {
        public UpdateGameData(String gameName, String packageName, ulong installedVersionInt)
        {
            this.GameName = gameName;
            this.Packagename = packageName;
            this.InstalledVersionInt = installedVersionInt;
        }
        public string GameName { get; set; }
        public string Packagename { get; set; }

        public ulong InstalledVersionInt { get; set; }
    }
}
