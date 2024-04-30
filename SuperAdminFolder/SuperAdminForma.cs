using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginParol.SuperAdminFolder
{
    public partial class SuperAdminForma : Form
    {
        public SuperAdminForma()
        {
            InitializeComponent();
        }

        private void SuperAdminFaylgaKirish_Click(object sender, EventArgs e)
        {
            string PathSuperAdminFile = @"D:\pdp\lesson1\LoginParol\LoginParol\SuperAdminFolder\SuperAdminFile.txt";
            string sw = File.ReadAllText(PathSuperAdminFile);
            MessageBox.Show(sw);
        }
    }
}
