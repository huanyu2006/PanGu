using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanGu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            log4net.LogManager.GetLogger("root").Info("sdfsdfsd");
        }
    }
}
