using System;
using System.Collections.Generic;
using Un4seen.Bass;
using System.Windows.Forms;

namespace player
{
    public static class Bass1
    {

        public static bool BD = false;

        // частота дискритизації
        public static int HZ = 441004;

        // стан ініціалізації
        public static bool InitDefaultDevice;

        // головний канал(потік) бази dll
        public static int Stream;

        private static readonly List<int> BassPluginsHandlers = new List<int>();

        // Гучність 
        public static int Volume = 100;

        /// <summary>
        /// канал зупинено руками
        /// </summary>
        private static bool isStoped = true;

        /// <summary>
        /// кінець плейлисту
        /// </summary>
        public static bool EndPlaylist;

        /// <summary>
        /// Початок плейлисту
        /// </summary>
        public static bool StartPlaylist;

        //Ініціалізація  Bass.dll
        public static bool InitBass(int HZ)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, HZ, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (InitDefaultDevice)
                {
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\basscd.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\bassdsd.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\bassmidi.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(main.AppPath + @"plugins\basswma.dll"));

                    int ErrorCount = 0;
                    for (int i = 0; i < BassPluginsHandlers.Count; i++)
                        if (BassPluginsHandlers[i] == 0)
                            ErrorCount++;
                    if (ErrorCount != 0)
                        MessageBox.Show(ErrorCount + "Палагінів не було знайдено", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ErrorCount = 0;
                }

            }
            
            return InitDefaultDevice;
        }

        /// <summary>
        /// програвати медіа файл
        /// </summary>
        /// <param name="Filename"></param>
        /// <param name="vol"></param>
        public static void Play(string Filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(HZ))
                {
                    Stream = Bass.BASS_StreamCreateFile(Filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {

                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);
            isStoped = false;
        }
        /// <summary>
        /// пауза
        /// </summary>
        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(Stream);
            }

        }


        /// <summary>
        /// стоп
        /// </summary>
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStoped = true;
        }

        /// <summary>
        /// стоп
        /// </summary>
        public static void Stoped()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }

        
        /// <summary>
        /// отримання часу програвання треку в секундах
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        /// <summary>
        /// Витягування поточної позиції відтворення(сек)
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        /// <summary>
        ///  перемотка треку
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="pos"></param>
        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }


        /// <summary>
        /// установка гучності
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="vol"></param>
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }
        /// <summary>
        /// Next track
        /// </summary>
        /// <returns></returns>
        public static bool ToNextTrack()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                if (main.Files.Count > main.CurrentTrackNumber + 1)
                {
                    Play(main.Files[++main.CurrentTrackNumber], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            }
            return false;
        }
        /// <summary>
        /// Next track buttom
        /// </summary>
        /// <returns></returns>
        public static bool ToNextTrackClick()
        {
            Stoped();
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                if (main.Files.Count > main.CurrentTrackNumber + 1)
                {
                    Play(main.Files[++main.CurrentTrackNumber], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            }
            return false;
        }
        public static bool ToPreviosTrackClick()
        {
            Stoped();
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                if ( main.CurrentTrackNumber != 0)
                {
                    Play(main.Files[--main.CurrentTrackNumber], Volume);
                    StartPlaylist = false;
                    return true;
                }
                else
                    StartPlaylist = true;
            }
            return false;
        }


        public static bool PlauAgainTrack()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {

                    Play(main.Files[main.CurrentTrackNumber], Volume);
                    return true;

            }
            return false;
        }

        public static bool PlauRandomTrack()
        {
            
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
            {
                Random rand = new Random();
                main.CurrentTrackNumber = rand.Next(0, main.Files.Count);
                Play(main.Files[main.CurrentTrackNumber], Volume);
                return true;

            }
            return false;
        }
    }
}
