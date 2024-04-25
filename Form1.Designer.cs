
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
            this.cb_Tipe = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.tb_YSize = new System.Windows.Forms.TextBox();
            this.tb_XSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Gravity = new System.Windows.Forms.TextBox();
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
            this.btn_EditScript = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_HapusObject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.cb_Tipe);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_Simpan);
            this.panel2.Controls.Add(this.tb_YSize);
            this.panel2.Controls.Add(this.tb_XSize);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_Gravity);
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
            this.panel2.Location = new System.Drawing.Point(1027, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 467);
            this.panel2.TabIndex = 4;
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
            this.cb_Tipe.Size = new System.Drawing.Size(143, 21);
            this.cb_Tipe.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
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
            this.tb_YSize.Location = new System.Drawing.Point(128, 145);
            this.tb_YSize.Name = "tb_YSize";
            this.tb_YSize.Size = new System.Drawing.Size(68, 20);
            this.tb_YSize.TabIndex = 2;
            this.tb_YSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_XSize
            // 
            this.tb_XSize.Location = new System.Drawing.Point(54, 145);
            this.tb_XSize.Name = "tb_XSize";
            this.tb_XSize.Size = new System.Drawing.Size(68, 20);
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
            this.tb_Gravity.Size = new System.Drawing.Size(143, 20);
            this.tb_Gravity.TabIndex = 2;
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
            this.tb_Y.Size = new System.Drawing.Size(143, 20);
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
            this.tb_X.Size = new System.Drawing.Size(143, 20);
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
            this.tb_Name.Size = new System.Drawing.Size(143, 20);
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
            this.tb_ID.Size = new System.Drawing.Size(143, 20);
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
            this.test.Location = new System.Drawing.Point(25, 34);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.TabIndex = 5;
            this.test.Text = "label3";
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
            this.panel4.Controls.Add(this.btn_EditScript);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(16, 527);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 149);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_EditScript
            // 
            this.btn_EditScript.Location = new System.Drawing.Point(7, 68);
            this.btn_EditScript.Name = "btn_EditScript";
            this.btn_EditScript.Size = new System.Drawing.Size(75, 23);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.test);
            this.panel5.Location = new System.Drawing.Point(265, 527);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(977, 149);
            this.panel5.TabIndex = 8;
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
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel5);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
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
    }
}

