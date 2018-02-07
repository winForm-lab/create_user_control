using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateUserControl.Controls
{
   public  class IntTextBox : TextBox
    {

        private int _value;

        public IntTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // IntTextBox
            // 
            this.TextChanged += new System.EventHandler(this.IntTextBox_TextChanged);
            this.ResumeLayout(false);

        }

        private void IntTextBox_TextChanged(object sender, EventArgs e)
        {
            string value = this.Text;
            int int_value;
            bool isInt =  int.TryParse(value, out int_value);
            if (isInt)
            {
               
            }
               
            else
            {
                MessageBox.Show("You must set int value");
                this.Text = _value.ToString();
            }


        }
    }
}
