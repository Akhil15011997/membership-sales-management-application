namespace Srinivas_Akhil_Assignment3_MS806
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SearchByIDButton = new System.Windows.Forms.Button();
            this.SearchByDateButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DisplayDetailsListBox = new System.Windows.Forms.ListBox();
            this.SearchByDateTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SearchByIDTextBox = new System.Windows.Forms.TextBox();
            this.PricingGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientConfirmedTextBox = new System.Windows.Forms.TextBox();
            this.QuotePanel = new System.Windows.Forms.Panel();
            this.PricePerMonthLabel = new System.Windows.Forms.Label();
            this.PriceFullTermLabel = new System.Windows.Forms.Label();
            this.PriceNextTermLabel = new System.Windows.Forms.Label();
            this.PromptLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TermTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PricingPictureBox = new System.Windows.Forms.PictureBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AvgMembershipFeesLabel = new System.Windows.Forms.Label();
            this.MembershipIDsListBox = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalMembershipFeesLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.AvgMembershipTermLabel = new System.Windows.Forms.Label();
            this.MembershipDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.JoinDayLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MembershipIDLabel = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSubmitButton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.PricingGroupBox.SuspendLayout();
            this.QuotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).BeginInit();
            this.SummaryGroupBox.SuspendLayout();
            this.MembershipDetailsGroupBox.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(198, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 34);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "S&earch";
            this.toolTip1.SetToolTip(this.SearchButton, "Press to bring up functionality to search records");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(279, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 34);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to exit application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(97, 16);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(95, 34);
            this.SummaryButton.TabIndex = 1;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Press to show summary of company sales ");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(17, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 34);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Press to clear form");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(390, 41);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 29);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.DisplayButton, "Press to display pricing details");
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(390, 300);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(94, 33);
            this.ProceedButton.TabIndex = 15;
            this.ProceedButton.Text = "&Proceed";
            this.toolTip1.SetToolTip(this.ProceedButton, "Press to proceed with processing membership");
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(155, 227);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(95, 35);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.Text = "C&onfirm";
            this.toolTip1.SetToolTip(this.ConfirmButton, "Press to enter client details");
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SearchByIDButton
            // 
            this.SearchByIDButton.Location = new System.Drawing.Point(18, 53);
            this.SearchByIDButton.Name = "SearchByIDButton";
            this.SearchByIDButton.Size = new System.Drawing.Size(195, 34);
            this.SearchByIDButton.TabIndex = 22;
            this.SearchByIDButton.Text = "Search by &ID";
            this.toolTip1.SetToolTip(this.SearchByIDButton, "Press to bring up functionality to search records");
            this.SearchByIDButton.UseVisualStyleBackColor = true;
            this.SearchByIDButton.Click += new System.EventHandler(this.SearchByIDButton_Click_1);
            // 
            // SearchByDateButton
            // 
            this.SearchByDateButton.Location = new System.Drawing.Point(18, 93);
            this.SearchByDateButton.Name = "SearchByDateButton";
            this.SearchByDateButton.Size = new System.Drawing.Size(195, 34);
            this.SearchByDateButton.TabIndex = 29;
            this.SearchByDateButton.Text = "Search by &Date";
            this.toolTip1.SetToolTip(this.SearchByDateButton, "Press to bring up functionality to search records");
            this.SearchByDateButton.UseVisualStyleBackColor = true;
            this.SearchByDateButton.Click += new System.EventHandler(this.SearchByDateButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.SearchButton);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Location = new System.Drawing.Point(536, 289);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(369, 70);
            this.ButtonPanel.TabIndex = 27;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.label14);
            this.SearchGroupBox.Controls.Add(this.SearchByDateButton);
            this.SearchGroupBox.Controls.Add(this.DisplayDetailsListBox);
            this.SearchGroupBox.Controls.Add(this.SearchByIDButton);
            this.SearchGroupBox.Controls.Add(this.SearchByDateTextBox);
            this.SearchGroupBox.Controls.Add(this.label13);
            this.SearchGroupBox.Controls.Add(this.SearchByIDTextBox);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(536, 380);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(369, 341);
            this.SearchGroupBox.TabIndex = 26;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(82, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(273, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Note :Enter Date in DD/MM/YYYY format";
            this.label14.Visible = false;
            // 
            // DisplayDetailsListBox
            // 
            this.DisplayDetailsListBox.FormattingEnabled = true;
            this.DisplayDetailsListBox.ItemHeight = 25;
            this.DisplayDetailsListBox.Location = new System.Drawing.Point(6, 171);
            this.DisplayDetailsListBox.Name = "DisplayDetailsListBox";
            this.DisplayDetailsListBox.ScrollAlwaysVisible = true;
            this.DisplayDetailsListBox.Size = new System.Drawing.Size(363, 154);
            this.DisplayDetailsListBox.TabIndex = 28;
            this.DisplayDetailsListBox.Visible = false;
            // 
            // SearchByDateTextBox
            // 
            this.SearchByDateTextBox.Location = new System.Drawing.Point(235, 93);
            this.SearchByDateTextBox.Name = "SearchByDateTextBox";
            this.SearchByDateTextBox.Size = new System.Drawing.Size(120, 30);
            this.SearchByDateTextBox.TabIndex = 20;
            this.SearchByDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(32, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 21;
            // 
            // SearchByIDTextBox
            // 
            this.SearchByIDTextBox.Location = new System.Drawing.Point(235, 53);
            this.SearchByIDTextBox.Name = "SearchByIDTextBox";
            this.SearchByIDTextBox.Size = new System.Drawing.Size(120, 30);
            this.SearchByIDTextBox.TabIndex = 18;
            this.SearchByIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PricingGroupBox
            // 
            this.PricingGroupBox.Controls.Add(this.DisplayButton);
            this.PricingGroupBox.Controls.Add(this.ProceedButton);
            this.PricingGroupBox.Controls.Add(this.label2);
            this.PricingGroupBox.Controls.Add(this.label3);
            this.PricingGroupBox.Controls.Add(this.ClientConfirmedTextBox);
            this.PricingGroupBox.Controls.Add(this.QuotePanel);
            this.PricingGroupBox.Controls.Add(this.TermTextBox);
            this.PricingGroupBox.Controls.Add(this.label8);
            this.PricingGroupBox.Controls.Add(this.PricingPictureBox);
            this.PricingGroupBox.Location = new System.Drawing.Point(22, 12);
            this.PricingGroupBox.Name = "PricingGroupBox";
            this.PricingGroupBox.Size = new System.Drawing.Size(498, 347);
            this.PricingGroupBox.TabIndex = 24;
            this.PricingGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Base Price ₹59";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Requested Term";
            // 
            // ClientConfirmedTextBox
            // 
            this.ClientConfirmedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientConfirmedTextBox.Location = new System.Drawing.Point(259, 303);
            this.ClientConfirmedTextBox.Name = "ClientConfirmedTextBox";
            this.ClientConfirmedTextBox.Size = new System.Drawing.Size(119, 30);
            this.ClientConfirmedTextBox.TabIndex = 16;
            this.ClientConfirmedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuotePanel
            // 
            this.QuotePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuotePanel.Controls.Add(this.PricePerMonthLabel);
            this.QuotePanel.Controls.Add(this.PriceFullTermLabel);
            this.QuotePanel.Controls.Add(this.PriceNextTermLabel);
            this.QuotePanel.Controls.Add(this.PromptLabel);
            this.QuotePanel.Controls.Add(this.label6);
            this.QuotePanel.Controls.Add(this.label);
            this.QuotePanel.Controls.Add(this.label4);
            this.QuotePanel.Location = new System.Drawing.Point(247, 82);
            this.QuotePanel.Name = "QuotePanel";
            this.QuotePanel.Size = new System.Drawing.Size(245, 198);
            this.QuotePanel.TabIndex = 17;
            // 
            // PricePerMonthLabel
            // 
            this.PricePerMonthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PricePerMonthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PricePerMonthLabel.Location = new System.Drawing.Point(138, 11);
            this.PricePerMonthLabel.Name = "PricePerMonthLabel";
            this.PricePerMonthLabel.Size = new System.Drawing.Size(104, 29);
            this.PricePerMonthLabel.TabIndex = 7;
            // 
            // PriceFullTermLabel
            // 
            this.PriceFullTermLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PriceFullTermLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceFullTermLabel.Location = new System.Drawing.Point(138, 54);
            this.PriceFullTermLabel.Name = "PriceFullTermLabel";
            this.PriceFullTermLabel.Size = new System.Drawing.Size(104, 29);
            this.PriceFullTermLabel.TabIndex = 9;
            // 
            // PriceNextTermLabel
            // 
            this.PriceNextTermLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PriceNextTermLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceNextTermLabel.Location = new System.Drawing.Point(138, 91);
            this.PriceNextTermLabel.Name = "PriceNextTermLabel";
            this.PriceNextTermLabel.Size = new System.Drawing.Size(104, 29);
            this.PriceNextTermLabel.TabIndex = 11;
            // 
            // PromptLabel
            // 
            this.PromptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.PromptLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.PromptLabel.Location = new System.Drawing.Point(3, 131);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(235, 61);
            this.PromptLabel.TabIndex = 12;
            this.PromptLabel.Text = "Your Sales Prompt Here";
            this.PromptLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 54);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price @ Start Next Full Term";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(1, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 20);
            this.label.TabIndex = 8;
            this.label.Text = "Price Full Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Per Month";
            // 
            // TermTextBox
            // 
            this.TermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermTextBox.Location = new System.Drawing.Point(269, 44);
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(100, 30);
            this.TermTextBox.TabIndex = 5;
            this.TermTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Confirmed Term";
            // 
            // PricingPictureBox
            // 
            this.PricingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PricingPictureBox.Image")));
            this.PricingPictureBox.Location = new System.Drawing.Point(12, 37);
            this.PricingPictureBox.Name = "PricingPictureBox";
            this.PricingPictureBox.Size = new System.Drawing.Size(212, 277);
            this.PricingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PricingPictureBox.TabIndex = 1;
            this.PricingPictureBox.TabStop = false;
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.label18);
            this.SummaryGroupBox.Controls.Add(this.AvgMembershipFeesLabel);
            this.SummaryGroupBox.Controls.Add(this.MembershipIDsListBox);
            this.SummaryGroupBox.Controls.Add(this.label17);
            this.SummaryGroupBox.Controls.Add(this.label7);
            this.SummaryGroupBox.Controls.Add(this.TotalMembershipFeesLabel);
            this.SummaryGroupBox.Controls.Add(this.label15);
            this.SummaryGroupBox.Controls.Add(this.AvgMembershipTermLabel);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(22, 380);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(498, 329);
            this.SummaryGroupBox.TabIndex = 25;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary Data";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(11, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(278, 25);
            this.label18.TabIndex = 28;
            this.label18.Text = "Average Membership Fees:";
            // 
            // AvgMembershipFeesLabel
            // 
            this.AvgMembershipFeesLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.AvgMembershipFeesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgMembershipFeesLabel.Location = new System.Drawing.Point(329, 117);
            this.AvgMembershipFeesLabel.Name = "AvgMembershipFeesLabel";
            this.AvgMembershipFeesLabel.Size = new System.Drawing.Size(120, 26);
            this.AvgMembershipFeesLabel.TabIndex = 29;
            // 
            // MembershipIDsListBox
            // 
            this.MembershipIDsListBox.FormattingEnabled = true;
            this.MembershipIDsListBox.ItemHeight = 25;
            this.MembershipIDsListBox.Location = new System.Drawing.Point(318, 162);
            this.MembershipIDsListBox.Name = "MembershipIDsListBox";
            this.MembershipIDsListBox.ScrollAlwaysVisible = true;
            this.MembershipIDsListBox.Size = new System.Drawing.Size(166, 154);
            this.MembershipIDsListBox.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(11, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(280, 25);
            this.label17.TabIndex = 26;
            this.label17.Text = "Average Membership Term:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(11, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total Membership Fees:";
            // 
            // TotalMembershipFeesLabel
            // 
            this.TotalMembershipFeesLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.TotalMembershipFeesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalMembershipFeesLabel.Location = new System.Drawing.Point(329, 77);
            this.TotalMembershipFeesLabel.Name = "TotalMembershipFeesLabel";
            this.TotalMembershipFeesLabel.Size = new System.Drawing.Size(120, 22);
            this.TotalMembershipFeesLabel.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(11, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Membership IDs";
            // 
            // AvgMembershipTermLabel
            // 
            this.AvgMembershipTermLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.AvgMembershipTermLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgMembershipTermLabel.Location = new System.Drawing.Point(329, 43);
            this.AvgMembershipTermLabel.Name = "AvgMembershipTermLabel";
            this.AvgMembershipTermLabel.Size = new System.Drawing.Size(120, 22);
            this.AvgMembershipTermLabel.TabIndex = 23;
            // 
            // MembershipDetailsGroupBox
            // 
            this.MembershipDetailsGroupBox.Controls.Add(this.ConfirmButton);
            this.MembershipDetailsGroupBox.Controls.Add(this.label12);
            this.MembershipDetailsGroupBox.Controls.Add(this.JoinDayLabel);
            this.MembershipDetailsGroupBox.Controls.Add(this.EmailTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label11);
            this.MembershipDetailsGroupBox.Controls.Add(this.TelephoneTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label9);
            this.MembershipDetailsGroupBox.Controls.Add(this.FullNameTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label5);
            this.MembershipDetailsGroupBox.Controls.Add(this.label10);
            this.MembershipDetailsGroupBox.Controls.Add(this.MembershipIDLabel);
            this.MembershipDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipDetailsGroupBox.Location = new System.Drawing.Point(536, 12);
            this.MembershipDetailsGroupBox.Name = "MembershipDetailsGroupBox";
            this.MembershipDetailsGroupBox.Size = new System.Drawing.Size(369, 271);
            this.MembershipDetailsGroupBox.TabIndex = 23;
            this.MembershipDetailsGroupBox.TabStop = false;
            this.MembershipDetailsGroupBox.Text = "Member Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(47, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Joining Date";
            // 
            // JoinDayLabel
            // 
            this.JoinDayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.JoinDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoinDayLabel.Location = new System.Drawing.Point(219, 70);
            this.JoinDayLabel.Name = "JoinDayLabel";
            this.JoinDayLabel.Size = new System.Drawing.Size(120, 22);
            this.JoinDayLabel.TabIndex = 21;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(219, 187);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(121, 26);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(47, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email Address";
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(219, 145);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(120, 26);
            this.TelephoneTextBox.TabIndex = 16;
            this.TelephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telephone Number";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(219, 107);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(120, 26);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(47, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(47, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Membership ID";
            // 
            // MembershipIDLabel
            // 
            this.MembershipIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MembershipIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MembershipIDLabel.Location = new System.Drawing.Point(219, 35);
            this.MembershipIDLabel.Name = "MembershipIDLabel";
            this.MembershipIDLabel.Size = new System.Drawing.Size(120, 22);
            this.MembershipIDLabel.TabIndex = 14;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.label1);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Controls.Add(this.PasswordSubmitButton);
            this.PasswordPanel.Location = new System.Drawing.Point(176, 43);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(541, 70);
            this.PasswordPanel.TabIndex = 22;
            this.PasswordPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Your Password ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 24);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(123, 26);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordSubmitButton
            // 
            this.PasswordSubmitButton.Location = new System.Drawing.Point(411, 22);
            this.PasswordSubmitButton.Name = "PasswordSubmitButton";
            this.PasswordSubmitButton.Size = new System.Drawing.Size(75, 33);
            this.PasswordSubmitButton.TabIndex = 0;
            this.PasswordSubmitButton.Text = "&Submit";
            this.PasswordSubmitButton.UseVisualStyleBackColor = true;
            this.PasswordSubmitButton.Click += new System.EventHandler(this.PasswordSubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 721);
            this.Controls.Add(this.MembershipDetailsGroupBox);
            this.Controls.Add(this.PricingGroupBox);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Halo Fitness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.PricingGroupBox.ResumeLayout(false);
            this.PricingGroupBox.PerformLayout();
            this.QuotePanel.ResumeLayout(false);
            this.QuotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).EndInit();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.MembershipDetailsGroupBox.ResumeLayout(false);
            this.MembershipDetailsGroupBox.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox PricingGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientConfirmedTextBox;
        private System.Windows.Forms.Panel QuotePanel;
        private System.Windows.Forms.Label PricePerMonthLabel;
        private System.Windows.Forms.Label PriceFullTermLabel;
        private System.Windows.Forms.Label PriceNextTermLabel;
        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TermTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PricingPictureBox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.GroupBox MembershipDetailsGroupBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label JoinDayLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MembershipIDLabel;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button PasswordSubmitButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label AvgMembershipFeesLabel;
        private System.Windows.Forms.ListBox MembershipIDsListBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalMembershipFeesLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label AvgMembershipTermLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SearchByDateButton;
        private System.Windows.Forms.ListBox DisplayDetailsListBox;
        private System.Windows.Forms.Button SearchByIDButton;
        private System.Windows.Forms.TextBox SearchByDateTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SearchByIDTextBox;
    }
}

