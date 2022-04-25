using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace GAME_TEST
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
            string[] names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(names[5])));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(names[6])));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(names[4])));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(names[3])));
            textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(names[2])));
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
