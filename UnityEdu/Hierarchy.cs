using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Hierarchy
{
    List<UnityObject> obj;
    List<MonoBehaviour> Script;

    public Hierarchy()
    {
        obj = new List<UnityObject>();
        Script = new List<MonoBehaviour>();
    }

    public void Update()
    {
        for (int i = 0; i < obj.Count; i++)
        {
            
        }
    }
}