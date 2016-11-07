using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
public class SpriteRenderer : Renderer
{
    public Sprite sprite;
    Image image;

    public SpriteRenderer(string pass, string name):base(name)
    {
        image = Image.FromFile(pass);
    }

    ~SpriteRenderer()
    {
        image.Dispose();
    }

    public Image getImage()
    {
        return image;
    }

}

