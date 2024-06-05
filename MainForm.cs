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
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;

namespace Engine
{
    public partial class Parent : Form
    {
        int targetObject = -1;
        int tipeSelected = 0;
        FormEditScript formEdit;
        String dir = System.IO.Directory.GetCurrentDirectory();
        public string dirName = "";
        public ResourceManager manager;
        AssetSelector selector;

        List<GameObject> gameObjects = new List<GameObject>();
        public Parent(string path)
        {
            dirName = path;
            formEdit = new FormEditScript(this);
            InitializeComponent();
            Browser.Load(dirName + "/index.html");
            Browser.ConsoleMessage += browser_ConsoleMessage;
            test.Text = dir ;
            loadProject();
            refreshAsset();
            selector = new AssetSelector(this);
          /*  foreach (String file in manager.listOfFolder)
            {
                Panel panel = new Panel();
                PictureBox btn = new PictureBox();
                Label label = new Label();
                label.Text = Path.GetDirectoryName(file);
                btn.Image =  Image.FromFile("data/asset/images/folder.png");
                btn.Click += new EventHandler(this.MyButtonHandler);
                btn.Width = 50;
                btn.Height = 50;
                btn.Text = "hallo";
                label.Location = new Point(0, btn.Height);
                panel.Controls.Add(btn);
                panel.Width = btn.Width ;
                panel.Controls.Add(label);
                flowPanel.Controls.Add(panel);
            }*/

            

            try
            {
                using (StreamReader configReader = new StreamReader(dirName + "/game/object.json"))
                {
                    gameObjects = JsonConvert.DeserializeObject<List<GameObject>>(configReader.ReadToEnd());
                    foreach (GameObject obj in gameObjects)
                    {
                        List.Rows.Add(obj.name, gameObjects.Count);
                    }
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        void setUp()
        {

        }

        void MyButtonHandler(object sender, EventArgs e){
            MessageBox.Show("hallo");
        }

        public void loadProject(){

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        float post = 0f;
        private void AddObject_Click(object sender, EventArgs e)
        {
            GameObject newObj = new GameObject(gameObjects.Count.ToString(), "Game Object " + gameObjects.Count.ToString(), "1", post, 5f, 100f, 50f,1, "0", 1, 1, 0, 1);
            gameObjects.Add(newObj);
            List.Rows.Add(newObj.name, gameObjects.Count);
            loadGame();
            
        }

        private void RemoveObject_Click(object sender, EventArgs e)
        {
            if (targetObject < 0 || targetObject >= gameObjects.Count) return;
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus ? ", "Yakin",  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) {
                gameObjects.RemoveAt(targetObject);
                List.Rows.RemoveAt(targetObject);
            }
            loadGame();
        }

        private void loadGame()
        {

            if (!Directory.Exists(dirName + "/game")){
                Directory.CreateDirectory(dirName + "/game");
                Console.WriteLine("Folder tujuan berhasil dibuat:");
            }
            if (!Directory.Exists(dirName + "/game/scenes")) {
                Directory.CreateDirectory(dirName + "/game/scenes");
                Console.WriteLine("Folder tujuan berhasil dibuat:");
            }
            if (!Directory.Exists(dirName + "/game/scripts")){
                Directory.CreateDirectory(dirName + "/game/scripts");
            }
            if (!Directory.Exists(dirName + "/game/objects")){
                Directory.CreateDirectory(dirName + "/game/objects");
                Console.WriteLine("Folder tujuan berhasil dibuat:");
            }

            CopyFile("data/index.html", dirName + "/index.html");
            if (!File.Exists(dirName + "/game/scripts/script.js")) CopyFile("data/game/scripts/script.js", dirName + "/game/scripts/script.js");
            CopyFile("data/game/objects/object.js", dirName + "/game/objects/object.js");
            CopyFile("data/game/objects/transform.js", dirName + "/game/objects/transform.js");

            string core = "";
            using (StreamReader reader = new StreamReader("data/core.js"))
            {
                core = reader.ReadToEnd();
                string canvas = "";
                using (StreamReader canvasReader = new StreamReader("data/game/canvas.js"))
                {
                    using (StreamReader configReader = new StreamReader("data/game/config.js"))
                    {
                        canvas = canvasReader.ReadToEnd();
                        canvas = canvas.Replace("$config", configReader.ReadToEnd());
                    }
                }
                using (StreamReader sceneReader = new StreamReader("data/game/scenes/mainScenes.js"))
                {
                    string scene = sceneReader.ReadToEnd();
                    scene = scene.Replace("$canvas", canvas);
                    using (StreamReader gameObjectReader = new StreamReader("data/game/objects/gameobjects.js"))
                    {
                        scene = scene.Replace("$gameObject", gameObjectReader.ReadToEnd());
                    }
                    using (StreamReader inputReader = new StreamReader("data/game/input.js"))
                    {
                        scene = scene.Replace("$inputs", inputReader.ReadToEnd());
                    }
                    using (StreamReader objectReader = new StreamReader("data/game/objects/object.js"))
                    {
                        scene = scene.Replace("$objects", objectReader.ReadToEnd());
                        using (StreamReader transformReader = new StreamReader("data/game/objects/transform.js"))
                        {
                            scene = scene.Replace("$transform", transformReader.ReadToEnd());
                        }
                        using (StreamReader scriptReader = new StreamReader(dirName + "/game/scripts/script.js"))
                        {
                            scene = scene.Replace("$script", scriptReader.ReadToEnd());
                        }
                    }

                    core = core.Replace("$mainScene", scene);
                    core = core.Replace("$object", JsonConvert.SerializeObject(gameObjects));
                }

            }

            using (StreamWriter writer = new StreamWriter(dirName + "/core.js"))
            {
                writer.Write(core);
            }

            using (StreamWriter writer = new StreamWriter(dirName + "/game/object.json"))
            {
                writer.Write(JsonConvert.SerializeObject(gameObjects));
            }


            Console.WriteLine("Proses selesai.");
            Browser.Load(dirName + "/index.html");
        }

        private void open(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo");
        }

        static void CopyFile(string sourceFile, string destFile)
        {
            File.Copy(sourceFile, destFile, true);
        }

        private void List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= gameObjects.Count) return;
            targetObject = e.RowIndex;
            DataGridViewRow row = List.Rows[e.RowIndex];
            tb_ID.Text = gameObjects[e.RowIndex].id;
            tb_Name.Text = gameObjects[e.RowIndex].name;
            cb_color.SelectedValue = gameObjects[e.RowIndex].fill;
            tb_X.Text = gameObjects[e.RowIndex].transform.x.ToString();
            tb_Y.Text = gameObjects[e.RowIndex].transform.y.ToString();
            tb_XSize.Text = gameObjects[e.RowIndex].transform.xSize.ToString();
            tb_YSize.Text = gameObjects[e.RowIndex].transform.ySize.ToString();
            tb_Gravity.Text = gameObjects[e.RowIndex].gravity.ToString();
            cb_Tipe.SelectedIndex = gameObjects[e.RowIndex].tipe;
            cb_absolute.Checked = gameObjects[e.RowIndex].absolute == 1 ? true : false;
            cb_absolute.Text = gameObjects[e.RowIndex].absolute == 1 ? "True" : "False";
            cb_collision.Checked = gameObjects[e.RowIndex].collisionBlock == 1 ? true : false;
            cb_collision.Text = gameObjects[e.RowIndex].collisionBlock == 1 ? "True" : "False";
            cb_color.Text = gameObjects[e.RowIndex].fill;
            tb_volume.Text = gameObjects[e.RowIndex].audio.volume.ToString();
            cb_loop.Checked = gameObjects[e.RowIndex].audio.loop == 0 ? false : true;
            cb_playstart.Checked = gameObjects[e.RowIndex].audio.playAtStart == 0 ? false : true;
            loadAudio();
            loadTexture();
        }

        public void insertAudio(GameObject.Source audio)
        {
            try
            {
                audio.path = audio.path.Replace(dirName+"/" , "");
                audio.path = audio.path.Replace("\\","/");
                
                MessageBox.Show(audio.path);
                gameObjects[targetObject].audio.source.Add(audio);
            }
            catch (Exception) { }
            loadAudio();
        }

        public void insertTexture(GameObject.Texture.Source texture)
        {
            try
            {
                texture.path = texture.path.Replace(dirName + "/", "");
                texture.path = texture.path.Replace("\\", "/");

                MessageBox.Show(texture.path);
                gameObjects[targetObject].texture.sources.Add(texture);
            }
            catch (Exception) { }
            loadTexture();
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            if (targetObject < 0 || targetObject >= gameObjects.Count) return;
            gameObjects[targetObject].name = tb_Name.Text;
            gameObjects[targetObject].gravity = tb_Gravity.Text;
            gameObjects[targetObject].transform.x = float.Parse(tb_X.Text);
            gameObjects[targetObject].transform.y = float.Parse(tb_Y.Text);
            gameObjects[targetObject].transform.xSize = float.Parse(tb_XSize.Text);
            gameObjects[targetObject].transform.ySize = float.Parse(tb_YSize.Text);
            gameObjects[targetObject].tipe = cb_Tipe.SelectedIndex;
            gameObjects[targetObject].absolute = cb_absolute.Checked ? 1 : 0;
            gameObjects[targetObject].collisionBlock = cb_collision.Checked ? 1 : 0;
            gameObjects[targetObject].fill = cb_color.SelectedItem.ToString();
            gameObjects[targetObject].audio.selectedTrack = cb_audio.SelectedIndex;
            gameObjects[targetObject].audio.volume = Int32.Parse(tb_volume.Text);
            gameObjects[targetObject].texture.selectedTexture = cb_texture.SelectedIndex;
            gameObjects[targetObject].audio.loop = cb_loop.Checked ? 1 : 0;
            gameObjects[targetObject].audio.playAtStart = cb_playstart.Checked ? 1 : 0;
            loadGame();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EditScript_Click(object sender, EventArgs e)
        {
            using (StreamReader canvasReader = new StreamReader(dirName + "/game/scripts/script.js"))
            {
                formEdit.getTB().Text = canvasReader.ReadToEnd();  
            }
            formEdit.Show();
        }

        private void cbTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipeSelected = cb_Tipe.SelectedIndex;
        }

        private void cbTipe_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_absolute_CheckedChanged(object sender, EventArgs e)
        {
            cb_absolute.Text = cb_absolute.Checked ? "True" : "False";
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            if (targetObject < 0 || targetObject >= gameObjects.Count) return;
          
            tb_ID.Text = gameObjects[targetObject].id;
            tb_Name.Text = gameObjects[targetObject].name;
            tb_X.Text = gameObjects[targetObject].transform.x.ToString();
            tb_Y.Text = gameObjects[targetObject].transform.y.ToString();
            tb_XSize.Text = gameObjects[targetObject].transform.xSize.ToString();
            tb_YSize.Text = gameObjects[targetObject].transform.ySize.ToString();
            tb_Gravity.Text = gameObjects[targetObject].gravity.ToString();
            cb_Tipe.SelectedIndex = gameObjects[targetObject].tipe;
            cb_absolute.Checked = gameObjects[targetObject].absolute == 1 ? true : false;
            cb_absolute.Text = gameObjects[targetObject].absolute == 1 ? "True" : "False";
            loadAudio();
        }

        private void cb_collision_CheckedChanged(object sender, EventArgs e)
        {
            cb_collision.Text = cb_absolute.Checked ? "True" : "False";
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void track_volume_ValueChanged(object sender, EventArgs e)
        {
            tb_volume.Text = track_volume.Value.ToString();
        }

        private void tb_volume_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(tb_volume.Text);
                num = num < 0 ? 0 : (num > 100 ? 100 : num);
                track_volume.Value = num;
                tb_volume.Text = num.ToString();
            }
            catch (Exception )
            {
                tb_volume.Text = "0";
            }
        }

        void loadAudio()
        {
            cb_audio.Items.Clear();
            try
            {
                foreach (GameObject.Source sourc in gameObjects[targetObject].audio.source)
                {
                    cb_audio.Items.Add(sourc.name);
                }
            }
            catch (Exception )
            {

            }
        }

        void loadTexture()
        {
            cb_texture.Items.Clear();
            try
            {
                foreach (GameObject.Texture.Source texture in gameObjects[targetObject].texture.sources)
                {
                    cb_texture.Items.Add(texture.name);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_addAudio_Click(object sender, EventArgs e)
        {
            selector.mode = 0;
            selector.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_texture_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                gameObjects[targetObject].texture.selectedTexture = cb_texture.SelectedIndex;
            }
            catch (Exception){}
        }

        private void btn_texture_Click(object sender, EventArgs e)
        {
            selector.mode = 1;
            selector.Show();
        }

        public void refreshAsset()
        {
            flowPanel.Controls.Clear();
            manager = new ResourceManager(dirName);
            foreach (String file in manager.listOfFile)
            {
                Panel panel = new Panel();
                PictureBox btn = new PictureBox();
                Label label = new Label();
                label.Text = Path.GetFileName(file);
                btn.Image = Image.FromFile("data/asset/images/file.png");
                btn.Click += new EventHandler(this.MyButtonHandler);
                btn.Width = 50;
                btn.Height = 50;
                btn.Text = "hallo";
                label.Location = new Point(0, btn.Height);
                panel.Controls.Add(btn);
                panel.Width = btn.Width;
                panel.Controls.Add(label);
                flowPanel.Controls.Add(panel);
            }
        }

        private void refresh_Btn_Click(object sender, EventArgs e)
        {
            refreshAsset();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Parent_Load(object sender, EventArgs e)
        {

        }

        public void browser_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            
        }

        public void browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            //Chromium.ExecuteScriptAsync("document.addEventListener(\"click\", function() {alert('Detect a click.');});");
        }
    }
    
}
