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
        //Start();
        n = 0;
    }

    public void Start()
    {
        MessageBox.Show(name + ".Start()");
        Random rnd = new Random();
        this.transform.postion.x = 0;
        this.transform.postion.y = 0;
        MessageBox.Show("Start()");
    }

    public override void Update()
    {
        //MessageBox.Show(name + ".Update()");
        //MessageBox.Show("Update()\nn="+n.ToString());
        this.transform.postion.x+=1;
        this.transform.postion.y += 2;
        //MessageBox.Show(this.transform.postion.x.ToString() +","+ this.transform.postion.y.ToString());
        n++;
    }
}