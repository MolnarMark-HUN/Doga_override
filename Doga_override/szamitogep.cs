using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga_override
{
    class szamitogep :aru
    {
        Form1 f = new Form1();
        public string type { get; set; }
        public int memorysize { get; set; }
        public string opsystem { get; set; }
        public szamitogep()
        {


        }
        
        public override void buttonclick(object s, EventArgs e)
        {
            f.button1.Click += (es, se) =>
            {
                MessageBox.Show($"Típus:{type}, Memoriaméret:{memorysize}, Operationsystem:{opsystem}");
            };
        }
    }
}
