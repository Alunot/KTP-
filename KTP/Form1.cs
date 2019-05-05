using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace KTP
{    
    public partial class Form1 : Form
    {
        int DotSize = 20;
        int LineSize = 3;

        Bitmap bmp;
        Graphics mat;
        Pen heal, inf, ill, lne;

        Dot dot;
        Line line;

        List<Dot> Dotes = new List<Dot>();
        List<Line> Lines = new List<Line>();
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(picture.Width, picture.Height);
            mat = Graphics.FromImage(bmp);

            Pen heal = new Pen(Color.Green, 5);
            Pen inf = new Pen(Color.Yellow, 5);
            Pen ill = new Pen(Color.Red, 5);
            Pen lne = new Pen(Color.Black, 5);
        }
        private void Button1_Click(object sender, EventArgs e) //Drow Matrix with Green Dots and Lines
        {
            int n = Convert.ToInt32(textBoxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);

            Dotes.Clear();
            Lines.Clear();
            mat.Clear(Color.White);

            Draw(n, m);
            picture.Image = bmp;
        }                 
        private void Draw(int n, int m) //Draw Matrix with Green Dots
        {
            Dot(n, m);
            Lin(n, m);

            Pen lne = new Pen(Color.Gray, LineSize);

            for (var i = 0; i < Lines.Count; i++)
                mat.DrawLine(lne, Lines[i].xS, Lines[i].yS, Lines[i].xF, Lines[i].yF);

            SolidBrush mySolidBrush = new SolidBrush(Color.Green);
            for (var i = 0; i < Dotes.Count; i++)
                mat.FillEllipse(mySolidBrush, Dotes[i].x- DotSize/2, Dotes[i].y- DotSize / 2, DotSize, DotSize);
            
            if (Coord.Checked == true)//Drow № of Dots 
            {
                mySolidBrush.Dispose();
                for (int i = 0; i < Dotes.Count; i++)
                    mat.DrawString("(" + Dotes[i].i + "|" + Dotes[i].j + ")", new Font("Arial", 12), Brushes.Black, Dotes[i].x - 20, Dotes[i].y - 10 - DotSize);
            }         
        }
        public void Dot(int n, int m)//return Dots List
        {
            int Lenght;

            if (picture.Width / (n + 1) > picture.Height / (m + 1))
                Lenght = picture.Height / (m);
            else
                Lenght = picture.Width / (n);

            int[] DotX = new int[n];
            int[] DotY = new int[m];
            for (var i = 0; i < n; i++)
                DotX[i] = Lenght / 2 + Lenght * i;
            for (var i = 0; i < m; i++)
                DotY[i] = Lenght / 2 + Lenght * i;

            for (var i = 0; i < n; i++)
                for (var j = 0; j < m; j++)
                    Dotes.Add(new Dot(i, j, DotX[i], DotY[j]));
        }
        public void Lin(int n, int m)//return Lines List
        {
            Near(n, m);
            for (int i = 0; i != n * m; i++)
                for (int j = 0; j != 4; j++)
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
            }
            for (int i = n * m - 1; i > 0; i--)
            {
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
    }
}
