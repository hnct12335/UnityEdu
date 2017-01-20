using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public class TestObject : GameObject
{
    public TestObject(string s) : base(s)
    {
        MessageBox.Show("TestObject:"+name+"生成");
        Attach(new TestScript("testsc"));
        Attach(new SpriteRenderer("tori.png", "birdtest"));
    }
}

