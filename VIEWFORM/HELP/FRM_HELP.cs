using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEWFORM.HELP
{
    public partial class FRM_HELP : Form
    {
        public int id = 0;
        public FRM_HELP()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (genericGridview.Rows.Count > 0) {
                id = (int)genericGridview.CurrentRow.Cells[0].Value;
            }
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
