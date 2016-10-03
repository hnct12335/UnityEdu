using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;



public class UnityObject
{
    bool DestroyFlag;

    public UnityObject()
    {
        DestroyFlag = false;
        MessageBox.Show("コンストラクト");
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
        UnityObject obj = new UnityObject();

        UnitySystem.AddNewObject(obj);

        return original;
    }

    ~UnityObject()
    {
        MessageBox.Show("デストラクト");
    }
}
