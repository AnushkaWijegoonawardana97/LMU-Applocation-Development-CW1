
namespace LMUSMSCW1
{
    partial class ExamResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamResults));
            this.AdminDasboard_Navbar_MC = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.AdminDashbaord_Logo_PB = new System.Windows.Forms.PictureBox();
            this.AdminDashboard_Settings_MLB = new MaterialSkin.Controls.MaterialButton();
            this.AdminDashboard_Logout_MLB = new MaterialSkin.Controls.MaterialButton();
            this.AdminDashboard_CD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.AdminDashboard_ScD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.StudentDashboard_ViewData_MC = new MaterialSkin.Controls.MaterialCard();
            this.MapStudent_ViewData_FilterBy_MCB = new MaterialSkin.Controls.MaterialComboBox();
            this.MapStudent_ViewData_SearchValue_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.MapSubject_ViewData_Search_MB = new MaterialSkin.Controls.MaterialButton();
            this.MapSubject_FullDataListView_MLV = new MaterialSkin.Controls.MaterialListView();
            this.StudentDashboard_Title_ML = new MaterialSkin.Controls.MaterialLabel();
            this.MapStudent_Error = new System.Windows.Forms.Label();
            this.MapStudent_Success = new System.Windows.Forms.Label();
            this.MapSubject_SaveBtn_MB = new MaterialSkin.Controls.MaterialButton();
            this.MapStudent_StudentName_MLV = new MaterialSkin.Controls.MaterialListView();
            this.MapStudent_ClassName_MLV = new MaterialSkin.Controls.MaterialListView();
            this.ExamResults_StudentName_Error = new System.Windows.Forms.Label();
            this.ExamResults_StudentName_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.ExamResults_ClassID_Error = new System.Windows.Forms.Label();
            this.ExamResults_ClassID_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.MapSubject_ResetBtn_MB = new MaterialSkin.Controls.MaterialButton();
            this.ExamResults_Marks_Error = new System.Windows.Forms.Label();
            this.ExamResults_Marks_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.ExamResults_SubjectName_Error = new System.Windows.Forms.Label();
            this.ExamResults_SubjectName_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.AdminDasboard_Navbar_MC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDashbaord_Logo_PB)).BeginInit();
            this.StudentDashboard_ViewData_MC.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminDasboard_Navbar_MC
            // 
            this.AdminDasboard_Navbar_MC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminDasboard_Navbar_MC.Controls.Add(this.materialButton1);
            this.AdminDasboard_Navbar_MC.Controls.Add(this.AdminDashbaord_Logo_PB);
            this.AdminDasboard_Navbar_MC.Controls.Add(this.AdminDashboard_Settings_MLB);
            this.AdminDasboard_Navbar_MC.Controls.Add(this.AdminDashboard_Logout_MLB);
            this.AdminDasboard_Navbar_MC.Controls.Add(this.AdminDashboard_CD_MLB);
            this.AdminDasboard_Navbar_MC.Controls.Add(this.AdminDashboard_ScD_MLB);
            this.AdminDasboard_Navbar_MC.Depth = 0;
            this.AdminDasboard_Navbar_MC.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminDasboard_Navbar_MC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminDasboard_Navbar_MC.Location = new System.Drawing.Point(0, 0);
            this.AdminDasboard_Navbar_MC.Margin = new System.Windows.Forms.Padding(14);
            this.AdminDasboard_Navbar_MC.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminDasboard_Navbar_MC.Name = "AdminDasboard_Navbar_MC";
            this.AdminDasboard_Navbar_MC.Padding = new System.Windows.Forms.Padding(14);
            this.AdminDasboard_Navbar_MC.Size = new System.Drawing.Size(220, 800);
            this.AdminDasboard_Navbar_MC.TabIndex = 84;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(18, 212);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MinimumSize = new System.Drawing.Size(180, 0);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(180, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Exam Results";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // AdminDashbaord_Logo_PB
            // 
            this.AdminDashbaord_Logo_PB.Image = ((System.Drawing.Image)(resources.GetObject("AdminDashbaord_Logo_PB.Image")));
            this.AdminDashbaord_Logo_PB.Location = new System.Drawing.Point(19, 17);
            this.AdminDashbaord_Logo_PB.Name = "AdminDashbaord_Logo_PB";
            this.AdminDashbaord_Logo_PB.Size = new System.Drawing.Size(180, 60);
            this.AdminDashbaord_Logo_PB.TabIndex = 2;
            this.AdminDashbaord_Logo_PB.TabStop = false;
            // 
            // AdminDashboard_Settings_MLB
            // 
            this.AdminDashboard_Settings_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminDashboard_Settings_MLB.Depth = 0;
            this.AdminDashboard_Settings_MLB.DrawShadows = true;
            this.AdminDashboard_Settings_MLB.HighEmphasis = true;
            this.AdminDashboard_Settings_MLB.Icon = null;
            this.AdminDashboard_Settings_MLB.Location = new System.Drawing.Point(18, 696);
            this.AdminDashboard_Settings_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdminDashboard_Settings_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.AdminDashboard_Settings_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminDashboard_Settings_MLB.Name = "AdminDashboard_Settings_MLB";
            this.AdminDashboard_Settings_MLB.Size = new System.Drawing.Size(180, 36);
            this.AdminDashboard_Settings_MLB.TabIndex = 8;
            this.AdminDashboard_Settings_MLB.Text = "Settings";
            this.AdminDashboard_Settings_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AdminDashboard_Settings_MLB.UseAccentColor = false;
            this.AdminDashboard_Settings_MLB.UseVisualStyleBackColor = true;
            this.AdminDashboard_Settings_MLB.Click += new System.EventHandler(this.AdminDashboard_Settings_MLB_Click);
            // 
            // AdminDashboard_Logout_MLB
            // 
            this.AdminDashboard_Logout_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminDashboard_Logout_MLB.Depth = 0;
            this.AdminDashboard_Logout_MLB.DrawShadows = true;
            this.AdminDashboard_Logout_MLB.HighEmphasis = true;
            this.AdminDashboard_Logout_MLB.Icon = null;
            this.AdminDashboard_Logout_MLB.Location = new System.Drawing.Point(19, 749);
            this.AdminDashboard_Logout_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdminDashboard_Logout_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.AdminDashboard_Logout_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminDashboard_Logout_MLB.Name = "AdminDashboard_Logout_MLB";
            this.AdminDashboard_Logout_MLB.Size = new System.Drawing.Size(180, 36);
            this.AdminDashboard_Logout_MLB.TabIndex = 7;
            this.AdminDashboard_Logout_MLB.Text = "Logout";
            this.AdminDashboard_Logout_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AdminDashboard_Logout_MLB.UseAccentColor = false;
            this.AdminDashboard_Logout_MLB.UseVisualStyleBackColor = true;
            this.AdminDashboard_Logout_MLB.Click += new System.EventHandler(this.AdminDashboard_Logout_MLB_Click);
            // 
            // AdminDashboard_CD_MLB
            // 
            this.AdminDashboard_CD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminDashboard_CD_MLB.Depth = 0;
            this.AdminDashboard_CD_MLB.DrawShadows = true;
            this.AdminDashboard_CD_MLB.HighEmphasis = true;
            this.AdminDashboard_CD_MLB.Icon = null;
            this.AdminDashboard_CD_MLB.Location = new System.Drawing.Point(18, 159);
            this.AdminDashboard_CD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdminDashboard_CD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.AdminDashboard_CD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminDashboard_CD_MLB.Name = "AdminDashboard_CD_MLB";
            this.AdminDashboard_CD_MLB.Size = new System.Drawing.Size(180, 36);
            this.AdminDashboard_CD_MLB.TabIndex = 5;
            this.AdminDashboard_CD_MLB.Text = "Students";
            this.AdminDashboard_CD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AdminDashboard_CD_MLB.UseAccentColor = false;
            this.AdminDashboard_CD_MLB.UseVisualStyleBackColor = true;
            this.AdminDashboard_CD_MLB.Click += new System.EventHandler(this.AdminDashboard_CD_MLB_Click);
            // 
            // AdminDashboard_ScD_MLB
            // 
            this.AdminDashboard_ScD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminDashboard_ScD_MLB.Depth = 0;
            this.AdminDashboard_ScD_MLB.DrawShadows = true;
            this.AdminDashboard_ScD_MLB.HighEmphasis = true;
            this.AdminDashboard_ScD_MLB.Icon = null;
            this.AdminDashboard_ScD_MLB.Location = new System.Drawing.Point(18, 106);
            this.AdminDashboard_ScD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdminDashboard_ScD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.AdminDashboard_ScD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminDashboard_ScD_MLB.Name = "AdminDashboard_ScD_MLB";
            this.AdminDashboard_ScD_MLB.Size = new System.Drawing.Size(180, 36);
            this.AdminDashboard_ScD_MLB.TabIndex = 1;
            this.AdminDashboard_ScD_MLB.Text = "Subjects";
            this.AdminDashboard_ScD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AdminDashboard_ScD_MLB.UseAccentColor = false;
            this.AdminDashboard_ScD_MLB.UseVisualStyleBackColor = true;
            this.AdminDashboard_ScD_MLB.Click += new System.EventHandler(this.AdminDashboard_ScD_MLB_Click);
            // 
            // StudentDashboard_ViewData_MC
            // 
            this.StudentDashboard_ViewData_MC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentDashboard_ViewData_MC.Controls.Add(this.MapStudent_ViewData_FilterBy_MCB);
            this.StudentDashboard_ViewData_MC.Controls.Add(this.MapStudent_ViewData_SearchValue_MTB);
            this.StudentDashboard_ViewData_MC.Controls.Add(this.MapSubject_ViewData_Search_MB);
            this.StudentDashboard_ViewData_MC.Controls.Add(this.MapSubject_FullDataListView_MLV);
            this.StudentDashboard_ViewData_MC.Depth = 0;
            this.StudentDashboard_ViewData_MC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StudentDashboard_ViewData_MC.Location = new System.Drawing.Point(262, 419);
            this.StudentDashboard_ViewData_MC.Margin = new System.Windows.Forms.Padding(14);
            this.StudentDashboard_ViewData_MC.MouseState = MaterialSkin.MouseState.HOVER;
            this.StudentDashboard_ViewData_MC.Name = "StudentDashboard_ViewData_MC";
            this.StudentDashboard_ViewData_MC.Padding = new System.Windows.Forms.Padding(14);
            this.StudentDashboard_ViewData_MC.Size = new System.Drawing.Size(910, 356);
            this.StudentDashboard_ViewData_MC.TabIndex = 86;
            // 
            // MapStudent_ViewData_FilterBy_MCB
            // 
            this.MapStudent_ViewData_FilterBy_MCB.AutoResize = false;
            this.MapStudent_ViewData_FilterBy_MCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MapStudent_ViewData_FilterBy_MCB.Depth = 0;
            this.MapStudent_ViewData_FilterBy_MCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MapStudent_ViewData_FilterBy_MCB.DropDownHeight = 174;
            this.MapStudent_ViewData_FilterBy_MCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapStudent_ViewData_FilterBy_MCB.DropDownWidth = 121;
            this.MapStudent_ViewData_FilterBy_MCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MapStudent_ViewData_FilterBy_MCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MapStudent_ViewData_FilterBy_MCB.FormattingEnabled = true;
            this.MapStudent_ViewData_FilterBy_MCB.Hint = "Filter By";
            this.MapStudent_ViewData_FilterBy_MCB.IntegralHeight = false;
            this.MapStudent_ViewData_FilterBy_MCB.ItemHeight = 43;
            this.MapStudent_ViewData_FilterBy_MCB.Items.AddRange(new object[] {
            "No Filter",
            "Student Name",
            "Class ID",
            "Subject Name"});
            this.MapStudent_ViewData_FilterBy_MCB.Location = new System.Drawing.Point(17, 19);
            this.MapStudent_ViewData_FilterBy_MCB.MaxDropDownItems = 4;
            this.MapStudent_ViewData_FilterBy_MCB.MouseState = MaterialSkin.MouseState.OUT;
            this.MapStudent_ViewData_FilterBy_MCB.Name = "MapStudent_ViewData_FilterBy_MCB";
            this.MapStudent_ViewData_FilterBy_MCB.Size = new System.Drawing.Size(325, 49);
            this.MapStudent_ViewData_FilterBy_MCB.TabIndex = 62;
            // 
            // MapStudent_ViewData_SearchValue_MTB
            // 
            this.MapStudent_ViewData_SearchValue_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MapStudent_ViewData_SearchValue_MTB.Depth = 0;
            this.MapStudent_ViewData_SearchValue_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.MapStudent_ViewData_SearchValue_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.MapStudent_ViewData_SearchValue_MTB.Hint = "Search...";
            this.MapStudent_ViewData_SearchValue_MTB.Location = new System.Drawing.Point(369, 19);
            this.MapStudent_ViewData_SearchValue_MTB.MaxLength = 50;
            this.MapStudent_ViewData_SearchValue_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.MapStudent_ViewData_SearchValue_MTB.Multiline = false;
            this.MapStudent_ViewData_SearchValue_MTB.Name = "MapStudent_ViewData_SearchValue_MTB";
            this.MapStudent_ViewData_SearchValue_MTB.Size = new System.Drawing.Size(325, 50);
            this.MapStudent_ViewData_SearchValue_MTB.TabIndex = 62;
            this.MapStudent_ViewData_SearchValue_MTB.Tag = "";
            this.MapStudent_ViewData_SearchValue_MTB.Text = "";
            // 
            // MapSubject_ViewData_Search_MB
            // 
            this.MapSubject_ViewData_Search_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MapSubject_ViewData_Search_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapSubject_ViewData_Search_MB.Depth = 0;
            this.MapSubject_ViewData_Search_MB.DrawShadows = true;
            this.MapSubject_ViewData_Search_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapSubject_ViewData_Search_MB.HighEmphasis = true;
            this.MapSubject_ViewData_Search_MB.Icon = null;
            this.MapSubject_ViewData_Search_MB.Location = new System.Drawing.Point(716, 26);
            this.MapSubject_ViewData_Search_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MapSubject_ViewData_Search_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.MapSubject_ViewData_Search_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.MapSubject_ViewData_Search_MB.Name = "MapSubject_ViewData_Search_MB";
            this.MapSubject_ViewData_Search_MB.Size = new System.Drawing.Size(180, 36);
            this.MapSubject_ViewData_Search_MB.TabIndex = 62;
            this.MapSubject_ViewData_Search_MB.Text = "Search";
            this.MapSubject_ViewData_Search_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MapSubject_ViewData_Search_MB.UseAccentColor = false;
            this.MapSubject_ViewData_Search_MB.UseVisualStyleBackColor = true;
            this.MapSubject_ViewData_Search_MB.Click += new System.EventHandler(this.MapSubject_ViewData_Search_MB_Click);
            // 
            // MapSubject_FullDataListView_MLV
            // 
            this.MapSubject_FullDataListView_MLV.AutoSizeTable = false;
            this.MapSubject_FullDataListView_MLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MapSubject_FullDataListView_MLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MapSubject_FullDataListView_MLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapSubject_FullDataListView_MLV.Depth = 0;
            this.MapSubject_FullDataListView_MLV.Font = new System.Drawing.Font("Roboto", 18F);
            this.MapSubject_FullDataListView_MLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.MapSubject_FullDataListView_MLV.FullRowSelect = true;
            this.MapSubject_FullDataListView_MLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MapSubject_FullDataListView_MLV.HideSelection = false;
            this.MapSubject_FullDataListView_MLV.Location = new System.Drawing.Point(17, 83);
            this.MapSubject_FullDataListView_MLV.Margin = new System.Windows.Forms.Padding(5);
            this.MapSubject_FullDataListView_MLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.MapSubject_FullDataListView_MLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MapSubject_FullDataListView_MLV.MouseState = MaterialSkin.MouseState.OUT;
            this.MapSubject_FullDataListView_MLV.Name = "MapSubject_FullDataListView_MLV";
            this.MapSubject_FullDataListView_MLV.OwnerDraw = true;
            this.MapSubject_FullDataListView_MLV.Size = new System.Drawing.Size(880, 254);
            this.MapSubject_FullDataListView_MLV.TabIndex = 2;
            this.MapSubject_FullDataListView_MLV.UseCompatibleStateImageBehavior = false;
            this.MapSubject_FullDataListView_MLV.View = System.Windows.Forms.View.Details;
            this.MapSubject_FullDataListView_MLV.SelectedIndexChanged += new System.EventHandler(this.MapSubject_FullDataListView_MLV_SelectedIndexChanged);
            // 
            // StudentDashboard_Title_ML
            // 
            this.StudentDashboard_Title_ML.AutoSize = true;
            this.StudentDashboard_Title_ML.Depth = 0;
            this.StudentDashboard_Title_ML.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StudentDashboard_Title_ML.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.StudentDashboard_Title_ML.Location = new System.Drawing.Point(257, 30);
            this.StudentDashboard_Title_ML.MouseState = MaterialSkin.MouseState.HOVER;
            this.StudentDashboard_Title_ML.Name = "StudentDashboard_Title_ML";
            this.StudentDashboard_Title_ML.Size = new System.Drawing.Size(146, 29);
            this.StudentDashboard_Title_ML.TabIndex = 85;
            this.StudentDashboard_Title_ML.Text = "Exam Results";
            // 
            // MapStudent_Error
            // 
            this.MapStudent_Error.AutoSize = true;
            this.MapStudent_Error.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapStudent_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.MapStudent_Error.Location = new System.Drawing.Point(265, 380);
            this.MapStudent_Error.Name = "MapStudent_Error";
            this.MapStudent_Error.Size = new System.Drawing.Size(115, 19);
            this.MapStudent_Error.TabIndex = 96;
            this.MapStudent_Error.Text = "Error Message";
            // 
            // MapStudent_Success
            // 
            this.MapStudent_Success.AutoSize = true;
            this.MapStudent_Success.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapStudent_Success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.MapStudent_Success.Location = new System.Drawing.Point(267, 380);
            this.MapStudent_Success.Name = "MapStudent_Success";
            this.MapStudent_Success.Size = new System.Drawing.Size(139, 19);
            this.MapStudent_Success.TabIndex = 95;
            this.MapStudent_Success.Text = "Success Message";
            // 
            // MapSubject_SaveBtn_MB
            // 
            this.MapSubject_SaveBtn_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MapSubject_SaveBtn_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapSubject_SaveBtn_MB.Depth = 0;
            this.MapSubject_SaveBtn_MB.DrawShadows = true;
            this.MapSubject_SaveBtn_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapSubject_SaveBtn_MB.HighEmphasis = true;
            this.MapSubject_SaveBtn_MB.Icon = null;
            this.MapSubject_SaveBtn_MB.Location = new System.Drawing.Point(996, 363);
            this.MapSubject_SaveBtn_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MapSubject_SaveBtn_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.MapSubject_SaveBtn_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.MapSubject_SaveBtn_MB.Name = "MapSubject_SaveBtn_MB";
            this.MapSubject_SaveBtn_MB.Size = new System.Drawing.Size(180, 36);
            this.MapSubject_SaveBtn_MB.TabIndex = 93;
            this.MapSubject_SaveBtn_MB.Text = "Save";
            this.MapSubject_SaveBtn_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MapSubject_SaveBtn_MB.UseAccentColor = false;
            this.MapSubject_SaveBtn_MB.UseVisualStyleBackColor = true;
            this.MapSubject_SaveBtn_MB.Click += new System.EventHandler(this.MapSubject_SaveBtn_MB_Click);
            // 
            // MapStudent_StudentName_MLV
            // 
            this.MapStudent_StudentName_MLV.AutoSizeTable = false;
            this.MapStudent_StudentName_MLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MapStudent_StudentName_MLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MapStudent_StudentName_MLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapStudent_StudentName_MLV.Depth = 0;
            this.MapStudent_StudentName_MLV.Font = new System.Drawing.Font("Roboto", 18F);
            this.MapStudent_StudentName_MLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.MapStudent_StudentName_MLV.FullRowSelect = true;
            this.MapStudent_StudentName_MLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MapStudent_StudentName_MLV.HideSelection = false;
            this.MapStudent_StudentName_MLV.Location = new System.Drawing.Point(747, 157);
            this.MapStudent_StudentName_MLV.Margin = new System.Windows.Forms.Padding(5);
            this.MapStudent_StudentName_MLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.MapStudent_StudentName_MLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MapStudent_StudentName_MLV.MouseState = MaterialSkin.MouseState.OUT;
            this.MapStudent_StudentName_MLV.Name = "MapStudent_StudentName_MLV";
            this.MapStudent_StudentName_MLV.OwnerDraw = true;
            this.MapStudent_StudentName_MLV.Size = new System.Drawing.Size(421, 181);
            this.MapStudent_StudentName_MLV.TabIndex = 92;
            this.MapStudent_StudentName_MLV.UseCompatibleStateImageBehavior = false;
            this.MapStudent_StudentName_MLV.View = System.Windows.Forms.View.Details;
            this.MapStudent_StudentName_MLV.SelectedIndexChanged += new System.EventHandler(this.MapStudent_StudentName_MLV_SelectedIndexChanged);
            // 
            // MapStudent_ClassName_MLV
            // 
            this.MapStudent_ClassName_MLV.AutoSizeTable = false;
            this.MapStudent_ClassName_MLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MapStudent_ClassName_MLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MapStudent_ClassName_MLV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapStudent_ClassName_MLV.Depth = 0;
            this.MapStudent_ClassName_MLV.Font = new System.Drawing.Font("Roboto", 18F);
            this.MapStudent_ClassName_MLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.MapStudent_ClassName_MLV.FullRowSelect = true;
            this.MapStudent_ClassName_MLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MapStudent_ClassName_MLV.HideSelection = false;
            this.MapStudent_ClassName_MLV.Location = new System.Drawing.Point(262, 157);
            this.MapStudent_ClassName_MLV.Margin = new System.Windows.Forms.Padding(5);
            this.MapStudent_ClassName_MLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.MapStudent_ClassName_MLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MapStudent_ClassName_MLV.MouseState = MaterialSkin.MouseState.OUT;
            this.MapStudent_ClassName_MLV.Name = "MapStudent_ClassName_MLV";
            this.MapStudent_ClassName_MLV.OwnerDraw = true;
            this.MapStudent_ClassName_MLV.Size = new System.Drawing.Size(421, 181);
            this.MapStudent_ClassName_MLV.TabIndex = 88;
            this.MapStudent_ClassName_MLV.UseCompatibleStateImageBehavior = false;
            this.MapStudent_ClassName_MLV.View = System.Windows.Forms.View.Details;
            this.MapStudent_ClassName_MLV.SelectedIndexChanged += new System.EventHandler(this.MapStudent_ClassName_MLV_SelectedIndexChanged);
            // 
            // ExamResults_StudentName_Error
            // 
            this.ExamResults_StudentName_Error.AutoSize = true;
            this.ExamResults_StudentName_Error.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamResults_StudentName_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ExamResults_StudentName_Error.Location = new System.Drawing.Point(504, 127);
            this.ExamResults_StudentName_Error.Name = "ExamResults_StudentName_Error";
            this.ExamResults_StudentName_Error.Size = new System.Drawing.Size(158, 15);
            this.ExamResults_StudentName_Error.TabIndex = 91;
            this.ExamResults_StudentName_Error.Text = "This field cannot be empty.";
            // 
            // ExamResults_StudentName_MTB
            // 
            this.ExamResults_StudentName_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamResults_StudentName_MTB.Depth = 0;
            this.ExamResults_StudentName_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.ExamResults_StudentName_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ExamResults_StudentName_MTB.Hint = "Student Name";
            this.ExamResults_StudentName_MTB.Location = new System.Drawing.Point(502, 77);
            this.ExamResults_StudentName_MTB.MaxLength = 50;
            this.ExamResults_StudentName_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ExamResults_StudentName_MTB.Multiline = false;
            this.ExamResults_StudentName_MTB.Name = "ExamResults_StudentName_MTB";
            this.ExamResults_StudentName_MTB.Size = new System.Drawing.Size(200, 50);
            this.ExamResults_StudentName_MTB.TabIndex = 90;
            this.ExamResults_StudentName_MTB.Tag = "";
            this.ExamResults_StudentName_MTB.Text = "";
            // 
            // ExamResults_ClassID_Error
            // 
            this.ExamResults_ClassID_Error.AutoSize = true;
            this.ExamResults_ClassID_Error.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamResults_ClassID_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ExamResults_ClassID_Error.Location = new System.Drawing.Point(264, 127);
            this.ExamResults_ClassID_Error.Name = "ExamResults_ClassID_Error";
            this.ExamResults_ClassID_Error.Size = new System.Drawing.Size(158, 15);
            this.ExamResults_ClassID_Error.TabIndex = 89;
            this.ExamResults_ClassID_Error.Text = "This field cannot be empty.";
            // 
            // ExamResults_ClassID_MTB
            // 
            this.ExamResults_ClassID_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamResults_ClassID_MTB.Depth = 0;
            this.ExamResults_ClassID_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.ExamResults_ClassID_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ExamResults_ClassID_MTB.Hint = "Class ID";
            this.ExamResults_ClassID_MTB.Location = new System.Drawing.Point(262, 77);
            this.ExamResults_ClassID_MTB.MaxLength = 50;
            this.ExamResults_ClassID_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ExamResults_ClassID_MTB.Multiline = false;
            this.ExamResults_ClassID_MTB.Name = "ExamResults_ClassID_MTB";
            this.ExamResults_ClassID_MTB.Size = new System.Drawing.Size(200, 50);
            this.ExamResults_ClassID_MTB.TabIndex = 87;
            this.ExamResults_ClassID_MTB.Tag = "";
            this.ExamResults_ClassID_MTB.Text = "";
            // 
            // MapSubject_ResetBtn_MB
            // 
            this.MapSubject_ResetBtn_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MapSubject_ResetBtn_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MapSubject_ResetBtn_MB.Depth = 0;
            this.MapSubject_ResetBtn_MB.DrawShadows = true;
            this.MapSubject_ResetBtn_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapSubject_ResetBtn_MB.HighEmphasis = true;
            this.MapSubject_ResetBtn_MB.Icon = null;
            this.MapSubject_ResetBtn_MB.Location = new System.Drawing.Point(776, 363);
            this.MapSubject_ResetBtn_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MapSubject_ResetBtn_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.MapSubject_ResetBtn_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.MapSubject_ResetBtn_MB.Name = "MapSubject_ResetBtn_MB";
            this.MapSubject_ResetBtn_MB.Size = new System.Drawing.Size(180, 36);
            this.MapSubject_ResetBtn_MB.TabIndex = 94;
            this.MapSubject_ResetBtn_MB.Text = "Rest";
            this.MapSubject_ResetBtn_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MapSubject_ResetBtn_MB.UseAccentColor = false;
            this.MapSubject_ResetBtn_MB.UseVisualStyleBackColor = true;
            this.MapSubject_ResetBtn_MB.Click += new System.EventHandler(this.MapSubject_ResetBtn_MB_Click);
            // 
            // ExamResults_Marks_Error
            // 
            this.ExamResults_Marks_Error.AutoSize = true;
            this.ExamResults_Marks_Error.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamResults_Marks_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ExamResults_Marks_Error.Location = new System.Drawing.Point(970, 127);
            this.ExamResults_Marks_Error.Name = "ExamResults_Marks_Error";
            this.ExamResults_Marks_Error.Size = new System.Drawing.Size(158, 15);
            this.ExamResults_Marks_Error.TabIndex = 98;
            this.ExamResults_Marks_Error.Text = "This field cannot be empty.";
            // 
            // ExamResults_Marks_MTB
            // 
            this.ExamResults_Marks_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamResults_Marks_MTB.Depth = 0;
            this.ExamResults_Marks_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.ExamResults_Marks_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ExamResults_Marks_MTB.Hint = "Marks";
            this.ExamResults_Marks_MTB.Location = new System.Drawing.Point(968, 77);
            this.ExamResults_Marks_MTB.MaxLength = 50;
            this.ExamResults_Marks_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ExamResults_Marks_MTB.Multiline = false;
            this.ExamResults_Marks_MTB.Name = "ExamResults_Marks_MTB";
            this.ExamResults_Marks_MTB.Size = new System.Drawing.Size(200, 50);
            this.ExamResults_Marks_MTB.TabIndex = 97;
            this.ExamResults_Marks_MTB.Tag = "";
            this.ExamResults_Marks_MTB.Text = "";
            // 
            // ExamResults_SubjectName_Error
            // 
            this.ExamResults_SubjectName_Error.AutoSize = true;
            this.ExamResults_SubjectName_Error.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamResults_SubjectName_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ExamResults_SubjectName_Error.Location = new System.Drawing.Point(735, 127);
            this.ExamResults_SubjectName_Error.Name = "ExamResults_SubjectName_Error";
            this.ExamResults_SubjectName_Error.Size = new System.Drawing.Size(158, 15);
            this.ExamResults_SubjectName_Error.TabIndex = 100;
            this.ExamResults_SubjectName_Error.Text = "This field cannot be empty.";
            // 
            // ExamResults_SubjectName_MTB
            // 
            this.ExamResults_SubjectName_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExamResults_SubjectName_MTB.Depth = 0;
            this.ExamResults_SubjectName_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.ExamResults_SubjectName_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ExamResults_SubjectName_MTB.Hint = "Subject Name";
            this.ExamResults_SubjectName_MTB.Location = new System.Drawing.Point(733, 77);
            this.ExamResults_SubjectName_MTB.MaxLength = 50;
            this.ExamResults_SubjectName_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ExamResults_SubjectName_MTB.Multiline = false;
            this.ExamResults_SubjectName_MTB.Name = "ExamResults_SubjectName_MTB";
            this.ExamResults_SubjectName_MTB.Size = new System.Drawing.Size(200, 50);
            this.ExamResults_SubjectName_MTB.TabIndex = 99;
            this.ExamResults_SubjectName_MTB.Tag = "";
            this.ExamResults_SubjectName_MTB.Text = "";
            // 
            // ExamResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.ExamResults_SubjectName_Error);
            this.Controls.Add(this.ExamResults_SubjectName_MTB);
            this.Controls.Add(this.ExamResults_Marks_Error);
            this.Controls.Add(this.ExamResults_Marks_MTB);
            this.Controls.Add(this.AdminDasboard_Navbar_MC);
            this.Controls.Add(this.StudentDashboard_ViewData_MC);
            this.Controls.Add(this.StudentDashboard_Title_ML);
            this.Controls.Add(this.MapStudent_Error);
            this.Controls.Add(this.MapStudent_Success);
            this.Controls.Add(this.MapSubject_SaveBtn_MB);
            this.Controls.Add(this.MapStudent_StudentName_MLV);
            this.Controls.Add(this.MapStudent_ClassName_MLV);
            this.Controls.Add(this.ExamResults_StudentName_Error);
            this.Controls.Add(this.ExamResults_StudentName_MTB);
            this.Controls.Add(this.ExamResults_ClassID_Error);
            this.Controls.Add(this.ExamResults_ClassID_MTB);
            this.Controls.Add(this.MapSubject_ResetBtn_MB);
            this.Font = new System.Drawing.Font("Roboto", 18F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ExamResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-pupil Exam Results";
            this.Load += new System.EventHandler(this.ExamResults_Load);
            this.AdminDasboard_Navbar_MC.ResumeLayout(false);
            this.AdminDasboard_Navbar_MC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDashbaord_Logo_PB)).EndInit();
            this.StudentDashboard_ViewData_MC.ResumeLayout(false);
            this.StudentDashboard_ViewData_MC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard AdminDasboard_Navbar_MC;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox AdminDashbaord_Logo_PB;
        private MaterialSkin.Controls.MaterialButton AdminDashboard_Settings_MLB;
        private MaterialSkin.Controls.MaterialButton AdminDashboard_Logout_MLB;
        private MaterialSkin.Controls.MaterialButton AdminDashboard_CD_MLB;
        private MaterialSkin.Controls.MaterialButton AdminDashboard_ScD_MLB;
        private MaterialSkin.Controls.MaterialCard StudentDashboard_ViewData_MC;
        private MaterialSkin.Controls.MaterialComboBox MapStudent_ViewData_FilterBy_MCB;
        private MaterialSkin.Controls.MaterialTextBox MapStudent_ViewData_SearchValue_MTB;
        private MaterialSkin.Controls.MaterialButton MapSubject_ViewData_Search_MB;
        private MaterialSkin.Controls.MaterialListView MapSubject_FullDataListView_MLV;
        private MaterialSkin.Controls.MaterialLabel StudentDashboard_Title_ML;
        private System.Windows.Forms.Label MapStudent_Error;
        private System.Windows.Forms.Label MapStudent_Success;
        private MaterialSkin.Controls.MaterialButton MapSubject_SaveBtn_MB;
        private MaterialSkin.Controls.MaterialListView MapStudent_StudentName_MLV;
        private MaterialSkin.Controls.MaterialListView MapStudent_ClassName_MLV;
        private System.Windows.Forms.Label ExamResults_StudentName_Error;
        private MaterialSkin.Controls.MaterialTextBox ExamResults_StudentName_MTB;
        private System.Windows.Forms.Label ExamResults_ClassID_Error;
        private MaterialSkin.Controls.MaterialTextBox ExamResults_ClassID_MTB;
        private MaterialSkin.Controls.MaterialButton MapSubject_ResetBtn_MB;
        private System.Windows.Forms.Label ExamResults_Marks_Error;
        private MaterialSkin.Controls.MaterialTextBox ExamResults_Marks_MTB;
        private System.Windows.Forms.Label ExamResults_SubjectName_Error;
        private MaterialSkin.Controls.MaterialTextBox ExamResults_SubjectName_MTB;
    }
}