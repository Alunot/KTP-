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
        Bitmap bmp;
        Graphics mat;
        Pen heal, inf, ill, lin;

        Dot dot;
        Line line;

        List<Dot> Dotes = new List<Dot>();
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(picture.Width, picture.Height);
            mat = Graphics.FromImage(bmp);

            heal = new Pen(Color.Green);
            inf = new Pen(Color.Yellow);
            ill = new Pen(Color.Red);
            lin = new Pen(Color.Black);            

        }
        private void Button1_Click(object sender, EventArgs e)
        {            
            Matrix();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            mat.Clear(Color.White);
            picture.Image = bmp;
        }
        private void Matrix()
        {            
            int n = Convert.ToInt32(textBoxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);

            mat.Clear(Color.White);
            Draw(n, m);
            picture.Image = bmp;
        }      
        private void Draw(int n, int m) //Drow Matrix with Green Dots
        {
            Dot(n, m);
            SolidBrush mySolidBrush = new SolidBrush(Color.Green);
            for (var i = 0; i < Dotes.Count; i++)
                mat.FillEllipse(mySolidBrush, Dotes[i].x, Dotes[i].y, 10, 10);

            if (Coord.Checked == true)
            {
                mySolidBrush.Dispose();
                for (int i = 0; i < Dotes.Count; i++)
                    mat.DrawString("(" + Dotes[i].i + "|" + Dotes[i].j + ")", new Font("Arial", 12), Brushes.Black, Dotes[i].x - 15, Dotes[i].y - 33);
            }
            Ner(n, m);


        }

        private void Dot(int n, int m)
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
        private void Ner(int n, int m)
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
        private void lne(int n, int m)
        {

        }
    }
}
