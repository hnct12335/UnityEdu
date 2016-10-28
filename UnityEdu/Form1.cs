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

        Bitmap canvas;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            obj0 = new GameObject();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(canvas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj0.Instantiate(obj0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
