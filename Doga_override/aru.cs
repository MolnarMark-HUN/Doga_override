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
        public Button button1;

        public int price { get; set; }
        public string name { get; set; }
        public aru()
        {
            InitializeComponent();
            buttonname();
            buttonclick();
        }
        public void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aru
            // 
            this.Controls.Add(this.button1);
            this.Name = "aru";
            this.Size = new System.Drawing.Size(160, 150);
            this.ResumeLayout(false);

        }
        public virtual void buttonclick()
        {
            button1.Click += (ss, ee) =>
            {
                MessageBox.Show(price.ToString());
            };
        }
        public virtual void buttonname()
        {
            button1.Text = name;
        }
    }
        
}
