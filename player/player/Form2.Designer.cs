namespace player
{
    partial class Form2
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.AddList = new System.Windows.Forms.Button();
            this.DeleteList = new System.Windows.Forms.Button();
            this.OpenList = new System.Windows.Forms.Button();
            this.List_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(178, 95);
            this.ListBox.TabIndex = 0;
            // 
            // AddList
            // 
            this.AddList.Location = new System.Drawing.Point(12, 113);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(75, 23);
            this.AddList.TabIndex = 1;
            this.AddList.Text = "Add";
            this.AddList.UseVisualStyleBackColor = true;
            this.AddList.Click += new System.EventHandler(this.AddList_Click_1);
            // 
            // DeleteList
            // 
            this.DeleteList.Location = new System.Drawing.Point(93, 113);
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(75, 23);
            this.DeleteList.TabIndex = 2;
            this.DeleteList.Text = "Delete";
            this.DeleteList.UseVisualStyleBackColor = true;
            // 
            // OpenList
            // 
            this.OpenList.Location = new System.Drawing.Point(174, 113);
            this.OpenList.Name = "OpenList";
            this.OpenList.Size = new System.Drawing.Size(75, 23);
            this.OpenList.TabIndex = 3;
            this.OpenList.Text = "Open";
            this.OpenList.UseVisualStyleBackColor = true;
            this.OpenList.Click += new System.EventHandler(this.OpenList_Click);
            // 
            // List_add
            // 
            this.List_add.Location = new System.Drawing.Point(197, 13);
            this.List_add.Name = "List_add";
            this.List_add.Size = new System.Drawing.Size(75, 94);
            this.List_add.TabIndex = 4;
            this.List_add.Text = "Скласти Список";
            this.List_add.UseVisualStyleBackColor = true;
            this.List_add.Click += new System.EventHandler(this.List_add_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(318, 165);
            this.Controls.Add(this.List_add);
            this.Controls.Add(this.OpenList);
            this.Controls.Add(this.DeleteList);
            this.Controls.Add(this.AddList);
            this.Controls.Add(this.ListBox);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button AddList;
        private System.Windows.Forms.Button DeleteList;
        private System.Windows.Forms.Button OpenList;
        private System.Windows.Forms.Button List_add;
    }
}