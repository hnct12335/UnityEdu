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
        //SpriteRenderer Srend;
        public TestObject obj1;

        Bitmap canvas;
        Graphics g;



        public Form1()
        {
            InitializeComponent();
            obj0 = new GameObject("obj0");
            //Srend = new SpriteRenderer("tori.png", "SRendTori");
            

            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(canvas);
        }

        

        ~Form1()
        {
            g.Dispose();
        }

        public void Draw(Image img, int x, int y)
        {
            //MessageBox.Show("drow()");
            g.DrawImage(img, x, y, img.Width, img.Height);
            pictureBox1.Image = canvas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj1 = new TestObject("TestObj"); 
            MessageBox.Show(obj1.GetComponent<Transform>().x.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj0.Instantiate(obj1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj1.Update();

        }


    }
}
