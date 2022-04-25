using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace OOP_Lab_II.Game
{
    class Texture
    {
        private List<System.Drawing.Image> textures;
        private Texture()
        {
            // rectangle orange,green,blue = 1 , 2 , 3
            // triangle orange,green,blue = 4 , 5 , 6
            // round orange,green,blue = 7 , 8 , 9
            textures = new List<Image>();
            
            string resPath = "OOP_Lab_II.Game.res.";
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "frame.png")));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "selectable_frame.png")));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Rectangle-Orange.png")));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Rectangle-Green.png")));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Rectangle-Blue.png")));
        }
        private static Texture instance;
        public static Texture texture
        {
            get
            {
                if (instance == null)
                    instance = new Texture();
                return instance;
            }
        }
        public Image this[int i] { get => textures[i]; }

    }
}
