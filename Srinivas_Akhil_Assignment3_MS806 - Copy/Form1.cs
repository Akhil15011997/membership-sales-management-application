using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Srinivas_Akhil_Assignment3_MS806
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int INCREMENT = 2, FORMWIDTH = 954, FORMSTARTHEIGHT = 380, FORMEXPANDHEIGHT = 620;


        private void Form1_Load(object sender, EventArgs e)
        {
            MembershipDetailsGroupBox.Visible = false;
            PricingGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
            ButtonPanel.Visible = false;
            PasswordPanel.Visible = true;
            this.Size = new Size(FORMWIDTH, FORMSTARTHEIGHT);
        }

        int passwordcount = 1, attempt = 3;
        private void PasswordSubmitButton_Click(object sender, EventArgs e)
        {
            string Password = "s";
            do
            {
                if (PasswordTextBox.Text != Password & passwordcount < 3)
                {
                    attempt--;
                    MessageBox.Show("Invalid Password\nNumber of attempts left: " + attempt, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordTextBox.Clear();
                    passwordcount += 1;
                }
                else if (PasswordTextBox.Text != Password & passwordcount == 3)
                {
                    MessageBox.Show("Maximum attempts Reached\nClosing the Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
                }
                else if (PasswordTextBox.Text == Password & passwordcount <= 3)
                {
                    PasswordPanel.Visible = false;
                    PricingGroupBox.Visible = true;
                    ButtonPanel.Visible = true;
                    break;
                }
            } while (passwordcount >= 4);
        }


        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                int enteredmonth = int.Parse(TermTextBox.Text);
                if (enteredmonth > 0)
                {
                    PriceCalculationforTerm(enteredmonth);
                    if (enteredmonth < 61)
                    {
                        decimal salespromptvalue = priceNextTerm - priceFullTerm;
                        salespromptvalue = Math.Abs(salespromptvalue);
                        PromptLabel.Visible = true;
                        PromptLabel.Text = "Workout more by choosing the next term and save more than " + salespromptvalue.ToString("C2");
                        PricePerMonthLabel.Text = priceperMonth.ToString("C2");
                        PriceFullTermLabel.Text = priceFullTerm.ToString("C2");
                        PriceNextTermLabel.Text = priceNextTerm.ToString("C2");
                    }
                    else
                    {
                        PricePerMonthLabel.Text = priceperMonth.ToString("C2");
                        PriceFullTermLabel.Text = priceFullTerm.ToString("C2");
                        PriceNextTermLabel.Text = "";
                        PromptLabel.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Enter valid month in digits", "Invalid", MessageBoxButtons.OK);
                    TermTextBox.Clear();
                    TermTextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Enter valid month in digits", "Invalid", MessageBoxButtons.OK);
                TermTextBox.Clear();
                TermTextBox.Focus();
            }
        }
        const decimal defaultprice = 59;
        const decimal discount1 = 0m, discount2 = 0.10m, discount3 = 0.20m, discount4 = 0.25m, discount5 = 0.33m, discount6 = 0.40m, discount7 = 0.66m;
        decimal priceperMonth, priceFullTerm, priceNextTerm;
        private void PriceCalculationforTerm(int month)
        {
            if (month < 3)
            {
                priceperMonth = (defaultprice - (defaultprice * discount1));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = (defaultprice - (defaultprice * discount2)) * 3;
            }
            else if (month < 7)
            {
                priceperMonth = (defaultprice - (defaultprice * discount2));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = (defaultprice - (defaultprice * discount3)) * 7;
            }
            else if (month < 13)
            {
                priceperMonth = (defaultprice - (defaultprice * discount3));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = (defaultprice - (defaultprice * discount4)) * 13;
            }
            else if (month < 19)
            {
                priceperMonth = (defaultprice - (defaultprice * discount4));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = (defaultprice - (defaultprice * discount5)) * 19;
            }
            else if (month < 25)
            {
                priceperMonth = (defaultprice - (defaultprice * discount5));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = (defaultprice - (defaultprice * discount6)) * 25;
            }
            else if (month < 61)
            {
                priceperMonth = (defaultprice - (defaultprice * discount6));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = (defaultprice - (defaultprice * discount7)) * 61;
            }
            else
            {
                priceperMonth = (defaultprice - (defaultprice * discount7));
                priceFullTerm = priceperMonth * month;
                priceNextTerm = 0;
            }
            priceperMonth = Math.Round(priceperMonth, 2);
            priceFullTerm = Math.Round(priceFullTerm, 2);
            priceNextTerm = Math.Round(priceNextTerm, 2);
        }
        int ConfirmedMonth;
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                int month = int.Parse(ClientConfirmedTextBox.Text);
                ConfirmedMonth = month;
                if (month > 0)
                {
                    PriceCalculationforTerm(month);
                    DisplayButton.Enabled = false; TermTextBox.Enabled = false;
                    PricePerMonthLabel.Text = ""; PriceFullTermLabel.Text = ""; PriceNextTermLabel.Text = ""; PromptLabel.Visible = false; ;
                    MembershipDetailsGroupBox.Visible = true;
                    UniqueMembershipGeneration();
                    DateTime today = new DateTime();
                    today = DateTime.Now;
                    JoinDayLabel.Text = today.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Enter valid month in digits", "Invalid", MessageBoxButtons.OK);
                    ClientConfirmedTextBox.Clear();
                    ClientConfirmedTextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Enter valid month in digits", "Invalid", MessageBoxButtons.OK);
                ClientConfirmedTextBox.Clear();
                ClientConfirmedTextBox.Focus();
            }
        }
        
        private int CalculateNoofLinesinFile()
        {
            int count = 1, lines; 
            try
            {
                StreamReader OutputFile = File.OpenText("HaloFitnessClientDetails.txt");
                while (OutputFile.ReadLine() != null)
                {
                    count++;
                }
                lines = count;
                OutputFile.Close();
            }
            catch {
                MessageBox.Show("File does not exist in the path!!!\nContact Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lines = 0;
            }
            return lines;
        }
        private void UniqueMembershipGeneration()
        {
            int totalLines = CalculateNoofLinesinFile();
            Random Rand = new Random();
            int rand = Rand.Next(0, 999999);
            try
            {
                StreamReader OutputFile = File.OpenText("HaloFitnessClientDetails.txt");
                while (OutputFile.ReadLine() != null)
                {
                    for (int i = 1; i <= totalLines; i ++)
                    {
                        if (OutputFile.ReadLine() == rand.ToString("D6"))
                        {
                            UniqueMembershipGeneration();
                        }
                        else
                        {
                            MembershipIDLabel.Text = rand.ToString("D6");
                        }
                    }
                }
                OutputFile.Close();
            }
            catch
            {
                MessageBox.Show("File does not exist in the path!!!\nContact Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text != "")
            {
                try
                {
                    long pHNo = long.Parse(TelephoneTextBox.Text);
                    if (pHNo.ToString().Length == 10)
                    {
                        if (EmailTextBox.Text != "" & (EmailTextBox.Text.Contains("@") | EmailTextBox.Text.EndsWith(".com") | EmailTextBox.Text.EndsWith(".in") | EmailTextBox.Text.EndsWith(".ie")))
                        {
                            string details = "Name of Client:\t\t" + FullNameTextBox.Text + "\nMembership ID:\t\t" + MembershipIDLabel.Text + "\nDate of Joining:\t\t" + JoinDayLabel.Text + "\nTelephone Number:\t" + TelephoneTextBox.Text + "\nEmail Address:\t\t" + EmailTextBox.Text + "\nMonths Selected:\t\t" + ConfirmedMonth + "\nTotal Price:\t\t" + priceFullTerm.ToString("C2") + "\nPrice per Month:\t\t" + priceperMonth.ToString("C2");
                            if (MessageBox.Show("Do you wish to Proceed?\n" + details, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                try
                                {
                                    StreamWriter InputFile = File.AppendText("HaloFitnessClientDetails.txt");
                                    InputFile.WriteLine(MembershipIDLabel.Text);
                                    InputFile.WriteLine(JoinDayLabel.Text);
                                    InputFile.WriteLine(FullNameTextBox.Text);
                                    InputFile.WriteLine(TelephoneTextBox.Text);
                                    InputFile.WriteLine(EmailTextBox.Text);
                                    InputFile.WriteLine(ConfirmedMonth.ToString());
                                    InputFile.WriteLine(priceFullTerm.ToString());
                                    InputFile.Close();
                                    MessageBox.Show("Details Saved!!!\nWelcome to Halo Fitness!\nAll the best to get your dream Physique", "Conragulations");
                                    ClearButton_Click(sender, e);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("File does not exist in the path!!!\nContact Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                ClearButton.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Email of the Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EmailTextBox.Clear();
                            EmailTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid telephone number of the Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TelephoneTextBox.Clear();
                        TelephoneTextBox.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Enter telephone number of the Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TelephoneTextBox.Clear();
                    TelephoneTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter Name of the Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FullNameTextBox.Focus();
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TermTextBox.Clear(); DisplayButton.Enabled = true;
            PricePerMonthLabel.Text = ""; PriceFullTermLabel.Text = ""; PriceNextTermLabel.Text = "";
            PromptLabel.Visible = false;
            MembershipDetailsGroupBox.Visible = false;
            ClientConfirmedTextBox.Clear(); 
            FullNameTextBox.Clear(); TelephoneTextBox.Clear(); EmailTextBox.Clear();
            SearchByIDTextBox.Clear(); SearchByDateTextBox.Clear(); DisplayDetailsListBox.Visible = false;
            if ((SummaryGroupBox.Visible) || (SearchGroupBox.Visible))
            {
                for (int i = 620; i > 380; i -= INCREMENT)
                {
                    this.Size = new Size(FORMWIDTH, i);
                    this.Update();
                    System.Threading.Thread.Sleep(1);
                }
            }
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
        }
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SearchByIDTextBox.Clear(); SearchByDateTextBox.Clear(); DisplayDetailsListBox.Items.Clear();
            SearchGroupBox.Visible = false;
            SummaryGroupBox.Visible = true;
            int TotalLines = CalculateNoofLinesinFile();
            decimal TotalTranscations = Convert.ToDecimal(TotalLines) / 7;
            decimal TotalMembershipFees = CalculateSummary(7);
            TotalMembershipFeesLabel.Text = TotalMembershipFees.ToString("C2");
            AvgMembershipFeesLabel.Text = (TotalMembershipFees / TotalTranscations).ToString("C2");
            decimal TotalTerms = CalculateSummary(6);
            AvgMembershipTermLabel.Text = (TotalTerms/ TotalTranscations).ToString("N2");
            decimal TotalMembershipIDs = CalculateSummary(1);
            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }
        }
        private decimal CalculateSummary(int CalculateLines)
        {
            MembershipIDsListBox.Items.Clear();
            int TotalLines = CalculateNoofLinesinFile();
            string temp;
            decimal Total =0m, value;
                try
                {
                StreamReader OutputFile = File.OpenText("HaloFitnessClientDetails.txt");
                while (!OutputFile.EndOfStream)
                {
                    for (int i = 1; i <= TotalLines - 1; i++)
                {
                        if ((i - CalculateLines) % 7 == 0)
                        {
                            if (CalculateLines == 1) { MembershipIDsListBox.Items.Add(OutputFile.ReadLine()); }
                            else { temp = OutputFile.ReadLine();
                                value = decimal.Parse(temp);
                                Total += value; }
                        }
                        else { OutputFile.ReadLine(); }
                        }
                    
                }
                    OutputFile.Close();
                }
                catch
                {
                    MessageBox.Show("No Information Available\nContact Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            return Total;
        }
    private void SearchButton_Click(object sender, EventArgs e)
        {
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = true;

            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }
        }
        private void SearchByIDButton_Click_1(object sender, EventArgs e)
        {
        DisplayDetailsListBox.Items.Clear();
            SearchByDateTextBox.Clear();
            try
            {
                int membershipIDentered = int.Parse(SearchByIDTextBox.Text);
                    string temp = SearchByIDTextBox.Text;
                    int TotalLines = CalculateNoofLinesinFile();
                try
                {
                    StreamReader OutputFile = File.OpenText("HaloFitnessClientDetails.txt");
                    while (!OutputFile.EndOfStream)
                    {
                        for (int i = 1; i <= TotalLines - 2; i++)
                        {
                                if (temp == OutputFile.ReadLine())
                                {
                                    DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                    DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                    DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                    DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                    DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                    DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                    DisplayDetailsListBox.Visible = true;
                                    break;
                                }
                                else if (i == TotalLines - 1) { MessageBox.Show("Does not exist","Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        }
                    }
                    OutputFile.Close();
                }
                catch
                {
                    MessageBox.Show("No Information Available\nContact Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            catch
            {
                MessageBox.Show("Enter Valid Membership ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchByDateButton_Click(object sender, EventArgs e)
        {
            DisplayDetailsListBox.Items.Clear();
            SearchByIDTextBox.Clear();
            try
            {
                DateTime searchDate = new DateTime();
                searchDate = DateTime.ParseExact(SearchByDateTextBox.Text, "dd/MM/yyyy", null);
                string temp = SearchByDateTextBox.Text;
                string tempID;
                int TotalLines = CalculateNoofLinesinFile();
                try
                {
                    StreamReader OutputFile = File.OpenText("HaloFitnessClientDetails.txt");
                    while (!OutputFile.EndOfStream)
                    {
                        for (int i = 1; i <= TotalLines - 2; i++)
                        {
                            tempID = OutputFile.ReadLine();
                            if (temp == OutputFile.ReadLine())
                            {
                                DisplayDetailsListBox.Items.Add(tempID);
                                DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                DisplayDetailsListBox.Items.Add(OutputFile.ReadLine());
                                DisplayDetailsListBox.Items.Add("");
                                DisplayDetailsListBox.Visible = true;
                                break;
                            }
                            else if (i == TotalLines - 1) { MessageBox.Show("No Transcations were done on the date","Information",MessageBoxButtons.OK,MessageBoxIcon.Information); }
                        }
                    }
                    OutputFile.Close();
                }
                catch
                {
                    MessageBox.Show("No Information Available\nContact Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Enter Valid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
