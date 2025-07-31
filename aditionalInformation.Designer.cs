namespace Library_Managment
{
    partial class aditionalInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aditionalInformation));
            lblContinueAs = new Label();
            rBtnProfessor = new RadioButton();
            rBtnStudent = new RadioButton();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblMajor = new Label();
            cmbxMajor = new ComboBox();
            lblDateOfBirth = new Label();
            cmbxYear = new ComboBox();
            cmbxMonth = new ComboBox();
            cmbxDay = new ComboBox();
            cmbxTermsOfUse = new CheckBox();
            lblSpecialization = new Label();
            cmbxSpecialzation = new ComboBox();
            mbtnSignUp = new MaterialSkin.Controls.MaterialButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblContinueAs
            // 
            resources.ApplyResources(lblContinueAs, "lblContinueAs");
            lblContinueAs.Name = "lblContinueAs";
            // 
            // rBtnProfessor
            // 
            resources.ApplyResources(rBtnProfessor, "rBtnProfessor");
            rBtnProfessor.Name = "rBtnProfessor";
            rBtnProfessor.TabStop = true;
            rBtnProfessor.UseVisualStyleBackColor = true;
            rBtnProfessor.CheckedChanged += rBtnProfessor_CheckedChanged;
            // 
            // rBtnStudent
            // 
            resources.ApplyResources(rBtnStudent, "rBtnStudent");
            rBtnStudent.Name = "rBtnStudent";
            rBtnStudent.TabStop = true;
            rBtnStudent.UseVisualStyleBackColor = true;
            rBtnStudent.CheckedChanged += rBtnStudent_CheckedChanged;
            // 
            // lblFullName
            // 
            resources.ApplyResources(lblFullName, "lblFullName");
            lblFullName.Name = "lblFullName";
            // 
            // txtFullName
            // 
            resources.ApplyResources(txtFullName, "txtFullName");
            txtFullName.Name = "txtFullName";
            txtFullName.KeyPress += txtFullName_KeyPress;
            // 
            // lblMajor
            // 
            resources.ApplyResources(lblMajor, "lblMajor");
            lblMajor.Name = "lblMajor";
            // 
            // cmbxMajor
            // 
            resources.ApplyResources(cmbxMajor, "cmbxMajor");
            cmbxMajor.FormattingEnabled = true;
            cmbxMajor.Items.AddRange(new object[] { resources.GetString("cmbxMajor.Items"), resources.GetString("cmbxMajor.Items1"), resources.GetString("cmbxMajor.Items2"), resources.GetString("cmbxMajor.Items3"), resources.GetString("cmbxMajor.Items4"), resources.GetString("cmbxMajor.Items5") });
            cmbxMajor.Name = "cmbxMajor";
            cmbxMajor.SelectedIndexChanged += cmbxMajor_SelectedIndexChanged;
            // 
            // lblDateOfBirth
            // 
            resources.ApplyResources(lblDateOfBirth, "lblDateOfBirth");
            lblDateOfBirth.Name = "lblDateOfBirth";
            // 
            // cmbxYear
            // 
            resources.ApplyResources(cmbxYear, "cmbxYear");
            cmbxYear.FormattingEnabled = true;
            cmbxYear.Items.AddRange(new object[] { resources.GetString("cmbxYear.Items"), resources.GetString("cmbxYear.Items1"), resources.GetString("cmbxYear.Items2"), resources.GetString("cmbxYear.Items3"), resources.GetString("cmbxYear.Items4"), resources.GetString("cmbxYear.Items5"), resources.GetString("cmbxYear.Items6"), resources.GetString("cmbxYear.Items7"), resources.GetString("cmbxYear.Items8"), resources.GetString("cmbxYear.Items9"), resources.GetString("cmbxYear.Items10"), resources.GetString("cmbxYear.Items11"), resources.GetString("cmbxYear.Items12"), resources.GetString("cmbxYear.Items13"), resources.GetString("cmbxYear.Items14"), resources.GetString("cmbxYear.Items15"), resources.GetString("cmbxYear.Items16"), resources.GetString("cmbxYear.Items17"), resources.GetString("cmbxYear.Items18"), resources.GetString("cmbxYear.Items19"), resources.GetString("cmbxYear.Items20"), resources.GetString("cmbxYear.Items21"), resources.GetString("cmbxYear.Items22"), resources.GetString("cmbxYear.Items23"), resources.GetString("cmbxYear.Items24"), resources.GetString("cmbxYear.Items25"), resources.GetString("cmbxYear.Items26"), resources.GetString("cmbxYear.Items27"), resources.GetString("cmbxYear.Items28"), resources.GetString("cmbxYear.Items29"), resources.GetString("cmbxYear.Items30"), resources.GetString("cmbxYear.Items31"), resources.GetString("cmbxYear.Items32"), resources.GetString("cmbxYear.Items33"), resources.GetString("cmbxYear.Items34"), resources.GetString("cmbxYear.Items35"), resources.GetString("cmbxYear.Items36"), resources.GetString("cmbxYear.Items37"), resources.GetString("cmbxYear.Items38"), resources.GetString("cmbxYear.Items39"), resources.GetString("cmbxYear.Items40"), resources.GetString("cmbxYear.Items41"), resources.GetString("cmbxYear.Items42"), resources.GetString("cmbxYear.Items43"), resources.GetString("cmbxYear.Items44"), resources.GetString("cmbxYear.Items45"), resources.GetString("cmbxYear.Items46"), resources.GetString("cmbxYear.Items47"), resources.GetString("cmbxYear.Items48"), resources.GetString("cmbxYear.Items49"), resources.GetString("cmbxYear.Items50"), resources.GetString("cmbxYear.Items51"), resources.GetString("cmbxYear.Items52"), resources.GetString("cmbxYear.Items53"), resources.GetString("cmbxYear.Items54"), resources.GetString("cmbxYear.Items55"), resources.GetString("cmbxYear.Items56"), resources.GetString("cmbxYear.Items57"), resources.GetString("cmbxYear.Items58"), resources.GetString("cmbxYear.Items59"), resources.GetString("cmbxYear.Items60"), resources.GetString("cmbxYear.Items61"), resources.GetString("cmbxYear.Items62"), resources.GetString("cmbxYear.Items63"), resources.GetString("cmbxYear.Items64"), resources.GetString("cmbxYear.Items65"), resources.GetString("cmbxYear.Items66"), resources.GetString("cmbxYear.Items67"), resources.GetString("cmbxYear.Items68"), resources.GetString("cmbxYear.Items69"), resources.GetString("cmbxYear.Items70"), resources.GetString("cmbxYear.Items71"), resources.GetString("cmbxYear.Items72"), resources.GetString("cmbxYear.Items73"), resources.GetString("cmbxYear.Items74"), resources.GetString("cmbxYear.Items75"), resources.GetString("cmbxYear.Items76"), resources.GetString("cmbxYear.Items77"), resources.GetString("cmbxYear.Items78"), resources.GetString("cmbxYear.Items79"), resources.GetString("cmbxYear.Items80"), resources.GetString("cmbxYear.Items81"), resources.GetString("cmbxYear.Items82"), resources.GetString("cmbxYear.Items83"), resources.GetString("cmbxYear.Items84"), resources.GetString("cmbxYear.Items85"), resources.GetString("cmbxYear.Items86"), resources.GetString("cmbxYear.Items87"), resources.GetString("cmbxYear.Items88"), resources.GetString("cmbxYear.Items89"), resources.GetString("cmbxYear.Items90"), resources.GetString("cmbxYear.Items91"), resources.GetString("cmbxYear.Items92"), resources.GetString("cmbxYear.Items93"), resources.GetString("cmbxYear.Items94"), resources.GetString("cmbxYear.Items95"), resources.GetString("cmbxYear.Items96"), resources.GetString("cmbxYear.Items97"), resources.GetString("cmbxYear.Items98"), resources.GetString("cmbxYear.Items99"), resources.GetString("cmbxYear.Items100") });
            cmbxYear.Name = "cmbxYear";
            cmbxYear.KeyPress += cmbxYear_KeyPress;
            // 
            // cmbxMonth
            // 
            resources.ApplyResources(cmbxMonth, "cmbxMonth");
            cmbxMonth.FormattingEnabled = true;
            cmbxMonth.Items.AddRange(new object[] { resources.GetString("cmbxMonth.Items"), resources.GetString("cmbxMonth.Items1"), resources.GetString("cmbxMonth.Items2"), resources.GetString("cmbxMonth.Items3"), resources.GetString("cmbxMonth.Items4"), resources.GetString("cmbxMonth.Items5"), resources.GetString("cmbxMonth.Items6"), resources.GetString("cmbxMonth.Items7"), resources.GetString("cmbxMonth.Items8"), resources.GetString("cmbxMonth.Items9"), resources.GetString("cmbxMonth.Items10"), resources.GetString("cmbxMonth.Items11") });
            cmbxMonth.Name = "cmbxMonth";
            cmbxMonth.SelectedIndexChanged += cmbxMonth_SelectedIndexChanged;
            cmbxMonth.KeyPress += cmbxMonth_KeyPress;
            // 
            // cmbxDay
            // 
            resources.ApplyResources(cmbxDay, "cmbxDay");
            cmbxDay.FormattingEnabled = true;
            cmbxDay.Items.AddRange(new object[] { resources.GetString("cmbxDay.Items"), resources.GetString("cmbxDay.Items1"), resources.GetString("cmbxDay.Items2"), resources.GetString("cmbxDay.Items3"), resources.GetString("cmbxDay.Items4"), resources.GetString("cmbxDay.Items5"), resources.GetString("cmbxDay.Items6"), resources.GetString("cmbxDay.Items7"), resources.GetString("cmbxDay.Items8"), resources.GetString("cmbxDay.Items9"), resources.GetString("cmbxDay.Items10"), resources.GetString("cmbxDay.Items11"), resources.GetString("cmbxDay.Items12"), resources.GetString("cmbxDay.Items13"), resources.GetString("cmbxDay.Items14"), resources.GetString("cmbxDay.Items15"), resources.GetString("cmbxDay.Items16"), resources.GetString("cmbxDay.Items17"), resources.GetString("cmbxDay.Items18"), resources.GetString("cmbxDay.Items19"), resources.GetString("cmbxDay.Items20"), resources.GetString("cmbxDay.Items21"), resources.GetString("cmbxDay.Items22"), resources.GetString("cmbxDay.Items23"), resources.GetString("cmbxDay.Items24"), resources.GetString("cmbxDay.Items25"), resources.GetString("cmbxDay.Items26"), resources.GetString("cmbxDay.Items27"), resources.GetString("cmbxDay.Items28"), resources.GetString("cmbxDay.Items29"), resources.GetString("cmbxDay.Items30") });
            cmbxDay.Name = "cmbxDay";
            cmbxDay.KeyPress += cmbxDay_KeyPress;
            // 
            // cmbxTermsOfUse
            // 
            resources.ApplyResources(cmbxTermsOfUse, "cmbxTermsOfUse");
            cmbxTermsOfUse.Name = "cmbxTermsOfUse";
            cmbxTermsOfUse.UseVisualStyleBackColor = true;
            cmbxTermsOfUse.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblSpecialization
            // 
            resources.ApplyResources(lblSpecialization, "lblSpecialization");
            lblSpecialization.Name = "lblSpecialization";
            // 
            // cmbxSpecialzation
            // 
            resources.ApplyResources(cmbxSpecialzation, "cmbxSpecialzation");
            cmbxSpecialzation.FormattingEnabled = true;
            cmbxSpecialzation.Name = "cmbxSpecialzation";
            cmbxSpecialzation.SelectedIndexChanged += cmbxSpecialzation_SelectedIndexChanged;
            // 
            // mbtnSignUp
            // 
            resources.ApplyResources(mbtnSignUp, "mbtnSignUp");
            mbtnSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnSignUp.Depth = 0;
            mbtnSignUp.HighEmphasis = true;
            mbtnSignUp.Icon = null;
            mbtnSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnSignUp.Name = "mbtnSignUp";
            mbtnSignUp.NoAccentTextColor = Color.Empty;
            mbtnSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnSignUp.UseAccentColor = false;
            mbtnSignUp.UseVisualStyleBackColor = true;
            mbtnSignUp.Click += mbtnSignUp_Click;
            // 
            // aditionalInformation
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mbtnSignUp);
            Controls.Add(cmbxSpecialzation);
            Controls.Add(lblSpecialization);
            Controls.Add(cmbxTermsOfUse);
            Controls.Add(cmbxDay);
            Controls.Add(cmbxMonth);
            Controls.Add(cmbxYear);
            Controls.Add(lblDateOfBirth);
            Controls.Add(cmbxMajor);
            Controls.Add(lblMajor);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(rBtnStudent);
            Controls.Add(rBtnProfessor);
            Controls.Add(lblContinueAs);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "aditionalInformation";
            Sizable = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label lblContinueAs;
        internal RadioButton rBtnProfessor;
        internal RadioButton rBtnStudent;
        internal Label lblFullName;
        internal TextBox txtFullName;
        internal Label lblMajor;
        internal ComboBox cmbxMajor;
        internal Label lblDateOfBirth;
        internal ComboBox cmbxYear;
        internal ComboBox cmbxMonth;
        internal ComboBox cmbxDay;
        internal CheckBox cmbxTermsOfUse;
        internal Label lblSpecialization;
        internal ComboBox cmbxSpecialzation;
        internal MaterialSkin.Controls.MaterialButton mbtnSignUp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}