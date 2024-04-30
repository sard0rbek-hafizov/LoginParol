using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginParol
{
    public partial class RoyxatdanOtish : Form
    {

        public RoyxatdanOtish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userFileText = @"D:\pdp\lesson1\LoginParol\LoginParol\user.txt";
            string users = File.ReadAllText(userFileText);
            string[] users1 = File.ReadAllLines(userFileText);
            if (tbFIO.Text.Length > 0 && tbLogin.Text.Length > 0 && tbParol.Text.Length > 0)
            {
                if (!users.Contains(tbLogin.Text))
                {
                    File.AppendAllText(userFileText, (users1.Length + 1).ToString() + "," + tbFIO.Text + "," + tbLogin.Text + "," + tbParol.Text + "," + UserType.Mijoz + "\n");
                    MessageBox.Show("Muvaffaqiyatli yuklandi.");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Bunday foydalanuvchi oldin ro'yxatdan o'tgan.");
                    
                }

            }
            else if (tbFIO.Text.Length > 0 && tbLogin.Text.Length > 0)
            {
                MessageBox.Show("Siz Parolni kiritmadingiz.");
            }
            else if (tbFIO.Text.Length > 0 && tbParol.Text.Length > 0)
            {
                MessageBox.Show("Siz Loginni kiritmadingiz.");
            }
            else if (tbLogin.Text.Length > 0 && tbParol.Text.Length > 0)
            {
                MessageBox.Show("Siz Familiya Ism Otasini Ismini kiritmadingiz. ");
            }
            else
            {
                MessageBox.Show("Siz bo'sh qiymat kiritdingiz.");
            }
        }
        enum UserType
        {
            SuperAdmin,
            Admin,
            Mijoz
        }

        private void tbFIO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
