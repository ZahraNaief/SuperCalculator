namespace Assignment_3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            txtCmFt = new TextBox();
            txtInch = new TextBox();
            btnCalculate = new Button();
            lblBMI = new Label();
            lblWeight = new Label();
            lblbmiResult = new Label();
            lblWeightCat = new Label();
            lblNormalBMI = new Label();
            grpUnit = new GroupBox();
            rbtnUSCustomoryUnits = new RadioButton();
            rbtnMetric = new RadioButton();
            grpResult = new GroupBox();
            label1 = new Label();
            lblWght = new Label();
            txtweight = new TextBox();
            lblHeight = new Label();
            lblNormalWeight = new Label();
            lblLowandHighWeight = new Label();
            grpBMICalculator = new GroupBox();
            grpSavingPlan = new GroupBox();
            txtFees = new TextBox();
            txtGrowth = new TextBox();
            txtPeriod = new TextBox();
            txtMonthlyDeposit = new TextBox();
            txtInitialDeposit = new TextBox();
            blFees = new Label();
            lblGrowth = new Label();
            lblPeriod = new Label();
            lblMonthlyDeposit = new Label();
            lblInitialDeposit = new Label();
            btnCalSaving = new Button();
            grpFutureValue = new GroupBox();
            lblTltFee = new Label();
            lblFnlBalance = new Label();
            lblAmtEarned = new Label();
            lblAmtPaid = new Label();
            lblTotalFees = new Label();
            lblFinalBalance = new Label();
            lblAmountEarned = new Label();
            lblAmountPaid = new Label();
            grpSavingCal = new GroupBox();
            grpBMICal = new GroupBox();
            groupBox1 = new GroupBox();
            btnCalculateBMR = new Button();
            txtAge = new TextBox();
            lblAge = new Label();
            listBoxBMRCal = new ListBox();
            grpActivityLevel = new GroupBox();
            rbtnExtraActive = new RadioButton();
            rbtnVeryActive = new RadioButton();
            rbtnModeratelyActive = new RadioButton();
            rbtnLightlyActive = new RadioButton();
            rbtnSedentary = new RadioButton();
            grpGender = new GroupBox();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            grpUnit.SuspendLayout();
            grpResult.SuspendLayout();
            grpBMICalculator.SuspendLayout();
            grpSavingPlan.SuspendLayout();
            grpFutureValue.SuspendLayout();
            grpSavingCal.SuspendLayout();
            grpBMICal.SuspendLayout();
            groupBox1.SuspendLayout();
            grpActivityLevel.SuspendLayout();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Arial Narrow", 10F);
            lblName.Location = new Point(6, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(162, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Your Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial Narrow", 10F);
            txtName.Location = new Point(174, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 30);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtCmFt
            // 
            txtCmFt.Font = new Font("Arial Narrow", 10F);
            txtCmFt.Location = new Point(174, 89);
            txtCmFt.Name = "txtCmFt";
            txtCmFt.Size = new Size(125, 30);
            txtCmFt.TabIndex = 3;
            // 
            // txtInch
            // 
            txtInch.Font = new Font("Arial Narrow", 10F);
            txtInch.Location = new Point(305, 89);
            txtInch.Name = "txtInch";
            txtInch.Size = new Size(127, 30);
            txtInch.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial Narrow", 10F);
            btnCalculate.Location = new Point(181, 222);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(228, 43);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate BMI";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblBMI
            // 
            lblBMI.Font = new Font("Arial Narrow", 10F);
            lblBMI.Location = new Point(7, 42);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(164, 38);
            lblBMI.TabIndex = 6;
            lblBMI.Text = "Your BMI";
            lblBMI.TextAlign = ContentAlignment.MiddleCenter;
            lblBMI.Click += lblBMI_Click;
            // 
            // lblWeight
            // 
            lblWeight.Font = new Font("Arial Narrow", 10F);
            lblWeight.Location = new Point(7, 93);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(164, 40);
            lblWeight.TabIndex = 7;
            lblWeight.Text = "WeightCategory";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblbmiResult
            // 
            lblbmiResult.BorderStyle = BorderStyle.Fixed3D;
            lblbmiResult.Font = new Font("Arial Narrow", 10F);
            lblbmiResult.Location = new Point(200, 40);
            lblbmiResult.Name = "lblbmiResult";
            lblbmiResult.Size = new Size(462, 40);
            lblbmiResult.TabIndex = 8;
            lblbmiResult.Text = "Label3";
            lblbmiResult.TextAlign = ContentAlignment.MiddleRight;
            lblbmiResult.Click += label1_Click;
            // 
            // lblWeightCat
            // 
            lblWeightCat.BorderStyle = BorderStyle.Fixed3D;
            lblWeightCat.Font = new Font("Arial Narrow", 10F);
            lblWeightCat.Location = new Point(200, 93);
            lblWeightCat.Name = "lblWeightCat";
            lblWeightCat.Size = new Size(462, 40);
            lblWeightCat.TabIndex = 9;
            lblWeightCat.Text = "Label3";
            lblWeightCat.TextAlign = ContentAlignment.MiddleRight;
            lblWeightCat.UseMnemonic = false;
            lblWeightCat.Click += lblWeightCal_Click;
            // 
            // lblNormalBMI
            // 
            lblNormalBMI.BorderStyle = BorderStyle.FixedSingle;
            lblNormalBMI.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNormalBMI.ForeColor = SystemColors.WindowText;
            lblNormalBMI.Location = new Point(16, 432);
            lblNormalBMI.Name = "lblNormalBMI";
            lblNormalBMI.Size = new Size(743, 44);
            lblNormalBMI.TabIndex = 10;
            lblNormalBMI.Text = "Label3";
            lblNormalBMI.TextAlign = ContentAlignment.MiddleCenter;
            lblNormalBMI.Click += label2_Click;
            // 
            // grpUnit
            // 
            grpUnit.Controls.Add(rbtnUSCustomoryUnits);
            grpUnit.Controls.Add(rbtnMetric);
            grpUnit.Location = new Point(478, 12);
            grpUnit.Name = "grpUnit";
            grpUnit.Size = new Size(281, 167);
            grpUnit.TabIndex = 11;
            grpUnit.TabStop = false;
            grpUnit.Text = "Unit";
            // 
            // rbtnUSCustomoryUnits
            // 
            rbtnUSCustomoryUnits.Location = new Point(35, 89);
            rbtnUSCustomoryUnits.Name = "rbtnUSCustomoryUnits";
            rbtnUSCustomoryUnits.Size = new Size(234, 44);
            rbtnUSCustomoryUnits.TabIndex = 1;
            rbtnUSCustomoryUnits.TabStop = true;
            rbtnUSCustomoryUnits.Text = "U.S. Units (ft,lbs)";
            rbtnUSCustomoryUnits.UseVisualStyleBackColor = true;
            rbtnUSCustomoryUnits.CheckedChanged += rbtnUSCustomoryUnits_CheckedChanged;
            // 
            // rbtnMetric
            // 
            rbtnMetric.ForeColor = Color.Black;
            rbtnMetric.Location = new Point(35, 39);
            rbtnMetric.Name = "rbtnMetric";
            rbtnMetric.Size = new Size(212, 44);
            rbtnMetric.TabIndex = 0;
            rbtnMetric.TabStop = true;
            rbtnMetric.Text = "Metric (kg,cm)";
            rbtnMetric.UseVisualStyleBackColor = true;
            rbtnMetric.CheckedChanged += rbtnMetric_CheckedChanged;
            // 
            // grpResult
            // 
            grpResult.Controls.Add(label1);
            grpResult.Controls.Add(lblbmiResult);
            grpResult.Controls.Add(lblBMI);
            grpResult.Controls.Add(lblWeight);
            grpResult.Controls.Add(lblWeightCat);
            grpResult.Location = new Point(16, 271);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(743, 164);
            grpResult.TabIndex = 12;
            grpResult.TabStop = false;
            grpResult.Text = "Results";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 161);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 10;
            // 
            // lblWght
            // 
            lblWght.Location = new Point(26, 129);
            lblWght.Name = "lblWght";
            lblWght.Size = new Size(130, 38);
            lblWght.TabIndex = 13;
            lblWght.Text = "Weight";
            lblWght.TextAlign = ContentAlignment.MiddleCenter;
            lblWght.Click += lblWght_Click;
            // 
            // txtweight
            // 
            txtweight.Location = new Point(174, 136);
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(125, 31);
            txtweight.TabIndex = 14;
            // 
            // lblHeight
            // 
            lblHeight.Location = new Point(24, 85);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(132, 34);
            lblHeight.TabIndex = 15;
            lblHeight.Text = "Height";
            lblHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNormalWeight
            // 
            lblNormalWeight.BorderStyle = BorderStyle.FixedSingle;
            lblNormalWeight.ForeColor = SystemColors.WindowText;
            lblNormalWeight.Location = new Point(16, 476);
            lblNormalWeight.Name = "lblNormalWeight";
            lblNormalWeight.Size = new Size(743, 47);
            lblNormalWeight.TabIndex = 16;
            lblNormalWeight.Text = "label2";
            lblNormalWeight.TextAlign = ContentAlignment.MiddleCenter;
            lblNormalWeight.Click += lblNormalWeight_Click;
            // 
            // lblLowandHighWeight
            // 
            lblLowandHighWeight.BorderStyle = BorderStyle.FixedSingle;
            lblLowandHighWeight.Location = new Point(16, 523);
            lblLowandHighWeight.Name = "lblLowandHighWeight";
            lblLowandHighWeight.Size = new Size(743, 46);
            lblLowandHighWeight.TabIndex = 17;
            lblLowandHighWeight.Text = "label1";
            lblLowandHighWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpBMICalculator
            // 
            grpBMICalculator.Controls.Add(lblName);
            grpBMICalculator.Controls.Add(txtName);
            grpBMICalculator.Controls.Add(lblHeight);
            grpBMICalculator.Controls.Add(txtweight);
            grpBMICalculator.Controls.Add(txtCmFt);
            grpBMICalculator.Controls.Add(lblWght);
            grpBMICalculator.Controls.Add(txtInch);
            grpBMICalculator.Location = new Point(16, 12);
            grpBMICalculator.Name = "grpBMICalculator";
            grpBMICalculator.Size = new Size(456, 202);
            grpBMICalculator.TabIndex = 18;
            grpBMICalculator.TabStop = false;
            grpBMICalculator.Text = "BMI Calculator";
            grpBMICalculator.Enter += groupBox1_Enter;
            // 
            // grpSavingPlan
            // 
            grpSavingPlan.Controls.Add(txtFees);
            grpSavingPlan.Controls.Add(txtGrowth);
            grpSavingPlan.Controls.Add(txtPeriod);
            grpSavingPlan.Controls.Add(txtMonthlyDeposit);
            grpSavingPlan.Controls.Add(txtInitialDeposit);
            grpSavingPlan.Controls.Add(blFees);
            grpSavingPlan.Controls.Add(lblGrowth);
            grpSavingPlan.Controls.Add(lblPeriod);
            grpSavingPlan.Controls.Add(lblMonthlyDeposit);
            grpSavingPlan.Controls.Add(lblInitialDeposit);
            grpSavingPlan.Location = new Point(19, 18);
            grpSavingPlan.Name = "grpSavingPlan";
            grpSavingPlan.Size = new Size(612, 291);
            grpSavingPlan.TabIndex = 19;
            grpSavingPlan.TabStop = false;
            grpSavingPlan.Text = "Saving Plan";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(302, 223);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(289, 31);
            txtFees.TabIndex = 9;
            txtFees.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGrowth
            // 
            txtGrowth.Location = new Point(302, 182);
            txtGrowth.Name = "txtGrowth";
            txtGrowth.Size = new Size(289, 31);
            txtGrowth.TabIndex = 8;
            txtGrowth.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPeriod
            // 
            txtPeriod.Location = new Point(302, 140);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(289, 31);
            txtPeriod.TabIndex = 7;
            txtPeriod.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMonthlyDeposit
            // 
            txtMonthlyDeposit.Location = new Point(303, 92);
            txtMonthlyDeposit.Name = "txtMonthlyDeposit";
            txtMonthlyDeposit.Size = new Size(288, 31);
            txtMonthlyDeposit.TabIndex = 6;
            txtMonthlyDeposit.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInitialDeposit
            // 
            txtInitialDeposit.Location = new Point(302, 46);
            txtInitialDeposit.Name = "txtInitialDeposit";
            txtInitialDeposit.Size = new Size(289, 31);
            txtInitialDeposit.TabIndex = 5;
            txtInitialDeposit.TextAlign = HorizontalAlignment.Right;
            // 
            // blFees
            // 
            blFees.Location = new Point(20, 220);
            blFees.Name = "blFees";
            blFees.Size = new Size(237, 37);
            blFees.TabIndex = 4;
            blFees.Text = "Fees in %age";
            blFees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrowth
            // 
            lblGrowth.Location = new Point(20, 178);
            lblGrowth.Name = "lblGrowth";
            lblGrowth.Size = new Size(237, 39);
            lblGrowth.TabIndex = 3;
            lblGrowth.Text = "Growth (or interest) in %age";
            lblGrowth.TextAlign = ContentAlignment.MiddleCenter;
            lblGrowth.Click += lblGrowth_Click;
            // 
            // lblPeriod
            // 
            lblPeriod.Location = new Point(20, 134);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(237, 43);
            lblPeriod.TabIndex = 2;
            lblPeriod.Text = "Period (years)";
            lblPeriod.TextAlign = ContentAlignment.MiddleCenter;
            lblPeriod.Click += lblPeriod_Click;
            // 
            // lblMonthlyDeposit
            // 
            lblMonthlyDeposit.Location = new Point(20, 92);
            lblMonthlyDeposit.Name = "lblMonthlyDeposit";
            lblMonthlyDeposit.Size = new Size(237, 42);
            lblMonthlyDeposit.TabIndex = 1;
            lblMonthlyDeposit.Text = "Monthly deposit";
            lblMonthlyDeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInitialDeposit
            // 
            lblInitialDeposit.Location = new Point(20, 46);
            lblInitialDeposit.Name = "lblInitialDeposit";
            lblInitialDeposit.Size = new Size(237, 40);
            lblInitialDeposit.TabIndex = 0;
            lblInitialDeposit.Text = "Initial deposit";
            lblInitialDeposit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalSaving
            // 
            btnCalSaving.Location = new Point(179, 315);
            btnCalSaving.Name = "btnCalSaving";
            btnCalSaving.Size = new Size(362, 43);
            btnCalSaving.TabIndex = 20;
            btnCalSaving.Text = "Calculate Savings";
            btnCalSaving.UseVisualStyleBackColor = true;
            btnCalSaving.Click += btnCalSaving_Click;
            // 
            // grpFutureValue
            // 
            grpFutureValue.Controls.Add(lblTltFee);
            grpFutureValue.Controls.Add(lblFnlBalance);
            grpFutureValue.Controls.Add(lblAmtEarned);
            grpFutureValue.Controls.Add(lblAmtPaid);
            grpFutureValue.Controls.Add(lblTotalFees);
            grpFutureValue.Controls.Add(lblFinalBalance);
            grpFutureValue.Controls.Add(lblAmountEarned);
            grpFutureValue.Controls.Add(lblAmountPaid);
            grpFutureValue.Location = new Point(19, 364);
            grpFutureValue.Name = "grpFutureValue";
            grpFutureValue.Size = new Size(612, 230);
            grpFutureValue.TabIndex = 21;
            grpFutureValue.TabStop = false;
            grpFutureValue.Text = "Future Value";
            // 
            // lblTltFee
            // 
            lblTltFee.BorderStyle = BorderStyle.Fixed3D;
            lblTltFee.Location = new Point(269, 182);
            lblTltFee.Name = "lblTltFee";
            lblTltFee.Size = new Size(322, 33);
            lblTltFee.TabIndex = 7;
            lblTltFee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFnlBalance
            // 
            lblFnlBalance.BorderStyle = BorderStyle.Fixed3D;
            lblFnlBalance.Location = new Point(269, 130);
            lblFnlBalance.Name = "lblFnlBalance";
            lblFnlBalance.Size = new Size(322, 36);
            lblFnlBalance.TabIndex = 6;
            lblFnlBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmtEarned
            // 
            lblAmtEarned.BorderStyle = BorderStyle.Fixed3D;
            lblAmtEarned.Location = new Point(269, 84);
            lblAmtEarned.Name = "lblAmtEarned";
            lblAmtEarned.Size = new Size(322, 37);
            lblAmtEarned.TabIndex = 5;
            lblAmtEarned.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAmtPaid
            // 
            lblAmtPaid.BorderStyle = BorderStyle.Fixed3D;
            lblAmtPaid.Location = new Point(269, 38);
            lblAmtPaid.Name = "lblAmtPaid";
            lblAmtPaid.Size = new Size(321, 39);
            lblAmtPaid.TabIndex = 4;
            lblAmtPaid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            lblTotalFees.Location = new Point(36, 182);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(200, 33);
            lblTotalFees.TabIndex = 3;
            lblTotalFees.Text = "Total Fees";
            lblTotalFees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFinalBalance
            // 
            lblFinalBalance.Location = new Point(20, 130);
            lblFinalBalance.Name = "lblFinalBalance";
            lblFinalBalance.Size = new Size(221, 36);
            lblFinalBalance.TabIndex = 2;
            lblFinalBalance.Text = "Final Balance";
            lblFinalBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmountEarned
            // 
            lblAmountEarned.Location = new Point(36, 84);
            lblAmountEarned.Name = "lblAmountEarned";
            lblAmountEarned.Size = new Size(200, 37);
            lblAmountEarned.TabIndex = 1;
            lblAmountEarned.Text = "Amount Earned";
            lblAmountEarned.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.Location = new Point(36, 38);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(205, 39);
            lblAmountPaid.TabIndex = 0;
            lblAmountPaid.Text = "Amount Paid";
            lblAmountPaid.TextAlign = ContentAlignment.MiddleCenter;
            lblAmountPaid.Click += lblAmountPaid_Click;
            // 
            // grpSavingCal
            // 
            grpSavingCal.Controls.Add(grpFutureValue);
            grpSavingCal.Controls.Add(btnCalSaving);
            grpSavingCal.Controls.Add(grpSavingPlan);
            grpSavingCal.Location = new Point(817, 12);
            grpSavingCal.Name = "grpSavingCal";
            grpSavingCal.Size = new Size(657, 607);
            grpSavingCal.TabIndex = 24;
            grpSavingCal.TabStop = false;
            // 
            // grpBMICal
            // 
            grpBMICal.Controls.Add(grpBMICalculator);
            grpBMICal.Controls.Add(lblLowandHighWeight);
            grpBMICal.Controls.Add(lblNormalWeight);
            grpBMICal.Controls.Add(grpResult);
            grpBMICal.Controls.Add(grpUnit);
            grpBMICal.Controls.Add(lblNormalBMI);
            grpBMICal.Controls.Add(btnCalculate);
            grpBMICal.Location = new Point(15, 12);
            grpBMICal.Name = "grpBMICal";
            grpBMICal.Size = new Size(773, 594);
            grpBMICal.TabIndex = 25;
            grpBMICal.TabStop = false;
            grpBMICal.Enter += grpBMICal_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalculateBMR);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(lblAge);
            groupBox1.Controls.Add(listBoxBMRCal);
            groupBox1.Controls.Add(grpActivityLevel);
            groupBox1.Controls.Add(grpGender);
            groupBox1.Location = new Point(12, 635);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1465, 337);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "BMR Calculator";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // btnCalculateBMR
            // 
            btnCalculateBMR.Location = new Point(194, 251);
            btnCalculateBMR.Name = "btnCalculateBMR";
            btnCalculateBMR.Size = new Size(412, 44);
            btnCalculateBMR.TabIndex = 5;
            btnCalculateBMR.Text = "Calculate BMR";
            btnCalculateBMR.UseVisualStyleBackColor = true;
            btnCalculateBMR.Click += btnCalculateBMR_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(97, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(102, 31);
            txtAge.TabIndex = 4;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(34, 168);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(57, 35);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // listBoxBMRCal
            // 
            listBoxBMRCal.FormattingEnabled = true;
            listBoxBMRCal.ItemHeight = 25;
            listBoxBMRCal.Location = new Point(641, 45);
            listBoxBMRCal.Name = "listBoxBMRCal";
            listBoxBMRCal.Size = new Size(716, 229);
            listBoxBMRCal.TabIndex = 2;
            // 
            // grpActivityLevel
            // 
            grpActivityLevel.Controls.Add(rbtnExtraActive);
            grpActivityLevel.Controls.Add(rbtnVeryActive);
            grpActivityLevel.Controls.Add(rbtnModeratelyActive);
            grpActivityLevel.Controls.Add(rbtnLightlyActive);
            grpActivityLevel.Controls.Add(rbtnSedentary);
            grpActivityLevel.Location = new Point(252, 22);
            grpActivityLevel.Name = "grpActivityLevel";
            grpActivityLevel.Size = new Size(354, 223);
            grpActivityLevel.TabIndex = 1;
            grpActivityLevel.TabStop = false;
            grpActivityLevel.Text = "Weekly Activity Level";
            // 
            // rbtnExtraActive
            // 
            rbtnExtraActive.AutoSize = true;
            rbtnExtraActive.Location = new Point(25, 179);
            rbtnExtraActive.Name = "rbtnExtraActive";
            rbtnExtraActive.Size = new Size(297, 29);
            rbtnExtraActive.TabIndex = 4;
            rbtnExtraActive.TabStop = true;
            rbtnExtraActive.Text = "Extra active, hard exercises or job";
            rbtnExtraActive.UseVisualStyleBackColor = true;
            // 
            // rbtnVeryActive
            // 
            rbtnVeryActive.AutoSize = true;
            rbtnVeryActive.Location = new Point(25, 144);
            rbtnVeryActive.Name = "rbtnVeryActive";
            rbtnVeryActive.Size = new Size(231, 29);
            rbtnVeryActive.TabIndex = 3;
            rbtnVeryActive.TabStop = true;
            rbtnVeryActive.Text = "Very active (3 to 5 times)";
            rbtnVeryActive.UseVisualStyleBackColor = true;
            rbtnVeryActive.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // rbtnModeratelyActive
            // 
            rbtnModeratelyActive.AutoSize = true;
            rbtnModeratelyActive.Location = new Point(25, 109);
            rbtnModeratelyActive.Name = "rbtnModeratelyActive";
            rbtnModeratelyActive.Size = new Size(287, 29);
            rbtnModeratelyActive.TabIndex = 2;
            rbtnModeratelyActive.TabStop = true;
            rbtnModeratelyActive.Text = "Moderately active (3 to 5 times)";
            rbtnModeratelyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnLightlyActive
            // 
            rbtnLightlyActive.AutoSize = true;
            rbtnLightlyActive.Location = new Point(25, 74);
            rbtnLightlyActive.Name = "rbtnLightlyActive";
            rbtnLightlyActive.Size = new Size(201, 29);
            rbtnLightlyActive.TabIndex = 1;
            rbtnLightlyActive.TabStop = true;
            rbtnLightlyActive.Text = "Lightly active (1 to 3)";
            rbtnLightlyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnSedentary
            // 
            rbtnSedentary.AutoSize = true;
            rbtnSedentary.Location = new Point(25, 39);
            rbtnSedentary.Name = "rbtnSedentary";
            rbtnSedentary.Size = new Size(278, 29);
            rbtnSedentary.TabIndex = 0;
            rbtnSedentary.TabStop = true;
            rbtnSedentary.Text = "Sedentary (little or no exercise)";
            rbtnSedentary.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbtnMale);
            grpGender.Controls.Add(rbtnFemale);
            grpGender.Location = new Point(34, 38);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(191, 122);
            grpGender.TabIndex = 0;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(19, 77);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(75, 29);
            rbtnMale.TabIndex = 1;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(19, 42);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(93, 29);
            rbtnFemale.TabIndex = 0;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 1050);
            Controls.Add(groupBox1);
            Controls.Add(grpBMICal);
            Controls.Add(grpSavingCal);
            Name = "MainForm";
            Text = "Super Calculator by";
            Load += MainForm_Load;
            grpUnit.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            grpBMICalculator.ResumeLayout(false);
            grpBMICalculator.PerformLayout();
            grpSavingPlan.ResumeLayout(false);
            grpSavingPlan.PerformLayout();
            grpFutureValue.ResumeLayout(false);
            grpSavingCal.ResumeLayout(false);
            grpBMICal.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpActivityLevel.ResumeLayout(false);
            grpActivityLevel.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtCmFt;
        private TextBox txtInch;
        private Button btnCalculate;
        private Label lblBMI;
        private Label lblWeight;
        private Label lblbmiResult;
        private Label lblWeightCat;
        private Label lblNormalBMI;
        private GroupBox grpUnit;
        private RadioButton rbtnUSCustomoryUnits;
        private RadioButton rbtnMetric;
        private GroupBox grpResult;
        private Label lblWght;
        private TextBox txtweight;
        private Label lblHeight;
        private Label lblNormalWeight;
        private Label label1;
        private Label lblLowandHighWeight;
        private GroupBox grpBMICalculator;
        private GroupBox grpSavingPlan;
        private Label lblPeriod;
        private Label lblMonthlyDeposit;
        private Label lblInitialDeposit;
        private Label blFees;
        private Label lblGrowth;
        private TextBox txtMonthlyDeposit;
        private TextBox txtInitialDeposit;
        private TextBox txtGrowth;
        private TextBox txtPeriod;
        private TextBox txtFees;
        private Button btnCalSaving;
        private GroupBox grpFutureValue;
        private Label lblAmountPaid;
        private Label lblFinalBalance;
        private Label lblAmountEarned;
        private Label lblTotalFees;
        private Label lblTltFee;
        private Label lblFnlBalance;
        private Label lblAmtEarned;
        private Label lblAmtPaid;
        private GroupBox grpSavingCal;
        private GroupBox grpBMICal;
        private GroupBox groupBox1;
        private GroupBox grpGender;
        private ListBox listBoxBMRCal;
        private GroupBox grpActivityLevel;
        private RadioButton rbtnFemale;
        private RadioButton rbtnExtraActive;
        private RadioButton rbtnVeryActive;
        private RadioButton rbtnModeratelyActive;
        private RadioButton rbtnLightlyActive;
        private RadioButton rbtnSedentary;
        private RadioButton rbtnMale;
        private Button btnCalculateBMR;
        private TextBox txtAge;
        private Label lblAge;
    }
}
