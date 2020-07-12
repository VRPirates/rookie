using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class TroubleshootForm : Form
    {
        public TroubleshootForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string question = askTextBox.Text.ToLower();


            if ((question.Contains("beat saber") || question.Contains("beatsaber")) && question.Contains("dlc"))
                Form1.notify("You can install beatsaber DLC with BMBF, it will work on cracked versions too, just make sure you have latest beat saber and bmbf");
            else if ((question.Contains("load") && question.Contains("not")) || ((question.Contains("black") && question.Contains("screen")) || question.Contains("blackscreen")) && (question.Contains("boot") || question.Contains("launch") || question.Contains("start")))
                Form1.notify("Make sure you have made the user.json files, copied the obb folder and allowed app permissions");
            else if (question.Contains("pass") || question.Contains("pw"))
                Form1.notify(@"cs.rin.ru
https://t.me/questgameclub
https://t.me/QuestGameClub
oculusquestpiracy
OculusQuestPiracy
Telegram's passwords until 5/17/2020
https://t.me/questgameclub/thx
t.me/questgameclub/thxdonate
https://t.me/questgameclub/thxdonate
https://t.me/questgameclub/play
https://t.me/questgameclub/love
https://t.me/questgameclub/vip
https://t.me/questgameclub/thxdonatetome");
            else
                Form1.notify("Sorry I'm too dumb to answer that right now, please ask flow, if flow can't figure it out nobody can");

        }

        private void TroubleshootForm_Load(object sender, EventArgs e)
        {

        }
    }
}
