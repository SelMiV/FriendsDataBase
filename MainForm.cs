using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проект
{
    public partial class MainForm : Form
    {

        public void UpdateList()
        {
            List<Friend> Friends = SQLiteDataAccess.LoadPeopleList();

            Panel tmp = Friend_Panel_tmp;
            Label tmp_label = friendLFS_tmp;
            PictureBox tmp_pb = friendPicture_tmp;
            Label tmp_tel = Telefon_tmp;
            Label d_tmp = desc_tmp;

            //Удаляем все панельки
            for (int i = FriendList_FLP.Controls.Count - 1; i >= 0; i--)
            {
                Control control = FriendList_FLP.Controls[i];

                if (control is Panel panel && panel.Name != "Friend_Panel_tmp")
                {
                    FriendList_FLP.Controls.Remove(panel);
                    panel.Dispose();
                }
            }

            //Создаём панельки
            foreach (Friend f in Friends)
            {

                if (searchTextBox.Text != string.Empty)
                {
                    string lfs = $"{f.FirstName} {f.LastName} {f.SurName}".ToLower();

                    int i = lfs.IndexOf(searchTextBox.Text.ToLower());

                    if (i == -1)
                        continue;
                }


                Panel FC = new Panel();

                FC.Width = tmp.Width;
                FC.Height = tmp.Height;
                FC.BackColor = tmp.BackColor;
                FC.Name = $"FriendCard_{f.Id}";

                FC.Click += FC_Trigger;
                
                //фио
                Label FriendLFS = new Label();
                FC.Controls.Add(FriendLFS);

                FriendLFS.Location = tmp_label.Location;
                FriendLFS.Width = tmp_label.Width;
                FriendLFS.Height = tmp_label.Height;
                FriendLFS.Text = $"{f.LastName} {f.FirstName} {f.SurName}";
                FriendLFS.TextAlign = tmp_label.TextAlign;
                FriendLFS.ForeColor = tmp_label.ForeColor;

                //tel
                Label Telefon = new Label();
                FC.Controls.Add(Telefon);

                Telefon.Location = tmp_tel.Location;
                Telefon.Width = tmp_tel.Width;
                Telefon.Height = tmp_tel.Height;

                if (f.PhoneNumber.Length > 5)
                {
                    string Tel = $"7{f.PhoneNumber.ToString()}";
                    string Maska = '+' + Tel.Substring(0, 1) + '-' + Tel.Substring(1, 3) + '-' + Tel.Substring(4, 3) + '-' + Tel.Substring(7, 2) + '-' + Tel.Substring(9, 2);
                    Telefon.Text = $"{Maska}";
                }
                Telefon.TextAlign = tmp_tel.TextAlign;
                Telefon.ForeColor = tmp_tel.ForeColor;

                //short description
                Label ShDesc = new Label();
                FC.Controls.Add(ShDesc);

                ShDesc.Location = d_tmp.Location;
                ShDesc.Width = d_tmp.Width;
                ShDesc.Height = d_tmp.Height;
                ShDesc.Text = $"{f.Description}";
                ShDesc.TextAlign = d_tmp.TextAlign;
                ShDesc.ForeColor = d_tmp.ForeColor;

                //ава
                PictureBox Avatar = new PictureBox();
                FC.Controls.Add(Avatar);

                Avatar.Width = tmp_pb.Width;
                Avatar.Height = tmp_pb.Height;
                Avatar.BackColor = tmp_pb.BackColor;
                Avatar.Location = tmp_pb.Location;
                Avatar.SizeMode = tmp_pb.SizeMode;

                if (!string.IsNullOrEmpty(f.PhotoPath) && System.IO.File.Exists(f.PhotoPath))
                {
                    try
                    {
                        Avatar.Image = Image.FromFile(f.PhotoPath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image: {ex.Message}");
                        Avatar.Image = null;
                    }
                }
                else
                {
                    Avatar.Image = tmp_pb.Image;
                }

                //3 строчки кода из дипсика, шоб контролс прозрачные были
                foreach (Control child in FC.Controls)
                {
                    child.MouseDown += (s, e) => FC_Trigger(FC, e); // Перенаправляем клик
                    child.Cursor = Cursors.Default; // Курсор как у родителя
                }

                FriendList_FLP.Controls.Add(FC);
            }

            searchTextBox.Text = string.Empty;
        }

        private void FC_Trigger(object sender, EventArgs e)
        {
            Panel FC = sender as Panel;

            string s = FC.Name;
            int id = Convert.ToInt32(s.Substring(s.IndexOf('_') + 1));

            MessageBox.Show($"Панель была нажата! {id}");

            Friend friend = SQLiteDataAccess.LoadPeople(id);

            FriendCardForm Card = new FriendCardForm(friend);
            Card.ShowDialog();

            UpdateList();
        }

        private void Search_IB_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{searchTextBox.Text}");
            UpdateList();
        }

        public MainForm()
        {
            InitializeComponent();

            UpdateList();
        }
        private void addFriendButton_Click(object sender, EventArgs e)
        {
            AddFriendForm addfriendCardForm = new AddFriendForm();  // функция перехода в окно с картой друга по фотке
            addfriendCardForm.ShowDialog();

            UpdateList();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Friend_Panel_tmp_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
