using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public partial class FormEditScript : Form
    {
        static String dir = System.IO.Directory.GetCurrentDirectory();
        string dirName = dir + "/mygame/"; // Ganti dengan path direktori yang diinginkan
        Parent mainForm;

        public FormEditScript(Parent form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void formClose(object sender, FormClosedEventArgs e)
        {
            this.Hide();

        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public RichTextBox getTB()
        {
            return tb_EditScript;
        }

        private void FormEditScript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 19)
            {
                using (StreamWriter writer = new StreamWriter(dirName + "game/scripts/script.js"))
                {
                    writer.Write(tb_EditScript.Text);
                }
                mainForm.loadProject();
                MessageBox.Show("Saved");
            }
        }
    }
}
