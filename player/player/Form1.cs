using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace player
{
    public partial class Form1 : Form
    {
        
        string Defold_list = @"C:\path\playlist.txt";
        
        string[] playlists = Directory.GetFiles(@"C:\path", "*.txt");
        string[] songs;
        string delite_file = null;
        int temp = 0;
        int rand_temp = 0;
 
        public Form1()
        {
            InitializeComponent();
            main.Link = this;
            Bass1.InitBass(Bass1.HZ);
            main.SetInputFormats();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Open_list = files.Open_file();
            if (Open_list == null)
            {
                
                songs = File.ReadAllLines(Defold_list);
                for (int i = 0; i < songs.Length; i++)
                {
                    main.Files.Add(songs[i]);
                    TagModel TM = new TagModel(songs[i]);
                    playlist.Items.Add(TM.Album + "-" + TM.Title);
                }
            }
            else
            {
                songs = File.ReadAllLines(Defold_list);
                for (int i = 0; i < songs.Length; i++)
                {
                    main.Files.Add(songs[i]);
                    TagModel TM = new TagModel(songs[i]);
                    playlist.Items.Add(TM.Album + "-" + TM.Title);

                }
            }

        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\path\playlist.txt");
            delite_file = songs[playlist.SelectedIndex];
            playlist.Items.Clear();
            main.Files.Clear();
            for (int i = 0; i < songs.Length; i++)
            {
                if (i != playlist.SelectedIndex)
                {
                    main.Files.Add(songs[i]);
                    TagModel TM = new TagModel(songs[i]);
                    playlist.Items.Add(TM.Album + "-" + TM.Title);
                }
                else
                {
                    file.WriteLine(Defold_list, delite_file);
                    playlist.SelectedIndex = playlist.SelectedIndex - 1;
                }
            }
        }

        private void відкритиСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }

        private void butList_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Bass1.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
            string[] temp = openFileDialog1.FileNames;
            File.AppendAllLines(Defold_list, temp);
            for (int i = 0; i < temp.Length; i++)
            {
                main.Files.Add(temp[i]);
                TagModel TM = new TagModel(temp[i]);
                playlist.Items.Add(TM.Album + "-" + TM.Title);
                
            }
        }

        private void btmPLAY_Click(object sender, EventArgs e)
        {
            if ((playlist.Items.Count != 0) && (playlist.SelectedIndex != -1))
            {
                string current = main.Files[playlist.SelectedIndex];
                main.CurrentTrackNumber = playlist.SelectedIndex;
                Bass1.Play(current, Bass1.Volume);
                label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(Bass1.GetTimeOfStream(Bass1.Stream)).ToString();
                slTime.Maximum = Bass1.GetTimeOfStream(Bass1.Stream);
                slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);
                timer1.Enabled = true;
                TagModel TM = new TagModel(current);
                Artist.Text = TM.Artist;
                Name_file.Text = TM.Title;
            }
        }

        private void btmSTOP_Click(object sender, EventArgs e)
        {
            Bass1.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
            slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);

            if (temp == 1 && rand_temp == 0)
            {  
                    if (Bass1.PlauAgainTrack())
                    {
                        playlist.SelectedIndex = main.CurrentTrackNumber;

                        label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
                        label2.Text = TimeSpan.FromSeconds(Bass1.GetTimeOfStream(Bass1.Stream)).ToString();
                        slTime.Maximum = Bass1.GetTimeOfStream(Bass1.Stream);
                        slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);
   
                    }
            }
            else
            {
                if (temp == 0 && rand_temp == 1)
                {
                    if (Bass1.PlauRandomTrack())
                    {
                        playlist.SelectedIndex = main.CurrentTrackNumber;

                        label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
                        label2.Text = TimeSpan.FromSeconds(Bass1.GetTimeOfStream(Bass1.Stream)).ToString();
                        slTime.Maximum = Bass1.GetTimeOfStream(Bass1.Stream);
                        slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);

                    }
                }
                else { 
                if (Bass1.ToNextTrack())
                {

                    playlist.SelectedIndex = main.CurrentTrackNumber;
                    label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
                    label2.Text = TimeSpan.FromSeconds(Bass1.GetTimeOfStream(Bass1.Stream)).ToString();
                    slTime.Maximum = Bass1.GetTimeOfStream(Bass1.Stream);
                    slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);
                }

                if (Bass1.EndPlaylist)
                {
                    btmSTOP_Click(this, new EventArgs());
                    playlist.SelectedIndex = main.CurrentTrackNumber = 0;
                    Bass1.EndPlaylist = false;
                }
                }
            }
            string current = main.Files[playlist.SelectedIndex];
            TagModel TM = new TagModel(current);
            Artist.Text = TM.Artist;
            Name_file.Text = TM.Title;
        }

        private void slTime_Scroll(object sender, ScrollEventArgs e)
        {
            Bass1.SetPosOfScroll(Bass1.Stream, slTime.Value);
        }

        private void slVol_Scroll(object sender, ScrollEventArgs e)
        {
            if (main.volumeOff == true)
            {
                slVol.Value = 0;
                Bass1.SetVolumeToStream(Bass1.Stream, slVol.Value);
            }
            else
            {
                Bass1.SetVolumeToStream(Bass1.Stream, slVol.Value);
            }
        }

        private void btmPAUSE_Click(object sender, EventArgs e)
        {
            Bass1.Pause();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void next_Click(object sender, EventArgs e)
        {
            if (Bass1.ToNextTrackClick())
            {
                playlist.SelectedIndex = main.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(Bass1.GetTimeOfStream(Bass1.Stream)).ToString();
                slTime.Maximum = Bass1.GetTimeOfStream(Bass1.Stream);
                slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);
            }
            if (Bass1.EndPlaylist)
            {
                btmSTOP_Click(this, new EventArgs());
                playlist.SelectedIndex = main.CurrentTrackNumber = 0;
                Bass1.EndPlaylist = false;
            }
            string current = main.Files[playlist.SelectedIndex];
            TagModel TM = new TagModel(current);
            Artist.Text = TM.Artist;
            Name_file.Text = TM.Title;
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (Bass1.ToPreviosTrackClick())
            {
                playlist.SelectedIndex = main.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(Bass1.GetPosOfStream(Bass1.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(Bass1.GetTimeOfStream(Bass1.Stream)).ToString();
                slTime.Maximum = Bass1.GetTimeOfStream(Bass1.Stream);
                slTime.Value = Bass1.GetPosOfStream(Bass1.Stream);
            }
            if (Bass1.StartPlaylist)
            {
                btmSTOP_Click(this, new EventArgs());
                playlist.SelectedIndex = main.CurrentTrackNumber = 0;
                Bass1.StartPlaylist = false;
            }


            string current = main.Files[playlist.SelectedIndex];
            TagModel TM = new TagModel(current);
            Artist.Text = TM.Artist;
            Name_file.Text = TM.Title;
        }

        private void VolumeOff_Click(object sender, EventArgs e)
        {
            main.volumeOff = true;
            main.volumeNew = slVol.Value;
            slVol.Value = 0;
            Bass1.SetVolumeToStream(Bass1.Stream, slVol.Value);
        }

        private void VolumeOn_Click(object sender, EventArgs e)
        {
            main.volumeOff = false;
            slVol.Value = main.volumeNew;
            Bass1.SetVolumeToStream(Bass1.Stream, slVol.Value);
        }

        private void Reload_Click(object sender, EventArgs e)
        {
                
            temp = temp + 1;
            if (temp == 2)
            {
                temp = 0;
            }
        }

        private void random_Click(object sender, EventArgs e)
        {
            rand_temp = rand_temp + 1;
            if (rand_temp == 2)
            {
                rand_temp = 0;
            }
          
        }

        private void видалитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Bass1.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
            Artist.Text = "Unknown artist";
            Name_file.Text = "Unknown song";
            playlist.Items.Clear();
            main.Files.Clear();
            File.Delete(Defold_list);
            File.Create(Defold_list);
            //StreamWriter writer = new StreamWriter(file);
           
            //Application.dataPath + "playlist.txt"
        }
    }
}
