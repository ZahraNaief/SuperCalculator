namespace Assignment_3
{
    public partial class MainForm : Form
    {
        private string name = string.Empty;
        private BMICalculator bmiCal = new BMICalculator();
        private SavingCalculator saveCal = new SavingCalculator();
        private BMRCalculator BMRCal = new BMRCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            //GUI section for BMI
            this.Text += " Zahra Khalid";
            rbtnMetric.Checked = true;
            lblHeight.Text = "Height";
            lblWght.Text = "Weight";
            lblWeightCat.Text = String.Empty;
            lblbmiResult.Text = String.Empty;
            lblLowandHighWeight.Text = string.Empty;
            lblNormalBMI.Text = "Normal BMI is between 18.50 and 24.90";
            lblNormalWeight.Text = "Normal weight is between 116 and 157 lbs";

            //GUI section for Saving Calculator
            lblAmtPaid.Text = String.Empty;
            lblAmtEarned.Text = String.Empty;
            lblFnlBalance.Text = String.Empty;
            lblTltFee.Text = String.Empty;

            //GUI section for BMR
            txtAge.Text = String.Empty;
            listBoxBMRCal.Items.Clear();
        }
        private void UpdateHeightUnits()
        {
            lblbmiResult.Text = String.Empty;
            lblWeightCat.Text = String.Empty;
            txtCmFt.Text = String.Empty;
            txtInch.Text = String.Empty;
            txtweight.Text = String.Empty;
            if (rbtnMetric.Checked)
            {
                lblHeight.Text = "Height (cm)";
                lblWght.Text = "Weight (kg)";
                txtInch.Visible = false;
            }
            else
            {
                lblHeight.Text = "Height (ft ,in)";
                lblWght.Text = "Weight (lbs)";
                txtInch.Visible = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void lblHeight_Click(object sender, EventArgs e)
        {

        }
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightUnits();
        }
        private void rbtnUSCustomoryUnits_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightUnits();
        }
        private void lblWeightCal_Click(object sender, EventArgs e)
        {

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool calculate = readInputBMI();
            if (calculate)
            {
                calculateAndDisplayResults();
            }
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>

        // Method to read Input for Saving Calculator
        //reading input and calculating Results for BMI Calculator
        #region
        /// Calculate and Display Results for BMI
        private void calculateAndDisplayResults()
        {
            double bmiResult = 0;
            bmiResult = bmiCal.calculateBMI();
            lblbmiResult.Text = bmiResult.ToString("f2");
            lblWeightCat.Text = bmiCal.FindWeightCategory(bmiResult).ToString();
            lblLowandHighWeight.Text = bmiCal.LowAndHighWeigt();
        }
        private bool readInputBMI()
        {
            readName();
            readUnit();
            bool height = readHeight();
            bool weight = readWeight();
            return height && weight;
        }
        private void readName()
        {
            name = txtName.Text.Trim();
            if (txtName.Text == string.Empty)
                MessageBox.Show("Name is required!", "Error");

            grpResult.Text = "Results for " + name;
        }
        private void readUnit()
        {
            if (rbtnMetric.Checked)
                bmiCal.SetUnit(UnitTypes.Metric);
            else
                bmiCal.SetUnit(UnitTypes.USCustomaryUnits);
        }
        private bool readHeight()
        {
            double outheight = 0;
            double inchHeight = 0;
            bool validheight = double.TryParse(txtCmFt.Text, out outheight);
            bool validInch = double.TryParse(txtInch.Text, out inchHeight);
            if (validheight)
            {
                if (outheight > 0) //Height should not be negative
                {
                    /* if unit type is Metric than height need to be changed
                    from cmm to m and if it is USCustomaryUnits than height need to 
                    changed from ft to inch */
                    if (bmiCal.GetUnit() == UnitTypes.USCustomaryUnits)
                    {
                        if (inchHeight > 0)
                            bmiCal.SetHeight((outheight * 12.0) + inchHeight);  // ft --> Inch
                            BMRCal.SetHeight((outheight * 30.48) + (inchHeight * 2.54));
                    }
                    else
                    {
                        bmiCal.SetHeight(outheight / 100.0); // cm --> m
                        BMRCal.SetHeight(outheight);

                    }
                }
            }
            if (!validheight)
                MessageBox.Show("The height value is Invalid", "Error");
            return validheight;
        }
        private bool readWeight()
        {
            double outweight = 0.0;
            // try parse
            bool validWeight = double.TryParse(txtweight.Text, out outweight);
            if (bmiCal.GetUnit() == UnitTypes.USCustomaryUnits)
            {
                if (outweight > 0)
                    bmiCal.SetWeight(outweight);
                    BMRCal.SetWeight(outweight / 2.20462);
            }
            else
            {
                BMRCal.SetWeight(outweight);

            }
            if (!validWeight) //Ok == false
                MessageBox.Show("The weight value is Invalid", "Error");
            return validWeight;
        }
        #endregion
        //reading input and calculating Results for Saving Calculator
        #region
        /// Calculate and Display Results for Savings
        private void calculateAndDisplaySaving()
        {
            double amountPaid = 0;
            double amountEarned = 0;
            double finalBalance = 0;
            double totalFee = 0;
            readInputSaving();
            amountPaid = saveCal.CalculateTotalAmountPaid();
            amountEarned = saveCal.GetAmountEarned();
            finalBalance = saveCal.GetFinalBalance();
            totalFee = saveCal.GetTotalFees();
            lblAmtPaid.Text = amountPaid.ToString();
            lblAmtEarned.Text = amountEarned.ToString();
            lblFnlBalance.Text = finalBalance.ToString();
            lblTltFee.Text = totalFee.ToString();
        }
        // Read input for the saving calculator
        private bool readInputSaving()
        {
            bool initialDeposit = readInitialDeposit();
            bool monthlyDeposit = readMonthlyDeposit();
            bool period = readPeriods();
            bool interestrate = readInterestRate();
            bool feeInpercentage = readFeesInPercentage();
            bool validInput = initialDeposit && monthlyDeposit && period && interestrate && feeInpercentage;
            return validInput;
        }
        private bool readInitialDeposit()
        {
            double initailDep = 0;

            if (!string.IsNullOrWhiteSpace(txtInitialDeposit.Text))
            {
                if (double.TryParse(txtInitialDeposit.Text, out initailDep) && initailDep >= 0)
                {
                    saveCal.SetIntialDeposit(initailDep);
                    return true;
                }
                else
                {
                    MessageBox.Show("The initial deposit value is invalid. Please enter a valid positive value.", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the initial deposit amount.", "Error");
                return false;
            }
        }
        private bool readMonthlyDeposit()
        {
            double monthlyDeposit = 0;
            if (!string.IsNullOrWhiteSpace(txtMonthlyDeposit.Text))
            {
                if (double.TryParse(txtMonthlyDeposit.Text, out monthlyDeposit) && monthlyDeposit >= 0)
                {
                    saveCal.SetMonthlyDeposit(monthlyDeposit);
                    return true;
                }
                else
                {
                    MessageBox.Show("The monthly deposit value is invalid. Please enter a valid positive value.", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the monthly deposit amount.", "Error");
                return false;
            }
        }
        private bool readPeriods()
        {
            double period = 0;

            if (!string.IsNullOrWhiteSpace(txtPeriod.Text))
            {
                if (double.TryParse(txtPeriod.Text, out period) && period >= 0)
                {
                    saveCal.SetPeriodInYears(period);
                    return true;
                }
                else
                {
                    MessageBox.Show("The period's value is invalid. Please enter a valid value.", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the period years.", "Error");
                return false;
            }
        }
        private bool readInterestRate()
        {
            double rate = 0;
            if (!string.IsNullOrWhiteSpace(txtGrowth.Text))
            {
                if (double.TryParse(txtGrowth.Text, out rate) && rate >= 0)
                {

                    saveCal.SetInterestRate(rate);
                    return true;
                }
                else
                {
                    MessageBox.Show("The Fees's value is invalid. Please enter a valid value.", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the fees.", "Error");
                return false;
            }

        }
        private bool readFeesInPercentage()
        {
            double fees = 0;

            if (!string.IsNullOrWhiteSpace(txtFees.Text))
            {
                if (double.TryParse(txtFees.Text, out fees) && fees >= 0)
                {

                    saveCal.SetFeesInPercentage(fees);
                    return true;
                }
                else
                {
                    MessageBox.Show("The Fees's value is invalid. Please enter a valid value.", "Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter the fees.", "Error");
                return false;
            }
        }
        #endregion

        //reading input and calculating Results for BMR Calculator'
        #region
        // Calculate and Display Results for BMR
        private void CalculateAndDisplayBMR()
        {
            double bmrResult = 0;
            bmrResult = BMRCal.calculateBMR();
            listBoxBMRCal.Items.Add($"BMR RESULTS FOR                             " + txtName.Text + "\n\n");
            listBoxBMRCal.Items.Add($"Your BMR (Calories/day){new string(' ',91) }{ bmrResult:##0000.0}");
            listBoxBMRCal.Items.Add($"Calories to maintain your weight{new string(' ', 78)}{BMRCal.activityLevel():##0000.0}");
            listBoxBMRCal.Items.Add($"Calories to lose 0,5kg per week{new string(' ', 80)}{BMRCal.GetloosehalfKg():##0000.0}");
            listBoxBMRCal.Items.Add($"Calories to lose 1kg per week{new string(' ',84)}{BMRCal.GetlooseoneKg():##0000.0}");  
            listBoxBMRCal.Items.Add($"Calories to gain 0,5kg per week{new string(' ',80)}{BMRCal.GetgainhalfKg():##0000.0}");
            listBoxBMRCal.Items.Add($"Calories to gain 1kg per week {new string(' ',82)}{BMRCal.GetgainoneKg():##0000.0}" + "\n");
            listBoxBMRCal.Items.Add($"Loosing more than 1000 calories per day is to be avoided");
            
        }
        //Read Input for BMR
        private bool readBMRinput()
        {        
            bool height = readHeight();
            bool weight = readWeight();
            bool readgender = readGender();
            bool readactivity = readWeeklyActivity();
            bool age =   readAge();
            return height && weight && age && readactivity && readgender;
        }
        private bool readWeeklyActivity()
        {
            if (rbtnSedentary.Checked)
                BMRCal.SetWeeklyActivity(WeeklyActivity.Sedentary);
            else if (rbtnLightlyActive.Checked)
                BMRCal.SetWeeklyActivity(WeeklyActivity.Light);
            else if (rbtnModeratelyActive.Checked)
                BMRCal.SetWeeklyActivity(WeeklyActivity.Moderate);
            else if (rbtnVeryActive.Checked)
                BMRCal.SetWeeklyActivity(WeeklyActivity.VeryActive);
            else if (rbtnExtraActive.Checked)
                BMRCal.SetWeeklyActivity(WeeklyActivity.ExtraActive);
            else
            {
                MessageBox.Show("Select the weekly activity, Error");
                return false;
            }
            return true;
        }

        private bool readAge()
        {
            double outAge = 0.0;
            // try parse
            bool validAge = double.TryParse(txtAge.Text, out outAge);
            if (outAge > 0)
            {
                BMRCal.SetAge(outAge);
            }
            if (!validAge) //Ok == false
                MessageBox.Show("The age  is Invalid", "Error");
            return validAge;
        }
        private bool readGender()
        {
            if (rbtnFemale.Checked)
                BMRCal.SetGender(Gender.Female);
            else if (rbtnMale.Checked)
                BMRCal.SetGender(Gender.Male);
            else
            {
                MessageBox.Show("Select Gender, Error");
                return false;
            }
            return true;
        }
       
        #endregion
        private void lblWght_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
        private void lblNormalWeight_Click(object sender, EventArgs e)
        {

        }
        private void lblBMI_Click(object sender, EventArgs e)
        {

        }
        private void grpResult_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void lblGrowth_Click(object sender, EventArgs e)
        {

        }
        private void lblPeriod_Click(object sender, EventArgs e)
        {

        }
        private void lblAmountPaid_Click(object sender, EventArgs e)
        {

        }
        private void btnCalSaving_Click(object sender, EventArgs e)
        {
            bool calculateSaving = readInputSaving();
            if (calculateSaving)
            {
                calculateAndDisplaySaving();
            }
        }

        private void btnResetBMICal_Click(object sender, EventArgs e)
        {
            // Loop through all controls in the form
            foreach (Control control in grpBMICal.Controls)
            {
                // Check if the control is a TextBox or a Label
                if (control is TextBox textBox)
                {
                    // Clear the text of text boxes
                    textBox.Text = "";
                }
                else if (control is Label label)
                {
                    // Clear the text of labels
                    label.Text = "";
                }
            }
        }

        private void btnResetSavingCal_Click(object sender, EventArgs e)
        {
            // Loop through all controls in the form
            foreach (Control control in grpSavingCal.Controls)
            {
                // Check if the control is a TextBox or a Label
                if (control is TextBox textBox)
                {
                    // Clear the text of text boxes
                    textBox.Text = "";
                }
                else if (control is Label label)
                {
                    // Clear the text of labels
                    label.Text = "";
                }
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            bool calculateBMR = readBMRinput();
            if (calculateBMR)
            {
                CalculateAndDisplayBMR();
            }
        }

        private void grpBMICal_Enter(object sender, EventArgs e)
        {

        }
    }
}
