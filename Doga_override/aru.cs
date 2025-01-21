using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga_override
{
    public class aru:UserControl
    {
        public int price { get; set; }
        public string name { get; set; }
        Form1 f = new Form1();

        public void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // aru
            // 
            this.Name = "aru";
            this.Size = new System.Drawing.Size(160, 150);
            this.ResumeLayout(false);
            buttonname();
        }
        public virtual void buttonclick(Object s,EventArgs e)
        {
            f.button1.Click += (ss, ee) =>
            {
                MessageBox.Show(price.ToString());
            };
        }
        public virtual void buttonname()
        {
            f.button1.Text = name;
        }
    }
        
}
