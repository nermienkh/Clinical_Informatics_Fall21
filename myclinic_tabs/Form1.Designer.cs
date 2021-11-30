
namespace myclinic_tabs
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowDoctors = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_patientID = new System.Windows.Forms.TextBox();
            this.txt_patientPhone = new System.Windows.Forms.TextBox();
            this.txt_patientNationalID = new System.Windows.Forms.TextBox();
            this.txt_patientLName = new System.Windows.Forms.TextBox();
            this.txt_patientFName = new System.Windows.Forms.TextBox();
            this.btn_addPatient = new System.Windows.Forms.Button();
            this.dateTimePicker_PatientDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDrugStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_drugCode = new System.Windows.Forms.TextBox();
            this.comboBox_listDrugs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Location = new System.Drawing.Point(27, 17);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(747, 416);
            this.tabMain.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowDoctors);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doctor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowDoctors
            // 
            this.btnShowDoctors.Location = new System.Drawing.Point(281, 9);
            this.btnShowDoctors.Name = "btnShowDoctors";
            this.btnShowDoctors.Size = new System.Drawing.Size(143, 23);
            this.btnShowDoctors.TabIndex = 1;
            this.btnShowDoctors.Text = "Show Doctors";
            this.btnShowDoctors.UseVisualStyleBackColor = true;
            this.btnShowDoctors.Click += new System.EventHandler(this.btnShowDoctors_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_patientID);
            this.tabPage1.Controls.Add(this.txt_patientPhone);
            this.tabPage1.Controls.Add(this.txt_patientNationalID);
            this.tabPage1.Controls.Add(this.txt_patientLName);
            this.tabPage1.Controls.Add(this.txt_patientFName);
            this.tabPage1.Controls.Add(this.btn_addPatient);
            this.tabPage1.Controls.Add(this.dateTimePicker_PatientDOB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // txt_patientID
            // 
            this.txt_patientID.Location = new System.Drawing.Point(121, 10);
            this.txt_patientID.Name = "txt_patientID";
            this.txt_patientID.Size = new System.Drawing.Size(216, 20);
            this.txt_patientID.TabIndex = 12;
            // 
            // txt_patientPhone
            // 
            this.txt_patientPhone.Location = new System.Drawing.Point(121, 137);
            this.txt_patientPhone.Name = "txt_patientPhone";
            this.txt_patientPhone.Size = new System.Drawing.Size(216, 20);
            this.txt_patientPhone.TabIndex = 7;
            // 
            // txt_patientNationalID
            // 
            this.txt_patientNationalID.Location = new System.Drawing.Point(121, 107);
            this.txt_patientNationalID.Name = "txt_patientNationalID";
            this.txt_patientNationalID.Size = new System.Drawing.Size(216, 20);
            this.txt_patientNationalID.TabIndex = 6;
            // 
            // txt_patientLName
            // 
            this.txt_patientLName.Location = new System.Drawing.Point(121, 73);
            this.txt_patientLName.Name = "txt_patientLName";
            this.txt_patientLName.Size = new System.Drawing.Size(216, 20);
            this.txt_patientLName.TabIndex = 5;
            // 
            // txt_patientFName
            // 
            this.txt_patientFName.Location = new System.Drawing.Point(121, 36);
            this.txt_patientFName.Name = "txt_patientFName";
            this.txt_patientFName.Size = new System.Drawing.Size(216, 20);
            this.txt_patientFName.TabIndex = 4;
            // 
            // btn_addPatient
            // 
            this.btn_addPatient.Location = new System.Drawing.Point(48, 262);
            this.btn_addPatient.Name = "btn_addPatient";
            this.btn_addPatient.Size = new System.Drawing.Size(143, 23);
            this.btn_addPatient.TabIndex = 11;
            this.btn_addPatient.Text = "Add Patient";
            this.btn_addPatient.UseVisualStyleBackColor = true;
            this.btn_addPatient.Click += new System.EventHandler(this.btn_addPatient_Click);
            // 
            // dateTimePicker_PatientDOB
            // 
            this.dateTimePicker_PatientDOB.Location = new System.Drawing.Point(121, 176);
            this.dateTimePicker_PatientDOB.Name = "dateTimePicker_PatientDOB";
            this.dateTimePicker_PatientDOB.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker_PatientDOB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.lblDrugStatus);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox_drugCode);
            this.tabPage3.Controls.Add(this.comboBox_listDrugs);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(739, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drug";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "find drug by code ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFindDrugByCode_Click);
            // 
            // lblDrugStatus
            // 
            this.lblDrugStatus.AutoSize = true;
            this.lblDrugStatus.Location = new System.Drawing.Point(329, 179);
            this.lblDrugStatus.Name = "lblDrugStatus";
            this.lblDrugStatus.Size = new System.Drawing.Size(59, 13);
            this.lblDrugStatus.TabIndex = 4;
            this.lblDrugStatus.Text = "drug status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(245, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "drug status";
            // 
            // textBox_drugCode
            // 
            this.textBox_drugCode.Location = new System.Drawing.Point(139, 176);
            this.textBox_drugCode.Name = "textBox_drugCode";
            this.textBox_drugCode.Size = new System.Drawing.Size(100, 20);
            this.textBox_drugCode.TabIndex = 1;
            // 
            // comboBox_listDrugs
            // 
            this.comboBox_listDrugs.FormattingEnabled = true;
            this.comboBox_listDrugs.Location = new System.Drawing.Point(122, 60);
            this.comboBox_listDrugs.Name = "comboBox_listDrugs";
            this.comboBox_listDrugs.Size = new System.Drawing.Size(121, 21);
            this.comboBox_listDrugs.TabIndex = 0;
            this.comboBox_listDrugs.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "List of Drug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowDoctors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_patientID;
        private System.Windows.Forms.TextBox txt_patientPhone;
        private System.Windows.Forms.TextBox txt_patientNationalID;
        private System.Windows.Forms.TextBox txt_patientLName;
        private System.Windows.Forms.TextBox txt_patientFName;
        private System.Windows.Forms.Button btn_addPatient;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PatientDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox_listDrugs;
        private System.Windows.Forms.TextBox textBox_drugCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDrugStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}