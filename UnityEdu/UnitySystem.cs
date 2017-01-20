using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



static public class UnitySystem
{
    public static List<UnityObject> hierarcy = new List<UnityObject>();


    public static void AddNewObject(UnityObject obj)
    {
        hierarcy.Add(obj);
    }

    public static void Update()
    {
        foreach (UnityObject obj in hierarcy)
        {
            obj.Update();
        }
    }
}
