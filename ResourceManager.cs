using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Engine
{
    public class ResourceManager
    {
        public List<Audio> audio = new List<Audio>();
        public Image imageAsset = new Image("","");
        public String rootPath;
        List<String> paths = new List<string>();
        public List<String> listOfFile = new List<string>();
        public List<String> listOfFolder = new List<string>();
        int idx = 0;
        public ResourceManager(String rootPath)
        {
            this.rootPath = rootPath;
            paths.Add(rootPath);

            Thread thread = new Thread(new ThreadStart(scanAsset));
            thread.Start();
            thread.Join();
        }

        void scanAsset()
        {
            while (idx < paths.Count)
            {
                listOfFolder.Add(paths[idx]);
                foreach(String file in Directory.GetFiles(paths[idx]))
                {
                    listOfFile.Add(file);
                    if (Path.GetExtension(file).Equals(".mp3")||Path.GetExtension(file).Contains("png") || Path.GetExtension(file).Contains("jpg"))
                    {
                        audio.Add(new Audio(file, Path.GetFileName(file)));
                    }
                }

                foreach (String dir in Directory.GetDirectories(paths[idx]))
                {
                    paths.Add(dir);
                }
                idx++;
            }
        }

        public class Audio
        {
            public String path, judul;
            public Audio(String path, String judul)
            {
                this.path = path;
                this.judul = judul;
            }
        }

        public class Image
        {
            public String path, judul;
            public Image(String path, String judul)
            {
                this.path = path;
                this.judul = judul;
            }
        }
    }
}
