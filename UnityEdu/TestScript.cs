using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class TestScript : MonoBehaviour
{
    public TestScript(string s):base(s)
    {
        Start();
    }

    void Start()
    {
        MessageBox.Show("Start()");
    }

    public void Update()
    {
        MessageBox.Show("Update()");
    }
}