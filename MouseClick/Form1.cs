using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int VirtualKeyPressed);

        int lcounter = 0;
        //LeftButton
        public int GetLeftMousePressed()
        {
            if (GetAsyncKeyState(0x01) == 0)
            {
                //MessageBox.Show("aaa");
                return 0;
            }
            else
            {
                //MessageBox.Show("bbb");
                label1.Text = lcounter.ToString();
                lcounter++;
                return lcounter;
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetLeftMousePressed();
            
        }

        // 0x01 stands for left Mouse click
        // for different Virtual-Keys view list:
        // https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
    }
}
