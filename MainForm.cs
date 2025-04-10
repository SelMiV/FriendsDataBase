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
            this.FriendListLB.Items.Clear();

            List<Friend> Friends = SQLiteDataAccess.LoadPeopleList();

            foreach (Friend Friend in Friends)
            {
                //Console.WriteLine($"{Friend.Id} {Friend}");

                this.FriendListLB.Items.Add($"ID: [{Friend.Id}]\t{Friend.FirstName} {Friend.LastName} {Friend.SurName}");
            }
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
                
        private void searchButton_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.FriendListLB.SelectedIndex != -1)
            {
                string s = this.FriendListLB.SelectedItem.ToString();

                int i1 = s.IndexOf("[")+1;
                int i2 = s.IndexOf("]");

                int ID = Convert.ToInt32(s.Substring(i1, i2 - i1));

                //MessageBox.Show($"Вы выбрали: {ID}");
            
                Friend friend = SQLiteDataAccess.LoadPeople(ID);

                FriendCardForm Card = new FriendCardForm(friend);
                Card.ShowDialog();
                
                UpdateList();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
