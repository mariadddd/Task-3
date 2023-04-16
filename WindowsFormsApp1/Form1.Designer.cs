namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.Family = new System.Windows.Forms.GroupBox();
            this.liveWithCats = new System.Windows.Forms.RadioButton();
            this.notMarried = new System.Windows.Forms.RadioButton();
            this.married = new System.Windows.Forms.RadioButton();
            this.Info = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.Gender.SuspendLayout();
            this.Family.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelDateOfBirth);
            this.panel1.Controls.Add(this.DateOfBirth);
            this.panel1.Controls.Add(this.labelSecondName);
            this.panel1.Controls.Add(this.SecondName);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.Surname);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.Name);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labelDateOfBirth
            // 
            resources.ApplyResources(this.labelDateOfBirth, "labelDateOfBirth");
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            // 
            // DateOfBirth
            // 
            resources.ApplyResources(this.DateOfBirth, "DateOfBirth");
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // labelSecondName
            // 
            resources.ApplyResources(this.labelSecondName, "labelSecondName");
            this.labelSecondName.Name = "labelSecondName";
            // 
            // SecondName
            // 
            resources.ApplyResources(this.SecondName, "SecondName");
            this.SecondName.Name = "SecondName";
            // 
            // labelSurname
            // 
            resources.ApplyResources(this.labelSurname, "labelSurname");
            this.labelSurname.Name = "labelSurname";
            // 
            // Surname
            // 
            resources.ApplyResources(this.Surname, "Surname");
            this.Surname.Name = "Surname";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // Name
            // 
            resources.ApplyResources(this.Name, "Name");
            this.Name.Name = "Name";
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.female);
            this.Gender.Controls.Add(this.male);
            resources.ApplyResources(this.Gender, "Gender");
            this.Gender.Name = "Gender";
            this.Gender.TabStop = false;
            // 
            // female
            // 
            resources.ApplyResources(this.female, "female");
            this.female.Name = "female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            resources.ApplyResources(this.male, "male");
            this.male.Checked = true;
            this.male.Name = "male";
            this.male.TabStop = true;
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // Family
            // 
            this.Family.BackColor = System.Drawing.Color.White;
            this.Family.Controls.Add(this.liveWithCats);
            this.Family.Controls.Add(this.notMarried);
            this.Family.Controls.Add(this.married);
            resources.ApplyResources(this.Family, "Family");
            this.Family.Name = "Family";
            this.Family.TabStop = false;
            // 
            // liveWithCats
            // 
            resources.ApplyResources(this.liveWithCats, "liveWithCats");
            this.liveWithCats.Checked = true;
            this.liveWithCats.Name = "liveWithCats";
            this.liveWithCats.TabStop = true;
            this.liveWithCats.UseVisualStyleBackColor = true;
            this.liveWithCats.CheckedChanged += new System.EventHandler(this.liveWithCats_CheckedChanged);
            // 
            // notMarried
            // 
            resources.ApplyResources(this.notMarried, "notMarried");
            this.notMarried.Name = "notMarried";
            this.notMarried.UseVisualStyleBackColor = true;
            this.notMarried.CheckedChanged += new System.EventHandler(this.notMarried_CheckedChanged);
            // 
            // married
            // 
            resources.ApplyResources(this.married, "married");
            this.married.Name = "married";
            this.married.UseVisualStyleBackColor = true;
            this.married.CheckedChanged += new System.EventHandler(this.married_CheckedChanged);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Name = "Info";
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.labelInfo.Name = "labelInfo";
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Save);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.panel1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.Family.ResumeLayout(false);
            this.Family.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.MaskedTextBox DateOfBirth;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.GroupBox Family;
        private System.Windows.Forms.RadioButton liveWithCats;
        private System.Windows.Forms.RadioButton notMarried;
        private System.Windows.Forms.RadioButton married;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

