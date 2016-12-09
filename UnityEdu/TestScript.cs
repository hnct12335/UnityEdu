using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class TestScript : MonoBehaviour
{
    int n;
    public TestScript(string s):base(s)
    {
        Start();
        n = 0;
    }

    void Start()
    {
        MessageBox.Show("Start()");
    }

    public override void Update()
    {
        MessageBox.Show("Update()\nn="+n.ToString());
        this.transform.postion.x+=1;
        n++;
    }
}