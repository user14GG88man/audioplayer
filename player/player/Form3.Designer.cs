namespace player
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textList = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddList
            // 
            this.AddList.Location = new System.Drawing.Point(121, 57);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(75, 23);
            this.AddList.TabIndex = 0;
            this.AddList.Text = "Додати";
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ведіть назву вашого списку";
            // 
            // textList
            // 
            this.textList.Location = new System.Drawing.Point(167, 31);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(100, 20);
            this.textList.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(202, 57);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(311, 111);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddList);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textList;
        private System.Windows.Forms.Button Exit;
    }
}