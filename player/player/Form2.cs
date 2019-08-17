using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace player
{
    public partial class Form2 : Form
    {
        string[] playlists = Directory.GetFiles(@"C:\path", "*.txt");
        int count = -1;
        DirectoryInfo dir = new DirectoryInfo(@"C:\path");
        private void Form2_Load(object sender, EventArgs e)
        {


            foreach (string elem in playlists)
            {
                count = +1;
                Console.Write(playlists[count]);

            }

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void AddList_Click_1(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Close();
        }

        private void OpenList_Click(object sender, EventArgs e)
        {

            int Pos = ListBox.SelectedIndex;
            if (Pos == -1)
            {
                MessageBox.Show("Виберіть список для відкриття", "Помилка",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                files.File_pos(playlists[Pos]);
                this.Close();
            }

        }

        private void List_add_Click(object sender, EventArgs e)
        {
            if (count != -1)
            {
                for (int i = 0; i >= count; i++)
                {
                    //ListBox.Items.Add(playlists[i]);
                   // foreach (var item in dir.GetFiles())
                   // {
                   //     ListBox.Items.Add(item.Name);
                   // }
                    //
                }
                for (int i = 0; i < count; i++)
                {
                    ListBox.Items.Add(playlists[i]);
                }
            }
        }
    }
}

