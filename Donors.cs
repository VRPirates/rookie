using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidSideloader
{
    class Donors
    {

        //This shit sucks but i'll switch to programatically adding indexes from the gamelist txt sometimes maybe

        public static int GameNameIndex = 0;
        public static int PackageNameIndex = 1;
        public static int VersionCodeIndex = 2;
        public static int UpdateOrNew = 3;


        public static List<string> donorGameProperties = new List<string>();
        /* Game Name
         * Package Name
         * Version Code
         * Update or New app
         */
        public static List<string[]> donorGames = new List<string[]>();
        public static void initDonorGames()
        {
            donorGameProperties.Clear();
            donorGames.Clear();
            if (!MainForm.DonorApps.Equals(""))
            {
                string[] gameListSplited = MainForm.DonorApps.Split(new[] { '\n' }, 2);

                foreach (string gameProperty in gameListSplited[0].Split(';'))
                {
                    donorGameProperties.Add(gameProperty);
                }

                foreach (string game in gameListSplited[1].Split('\n'))
                {
                    if (game.Length > 1)
                    {
                        string[] splitGame = game.Split(';');
                        donorGames.Add(splitGame);
                    }
                }
            }


        }
    }
}
