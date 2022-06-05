using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace OOP_Lab_II.Game
{
    public static class Builder
    {
        public static void Build(List<Cell> _objects, gameGrid _grid)
        {
            TextureBuilder();
            SoundBuilder();
            CellsBuilder(_objects, _grid);
        }
        private static void TextureBuilder()
        {
            // rectangle orange,green,blue = 1 , 2 , 3
            // triangle orange,green,blue = 4 , 5 , 6
            // round orange,green,blue = 7 , 8 , 9

            string resPath = "OOP_Lab_II.Game.res.";
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "frame.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "selectable_frame.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Rectangle-Orange.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Rectangle-Green.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Rectangle-Blue.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Triangle-Orange.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Triangle-Green.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Triangle-Blue.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Round-Orange.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Round-Green.png")));
            Texture.textures.Add(Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(resPath + "Round-Blue.png")));
        }
        private static void SoundBuilder()
        {
            Sounds.MoveSound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.Move.wav");
            Sounds.BingoSound.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("OOP_Lab_II.Game.audio.Bingo.wav");
        }
        private static void CellsBuilder(List<Cell> _objects, gameGrid _grid)
        {
            for (int i = 0; i < _grid.Row; i++)
                for (int j = 0; j < _grid.Column; j++)
                {
                    Cell cell = new Cell(0, _grid.indexTolocation(i, j), _grid.CellSize);
                    _objects.Add(cell);  // Add Created Objects to list<object> objects
                    cell.box.Image = Texture.textures[0];
                }
        }
    }
}
