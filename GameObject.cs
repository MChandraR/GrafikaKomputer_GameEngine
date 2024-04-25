using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class GameObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string gravity { get; set; }
        public int tipe { get; set; }
        public Transform transform { get; set; }
        public GameObject(string id,string name, string type, float x, float y, float xSize, float ySize, int tipe,string gravity)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.transform = new Transform();
            this.transform.x = x;
            this.transform.y = y;
            this.transform.xSize = xSize;
            this.transform.ySize = ySize;
            this.gravity = gravity;
            this.tipe = tipe;
        }

        public class Transform
        {
            public float x { get; set; }
            public float y { get; set; }
            public float xSize { get; set; }
            public float ySize { get; set; }
        }
    }
}
