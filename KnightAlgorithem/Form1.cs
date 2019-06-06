using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace KnightAlgorithem
{
    public partial class Form1 : Form
    {
        const int KMS = 100;
        const int To_Be_Visited = -1;
        const int Max_Allowed_Move = 8;
        static int[,] Bored;
        static int BoredSize;
        static int[] Allowed_Move_col = {2,1,-1,-2,-2,-1,1,2 };
        static int[] Allowed_Move_row = {1,2,2,1,-1,-2,-2,-1 };
        int InitialCol, InitialRow;
        Graphics g;
        Pen p = new Pen(Color.Black);
        Pen p1 = new Pen(Color.Red);
        static bool[,] bored2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PrintBored()
        {
            g = panel1.CreateGraphics();
            g.Clear(Color.White);
            int DrawRow = panel1.Size.Height / BoredSize;
            int DrawCol = panel1.Size.Width / BoredSize;
            for (int i = 0; i <= panel1.Size.Height; i+=DrawRow)
            {
                g.DrawLine(p, 0, i, panel1.Size.Width, i);
            }
            for (int j = 0; j <= panel1.Size.Width; j += DrawCol)
            {
                g.DrawLine(p, j, 0, j, panel1.Size.Height);
            }
            int DrawC=0,DrawR=0;
            for (int k = 0; k < BoredSize; k++)
            {
                for (int s = 0; s < BoredSize; s++)
                {
                    g.DrawString(Bored[k, s].ToString(), new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold), p.Brush, DrawC + DrawCol / 2-4, DrawR + DrawRow / 2-4);
                    DrawC += DrawCol;
                }
                DrawC = 0;
                DrawR += DrawRow;
            }
        }

        public void PrintBored2()
        {
            g = panel1.CreateGraphics();
            g.Clear(Color.White);
            int DrawRow = panel1.Size.Height / BoredSize;
            int DrawCol = panel1.Size.Width / BoredSize;
            for (int i = 0; i <= panel1.Size.Height; i += DrawRow)
            {
                g.DrawLine(p, 0, i, panel1.Size.Width, i);
            }
            for (int j = 0; j <= panel1.Size.Width; j += DrawCol)
            {
                g.DrawLine(p, j, 0, j, panel1.Size.Height);
            }
            int DrawC = 0, DrawR = 0;
            bool check = false;
            for (int k = 0; k < BoredSize; k++)
            {
                for (int s = 0; s < BoredSize; s++)
                {
                    if (bored2[k, s])
                    {
                        check = true;
                        g.FillRectangle(p1.Brush, DrawC, DrawR, DrawRow, DrawRow);
                        g.DrawString(k.ToString()+" "+s.ToString(), new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold), p.Brush, DrawC + DrawCol / 2 - 6, DrawR + DrawRow / 2 - 6);
                        
                    }
                    DrawC += DrawCol;
                }
                DrawC = 0;
                DrawR += DrawRow;
            }
            if (!check)
            {
                MessageBox.Show("There is No Solution For Such Size!!");
                g.Clear(Color.White);
            }
            
        }

        
        private void Solvebtn_Click(object sender, EventArgs e)
        {
            if (Sizetxt.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                InitialCol = Convert.ToInt32(textBox1.Text);
                InitialRow = Convert.ToInt32(textBox2.Text);
                BoredSize = Convert.ToInt32(Sizetxt.Text);
                Bored = new int[BoredSize + 1, BoredSize + 1];
                progressBar1.Value = 0;
                progressBar1.Maximum = BoredSize * BoredSize * 10;
                for (int i = 0; i < BoredSize; i++)
                {
                    for (int j = 0; j < BoredSize; j++)
                    {
                        Bored[i, j] = To_Be_Visited;
                    }
                }
                Bored[InitialRow, InitialCol] = 0;
                if (!Solve(InitialRow, InitialCol, 1))
                    MessageBox.Show("Problem Can Not Be Solved !");
                else
                    PrintBored();
            }
            else
                MessageBox.Show("Some Inputs Are Empty!");
        }

        public bool Solve(int PreviousRow, int PreviousCol, int Next_Step_no)
        {
           for (int i = 0; i < Max_Allowed_Move; i++)
                {
                    int col = PreviousCol + Allowed_Move_col[i];
                    int row = PreviousRow + Allowed_Move_row[i];
                    if (col < 0 || col > BoredSize) continue;
                    if (row < 0 || row > BoredSize) continue;
                    if (Bored[row, col] != To_Be_Visited) continue;
                    Bored[row, col] = Next_Step_no;
                    if (Next_Step_no == BoredSize * BoredSize - 1)
                        return true;
                    else
                    {
                        if (Solve(row, col, Next_Step_no + 1))
                        {
                            progressBar1.Increment(10);
                            return true;
                        }
                        else
                        {
                            Bored[row, col] = To_Be_Visited;
                        }
                    }
                }
                return false;
            
        }

        private void Solve2btn_Click(object sender, EventArgs e)
        {
            if (Sizetxt.Text != "")
            {
                BoredSize = Convert.ToInt32(Sizetxt.Text);
                bored2 = new bool[BoredSize, BoredSize];
                for (int i = 0; i < BoredSize; i++)
                {
                    for (int j = 0; j < BoredSize; j++)
                    {
                        bored2[i, j] = false;
                    }
                }
                for (int k = 0; k < BoredSize; k++)
                {
                    for (int l = 0; l < BoredSize; l++)
                    {
                        Bored = new int[BoredSize + 1, BoredSize + 1];
                        progressBar1.Value = 0;
                        progressBar1.Maximum = BoredSize * BoredSize * 10;
                        for (int i = 0; i < BoredSize; i++)
                        {
                            for (int j = 0; j < BoredSize; j++)
                            {
                                Bored[i, j] = To_Be_Visited;
                            }
                        }
                        Bored[k, l] = 0;
                        if (Solve(k, l, 1))
                            bored2[k, l] = true;
                    }
                }
                PrintBored2();
            }
            else
                MessageBox.Show("Enter The Size Field.");
        }
       
    }
}
