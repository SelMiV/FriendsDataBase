using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace проект
{
    public partial class FriendCardForm : Form
    {
        private Friend _friend;

        public FriendCardForm(Friend friend)
        {
            InitializeComponent();
            _friend = friend;
            LoadFriend();
        }

        private void LoadFriend()
        {
            if (_friend != null)
            {
                LastNameTL.Text = _friend.LastName;
                FirstNameTL.Text = _friend.FirstName;
                SurNameTL.Text = _friend.SurName;
                PhoneTL.Text = _friend.PhoneNumber;
                DateTL.Text = _friend.Date;
                FullDescTL.Text = _friend.FullDescription;


                if (!string.IsNullOrEmpty(_friend.PhotoPath) && System.IO.File.Exists(_friend.PhotoPath))
                {
                    try
                    {
                        photoPictureBox.Image = Image.FromFile(_friend.PhotoPath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image: {ex.Message}");
                        photoPictureBox.Image = null;
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddFriendForm addFriendForm = new AddFriendForm(_friend); // функция перехода в окно добавления друга по кнопке
            addFriendForm.ShowDialog();

            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close(); // функция закрытия окна по кнопке
        }

        private void deliteButton_Click(Object sender, EventArgs e)
        {
            SQLiteDataAccess.DeletePeople(_friend.Id);
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void FriendCardForm_Load(object sender, EventArgs e)
        {

        }
    }
}