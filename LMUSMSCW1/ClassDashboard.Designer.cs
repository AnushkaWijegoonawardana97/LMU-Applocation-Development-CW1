
namespace LMUSMSCW1
{
    partial class ClassDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassDashboard));
            this.ClassDashboard_Close_PB = new System.Windows.Forms.PictureBox();
            this.ClassDashboard_Title_ML = new MaterialSkin.Controls.MaterialLabel();
            this.ClassDashboard_YearInput_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.ClassDashboard_SectionInput_MCB = new MaterialSkin.Controls.MaterialComboBox();
            this.ClassDashboard_GradeInput_MCB = new MaterialSkin.Controls.MaterialComboBox();
            this.ClassDashboard_ClassNameInput_MTB = new MaterialSkin.Controls.MaterialTextBox();
            this.ClassDashboard_ClassTeacherInput_MCB = new MaterialSkin.Controls.MaterialComboBox();
            this.ClassDashboard_ClassMonitorInput_MCB = new MaterialSkin.Controls.MaterialComboBox();
            this.ClassDashboard_ResetBtn_MB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_SaveBtn_MB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_ViewData_MC = new MaterialSkin.Controls.MaterialCard();
            this.ClassDashboard_DataTabel_MLV = new MaterialSkin.Controls.MaterialListView();
            this.ClassDasboard_Navbar_MC = new MaterialSkin.Controls.MaterialCard();
            this.ClassDashbaord_Logo_PB = new System.Windows.Forms.PictureBox();
            this.ClassDashboard_Settings_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_Logout_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_UD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_SubD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_StfD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_StuD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_CD_MLB = new MaterialSkin.Controls.MaterialButton();
            this.ClassDashboard_ScD_MLB = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDashboard_Close_PB)).BeginInit();
            this.ClassDashboard_ViewData_MC.SuspendLayout();
            this.ClassDasboard_Navbar_MC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDashbaord_Logo_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassDashboard_Close_PB
            // 
            this.ClassDashboard_Close_PB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_Close_PB.Image = ((System.Drawing.Image)(resources.GetObject("ClassDashboard_Close_PB.Image")));
            this.ClassDashboard_Close_PB.Location = new System.Drawing.Point(1156, 12);
            this.ClassDashboard_Close_PB.Name = "ClassDashboard_Close_PB";
            this.ClassDashboard_Close_PB.Size = new System.Drawing.Size(32, 32);
            this.ClassDashboard_Close_PB.TabIndex = 4;
            this.ClassDashboard_Close_PB.TabStop = false;
            this.ClassDashboard_Close_PB.Click += new System.EventHandler(this.ClassDashboard_Close_PB_Click);
            // 
            // ClassDashboard_Title_ML
            // 
            this.ClassDashboard_Title_ML.AutoSize = true;
            this.ClassDashboard_Title_ML.Depth = 0;
            this.ClassDashboard_Title_ML.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ClassDashboard_Title_ML.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.ClassDashboard_Title_ML.Location = new System.Drawing.Point(249, 28);
            this.ClassDashboard_Title_ML.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_Title_ML.Name = "ClassDashboard_Title_ML";
            this.ClassDashboard_Title_ML.Size = new System.Drawing.Size(182, 29);
            this.ClassDashboard_Title_ML.TabIndex = 17;
            this.ClassDashboard_Title_ML.Text = "Class Dashboard";
            // 
            // ClassDashboard_YearInput_MTB
            // 
            this.ClassDashboard_YearInput_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassDashboard_YearInput_MTB.Depth = 0;
            this.ClassDashboard_YearInput_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.ClassDashboard_YearInput_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClassDashboard_YearInput_MTB.Hint = "Year";
            this.ClassDashboard_YearInput_MTB.Location = new System.Drawing.Point(575, 89);
            this.ClassDashboard_YearInput_MTB.MaxLength = 50;
            this.ClassDashboard_YearInput_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_YearInput_MTB.Multiline = false;
            this.ClassDashboard_YearInput_MTB.Name = "ClassDashboard_YearInput_MTB";
            this.ClassDashboard_YearInput_MTB.Size = new System.Drawing.Size(275, 50);
            this.ClassDashboard_YearInput_MTB.TabIndex = 18;
            this.ClassDashboard_YearInput_MTB.Tag = "";
            this.ClassDashboard_YearInput_MTB.Text = "";
            // 
            // ClassDashboard_SectionInput_MCB
            // 
            this.ClassDashboard_SectionInput_MCB.AutoResize = false;
            this.ClassDashboard_SectionInput_MCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDashboard_SectionInput_MCB.Depth = 0;
            this.ClassDashboard_SectionInput_MCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClassDashboard_SectionInput_MCB.DropDownHeight = 174;
            this.ClassDashboard_SectionInput_MCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDashboard_SectionInput_MCB.DropDownWidth = 121;
            this.ClassDashboard_SectionInput_MCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ClassDashboard_SectionInput_MCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassDashboard_SectionInput_MCB.FormattingEnabled = true;
            this.ClassDashboard_SectionInput_MCB.Hint = "Section";
            this.ClassDashboard_SectionInput_MCB.IntegralHeight = false;
            this.ClassDashboard_SectionInput_MCB.ItemHeight = 43;
            this.ClassDashboard_SectionInput_MCB.Items.AddRange(new object[] {
            "Primary Section",
            "Middle School Section",
            "Upper School Section",
            "A/L Section"});
            this.ClassDashboard_SectionInput_MCB.Location = new System.Drawing.Point(254, 90);
            this.ClassDashboard_SectionInput_MCB.MaxDropDownItems = 4;
            this.ClassDashboard_SectionInput_MCB.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_SectionInput_MCB.Name = "ClassDashboard_SectionInput_MCB";
            this.ClassDashboard_SectionInput_MCB.Size = new System.Drawing.Size(275, 49);
            this.ClassDashboard_SectionInput_MCB.TabIndex = 19;
            // 
            // ClassDashboard_GradeInput_MCB
            // 
            this.ClassDashboard_GradeInput_MCB.AutoResize = false;
            this.ClassDashboard_GradeInput_MCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDashboard_GradeInput_MCB.Depth = 0;
            this.ClassDashboard_GradeInput_MCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClassDashboard_GradeInput_MCB.DropDownHeight = 174;
            this.ClassDashboard_GradeInput_MCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDashboard_GradeInput_MCB.DropDownWidth = 121;
            this.ClassDashboard_GradeInput_MCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ClassDashboard_GradeInput_MCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassDashboard_GradeInput_MCB.FormattingEnabled = true;
            this.ClassDashboard_GradeInput_MCB.Hint = "Grade";
            this.ClassDashboard_GradeInput_MCB.IntegralHeight = false;
            this.ClassDashboard_GradeInput_MCB.ItemHeight = 43;
            this.ClassDashboard_GradeInput_MCB.Items.AddRange(new object[] {
            "Primary Section",
            "Middle School Section",
            "Upper School Section",
            "A/L Section"});
            this.ClassDashboard_GradeInput_MCB.Location = new System.Drawing.Point(893, 90);
            this.ClassDashboard_GradeInput_MCB.MaxDropDownItems = 4;
            this.ClassDashboard_GradeInput_MCB.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_GradeInput_MCB.Name = "ClassDashboard_GradeInput_MCB";
            this.ClassDashboard_GradeInput_MCB.Size = new System.Drawing.Size(275, 49);
            this.ClassDashboard_GradeInput_MCB.TabIndex = 20;
            // 
            // ClassDashboard_ClassNameInput_MTB
            // 
            this.ClassDashboard_ClassNameInput_MTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassDashboard_ClassNameInput_MTB.Depth = 0;
            this.ClassDashboard_ClassNameInput_MTB.Font = new System.Drawing.Font("Roboto", 12F);
            this.ClassDashboard_ClassNameInput_MTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClassDashboard_ClassNameInput_MTB.Hint = "Class Name";
            this.ClassDashboard_ClassNameInput_MTB.Location = new System.Drawing.Point(254, 166);
            this.ClassDashboard_ClassNameInput_MTB.MaxLength = 50;
            this.ClassDashboard_ClassNameInput_MTB.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_ClassNameInput_MTB.Multiline = false;
            this.ClassDashboard_ClassNameInput_MTB.Name = "ClassDashboard_ClassNameInput_MTB";
            this.ClassDashboard_ClassNameInput_MTB.Size = new System.Drawing.Size(275, 50);
            this.ClassDashboard_ClassNameInput_MTB.TabIndex = 21;
            this.ClassDashboard_ClassNameInput_MTB.Tag = "";
            this.ClassDashboard_ClassNameInput_MTB.Text = "";
            // 
            // ClassDashboard_ClassTeacherInput_MCB
            // 
            this.ClassDashboard_ClassTeacherInput_MCB.AutoResize = false;
            this.ClassDashboard_ClassTeacherInput_MCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDashboard_ClassTeacherInput_MCB.Depth = 0;
            this.ClassDashboard_ClassTeacherInput_MCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClassDashboard_ClassTeacherInput_MCB.DropDownHeight = 174;
            this.ClassDashboard_ClassTeacherInput_MCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDashboard_ClassTeacherInput_MCB.DropDownWidth = 121;
            this.ClassDashboard_ClassTeacherInput_MCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ClassDashboard_ClassTeacherInput_MCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassDashboard_ClassTeacherInput_MCB.FormattingEnabled = true;
            this.ClassDashboard_ClassTeacherInput_MCB.Hint = "Class Teacher";
            this.ClassDashboard_ClassTeacherInput_MCB.IntegralHeight = false;
            this.ClassDashboard_ClassTeacherInput_MCB.ItemHeight = 43;
            this.ClassDashboard_ClassTeacherInput_MCB.Items.AddRange(new object[] {
            "Primary Section",
            "Middle School Section",
            "Upper School Section",
            "A/L Section"});
            this.ClassDashboard_ClassTeacherInput_MCB.Location = new System.Drawing.Point(575, 167);
            this.ClassDashboard_ClassTeacherInput_MCB.MaxDropDownItems = 4;
            this.ClassDashboard_ClassTeacherInput_MCB.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_ClassTeacherInput_MCB.Name = "ClassDashboard_ClassTeacherInput_MCB";
            this.ClassDashboard_ClassTeacherInput_MCB.Size = new System.Drawing.Size(275, 49);
            this.ClassDashboard_ClassTeacherInput_MCB.TabIndex = 22;
            // 
            // ClassDashboard_ClassMonitorInput_MCB
            // 
            this.ClassDashboard_ClassMonitorInput_MCB.AutoResize = false;
            this.ClassDashboard_ClassMonitorInput_MCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDashboard_ClassMonitorInput_MCB.Depth = 0;
            this.ClassDashboard_ClassMonitorInput_MCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClassDashboard_ClassMonitorInput_MCB.DropDownHeight = 174;
            this.ClassDashboard_ClassMonitorInput_MCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDashboard_ClassMonitorInput_MCB.DropDownWidth = 121;
            this.ClassDashboard_ClassMonitorInput_MCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ClassDashboard_ClassMonitorInput_MCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassDashboard_ClassMonitorInput_MCB.FormattingEnabled = true;
            this.ClassDashboard_ClassMonitorInput_MCB.Hint = "Class Monitor";
            this.ClassDashboard_ClassMonitorInput_MCB.IntegralHeight = false;
            this.ClassDashboard_ClassMonitorInput_MCB.ItemHeight = 43;
            this.ClassDashboard_ClassMonitorInput_MCB.Items.AddRange(new object[] {
            "Primary Section",
            "Middle School Section",
            "Upper School Section",
            "A/L Section"});
            this.ClassDashboard_ClassMonitorInput_MCB.Location = new System.Drawing.Point(893, 167);
            this.ClassDashboard_ClassMonitorInput_MCB.MaxDropDownItems = 4;
            this.ClassDashboard_ClassMonitorInput_MCB.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_ClassMonitorInput_MCB.Name = "ClassDashboard_ClassMonitorInput_MCB";
            this.ClassDashboard_ClassMonitorInput_MCB.Size = new System.Drawing.Size(275, 49);
            this.ClassDashboard_ClassMonitorInput_MCB.TabIndex = 23;
            // 
            // ClassDashboard_ResetBtn_MB
            // 
            this.ClassDashboard_ResetBtn_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_ResetBtn_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_ResetBtn_MB.Depth = 0;
            this.ClassDashboard_ResetBtn_MB.DrawShadows = true;
            this.ClassDashboard_ResetBtn_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassDashboard_ResetBtn_MB.HighEmphasis = true;
            this.ClassDashboard_ResetBtn_MB.Icon = null;
            this.ClassDashboard_ResetBtn_MB.Location = new System.Drawing.Point(768, 248);
            this.ClassDashboard_ResetBtn_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_ResetBtn_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_ResetBtn_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_ResetBtn_MB.Name = "ClassDashboard_ResetBtn_MB";
            this.ClassDashboard_ResetBtn_MB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_ResetBtn_MB.TabIndex = 25;
            this.ClassDashboard_ResetBtn_MB.Text = "Rest";
            this.ClassDashboard_ResetBtn_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_ResetBtn_MB.UseAccentColor = false;
            this.ClassDashboard_ResetBtn_MB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_SaveBtn_MB
            // 
            this.ClassDashboard_SaveBtn_MB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_SaveBtn_MB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_SaveBtn_MB.Depth = 0;
            this.ClassDashboard_SaveBtn_MB.DrawShadows = true;
            this.ClassDashboard_SaveBtn_MB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassDashboard_SaveBtn_MB.HighEmphasis = true;
            this.ClassDashboard_SaveBtn_MB.Icon = null;
            this.ClassDashboard_SaveBtn_MB.Location = new System.Drawing.Point(988, 248);
            this.ClassDashboard_SaveBtn_MB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_SaveBtn_MB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_SaveBtn_MB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_SaveBtn_MB.Name = "ClassDashboard_SaveBtn_MB";
            this.ClassDashboard_SaveBtn_MB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_SaveBtn_MB.TabIndex = 24;
            this.ClassDashboard_SaveBtn_MB.Text = "Save";
            this.ClassDashboard_SaveBtn_MB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_SaveBtn_MB.UseAccentColor = false;
            this.ClassDashboard_SaveBtn_MB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_ViewData_MC
            // 
            this.ClassDashboard_ViewData_MC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDashboard_ViewData_MC.Controls.Add(this.ClassDashboard_DataTabel_MLV);
            this.ClassDashboard_ViewData_MC.Depth = 0;
            this.ClassDashboard_ViewData_MC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassDashboard_ViewData_MC.Location = new System.Drawing.Point(254, 319);
            this.ClassDashboard_ViewData_MC.Margin = new System.Windows.Forms.Padding(14);
            this.ClassDashboard_ViewData_MC.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_ViewData_MC.Name = "ClassDashboard_ViewData_MC";
            this.ClassDashboard_ViewData_MC.Padding = new System.Windows.Forms.Padding(14);
            this.ClassDashboard_ViewData_MC.Size = new System.Drawing.Size(914, 446);
            this.ClassDashboard_ViewData_MC.TabIndex = 26;
            // 
            // ClassDashboard_DataTabel_MLV
            // 
            this.ClassDashboard_DataTabel_MLV.AutoSizeTable = false;
            this.ClassDashboard_DataTabel_MLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDashboard_DataTabel_MLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassDashboard_DataTabel_MLV.Depth = 0;
            this.ClassDashboard_DataTabel_MLV.FullRowSelect = true;
            this.ClassDashboard_DataTabel_MLV.HideSelection = false;
            this.ClassDashboard_DataTabel_MLV.Location = new System.Drawing.Point(17, 17);
            this.ClassDashboard_DataTabel_MLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.ClassDashboard_DataTabel_MLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ClassDashboard_DataTabel_MLV.MouseState = MaterialSkin.MouseState.OUT;
            this.ClassDashboard_DataTabel_MLV.Name = "ClassDashboard_DataTabel_MLV";
            this.ClassDashboard_DataTabel_MLV.OwnerDraw = true;
            this.ClassDashboard_DataTabel_MLV.Size = new System.Drawing.Size(880, 412);
            this.ClassDashboard_DataTabel_MLV.TabIndex = 1;
            this.ClassDashboard_DataTabel_MLV.UseCompatibleStateImageBehavior = false;
            this.ClassDashboard_DataTabel_MLV.View = System.Windows.Forms.View.Details;
            // 
            // ClassDasboard_Navbar_MC
            // 
            this.ClassDasboard_Navbar_MC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashbaord_Logo_PB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_Settings_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_Logout_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_UD_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_SubD_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_StfD_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_StuD_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_CD_MLB);
            this.ClassDasboard_Navbar_MC.Controls.Add(this.ClassDashboard_ScD_MLB);
            this.ClassDasboard_Navbar_MC.Depth = 0;
            this.ClassDasboard_Navbar_MC.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassDasboard_Navbar_MC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClassDasboard_Navbar_MC.Location = new System.Drawing.Point(0, 0);
            this.ClassDasboard_Navbar_MC.Margin = new System.Windows.Forms.Padding(14);
            this.ClassDasboard_Navbar_MC.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDasboard_Navbar_MC.Name = "ClassDasboard_Navbar_MC";
            this.ClassDasboard_Navbar_MC.Padding = new System.Windows.Forms.Padding(14);
            this.ClassDasboard_Navbar_MC.Size = new System.Drawing.Size(220, 800);
            this.ClassDasboard_Navbar_MC.TabIndex = 27;
            // 
            // ClassDashbaord_Logo_PB
            // 
            this.ClassDashbaord_Logo_PB.Location = new System.Drawing.Point(19, 17);
            this.ClassDashbaord_Logo_PB.Name = "ClassDashbaord_Logo_PB";
            this.ClassDashbaord_Logo_PB.Size = new System.Drawing.Size(180, 60);
            this.ClassDashbaord_Logo_PB.TabIndex = 2;
            this.ClassDashbaord_Logo_PB.TabStop = false;
            // 
            // ClassDashboard_Settings_MLB
            // 
            this.ClassDashboard_Settings_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_Settings_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_Settings_MLB.Depth = 0;
            this.ClassDashboard_Settings_MLB.DrawShadows = true;
            this.ClassDashboard_Settings_MLB.HighEmphasis = true;
            this.ClassDashboard_Settings_MLB.Icon = null;
            this.ClassDashboard_Settings_MLB.Location = new System.Drawing.Point(18, 696);
            this.ClassDashboard_Settings_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_Settings_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_Settings_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_Settings_MLB.Name = "ClassDashboard_Settings_MLB";
            this.ClassDashboard_Settings_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_Settings_MLB.TabIndex = 8;
            this.ClassDashboard_Settings_MLB.Text = "Settings";
            this.ClassDashboard_Settings_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_Settings_MLB.UseAccentColor = false;
            this.ClassDashboard_Settings_MLB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_Logout_MLB
            // 
            this.ClassDashboard_Logout_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_Logout_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_Logout_MLB.Depth = 0;
            this.ClassDashboard_Logout_MLB.DrawShadows = true;
            this.ClassDashboard_Logout_MLB.HighEmphasis = true;
            this.ClassDashboard_Logout_MLB.Icon = null;
            this.ClassDashboard_Logout_MLB.Location = new System.Drawing.Point(19, 749);
            this.ClassDashboard_Logout_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_Logout_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_Logout_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_Logout_MLB.Name = "ClassDashboard_Logout_MLB";
            this.ClassDashboard_Logout_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_Logout_MLB.TabIndex = 7;
            this.ClassDashboard_Logout_MLB.Text = "Logout";
            this.ClassDashboard_Logout_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_Logout_MLB.UseAccentColor = false;
            this.ClassDashboard_Logout_MLB.UseVisualStyleBackColor = true;
            this.ClassDashboard_Logout_MLB.Click += new System.EventHandler(this.ClassDashboard_Logout_MLB_Click_1);
            // 
            // ClassDashboard_UD_MLB
            // 
            this.ClassDashboard_UD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_UD_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_UD_MLB.Depth = 0;
            this.ClassDashboard_UD_MLB.DrawShadows = true;
            this.ClassDashboard_UD_MLB.HighEmphasis = true;
            this.ClassDashboard_UD_MLB.Icon = null;
            this.ClassDashboard_UD_MLB.Location = new System.Drawing.Point(20, 371);
            this.ClassDashboard_UD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_UD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_UD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_UD_MLB.Name = "ClassDashboard_UD_MLB";
            this.ClassDashboard_UD_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_UD_MLB.TabIndex = 6;
            this.ClassDashboard_UD_MLB.Text = "User Dashboard";
            this.ClassDashboard_UD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_UD_MLB.UseAccentColor = false;
            this.ClassDashboard_UD_MLB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_SubD_MLB
            // 
            this.ClassDashboard_SubD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_SubD_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_SubD_MLB.Depth = 0;
            this.ClassDashboard_SubD_MLB.DrawShadows = true;
            this.ClassDashboard_SubD_MLB.HighEmphasis = true;
            this.ClassDashboard_SubD_MLB.Icon = null;
            this.ClassDashboard_SubD_MLB.Location = new System.Drawing.Point(18, 318);
            this.ClassDashboard_SubD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_SubD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_SubD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_SubD_MLB.Name = "ClassDashboard_SubD_MLB";
            this.ClassDashboard_SubD_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_SubD_MLB.TabIndex = 4;
            this.ClassDashboard_SubD_MLB.Text = "Subject Dashboard";
            this.ClassDashboard_SubD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_SubD_MLB.UseAccentColor = false;
            this.ClassDashboard_SubD_MLB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_StfD_MLB
            // 
            this.ClassDashboard_StfD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_StfD_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_StfD_MLB.Depth = 0;
            this.ClassDashboard_StfD_MLB.DrawShadows = true;
            this.ClassDashboard_StfD_MLB.HighEmphasis = true;
            this.ClassDashboard_StfD_MLB.Icon = null;
            this.ClassDashboard_StfD_MLB.Location = new System.Drawing.Point(18, 265);
            this.ClassDashboard_StfD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_StfD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_StfD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_StfD_MLB.Name = "ClassDashboard_StfD_MLB";
            this.ClassDashboard_StfD_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_StfD_MLB.TabIndex = 5;
            this.ClassDashboard_StfD_MLB.Text = "Staff Dashboard";
            this.ClassDashboard_StfD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_StfD_MLB.UseAccentColor = false;
            this.ClassDashboard_StfD_MLB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_StuD_MLB
            // 
            this.ClassDashboard_StuD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_StuD_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_StuD_MLB.Depth = 0;
            this.ClassDashboard_StuD_MLB.DrawShadows = true;
            this.ClassDashboard_StuD_MLB.HighEmphasis = true;
            this.ClassDashboard_StuD_MLB.Icon = null;
            this.ClassDashboard_StuD_MLB.Location = new System.Drawing.Point(17, 212);
            this.ClassDashboard_StuD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_StuD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_StuD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_StuD_MLB.Name = "ClassDashboard_StuD_MLB";
            this.ClassDashboard_StuD_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_StuD_MLB.TabIndex = 5;
            this.ClassDashboard_StuD_MLB.Text = "Student Dashboard";
            this.ClassDashboard_StuD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_StuD_MLB.UseAccentColor = false;
            this.ClassDashboard_StuD_MLB.UseVisualStyleBackColor = true;
            // 
            // ClassDashboard_CD_MLB
            // 
            this.ClassDashboard_CD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_CD_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_CD_MLB.Depth = 0;
            this.ClassDashboard_CD_MLB.DrawShadows = true;
            this.ClassDashboard_CD_MLB.HighEmphasis = true;
            this.ClassDashboard_CD_MLB.Icon = null;
            this.ClassDashboard_CD_MLB.Location = new System.Drawing.Point(18, 159);
            this.ClassDashboard_CD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_CD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_CD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_CD_MLB.Name = "ClassDashboard_CD_MLB";
            this.ClassDashboard_CD_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_CD_MLB.TabIndex = 5;
            this.ClassDashboard_CD_MLB.Text = "Class Dashboard";
            this.ClassDashboard_CD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_CD_MLB.UseAccentColor = false;
            this.ClassDashboard_CD_MLB.UseVisualStyleBackColor = true;
            this.ClassDashboard_CD_MLB.Click += new System.EventHandler(this.ClassDashboard_CD_MLB_Click);
            // 
            // ClassDashboard_ScD_MLB
            // 
            this.ClassDashboard_ScD_MLB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassDashboard_ScD_MLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassDashboard_ScD_MLB.Depth = 0;
            this.ClassDashboard_ScD_MLB.DrawShadows = true;
            this.ClassDashboard_ScD_MLB.HighEmphasis = true;
            this.ClassDashboard_ScD_MLB.Icon = null;
            this.ClassDashboard_ScD_MLB.Location = new System.Drawing.Point(18, 106);
            this.ClassDashboard_ScD_MLB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassDashboard_ScD_MLB.MinimumSize = new System.Drawing.Size(180, 0);
            this.ClassDashboard_ScD_MLB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassDashboard_ScD_MLB.Name = "ClassDashboard_ScD_MLB";
            this.ClassDashboard_ScD_MLB.Size = new System.Drawing.Size(180, 36);
            this.ClassDashboard_ScD_MLB.TabIndex = 1;
            this.ClassDashboard_ScD_MLB.Text = "School Dashboard";
            this.ClassDashboard_ScD_MLB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClassDashboard_ScD_MLB.UseAccentColor = false;
            this.ClassDashboard_ScD_MLB.UseVisualStyleBackColor = true;
            this.ClassDashboard_ScD_MLB.Click += new System.EventHandler(this.ClassDashboard_ScD_MLB_Click);
            // 
            // ClassDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.ClassDasboard_Navbar_MC);
            this.Controls.Add(this.ClassDashboard_ViewData_MC);
            this.Controls.Add(this.ClassDashboard_ResetBtn_MB);
            this.Controls.Add(this.ClassDashboard_SaveBtn_MB);
            this.Controls.Add(this.ClassDashboard_ClassMonitorInput_MCB);
            this.Controls.Add(this.ClassDashboard_ClassTeacherInput_MCB);
            this.Controls.Add(this.ClassDashboard_ClassNameInput_MTB);
            this.Controls.Add(this.ClassDashboard_GradeInput_MCB);
            this.Controls.Add(this.ClassDashboard_SectionInput_MCB);
            this.Controls.Add(this.ClassDashboard_YearInput_MTB);
            this.Controls.Add(this.ClassDashboard_Title_ML);
            this.Controls.Add(this.ClassDashboard_Close_PB);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ClassDashboard_Close_PB)).EndInit();
            this.ClassDashboard_ViewData_MC.ResumeLayout(false);
            this.ClassDasboard_Navbar_MC.ResumeLayout(false);
            this.ClassDasboard_Navbar_MC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDashbaord_Logo_PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ClassDashboard_Close_PB;
        private MaterialSkin.Controls.MaterialLabel ClassDashboard_Title_ML;
        private MaterialSkin.Controls.MaterialTextBox ClassDashboard_YearInput_MTB;
        private MaterialSkin.Controls.MaterialComboBox ClassDashboard_SectionInput_MCB;
        private MaterialSkin.Controls.MaterialComboBox ClassDashboard_GradeInput_MCB;
        private MaterialSkin.Controls.MaterialTextBox ClassDashboard_ClassNameInput_MTB;
        private MaterialSkin.Controls.MaterialComboBox ClassDashboard_ClassTeacherInput_MCB;
        private MaterialSkin.Controls.MaterialComboBox ClassDashboard_ClassMonitorInput_MCB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_ResetBtn_MB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_SaveBtn_MB;
        private MaterialSkin.Controls.MaterialCard ClassDashboard_ViewData_MC;
        private MaterialSkin.Controls.MaterialListView ClassDashboard_DataTabel_MLV;
        private MaterialSkin.Controls.MaterialCard ClassDasboard_Navbar_MC;
        private System.Windows.Forms.PictureBox ClassDashbaord_Logo_PB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_Settings_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_Logout_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_UD_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_SubD_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_StfD_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_StuD_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_CD_MLB;
        private MaterialSkin.Controls.MaterialButton ClassDashboard_ScD_MLB;
    }
}