using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga_override
{
    public partial class Form1 : Form
    {
        public Button button1 = new Button();
        aru newaru = new aru();
        public Form1()
        {
            InitializeComponent();
            start();
            newaru.buttonname();
        }
        public void start()
        {
            this.Controls.Add(button1);
        }
        

    }
}
