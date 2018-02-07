using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateUserControl.Controls
{
    public partial class UserControlClock : UserControl
    {
        public UserControlClock()
        {
            InitializeComponent();
            this.reglage();

            this.timer1.Tick += Timer1_Tick;


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.reglage();
        }

        public void reglage()
        {
            this.label1.Text = DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss");
        }
    }
}
