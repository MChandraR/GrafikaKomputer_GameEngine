
namespace Engine
{
    partial class ProjectLoader
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
            this.label1 = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project List";
            // 
            // projectList
            // 
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(18, 67);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(455, 342);
            this.projectList.TabIndex = 1;
            this.projectList.DoubleClick += new System.EventHandler(this.projectList_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "New Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.Location = new System.Drawing.Point(649, 67);
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(129, 49);
            this.openProjectBtn.TabIndex = 2;
            this.openProjectBtn.Text = "Open Project";
            this.openProjectBtn.UseVisualStyleBackColor = true;
            this.openProjectBtn.Click += new System.EventHandler(this.openProjectBtn_Click);
            // 
            // ProjectLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openProjectBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.label1);
            this.Name = "ProjectLoader";
            this.Text = "ProjectLoader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox projectList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button openProjectBtn;
    }
}