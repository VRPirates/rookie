using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidSideloader.Utilities
{
    class UploadGame
    {
        public UploadGame(string Uploadcommand, string Pckgcommand, string Uploadgamename, ulong Uploadversion)
        {
            this.Uploadcommand = Uploadcommand;
            this.Pckgcommand = Pckgcommand;
            this.Uploadgamename = Uploadgamename;
            this.Uploadversion = Uploadversion;
        }
        public UploadGame()
        {
            
        }
        public string Uploadcommand { get; set; }

        public string Pckgcommand { get; set; }
        
        public string Uploadgamename { get; set; }

        public ulong Uploadversion { get; set; }

    }
}
