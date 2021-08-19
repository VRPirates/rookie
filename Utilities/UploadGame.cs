using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidSideloader.Utilities
{
    class UploadGame
    {
        private string uploadcommand;
        public string Uploadcommand
        {
            get => uploadcommand;
            set => uploadcommand = value;
        }   
        private string pckgcommand;
        public string Pckgcommand
        {
            get => pckgcommand;
            set => pckgcommand = value;
        }
        private string uploadgamename;
        public string Uploadgamename
        {
            get => uploadgamename;
            set => uploadgamename = value;
        }
        private ulong uploadversion;
        public ulong Uploadversion
        {
            get => uploadversion;
            set => uploadversion = value;
        }
    }
}
