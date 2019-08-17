using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace player
{
    static class files
    {
        public static string FilePos = null;
        public static void File_pos(string File)
        {
            FilePos = File;
        }

        public static string Open_file()
        {
            return FilePos;
        }

    }
}
