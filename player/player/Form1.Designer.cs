namespace player
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playlist = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видалитиВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btmPLAY = new System.Windows.Forms.Button();
            this.btmPAUSE = new System.Windows.Forms.Button();
            this.butList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.slVol = new MB.Controls.ColorSlider();
            this.slTime = new MB.Controls.ColorSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btmSTOP = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Artist = new System.Windows.Forms.Label();
            this.Name_file = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.VolumeOn = new System.Windows.Forms.Button();
            this.VolumeOff = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.playlist.ContextMenuStrip = this.contextMenuStrip1;
            this.playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.playlist.ForeColor = System.Drawing.Color.Firebrick;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 17;
            this.playlist.Location = new System.Drawing.Point(12, 28);
            this.playlist.Name = "playlist";
            this.playlist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playlist.Size = new System.Drawing.Size(210, 310);
            this.playlist.TabIndex = 0;
            this.playlist.DoubleClick += new System.EventHandler(this.btmPLAY_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видалитиВсеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 26);
            // 
            // видалитиВсеToolStripMenuItem
            // 
            this.видалитиВсеToolStripMenuItem.Name = "видалитиВсеToolStripMenuItem";
            this.видалитиВсеToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.видалитиВсеToolStripMenuItem.Text = "Видалити все";
            this.видалитиВсеToolStripMenuItem.Click += new System.EventHandler(this.видалитиВсеToolStripMenuItem_Click);
            // 
            // btmPLAY
            // 
            this.btmPLAY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmPLAY.BackgroundImage")));
            this.btmPLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmPLAY.Location = new System.Drawing.Point(124, 370);
            this.btmPLAY.Name = "btmPLAY";
            this.btmPLAY.Size = new System.Drawing.Size(30, 30);
            this.btmPLAY.TabIndex = 1;
            this.btmPLAY.UseVisualStyleBackColor = true;
            this.btmPLAY.Click += new System.EventHandler(this.btmPLAY_Click);
            // 
            // btmPAUSE
            // 
            this.btmPAUSE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmPAUSE.BackgroundImage")));
            this.btmPAUSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmPAUSE.Location = new System.Drawing.Point(159, 370);
            this.btmPAUSE.Name = "btmPAUSE";
            this.btmPAUSE.Size = new System.Drawing.Size(30, 30);
            this.btmPAUSE.TabIndex = 2;
            this.btmPAUSE.UseVisualStyleBackColor = true;
            this.btmPAUSE.Click += new System.EventHandler(this.btmPAUSE_Click);
            // 
            // butList
            // 
            this.butList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butList.BackgroundImage")));
            this.butList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butList.Location = new System.Drawing.Point(534, 344);
            this.butList.Name = "butList";
            this.butList.Size = new System.Drawing.Size(26, 26);
            this.butList.TabIndex = 3;
            this.butList.UseVisualStyleBackColor = true;
            this.butList.Click += new System.EventHandler(this.butList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.ElapsedInnerColor = System.Drawing.Color.IndianRed;
            this.slVol.ElapsedOuterColor = System.Drawing.Color.SeaShell;
            this.slVol.LargeChange = ((uint)(5u));
            this.slVol.Location = new System.Drawing.Point(465, 376);
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(95, 24);
            this.slVol.SmallChange = ((uint)(1u));
            this.slVol.TabIndex = 5;
            this.slVol.Text = "colorSlider2";
            this.slVol.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.slVol.Value = 100;
            this.slVol.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVol_Scroll);
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.BarInnerColor = System.Drawing.Color.MediumOrchid;
            this.slTime.BarOuterColor = System.Drawing.Color.Silver;
            this.slTime.BarPenColor = System.Drawing.Color.Honeydew;
            this.slTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.slTime.ElapsedInnerColor = System.Drawing.Color.IndianRed;
            this.slTime.ElapsedOuterColor = System.Drawing.Color.AliceBlue;
            this.slTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.slTime.LargeChange = ((uint)(5u));
            this.slTime.Location = new System.Drawing.Point(64, 343);
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(412, 21);
            this.slTime.SmallChange = ((uint)(1u));
            this.slTime.TabIndex = 4;
            this.slTime.Text = "colorSlider1";
            this.slTime.ThumbInnerColor = System.Drawing.Color.CornflowerBlue;
            this.slTime.ThumbOuterColor = System.Drawing.Color.MidnightBlue;
            this.slTime.ThumbRoundRectSize = new System.Drawing.Size(6, 4);
            this.slTime.ThumbSize = 12;
            this.slTime.Value = 0;
            this.slTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btmSTOP
            // 
            this.btmSTOP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btmSTOP.BackgroundImage")));
            this.btmSTOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmSTOP.Location = new System.Drawing.Point(194, 370);
            this.btmSTOP.Name = "btmSTOP";
            this.btmSTOP.Size = new System.Drawing.Size(30, 30);
            this.btmSTOP.TabIndex = 8;
            this.btmSTOP.UseVisualStyleBackColor = true;
            this.btmSTOP.Click += new System.EventHandler(this.btmSTOP_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(228, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 280);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.Artist.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Artist.Location = new System.Drawing.Point(228, 308);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(115, 20);
            this.Artist.TabIndex = 11;
            this.Artist.Text = "Unknown artist";
            // 
            // Name_file
            // 
            this.Name_file.AutoSize = true;
            this.Name_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_file.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name_file.Location = new System.Drawing.Point(229, 328);
            this.Name_file.Name = "Name_file";
            this.Name_file.Size = new System.Drawing.Size(101, 17);
            this.Name_file.TabIndex = 12;
            this.Name_file.Text = "Unknown song";
            // 
            // next
            // 
            this.next.BackgroundImage = global::player.Properties.Resources.next;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Location = new System.Drawing.Point(226, 370);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(30, 30);
            this.next.TabIndex = 13;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Prev
            // 
            this.Prev.BackgroundImage = global::player.Properties.Resources.prev;
            this.Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prev.Location = new System.Drawing.Point(92, 370);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(30, 30);
            this.Prev.TabIndex = 14;
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Reload
            // 
            this.Reload.BackgroundImage = global::player.Properties.Resources.reload;
            this.Reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reload.Location = new System.Drawing.Point(337, 370);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(30, 30);
            this.Reload.TabIndex = 16;
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // random
            // 
            this.random.BackgroundImage = global::player.Properties.Resources.random;
            this.random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.random.Location = new System.Drawing.Point(305, 370);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(30, 30);
            this.random.TabIndex = 17;
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // VolumeOn
            // 
            this.VolumeOn.BackgroundImage = global::player.Properties.Resources.VolumeOm;
            this.VolumeOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeOn.Location = new System.Drawing.Point(429, 370);
            this.VolumeOn.Name = "VolumeOn";
            this.VolumeOn.Size = new System.Drawing.Size(30, 30);
            this.VolumeOn.TabIndex = 18;
            this.VolumeOn.UseVisualStyleBackColor = true;
            this.VolumeOn.Click += new System.EventHandler(this.VolumeOn_Click);
            // 
            // VolumeOff
            // 
            this.VolumeOff.BackgroundImage = global::player.Properties.Resources.VolumeOff;
            this.VolumeOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeOff.Location = new System.Drawing.Point(401, 370);
            this.VolumeOff.Name = "VolumeOff";
            this.VolumeOff.Size = new System.Drawing.Size(30, 30);
            this.VolumeOff.TabIndex = 19;
            this.VolumeOff.UseVisualStyleBackColor = true;
            this.VolumeOff.Click += new System.EventHandler(this.VolumeOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.VolumeOff);
            this.Controls.Add(this.VolumeOn);
            this.Controls.Add(this.random);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Name_file);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btmSTOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.slTime);
            this.Controls.Add(this.butList);
            this.Controls.Add(this.btmPAUSE);
            this.Controls.Add(this.btmPLAY);
            this.Controls.Add(this.playlist);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maine player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Button btmPLAY;
        private System.Windows.Forms.Button btmPAUSE;
        private System.Windows.Forms.Button butList;
        private MB.Controls.ColorSlider slTime;
        private MB.Controls.ColorSlider slVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btmSTOP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Name_file;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button VolumeOn;
        private System.Windows.Forms.Button VolumeOff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видалитиВсеToolStripMenuItem;
    }
}

