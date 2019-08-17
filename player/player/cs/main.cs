using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace player
{
    public static class main
    {
        public static Form1 Link;
        /// <summary>
        /// шлях до виконуваного файлу(формат)
        /// </summary>
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// список імен файлів
        /// </summary>
        public static List<string> Files = new List<string>();


        /// <summary>
        /// Volume off indikator
        /// </summary>
        public static bool volumeOff = false;

        /// <summary>
        /// Volume on indikator
        /// </summary>
        public static int volumeOn = 100;

        public static int volumeNew = 0;



        /// <summary>
        /// позиція трека в плейлисті
        /// </summary>
        public static int CurrentTrackNumber;

        /// <summary>
        /// get file mane in directory
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileName(string file)
        {
            string[] temp = file.Split('\\');
            return temp[temp.Length - 1];
        }

        /// <summary>
        /// get formats files
        /// </summary>
        public static void SetInputFormats()
        {
            Link.openFileDialog1.Filter = "Всі формати|*.mp3; *.m4a; *.mp4; *.tta; *.opus; *.ogg; *.alas"
                + "|MPEG Audio Layer III (*.mp3)|*.mp3"
                + "|Advanced Audio (*.m4a; *.mp4)|*.m4p;*.mp4";
        }
    }
}
