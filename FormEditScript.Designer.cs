
namespace Engine
{
    partial class FormEditScript
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
            this.tb_EditScript = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_EditScript
            // 
            this.tb_EditScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_EditScript.Font = new System.Drawing.Font("Modern No. 20", 11.95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EditScript.Location = new System.Drawing.Point(0, 0);
            this.tb_EditScript.Name = "tb_EditScript";
            this.tb_EditScript.Size = new System.Drawing.Size(800, 450);
            this.tb_EditScript.TabIndex = 0;
            this.tb_EditScript.TabStop = false;
            this.tb_EditScript.Text = "Edit";
            this.tb_EditScript.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEditScript_KeyPress);
            // 
            // FormEditScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_EditScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEditScript";
            this.Text = "FormEditScript";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClose);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormEditScript_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_EditScript;
    }
}