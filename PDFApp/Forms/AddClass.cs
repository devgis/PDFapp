using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDFApp.Forms
{
    public partial class AddClass : CCSkinMain
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void tsbPicsManager_Click(object sender, EventArgs e)
        {
            PicsForm picsForm = new PicsForm();
            picsForm.ShowDialog();
        }
    }
}
