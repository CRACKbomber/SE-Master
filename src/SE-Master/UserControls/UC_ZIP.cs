using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEMaster.FileFormats;

namespace SE_Master.UserControls
{
    public partial class UC_ZIP : UserControl
    {
		// XZP2Pack _zipPack;
        public UC_ZIP()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // TODO: Handle if a zip is already open.
            using var fdlg = new OpenFileDialog()
            {
                Title = "SE Master | Select a 360.zip file",
                InitialDirectory = @"c:\",
                Filter = "360.zip (*.360.zip)|*.360.zip",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                var path = fdlg.FileName;
                textBox1.Text = path;

                // _zipPack = new XZP2Pack(File.OpenRead(path));

                // TODO: Fill treeview or whatever with zip directory (_zipPack.ZipEntries)


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HelpBoxZip infoForm = new();
            infoForm.ShowDialog();
        }
    }
}
