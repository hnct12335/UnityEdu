using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Sprite : UnityObject
{
    Texture2D texture;
    Texture2D associatedAlphaSplitTexture;
    



    public Sprite(string pass, string name): base(name)
    {
    }

    public override void Update()
    {
        Console.WriteLine("x:" + this.transform.postion.x.ToString());
    }






}

