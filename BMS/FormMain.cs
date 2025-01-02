using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class FormMain : Form
    {
        public FormMain(ManualGradingForm frm)
        {
            InitializeComponent();

            var form = new ManualGradingForm();
            form.Dock = DockStyle.Fill;
            this.mainConntent.Controls.Add(form);
        }
    }
}
