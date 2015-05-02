using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriangleLibrary;

namespace task_4_winform
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen = new Pen(Color.Blue, 2F);

        private PointOfTriangle[] points = new PointOfTriangle[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textAX.Text, out points[0].X) && int.TryParse(textAY.Text, out points[0].Y)
                && int.TryParse(textBX.Text, out points[1].X) && int.TryParse(textBY.Text, out points[1].Y)
                && int.TryParse(textCX.Text, out points[2].X) && int.TryParse(textCY.Text, out points[2].Y))
	        {
                try
                {

                    Triangle triangle = new Triangle(points[0], points[1], points[2]);
                    Point[] p = new Point[3];
                    p[0].X = points[0].X;
                    p[0].Y = points[0].Y;
                    p[1].X = points[1].X;
                    p[1].Y = points[1].Y;
                    p[2].X = points[2].X;
                    p[2].Y = points[2].Y;
                    g = pictureBox1.CreateGraphics();
                    g.Clear(pictureBox1.BackColor);
                    g.DrawPolygon(pen, p);
                    textBoxSide1.Text = triangle.SideFirst.ToString();
                    textBoxSide2.Text = triangle.SideSecond.ToString();
                    textBoxSide3.Text = triangle.SideThird.ToString();
                    CalculateWithSides(triangle);
                }
                catch (ArgumentException ex)
                {
                    label1.Text = "Uncorrect triangle"; 
                }
	        }
            else
            {
                label1.Text = "Some of input text isn't a point";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Close();
            double sideFirst;
            double sideSecond;
            double sideThird;
            if (double.TryParse(textBoxSide1.Text, out sideFirst) && sideFirst > 0
                && double.TryParse(textBoxSide2.Text, out sideSecond) && sideSecond > 0
                && double.TryParse(textBoxSide3.Text, out sideThird) && sideThird > 0)
            {
                try
                {
                    CalculateWithSides(new Triangle(sideFirst, sideSecond, sideThird));
                }
                catch (Exception ex)
                {
                    label1.Text = "Uncorrect triangle";
                }
                
            }
        }
        private void CalculateWithSides(Triangle triangle)
        {
            textBoxForPerimeter.Text = triangle.GetPerimeter().ToString();
            textBoxForSquare.Text = triangle.GetSquare().ToString();
        }
    }
}
