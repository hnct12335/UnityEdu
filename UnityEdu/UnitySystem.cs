using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



static public class UnitySystem
{
    static List<UnityObject> hierarcy = new List<UnityObject>();


    public static void AddNewObject(UnityObject obj)
    {
        hierarcy.Add(obj);
    }
}
