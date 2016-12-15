using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace UnityEdu
{
    static class Program
    {
        static Form1 f;
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            f = new Form1();
            Application.Run(f);
        }

        static public void Draw(Image img, float x, float y){
            f.Draw(img, x, y);
        }
    }
}
