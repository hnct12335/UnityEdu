using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class TestObject : UnityObject
{
    public TestScript testscript;
    public TestObject(string s) : base(s)
    {
        testscript = new TestScript("testsc");
    }
}

