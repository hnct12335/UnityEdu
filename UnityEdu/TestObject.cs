using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class TestObject : GameObject
{
    public TestObject(string s) : base(s)
    {
        Attach(new TestScript("testsc"));
        Attach(new SpriteRenderer("tori.png", "birdtest"));
    }
}

