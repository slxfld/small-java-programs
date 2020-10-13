
/* The MIT License (MIT)

Copyright (c) 2018 Simon Lixenfeld

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        Graphics g;
        Graphics g2;
        Mine[,] minen;
        int limit = 16;
        int Minenanzahl = 10;
        int minen_gesetzt = 0;
        int z_wert = 20;
        bool zu_ende = false;
        bool im_spiel = false;

        public Form1()
        {

            InitializeComponent();
            g = panel1.CreateGraphics();
            g2 = this.CreateGraphics();

		    limit = 19;

        }

	private void init(){
	
	    minen = new Mine[limit,limit];

            for (int y = 0; y < limit; y++)
            {
                for (int x = 0; x < limit; x++)
                {
                    minen[x, y] = new Mine(x, y);
                }
            }
            minen_verteilen();
	}

        private void minen_verteilen()
        {

            Random rand = new Random();
            for (int m = 0; m < Minenanzahl; m++)
            {

                int ziel = rand.Next(limit * limit);
                int count = 0;

                for (int y = 1; y < limit-1; y++)
                {
                    for (int x = 1; x < limit-1; x++)
                    {
                        count++;
                        if (count == ziel)
                        {
                            if (minen[x, y].gesetzt == false)
                            {
                                minen[x, y].gesetzt = true;
                                minen_gesetzt++;
                            }
                        }
                    }
                }
            }
        }


        public void spiel_ende(string entscheid)
        {
            if (entscheid == "verloren")
            {
                MessageBox.Show("Spielende, Eine Mine wurde aufgedeckt");
            }
            else
            {
                MessageBox.Show("Alle Minen sind markiert, du hast gewonnen!");

            }
            zu_ende = true;
        }



        public void check_minen_umkreis(Mine mine)
        {
            try
            {
                if (mine.null_checked == false)
                {
                    int um_count = 0;
                    bool minen_gefunden = false;
                    for (int y = mine.y - 1; y <= mine.y + 1; y++)
                    {
                        for (int x = mine.x - 1; x <= mine.x + 1; x++)
                        {
                            if (minen[x, y].gesetzt)
                            {
                                um_count++;
                                minen_gefunden = true;
                            }
                        }
                    }

                    mine.minen_im_umkreis = um_count;
                    if (!mine.gesetzt) { 
                        mine.aufgedeckt = true; 
                        if (um_count == 0) { 
                            mine.null_checked = true;
                            check_umkreis(mine.x, mine.y); 

                        }
                    }
                }
            }
            catch (Exception e) { }
        }

        public void check_umkreis(int x, int y)
        {

                check_minen_umkreis(minen[x - 1, y - 1]);
                check_minen_umkreis(minen[x, y - 1]);
                check_minen_umkreis(minen[x + 1, y - 1]);

                check_minen_umkreis(minen[x - 1, y]);
                check_minen_umkreis(minen[x, y]);
                check_minen_umkreis(minen[x + 1, y]);

                check_minen_umkreis(minen[x - 1, y + 1]);
                check_minen_umkreis(minen[x, y + 1]);
                check_minen_umkreis(minen[x + 1, y + 1]);
                minen[x, y].aufgedeckt = true;
            
        }

        private void check_gewinn()
        {
            bool gewonnen = true;
            for (int y = 0; y < limit; y++)
            {
                for (int x = 0; x < limit; x++)
                {
                    if (minen[x, y].gesetzt)
                    {
                        if (!minen[x, y].flagged)
                        {
                            gewonnen = false;
                        }
                    }
                }
            }
            if (gewonnen)
            {
                spiel_ende("gewonnen");
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            progressBar1.Value = 0;
            if(!zu_ende){
                progressBar1.Value = 40;
                for (int y = 0; y < limit; y++)
                {
                    for (int x = 0; x < limit; x++)
                    {
                        if (x != 1 && x != limit-1 && y != 1 && y != limit-1)
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                if (minen[x, y].flagged == false)
                                {
                                    if(minen_gesetzt>0){
                                    minen[x, y].check_collision(e.X, e.Y, true);
                                    if (minen[x, y].flagged)
                                    {

                                        minen_gesetzt--;
                                        check_gewinn();
                                    }
                                }
                                }
                                else
                                {
                                    minen[x, y].check_collision(e.X, e.Y, false);
                                    if (!minen[x, y].flagged)
                                    {

                                        minen_gesetzt++;
                                    }
                                }
                            }
                            else
                            {
                                bool collided = minen[x, y].check_collision(e.X, e.Y, false);
                                if (collided)
                                {
                                    if (minen[x, y].gesetzt) { spiel_ende("verloren"); }
                                    if (!minen[x, y].gesetzt)
                                    {
                                        try
                                        {
                                            if (minen[x, y].aufgedeckt == false)
                                            {
                                                check_minen_umkreis(minen[x, y]);
                                                if (minen[x, y].minen_im_umkreis == 0)
                                                {
                                                    check_umkreis(x, y);
                                                }
                                            }
                                        }
                                        catch (Exception e7) { }
                                    }
                                }
                            }
                        }
                    }
                }
                panel1.Invalidate();
             }
            progressBar1.Value = 100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (im_spiel)
            {
                for (int y = 0; y < limit; y++)
                {
                    for (int x = 0; x < limit; x++)
                    {
                        minen[x, y].draw(g);
                    }
                }
                String m_anz = "Minen: " + minen_gesetzt;
                minen_label.Text = "Minen: " + m_anz;
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {

        }

	private void spiel_buttonclick(object sender, EventArgs e){
	    


	}

    private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void anz_button_Click(object sender, EventArgs e)
    {
        Minenanzahl = Convert.ToInt32((int)anz_numeric.Value);
        init();
        im_spiel = true;
        anz_numeric.Visible = false;
        anz_button.Visible = false;
        anz_label.Visible = false;
    }

    }
}
