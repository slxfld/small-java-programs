using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Funktions Zeichner ^1, ^2, ^3, ^4
//
// Author: (C) Simon Lixenfeld 2018
// Lizenz: MIT


namespace Funktions_Zeichner
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pencil;
        
        //Variables
        int start_index;
        int end_index;
        int abstand;
        int height;

        bool zeichnen = false;

        int hoch;
        double A_val;
        double B_val;
        double C_val;
        double D_val;
        double E_val;


        int calc_distance()
        {
            int distance = 0;
            if (end_index > start_index)
            {//Start < End
                for (int i = start_index; i < end_index; i++)
                {
                    distance++;
                }
            }
            else if (end_index < start_index)
            {//Start > End
                MessageBox.Show("Von > Bis");
            }
            else
            {// StartIndex = EndIndex
                MessageBox.Show("Ungültiger Zahlbereich");
            }
            return distance;
        }

        
        double[] funktion_berechnen(int ind)
        {
            //Funktion Berechnung
            ind = ind + start_index;
            double[] fu_value = new double[4];
            
                hoch = Convert.ToInt32(tbHoch.Text);
                A_val = Convert.ToDouble(tbA.Text);
                B_val = Convert.ToDouble(tbB.Text);
                C_val = Convert.ToDouble(tbC.Text);
                D_val = Convert.ToDouble(tbD.Text);
                E_val = Convert.ToDouble(tbE.Text);

                
                if (hoch == 1)
                {
                    fu_value[0] = A_val * ind + B_val;
                    fu_value[1] = A_val;
                    fu_value[2] = 0;
                    fu_value[3] = 0;

                }
                else if (hoch == 2)
                {
                    fu_value[0] = A_val * Math.Pow(ind, 2) + B_val * ind + C_val;
                    fu_value[1] = (2 * A_val) * ind + B_val;
                    fu_value[2] = A_val;
                    fu_value[3] = 0;
                }
                else if (hoch == 3)
                {
                    fu_value[0] = A_val * Math.Pow(ind, 3) + B_val * ind + C_val * ind + D_val;
                    fu_value[1] = (3 * A_val) * Math.Pow(ind, 2) + (2 * B_val) + C_val;
                    fu_value[2] = (6 * A_val) + B_val;
                    fu_value[3] = A_val;

                }
                else if (hoch == 4)
                {
                    fu_value[0] = A_val * Math.Pow(ind, 4) + B_val * ind + C_val * ind + D_val * ind + E_val;
                }
                //Return Array von Y-Wert Ableitungen
                fu_value[0] = -fu_value[0];
                fu_value[1] = -fu_value[1];
                fu_value[2] = -fu_value[2];
                fu_value[3] = -fu_value[3];

                return fu_value;
        }

        void Grafik_Zeichnen(Graphics g)
        {
            //Zeichnen Linien
            pencil = new Pen(Brushes.Black, 2);
            int dist = calc_distance();
            double[] points = new double[dist + 1];
            double[] points1 = new double[dist + 1];
            double[] points2 = new double[dist + 1];
            double[] points3 = new double[dist + 1];
            
            tb_ergebnise.Clear();
            for(int i = 0; i < dist; i++){
                
                //Funktion Berechnung
                double[] func_value = funktion_berechnen(i);
                points[i] = func_value[0] / height;
                points1[i] = func_value[1] / height;
                points2[i] = func_value[2] / height;
                points3[i] = func_value[3] / height;

                tb_ergebnise.Text += "f(" + (i + start_index) + "): " + func_value[0] + Environment.NewLine;
                
                g.FillEllipse(Brushes.Blue, 5 + (i * abstand), (panel1.Height / 2) + (((int)func_value[0]) / height), 3, 3);
                g.FillEllipse(Brushes.Red, 5 + (i * abstand), (panel1.Height / 2) + (((int)func_value[1]) / height), 3, 3);
                g.FillEllipse(Brushes.Green, 5 + (i * abstand), (panel1.Height / 2) + (((int)func_value[2]) / height), 3, 3);
                g.FillEllipse(Brushes.Purple, 5 + (i * abstand), (panel1.Height / 2) + (((int)func_value[3]) / height), 3, 3);
                
                //X
                if (i % 2 == 1)
                {
                    g.DrawString("" + (i + start_index), new Font("Consolas", 8, FontStyle.Bold), Brushes.Black, 5 + (i * abstand), (panel1.Height) - 30);
                }
                else
                {
                    g.DrawString("" + (i + start_index), new Font("Consolas", 8, FontStyle.Bold), Brushes.Black, 5 + (i * abstand), (panel1.Height) - 20);
                }
                
                //Y
                //g.DrawString("" + ((int)func_value[0]), new Font("Consolas", 8, FontStyle.Bold), Brushes.Black, 5, (panel1.Height / 2) + ((int)func_value[0]) / height);
                g.DrawString("" + ((int)func_value[0]), new Font("Consolas", 8, FontStyle.Bold), Brushes.Black, 5 + (i * abstand), (panel1.Height / 2) + ((int)func_value[0]) / height);
                
                
                if (hoch == 2)
                {
                    g.DrawString("f(x) = " + A_val + "X^" + hoch + " + (" + B_val + ")X + (" + C_val+")", new Font("Consolas", 11, FontStyle.Bold), Brushes.Black, 10, 10);
                }
                if (hoch == 3)
                {
                    g.DrawString("f(x) = " + A_val + "X^" + hoch + " + (" + B_val + ")X + (" + C_val+")X + ("+ D_val+")", new Font("Consolas", 11, FontStyle.Bold), Brushes.Black, 10, 10);
                }
                if (hoch == 4)
                {
                    g.DrawString("f(x) = " + A_val + "X^" + hoch + " + (" + B_val + ")X + (" + C_val + ")X + (" + D_val+")X + ("+ E_val+")", new Font("Consolas", 11, FontStyle.Bold), Brushes.Black, 10, 10);
                }
            }
            //Lines
            //f(x)
            for (int j = 0; j < dist; j++)
            {
                pencil = new Pen(Brushes.Blue, 1);
                if (j != dist - 1)
                {
                    g.DrawLine(pencil, 5 + (j * abstand), (panel1.Height / 2) + (int)points[j], 5 + ((j + 1) * abstand), (panel1.Height / 2) + (int)points[j + 1]);
                }
            }
            //f(x)'
            for (int j = 0; j < dist; j++)
            {
                pencil = new Pen(Brushes.Red, 1);
                if (j != dist - 1)
                {
                    g.DrawLine(pencil, 5 + (j * abstand), (panel1.Height / 2) + (int)points1[j], 5 + ((j + 1) * abstand), (panel1.Height / 2) + (int)points1[j + 1]);
                }
            }
            //f(x)''
            for (int j = 0; j < dist; j++)
            {
                pencil = new Pen(Brushes.Green, 1);
                if (j != dist - 1)
                {
                    g.DrawLine(pencil, 5 + (j * abstand), (panel1.Height / 2) + (int)points2[j], 5 + ((j + 1) * abstand), (panel1.Height / 2) + (int)points2[j + 1]);
                }
            }
            //f(x)'''
            for (int j = 0; j < dist; j++)
            {
                pencil = new Pen(Brushes.Purple, 1);
                if (j != dist - 1)
                {
                    g.DrawLine(pencil, 5 + (j * abstand), (panel1.Height / 2) + (int)points3[j], 5 + ((j + 1) * abstand), (panel1.Height / 2) + (int)points3[j + 1]);
                }
           }

        }

        void Hintergrund_Zeichnen(Graphics g)
        {
            //Zeichnen Linien
            pencil = new Pen(Brushes.Black, 1);
            g.FillRectangle(Brushes.White, 2, 2, panel1.Width - 2, panel1.Height - 2);
            g.DrawLine(pencil, 2, panel1.Height / 2, panel1.Width - 2, panel1.Height / 2);
            g.DrawLine(pencil, 2, 2, 2, panel1.Height);


        }

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            Hintergrund_Zeichnen(g);
        }

        void changed_numeric(object sender, EventArgs e)
        {
            start_index = Convert.ToInt32(von_numeric.Value);
            end_index = Convert.ToInt32(bis_numeric.Value);
            height = Convert.ToInt32(hohe_numeric.Value);
            abstand = Convert.ToInt32(abstand_numeric.Value);
            
            bereich_l.Text = "Bereich: [" + start_index + ";" + end_index + "]";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Hintergrund_Zeichnen(g);
            if (zeichnen)
            {
                zeichnen = false;
                Grafik_Zeichnen(g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zeichnen = true;
            panel1.Invalidate();
        }


    }
}
