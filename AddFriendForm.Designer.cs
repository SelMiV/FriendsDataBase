using System.Drawing;
using System.Windows.Forms;

namespace проект
{
    partial class AddFriendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addFriendButton = new проект.RoundButtons();
            this.backButton = new проект.RoundButtons();
            this.newfriendLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.surNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.fulldescriptionLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.fulldescriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.lfsTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.surNameErrorLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.photoPathTextBox = new System.Windows.Forms.TextBox();
            this.browsePhotoButton = new проект.RoundButtons();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.photoPictureBox.BackgroundImage = global::проект.Properties.Resources.ad9f1d23e02dd9acda2decb2fd77ac29;
            this.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoPictureBox.Location = new System.Drawing.Point(63, 148);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(169, 159);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.firstNameLabel.Location = new System.Drawing.Point(319, 113);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(48, 17);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "Имя:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.phoneLabel.Location = new System.Drawing.Point(319, 290);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(148, 17);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Номер телефона";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneTextBox.Location = new System.Drawing.Point(323, 313);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(147, 15);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_Validated);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.ForeColor = System.Drawing.Color.White;
            this.firstNameTextBox.Location = new System.Drawing.Point(323, 132);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(147, 15);
            this.firstNameTextBox.TabIndex = 7;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.addFriendButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.newfriendLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 79);
            this.panel1.TabIndex = 8;
            // 
            // addFriendButton
            // 
            this.addFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.addFriendButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.addFriendButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.addFriendButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addFriendButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addFriendButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.addFriendButton.ButtonPressedColor = System.Drawing.Color.White;
            this.addFriendButton.ButtonPressedColor2 = System.Drawing.Color.White;
            this.addFriendButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.addFriendButton.ButtonRoundRadius = 30;
            this.addFriendButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFriendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.addFriendButton.Location = new System.Drawing.Point(648, 12);
            this.addFriendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(149, 60);
            this.addFriendButton.TabIndex = 27;
            this.addFriendButton.Text = "Добавить друга";
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.backButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.backButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.backButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.backButton.ButtonPressedColor = System.Drawing.Color.White;
            this.backButton.ButtonPressedColor2 = System.Drawing.Color.White;
            this.backButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.backButton.ButtonRoundRadius = 30;
            this.backButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(149, 60);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Назад";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newfriendLabel
            // 
            this.newfriendLabel.AutoSize = true;
            this.newfriendLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newfriendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.newfriendLabel.Location = new System.Drawing.Point(189, 27);
            this.newfriendLabel.Name = "newfriendLabel";
            this.newfriendLabel.Size = new System.Drawing.Size(129, 20);
            this.newfriendLabel.TabIndex = 25;
            this.newfriendLabel.Text = "Новый друг";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.lastNameLabel.Location = new System.Drawing.Point(323, 175);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(88, 17);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // surNameLabel
            // 
            this.surNameLabel.AutoSize = true;
            this.surNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.surNameLabel.Location = new System.Drawing.Point(319, 231);
            this.surNameLabel.Name = "surNameLabel";
            this.surNameLabel.Size = new System.Drawing.Size(98, 17);
            this.surNameLabel.TabIndex = 10;
            this.surNameLabel.Text = "Отчество:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.dateLabel.Location = new System.Drawing.Point(319, 350);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(148, 17);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Дата рождения:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.descriptionLabel.Location = new System.Drawing.Point(591, 113);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(178, 17);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Краткое описание:";
            // 
            // fulldescriptionLabel
            // 
            this.fulldescriptionLabel.AutoSize = true;
            this.fulldescriptionLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fulldescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.fulldescriptionLabel.Location = new System.Drawing.Point(591, 175);
            this.fulldescriptionLabel.Name = "fulldescriptionLabel";
            this.fulldescriptionLabel.Size = new System.Drawing.Size(168, 17);
            this.fulldescriptionLabel.TabIndex = 13;
            this.fulldescriptionLabel.Text = "Полное описание:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.ForeColor = System.Drawing.Color.White;
            this.lastNameTextBox.Location = new System.Drawing.Point(323, 194);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(147, 15);
            this.lastNameTextBox.TabIndex = 14;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.surNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surNameTextBox.ForeColor = System.Drawing.Color.White;
            this.surNameTextBox.Location = new System.Drawing.Point(323, 250);
            this.surNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(147, 15);
            this.surNameTextBox.TabIndex = 15;
            this.surNameTextBox.TextChanged += new System.EventHandler(this.surNameTextBox_TextChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(323, 368);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(145, 22);
            this.dateTextBox.TabIndex = 16;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(595, 132);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(175, 15);
            this.descriptionTextBox.TabIndex = 17;
            // 
            // fulldescriptionTextBox
            // 
            this.fulldescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.fulldescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fulldescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fulldescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.fulldescriptionTextBox.Location = new System.Drawing.Point(595, 194);
            this.fulldescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fulldescriptionTextBox.Name = "fulldescriptionTextBox";
            this.fulldescriptionTextBox.Size = new System.Drawing.Size(175, 15);
            this.fulldescriptionTextBox.TabIndex = 18;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.photoLabel.Location = new System.Drawing.Point(107, 126);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(69, 20);
            this.photoLabel.TabIndex = 24;
            this.photoLabel.Text = "Фото:";
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.firstNameErrorLabel.Location = new System.Drawing.Point(323, 159);
            this.firstNameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.firstNameErrorLabel.TabIndex = 25;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoEllipsis = true;
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.phoneErrorLabel.Location = new System.Drawing.Point(476, 316);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(336, 16);
            this.phoneErrorLabel.TabIndex = 26;
            this.phoneErrorLabel.Text = "Пожалуйста, введите номер телефона полностью";
            // 
            // lfsTextBox
            // 
            this.lfsTextBox.Location = new System.Drawing.Point(0, 0);
            this.lfsTextBox.Name = "lfsTextBox";
            this.lfsTextBox.Size = new System.Drawing.Size(100, 22);
            this.lfsTextBox.TabIndex = 0;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CalendarForeColor = System.Drawing.Color.PaleTurquoise;
            this.dateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.PaleTurquoise;
            this.dateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.PaleTurquoise;
            this.dateDateTimePicker.Location = new System.Drawing.Point(323, 368);
            this.dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateDateTimePicker.TabIndex = 27;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.lastNameErrorLabel.Location = new System.Drawing.Point(463, 222);
            this.lastNameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.lastNameErrorLabel.TabIndex = 28;
            // 
            // surNameErrorLabel
            // 
            this.surNameErrorLabel.AutoSize = true;
            this.surNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.surNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.surNameErrorLabel.Location = new System.Drawing.Point(463, 277);
            this.surNameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surNameErrorLabel.Name = "surNameErrorLabel";
            this.surNameErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.surNameErrorLabel.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // photoPathTextBox
            // 
            this.photoPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.photoPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.photoPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.photoPathTextBox.Location = new System.Drawing.Point(63, 385);
            this.photoPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.photoPathTextBox.Name = "photoPathTextBox";
            this.photoPathTextBox.Size = new System.Drawing.Size(169, 15);
            this.photoPathTextBox.TabIndex = 30;
            // 
            // browsePhotoButton
            // 
            this.browsePhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.browsePhotoButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.browsePhotoButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.browsePhotoButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.browsePhotoButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.browsePhotoButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.browsePhotoButton.ButtonPressedColor = System.Drawing.Color.White;
            this.browsePhotoButton.ButtonPressedColor2 = System.Drawing.Color.White;
            this.browsePhotoButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.browsePhotoButton.ButtonRoundRadius = 30;
            this.browsePhotoButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browsePhotoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.browsePhotoButton.Location = new System.Drawing.Point(59, 313);
            this.browsePhotoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browsePhotoButton.Name = "browsePhotoButton";
            this.browsePhotoButton.Size = new System.Drawing.Size(173, 62);
            this.browsePhotoButton.TabIndex = 28;
            this.browsePhotoButton.Text = "(нажмите, чтобы загрузить фото)";
            this.browsePhotoButton.Click += new System.EventHandler(this.browsePhotoButton_Click);
            // 
            // AddFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.browsePhotoButton);
            this.Controls.Add(this.photoPathTextBox);
            this.Controls.Add(this.surNameErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.photoLabel);
            this.Controls.Add(this.fulldescriptionTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.surNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.fulldescriptionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.surNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "AddFriendForm";
            this.Text = "Окно добавления друга";
            this.Load += new System.EventHandler(this.AddFriendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label surNameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label fulldescriptionLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox fulldescriptionTextBox;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.Label newfriendLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.TextBox lfsTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label surNameErrorLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox photoPathTextBox;
        private RoundButtons addFriendButton;
        private RoundButtons backButton;
        private RoundButtons browsePhotoButton;
    }
}