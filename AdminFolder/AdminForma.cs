using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginParol.AdminFolder
{
    public partial class AdminForma : Form
    {
        public AdminForma()
        {
            InitializeComponent();
        }

        private void btAdminFaylgaKirish_Click(object sender, EventArgs e)
        {
            string PathSuperAdminFile = @"D:\pdp\lesson1\LoginParol\LoginParol\AdminFolder\AdminFile.txt";
            string sw = File.ReadAllText(PathSuperAdminFile);
            MessageBox.Show(sw);
        }
    }
}
