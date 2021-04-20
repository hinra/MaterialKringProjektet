using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class2Table {
    class myButton : Button, IComponent {
        public myButton() {

            BackColor = Color.Red; 
        }
    }
}
