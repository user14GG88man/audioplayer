using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Un4seen.Bass.AddOn.Tags;

namespace player
{


    public class TagModel
    {
        public int BitRate;
        public int Freg;
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;

        Dictionary<int, string> ChannelsDist = new Dictionary<int, string>()
        {
            {0, "Null"},
            {1, "Mono"},
            {2, "Stereo"}
        };
        public  TagModel(string file)
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(file);
            if (tagInfo == null)
                BitRate = 0;
            else
            {
                BitRate = tagInfo.bitrate;
                Freg = tagInfo.channelinfo.freq;
                Channels = ChannelsDist[tagInfo.channelinfo.chans];
                Artist = tagInfo.artist;
                Album = tagInfo.album;
                if (tagInfo.title == "")
                    Title = main.GetFileName(file);
                else
                    Title = tagInfo.title;
                Year = tagInfo.year;
            }
        }
    }
}