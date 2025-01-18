namespace UniversitySystem
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.CMSStudentHandle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ILUniversitySections = new System.Windows.Forms.ImageList(this.components);
            this.TCStudents = new Guna.UI2.WinForms.Guna2TabControl();
            this.TStudents = new System.Windows.Forms.TabPage();
            this.TCStudentsOP = new Guna.UI2.WinForms.Guna2TabControl();
            this.TPStudentsList = new System.Windows.Forms.TabPage();
            this.LVStudentsList = new System.Windows.Forms.ListView();
            this.ILGenderImage = new System.Windows.Forms.ImageList(this.components);
            this.TAcademicInfo = new System.Windows.Forms.TabPage();
            this.LVAcademicInfo = new System.Windows.Forms.ListView();
            this.TPersonalInfo = new System.Windows.Forms.TabPage();
            this.LVPersonalInfo = new System.Windows.Forms.ListView();
            this.TContactInfo = new System.Windows.Forms.TabPage();
            this.LVContactInfo = new System.Windows.Forms.ListView();
            this.TView = new System.Windows.Forms.TabPage();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LBAchievements = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBCredits = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBGPA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBYearOfStudy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBMajor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBStudentID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LBGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBLastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBBirthDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBFirstName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PBStudentImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TAdd = new System.Windows.Forms.TabPage();
            this.TUpdate = new System.Windows.Forms.TabPage();
            this.TProfessors = new System.Windows.Forms.TabPage();
            this.TCourses = new System.Windows.Forms.TabPage();
            this.TDepartements = new System.Windows.Forms.TabPage();
            this.CMSStudentHandle.SuspendLayout();
            this.TCStudents.SuspendLayout();
            this.TStudents.SuspendLayout();
            this.TCStudentsOP.SuspendLayout();
            this.TPStudentsList.SuspendLayout();
            this.TAcademicInfo.SuspendLayout();
            this.TPersonalInfo.SuspendLayout();
            this.TContactInfo.SuspendLayout();
            this.TView.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CMSStudentHandle
            // 
            this.CMSStudentHandle.BackColor = System.Drawing.Color.SteelBlue;
            this.CMSStudentHandle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.CMSStudentHandle.Name = "CMSStudentHandle";
            resources.ApplyResources(this.CMSStudentHandle, "CMSStudentHandle");
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // ILUniversitySections
            // 
            this.ILUniversitySections.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILUniversitySections.ImageStream")));
            this.ILUniversitySections.TransparentColor = System.Drawing.Color.Transparent;
            this.ILUniversitySections.Images.SetKeyName(0, "graduation.png");
            this.ILUniversitySections.Images.SetKeyName(1, "dean.png");
            this.ILUniversitySections.Images.SetKeyName(2, "curriculum.png");
            this.ILUniversitySections.Images.SetKeyName(3, "department.png");
            // 
            // TCStudents
            // 
            resources.ApplyResources(this.TCStudents, "TCStudents");
            this.TCStudents.Controls.Add(this.TStudents);
            this.TCStudents.Controls.Add(this.TProfessors);
            this.TCStudents.Controls.Add(this.TCourses);
            this.TCStudents.Controls.Add(this.TDepartements);
            this.TCStudents.ImageList = this.ILUniversitySections;
            this.TCStudents.Name = "TCStudents";
            this.TCStudents.SelectedIndex = 0;
            this.TCStudents.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TCStudents.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TCStudents.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TCStudents.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TCStudents.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TCStudents.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TCStudents.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TCStudents.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TCStudents.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TCStudents.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TCStudents.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TCStudents.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TCStudents.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TCStudents.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TCStudents.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TCStudents.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TCStudents.TabButtonSize = new System.Drawing.Size(150, 50);
            this.TCStudents.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TCStudents.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // TStudents
            // 
            this.TStudents.BackColor = System.Drawing.Color.SteelBlue;
            this.TStudents.Controls.Add(this.TCStudentsOP);
            resources.ApplyResources(this.TStudents, "TStudents");
            this.TStudents.Name = "TStudents";
            // 
            // TCStudentsOP
            // 
            this.TCStudentsOP.Controls.Add(this.TPStudentsList);
            this.TCStudentsOP.Controls.Add(this.TAcademicInfo);
            this.TCStudentsOP.Controls.Add(this.TPersonalInfo);
            this.TCStudentsOP.Controls.Add(this.TContactInfo);
            this.TCStudentsOP.Controls.Add(this.TView);
            this.TCStudentsOP.Controls.Add(this.TAdd);
            this.TCStudentsOP.Controls.Add(this.TUpdate);
            resources.ApplyResources(this.TCStudentsOP, "TCStudentsOP");
            this.TCStudentsOP.Name = "TCStudentsOP";
            this.TCStudentsOP.SelectedIndex = 0;
            this.TCStudentsOP.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TCStudentsOP.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TCStudentsOP.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TCStudentsOP.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TCStudentsOP.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TCStudentsOP.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TCStudentsOP.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TCStudentsOP.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TCStudentsOP.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TCStudentsOP.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TCStudentsOP.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TCStudentsOP.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TCStudentsOP.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TCStudentsOP.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TCStudentsOP.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TCStudentsOP.TabButtonSize = new System.Drawing.Size(80, 45);
            this.TCStudentsOP.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TCStudentsOP.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.TCStudentsOP.SelectedIndexChanged += new System.EventHandler(this.TCStudentsOP_SelectedIndexChanged);
            // 
            // TPStudentsList
            // 
            this.TPStudentsList.BackColor = System.Drawing.Color.SteelBlue;
            this.TPStudentsList.Controls.Add(this.LVStudentsList);
            resources.ApplyResources(this.TPStudentsList, "TPStudentsList");
            this.TPStudentsList.Name = "TPStudentsList";
            // 
            // LVStudentsList
            // 
            this.LVStudentsList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LVStudentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVStudentsList.ContextMenuStrip = this.CMSStudentHandle;
            this.LVStudentsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.LVStudentsList.HideSelection = false;
            resources.ApplyResources(this.LVStudentsList, "LVStudentsList");
            this.LVStudentsList.Name = "LVStudentsList";
            this.LVStudentsList.SmallImageList = this.ILGenderImage;
            this.LVStudentsList.UseCompatibleStateImageBehavior = false;
            this.LVStudentsList.View = System.Windows.Forms.View.Details;
            // 
            // ILGenderImage
            // 
            this.ILGenderImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILGenderImage.ImageStream")));
            this.ILGenderImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ILGenderImage.Images.SetKeyName(0, "man.png");
            this.ILGenderImage.Images.SetKeyName(1, "woman.png");
            // 
            // TAcademicInfo
            // 
            this.TAcademicInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.TAcademicInfo.Controls.Add(this.LVAcademicInfo);
            resources.ApplyResources(this.TAcademicInfo, "TAcademicInfo");
            this.TAcademicInfo.Name = "TAcademicInfo";
            // 
            // LVAcademicInfo
            // 
            this.LVAcademicInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LVAcademicInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVAcademicInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.LVAcademicInfo.HideSelection = false;
            resources.ApplyResources(this.LVAcademicInfo, "LVAcademicInfo");
            this.LVAcademicInfo.Name = "LVAcademicInfo";
            this.LVAcademicInfo.SmallImageList = this.ILGenderImage;
            this.LVAcademicInfo.UseCompatibleStateImageBehavior = false;
            this.LVAcademicInfo.View = System.Windows.Forms.View.Details;
            // 
            // TPersonalInfo
            // 
            this.TPersonalInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.TPersonalInfo.Controls.Add(this.LVPersonalInfo);
            resources.ApplyResources(this.TPersonalInfo, "TPersonalInfo");
            this.TPersonalInfo.Name = "TPersonalInfo";
            // 
            // LVPersonalInfo
            // 
            this.LVPersonalInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LVPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.LVPersonalInfo.HideSelection = false;
            resources.ApplyResources(this.LVPersonalInfo, "LVPersonalInfo");
            this.LVPersonalInfo.Name = "LVPersonalInfo";
            this.LVPersonalInfo.SmallImageList = this.ILGenderImage;
            this.LVPersonalInfo.UseCompatibleStateImageBehavior = false;
            this.LVPersonalInfo.View = System.Windows.Forms.View.Details;
            // 
            // TContactInfo
            // 
            this.TContactInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.TContactInfo.Controls.Add(this.LVContactInfo);
            resources.ApplyResources(this.TContactInfo, "TContactInfo");
            this.TContactInfo.Name = "TContactInfo";
            // 
            // LVContactInfo
            // 
            this.LVContactInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LVContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVContactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.LVContactInfo.HideSelection = false;
            resources.ApplyResources(this.LVContactInfo, "LVContactInfo");
            this.LVContactInfo.Name = "LVContactInfo";
            this.LVContactInfo.SmallImageList = this.ILGenderImage;
            this.LVContactInfo.UseCompatibleStateImageBehavior = false;
            this.LVContactInfo.View = System.Windows.Forms.View.Details;
            // 
            // TView
            // 
            this.TView.BackColor = System.Drawing.Color.SteelBlue;
            this.TView.Controls.Add(this.guna2CustomGradientPanel1);
            resources.ApplyResources(this.TView, "TView");
            this.TView.Name = "TView";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Separator1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GroupBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.PBStudentImage);
            resources.ApplyResources(this.guna2CustomGradientPanel1, "guna2CustomGradientPanel1");
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.AliceBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DeepSkyBlue;
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.LBAchievements);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel16);
            this.guna2GroupBox2.Controls.Add(this.LBCredits);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel14);
            this.guna2GroupBox2.Controls.Add(this.LBGPA);
            this.guna2GroupBox2.Controls.Add(this.LBYearOfStudy);
            this.guna2GroupBox2.Controls.Add(this.LBMajor);
            this.guna2GroupBox2.Controls.Add(this.LBStudentID);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel9);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel10);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel11);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel12);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.SkyBlue;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.guna2GroupBox2, "guna2GroupBox2");
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Depth = 20;
            this.guna2GroupBox2.UseTransparentBackground = true;
            // 
            // LBAchievements
            // 
            this.LBAchievements.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBAchievements, "LBAchievements");
            this.LBAchievements.Name = "LBAchievements";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel16, "guna2HtmlLabel16");
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            // 
            // LBCredits
            // 
            this.LBCredits.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBCredits, "LBCredits");
            this.LBCredits.Name = "LBCredits";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel14, "guna2HtmlLabel14");
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            // 
            // LBGPA
            // 
            this.LBGPA.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBGPA, "LBGPA");
            this.LBGPA.Name = "LBGPA";
            // 
            // LBYearOfStudy
            // 
            this.LBYearOfStudy.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBYearOfStudy, "LBYearOfStudy");
            this.LBYearOfStudy.Name = "LBYearOfStudy";
            // 
            // LBMajor
            // 
            this.LBMajor.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBMajor, "LBMajor");
            this.LBMajor.Name = "LBMajor";
            // 
            // LBStudentID
            // 
            this.LBStudentID.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBStudentID, "LBStudentID");
            this.LBStudentID.Name = "LBStudentID";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel9, "guna2HtmlLabel9");
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel10, "guna2HtmlLabel10");
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel11, "guna2HtmlLabel11");
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel12, "guna2HtmlLabel12");
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.LBGender);
            this.guna2GroupBox1.Controls.Add(this.LBLastName);
            this.guna2GroupBox1.Controls.Add(this.LBBirthDate);
            this.guna2GroupBox1.Controls.Add(this.LBFirstName);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.SkyBlue;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.guna2GroupBox1, "guna2GroupBox1");
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Depth = 20;
            this.guna2GroupBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.guna2GroupBox1.UseTransparentBackground = true;
            // 
            // LBGender
            // 
            this.LBGender.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBGender, "LBGender");
            this.LBGender.Name = "LBGender";
            // 
            // LBLastName
            // 
            this.LBLastName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBLastName, "LBLastName");
            this.LBLastName.Name = "LBLastName";
            // 
            // LBBirthDate
            // 
            this.LBBirthDate.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBBirthDate, "LBBirthDate");
            this.LBBirthDate.Name = "LBBirthDate";
            // 
            // LBFirstName
            // 
            this.LBFirstName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBFirstName, "LBFirstName");
            this.LBFirstName.Name = "LBFirstName";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel4, "guna2HtmlLabel4");
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel3, "guna2HtmlLabel3");
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // PBStudentImage
            // 
            this.PBStudentImage.BackColor = System.Drawing.Color.Transparent;
            this.PBStudentImage.FillColor = System.Drawing.Color.LightCyan;
            this.PBStudentImage.ImageRotate = 0F;
            resources.ApplyResources(this.PBStudentImage, "PBStudentImage");
            this.PBStudentImage.Name = "PBStudentImage";
            this.PBStudentImage.ShadowDecoration.BorderRadius = 0;
            this.PBStudentImage.ShadowDecoration.Depth = 10;
            this.PBStudentImage.ShadowDecoration.Enabled = true;
            this.PBStudentImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBStudentImage.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(6, 4, 6, 6);
            this.PBStudentImage.TabStop = false;
            this.PBStudentImage.UseTransparentBackground = true;
            // 
            // TAdd
            // 
            this.TAdd.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.TAdd, "TAdd");
            this.TAdd.Name = "TAdd";
            // 
            // TUpdate
            // 
            this.TUpdate.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.TUpdate, "TUpdate");
            this.TUpdate.Name = "TUpdate";
            // 
            // TProfessors
            // 
            this.TProfessors.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.TProfessors, "TProfessors");
            this.TProfessors.Name = "TProfessors";
            // 
            // TCourses
            // 
            this.TCourses.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.TCourses, "TCourses");
            this.TCourses.Name = "TCourses";
            // 
            // TDepartements
            // 
            this.TDepartements.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.TDepartements, "TDepartements");
            this.TDepartements.Name = "TDepartements";
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCStudents);
            this.Name = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.CMSStudentHandle.ResumeLayout(false);
            this.TCStudents.ResumeLayout(false);
            this.TStudents.ResumeLayout(false);
            this.TCStudentsOP.ResumeLayout(false);
            this.TPStudentsList.ResumeLayout(false);
            this.TAcademicInfo.ResumeLayout(false);
            this.TPersonalInfo.ResumeLayout(false);
            this.TContactInfo.ResumeLayout(false);
            this.TView.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBStudentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ILUniversitySections;
        private System.Windows.Forms.ContextMenuStrip CMSStudentHandle;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TabControl TCStudents;
        private System.Windows.Forms.TabPage TStudents;
        private System.Windows.Forms.TabPage TProfessors;
        private System.Windows.Forms.TabPage TCourses;
        private System.Windows.Forms.TabPage TDepartements;
        private Guna.UI2.WinForms.Guna2TabControl TCStudentsOP;
        private System.Windows.Forms.TabPage TPStudentsList;
        private System.Windows.Forms.ListView LVStudentsList;
        private System.Windows.Forms.TabPage TAcademicInfo;
        private System.Windows.Forms.TabPage TPersonalInfo;
        private System.Windows.Forms.TabPage TContactInfo;
        private System.Windows.Forms.TabPage TView;
        private System.Windows.Forms.TabPage TAdd;
        private System.Windows.Forms.TabPage TUpdate;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ImageList ILGenderImage;
        private System.Windows.Forms.ListView LVAcademicInfo;
        private System.Windows.Forms.ListView LVPersonalInfo;
        private System.Windows.Forms.ListView LVContactInfo;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PBStudentImage;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBBirthDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBGPA;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBYearOfStudy;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBMajor;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBStudentID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBCredits;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBAchievements;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
    }
}