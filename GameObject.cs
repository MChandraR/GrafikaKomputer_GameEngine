using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GameObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string gravity { get; set; }
        public string fill { get; set; }
        public int absolute { get; set; }
        public int collisionBlock { get; set; }
        public int tipe { get; set; }
        public Transform transform { get; set; }
        public Audio audio { get; set; }
        public Texture texture { get; set; }
        public GameObject(string id,string name, string type, float x, float y, float xSize, float ySize, int tipe,string gravity, int absolute, int collisionBlock, int loop, int vol)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.transform = new Transform();
            this.audio = new Audio(loop, vol);
            this.transform.x = x;
            this.transform.y = y;
            this.transform.xSize = xSize;
            this.transform.ySize = ySize;
            this.gravity = gravity;
            this.tipe = tipe;
            this.absolute = absolute;
            this.collisionBlock = collisionBlock;
            this.fill = "Blue";
            this.texture = new Texture();
            this.texture.sources = new List<Texture.Source>();
        }

        public class Transform
        {
            public float x { get; set; }
            public float y { get; set; }
            public float xSize { get; set; }
            public float ySize { get; set; }
        }

        public class Audio
        {
            public Audio(int loop, int volume)
            {
                this.loop = loop;
                this.volume = volume;
                this.source = new List<Source>();
                this.playAtStart = 0;
            }
            public List<Source> source { get;set;}
            public int loop { get; set; }
            public int playAtStart { get; set; }
            public int volume { get; set; }
            public int selectedTrack { get; set; }
        }

        public class Texture
        {
            public List<Source> sources { get; set; }
            public int selectedTexture { get; set; }

            public class Source
            {
                public string name { get; set; }
                public string path { get; set; }

                public Source(string name, string path)
                {
                    this.name = name;
                    this.path = path;
                }
            }
        }

        public class Source
        {
            public String name ,path;
            public Source(String name, String path)
            {
                this.name = name; this.path = path;
            }
        }
    }
}
