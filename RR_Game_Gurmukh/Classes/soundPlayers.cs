using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RR_Game_Gurmukh.Classes
{
    public class soundPlayers
    {
        public void soundPlayerSystem(Stream s)
        {

            SoundPlayer mySoundPlayer = new SoundPlayer(s);

            mySoundPlayer.Play();

        }
    }
}
