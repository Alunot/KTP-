using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Timer = System.Timers.Timer;
using System.Threading;



namespace KTP
{    
    public partial class Form1 : Form
    {
        int DotSize = 20;
        int LineSize = 3;

        int TimeChek = 0;

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
        private void Button1_Click(object sender, EventArgs e) //Drow Matrix with Green Dots and Lines
        {           
            Dotes.Clear();
            Lines.Clear();
            mat.Clear(Color.White);

            Draw();
            picture.Image = bmp;
        }                 
        private void Draw() //Draw Matrix with Yellow Dots
        {
            int n = Convert.ToInt32(textBoxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);
            Dot(n, m);
            Lin(n, m);

            DotSize = 240/(n+m);

            for (var i = 0; i < Lines.Count; i++)
                Draw(Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);

            for (var i = 0; i < Dotes.Count; i++)
                Draw(Dotes[i].State, Dotes[i].x, Dotes[i].y);
            
            if (Coord.Checked == true)//Draw Cord of Dots             
                for (int i = 0; i < Dotes.Count; i++)
                    mat.DrawString("(" + Dotes[i].i + "|" + Dotes[i].j + ")", new Font("Arial", 10), Brushes.Black, Dotes[i].x - 14, Dotes[i].y - 6 - DotSize);
            if (DotN.Checked == true)//Draw № of Dots             
                for (int i = 0; i < Dotes.Count; i++)
                    mat.DrawString("(" + i + ")", new Font("Arial", 8), Brushes.Black, Dotes[i].x+DotSize / 4, Dotes[i].y+ DotSize / 4);
        }        
        private void Draw(int Color, int x, int y)//Draw Dots
        {
            if (Color==1)
                mat.FillEllipse(Rem, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
            else if (Color == 2)
                mat.FillEllipse(Inf, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
            else if (Color == 3)
                mat.FillEllipse(Sus, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
            else if (Color == 0)
                mat.FillEllipse(Del, x - DotSize / 2, y - DotSize / 2, DotSize, DotSize);
        }
        private void Draw(int xS, int yS, int xF, int yF)//Draw Lines
        {
            Pen lne = new Pen(Color.Gray, LineSize);
            mat.DrawLine(lne, xS, yS, xF, yF);
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
        }
        public void Lin(int n, int m)//return Lines List
        {
            Near(n, m);
            for (int i = 0; i != n * m; i++)
                for (int j = 0; j != Dotes[i].Near.Count; j++)
                {
                    if (((Dotes[i].i != 0) || (Dotes[i].j != 0) || (Dotes[i].i != n) || (Dotes[i].j != m)) && (j != 3))
                        if ((((Dotes[i].i != 0) && (Dotes[i].j != 0)) || ((Dotes[i].i != 0) && (Dotes[i].i != n)) || ((Dotes[i].i != 0) && (Dotes[i].j != m)) || ((Dotes[i].j != m) && (Dotes[i].i != n))) && (j != 2))
                            Lines.Add(new Line(Dotes[i].x, Dotes[i].y, Dotes[i].Near[j].x, Dotes[i].Near[j].y));
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
            Dotes.Clear();
            Lines.Clear();
            mat.Clear(Color.White);
            picture.Image = bmp;
        }

        public void Button3_Click(object sender, EventArgs e)//Start/Stop Simulation
        {
            timer1.Interval = 100000/Convert.ToInt32(textBoxSpeed.Text);           
            Dotes[Convert.ToInt32(textBoxDot1.Text)].State=3;
            Dotes[Convert.ToInt32(textBoxDot1.Text)].Time = TimeChek + Convert.ToInt32(textBoxTime.Text);

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
            for (int i =0;i != Dotes[Dot].Near.Count; i++)
                if ((Chance > Chan.Next(0, 100)) && (Dotes[Dot].Near[i].State == 3))
                {
                    Dotes[Dot].State = 3;
                    Dotes[Dot].Time = TimeChek + Time;
                }
        }
        private void Susceptible(int Dot)// Ifected 3
        {
            if ((Dotes[Dot].Time != 0) && (TimeChek >= Dotes[Dot].Time))
                Dotes[Dot].State = 1;
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
        }
        private void Button4_Click(object sender, EventArgs e)// Reset
        {
            Dotes.Clear();
            Lines.Clear();
            mat.Clear(Color.White);

            Draw();

            timer1.Interval = 100000 / Convert.ToInt32(textBoxSpeed.Text);
            Dotes[Convert.ToInt32(textBoxDot1.Text)].State = 3;
            Dotes[Convert.ToInt32(textBoxDot1.Text)].Time = TimeChek + Convert.ToInt32(textBoxTime.Text);

            picture.Image = bmp;

            timer1.Enabled = true;
        }
    }
}
