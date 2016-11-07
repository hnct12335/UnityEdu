using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public class Transform : Component
{
    public Vector3 postion;

    public Transform(string name) : base(name)
    {
        postion.x = 0;
        postion.y = 0;
        postion.z = 0;
    }
}
