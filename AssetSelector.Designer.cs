
namespace Engine
{
    partial class AssetSelector
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Item = new System.Windows.Forms.ListBox();
            this.btn_Tambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_Item
            // 
            this.lb_Item.FormattingEnabled = true;
            this.lb_Item.Location = new System.Drawing.Point(12, 38);
            this.lb_Item.Name = "lb_Item";
            this.lb_Item.Size = new System.Drawing.Size(258, 147);
            this.lb_Item.TabIndex = 2;
            // 
            // btn_Tambah
            // 
            this.btn_Tambah.Location = new System.Drawing.Point(112, 192);
            this.btn_Tambah.Name = "btn_Tambah";
            this.btn_Tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_Tambah.TabIndex = 3;
            this.btn_Tambah.Text = "Tambah";
            this.btn_Tambah.UseVisualStyleBackColor = true;
            this.btn_Tambah.Click += new System.EventHandler(this.btn_Tambah_Click);
            // 
            // AssetSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 224);
            this.Controls.Add(this.btn_Tambah);
            this.Controls.Add(this.lb_Item);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AssetSelector";
            this.Text = "AssetSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssetSelector_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssetSelector_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_Item;
        private System.Windows.Forms.Button btn_Tambah;
    }
}