using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace KTP
{
    public partial class Form1 : Form
    {
        int DotSize = 30;
        int LineSize = 3;

        int TimeChek = 0, n, m;

        bool load = false;
        bool Gclick = false;

        string filename, st;

        Bitmap bmp;
        Graphics mat;

        List<Dot> Dotes = new List<Dot>();
        List<Line> Lines = new List<Line>();

        SolidBrush Rem = new SolidBrush(Color.Green); //1
        SolidBrush Inf = new SolidBrush(Color.Gold); //2
        SolidBrush Sus = new SolidBrush(Color.Red); //3
        SolidBrush Del = new SolidBrush(Color.White); //0

        Random Chan = new Random();
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(picture.Width, picture.Height);
            mat = Graphics.FromImage(bmp);
        }
        //1.0-----------------------------------------------------------------------------------------------------
        private void Button1_Click(object sender, EventArgs e) //Drow Matrix with Green Dots and Lines
        {
            mat.Clear(Color.White);
            grap.Series["SusGraph"].Points.Clear();
            grap.Series["RefGraph"].Points.Clear();
            grap.Series["InfGraph"].Points.Clear();

            Draw();
            picture.Image = bmp;
            StatAndGraph(TimeChek);
        }
        private void Draw() //Draw Matrix with Yellow Dots
        {
            if ((n != Convert.ToInt32(textBoxN.Text)) || (m != Convert.ToInt32(textBoxN.Text)))
            {
                Dotes.Clear();
                Lines.Clear();
                n = Convert.ToInt32(textBoxN.Text);
                m = Convert.ToInt32(textBoxM.Text);
            }

            DotSize = 320 / (n + m);

            if ((Dotes.Count == 0) && (Lines.Count == 0))
            {
                Dot(n, m);
                Lin(n, m);
            }

            for (var i = 0; i < Lines.Count; i++)
                Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
            for (var i = 0; i < Dotes.Count; i++)
                Draw(Dotes[i].State, Dotes[i].x, Dotes[i].y);

            if (Coord.Checked == true)//Draw Coord of Dots             
                for (int i = 0; i < Dotes.Count; i++)
                    mat.DrawString("(" + Dotes[i].i + "|" + Dotes[i].j + ")", new Font("Arial", 10), Brushes.Black, Dotes[i].x - 14, Dotes[i].y - 6 - DotSize);
            if (DotN.Checked == true)//Draw № of Dots             
                for (int i = 0; i < Dotes.Count; i++)
                    mat.DrawString("(" + i + ")", new Font("Arial", 7), Brushes.Black, Dotes[i].x + DotSize / 4, Dotes[i].y + DotSize / 4);

            {
                textBoxM.BackColor = Color.White;
                textBoxM.ForeColor = Color.Black;
                textBoxM.ReadOnly = false;
                textBoxN.BackColor = Color.White;
                textBoxN.ForeColor = Color.Black;
                textBoxN.ReadOnly = false;
            }// load file
        }
        private void Draw(int State, int x, int y)//Draw Dots
        {
            if (State == 1)
                mat.FillEllipse(Rem, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
            else if (State == 2)
                mat.FillEllipse(Inf, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
            else if (State == 3)
                mat.FillEllipse(Sus, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
            else if (State == 0)
                mat.FillEllipse(Del, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
        }
        private void Draw(int State, int xS, int yS, int xF, int yF)//Draw Lines
        {
            Pen lne = new Pen(Color.Gray, LineSize);
            Pen Dlne = new Pen(Color.White, LineSize);

            if (State == 1)
                mat.DrawLine(lne, xS, yS, xF, yF);
            else if (State == 0)
                mat.DrawLine(Dlne, xS, yS, xF, yF);
        }
        public void Dot(int n, int m)//return Dots List
        {
            int Lenght;

            if (picture.Width / (n + 1) > picture.Height / (m + 1))
                Lenght = picture.Height / (m);
            else
                Lenght = picture.Width / (n);

            int[] DotX = new int[m];
            int[] DotY = new int[n];
            for (var i = 0; i < m; i++)
                DotX[i] = Lenght / 2 + Lenght * i;
            for (var i = 0; i < n; i++)
                DotY[i] = Lenght / 2 + Lenght * i;

            for (var i = 0; i < n; i++)
                for (var j = 0; j < m; j++)
                    Dotes.Add(new Dot(i, j, DotX[j], DotY[i]));
            for (int i = 0; i != Dotes.Count; i++)
                Dotes[i].no = i;
        }
        public void Lin(int n, int m)//return Lines List
        {
            Near(n, m);
            int k = 0;
            for (int i = 0; i != Dotes.Count; i++)
                for (int j = 0; j != Dotes[i].Near.Count; j++)
                {
                    if ((Dotes[i].x <= Dotes[i].Near[j].x) && (Dotes[i].y <= Dotes[i].Near[j].y))
                    {
                        if (Dotes[i].x == Dotes[i].Near[j].x)
                            Lines.Add(new Line(Dotes[i].x, Dotes[i].y + DotSize / 2, Dotes[i].Near[j].x, Dotes[i].Near[j].y - DotSize / 2));
                        else
                            Lines.Add(new Line(Dotes[i].x + DotSize / 2, Dotes[i].y, Dotes[i].Near[j].x - DotSize / 2, Dotes[i].Near[j].y));
                        Lines[k].Dot = i;
                        Lines[k].DotN = Dotes[i].Near[j].no;
                        k++;
                    }
                }
        }
        public void Near(int n, int m)//return Near of Dots List
        {
            for (int i = 0; i < Dotes.Count; i++)
            {
                if (Dotes[i].j != m - 1)
                    Dotes[i].Near.Add(Dotes[i + 1]);
                if (Dotes[i].i != n - 1)
                    Dotes[i].Near.Add(Dotes[i + m]);
                if (Dotes[i].j != 0)
                    Dotes[i].Near.Add(Dotes[i - 1]);
                if (Dotes[i].i != 0)
                    Dotes[i].Near.Add(Dotes[i - m]);
            }
        }
        private void Button2_Click(object sender, EventArgs e)//Clear picture
        {
            grap.Series["SusGraph"].Points.Clear();
            grap.Series["RefGraph"].Points.Clear();
            grap.Series["InfGraph"].Points.Clear();

            Dotes.Clear();
            Lines.Clear();
            mat.Clear(Color.White);
            picture.Image = bmp;
        }
        //2.0-----------------------------------------------------------------------------------------------------
        private void Button3_Click(object sender, EventArgs e)//Start/Stop Simulation
        {
            timer1.Interval = 100000 / Convert.ToInt32(textBoxSpeed.Text);
            if (InfDot.Checked == false)
            {
                Dotes[Convert.ToInt32(textBoxDot1.Text)].State = 3;
                Dotes[Convert.ToInt32(textBoxDot1.Text)].Time = TimeChek + Convert.ToInt32(textBoxTime.Text);
                Dotes[Convert.ToInt32(textBoxDot1.Text)].kol++;
            }

            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled == true)
            {
                button3.Text = ("STOP");
                button3.BackColor = Color.MistyRose;
                button4.Enabled = true;
                button4.BackColor = Color.Moccasin;
                button4.ForeColor = Color.Black;
            }
            else
            {
                button3.Text = ("Start");
                button3.BackColor = Color.Beige;
                button4.Enabled = false;
                button4.BackColor = Color.PapayaWhip;
                button4.ForeColor = Color.Gray;
            }
        }
        private void Live(int Chance, int Time)//Simulate Ifected
        {
            for (int i = 0; i != Dotes.Count; i++)
                if (Dotes[i].State == 2)
                    Infected(i, Chance, Time);
            for (int i = 0; i != Dotes.Count; i++)
                if (Dotes[i].State == 3)
                    Susceptible(i);
        }
        private void Infected(int Dot, int Chance, int Time)// Ifected 2
        {
            for (int i = 0; i != Dotes[Dot].Near.Count; i++)
                if ((Chance > Chan.Next(0, 100)) && (Dotes[Dot].Near[i].State == 3) && (Dotes[Dot].State == 2))
                    for (int k = 0; k != Lines.Count; k++)
                        if (((Lines[k].Dot == Dot) && (Lines[k].DotN == Dotes[Dot].Near[i].no)) || ((Lines[k].DotN == Dot) && (Lines[k].Dot == Dotes[Dot].Near[i].no)))
                            if (Lines[k].State != 0)
                            {
                                Dotes[Dot].State = 3;
                                Dotes[Dot].Time = TimeChek + Time;
                                Dotes[Dot].kol++;
                            }
        }
        private void Susceptible(int Dot)// Ifected 3
        {
            if (SIRSIS.Checked == true)
            {
                if ((Dotes[Dot].Time != 0) && (TimeChek >= Dotes[Dot].Time))
                    Dotes[Dot].State = 1;
            }
            else
            {
                if ((Dotes[Dot].Time != 0) && (TimeChek >= Dotes[Dot].Time))
                    Dotes[Dot].State = 2;
            }
        }
        public void Timer1_Tick(object sender, EventArgs e)// Recurs of Simulate
        {
            int Chance = Convert.ToInt32(textBoxChance.Text);
            int Time = Convert.ToInt32(textBoxTime.Text);
            Live(Chance, Time);

            TimeChek++;

            for (int i = 0; i < Dotes.Count; i++)
                Draw(Dotes[i].State, Dotes[i].x, Dotes[i].y);
            picture.Image = bmp;

            StatAndGraph(TimeChek);
        }
        private void Button4_Click(object sender, EventArgs e)// Reset
        {
            mat.Clear(Color.White);
            if (load)
                Fileread(filename);
            else
            {
                for (var i = 0; i < Dotes.Count; i++)
                {
                    Dotes[i].kol = 0;
                    Dotes[i].State = 2;
                }
                timer1.Interval = 100000 / Convert.ToInt32(textBoxSpeed.Text);
                Dotes[Convert.ToInt32(textBoxDot1.Text)].State = 3;
                Dotes[Convert.ToInt32(textBoxDot1.Text)].Time = TimeChek + Convert.ToInt32(textBoxTime.Text);
                Dotes[Convert.ToInt32(textBoxDot1.Text)].kol++;
            }
            grap.Series["SusGraph"].Points.Clear();
            grap.Series["RefGraph"].Points.Clear();
            grap.Series["InfGraph"].Points.Clear();

            Draw();
            picture.Image = bmp;

            timer1.Enabled = true;
        }
        //3.0-----------------------------------------------------------------------------------------------------
        private void Picture_MouseClick(object sender, MouseEventArgs e) // Change State of picture elements
        {
            for (int i = 0; i < Dotes.Count; i++) // Chenge Dotes
                if (((e.X >= Dotes[i].x - DotSize / 2) && (e.X <= Dotes[i].x + DotSize / 2)) && ((e.Y >= Dotes[i].y - DotSize / 2) && (e.Y <= Dotes[i].y + DotSize / 2)))
                    if (Dotes[i].State == 2)
                        if (InfDot.Checked == true)
                        {
                            Dotes[i].State = 3;
                            Draw(Dotes[i].State, Dotes[i].x, Dotes[i].y);
                            Dotes[i].Time = TimeChek + Convert.ToInt32(textBoxTime.Text);
                            Dotes[Convert.ToInt32(textBoxDot1.Text)].kol++;
                        }
                        else
                        {
                            Dotes[i].State = 0;
                            Draw(Dotes[i].State, Dotes[i].x, Dotes[i].y);
                            Dotes[Convert.ToInt32(textBoxDot1.Text)].kol = 0;
                        }
                    else
                    {
                        Dotes[i].State = 2;
                        Draw(Dotes[i].State, Dotes[i].x, Dotes[i].y);
                        Dotes[Convert.ToInt32(textBoxDot1.Text)].kol = 0;
                    }
            for (int i = 0; i < Lines.Count; i++) // Chenge Lines
            {
                if (((e.X >= Lines[i].xS - 1) && (e.X <= Lines[i].xF - 1)) && ((e.Y >= Lines[i].yS + 1) && (e.Y <= Lines[i].yF + 1)))
                    if (Lines[i].State != 0)
                    {
                        Lines[i].State = 0;
                        Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
                    }
                    else
                    {
                        Lines[i].State = 1;
                        Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
                    }
                if (((e.X >= Lines[i].xS) && (e.X <= Lines[i].xF)) && ((e.Y >= Lines[i].yS) && (e.Y <= Lines[i].yF)))
                    if (Lines[i].State != 0)
                    {
                        Lines[i].State = 0;
                        Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
                    }
                    else
                    {
                        Lines[i].State = 1;
                        Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
                    }
                if (((e.X >= Lines[i].xS + 1) && (e.X <= Lines[i].xF + 1)) && ((e.Y >= Lines[i].yS - 1) && (e.Y <= Lines[i].yF - 1)))
                    if (Lines[i].State != 0)
                    {
                        Lines[i].State = 0;
                        Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
                    }
                    else
                    {
                        Lines[i].State = 1;
                        Draw(Lines[i].State, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);
                    }
            }

            picture.Image = bmp;
            //string Col = "x= " + e.X.ToString() + "  y= " + e.Y.ToString();
            //MessageBox.Show(Col);
        }
        private void InfDot_MouseClick(object sender, MouseEventArgs e)// Click for patient zero
        {
            if (InfDot.Checked == true)
            {
                textBoxDot1.Enabled = false;
                textBoxDot1.BackColor = Color.LightGray;
                textBoxDot1.ForeColor = Color.Gray;

            }
            else
            {
                textBoxDot1.Enabled = true;
                textBoxDot1.BackColor = Color.White;
                textBoxDot1.ForeColor = Color.Black;
            }
        }
        private void SIRSIS_MouseClick(object sender, MouseEventArgs e)// Change SIR-SIS simulate
        {
            if (SIRSIS.Checked == true)
            {
                label_SR.ForeColor = Color.DarkGreen;
                label_SR.Text = ("R");
            }
            else
            {
                label_SR.ForeColor = Color.Red;
                label_SR.Text = ("S");
            }
        }
        private void Button5_Click(object sender, EventArgs e)// Load file matrix
        {
            OpenFileDialog matr = new OpenFileDialog();
            if (matr.ShowDialog(this) == DialogResult.OK)
                Fileread(matr.FileName);
            filename = matr.FileName;
        }
        private void Fileread(string filename)// Read file matrix
        {
            Dotes.Clear();
            Lines.Clear();

            int i = 0, j = 0;
            int[] StateD = new int[i];
            int[] kolD = new int[i];
            int[] StateL = new int[i];
            string[] text = File.ReadAllLines(filename);

            foreach (string str in text)
            {
                if (str[0] == 'C')
                {
                    textBoxN.Text = str[2].ToString() + str[3].ToString();
                    n = Convert.ToInt32(str[2].ToString() + str[3].ToString());
                    textBoxM.Text = str[5].ToString() + str[6].ToString();
                    m = Convert.ToInt32(str[5].ToString() + str[6].ToString());
                }

                Array.Resize(ref StateD, i + 1);
                Array.Resize(ref kolD, i + 1);
                Array.Resize(ref StateL, j + 1);

                if (str[0] == 'D')
                {
                    StateD[i] = Convert.ToInt32(str[6].ToString());
                    kolD[i] = Convert.ToInt32(str[8].ToString() + str[9].ToString() + str[10].ToString());
                    i++;
                }
                else if (str[0] == 'L')
                {
                    StateL[j] = Convert.ToInt32(str[6].ToString());
                    j++;
                }
            }
            Dot(n, m, StateD, kolD);
            Lin(n, m, StateL);
            {
                textBoxM.BackColor = Color.LightGray;
                textBoxM.ForeColor = Color.Gray;
                textBoxM.ReadOnly = true;
                textBoxN.BackColor = Color.LightGray;
                textBoxN.ForeColor = Color.Gray;
                textBoxN.ReadOnly = true;
                InfDot.Checked = true;
                textBoxDot1.Enabled = false;
                textBoxDot1.BackColor = Color.LightGray;
                textBoxDot1.ForeColor = Color.Gray;
                load = true;
            }// lock box
        }
        public void Dot(int n, int m, int[] State, int[] kol)//return Dots List State and kol
        {
            int Lenght;
            int[] DotX = new int[m];
            int[] DotY = new int[n];

            if (picture.Width / (n + 1) > picture.Height / (m + 1))
                Lenght = picture.Height / (m);
            else
                Lenght = picture.Width / (n);

            for (var i = 0; i < m; i++)
                DotX[i] = Lenght / 2 + Lenght * i;
            for (var i = 0; i < n; i++)
                DotY[i] = Lenght / 2 + Lenght * i;

            for (var i = 0; i < n; i++)
                for (var j = 0; j < m; j++)
                    Dotes.Add(new Dot(i, j, DotX[j], DotY[i]));
            for (int i = 0; i != Dotes.Count; i++)
            {
                Dotes[i].no = i;
                Dotes[i].State = State[i];
                Dotes[i].kol = kol[i];
                if (State[i] == 3)
                    Dotes[i].Time = 2;
            }
        }
        public void Lin(int n, int m, int[] State)//return Lines List State
        {
            Near(n, m);
            int k = 0;
            for (int i = 0; i != Dotes.Count; i++)
                for (int j = 0; j != Dotes[i].Near.Count; j++)
                {
                    if ((Dotes[i].x <= Dotes[i].Near[j].x) && (Dotes[i].y <= Dotes[i].Near[j].y))
                    {
                        if (Dotes[i].x == Dotes[i].Near[j].x)
                            Lines.Add(new Line(Dotes[i].x, Dotes[i].y + DotSize / 2, Dotes[i].Near[j].x, Dotes[i].Near[j].y - DotSize / 2));
                        else
                            Lines.Add(new Line(Dotes[i].x + DotSize / 2, Dotes[i].y, Dotes[i].Near[j].x - DotSize / 2, Dotes[i].Near[j].y));
                        Lines[k].Dot = i;
                        Lines[k].DotN = Dotes[i].Near[j].no;
                        Lines[k].State = State[k];
                        k++;
                    }
                }
        }
        private void Button6_Click(object sender, EventArgs e) // Save matrix to file
        {
            string filename = @"D:\Users\Documents\MTUCI std\СиАОД\SIAOD\KTP-\KTP\Matrix.txt";
            string[] text = new string[Dotes.Count + Lines.Count + 1];

            int n = Convert.ToInt32(textBoxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);

            if (n < 10)
                text[0] = "C 0" + n + " " + m;
            else if (m < 10)
                text[0] = "C " + n + " 0" + m;
            else
                text[0] = "C " + n + " " + m;

            if ((n < 10) && (m < 10))
                text[0] = "C 0" + n + " 0" + m;

            for (var i = 0; i < Dotes.Count; i++)
            {
                if (Dotes[i].kol < 100)
                    if (Dotes[i].kol < 10)
                        Dotes[i].koll = " 00" + Dotes[i].kol;
                    else
                        Dotes[i].koll = " 0" + Dotes[i].kol;
                else
                    Dotes[i].koll = " " + Dotes[i].kol;
            }

            for (var i = 0; i < Dotes.Count; i++)
                if (i < 10)
                    text[i + 1] = "D 00" + i + " " + Dotes[i].State + Dotes[i].koll;
                else if (i < 100)
                    text[i + 1] = "D 0" + i + " " + Dotes[i].State + Dotes[i].koll;
                else
                    text[i + 1] = "D " + i + " " + Dotes[i].State + Dotes[i].koll;
            for (var i = Dotes.Count; i < Dotes.Count + Lines.Count; i++)
                if (i - Dotes.Count < 10)
                    text[i + 1] = "L 00" + (i - Dotes.Count) + " " + Lines[i - Dotes.Count].State;
                else if (i - Dotes.Count < 100)
                    text[i + 1] = "L 0" + (i - Dotes.Count) + " " + Lines[i - Dotes.Count].State;
                else
                    text[i + 1] = "L " + (i - Dotes.Count) + " " + Lines[i - Dotes.Count].State;

            File.WriteAllLines(filename, text);
        }
        //4.0-----------------------------------------------------------------------------------------------------
        private void Button7_Click(object sender, EventArgs e)// Chang Window, make Graphics and Stats
        {
            if (Gclick == false)
                Gclick = true;
            else Gclick = false;
            Window(Gclick);
        }
        public void Window(bool click)//Chang Window for Graphics and Stats
        {
            if (click == true)
            {
                Statis.Visible = true;
                chart1.Visible = true;

                this.Height = 750;
            }
            else
            {
                Statis.Visible = false;
                chart1.Visible = false;

                this.Height = 556;
            }
        }
        public void StatAndGraph(int time)// Make Graphics and Stats
        {
            int kolR = 0, kolI = 0, kolS = 0;
            //stats---------------------------------------------
            st = "Dotes №| State | Kol" + "\r\n";
            for (int i = 0; i < Dotes.Count; i++)
            {
                if (i < 100)
                    if (i < 10)
                        st = st + i + "            |" + Dotes[i].State + "         |" + Dotes[i].kol + "\r\n";
                    else
                        st = st + i + "          |" + Dotes[i].State + "         |" + Dotes[i].kol + "\r\n";
                else
                    st = st + i + "        |" + Dotes[i].State + "         |" + Dotes[i].kol + "\r\n";

                if (Dotes[i].State == 3)
                    kolS++;
                else if (Dotes[i].State == 2)
                    kolI++;
                else if (Dotes[i].State == 1)
                    kolR++;
            }
            Statis.Text = st;
            //graph---------------------------------------------
            grap.Series["SusGraph"].Points.AddY(kolS);
            grap.Series["RefGraph"].Points.AddY(kolR);
            grap.Series["InfGraph"].Points.AddY(kolI);
            chart1.Series[0].Points.Clear();
            chart1.Series["SusGraph"].Points.AddY(kolR);
            chart1.Series["SusGraph"].Points.AddY(kolI);
            chart1.Series["SusGraph"].Points.AddY(kolS);


        }
    }
}
