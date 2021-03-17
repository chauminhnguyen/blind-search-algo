namespace BlindSearchAlgorithm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DFS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Line_End = new System.Windows.Forms.TextBox();
            this.Line_Start = new System.Windows.Forms.TextBox();
            this.All = new System.Windows.Forms.TextBox();
            this.BFS_Line = new System.Windows.Forms.Button();
            this.BFS = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.DFS_Line = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graph1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graph2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graph3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graph4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.result = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Table = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DFS
            // 
            this.DFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.DFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.DFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.DFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.DFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DFS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFS.ForeColor = System.Drawing.Color.White;
            this.DFS.Location = new System.Drawing.Point(15, 95);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(170, 51);
            this.DFS.TabIndex = 0;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = false;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(72)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 56);
            this.panel1.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(1013, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.TabIndex = 6;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Written By: Nguyen Minh Chau";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Blind Search Algorithm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "result";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Line_End);
            this.panel2.Controls.Add(this.Line_Start);
            this.panel2.Controls.Add(this.All);
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.DFS_Line);
            this.panel2.Controls.Add(this.DFS);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.BFS);
            this.panel2.Controls.Add(this.BFS_Line);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 503);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(38, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "End";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Start";
            // 
            // Line_End
            // 
            this.Line_End.Location = new System.Drawing.Point(85, 294);
            this.Line_End.Name = "Line_End";
            this.Line_End.Size = new System.Drawing.Size(100, 20);
            this.Line_End.TabIndex = 15;
            // 
            // Line_Start
            // 
            this.Line_Start.Location = new System.Drawing.Point(85, 259);
            this.Line_Start.Name = "Line_Start";
            this.Line_Start.Size = new System.Drawing.Size(100, 20);
            this.Line_Start.TabIndex = 14;
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(85, 63);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(100, 20);
            this.All.TabIndex = 13;
            // 
            // BFS_Line
            // 
            this.BFS_Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.BFS_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFS_Line.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.BFS_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.BFS_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.BFS_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFS_Line.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFS_Line.ForeColor = System.Drawing.Color.White;
            this.BFS_Line.Location = new System.Drawing.Point(15, 387);
            this.BFS_Line.Name = "BFS_Line";
            this.BFS_Line.Size = new System.Drawing.Size(170, 51);
            this.BFS_Line.TabIndex = 6;
            this.BFS_Line.Text = "BFS Line";
            this.BFS_Line.UseVisualStyleBackColor = false;
            this.BFS_Line.Click += new System.EventHandler(this.BFS_Line_Click);
            // 
            // BFS
            // 
            this.BFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.BFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.BFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.BFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.BFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFS.ForeColor = System.Drawing.Color.White;
            this.BFS.Location = new System.Drawing.Point(15, 152);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(170, 51);
            this.BFS.TabIndex = 7;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = false;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(15, 95);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 51);
            this.SidePanel.TabIndex = 3;
            // 
            // DFS_Line
            // 
            this.DFS_Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.DFS_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DFS_Line.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.DFS_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.DFS_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.DFS_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DFS_Line.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFS_Line.ForeColor = System.Drawing.Color.White;
            this.DFS_Line.Location = new System.Drawing.Point(15, 330);
            this.DFS_Line.Name = "DFS_Line";
            this.DFS_Line.Size = new System.Drawing.Size(170, 51);
            this.DFS_Line.TabIndex = 0;
            this.DFS_Line.Text = "DFS Line";
            this.DFS_Line.UseVisualStyleBackColor = false;
            this.DFS_Line.Click += new System.EventHandler(this.DFS_Line_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graph1ToolStripMenuItem,
            this.graph2ToolStripMenuItem,
            this.graph3ToolStripMenuItem,
            this.graph4ToolStripMenuItem});
            this.graphToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // graph1ToolStripMenuItem
            // 
            this.graph1ToolStripMenuItem.Name = "graph1ToolStripMenuItem";
            this.graph1ToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.graph1ToolStripMenuItem.Text = "Graph 1";
            this.graph1ToolStripMenuItem.Click += new System.EventHandler(this.graph1ToolStripMenuItem_Click);
            // 
            // graph2ToolStripMenuItem
            // 
            this.graph2ToolStripMenuItem.Name = "graph2ToolStripMenuItem";
            this.graph2ToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.graph2ToolStripMenuItem.Text = "Graph 2";
            this.graph2ToolStripMenuItem.Click += new System.EventHandler(this.graph2ToolStripMenuItem_Click);
            // 
            // graph3ToolStripMenuItem
            // 
            this.graph3ToolStripMenuItem.Name = "graph3ToolStripMenuItem";
            this.graph3ToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.graph3ToolStripMenuItem.Text = "Graph 3";
            this.graph3ToolStripMenuItem.Click += new System.EventHandler(this.graph3ToolStripMenuItem_Click);
            // 
            // graph4ToolStripMenuItem
            // 
            this.graph4ToolStripMenuItem.Name = "graph4ToolStripMenuItem";
            this.graph4ToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.graph4ToolStripMenuItem.Text = "Graph 4";
            this.graph4ToolStripMenuItem.Click += new System.EventHandler(this.graph4ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(163, 63);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(598, 32);
            this.result.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 292);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(617, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(207, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table.ForeColor = System.Drawing.Color.White;
            this.Table.Location = new System.Drawing.Point(383, 224);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(47, 20);
            this.Table.TabIndex = 8;
            this.Table.Text = "Table";
            // 
            // Graph
            // 
            this.Graph.AutoSize = true;
            this.Graph.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graph.ForeColor = System.Drawing.Color.White;
            this.Graph.Location = new System.Drawing.Point(808, 224);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(56, 20);
            this.Graph.TabIndex = 9;
            this.Graph.Text = "Graph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1050, 559);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DFS;
        private System.Windows.Forms.Panel panel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DFS_Line;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button BFS_Line;
        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graph1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graph2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graph3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graph4ToolStripMenuItem;
        private System.Windows.Forms.Label Graph;
        private System.Windows.Forms.Label Table;
        private System.Windows.Forms.TextBox Line_End;
        private System.Windows.Forms.TextBox Line_Start;
        private System.Windows.Forms.TextBox All;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

