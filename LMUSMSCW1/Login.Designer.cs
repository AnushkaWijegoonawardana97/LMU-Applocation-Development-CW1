
namespace LMUSMSCW1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login_SidePicture_PB = new System.Windows.Forms.PictureBox();
            this.Login_Close_PB = new System.Windows.Forms.PictureBox();
            this.Login_Title_ML = new MaterialSkin.Controls.MaterialLabel();
            this.Login_Text_ML = new MaterialSkin.Controls.MaterialLabel();
            this.Login_Username_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.Login_Password_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.Login_Login_MB = new MaterialSkin.Controls.MaterialButton();
            this.Login_FP_MTB = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.Login_SidePicture_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Close_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_SidePicture_PB
            // 
            this.Login_SidePicture_PB.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login_SidePicture_PB.Image = ((System.Drawing.Image)(resources.GetObject("Login_SidePicture_PB.Image")));
            this.Login_SidePicture_PB.Location = new System.Drawing.Point(0, 0);
            this.Login_SidePicture_PB.Name = "Login_SidePicture_PB";
            this.Login_SidePicture_PB.Size = new System.Drawing.Size(600, 625);
            this.Login_SidePicture_PB.TabIndex = 0;
            this.Login_SidePicture_PB.TabStop = false;
            // 
            // Login_Close_PB
            // 
            this.Login_Close_PB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Close_PB.Image = ((System.Drawing.Image)(resources.GetObject("Login_Close_PB.Image")));
            this.Login_Close_PB.Location = new System.Drawing.Point(956, 12);
            this.Login_Close_PB.Name = "Login_Close_PB";
            this.Login_Close_PB.Size = new System.Drawing.Size(32, 32);
            this.Login_Close_PB.TabIndex = 1;
            this.Login_Close_PB.TabStop = false;
            this.Login_Close_PB.Click += new System.EventHandler(this.Login_Close_PB_Click);
            // 
            // Login_Title_ML
            // 
            this.Login_Title_ML.AutoSize = true;
            this.Login_Title_ML.Depth = 0;
            this.Login_Title_ML.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Title_ML.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.Login_Title_ML.Location = new System.Drawing.Point(642, 153);
            this.Login_Title_ML.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Title_ML.Name = "Login_Title_ML";
            this.Login_Title_ML.Size = new System.Drawing.Size(297, 41);
            this.Login_Title_ML.TabIndex = 3;
            this.Login_Title_ML.Text = "Welcome to e-pupil.";
            this.Login_Title_ML.UseAccent = true;
            this.Login_Title_ML.UseCompatibleTextRendering = true;
            // 
            // Login_Text_ML
            // 
            this.Login_Text_ML.AutoSize = true;
            this.Login_Text_ML.Depth = 0;
            this.Login_Text_ML.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Login_Text_ML.Location = new System.Drawing.Point(641, 206);
            this.Login_Text_ML.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Text_ML.Name = "Login_Text_ML";
            this.Login_Text_ML.Size = new System.Drawing.Size(320, 19);
            this.Login_Text_ML.TabIndex = 4;
            this.Login_Text_ML.Text = "Sri Lanks Best Student Managemetn System.";
            this.Login_Text_ML.UseCompatibleTextRendering = true;
            // 
            // Login_Username_MTB
            // 
            this.Login_Username_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Username_MTB.Depth = 0;
            this.Login_Username_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.Login_Username_MTB.Hint = "Username";
            this.Login_Username_MTB.Location = new System.Drawing.Point(641, 268);
            this.Login_Username_MTB.MaxLength = 50;
            this.Login_Username_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.Login_Username_MTB.Multiline = false;
            this.Login_Username_MTB.Name = "Login_Username_MTB";
            this.Login_Username_MTB.Size = new System.Drawing.Size(320, 50);
            this.Login_Username_MTB.TabIndex = 5;
            this.Login_Username_MTB.Tag = "";
            this.Login_Username_MTB.Text = "";
            // 
            // Login_Password_MTB
            // 
            this.Login_Password_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Password_MTB.Depth = 0;
            this.Login_Password_MTB.DetectUrls = false;
            this.Login_Password_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.Login_Password_MTB.Hint = "Password";
            this.Login_Password_MTB.Location = new System.Drawing.Point(641, 361);
            this.Login_Password_MTB.MaxLength = 50;
            this.Login_Password_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.Login_Password_MTB.Multiline = false;
            this.Login_Password_MTB.Name = "Login_Password_MTB";
            this.Login_Password_MTB.Size = new System.Drawing.Size(320, 50);
            this.Login_Password_MTB.TabIndex = 6;
            this.Login_Password_MTB.Text = "";
            // 
            // Login_Login_MB
            // 
            this.Login_Login_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_Login_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Login_MB.Depth = 0;
            this.Login_Login_MB.DrawShadows = true;
            this.Login_Login_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Login_MB.HighEmphasis = true;
            this.Login_Login_MB.Icon = null;
            this.Login_Login_MB.Location = new System.Drawing.Point(642, 463);
            this.Login_Login_MB.Margin = new System.Windows.Forms.Padding(16, 6, 16, 6);
            this.Login_Login_MB.MinimumSize = new System.Drawing.Size(150, 0);
            this.Login_Login_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_Login_MB.Name = "Login_Login_MB";
            this.Login_Login_MB.Size = new System.Drawing.Size(150, 36);
            this.Login_Login_MB.TabIndex = 7;
            this.Login_Login_MB.Text = "Login";
            this.Login_Login_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Login_Login_MB.UseAccentColor = false;
            this.Login_Login_MB.UseVisualStyleBackColor = true;
            this.Login_Login_MB.Click += new System.EventHandler(this.Login_Login_MB_Click);
            // 
            // Login_FP_MTB
            // 
            this.Login_FP_MTB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_FP_MTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_FP_MTB.Depth = 0;
            this.Login_FP_MTB.DrawShadows = true;
            this.Login_FP_MTB.HighEmphasis = true;
            this.Login_FP_MTB.Icon = null;
            this.Login_FP_MTB.Location = new System.Drawing.Point(802, 463);
            this.Login_FP_MTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login_FP_MTB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_FP_MTB.Name = "Login_FP_MTB";
            this.Login_FP_MTB.Size = new System.Drawing.Size(159, 36);
            this.Login_FP_MTB.TabIndex = 8;
            this.Login_FP_MTB.Text = "Forget Password";
            this.Login_FP_MTB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.Login_FP_MTB.UseAccentColor = false;
            this.Login_FP_MTB.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.Login_FP_MTB);
            this.Controls.Add(this.Login_Login_MB);
            this.Controls.Add(this.Login_Password_MTB);
            this.Controls.Add(this.Login_Username_MTB);
            this.Controls.Add(this.Login_Text_ML);
            this.Controls.Add(this.Login_Title_ML);
            this.Controls.Add(this.Login_Close_PB);
            this.Controls.Add(this.Login_SidePicture_PB);
            this.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Login_SidePicture_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Close_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_SidePicture_PB;
        private System.Windows.Forms.PictureBox Login_Close_PB;
        private MaterialSkin.Controls.MaterialLabel Login_Title_ML;
        private MaterialSkin.Controls.MaterialLabel Login_Text_ML;
        private MaterialSkin.Controls.MaterialTextBox Login_Username_MTB;
        private MaterialSkin.Controls.MaterialTextBox Login_Password_MTB;
        private MaterialSkin.Controls.MaterialButton Login_Login_MB;
        private MaterialSkin.Controls.MaterialButton Login_FP_MTB;
    }
}

