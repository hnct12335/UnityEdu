using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class GameObject : UnityObject
{
    public GameObject(string name) : base(name)
        {}
    public Transform transform;
}

