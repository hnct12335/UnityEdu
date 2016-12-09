using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
public class SpriteRenderer : Renderer
{
    public Sprite sprite;
    Image image;


    public SpriteRenderer(string pass, string name):base(name)
    {
        image = Image.FromFile(pass);
        sprite = new Sprite(pass, name);
    }

    ~SpriteRenderer()
    {
        image.Dispose();
    }

    public override void Update()
    {
        UnityEdu.Program.Draw(image, this.transform.postion.x, this.transform.postion.y);
    }

}

