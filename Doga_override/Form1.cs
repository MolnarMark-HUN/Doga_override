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

        
        public Form1()
        {
            InitializeComponent();
            start();
            
        }
        public void start()
        {
            szamitogep one = new szamitogep() { type = "hehe", memorysize = 100, opsystem = "wind" };

            this.Controls.Add(one);
            szamitogep two = new szamitogep() { type = "rak", memorysize = 500, opsystem = "rakos" };

            this.Controls.Add(two);
        }
        

    }
}
