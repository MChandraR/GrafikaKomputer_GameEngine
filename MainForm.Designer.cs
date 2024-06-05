
namespace Engine
{
    partial class Parent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.List = new System.Windows.Forms.DataGridView();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddObject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_texture = new System.Windows.Forms.Button();
            this.btn_addAudio = new System.Windows.Forms.Button();
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.cb_texture = new System.Windows.Forms.ComboBox();
            this.cb_audio = new System.Windows.Forms.ComboBox();
            this.cb_collision = new System.Windows.Forms.CheckBox();
            this.cb_absolute = new System.Windows.Forms.CheckBox();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.cb_Tipe = new System.Windows.Forms.ComboBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.tb_YSize = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_XSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Gravity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.panel4 = new System.Windows.Forms.Panel();
            this.refresh_Btn = new System.Windows.Forms.Button();
            this.btn_EditScript = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.assetPanel = new System.Windows.Forms.Panel();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_HapusObject = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_loop = new System.Windows.Forms.CheckBox();
            this.cb_playstart = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.assetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.List);
            this.panel1.Location = new System.Drawing.Point(16, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 448);
            this.panel1.TabIndex = 1;
            // 
            // List
            // 
            this.List.AllowUserToAddRows = false;
            this.List.AllowUserToDeleteRows = false;
            this.List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Object,
            this.ID});
            this.List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List.Location = new System.Drawing.Point(0, 0);
            this.List.Name = "List";
            this.List.ReadOnly = true;
            this.List.RowHeadersVisible = false;
            this.List.Size = new System.Drawing.Size(215, 448);
            this.List.TabIndex = 0;
            this.List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_CellClick);
            // 
            // Object
            // 
            this.Object.HeaderText = "Object";
            this.Object.Name = "Object";
            this.Object.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // AddObject
            // 
            this.AddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddObject.Location = new System.Drawing.Point(194, 26);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(33, 24);
            this.AddObject.TabIndex = 2;
            this.AddObject.Text = "+";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Object";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btn_texture);
            this.panel2.Controls.Add(this.btn_addAudio);
            this.panel2.Controls.Add(this.tb_volume);
            this.panel2.Controls.Add(this.track_volume);
            this.panel2.Controls.Add(this.cb_texture);
            this.panel2.Controls.Add(this.cb_audio);
            this.panel2.Controls.Add(this.cb_playstart);
            this.panel2.Controls.Add(this.cb_collision);
            this.panel2.Controls.Add(this.cb_loop);
            this.panel2.Controls.Add(this.cb_absolute);
            this.panel2.Controls.Add(this.cb_color);
            this.panel2.Controls.Add(this.cb_Tipe);
            this.panel2.Controls.Add(this.bt_reset);
            this.panel2.Controls.Add(this.btn_Simpan);
            this.panel2.Controls.Add(this.tb_YSize);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tb_XSize);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_Gravity);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tb_Y);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_X);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_Name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_ID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1020, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 467);
            this.panel2.TabIndex = 4;
            // 
            // btn_texture
            // 
            this.btn_texture.Location = new System.Drawing.Point(194, 383);
            this.btn_texture.Name = "btn_texture";
            this.btn_texture.Size = new System.Drawing.Size(27, 23);
            this.btn_texture.TabIndex = 9;
            this.btn_texture.Text = "+";
            this.btn_texture.UseVisualStyleBackColor = true;
            this.btn_texture.Click += new System.EventHandler(this.btn_texture_Click);
            // 
            // btn_addAudio
            // 
            this.btn_addAudio.Location = new System.Drawing.Point(197, 308);
            this.btn_addAudio.Name = "btn_addAudio";
            this.btn_addAudio.Size = new System.Drawing.Size(27, 23);
            this.btn_addAudio.TabIndex = 9;
            this.btn_addAudio.Text = "+";
            this.btn_addAudio.UseVisualStyleBackColor = true;
            this.btn_addAudio.Click += new System.EventHandler(this.btn_addAudio_Click);
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(197, 343);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(24, 20);
            this.tb_volume.TabIndex = 8;
            this.tb_volume.TextChanged += new System.EventHandler(this.tb_volume_TextChanged);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(43, 343);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(151, 45);
            this.track_volume.TabIndex = 7;
            this.track_volume.ValueChanged += new System.EventHandler(this.track_volume_ValueChanged);
            // 
            // cb_texture
            // 
            this.cb_texture.FormattingEnabled = true;
            this.cb_texture.Location = new System.Drawing.Point(52, 385);
            this.cb_texture.Name = "cb_texture";
            this.cb_texture.Size = new System.Drawing.Size(136, 21);
            this.cb_texture.TabIndex = 6;
            this.cb_texture.SelectedIndexChanged += new System.EventHandler(this.cb_texture_SelectedIndexChanged);
            // 
            // cb_audio
            // 
            this.cb_audio.FormattingEnabled = true;
            this.cb_audio.Location = new System.Drawing.Point(52, 308);
            this.cb_audio.Name = "cb_audio";
            this.cb_audio.Size = new System.Drawing.Size(139, 21);
            this.cb_audio.TabIndex = 6;
            // 
            // cb_collision
            // 
            this.cb_collision.AutoSize = true;
            this.cb_collision.Location = new System.Drawing.Point(70, 258);
            this.cb_collision.Name = "cb_collision";
            this.cb_collision.Size = new System.Drawing.Size(48, 17);
            this.cb_collision.TabIndex = 5;
            this.cb_collision.Text = "false";
            this.cb_collision.UseVisualStyleBackColor = true;
            this.cb_collision.CheckedChanged += new System.EventHandler(this.cb_collision_CheckedChanged);
            // 
            // cb_absolute
            // 
            this.cb_absolute.AutoSize = true;
            this.cb_absolute.Location = new System.Drawing.Point(70, 231);
            this.cb_absolute.Name = "cb_absolute";
            this.cb_absolute.Size = new System.Drawing.Size(48, 17);
            this.cb_absolute.TabIndex = 5;
            this.cb_absolute.Text = "false";
            this.cb_absolute.UseVisualStyleBackColor = true;
            this.cb_absolute.CheckedChanged += new System.EventHandler(this.cb_absolute_CheckedChanged);
            // 
            // cb_color
            // 
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Yellow",
            "Black",
            "White"});
            this.cb_color.Location = new System.Drawing.Point(53, 281);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(168, 21);
            this.cb_color.TabIndex = 4;
            // 
            // cb_Tipe
            // 
            this.cb_Tipe.FormattingEnabled = true;
            this.cb_Tipe.Items.AddRange(new object[] {
            "Lingkaran\t",
            "Rectangle",
            "Segitiga"});
            this.cb_Tipe.Location = new System.Drawing.Point(54, 171);
            this.cb_Tipe.Name = "cb_Tipe";
            this.cb_Tipe.Size = new System.Drawing.Size(168, 21);
            this.cb_Tipe.TabIndex = 4;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(54, 423);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(68, 32);
            this.bt_reset.TabIndex = 3;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(129, 423);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(68, 32);
            this.btn_Simpan.TabIndex = 3;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // tb_YSize
            // 
            this.tb_YSize.Location = new System.Drawing.Point(142, 145);
            this.tb_YSize.Name = "tb_YSize";
            this.tb_YSize.Size = new System.Drawing.Size(82, 20);
            this.tb_YSize.TabIndex = 2;
            this.tb_YSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(7, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Volume";
            this.label15.Click += new System.EventHandler(this.label8_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(8, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Texture";
            this.label16.Click += new System.EventHandler(this.label8_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(7, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Audio";
            this.label14.Click += new System.EventHandler(this.label8_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(7, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Color";
            this.label13.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_XSize
            // 
            this.tb_XSize.Location = new System.Drawing.Point(54, 145);
            this.tb_XSize.Name = "tb_XSize";
            this.tb_XSize.Size = new System.Drawing.Size(82, 20);
            this.tb_XSize.TabIndex = 2;
            this.tb_XSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(8, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tipe";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Size";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_Gravity
            // 
            this.tb_Gravity.Location = new System.Drawing.Point(54, 199);
            this.tb_Gravity.Name = "tb_Gravity";
            this.tb_Gravity.Size = new System.Drawing.Size(168, 20);
            this.tb_Gravity.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(8, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Collision";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(8, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Absolute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(8, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gravity";
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(54, 119);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(168, 20);
            this.tb_Y.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(54, 93);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(168, 20);
            this.tb_X.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(54, 67);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(168, 20);
            this.tb_Name.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(54, 41);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(168, 20);
            this.tb_ID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Properti";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(262, 511);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.TabIndex = 5;
            this.test.Text = "label3";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Browser);
            this.panel3.Location = new System.Drawing.Point(265, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 467);
            this.panel3.TabIndex = 6;
            // 
            // Browser
            // 
            this.Browser.ActivateBrowserOnCreation = false;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(723, 467);
            this.Browser.TabIndex = 0;
            this.Browser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.Browser_LoadingStateChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.refresh_Btn);
            this.panel4.Controls.Add(this.btn_EditScript);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(16, 527);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 149);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // refresh_Btn
            // 
            this.refresh_Btn.Location = new System.Drawing.Point(7, 33);
            this.refresh_Btn.Name = "refresh_Btn";
            this.refresh_Btn.Size = new System.Drawing.Size(60, 26);
            this.refresh_Btn.TabIndex = 9;
            this.refresh_Btn.Text = "Refresh";
            this.refresh_Btn.UseVisualStyleBackColor = true;
            this.refresh_Btn.Click += new System.EventHandler(this.refresh_Btn_Click);
            // 
            // btn_EditScript
            // 
            this.btn_EditScript.Location = new System.Drawing.Point(100, 97);
            this.btn_EditScript.Name = "btn_EditScript";
            this.btn_EditScript.Size = new System.Drawing.Size(88, 33);
            this.btn_EditScript.TabIndex = 0;
            this.btn_EditScript.Text = "Edit Script";
            this.btn_EditScript.UseVisualStyleBackColor = true;
            this.btn_EditScript.Click += new System.EventHandler(this.btn_EditScript_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current WorkFolder";
            // 
            // assetPanel
            // 
            this.assetPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.assetPanel.Controls.Add(this.flowPanel);
            this.assetPanel.Location = new System.Drawing.Point(265, 527);
            this.assetPanel.Name = "assetPanel";
            this.assetPanel.Size = new System.Drawing.Size(977, 149);
            this.assetPanel.TabIndex = 8;
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(20);
            this.flowPanel.Size = new System.Drawing.Size(997, 149);
            this.flowPanel.TabIndex = 0;
            // 
            // btn_HapusObject
            // 
            this.btn_HapusObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HapusObject.Location = new System.Drawing.Point(150, 26);
            this.btn_HapusObject.Name = "btn_HapusObject";
            this.btn_HapusObject.Size = new System.Drawing.Size(33, 24);
            this.btn_HapusObject.TabIndex = 2;
            this.btn_HapusObject.Text = "-";
            this.btn_HapusObject.UseVisualStyleBackColor = true;
            this.btn_HapusObject.Click += new System.EventHandler(this.RemoveObject_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(124, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Loop";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(124, 259);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Play onStart";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // cb_loop
            // 
            this.cb_loop.AutoSize = true;
            this.cb_loop.Location = new System.Drawing.Point(206, 232);
            this.cb_loop.Name = "cb_loop";
            this.cb_loop.Size = new System.Drawing.Size(15, 14);
            this.cb_loop.TabIndex = 5;
            this.cb_loop.UseVisualStyleBackColor = true;
            this.cb_loop.CheckedChanged += new System.EventHandler(this.cb_absolute_CheckedChanged);
            // 
            // cb_playstart
            // 
            this.cb_playstart.AutoSize = true;
            this.cb_playstart.Location = new System.Drawing.Point(206, 259);
            this.cb_playstart.Name = "cb_playstart";
            this.cb_playstart.Size = new System.Drawing.Size(15, 14);
            this.cb_playstart.TabIndex = 5;
            this.cb_playstart.UseVisualStyleBackColor = true;
            this.cb_playstart.CheckedChanged += new System.EventHandler(this.cb_collision_CheckedChanged);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 681);
            this.Controls.Add(this.test);
            this.Controls.Add(this.assetPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_HapusObject);
            this.Controls.Add(this.AddObject);
            this.Controls.Add(this.panel1);
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Engine Grafika Komputer";
            this.Load += new System.EventHandler(this.Parent_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.assetPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.DataGridView List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel assetPanel;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_XSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_YSize;
        private System.Windows.Forms.Button btn_HapusObject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_EditScript;
        private CefSharp.WinForms.ChromiumWebBrowser Browser;
        private System.Windows.Forms.TextBox tb_Gravity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_Tipe;
        private System.Windows.Forms.CheckBox cb_absolute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cb_collision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_audio;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_volume;
        private System.Windows.Forms.Button btn_addAudio;
        private System.Windows.Forms.Button btn_texture;
        private System.Windows.Forms.ComboBox cb_texture;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button refresh_Btn;
        private System.Windows.Forms.CheckBox cb_playstart;
        private System.Windows.Forms.CheckBox cb_loop;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

