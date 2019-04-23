using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PDFApp.Forms;

namespace PDFApp
{
    public partial class MainForm : CCSkinMain
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tvMain.ExpandAll();
        }

        private void tsbAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void tsbEditBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void tsbDelBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ɾ��ʧ�ܣ�");
        }

        private void tsbPicsManager_Click(object sender, EventArgs e)
        {
            PicsForm picsForm = new PicsForm();
            picsForm.ShowDialog();
        }

        private void tsbExportPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����ʧ�ܣ�");
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��ӡʧ�ܣ�");
        }
    }
}
