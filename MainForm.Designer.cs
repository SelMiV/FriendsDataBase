namespace проект
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FriendList_FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.Friend_Panel_tmp = new System.Windows.Forms.Panel();
            this.desc_tmp = new System.Windows.Forms.Label();
            this.Telefon_tmp = new System.Windows.Forms.Label();
            this.friendLFS_tmp = new System.Windows.Forms.Label();
            this.friendPicture_tmp = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addFriendButton = new проект.RoundButtons();
            this.Search_IB = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FriendList_FLP.SuspendLayout();
            this.Friend_Panel_tmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendPicture_tmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_IB)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 0);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(884, 511);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // FriendList_FLP
            // 
            this.FriendList_FLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FriendList_FLP.AutoScroll = true;
            this.FriendList_FLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FriendList_FLP.Controls.Add(this.Friend_Panel_tmp);
            this.FriendList_FLP.Location = new System.Drawing.Point(0, 100);
            this.FriendList_FLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FriendList_FLP.Name = "FriendList_FLP";
            this.FriendList_FLP.Size = new System.Drawing.Size(884, 411);
            this.FriendList_FLP.TabIndex = 4;
            this.FriendList_FLP.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Friend_Panel_tmp
            // 
            this.Friend_Panel_tmp.AutoSize = true;
            this.Friend_Panel_tmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Friend_Panel_tmp.Controls.Add(this.desc_tmp);
            this.Friend_Panel_tmp.Controls.Add(this.Telefon_tmp);
            this.Friend_Panel_tmp.Controls.Add(this.friendLFS_tmp);
            this.Friend_Panel_tmp.Controls.Add(this.friendPicture_tmp);
            this.Friend_Panel_tmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Friend_Panel_tmp.Enabled = false;
            this.Friend_Panel_tmp.Location = new System.Drawing.Point(3, 3);
            this.Friend_Panel_tmp.Name = "Friend_Panel_tmp";
            this.Friend_Panel_tmp.Size = new System.Drawing.Size(860, 65);
            this.Friend_Panel_tmp.TabIndex = 0;
            this.Friend_Panel_tmp.Visible = false;
            this.Friend_Panel_tmp.Paint += new System.Windows.Forms.PaintEventHandler(this.Friend_Panel_tmp_Paint);
            // 
            // desc_tmp
            // 
            this.desc_tmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desc_tmp.Location = new System.Drawing.Point(682, 8);
            this.desc_tmp.Name = "desc_tmp";
            this.desc_tmp.Size = new System.Drawing.Size(175, 50);
            this.desc_tmp.TabIndex = 4;
            this.desc_tmp.Text = "label1";
            this.desc_tmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Telefon_tmp
            // 
            this.Telefon_tmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Telefon_tmp.Location = new System.Drawing.Point(501, 22);
            this.Telefon_tmp.Name = "Telefon_tmp";
            this.Telefon_tmp.Size = new System.Drawing.Size(175, 25);
            this.Telefon_tmp.TabIndex = 3;
            this.Telefon_tmp.Text = "label1";
            this.Telefon_tmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendLFS_tmp
            // 
            this.friendLFS_tmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.friendLFS_tmp.Location = new System.Drawing.Point(145, 22);
            this.friendLFS_tmp.Name = "friendLFS_tmp";
            this.friendLFS_tmp.Size = new System.Drawing.Size(350, 25);
            this.friendLFS_tmp.TabIndex = 1;
            this.friendLFS_tmp.Text = "label1";
            this.friendLFS_tmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendPicture_tmp
            // 
            this.friendPicture_tmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.friendPicture_tmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.friendPicture_tmp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("friendPicture_tmp.ErrorImage")));
            this.friendPicture_tmp.Image = global::проект.Properties.Resources.ad9f1d23e02dd9acda2decb2fd77ac29;
            this.friendPicture_tmp.InitialImage = ((System.Drawing.Image)(resources.GetObject("friendPicture_tmp.InitialImage")));
            this.friendPicture_tmp.Location = new System.Drawing.Point(14, 8);
            this.friendPicture_tmp.Name = "friendPicture_tmp";
            this.friendPicture_tmp.Size = new System.Drawing.Size(50, 50);
            this.friendPicture_tmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.friendPicture_tmp.TabIndex = 0;
            this.friendPicture_tmp.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(131, 32);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(484, 19);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.searchLabel.Location = new System.Drawing.Point(16, 33);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(92, 18);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Найти друга";
            // 
            // addFriendButton
            // 
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
            this.addFriendButton.Location = new System.Drawing.Point(732, 26);
            this.addFriendButton.Margin = new System.Windows.Forms.Padding(4);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(133, 49);
            this.addFriendButton.TabIndex = 3;
            this.addFriendButton.Text = "Добавить друга";
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // Search_IB
            // 
            this.Search_IB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_IB.BackColor = System.Drawing.Color.White;
            this.Search_IB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_IB.Image = global::проект.Properties.Resources.people;
            this.Search_IB.Location = new System.Drawing.Point(621, 20);
            this.Search_IB.Name = "Search_IB";
            this.Search_IB.Size = new System.Drawing.Size(36, 36);
            this.Search_IB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search_IB.TabIndex = 4;
            this.Search_IB.TabStop = false;
            this.Search_IB.Click += new System.EventHandler(this.Search_IB_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.Search_IB);
            this.panel2.Controls.Add(this.addFriendButton);
            this.panel2.Controls.Add(this.searchLabel);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 100);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BackgroundImage = global::проект.Properties.Resources.Фон;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.FriendList_FLP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "MainForm";
            this.Text = "Список друзей";
            this.FriendList_FLP.ResumeLayout(false);
            this.FriendList_FLP.PerformLayout();
            this.Friend_Panel_tmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendPicture_tmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_IB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel FriendList_FLP;
        private System.Windows.Forms.Panel Friend_Panel_tmp;
        private System.Windows.Forms.PictureBox friendPicture_tmp;
        private System.Windows.Forms.Label friendLFS_tmp;
        private System.Windows.Forms.Label Telefon_tmp;
        private System.Windows.Forms.Label desc_tmp;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private RoundButtons addFriendButton;
        private System.Windows.Forms.PictureBox Search_IB;
        private System.Windows.Forms.Panel panel2;
    }
}