namespace censorapp
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
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.ComboBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.worksector = new System.Windows.Forms.ComboBox();
            this.employmentstatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.officeaddress = new System.Windows.Forms.TextBox();
            this.stateoforigin = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.maritalstatus = new System.Windows.Forms.ComboBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST NAME";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(162, 22);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(237, 20);
            this.fname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MIDDLE NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "LAST NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SEX";
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(162, 65);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(237, 20);
            this.mname.TabIndex = 6;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(162, 106);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(237, 20);
            this.lname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "MARITAL STATUS";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(159, 225);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(172, 20);
            this.dob.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "DOB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "STATE OF ORIGIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "NATIONALITY";
            // 
            // nationality
            // 
            this.nationality.FormattingEnabled = true;
            this.nationality.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Republic of the",
            "Congo, Democratic Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "St. Kitts and Nevis",
            "St. Lucia",
            "St. Vincent and The Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom (UK)",
            "United States of America (USA)",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City (Holy See)",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.nationality.Location = new System.Drawing.Point(159, 382);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(121, 21);
            this.nationality.TabIndex = 20;
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.sex.Location = new System.Drawing.Point(162, 150);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(81, 21);
            this.sex.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "EMPLOYMENT STATUS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "OFFICE ADDRESS";
            // 
            // worksector
            // 
            this.worksector.FormattingEnabled = true;
            this.worksector.Items.AddRange(new object[] {
            "GOVERNMENT",
            "NON-GOVERNMENTAL",
            "PRIVATE",
            "OTHERS"});
            this.worksector.Location = new System.Drawing.Point(159, 463);
            this.worksector.Name = "worksector";
            this.worksector.Size = new System.Drawing.Size(121, 21);
            this.worksector.TabIndex = 25;
            // 
            // employmentstatus
            // 
            this.employmentstatus.FormattingEnabled = true;
            this.employmentstatus.Items.AddRange(new object[] {
            "employed",
            "unemployed"});
            this.employmentstatus.Location = new System.Drawing.Point(156, 421);
            this.employmentstatus.Name = "employmentstatus";
            this.employmentstatus.Size = new System.Drawing.Size(121, 21);
            this.employmentstatus.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "WORK SECTOR";
            // 
            // officeaddress
            // 
            this.officeaddress.Location = new System.Drawing.Point(159, 509);
            this.officeaddress.Name = "officeaddress";
            this.officeaddress.Size = new System.Drawing.Size(310, 20);
            this.officeaddress.TabIndex = 28;
            // 
            // stateoforigin
            // 
            this.stateoforigin.FormattingEnabled = true;
            this.stateoforigin.Items.AddRange(new object[] {
            "Abia",
            "Adamawa",
            "Anambra",
            "Akwa Ibom",
            "Bauchi",
            "Bayelsa",
            "Benue",
            "Borno",
            "Cross River",
            "Delta",
            "Ebonyi",
            "Enugu",
            "Edo",
            "Ekiti",
            "Gombe",
            "Imo",
            "Jigawa",
            "Kaduna",
            "Kano",
            "Katsina",
            "Kebbi",
            "Kogi",
            "Kwara",
            "Lagos",
            "Nasarawa",
            "Niger",
            "Ogun",
            "Ondo",
            "Osun",
            "Oyo",
            "Plateau",
            "Rivers",
            "Sokoto",
            "Taraba",
            "Yobe",
            "Zamfara"});
            this.stateoforigin.Location = new System.Drawing.Point(159, 341);
            this.stateoforigin.Name = "stateoforigin";
            this.stateoforigin.Size = new System.Drawing.Size(121, 21);
            this.stateoforigin.TabIndex = 29;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(168, 549);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 43);
            this.submit.TabIndex = 30;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "PHONE NUMBER";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "EMAIL";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(159, 265);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(290, 20);
            this.email.TabIndex = 33;
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(159, 301);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(149, 20);
            this.phonenumber.TabIndex = 34;
            // 
            // maritalstatus
            // 
            this.maritalstatus.FormattingEnabled = true;
            this.maritalstatus.Items.AddRange(new object[] {
            "single",
            "married",
            "divorced"});
            this.maritalstatus.Location = new System.Drawing.Point(156, 185);
            this.maritalstatus.Name = "maritalstatus";
            this.maritalstatus.Size = new System.Drawing.Size(81, 21);
            this.maritalstatus.TabIndex = 35;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(279, 549);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(120, 43);
            this.btnnext.TabIndex = 36;
            this.btnnext.Text = "NEXT FORM";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 604);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.maritalstatus);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.stateoforigin);
            this.Controls.Add(this.officeaddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.employmentstatus);
            this.Controls.Add(this.worksector);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox nationality;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox worksector;
        private System.Windows.Forms.ComboBox employmentstatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox officeaddress;
        private System.Windows.Forms.ComboBox stateoforigin;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.ComboBox maritalstatus;
        private System.Windows.Forms.Button btnnext;
    }
}

