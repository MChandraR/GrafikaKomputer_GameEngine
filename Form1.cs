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
        int targetObject = 0;
        int tipeSelected = 0;
        FormEditScript formEdit;
        static String dir = System.IO.Directory.GetCurrentDirectory();
        string dirName = dir + "/mygame/"; // Ganti dengan path direktori yang diinginkan

        List<GameObject> gameObjects = new List<GameObject>();
        public Parent()
        {
            formEdit = new FormEditScript(this);
            InitializeComponent();
            Browser.Load(dirName + "index.html");
            test.Text = dir ;
            loadProject();
        }

        public void loadProject()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        float post = 0f;
        private void AddObject_Click(object sender, EventArgs e)
        {
            GameObject newObj = new GameObject(gameObjects.Count.ToString(), "Game Object " + gameObjects.Count.ToString(), "1", post, 5f, 100f, 50f,1, "0");
            gameObjects.Add(newObj);
            List.Rows.Add(newObj.name + gameObjects.Count.ToString(), gameObjects.Count);
            loadGame();
        }

        private void RemoveObject_Click(object sender, EventArgs e)
        {
            if (targetObject < 0 || targetObject >= gameObjects.Count) return;
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus ? ", "Yakin",  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                gameObjects.RemoveAt(targetObject);
                List.Rows.RemoveAt(targetObject);
            }
            loadGame();
        }

        private void loadGame()
        {

            if (!Directory.Exists(dirName + "/game"))
            {
                Directory.CreateDirectory(dirName + "/game");
                Console.WriteLine("Folder tujuan berhasil dibuat:");
            }
            if (!Directory.Exists(dirName + "/game/scenes"))
            {
                Directory.CreateDirectory(dirName + "/game/scenes");
                Console.WriteLine("Folder tujuan berhasil dibuat:");
            }
            if (!Directory.Exists(dirName + "/game/scripts"))
            {
                Directory.CreateDirectory(dirName + "/game/scripts");
            }
            if (!Directory.Exists(dirName + "/game/objects"))
            {
                Directory.CreateDirectory(dirName + "/game/objects");
                Console.WriteLine("Folder tujuan berhasil dibuat:");
            }

            /*          int idx = 0;
                      foreach(GameObject obj in gameObjects)
                      {
                          List.Rows.Add(obj.name + idx.ToString(), idx);
                          idx++;

                      }*/


            CopyFile("data/index.html", dirName + "index.html");
            if (!File.Exists(dirName + "game/scripts/script.js")) CopyFile("data/game/scripts/script.js", dirName + "game/scripts/script.js");
            CopyFile("data/game/objects/object.js", dirName + "game/objects/object.js");
            CopyFile("data/game/objects/transform.js", dirName + "game/objects/transform.js");

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
                        using (StreamReader scriptReader = new StreamReader(dirName + "game/scripts/script.js"))
                        {
                            scene = scene.Replace("$script", scriptReader.ReadToEnd());
                        }
                    }

                    //Memuat game object dari json ke core.js

                    core = core.Replace("$mainScene", scene);
                    core = core.Replace("$object", JsonConvert.SerializeObject(gameObjects));
                }

            }

            using (StreamWriter writer = new StreamWriter(dirName + "core.js"))
            {
                writer.Write(core);
            }


            Console.WriteLine("Proses selesai.");
            Browser.Load(dirName + "index.html");
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
            tb_X.Text = gameObjects[e.RowIndex].transform.x.ToString();
            tb_Y.Text = gameObjects[e.RowIndex].transform.y.ToString();
            tb_XSize.Text = gameObjects[e.RowIndex].transform.xSize.ToString();
            tb_YSize.Text = gameObjects[e.RowIndex].transform.ySize.ToString();
            tb_Gravity.Text = gameObjects[e.RowIndex].gravity.ToString();
            cb_Tipe.SelectedIndex = gameObjects[e.RowIndex].tipe;
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            gameObjects[targetObject].name = tb_Name.Text;
            gameObjects[targetObject].gravity = tb_Gravity.Text;
            gameObjects[targetObject].transform.x = float.Parse(tb_X.Text);
            gameObjects[targetObject].transform.y = float.Parse(tb_Y.Text);
            gameObjects[targetObject].transform.xSize = float.Parse(tb_XSize.Text);
            gameObjects[targetObject].transform.ySize = float.Parse(tb_YSize.Text);
            gameObjects[targetObject].tipe = cb_Tipe.SelectedIndex;
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
            using (StreamReader canvasReader = new StreamReader(dirName + "game/scripts/script.js"))
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
    }
    
}
