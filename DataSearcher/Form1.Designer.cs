namespace DataSearcher
{
    partial class Form1
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_containg_files = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRootFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSearchedKeyWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(12, 80);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_browse);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.txt_directory);
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            this.splitContainer2.Panel1.Controls.Add(this.label_containg_files);
            this.splitContainer2.Panel1.Controls.Add(this.btn_search);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_Keyword);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_result);
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Size = new System.Drawing.Size(972, 604);
            this.splitContainer2.SplitterDistance = 483;
            this.splitContainer2.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(336, 155);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 10;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Select Folder";
            // 
            // txt_directory
            // 
            this.txt_directory.Location = new System.Drawing.Point(27, 155);
            this.txt_directory.Name = "txt_directory";
            this.txt_directory.ReadOnly = true;
            this.txt_directory.Size = new System.Drawing.Size(303, 20);
            this.txt_directory.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 233);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(468, 368);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listview1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No";
            this.columnHeader4.Width = 33;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "File Name";
            this.columnHeader5.Width = 188;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Size(kb)";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Matches Found";
            this.columnHeader7.Width = 180;
            // 
            // label_containg_files
            // 
            this.label_containg_files.AutoSize = true;
            this.label_containg_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_containg_files.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_containg_files.Location = new System.Drawing.Point(24, 206);
            this.label_containg_files.Name = "label_containg_files";
            this.label_containg_files.Size = new System.Drawing.Size(169, 15);
            this.label_containg_files.TabIndex = 6;
            this.label_containg_files.Text = "Files Containing Keyword";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(336, 103);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(69, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(27, 103);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(303, 20);
            this.txt_Keyword.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Insert Key Word";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recent Files";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Result for clicked items";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(3, 44);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_result.Size = new System.Drawing.Size(479, 557);
            this.textBox_result.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeRootFolderToolStripMenuItem,
            this.saveSearchedKeyWordToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeRootFolderToolStripMenuItem
            // 
            this.changeRootFolderToolStripMenuItem.Name = "changeRootFolderToolStripMenuItem";
            this.changeRootFolderToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.changeRootFolderToolStripMenuItem.Text = "Change Root Folder";
            // 
            // saveSearchedKeyWordToolStripMenuItem
            // 
            this.saveSearchedKeyWordToolStripMenuItem.Name = "saveSearchedKeyWordToolStripMenuItem";
            this.saveSearchedKeyWordToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveSearchedKeyWordToolStripMenuItem.Text = "Save searched key word";
            this.saveSearchedKeyWordToolStripMenuItem.Click += new System.EventHandler(this.saveSearchedKeyWordToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(986, 696);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRecent;
        private System.Windows.Forms.Label lbRecent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.ListView listView_result;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label_containg_files;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txt_directory;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRootFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSearchedKeyWordToolStripMenuItem;
    }
}

