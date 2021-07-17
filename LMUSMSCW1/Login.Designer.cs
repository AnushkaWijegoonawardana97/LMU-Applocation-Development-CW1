
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(642, 133);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "materialLabel2";
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.materialLabel2);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

