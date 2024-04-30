using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginParol.MijozFolder
{
    public partial class MijozForma : Form
    {
        public MijozForma()
        {
            InitializeComponent();
        }

        private void btMijozKirish_Click(object sender, EventArgs e)
        {
            string PathMijozFile = @"D:\pdp\lesson1\LoginParol\LoginParol\MijozFolder\MijozFile.txt";
            string sw = File.ReadAllText(PathMijozFile);
            MessageBox.Show(sw);
        }
    }
}
