using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace player
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void AddList_Click(object sender, EventArgs e)
        {
            string file_name = Convert.ToString(textList.Text);
            string file = @"C:\path";
            string pathString = Path.Combine(file, file_name);
            string message = "Поле Список повинно бути заповнене!";
            if (textList == null)
            {
                MessageBox.Show(message);
            }
            else
            {
                FileStream fs = File.Create(pathString +".txt");
                Form2 f = new Form2();
                f.Show();
                this.Close();
            }
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
