namespace Cinema
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сеансыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.купитьБилетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокФильмовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCoral;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(35, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сеансыToolStripMenuItem,
            this.купитьБилетыToolStripMenuItem,
            this.списокФильмовToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 52);
            this.menuStrip1.TabIndex = 135;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сеансыToolStripMenuItem
            // 
            this.сеансыToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.сеансыToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сеансыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.сеансыToolStripMenuItem.Name = "сеансыToolStripMenuItem";
            this.сеансыToolStripMenuItem.Size = new System.Drawing.Size(134, 46);
            this.сеансыToolStripMenuItem.Text = "Фильмы";
            // 
            // купитьБилетыToolStripMenuItem
            // 
            this.купитьБилетыToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.купитьБилетыToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.купитьБилетыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.купитьБилетыToolStripMenuItem.Name = "купитьБилетыToolStripMenuItem";
            this.купитьБилетыToolStripMenuItem.Size = new System.Drawing.Size(167, 46);
            this.купитьБилетыToolStripMenuItem.Text = "Расписание";
            this.купитьБилетыToolStripMenuItem.Click += new System.EventHandler(this.купитьБилетыToolStripMenuItem_Click);
            // 
            // списокФильмовToolStripMenuItem
            // 
            this.списокФильмовToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.списокФильмовToolStripMenuItem.Name = "списокФильмовToolStripMenuItem";
            this.списокФильмовToolStripMenuItem.Size = new System.Drawing.Size(193, 46);
            this.списокФильмовToolStripMenuItem.Text = "О кинотеатре";
            this.списокФильмовToolStripMenuItem.Click += new System.EventHandler(this.списокФильмовToolStripMenuItem_Click);
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(236, 46);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(882, 808);
            this.flowLayoutPanel1.TabIndex = 137;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(882, 860);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(698, 545);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem купитьБилетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокФильмовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}