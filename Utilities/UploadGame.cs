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
        public string Uploadcommand    // the Name property
        {
            get => uploadcommand;
            set => uploadcommand = value;
        }
        private string uploadgamename;
        public string Uploadgamename    // the Name property
        {
            get => uploadgamename;
            set => uploadgamename = value;
        }
        private ulong uploadversion;
        public ulong Uploadversion    // the Name property
        {
            get => uploadversion;
            set => uploadversion = value;
        }

        public static implicit operator List<object>(UploadGame v)
        {
            throw new NotImplementedException();
        }
    }
}
