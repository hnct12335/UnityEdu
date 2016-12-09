using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


public class GameObject : UnityObject
{
    List<Component> Components;
    public Transform transform;
    public GameObject(string name)
        : base(name)
    {
        transform = new Transform(name);
        Components = new List<Component>();
    }

    public void Attach(Component com)
    {
  
        Components.Add(com);
        com.transform = this.transform;
    }

    public override void Update()
    {
        foreach (UnityObject i in Components)
        {
            MessageBox.Show("Update呼び出し");
            i.Update();
        }
    }

}

