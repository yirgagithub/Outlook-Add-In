
using System.Windows.Forms;

namespace WorkFlow
{
    partial class AddEvent
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
            this.eventNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveAddEventBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.eventSubTb = new System.Windows.Forms.TextBox();
            this.singleEventChBx = new System.Windows.Forms.RadioButton();
            this.recurrenceChBx = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.singleEventBox = new System.Windows.Forms.GroupBox();
            this.startDateDP = new System.Windows.Forms.DateTimePicker();
            this.endDateDP = new System.Windows.Forms.DateTimePicker();
            this.startTimeDP = new System.Windows.Forms.DateTimePicker();
            this.endTimeDP = new System.Windows.Forms.DateTimePicker();
            this.recurrencyEventBox = new System.Windows.Forms.GroupBox();
            this.rangeBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.endAfterRangeTb = new System.Windows.Forms.TextBox();
            this.endDateRangeDP = new System.Windows.Forms.DateTimePicker();
            this.endAfterRangeRB = new System.Windows.Forms.RadioButton();
            this.neverRangeRB = new System.Windows.Forms.RadioButton();
            this.onRangeRB = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.startDateRangeDP = new System.Windows.Forms.DateTimePicker();
            this.patterRBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.weeklyGBX = new System.Windows.Forms.GroupBox();
            this.saturedayChBx = new System.Windows.Forms.CheckBox();
            this.fridayChBx = new System.Windows.Forms.CheckBox();
            this.thursdayChBx = new System.Windows.Forms.CheckBox();
            this.wednesdayChBx = new System.Windows.Forms.CheckBox();
            this.tuesdayChBx = new System.Windows.Forms.CheckBox();
            this.mondayChBx = new System.Windows.Forms.CheckBox();
            this.sundayChBx = new System.Windows.Forms.CheckBox();
            this.monthlyGBX = new System.Windows.Forms.GroupBox();
            this.onMonthLV = new System.Windows.Forms.TextBox();
            this.onDayWeeklyTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.recurrencyEveryTb = new System.Windows.Forms.TextBox();
            this.yearlyRRB = new System.Windows.Forms.RadioButton();
            this.monthlyRRB = new System.Windows.Forms.RadioButton();
            this.weeklyRRB = new System.Windows.Forms.RadioButton();
            this.dailyRRB = new System.Windows.Forms.RadioButton();
            this.eventTimeRBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endTimeRDP = new System.Windows.Forms.DateTimePicker();
            this.startTimeRDP = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.singleEventBox.SuspendLayout();
            this.recurrencyEventBox.SuspendLayout();
            this.rangeBox.SuspendLayout();
            this.patterRBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.weeklyGBX.SuspendLayout();
            this.monthlyGBX.SuspendLayout();
            this.eventTimeRBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event";
            // 
            // eventNameTb
            // 
            this.eventNameTb.Location = new System.Drawing.Point(122, 19);
            this.eventNameTb.Name = "eventNameTb";
            this.eventNameTb.Size = new System.Drawing.Size(435, 20);
            this.eventNameTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End time";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(559, 7);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(84, 30);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveAddEventBtn
            // 
            this.saveAddEventBtn.Location = new System.Drawing.Point(442, 7);
            this.saveAddEventBtn.Name = "saveAddEventBtn";
            this.saveAddEventBtn.Size = new System.Drawing.Size(84, 30);
            this.saveAddEventBtn.TabIndex = 7;
            this.saveAddEventBtn.Text = "Save";
            this.saveAddEventBtn.UseVisualStyleBackColor = true;
            this.saveAddEventBtn.Click += new System.EventHandler(this.saveAddEventBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event Subject";
            // 
            // eventSubTb
            // 
            this.eventSubTb.Location = new System.Drawing.Point(122, 48);
            this.eventSubTb.Name = "eventSubTb";
            this.eventSubTb.Size = new System.Drawing.Size(435, 20);
            this.eventSubTb.TabIndex = 11;
            // 
            // singleEventChBx
            // 
            this.singleEventChBx.AutoSize = true;
            this.singleEventChBx.Checked = true;
            this.singleEventChBx.Location = new System.Drawing.Point(122, 83);
            this.singleEventChBx.Name = "singleEventChBx";
            this.singleEventChBx.Size = new System.Drawing.Size(85, 17);
            this.singleEventChBx.TabIndex = 12;
            this.singleEventChBx.TabStop = true;
            this.singleEventChBx.Text = "Single Event";
            this.singleEventChBx.UseVisualStyleBackColor = true;
            this.singleEventChBx.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // recurrenceChBx
            // 
            this.recurrenceChBx.AutoSize = true;
            this.recurrenceChBx.Location = new System.Drawing.Point(257, 85);
            this.recurrenceChBx.Name = "recurrenceChBx";
            this.recurrenceChBx.Size = new System.Drawing.Size(106, 17);
            this.recurrenceChBx.TabIndex = 13;
            this.recurrenceChBx.TabStop = true;
            this.recurrenceChBx.Text = "Recurrece Event";
            this.recurrenceChBx.UseVisualStyleBackColor = true;
            this.recurrenceChBx.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Event Type";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.singleEventBox);
            this.flowLayoutPanel1.Controls.Add(this.recurrencyEventBox);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 545);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // singleEventBox
            // 
            this.singleEventBox.Controls.Add(this.startDateDP);
            this.singleEventBox.Controls.Add(this.label3);
            this.singleEventBox.Controls.Add(this.endDateDP);
            this.singleEventBox.Controls.Add(this.startTimeDP);
            this.singleEventBox.Controls.Add(this.endTimeDP);
            this.singleEventBox.Controls.Add(this.label2);
            this.singleEventBox.Location = new System.Drawing.Point(3, 3);
            this.singleEventBox.Name = "singleEventBox";
            this.singleEventBox.Size = new System.Drawing.Size(643, 106);
            this.singleEventBox.TabIndex = 15;
            this.singleEventBox.TabStop = false;
            // 
            // startDateDP
            // 
            this.startDateDP.Location = new System.Drawing.Point(119, 19);
            this.startDateDP.Name = "startDateDP";
            this.startDateDP.Size = new System.Drawing.Size(241, 20);
            this.startDateDP.TabIndex = 3;
            // 
            // endDateDP
            // 
            this.endDateDP.Location = new System.Drawing.Point(119, 67);
            this.endDateDP.Name = "endDateDP";
            this.endDateDP.Size = new System.Drawing.Size(244, 20);
            this.endDateDP.TabIndex = 5;
            // 
            // startTimeDP
            // 
            this.startTimeDP.CustomFormat = "hh:mm:ss";
            this.startTimeDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeDP.Location = new System.Drawing.Point(432, 19);
            this.startTimeDP.Name = "startTimeDP";
            this.startTimeDP.Size = new System.Drawing.Size(122, 20);
            this.startTimeDP.TabIndex = 8;
            // 
            // endTimeDP
            // 
            this.endTimeDP.CustomFormat = "hh:mm:ss";
            this.endTimeDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeDP.Location = new System.Drawing.Point(432, 67);
            this.endTimeDP.Name = "endTimeDP";
            this.endTimeDP.Size = new System.Drawing.Size(122, 20);
            this.endTimeDP.TabIndex = 9;
            // 
            // recurrencyEventBox
            // 
            this.recurrencyEventBox.Controls.Add(this.rangeBox);
            this.recurrencyEventBox.Controls.Add(this.patterRBox);
            this.recurrencyEventBox.Controls.Add(this.eventTimeRBox);
            this.recurrencyEventBox.Location = new System.Drawing.Point(3, 115);
            this.recurrencyEventBox.Name = "recurrencyEventBox";
            this.recurrencyEventBox.Size = new System.Drawing.Size(643, 371);
            this.recurrencyEventBox.TabIndex = 16;
            this.recurrencyEventBox.TabStop = false;
            this.recurrencyEventBox.Text = "Recurrence";
            // 
            // rangeBox
            // 
            this.rangeBox.Controls.Add(this.label11);
            this.rangeBox.Controls.Add(this.endAfterRangeTb);
            this.rangeBox.Controls.Add(this.endDateRangeDP);
            this.rangeBox.Controls.Add(this.endAfterRangeRB);
            this.rangeBox.Controls.Add(this.neverRangeRB);
            this.rangeBox.Controls.Add(this.onRangeRB);
            this.rangeBox.Controls.Add(this.label10);
            this.rangeBox.Controls.Add(this.startDateRangeDP);
            this.rangeBox.Location = new System.Drawing.Point(13, 263);
            this.rangeBox.Name = "rangeBox";
            this.rangeBox.Size = new System.Drawing.Size(624, 102);
            this.rangeBox.TabIndex = 2;
            this.rangeBox.TabStop = false;
            this.rangeBox.Text = "Range";
            this.rangeBox.Enter += new System.EventHandler(this.groupBox5_Enter_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "End";
            // 
            // endAfterRangeTb
            // 
            this.endAfterRangeTb.Location = new System.Drawing.Point(370, 54);
            this.endAfterRangeTb.Name = "endAfterRangeTb";
            this.endAfterRangeTb.Size = new System.Drawing.Size(171, 20);
            this.endAfterRangeTb.TabIndex = 6;
            this.endAfterRangeTb.Visible = false;
            // 
            // endDateRangeDP
            // 
            this.endDateRangeDP.Location = new System.Drawing.Point(370, 28);
            this.endDateRangeDP.Name = "endDateRangeDP";
            this.endDateRangeDP.Size = new System.Drawing.Size(171, 20);
            this.endDateRangeDP.TabIndex = 5;
            this.endDateRangeDP.Visible = false;
            // 
            // endAfterRangeRB
            // 
            this.endAfterRangeRB.AutoSize = true;
            this.endAfterRangeRB.Location = new System.Drawing.Point(295, 54);
            this.endAfterRangeRB.Name = "endAfterRangeRB";
            this.endAfterRangeRB.Size = new System.Drawing.Size(69, 17);
            this.endAfterRangeRB.TabIndex = 4;
            this.endAfterRangeRB.TabStop = true;
            this.endAfterRangeRB.Text = "End After";
            this.endAfterRangeRB.UseVisualStyleBackColor = true;
            this.endAfterRangeRB.CheckedChanged += new System.EventHandler(this.endAfterRangeRB_CheckedChanged);
            // 
            // neverRangeRB
            // 
            this.neverRangeRB.AutoSize = true;
            this.neverRangeRB.Location = new System.Drawing.Point(296, 77);
            this.neverRangeRB.Name = "neverRangeRB";
            this.neverRangeRB.Size = new System.Drawing.Size(54, 17);
            this.neverRangeRB.TabIndex = 3;
            this.neverRangeRB.TabStop = true;
            this.neverRangeRB.Text = "Never";
            this.neverRangeRB.UseVisualStyleBackColor = true;
            this.neverRangeRB.CheckedChanged += new System.EventHandler(this.neverRangeRB_CheckedChanged);
            // 
            // onRangeRB
            // 
            this.onRangeRB.AutoSize = true;
            this.onRangeRB.Location = new System.Drawing.Point(296, 28);
            this.onRangeRB.Name = "onRangeRB";
            this.onRangeRB.Size = new System.Drawing.Size(39, 17);
            this.onRangeRB.TabIndex = 2;
            this.onRangeRB.TabStop = true;
            this.onRangeRB.Text = "On";
            this.onRangeRB.UseVisualStyleBackColor = true;
            this.onRangeRB.CheckedChanged += new System.EventHandler(this.onRangeRB_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Start Date";
            // 
            // startDateRangeDP
            // 
            this.startDateRangeDP.Location = new System.Drawing.Point(9, 42);
            this.startDateRangeDP.Name = "startDateRangeDP";
            this.startDateRangeDP.Size = new System.Drawing.Size(172, 20);
            this.startDateRangeDP.TabIndex = 0;
            // 
            // patterRBox
            // 
            this.patterRBox.Controls.Add(this.flowLayoutPanel2);
            this.patterRBox.Controls.Add(this.label8);
            this.patterRBox.Controls.Add(this.recurrencyEveryTb);
            this.patterRBox.Controls.Add(this.yearlyRRB);
            this.patterRBox.Controls.Add(this.monthlyRRB);
            this.patterRBox.Controls.Add(this.weeklyRRB);
            this.patterRBox.Controls.Add(this.dailyRRB);
            this.patterRBox.Location = new System.Drawing.Point(13, 80);
            this.patterRBox.Name = "patterRBox";
            this.patterRBox.Size = new System.Drawing.Size(624, 177);
            this.patterRBox.TabIndex = 1;
            this.patterRBox.TabStop = false;
            this.patterRBox.Text = "Pattern";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.weeklyGBX);
            this.flowLayoutPanel2.Controls.Add(this.monthlyGBX);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 42);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(602, 126);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // weeklyGBX
            // 
            this.weeklyGBX.Controls.Add(this.saturedayChBx);
            this.weeklyGBX.Controls.Add(this.fridayChBx);
            this.weeklyGBX.Controls.Add(this.thursdayChBx);
            this.weeklyGBX.Controls.Add(this.wednesdayChBx);
            this.weeklyGBX.Controls.Add(this.tuesdayChBx);
            this.weeklyGBX.Controls.Add(this.mondayChBx);
            this.weeklyGBX.Controls.Add(this.sundayChBx);
            this.weeklyGBX.Location = new System.Drawing.Point(3, 3);
            this.weeklyGBX.Name = "weeklyGBX";
            this.weeklyGBX.Size = new System.Drawing.Size(593, 73);
            this.weeklyGBX.TabIndex = 0;
            this.weeklyGBX.TabStop = false;
            // 
            // saturedayChBx
            // 
            this.saturedayChBx.AutoSize = true;
            this.saturedayChBx.Location = new System.Drawing.Point(307, 50);
            this.saturedayChBx.Name = "saturedayChBx";
            this.saturedayChBx.Size = new System.Drawing.Size(74, 17);
            this.saturedayChBx.TabIndex = 6;
            this.saturedayChBx.Text = "Satureday";
            this.saturedayChBx.UseVisualStyleBackColor = true;
            // 
            // fridayChBx
            // 
            this.fridayChBx.AutoSize = true;
            this.fridayChBx.Location = new System.Drawing.Point(185, 50);
            this.fridayChBx.Name = "fridayChBx";
            this.fridayChBx.Size = new System.Drawing.Size(54, 17);
            this.fridayChBx.TabIndex = 5;
            this.fridayChBx.Text = "Friday";
            this.fridayChBx.UseVisualStyleBackColor = true;
            // 
            // thursdayChBx
            // 
            this.thursdayChBx.AutoSize = true;
            this.thursdayChBx.Location = new System.Drawing.Point(76, 50);
            this.thursdayChBx.Name = "thursdayChBx";
            this.thursdayChBx.Size = new System.Drawing.Size(70, 17);
            this.thursdayChBx.TabIndex = 4;
            this.thursdayChBx.Text = "Thursday";
            this.thursdayChBx.UseVisualStyleBackColor = true;
            // 
            // wednesdayChBx
            // 
            this.wednesdayChBx.AutoSize = true;
            this.wednesdayChBx.Location = new System.Drawing.Point(412, 19);
            this.wednesdayChBx.Name = "wednesdayChBx";
            this.wednesdayChBx.Size = new System.Drawing.Size(83, 17);
            this.wednesdayChBx.TabIndex = 3;
            this.wednesdayChBx.Text = "Wednesday";
            this.wednesdayChBx.UseVisualStyleBackColor = true;
            // 
            // tuesdayChBx
            // 
            this.tuesdayChBx.AutoSize = true;
            this.tuesdayChBx.Location = new System.Drawing.Point(307, 19);
            this.tuesdayChBx.Name = "tuesdayChBx";
            this.tuesdayChBx.Size = new System.Drawing.Size(67, 17);
            this.tuesdayChBx.TabIndex = 2;
            this.tuesdayChBx.Text = "Tuesday";
            this.tuesdayChBx.UseVisualStyleBackColor = true;
            // 
            // mondayChBx
            // 
            this.mondayChBx.AutoSize = true;
            this.mondayChBx.Location = new System.Drawing.Point(185, 19);
            this.mondayChBx.Name = "mondayChBx";
            this.mondayChBx.Size = new System.Drawing.Size(64, 17);
            this.mondayChBx.TabIndex = 1;
            this.mondayChBx.Text = "Monday";
            this.mondayChBx.UseVisualStyleBackColor = true;
            // 
            // sundayChBx
            // 
            this.sundayChBx.AutoSize = true;
            this.sundayChBx.Location = new System.Drawing.Point(76, 19);
            this.sundayChBx.Name = "sundayChBx";
            this.sundayChBx.Size = new System.Drawing.Size(62, 17);
            this.sundayChBx.TabIndex = 0;
            this.sundayChBx.Text = "Sunday";
            this.sundayChBx.UseVisualStyleBackColor = true;
            this.sundayChBx.CheckedChanged += new System.EventHandler(this.sundayChBx_CheckedChanged);
            // 
            // monthlyGBX
            // 
            this.monthlyGBX.Controls.Add(this.onMonthLV);
            this.monthlyGBX.Controls.Add(this.onDayWeeklyTb);
            this.monthlyGBX.Controls.Add(this.label9);
            this.monthlyGBX.Location = new System.Drawing.Point(3, 82);
            this.monthlyGBX.Name = "monthlyGBX";
            this.monthlyGBX.Size = new System.Drawing.Size(593, 37);
            this.monthlyGBX.TabIndex = 1;
            this.monthlyGBX.TabStop = false;
            // 
            // onMonthLV
            // 
            this.onMonthLV.Location = new System.Drawing.Point(402, 11);
            this.onMonthLV.Name = "onMonthLV";
            this.onMonthLV.Size = new System.Drawing.Size(122, 20);
            this.onMonthLV.TabIndex = 2;
            // 
            // onDayWeeklyTb
            // 
            this.onDayWeeklyTb.Location = new System.Drawing.Point(93, 12);
            this.onDayWeeklyTb.Name = "onDayWeeklyTb";
            this.onDayWeeklyTb.Size = new System.Drawing.Size(217, 20);
            this.onDayWeeklyTb.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "On";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Every";
            // 
            // recurrencyEveryTb
            // 
            this.recurrencyEveryTb.Location = new System.Drawing.Point(419, 19);
            this.recurrencyEveryTb.Name = "recurrencyEveryTb";
            this.recurrencyEveryTb.Size = new System.Drawing.Size(122, 20);
            this.recurrencyEveryTb.TabIndex = 4;
            this.recurrencyEveryTb.Text = "1";
            // 
            // yearlyRRB
            // 
            this.yearlyRRB.AutoSize = true;
            this.yearlyRRB.Location = new System.Drawing.Point(293, 17);
            this.yearlyRRB.Name = "yearlyRRB";
            this.yearlyRRB.Size = new System.Drawing.Size(54, 17);
            this.yearlyRRB.TabIndex = 3;
            this.yearlyRRB.TabStop = true;
            this.yearlyRRB.Text = "Yearly";
            this.yearlyRRB.UseVisualStyleBackColor = true;
            this.yearlyRRB.CheckedChanged += new System.EventHandler(this.yearlyRRB_CheckedChanged);
            // 
            // monthlyRRB
            // 
            this.monthlyRRB.AutoSize = true;
            this.monthlyRRB.Location = new System.Drawing.Point(225, 17);
            this.monthlyRRB.Name = "monthlyRRB";
            this.monthlyRRB.Size = new System.Drawing.Size(62, 17);
            this.monthlyRRB.TabIndex = 2;
            this.monthlyRRB.TabStop = true;
            this.monthlyRRB.Text = "Monthly";
            this.monthlyRRB.UseVisualStyleBackColor = true;
            this.monthlyRRB.CheckedChanged += new System.EventHandler(this.monthlyRRB_CheckedChanged);
            // 
            // weeklyRRB
            // 
            this.weeklyRRB.AutoSize = true;
            this.weeklyRRB.Checked = true;
            this.weeklyRRB.Location = new System.Drawing.Point(147, 17);
            this.weeklyRRB.Name = "weeklyRRB";
            this.weeklyRRB.Size = new System.Drawing.Size(61, 17);
            this.weeklyRRB.TabIndex = 1;
            this.weeklyRRB.TabStop = true;
            this.weeklyRRB.Text = "Weekly";
            this.weeklyRRB.UseVisualStyleBackColor = true;
            this.weeklyRRB.CheckedChanged += new System.EventHandler(this.weeklyRRB_CheckedChanged);
            // 
            // dailyRRB
            // 
            this.dailyRRB.AutoSize = true;
            this.dailyRRB.Location = new System.Drawing.Point(93, 17);
            this.dailyRRB.Name = "dailyRRB";
            this.dailyRRB.Size = new System.Drawing.Size(48, 17);
            this.dailyRRB.TabIndex = 0;
            this.dailyRRB.TabStop = true;
            this.dailyRRB.Text = "Daily";
            this.dailyRRB.UseVisualStyleBackColor = true;
            this.dailyRRB.CheckedChanged += new System.EventHandler(this.dailyRRB_CheckedChanged);
            // 
            // eventTimeRBox
            // 
            this.eventTimeRBox.Controls.Add(this.label7);
            this.eventTimeRBox.Controls.Add(this.label6);
            this.eventTimeRBox.Controls.Add(this.endTimeRDP);
            this.eventTimeRBox.Controls.Add(this.startTimeRDP);
            this.eventTimeRBox.Location = new System.Drawing.Point(13, 19);
            this.eventTimeRBox.Name = "eventTimeRBox";
            this.eventTimeRBox.Size = new System.Drawing.Size(624, 55);
            this.eventTimeRBox.TabIndex = 0;
            this.eventTimeRBox.TabStop = false;
            this.eventTimeRBox.Text = "Event time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Start";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "End";
            // 
            // endTimeRDP
            // 
            this.endTimeRDP.CustomFormat = "hh:mm:ss";
            this.endTimeRDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeRDP.Location = new System.Drawing.Point(419, 17);
            this.endTimeRDP.Name = "endTimeRDP";
            this.endTimeRDP.Size = new System.Drawing.Size(122, 20);
            this.endTimeRDP.TabIndex = 1;
            // 
            // startTimeRDP
            // 
            this.startTimeRDP.CustomFormat = "hh:mm:ss";
            this.startTimeRDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeRDP.Location = new System.Drawing.Point(147, 17);
            this.startTimeRDP.Name = "startTimeRDP";
            this.startTimeRDP.Size = new System.Drawing.Size(200, 20);
            this.startTimeRDP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelBtn);
            this.groupBox2.Controls.Add(this.saveAddEventBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 37);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(98, 74);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupBox1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(93, 25);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(688, 688);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eventNameTb);
            this.groupBox1.Controls.Add(this.recurrenceChBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.singleEventChBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.eventSubTb);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 680);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "AddEvent";
            this.Text = "Add Event";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.singleEventBox.ResumeLayout(false);
            this.singleEventBox.PerformLayout();
            this.recurrencyEventBox.ResumeLayout(false);
            this.rangeBox.ResumeLayout(false);
            this.rangeBox.PerformLayout();
            this.patterRBox.ResumeLayout(false);
            this.patterRBox.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.weeklyGBX.ResumeLayout(false);
            this.weeklyGBX.PerformLayout();
            this.monthlyGBX.ResumeLayout(false);
            this.monthlyGBX.PerformLayout();
            this.eventTimeRBox.ResumeLayout(false);
            this.eventTimeRBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveAddEventBtn;
        private Label label4;
        private TextBox eventSubTb;
        private RadioButton singleEventChBx;
        private RadioButton recurrenceChBx;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox6;
        private DateTimePicker endTimeDP;
        private DateTimePicker endDateDP;
        private DateTimePicker startDateDP;
        private DateTimePicker startTimeDP;
        private GroupBox singleEventBox;
        private GroupBox recurrencyEventBox;
        private GroupBox rangeBox;
        private GroupBox patterRBox;
        private GroupBox eventTimeRBox;
        private Label label7;
        private Label label6;
        private DateTimePicker endTimeRDP;
        private DateTimePicker startTimeRDP;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox weeklyGBX;
        private CheckBox saturedayChBx;
        private CheckBox fridayChBx;
        private CheckBox thursdayChBx;
        private CheckBox wednesdayChBx;
        private CheckBox tuesdayChBx;
        private CheckBox mondayChBx;
        private CheckBox sundayChBx;
        private GroupBox monthlyGBX;
        private Label label8;
        private TextBox recurrencyEveryTb;
        private RadioButton yearlyRRB;
        private RadioButton monthlyRRB;
        private RadioButton weeklyRRB;
        private RadioButton dailyRRB;
        private TextBox endAfterRangeTb;
        private DateTimePicker endDateRangeDP;
        private RadioButton endAfterRangeRB;
        private RadioButton neverRangeRB;
        private RadioButton onRangeRB;
        private Label label10;
        private DateTimePicker startDateRangeDP;
        private TextBox onDayWeeklyTb;
        private Label label9;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox onMonthLV;
    }
}