
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Minesweeper
{
    public class Mine
    {
        public int x;
        public int y;

        int size = 25;

        int Offsetx;
        int Offsety;

        public bool gesetzt = false;
        public bool flagged = false;
        public bool null_checked = false;

        public bool aufgedeckt = false;

        public int minen_im_umkreis = 0;


        public Mine(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;

            Offsetx = 5;
            Offsety = 5;
        }



        public bool check_collision(int M_x, int M_y,bool _flag)
        {
            bool erg = false;

            //HitBox Funktion
            if (M_x > (x * 30) && M_x < (x * 30) + size && M_y > (y * 30) && M_y < (y * 30) + size)
            {
                if (_flag==true)
                {
                    flagged = true;
                }
		        else
		        {
		            flagged = false;
		        }
                return true;
            }

            return erg;
        }

        public void draw(Graphics g)
        {
            g.FillRectangle(Brushes.DarkBlue, Offsetx + (x * 30), Offsety + (y * 30), size, size);



            if (!aufgedeckt)
            {
                g.FillRectangle(Brushes.Gray, Offsetx + (x * 30) - 2, Offsety + (y * 30) - 2, size, size);
            }
            else
            {
                g.FillRectangle(Brushes.White, Offsetx + (x * 30) - 2, Offsety + (y * 30) - 2, size, size);
                if (gesetzt == false) g.DrawString("" + minen_im_umkreis, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, Offsetx + (x * 30) + 5, Offsety + (y * 30) + 5);

            }


            if (gesetzt)
            {
               // g.FillRectangle(Brushes.Red, Offsetx + (x * 30) + 5, Offsety + (y * 30) + 5, size-15, size-15);
            }


            if (flagged == true){
                g.FillRectangle(Brushes.Lime, Offsetx + (x * 30), Offsety + (y * 30), size, size);
            }

            

        }

    }
}
