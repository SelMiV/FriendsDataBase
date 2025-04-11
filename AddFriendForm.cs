using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace проект
{
    public partial class AddFriendForm : Form
    {
        public Friend NewFriend { get; set; }
        public AddFriendForm()
        {
            InitializeComponent();
            InitializeValidation();
        }

        public AddFriendForm(Friend Friend)
        {
            InitializeComponent();
            InitializeValidation();

            this.NewFriend = Friend;

            photoPathTextBox.Text = Friend.PhotoPath;
            lastNameTextBox.Text = Friend.LastName;
            firstNameTextBox.Text = Friend.FirstName;
            surNameTextBox.Text = Friend.SurName;
            descriptionTextBox.Text = Friend.Description;
            fulldescriptionTextBox.Text = Friend.FullDescription;
            phoneTextBox.Text = Friend.PhoneNumber;
            lfsTextBox.Text = Friend.LFS;
            NewFriend.Id = Friend.Id;

            addFriendButton.Text = "Закончить редактирование";
        }


        private void InitializeValidation()
        {
            firstNameErrorLabel.Text = "";
            firstNameErrorLabel.Visible = false;
            phoneErrorLabel.Text = "";
            phoneErrorLabel.Visible = false;

            UpdateAddButtonState();
        }

        private void AddFriendForm_Load(object sender, EventArgs e)
        {
            phoneTextBox.Mask = "+7(999) 999 99-99";
            phoneTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            UpdateAddButtonState();
        }

        private void browsePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog1.Title = "Выберите фото";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoPathTextBox.Text = openFileDialog1.FileName;
                try
                {
                    photoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось открыть выбранный файл. Ошибка: " + ex.Message);
                    photoPathTextBox.Text = string.Empty;
                    photoPictureBox.Image = null;
                }
            }
        }


        private void addFriendButton_Click(object sender, EventArgs e)
        {
            string photoPath = photoPathTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string firstName = firstNameTextBox.Text.Trim();
            string surName = surNameTextBox.Text.Trim();
            string date = dateDateTimePicker.Value.ToShortDateString();
            string description = descriptionTextBox.Text.Trim();
            string fullDescription = fulldescriptionTextBox.Text.Trim();
            string phone = phoneTextBox.Text.Trim();
            string lfs = lfsTextBox.Text.Trim();

            //Валидация
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Поле 'Имя' обязательно для заполнения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
                return;
            }

            int Id;
            if (NewFriend != null)
                Id = NewFriend.Id;
            else
                Id = 0;

            NewFriend = new Friend
            {
                PhotoPath = photoPath,
                LastName = lastName,
                FirstName = firstName,
                SurName = surName,
                Date = date,
                Description = description,
                FullDescription = fullDescription,
                PhoneNumber = phone,  // Сохраняем отформатированный телефон
                LFS = lfs,
                Id = Id
            };

            if (Id == 0)
                SQLiteDataAccess.SavePerson(NewFriend);
            else
                SQLiteDataAccess.ChangePeople(NewFriend);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFirstName();
            UpdateAddButtonState();
        }
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLastName();
            UpdateAddButtonState();
        }
        private void surNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateSurName();
            UpdateAddButtonState();
        }

        private void phoneTextBox_Validated(object sender, EventArgs e)
        {
            ValidatePhone();
            UpdateAddButtonState();
        }

        private bool ValidateFirstName()
        {
            string firstName = firstNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim()))
            {
                firstNameErrorLabel.Text = "Поле 'Имя' обязательно для заполнения.";
                firstNameErrorLabel.Visible = true;
                return false;
            }

            else if (firstName.Any(char.IsDigit))
            {
                firstNameErrorLabel.Text = "Имя не должно содержать цифры.";
                firstNameErrorLabel.Visible = true;
                return false;
            }
            else
            {
                firstNameErrorLabel.Text = "";
                firstNameErrorLabel.Visible = false;
                return true;
            }
        }
        private bool ValidateLastName()
        {
            string lastName = lastNameTextBox.Text.Trim();
            if (lastName.Any(char.IsDigit))
            {
                lastNameErrorLabel.Text = "Фамилия не должна содержать цифры.";
                lastNameErrorLabel.Visible = true;
                return false;
            }
            else
            {
                lastNameErrorLabel.Text = "";
                lastNameErrorLabel.Visible = false;
                return true;
            }
        }
        private bool ValidateSurName()
        {
            string surName = surNameTextBox.Text.Trim();
            if (surName.Any(char.IsDigit))
            {
                surNameErrorLabel.Text = "Отчество не должно содержать цифры.";
                surNameErrorLabel.Visible = true;
                return false;
            }
            else
            {
                surNameErrorLabel.Text = "";
                surNameErrorLabel.Visible = false;
                return true;
            }
        }

        private bool ValidatePhone()
        {
            string phone = phoneTextBox.Text.Trim();

            if (phoneTextBox.MaskFull == false && !string.IsNullOrEmpty(phone)) //проверка на пустую строку
            {
                phoneErrorLabel.Text = "Пожалуйста, введите номер телефона полностью";
                phoneErrorLabel.Visible = true;
                return false;
            }
            else
            {
                phoneErrorLabel.Text = "";
                phoneErrorLabel.Visible = false;
                return true;
            }
        }

        private void UpdateAddButtonState()
        {
            addFriendButton.Enabled = ValidateFirstName() && ValidatePhone() && ValidateLastName() && ValidateSurName();
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
