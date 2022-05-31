using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_II.Game
{
    public class Cell
    {
        //Field
        public System.Windows.Forms.PictureBox box { get; set; }
        public int size { get; set; } //Size of Cell
        public Point location { get; set; } //Position on Screen
        public int id { get; set; }    //Position.x in Grid
        //Constructor
        public Cell(int id,Point location,int size)
        {
            this.id=id;this.location = location;this.size = size;
            box = new System.Windows.Forms.PictureBox();
            box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            box.Size = new Size(size, size);
            box.Location = location;
        }
        //Methods
        
    }
}
