using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnManualGrade_Click(object sender, EventArgs e)
        {
            this.mainConntent.Controls.Clear();
            var form = Program.MainServiceProvider.GetRequiredService<ManualGradingForm>();
            form.Dock = DockStyle.Fill;
            this.mainConntent.Controls.Add(form);

            UserProfile profile = new();
            this.pbxUserProfile.Image = profile.ProfileImage;
        }
    }
}
