using LoginParol.AdminFolder;
using LoginParol.SuperAdminFolder;
using System.Text.Json;
using System;
using LoginParol.MijozFolder;

namespace LoginParol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RoyxatdanOtish royxatdanOtish = new RoyxatdanOtish();
            royxatdanOtish.Show();
        }
        private void btKirish_Click(object sender, EventArgs e)
        {
            List<Users> usersList = new List<Users>();

            string userFileText = @"D:\pdp\lesson1\LoginParol\LoginParol\user.txt";
            string[] users = File.ReadAllLines(userFileText);
            for(int i = 0; i < users.Length; i++) 
            {
                string[] usersLine = users[i].Split(',');
                usersList.Add(new Users { Id = usersLine[0], FIO = usersLine[1], Login = usersLine[2], Parol = usersLine[3], UserType = usersLine[4] });
            }
            int sanoq = 0;
            foreach (Users users1 in usersList)
            {
                if (users1.Login == tbLoginn.Text && users1.Parol == tbParoll.Text)
                {
                    sanoq++;
                    if(users1.UserType == "SuperAdmin")
                    {
                        string PathSuperAdminFolder = @"D:\pdp\lesson1\LoginParol\LoginParol\SuperAdminFolder";
                        string PathSuperAdminFile = @"D:\pdp\lesson1\LoginParol\LoginParol\SuperAdminFolder\SuperAdminFile.txt";
                        Directory.CreateDirectory(PathSuperAdminFolder);
                        StreamWriter streamWriter = File.CreateText(PathSuperAdminFile);
                        int index = 0;
                        foreach(Users users2 in usersList)
                        {
                            if (users2.UserType == "SuperAdmin")
                            {
                                continue;
                            }
                            streamWriter.WriteLine( index++.ToString() + "," + users2.FIO + "," + users2.Login + "," + users2.Parol + "," + users2.UserType + "\n");
                        }
                        streamWriter.Close();
                        this.Hide();
                        SuperAdminForma superAdminForma = new SuperAdminForma();
                        superAdminForma.Show();
                    }
                    else if (users1.UserType == "Admin")
                    {
                        string PathAdminFolder = @"D:\pdp\lesson1\LoginParol\LoginParol\AdminFolder";
                        string PathAdminFile = @"D:\pdp\lesson1\LoginParol\LoginParol\AdminFolder\AdminFile.txt";
                        Directory.CreateDirectory(PathAdminFolder);
                        StreamWriter streamWriter = File.CreateText(PathAdminFile);
                        int index = 0;
                        foreach (Users users2 in usersList)
                        {
                            if (users2.UserType == "Mijoz")
                            {
                                streamWriter.WriteLine(index++.ToString() + "," + users2.FIO + "," + users2.Login + "," + users2.Parol + "," + users2.UserType + "\n");
                            }
                        }
                        streamWriter.Close();
                        this.Hide();
                        AdminForma adminForma = new AdminForma();
                        adminForma.Show();
                    }
                    else if (users1.UserType == "Mijoz")
                    {
                        Users users3 = new Users();
                        
                        int index = 0;
                        foreach (Users users2 in usersList)
                        {
                            if (users2.Login == tbLoginn.Text && users2.Parol == tbParoll.Text)
                            {
                                users3.Id = users2.Id;
                                users3.FIO = users2.FIO;
                                users3.Login = users2.Login;
                                users3.Parol = users2.Parol;
                                users3.UserType = users2.UserType;
                            }
                        }
                        string jsonFile = JsonSerializer.Serialize(users3);
                        string PathMijozFolder = @"D:\pdp\lesson1\LoginParol\LoginParol\MijozFolder";
                        string PathMijozFile = @"D:\pdp\lesson1\LoginParol\LoginParol\MijozFolder\MijozFile.txt";
                        Directory.CreateDirectory(PathMijozFolder);
                        StreamWriter streamWriter = File.CreateText(PathMijozFile);
                        streamWriter.WriteLine(jsonFile);
                        streamWriter.Close();
                        this.Hide();
                        MijozForma mijozForma = new MijozForma();
                        mijozForma.Show();
                    }

                }
            }
            if(sanoq == 0) 
            {
                tbLoginn.Clear();
                tbParoll.Clear();
                MessageBox.Show("Login va Parol xato kiritildi.");
            }
        }

        
    }
}
