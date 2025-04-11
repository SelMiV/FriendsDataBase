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
            this.components = new System.ComponentModel.Container();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newfriendLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.surNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.fulldescriptionLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.inputsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.browsePhotoButton = new проект.RoundButtons();
            this.addFriendButton = new проект.RoundButtons();
            this.backButton = new проект.RoundButtons();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.mainTableLayout.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.inputsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.photoPictureBox.Location = new System.Drawing.Point(13, 38);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(208, 180);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.firstNameLabel.Location = new System.Drawing.Point(3, 6);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(133, 13);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "Имя:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.phoneLabel.Location = new System.Drawing.Point(3, 141);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(133, 13);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "Номер телефона:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneTextBox.Location = new System.Drawing.Point(159, 141);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(341, 13);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_Validated);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.ForeColor = System.Drawing.Color.White;
            this.firstNameTextBox.Location = new System.Drawing.Point(159, 6);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(341, 13);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 8;
            // 
            // newfriendLabel
            // 
            this.newfriendLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newfriendLabel.AutoSize = true;
            this.newfriendLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newfriendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.newfriendLabel.Location = new System.Drawing.Point(211, 22);
            this.newfriendLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newfriendLabel.Name = "newfriendLabel";
            this.newfriendLabel.Size = new System.Drawing.Size(107, 16);
            this.newfriendLabel.TabIndex = 25;
            this.newfriendLabel.Text = "Новый друг";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.lastNameLabel.Location = new System.Drawing.Point(3, 51);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(133, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Фамилия:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surNameLabel
            // 
            this.surNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surNameLabel.AutoSize = true;
            this.surNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.surNameLabel.Location = new System.Drawing.Point(3, 96);
            this.surNameLabel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.surNameLabel.Name = "surNameLabel";
            this.surNameLabel.Size = new System.Drawing.Size(133, 13);
            this.surNameLabel.TabIndex = 10;
            this.surNameLabel.Text = "Отчество:";
            this.surNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.dateLabel.Location = new System.Drawing.Point(3, 188);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(133, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Дата рождения:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 216);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(151, 13);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Краткое описание:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fulldescriptionLabel
            // 
            this.fulldescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fulldescriptionLabel.AutoSize = true;
            this.fulldescriptionLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fulldescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.fulldescriptionLabel.Location = new System.Drawing.Point(3, 356);
            this.fulldescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.fulldescriptionLabel.Name = "fulldescriptionLabel";
            this.fulldescriptionLabel.Size = new System.Drawing.Size(151, 13);
            this.fulldescriptionLabel.TabIndex = 13;
            this.fulldescriptionLabel.Text = "Полное описание:";
            this.fulldescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.ForeColor = System.Drawing.Color.White;
            this.lastNameTextBox.Location = new System.Drawing.Point(159, 51);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(341, 13);
            this.lastNameTextBox.TabIndex = 14;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.surNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surNameTextBox.ForeColor = System.Drawing.Color.White;
            this.surNameTextBox.Location = new System.Drawing.Point(159, 96);
            this.surNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(341, 13);
            this.surNameTextBox.TabIndex = 15;
            this.surNameTextBox.TextChanged += new System.EventHandler(this.surNameTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.descriptionTextBox.Location = new System.Drawing.Point(159, 216);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(341, 13);
            this.descriptionTextBox.TabIndex = 17;
            // 
            // fulldescriptionTextBox
            // 
            this.fulldescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fulldescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.fulldescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fulldescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fulldescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.fulldescriptionTextBox.Location = new System.Drawing.Point(159, 238);
            this.fulldescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.fulldescriptionTextBox.Multiline = true;
            this.fulldescriptionTextBox.Name = "fulldescriptionTextBox";
            this.fulldescriptionTextBox.Size = new System.Drawing.Size(341, 249);
            this.fulldescriptionTextBox.TabIndex = 18;
            // 
            // photoLabel
            // 
            this.photoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.photoLabel.Location = new System.Drawing.Point(87, 14);
            this.photoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(57, 16);
            this.photoLabel.TabIndex = 24;
            this.photoLabel.Text = "Фото:";
            this.photoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.firstNameErrorLabel.Location = new System.Drawing.Point(338, 25);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorLabel.TabIndex = 25;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneErrorLabel.AutoEllipsis = true;
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.phoneErrorLabel.Location = new System.Drawing.Point(207, 160);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(261, 13);
            this.phoneErrorLabel.TabIndex = 26;
            this.phoneErrorLabel.Text = "Пожалуйста, введите номер телефона полностью";
            // 
            // lfsTextBox
            // 
            this.lfsTextBox.Location = new System.Drawing.Point(0, 0);
            this.lfsTextBox.Name = "lfsTextBox";
            this.lfsTextBox.Size = new System.Drawing.Size(100, 20);
            this.lfsTextBox.TabIndex = 0;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDateTimePicker.CalendarForeColor = System.Drawing.Color.PaleTurquoise;
            this.dateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.PaleTurquoise;
            this.dateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.PaleTurquoise;
            this.dateDateTimePicker.Location = new System.Drawing.Point(159, 185);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(358, 20);
            this.dateDateTimePicker.TabIndex = 27;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.lastNameErrorLabel.Location = new System.Drawing.Point(159, 70);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorLabel.TabIndex = 28;
            // 
            // surNameErrorLabel
            // 
            this.surNameErrorLabel.AutoSize = true;
            this.surNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.surNameErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.surNameErrorLabel.Location = new System.Drawing.Point(159, 115);
            this.surNameErrorLabel.Name = "surNameErrorLabel";
            this.surNameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.surNameErrorLabel.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // photoPathTextBox
            // 
            this.photoPathTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.photoPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.photoPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.photoPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.photoPathTextBox.Location = new System.Drawing.Point(10, 280);
            this.photoPathTextBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.photoPathTextBox.Name = "photoPathTextBox";
            this.photoPathTextBox.ReadOnly = true;
            this.photoPathTextBox.Size = new System.Drawing.Size(208, 13);
            this.photoPathTextBox.TabIndex = 30;
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTableLayout.Controls.Add(this.leftPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.rightPanel, 1, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 64);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.Padding = new System.Windows.Forms.Padding(10);
            this.mainTableLayout.RowCount = 1;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(800, 536);
            this.mainTableLayout.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.photoPictureBox);
            this.leftPanel.Controls.Add(this.photoLabel);
            this.leftPanel.Controls.Add(this.browsePhotoButton);
            this.leftPanel.Controls.Add(this.photoPathTextBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(13, 13);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(228, 510);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.inputsTableLayout);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(247, 13);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10);
            this.rightPanel.Size = new System.Drawing.Size(540, 510);
            this.rightPanel.TabIndex = 1;
            // 
            // inputsTableLayout
            // 
            this.inputsTableLayout.ColumnCount = 2;
            this.inputsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.inputsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.inputsTableLayout.Controls.Add(this.firstNameLabel, 0, 0);
            this.inputsTableLayout.Controls.Add(this.firstNameTextBox, 1, 0);
            this.inputsTableLayout.Controls.Add(this.firstNameErrorLabel, 1, 1);
            this.inputsTableLayout.Controls.Add(this.lastNameLabel, 0, 2);
            this.inputsTableLayout.Controls.Add(this.lastNameTextBox, 1, 2);
            this.inputsTableLayout.Controls.Add(this.lastNameErrorLabel, 1, 3);
            this.inputsTableLayout.Controls.Add(this.surNameLabel, 0, 4);
            this.inputsTableLayout.Controls.Add(this.surNameTextBox, 1, 4);
            this.inputsTableLayout.Controls.Add(this.surNameErrorLabel, 1, 5);
            this.inputsTableLayout.Controls.Add(this.phoneLabel, 0, 6);
            this.inputsTableLayout.Controls.Add(this.phoneTextBox, 1, 6);
            this.inputsTableLayout.Controls.Add(this.phoneErrorLabel, 1, 7);
            this.inputsTableLayout.Controls.Add(this.dateLabel, 0, 8);
            this.inputsTableLayout.Controls.Add(this.dateDateTimePicker, 1, 8);
            this.inputsTableLayout.Controls.Add(this.descriptionTextBox, 1, 9);
            this.inputsTableLayout.Controls.Add(this.fulldescriptionLabel, 0, 10);
            this.inputsTableLayout.Controls.Add(this.descriptionLabel, 0, 9);
            this.inputsTableLayout.Controls.Add(this.fulldescriptionTextBox, 1, 10);
            this.inputsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsTableLayout.Location = new System.Drawing.Point(10, 10);
            this.inputsTableLayout.Name = "inputsTableLayout";
            this.inputsTableLayout.RowCount = 11;
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputsTableLayout.Size = new System.Drawing.Size(520, 490);
            this.inputsTableLayout.TabIndex = 0;
            // 
            // browsePhotoButton
            // 
            this.browsePhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.browsePhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.browsePhotoButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.browsePhotoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.browsePhotoButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.browsePhotoButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.browsePhotoButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.browsePhotoButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.browsePhotoButton.ButtonPressedColor = System.Drawing.Color.White;
            this.browsePhotoButton.ButtonPressedColor2 = System.Drawing.Color.White;
            this.browsePhotoButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.browsePhotoButton.ButtonRoundRadius = 30;
            this.browsePhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browsePhotoButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browsePhotoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.browsePhotoButton.Location = new System.Drawing.Point(10, 230);
            this.browsePhotoButton.Margin = new System.Windows.Forms.Padding(2);
            this.browsePhotoButton.MinimumSize = new System.Drawing.Size(180, 40);
            this.browsePhotoButton.Name = "browsePhotoButton";
            this.browsePhotoButton.Size = new System.Drawing.Size(208, 40);
            this.browsePhotoButton.TabIndex = 28;
            this.browsePhotoButton.Text = "Загрузить фото";
            this.browsePhotoButton.Click += new System.EventHandler(this.browsePhotoButton_Click);
            // 
            // addFriendButton
            // 
            this.addFriendButton.AllowDrop = true;
            this.addFriendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.addFriendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFriendButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFriendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.addFriendButton.Location = new System.Drawing.Point(667, 10);
            this.addFriendButton.Margin = new System.Windows.Forms.Padding(2);
            this.addFriendButton.MinimumSize = new System.Drawing.Size(120, 40);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(120, 49);
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
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.backButton.Location = new System.Drawing.Point(9, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.MinimumSize = new System.Drawing.Size(120, 40);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 49);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Назад";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 639);
            this.Name = "AddFriendForm";
            this.Text = "Окно добавления друга";
            this.Load += new System.EventHandler(this.AddFriendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainTableLayout.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.inputsTableLayout.ResumeLayout(false);
            this.inputsTableLayout.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TableLayoutPanel inputsTableLayout;
        private System.Windows.Forms.ToolTip toolTip;
        private RoundButtons addFriendButton;
        private RoundButtons backButton;
        private RoundButtons browsePhotoButton;
    }
}