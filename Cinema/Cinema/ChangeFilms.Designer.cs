namespace Cinema
{
    partial class ChangeFilms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFilm = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReting = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRelizeDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new Cinema.CinemaDataSet();
            this.filmTableAdapter = new Cinema.CinemaDataSetTableAdapters.FilmTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.txtFilm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDuration, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 22);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 0, 22);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoto, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.txtReting, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.txtDirector, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtRelizeDate, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGenre, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 24;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1312, 1050);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.button3.Location = new System.Drawing.Point(647, 1187);
            this.button3.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(650, 57);
            this.button3.TabIndex = 39;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.SetColumnSpan(this.button2, 2);
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.button2.Location = new System.Drawing.Point(15, 1187);
            this.button2.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(602, 57);
            this.button2.TabIndex = 36;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFilm
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtFilm, 2);
            this.txtFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilm.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFilm.FormattingEnabled = true;
            this.txtFilm.Location = new System.Drawing.Point(15, 132);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(602, 43);
            this.txtFilm.TabIndex = 35;
            this.txtFilm.SelectedIndexChanged += new System.EventHandler(this.txtFilm_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 42);
            this.label11.TabIndex = 34;
            this.label11.Text = "Номер фильма";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDuration, 2);
            this.txtDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDuration.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.txtDuration.Location = new System.Drawing.Point(15, 1122);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDuration.Size = new System.Drawing.Size(602, 43);
            this.txtDuration.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(15, 1075);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 42);
            this.label10.TabIndex = 32;
            this.label10.Text = "Продолжительность";
            // 
            // txtCountry
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCountry, 2);
            this.txtCountry.DisplayMember = "Name";
            this.txtCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCountry.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCountry.FormattingEnabled = true;
            this.txtCountry.Location = new System.Drawing.Point(15, 597);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(602, 43);
            this.txtCountry.TabIndex = 31;
            this.txtCountry.ValueMember = "Name";
            this.txtCountry.SelectedIndexChanged += new System.EventHandler(this.txtCountry_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.button1.Location = new System.Drawing.Point(647, 1264);
            this.button1.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(650, 57);
            this.button1.TabIndex = 30;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 2);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.btnReg.Location = new System.Drawing.Point(15, 1264);
            this.btnReg.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(602, 57);
            this.btnReg.TabIndex = 28;
            this.btnReg.Text = "Добавить";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPhoto, 2);
            this.txtPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoto.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.txtPhoto.Location = new System.Drawing.Point(15, 1017);
            this.txtPhoto.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPhoto.Size = new System.Drawing.Size(602, 43);
            this.txtPhoto.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 970);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 42);
            this.label9.TabIndex = 26;
            this.label9.Text = "Фотография";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtReting
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtReting, 2);
            this.txtReting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReting.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtReting.FormattingEnabled = true;
            this.txtReting.Location = new System.Drawing.Point(15, 912);
            this.txtReting.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtReting.Name = "txtReting";
            this.txtReting.Size = new System.Drawing.Size(602, 43);
            this.txtReting.TabIndex = 25;
            this.txtReting.SelectedIndexChanged += new System.EventHandler(this.txtReting_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 865);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 42);
            this.label8.TabIndex = 24;
            this.label8.Text = "Рейтинг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 760);
            this.label6.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 42);
            this.label6.TabIndex = 22;
            this.label6.Text = "Жанр";
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDirector, 2);
            this.txtDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDirector.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.txtDirector.Location = new System.Drawing.Point(15, 702);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(602, 43);
            this.txtDirector.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 655);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 42);
            this.label5.TabIndex = 20;
            this.label5.Text = "Режиссер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 550);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 42);
            this.label4.TabIndex = 18;
            this.label4.Text = "Страна";
            // 
            // txtRelizeDate
            // 
            this.txtRelizeDate.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtRelizeDate, 2);
            this.txtRelizeDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelizeDate.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.txtRelizeDate.Location = new System.Drawing.Point(15, 492);
            this.txtRelizeDate.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtRelizeDate.Name = "txtRelizeDate";
            this.txtRelizeDate.Size = new System.Drawing.Size(602, 43);
            this.txtRelizeDate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 445);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 42);
            this.label3.TabIndex = 16;
            this.label3.Text = "Год выхода";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.txtDescription.Location = new System.Drawing.Point(15, 342);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(602, 90);
            this.txtDescription.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Описание";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.txtName, 2);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            this.txtName.Location = new System.Drawing.Point(15, 237);
            this.txtName.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(602, 43);
            this.txtName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15);
            this.label1.Size = new System.Drawing.Size(1292, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Изменение данных о фильмах";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtGenre, 2);
            this.txtGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGenre.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGenre.FormattingEnabled = true;
            this.txtGenre.Location = new System.Drawing.Point(15, 807);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(602, 43);
            this.txtGenre.TabIndex = 23;
            this.txtGenre.SelectedIndexChanged += new System.EventHandler(this.txtGenre_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.countryIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.genreIDDataGridViewTextBoxColumn,
            this.ratingIDDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dataGridViewImageColumn1});
            this.dataGridView1.DataSource = this.filmBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Banner", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(647, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 20);
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 1065);
            this.dataGridView1.TabIndex = 29;
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            this.filmIDDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.filmIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            this.filmIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FilmDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Год выхода";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            this.countryIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn4.HeaderText = "Режиссер";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // genreIDDataGridViewTextBoxColumn
            // 
            this.genreIDDataGridViewTextBoxColumn.DataPropertyName = "GenreID";
            this.genreIDDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.genreIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreIDDataGridViewTextBoxColumn.Name = "genreIDDataGridViewTextBoxColumn";
            this.genreIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ratingIDDataGridViewTextBoxColumn
            // 
            this.ratingIDDataGridViewTextBoxColumn.DataPropertyName = "RatingID";
            this.ratingIDDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.ratingIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ratingIDDataGridViewTextBoxColumn.Name = "ratingIDDataGridViewTextBoxColumn";
            this.ratingIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Фото";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.cinemaDataSet;
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // ChangeFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1312, 1050);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChangeFilms";
            this.Text = "Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeFilms_FormClosed_1);
            this.Load += new System.EventHandler(this.ChangeFilms_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRelizeDate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtGenre;
        public System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtReting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox txtCountry;
        public System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label10;
        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private CinemaDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.ComboBox txtFilm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}