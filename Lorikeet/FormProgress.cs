using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lorikeet
{
    public partial class FormProgress : Form
    {
        public FormProgress(int maxCount)
        {
            InitializeComponent();
           
            progressBarControl.Properties.Step = 1;
            progressBarControl.Properties.PercentView = true;
            progressBarControl.Properties.Maximum = maxCount;
            progressBarControl.Properties.Minimum = 0;
            progressBarControl.ShowProgressInTaskBar = true;
        }

        public void StepProgress()
        {
            progressBarControl.PerformStep();
            progressBarControl.Update();
        }
    }
}
