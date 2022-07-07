namespace 抽奖程序_v._1._0._0a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.从文件夹打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开创建向导ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startBotten = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从文件夹打开ToolStripMenuItem,
            this.打开创建向导ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "选项";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 从文件夹打开ToolStripMenuItem
            // 
            this.从文件夹打开ToolStripMenuItem.Name = "从文件夹打开ToolStripMenuItem";
            this.从文件夹打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.从文件夹打开ToolStripMenuItem.Text = "从文件夹打开";
            this.从文件夹打开ToolStripMenuItem.Click += new System.EventHandler(this.从文件夹打开ToolStripMenuItem_Click);
            // 
            // 打开创建向导ToolStripMenuItem
            // 
            this.打开创建向导ToolStripMenuItem.Name = "打开创建向导ToolStripMenuItem";
            this.打开创建向导ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开创建向导ToolStripMenuItem.Text = "打开创建向导";
            this.打开创建向导ToolStripMenuItem.Click += new System.EventHandler(this.打开创建向导ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem2.Text = "帮助";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 498);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startBotten
            // 
            this.startBotten.Location = new System.Drawing.Point(574, 460);
            this.startBotten.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.startBotten.Name = "startBotten";
            this.startBotten.Size = new System.Drawing.Size(193, 51);
            this.startBotten.TabIndex = 2;
            this.startBotten.Text = "开抽";
            this.startBotten.UseVisualStyleBackColor = true;
            this.startBotten.Click += new System.EventHandler(this.startBotten_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 527);
            this.Controls.Add(this.startBotten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "抽奖程序 v.1.0.0a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private Label label1;
        private Button startBotten;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 从文件夹打开ToolStripMenuItem;
        private ToolStripMenuItem 打开创建向导ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private OpenFileDialog openFileDialog1;
    }
}