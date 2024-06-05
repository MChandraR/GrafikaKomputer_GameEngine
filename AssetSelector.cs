using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
    public partial class AssetSelector : Form
    {
        public ResourceManager rm;
        public Parent parent;
        public int INSERT_AUDIO = 0, INSERT_TEXTURE = 1;
        public int mode = 0;
        public Dictionary<String, String> asset = new Dictionary<string, string>();
      
        public AssetSelector( Parent parent)
        {
            InitializeComponent();
            this.rm = parent.manager;
            this.parent = parent;
            foreach (ResourceManager.Audio aud in rm.audio)
            {
                lb_Item.Items.Add(aud.judul);
                try
                {
                    asset.Add(aud.judul, aud.path);
                }
                catch (Exception) { }
            }
        }

        private void AssetSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void AssetSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btn_Tambah_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                parent.insertAudio(new GameObject.Source(lb_Item.SelectedItem.ToString(), asset[lb_Item.SelectedItem.ToString()]));
            } else if (mode == 1)
            {
                if (Path.GetExtension(asset[lb_Item.SelectedItem.ToString()]).Contains("png"))
                {
                    parent.insertTexture(new GameObject.Texture.Source(lb_Item.SelectedItem.ToString(), asset[lb_Item.SelectedItem.ToString()]));
                }
                else
                {
                    MessageBox.Show("Format File tidak sesuai !");
                }
            }
        }

    }
}
