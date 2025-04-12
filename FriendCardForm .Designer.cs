using System.Drawing;
using System.Windows.Forms;
namespace проект
{
    partial class FriendCardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new проект.RoundButtons();
            this.deliteButton = new проект.RoundButtons();
            this.backButton = new проект.RoundButtons();
            this.contentTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.photoPanel = new System.Windows.Forms.Panel();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.photoLabel = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.detailsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTL = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTL = new System.Windows.Forms.Label();
            this.surNameLabel = new System.Windows.Forms.Label();
            this.SurNameTL = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.PhoneTL = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.DateTL = new System.Windows.Forms.Label();
            this.fulldescriptionLabel = new System.Windows.Forms.Label();
            this.FullDescTL = new System.Windows.Forms.Label();
            this.mainTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contentTableLayout.SuspendLayout();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.detailsPanel.SuspendLayout();
            this.detailsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.panel1, 0, 0);
            this.mainTableLayout.Controls.Add(this.contentTableLayout, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Size = new System.Drawing.Size(664, 415);
            this.mainTableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.deliteButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 74);
            this.panel1.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.editButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.editButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.editButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.editButton.ButtonPressedColor = System.Drawing.Color.White;
            this.editButton.ButtonPressedColor2 = System.Drawing.Color.White;
            this.editButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.editButton.ButtonRoundRadius = 30;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.editButton.Location = new System.Drawing.Point(482, 17);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(119, 40);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактировать";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deliteButton
            // 
            this.deliteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.deliteButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.deliteButton.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.deliteButton.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deliteButton.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deliteButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.deliteButton.ButtonPressedColor = System.Drawing.Color.White;
            this.deliteButton.ButtonPressedColor2 = System.Drawing.Color.White;
            this.deliteButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.deliteButton.ButtonRoundRadius = 30;
            this.deliteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliteButton.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.deliteButton.Location = new System.Drawing.Point(354, 17);
            this.deliteButton.Name = "deliteButton";
            this.deliteButton.Size = new System.Drawing.Size(100, 40);
            this.deliteButton.TabIndex = 1;
            this.deliteButton.Text = "Удалить";
            this.deliteButton.Click += new System.EventHandler(this.deliteButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(25, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 40);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // contentTableLayout
            // 
            this.contentTableLayout.ColumnCount = 2;
            this.contentTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.contentTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.contentTableLayout.Controls.Add(this.photoPanel, 0, 0);
            this.contentTableLayout.Controls.Add(this.detailsPanel, 1, 0);
            this.contentTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTableLayout.Location = new System.Drawing.Point(3, 83);
            this.contentTableLayout.Name = "contentTableLayout";
            this.contentTableLayout.RowCount = 1;
            this.contentTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentTableLayout.Size = new System.Drawing.Size(658, 329);
            this.contentTableLayout.TabIndex = 1;
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.photoPictureBox);
            this.photoPanel.Controls.Add(this.photoLabel);
            this.photoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photoPanel.Location = new System.Drawing.Point(3, 3);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(224, 323);
            this.photoPanel.TabIndex = 0;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.photoPictureBox.Location = new System.Drawing.Point(25, 50);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(173, 209);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 0;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // photoLabel
            // 
            this.photoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.photoLabel.Location = new System.Drawing.Point(86, 20);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(52, 15);
            this.photoLabel.TabIndex = 23;
            this.photoLabel.Text = "Фото:";
            this.photoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.detailsTableLayout);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.Location = new System.Drawing.Point(233, 3);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(422, 323);
            this.detailsPanel.TabIndex = 1;
            // 
            // detailsTableLayout
            // 
            this.detailsTableLayout.ColumnCount = 2;
            this.detailsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.detailsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.detailsTableLayout.Controls.Add(this.lastNameLabel, 0, 0);
            this.detailsTableLayout.Controls.Add(this.LastNameTL, 1, 0);
            this.detailsTableLayout.Controls.Add(this.firstNameLabel, 0, 1);
            this.detailsTableLayout.Controls.Add(this.FirstNameTL, 1, 1);
            this.detailsTableLayout.Controls.Add(this.surNameLabel, 0, 2);
            this.detailsTableLayout.Controls.Add(this.SurNameTL, 1, 2);
            this.detailsTableLayout.Controls.Add(this.phoneLabel, 0, 3);
            this.detailsTableLayout.Controls.Add(this.PhoneTL, 1, 3);
            this.detailsTableLayout.Controls.Add(this.dateLabel, 0, 4);
            this.detailsTableLayout.Controls.Add(this.DateTL, 1, 4);
            this.detailsTableLayout.Controls.Add(this.fulldescriptionLabel, 0, 5);
            this.detailsTableLayout.Controls.Add(this.FullDescTL, 1, 5);
            this.detailsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsTableLayout.Location = new System.Drawing.Point(0, 0);
            this.detailsTableLayout.Name = "detailsTableLayout";
            this.detailsTableLayout.RowCount = 6;
            this.detailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.detailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.detailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.detailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.detailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.detailsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.detailsTableLayout.Size = new System.Drawing.Size(422, 323);
            this.detailsTableLayout.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.lastNameLabel.Location = new System.Drawing.Point(3, 12);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(162, 13);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Фамилия:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameTL
            // 
            this.LastNameTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.LastNameTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTL.ForeColor = System.Drawing.Color.White;
            this.LastNameTL.Location = new System.Drawing.Point(171, 6);
            this.LastNameTL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.LastNameTL.MinimumSize = new System.Drawing.Size(100, 25);
            this.LastNameTL.Name = "LastNameTL";
            this.LastNameTL.Size = new System.Drawing.Size(241, 25);
            this.LastNameTL.TabIndex = 24;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.firstNameLabel.Location = new System.Drawing.Point(3, 50);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(162, 13);
            this.firstNameLabel.TabIndex = 19;
            this.firstNameLabel.Text = "Имя:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameTL
            // 
            this.FirstNameTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.FirstNameTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTL.ForeColor = System.Drawing.Color.White;
            this.FirstNameTL.Location = new System.Drawing.Point(171, 44);
            this.FirstNameTL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.FirstNameTL.MinimumSize = new System.Drawing.Size(100, 25);
            this.FirstNameTL.Name = "FirstNameTL";
            this.FirstNameTL.Size = new System.Drawing.Size(241, 25);
            this.FirstNameTL.TabIndex = 25;
            // 
            // surNameLabel
            // 
            this.surNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.surNameLabel.AutoSize = true;
            this.surNameLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.surNameLabel.Location = new System.Drawing.Point(3, 88);
            this.surNameLabel.Name = "surNameLabel";
            this.surNameLabel.Size = new System.Drawing.Size(162, 13);
            this.surNameLabel.TabIndex = 20;
            this.surNameLabel.Text = "Отчество:";
            this.surNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SurNameTL
            // 
            this.SurNameTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurNameTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.SurNameTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNameTL.ForeColor = System.Drawing.Color.White;
            this.SurNameTL.Location = new System.Drawing.Point(171, 82);
            this.SurNameTL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.SurNameTL.MinimumSize = new System.Drawing.Size(100, 25);
            this.SurNameTL.Name = "SurNameTL";
            this.SurNameTL.Size = new System.Drawing.Size(241, 25);
            this.SurNameTL.TabIndex = 26;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.phoneLabel.Location = new System.Drawing.Point(3, 126);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(162, 13);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Номер телефона:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneTL
            // 
            this.PhoneTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.PhoneTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTL.ForeColor = System.Drawing.Color.White;
            this.PhoneTL.Location = new System.Drawing.Point(171, 120);
            this.PhoneTL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.PhoneTL.MinimumSize = new System.Drawing.Size(150, 25);
            this.PhoneTL.Name = "PhoneTL";
            this.PhoneTL.Size = new System.Drawing.Size(241, 25);
            this.PhoneTL.TabIndex = 27;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.dateLabel.Location = new System.Drawing.Point(3, 164);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(162, 13);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Дата рождения:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateTL
            // 
            this.DateTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.DateTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTL.ForeColor = System.Drawing.Color.White;
            this.DateTL.Location = new System.Drawing.Point(171, 158);
            this.DateTL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.DateTL.MinimumSize = new System.Drawing.Size(150, 25);
            this.DateTL.Name = "DateTL";
            this.DateTL.Size = new System.Drawing.Size(241, 25);
            this.DateTL.TabIndex = 28;
            // 
            // fulldescriptionLabel
            // 
            this.fulldescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fulldescriptionLabel.AutoSize = true;
            this.fulldescriptionLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fulldescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(166)))));
            this.fulldescriptionLabel.Location = new System.Drawing.Point(3, 250);
            this.fulldescriptionLabel.Name = "fulldescriptionLabel";
            this.fulldescriptionLabel.Size = new System.Drawing.Size(162, 13);
            this.fulldescriptionLabel.TabIndex = 15;
            this.fulldescriptionLabel.Text = "Полное описание:";
            this.fulldescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FullDescTL
            // 
            this.FullDescTL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullDescTL.AutoSize = true;
            this.FullDescTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.FullDescTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullDescTL.ForeColor = System.Drawing.Color.White;
            this.FullDescTL.Location = new System.Drawing.Point(171, 190);
            this.FullDescTL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.FullDescTL.MinimumSize = new System.Drawing.Size(200, 60);
            this.FullDescTL.Name = "FullDescTL";
            this.FullDescTL.Size = new System.Drawing.Size(241, 123);
            this.FullDescTL.TabIndex = 29;
            this.FullDescTL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FriendCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(664, 415);
            this.Controls.Add(this.mainTableLayout);
            this.MinimumSize = new System.Drawing.Size(680, 454);
            this.Name = "FriendCardForm";
            this.Load += new System.EventHandler(this.FriendCardForm_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contentTableLayout.ResumeLayout(false);
            this.photoPanel.ResumeLayout(false);
            this.photoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            this.detailsTableLayout.ResumeLayout(false);
            this.detailsTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Panel panel1;
        private RoundButtons editButton;
        private RoundButtons deliteButton;
        private RoundButtons backButton;
        private System.Windows.Forms.TableLayoutPanel contentTableLayout;
        private System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.TableLayoutPanel detailsTableLayout;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label LastNameTL;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label FirstNameTL;
        private System.Windows.Forms.Label surNameLabel;
        private System.Windows.Forms.Label SurNameTL;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label PhoneTL;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label DateTL;
        private System.Windows.Forms.Label fulldescriptionLabel;
        private System.Windows.Forms.Label FullDescTL;
    }
}