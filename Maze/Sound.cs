using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace Maze
{
    static class Sound
    {
       static SoundPlayer sound1 = new SoundPlayer(Properties.Resources.sound1);
        static SoundPlayer sound2 = new SoundPlayer(Properties.Resources.sound2);
        static SoundPlayer sound3 = new SoundPlayer(Properties.Resources.sound3);

        public static void play_fail()
        {
            sound1.Play();
          
        }
        public static void play_faild()
        {
            sound2.Play();

        }
        public static void play_fai()
        {
            sound3.Play();

        }

    }

}
