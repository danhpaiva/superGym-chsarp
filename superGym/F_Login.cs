using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superGym
{
    public partial class F_Login : Form
    {
        F_Principal f_Principal;
        public F_Login(F_Principal f)
        {
            InitializeComponent();
            f_Principal = f;
        }
    }
}
