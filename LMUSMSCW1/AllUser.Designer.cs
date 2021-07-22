
namespace LMUSMSCW1
{
    partial class AllUser
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Username");
            this.UserDashboard_ALU_Card_MC = new MaterialSkin.Controls.MaterialCard();
            this.UserDashboard_ALU_ListView_MLV = new MaterialSkin.Controls.MaterialListView();
            this.UserDashboard_ALU_UsernameTkError = new System.Windows.Forms.Label();
            this.UserDashboard_ALU_Success = new System.Windows.Forms.Label();
            this.UserDashboard_ALU_AccessLevelError = new System.Windows.Forms.Label();
            this.UserDashboard_ALU_PasswordError = new System.Windows.Forms.Label();
            this.UserDashboard_ALU_UsernameError = new System.Windows.Forms.Label();
            this.UserDashboard_ALU_NameError = new System.Windows.Forms.Label();
            this.UserDashboard_ALU_Hint_ML = new MaterialSkin.Controls.MaterialLabel();
            this.UserDashboard_ALU_RestBtn_MB = new MaterialSkin.Controls.MaterialButton();
            this.UserDashboard_ALU_SaveBtn_MB = new MaterialSkin.Controls.MaterialButton();
            this.UserDashboard_ALU_AccessLevel_MTB = new MaterialSkin.Controls.MaterialComboBox();
            this.UserDashboard_ALU_Password_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.UserDashboard_ALU_UserName_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.UserDashboard_ALU_Title_ML = new MaterialSkin.Controls.MaterialLabel();
            this.UserDashboard_ALU_Name_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.UserDashboard_ALU_Card_MC.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDashboard_ALU_Card_MC
            // 
            this.UserDashboard_ALU_Card_MC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDashboard_ALU_Card_MC.Controls.Add(this.UserDashboard_ALU_ListView_MLV);
            this.UserDashboard_ALU_Card_MC.Depth = 0;
            this.UserDashboard_ALU_Card_MC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserDashboard_ALU_Card_MC.Location = new System.Drawing.Point(25, 22);
            this.UserDashboard_ALU_Card_MC.Margin = new System.Windows.Forms.Padding(14);
            this.UserDashboard_ALU_Card_MC.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDashboard_ALU_Card_MC.Name = "UserDashboard_ALU_Card_MC";
            this.UserDashboard_ALU_Card_MC.Padding = new System.Windows.Forms.Padding(14);
            this.UserDashboard_ALU_Card_MC.Size = new System.Drawing.Size(905, 453);
            this.UserDashboard_ALU_Card_MC.TabIndex = 55;
            // 
            // UserDashboard_ALU_ListView_MLV
            // 
            this.UserDashboard_ALU_ListView_MLV.AutoSizeTable = false;
            this.UserDashboard_ALU_ListView_MLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDashboard_ALU_ListView_MLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDashboard_ALU_ListView_MLV.Depth = 0;
            this.UserDashboard_ALU_ListView_MLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDashboard_ALU_ListView_MLV.FullRowSelect = true;
            this.UserDashboard_ALU_ListView_MLV.HideSelection = false;
            this.UserDashboard_ALU_ListView_MLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.UserDashboard_ALU_ListView_MLV.Location = new System.Drawing.Point(14, 14);
            this.UserDashboard_ALU_ListView_MLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.UserDashboard_ALU_ListView_MLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UserDashboard_ALU_ListView_MLV.MouseState = MaterialSkin.MouseState.OUT;
            this.UserDashboard_ALU_ListView_MLV.Name = "UserDashboard_ALU_ListView_MLV";
            this.UserDashboard_ALU_ListView_MLV.OwnerDraw = true;
            this.UserDashboard_ALU_ListView_MLV.Size = new System.Drawing.Size(877, 425);
            this.UserDashboard_ALU_ListView_MLV.TabIndex = 0;
            this.UserDashboard_ALU_ListView_MLV.UseCompatibleStateImageBehavior = false;
            this.UserDashboard_ALU_ListView_MLV.View = System.Windows.Forms.View.List;
            // 
            // UserDashboard_ALU_UsernameTkError
            // 
            this.UserDashboard_ALU_UsernameTkError.AutoSize = true;
            this.UserDashboard_ALU_UsernameTkError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDashboard_ALU_UsernameTkError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.UserDashboard_ALU_UsernameTkError.Location = new System.Drawing.Point(337, 607);
            this.UserDashboard_ALU_UsernameTkError.Name = "UserDashboard_ALU_UsernameTkError";
            this.UserDashboard_ALU_UsernameTkError.Size = new System.Drawing.Size(147, 15);
            this.UserDashboard_ALU_UsernameTkError.TabIndex = 69;
            this.UserDashboard_ALU_UsernameTkError.Text = "Username already taken.";
            // 
            // UserDashboard_ALU_Success
            // 
            this.UserDashboard_ALU_Success.AutoSize = true;
            this.UserDashboard_ALU_Success.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDashboard_ALU_Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.UserDashboard_ALU_Success.Location = new System.Drawing.Point(778, 581);
            this.UserDashboard_ALU_Success.Name = "UserDashboard_ALU_Success";
            this.UserDashboard_ALU_Success.Size = new System.Drawing.Size(124, 19);
            this.UserDashboard_ALU_Success.TabIndex = 68;
            this.UserDashboard_ALU_Success.Text = "New User Added";
            // 
            // UserDashboard_ALU_AccessLevelError
            // 
            this.UserDashboard_ALU_AccessLevelError.AutoSize = true;
            this.UserDashboard_ALU_AccessLevelError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDashboard_ALU_AccessLevelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.UserDashboard_ALU_AccessLevelError.Location = new System.Drawing.Point(339, 682);
            this.UserDashboard_ALU_AccessLevelError.Name = "UserDashboard_ALU_AccessLevelError";
            this.UserDashboard_ALU_AccessLevelError.Size = new System.Drawing.Size(158, 15);
            this.UserDashboard_ALU_AccessLevelError.TabIndex = 67;
            this.UserDashboard_ALU_AccessLevelError.Text = "This field cannot be empty.";
            // 
            // UserDashboard_ALU_PasswordError
            // 
            this.UserDashboard_ALU_PasswordError.AutoSize = true;
            this.UserDashboard_ALU_PasswordError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDashboard_ALU_PasswordError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.UserDashboard_ALU_PasswordError.Location = new System.Drawing.Point(28, 683);
            this.UserDashboard_ALU_PasswordError.Name = "UserDashboard_ALU_PasswordError";
            this.UserDashboard_ALU_PasswordError.Size = new System.Drawing.Size(158, 15);
            this.UserDashboard_ALU_PasswordError.TabIndex = 66;
            this.UserDashboard_ALU_PasswordError.Text = "This field cannot be empty.";
            // 
            // UserDashboard_ALU_UsernameError
            // 
            this.UserDashboard_ALU_UsernameError.AutoSize = true;
            this.UserDashboard_ALU_UsernameError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDashboard_ALU_UsernameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.UserDashboard_ALU_UsernameError.Location = new System.Drawing.Point(338, 607);
            this.UserDashboard_ALU_UsernameError.Name = "UserDashboard_ALU_UsernameError";
            this.UserDashboard_ALU_UsernameError.Size = new System.Drawing.Size(158, 15);
            this.UserDashboard_ALU_UsernameError.TabIndex = 65;
            this.UserDashboard_ALU_UsernameError.Text = "This field cannot be empty.";
            // 
            // UserDashboard_ALU_NameError
            // 
            this.UserDashboard_ALU_NameError.AutoSize = true;
            this.UserDashboard_ALU_NameError.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDashboard_ALU_NameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.UserDashboard_ALU_NameError.Location = new System.Drawing.Point(28, 606);
            this.UserDashboard_ALU_NameError.Name = "UserDashboard_ALU_NameError";
            this.UserDashboard_ALU_NameError.Size = new System.Drawing.Size(158, 15);
            this.UserDashboard_ALU_NameError.TabIndex = 64;
            this.UserDashboard_ALU_NameError.Text = "This field cannot be empty.";
            // 
            // UserDashboard_ALU_Hint_ML
            // 
            this.UserDashboard_ALU_Hint_ML.AutoSize = true;
            this.UserDashboard_ALU_Hint_ML.Depth = 0;
            this.UserDashboard_ALU_Hint_ML.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserDashboard_ALU_Hint_ML.Location = new System.Drawing.Point(477, 489);
            this.UserDashboard_ALU_Hint_ML.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDashboard_ALU_Hint_ML.Name = "UserDashboard_ALU_Hint_ML";
            this.UserDashboard_ALU_Hint_ML.Size = new System.Drawing.Size(453, 19);
            this.UserDashboard_ALU_Hint_ML.TabIndex = 63;
            this.UserDashboard_ALU_Hint_ML.Text = "* Select the staff member from above to create a new staff user.";
            // 
            // UserDashboard_ALU_RestBtn_MB
            // 
            this.UserDashboard_ALU_RestBtn_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserDashboard_ALU_RestBtn_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserDashboard_ALU_RestBtn_MB.Depth = 0;
            this.UserDashboard_ALU_RestBtn_MB.DrawShadows = true;
            this.UserDashboard_ALU_RestBtn_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDashboard_ALU_RestBtn_MB.HighEmphasis = true;
            this.UserDashboard_ALU_RestBtn_MB.Icon = null;
            this.UserDashboard_ALU_RestBtn_MB.Location = new System.Drawing.Point(750, 609);
            this.UserDashboard_ALU_RestBtn_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserDashboard_ALU_RestBtn_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.UserDashboard_ALU_RestBtn_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDashboard_ALU_RestBtn_MB.Name = "UserDashboard_ALU_RestBtn_MB";
            this.UserDashboard_ALU_RestBtn_MB.Size = new System.Drawing.Size(180, 36);
            this.UserDashboard_ALU_RestBtn_MB.TabIndex = 62;
            this.UserDashboard_ALU_RestBtn_MB.Text = "Rest";
            this.UserDashboard_ALU_RestBtn_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.UserDashboard_ALU_RestBtn_MB.UseAccentColor = false;
            this.UserDashboard_ALU_RestBtn_MB.UseVisualStyleBackColor = true;
            // 
            // UserDashboard_ALU_SaveBtn_MB
            // 
            this.UserDashboard_ALU_SaveBtn_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserDashboard_ALU_SaveBtn_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserDashboard_ALU_SaveBtn_MB.Depth = 0;
            this.UserDashboard_ALU_SaveBtn_MB.DrawShadows = true;
            this.UserDashboard_ALU_SaveBtn_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDashboard_ALU_SaveBtn_MB.HighEmphasis = true;
            this.UserDashboard_ALU_SaveBtn_MB.Icon = null;
            this.UserDashboard_ALU_SaveBtn_MB.Location = new System.Drawing.Point(750, 657);
            this.UserDashboard_ALU_SaveBtn_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserDashboard_ALU_SaveBtn_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.UserDashboard_ALU_SaveBtn_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDashboard_ALU_SaveBtn_MB.Name = "UserDashboard_ALU_SaveBtn_MB";
            this.UserDashboard_ALU_SaveBtn_MB.Size = new System.Drawing.Size(180, 36);
            this.UserDashboard_ALU_SaveBtn_MB.TabIndex = 61;
            this.UserDashboard_ALU_SaveBtn_MB.Text = "Save User";
            this.UserDashboard_ALU_SaveBtn_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UserDashboard_ALU_SaveBtn_MB.UseAccentColor = false;
            this.UserDashboard_ALU_SaveBtn_MB.UseVisualStyleBackColor = true;
            // 
            // UserDashboard_ALU_AccessLevel_MTB
            // 
            this.UserDashboard_ALU_AccessLevel_MTB.AutoResize = false;
            this.UserDashboard_ALU_AccessLevel_MTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDashboard_ALU_AccessLevel_MTB.Depth = 0;
            this.UserDashboard_ALU_AccessLevel_MTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UserDashboard_ALU_AccessLevel_MTB.DropDownHeight = 174;
            this.UserDashboard_ALU_AccessLevel_MTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserDashboard_ALU_AccessLevel_MTB.DropDownWidth = 121;
            this.UserDashboard_ALU_AccessLevel_MTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UserDashboard_ALU_AccessLevel_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserDashboard_ALU_AccessLevel_MTB.FormattingEnabled = true;
            this.UserDashboard_ALU_AccessLevel_MTB.Hint = "Access Level";
            this.UserDashboard_ALU_AccessLevel_MTB.IntegralHeight = false;
            this.UserDashboard_ALU_AccessLevel_MTB.ItemHeight = 43;
            this.UserDashboard_ALU_AccessLevel_MTB.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.UserDashboard_ALU_AccessLevel_MTB.Location = new System.Drawing.Point(335, 632);
            this.UserDashboard_ALU_AccessLevel_MTB.MaxDropDownItems = 4;
            this.UserDashboard_ALU_AccessLevel_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.UserDashboard_ALU_AccessLevel_MTB.Name = "UserDashboard_ALU_AccessLevel_MTB";
            this.UserDashboard_ALU_AccessLevel_MTB.Size = new System.Drawing.Size(275, 49);
            this.UserDashboard_ALU_AccessLevel_MTB.TabIndex = 60;
            // 
            // UserDashboard_ALU_Password_MTB
            // 
            this.UserDashboard_ALU_Password_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDashboard_ALU_Password_MTB.Depth = 0;
            this.UserDashboard_ALU_Password_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.UserDashboard_ALU_Password_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.UserDashboard_ALU_Password_MTB.Hint = "Password";
            this.UserDashboard_ALU_Password_MTB.Location = new System.Drawing.Point(25, 633);
            this.UserDashboard_ALU_Password_MTB.MaxLength = 50;
            this.UserDashboard_ALU_Password_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.UserDashboard_ALU_Password_MTB.Multiline = false;
            this.UserDashboard_ALU_Password_MTB.Name = "UserDashboard_ALU_Password_MTB";
            this.UserDashboard_ALU_Password_MTB.Password = true;
            this.UserDashboard_ALU_Password_MTB.Size = new System.Drawing.Size(275, 50);
            this.UserDashboard_ALU_Password_MTB.TabIndex = 59;
            this.UserDashboard_ALU_Password_MTB.Tag = "";
            this.UserDashboard_ALU_Password_MTB.Text = "";
            // 
            // UserDashboard_ALU_UserName_MTB
            // 
            this.UserDashboard_ALU_UserName_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDashboard_ALU_UserName_MTB.Depth = 0;
            this.UserDashboard_ALU_UserName_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.UserDashboard_ALU_UserName_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.UserDashboard_ALU_UserName_MTB.Hint = "Username";
            this.UserDashboard_ALU_UserName_MTB.Location = new System.Drawing.Point(335, 556);
            this.UserDashboard_ALU_UserName_MTB.MaxLength = 50;
            this.UserDashboard_ALU_UserName_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.UserDashboard_ALU_UserName_MTB.Multiline = false;
            this.UserDashboard_ALU_UserName_MTB.Name = "UserDashboard_ALU_UserName_MTB";
            this.UserDashboard_ALU_UserName_MTB.Size = new System.Drawing.Size(275, 50);
            this.UserDashboard_ALU_UserName_MTB.TabIndex = 58;
            this.UserDashboard_ALU_UserName_MTB.Tag = "";
            this.UserDashboard_ALU_UserName_MTB.Text = "";
            // 
            // UserDashboard_ALU_Title_ML
            // 
            this.UserDashboard_ALU_Title_ML.AutoSize = true;
            this.UserDashboard_ALU_Title_ML.Depth = 0;
            this.UserDashboard_ALU_Title_ML.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UserDashboard_ALU_Title_ML.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.UserDashboard_ALU_Title_ML.Location = new System.Drawing.Point(20, 502);
            this.UserDashboard_ALU_Title_ML.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDashboard_ALU_Title_ML.Name = "UserDashboard_ALU_Title_ML";
            this.UserDashboard_ALU_Title_ML.Size = new System.Drawing.Size(145, 29);
            this.UserDashboard_ALU_Title_ML.TabIndex = 57;
            this.UserDashboard_ALU_Title_ML.Text = "Update Users";
            // 
            // UserDashboard_ALU_Name_MTB
            // 
            this.UserDashboard_ALU_Name_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDashboard_ALU_Name_MTB.Depth = 0;
            this.UserDashboard_ALU_Name_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.UserDashboard_ALU_Name_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.UserDashboard_ALU_Name_MTB.Hint = "Full Name";
            this.UserDashboard_ALU_Name_MTB.Location = new System.Drawing.Point(25, 556);
            this.UserDashboard_ALU_Name_MTB.MaxLength = 50;
            this.UserDashboard_ALU_Name_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.UserDashboard_ALU_Name_MTB.Multiline = false;
            this.UserDashboard_ALU_Name_MTB.Name = "UserDashboard_ALU_Name_MTB";
            this.UserDashboard_ALU_Name_MTB.Size = new System.Drawing.Size(275, 50);
            this.UserDashboard_ALU_Name_MTB.TabIndex = 56;
            this.UserDashboard_ALU_Name_MTB.Tag = "";
            this.UserDashboard_ALU_Name_MTB.Text = "";
            // 
            // AllUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(951, 721);
            this.Controls.Add(this.UserDashboard_ALU_Card_MC);
            this.Controls.Add(this.UserDashboard_ALU_UsernameTkError);
            this.Controls.Add(this.UserDashboard_ALU_Success);
            this.Controls.Add(this.UserDashboard_ALU_AccessLevelError);
            this.Controls.Add(this.UserDashboard_ALU_PasswordError);
            this.Controls.Add(this.UserDashboard_ALU_UsernameError);
            this.Controls.Add(this.UserDashboard_ALU_NameError);
            this.Controls.Add(this.UserDashboard_ALU_Hint_ML);
            this.Controls.Add(this.UserDashboard_ALU_RestBtn_MB);
            this.Controls.Add(this.UserDashboard_ALU_SaveBtn_MB);
            this.Controls.Add(this.UserDashboard_ALU_AccessLevel_MTB);
            this.Controls.Add(this.UserDashboard_ALU_Password_MTB);
            this.Controls.Add(this.UserDashboard_ALU_UserName_MTB);
            this.Controls.Add(this.UserDashboard_ALU_Title_ML);
            this.Controls.Add(this.UserDashboard_ALU_Name_MTB);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllUser";
            this.Text = "AllUser";
            this.UserDashboard_ALU_Card_MC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard UserDashboard_ALU_Card_MC;
        private MaterialSkin.Controls.MaterialListView UserDashboard_ALU_ListView_MLV;
        private System.Windows.Forms.Label UserDashboard_ALU_UsernameTkError;
        private System.Windows.Forms.Label UserDashboard_ALU_Success;
        private System.Windows.Forms.Label UserDashboard_ALU_AccessLevelError;
        private System.Windows.Forms.Label UserDashboard_ALU_PasswordError;
        private System.Windows.Forms.Label UserDashboard_ALU_UsernameError;
        private System.Windows.Forms.Label UserDashboard_ALU_NameError;
        private MaterialSkin.Controls.MaterialLabel UserDashboard_ALU_Hint_ML;
        private MaterialSkin.Controls.MaterialButton UserDashboard_ALU_RestBtn_MB;
        private MaterialSkin.Controls.MaterialButton UserDashboard_ALU_SaveBtn_MB;
        private MaterialSkin.Controls.MaterialComboBox UserDashboard_ALU_AccessLevel_MTB;
        private MaterialSkin.Controls.MaterialTextBox UserDashboard_ALU_Password_MTB;
        private MaterialSkin.Controls.MaterialTextBox UserDashboard_ALU_UserName_MTB;
        private MaterialSkin.Controls.MaterialLabel UserDashboard_ALU_Title_ML;
        private MaterialSkin.Controls.MaterialTextBox UserDashboard_ALU_Name_MTB;
    }
}