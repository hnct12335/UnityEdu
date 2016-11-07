using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;



public class UnityObject
{
    public string name;

    bool DestroyFlag;

    public UnityObject(string s)
    {
        DestroyFlag = false;
        this.name = s;
        MessageBox.Show("コンストラクト" + name);
    }

    public void Destroy(UnityObject obj, float t)
    {
        DestroyFlag = true;
    }


    public void Instantiate(UnityObject original)
    {
        Vector3 temp;
        temp.x = 0;
        temp.y = 0;
        temp.z = 0;
        Instantiate(original, temp);
    }

    public static Object Instantiate(UnityObject original, Vector3 position)
    {
        UnityObject obj = new UnityObject(original.name + "_copy");

        UnitySystem.AddNewObject(obj);

        return original;
    }

    ~UnityObject()
    {
        MessageBox.Show("デストラクト" + name);
    }
}
