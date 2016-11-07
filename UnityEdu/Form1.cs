using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnityEdu
{
    

    public partial class Form1 : Form
    {
        public GameObject obj0;
        SpriteRenderer Srend;

        Bitmap canvas;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            obj0 = new GameObject("obj0");
            Srend = new SpriteRenderer("tori.png", "SRendTori");

            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(canvas);
        }

        ~Form1()
        {
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image temp;
            temp = Srend.getImage();

            obj0.Instantiate(obj0);
            g.DrawImage(temp, 0, 0, temp.Width, temp.Height);
            pictureBox1.Image = canvas;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
