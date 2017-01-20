using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;



public class UnityObject
{
    public string name;

    bool DestroyFlag;
    public Transform transform;
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


    public static T Instantiate<T>(T original) where T : UnityObject
    {
        Vector3 temp;
        temp.x = 0;
        temp.y = 0;
        temp.z = 0;
        return Instantiate(original, temp);
    }

    public static T Instantiate<T>(T original, Vector3 position) where T : UnityObject
    {
        MessageBox.Show("Instantiate");

        T obj = (T)Activator.CreateInstance(typeof(T), original.name + "_copy");
            
//            new UnityObject(original.name + "_copy");
        obj.transform = new Transform(original.name+"trans");

        UnitySystem.AddNewObject(obj);

        return obj;
    }

    public virtual void Update() { }

    ~UnityObject()
    {
        MessageBox.Show("デストラクト" + name);
    }
}
