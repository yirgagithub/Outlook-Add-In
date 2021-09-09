using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlow
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();

            if (this.singleEventChBx.Checked)
            {
                this.recurrencyEventBox.Hide();
            }
            if (this.weeklyRRB.Checked)
            {
                this.weeklyGBX.Show();
                this.monthlyGBX.Hide();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveAddEventBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String subject = this.eventNameTb.Text.ToString();
                String body = this.eventSubTb.Text.ToString();

                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();

                MAPIFolder currentCalendar = Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder;
                AppointmentItem newEvent = currentCalendar.Items.Add(OlItemType.olAppointmentItem) as AppointmentItem;

                if (this.singleEventChBx.Checked)
                {
                    startDate = this.startDateDP.Value.Date.AddHours(this.startTimeDP.Value.TimeOfDay.TotalHours);
                    endDate = this.endDateDP.Value.Date.AddHours(this.endTimeDP.Value.TimeOfDay.TotalHours);

                    newEvent.Start = startDate;
                    newEvent.End = endDate;
                }
                else
                {
                    RecurrencePattern pattern = newEvent.GetRecurrencePattern();

                    //recurrence type
                    if (this.dailyRRB.Checked)
                    {
                        pattern.RecurrenceType = OlRecurrenceType.olRecursDaily;

                    }
                    else if (this.weeklyRRB.Checked)
                    {
                        pattern.RecurrenceType = OlRecurrenceType.olRecursWeekly;
                        pattern.DayOfWeekMask = getCheckedDays();
                    }
                    else if (this.monthlyRRB.Checked)
                    {
                        pattern.RecurrenceType = OlRecurrenceType.olRecursMonthly;
                        pattern.DayOfMonth = int.Parse(this.onDayWeeklyTb.Text.ToString());
                    }
                    else if (this.yearlyRRB.Checked)
                    {
                        pattern.RecurrenceType = OlRecurrenceType.olRecursYearly;
                        pattern.MonthOfYear = int.Parse(this.onDayWeeklyTb.Text.ToString());
                        pattern.DayOfMonth = int.Parse(this.onDayWeeklyTb.Text.ToString());
                    }


                    startDate = this.startDateRangeDP.Value;
                    endDate = this.endDateRangeDP.Value;

                    pattern.PatternStartDate = startDate;
                    pattern.PatternEndDate = endDate;

                    pattern.StartTime = this.startTimeRDP.Value;
                    pattern.EndTime = this.endTimeRDP.Value;
                    pattern.Duration = (int)(this.endTimeRDP.Value.TimeOfDay.TotalHours - this.startTimeRDP.Value.TimeOfDay.TotalHours);

                    pattern.Interval = int.Parse(this.recurrencyEveryTb.Text.ToString());
                }


                newEvent.Subject = subject;
                newEvent.Body = body;
                newEvent.Save();

                this.Hide();
            }
            catch(ArgumentNullException argumentsNullException)
            {
                Debug.WriteLine("Exception on add event " + argumentsNullException.Message);
            }
            catch(FormatException formatException)
            {
                Debug.WriteLine("Exception on add event " + formatException.Message);
            }
            catch (System.Exception exception)
            {
                Debug.WriteLine("Exception on add event " + exception.Message);
            }
        }

        private OlDaysOfWeek getCheckedDays()
        {
            OlDaysOfWeek olDaysOfWeek = 0;
            if (this.sundayChBx.Checked)
            {
                olDaysOfWeek = OlDaysOfWeek.olSunday;
            }
            if(this.mondayChBx.Checked){
                olDaysOfWeek = olDaysOfWeek  != 0 ? olDaysOfWeek | OlDaysOfWeek.olMonday : OlDaysOfWeek.olMonday ;
            }
            if (this.tuesdayChBx.Checked)
            {
                olDaysOfWeek = olDaysOfWeek != 0 ? olDaysOfWeek | OlDaysOfWeek.olTuesday : OlDaysOfWeek.olTuesday;
            }
            if (this.wednesdayChBx.Checked)
            {
                olDaysOfWeek = olDaysOfWeek != 0 ? olDaysOfWeek | OlDaysOfWeek.olWednesday : OlDaysOfWeek.olWednesday;
            }
            if (this.thursdayChBx.Checked)
            {
                olDaysOfWeek = olDaysOfWeek != 0 ? olDaysOfWeek | OlDaysOfWeek.olThursday : OlDaysOfWeek.olThursday;
            }
            if (this.fridayChBx.Checked)
            {
                olDaysOfWeek = olDaysOfWeek != 0 ? olDaysOfWeek | OlDaysOfWeek.olFriday : OlDaysOfWeek.olFriday;
            }
            if (this.saturedayChBx.Checked)
            {
                olDaysOfWeek = olDaysOfWeek != 0 ? olDaysOfWeek | OlDaysOfWeek.olSaturday : OlDaysOfWeek.olSaturday;
            }

            return olDaysOfWeek;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.singleEventBox.Show();
            this.label2.Show();
            this.label3.Show();
            this.recurrencyEventBox.Hide();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.singleEventBox.Hide();
            this.label2.Hide();
            this.label3.Hide();
            this.recurrencyEventBox.Show();
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void weeklyRRB_CheckedChanged(object sender, EventArgs e)
        {
            this.weeklyGBX.Show();
            this.monthlyGBX.Hide();
        }

        private void monthlyRRB_CheckedChanged(object sender, EventArgs e)
        {
            this.weeklyGBX.Hide();
            this.monthlyGBX.Show();
            this.onMonthLV.Hide();
        }

        private void yearlyRRB_CheckedChanged(object sender, EventArgs e)
        {
            this.weeklyGBX.Hide();
            this.monthlyGBX.Show();
            this.onMonthLV.Show();
        }

        private void onRangeRB_CheckedChanged(object sender, EventArgs e)
        {
            this.endDateRangeDP.Visible = true;
            this.endAfterRangeTb.Visible = false;
        }

        private void endAfterRangeRB_CheckedChanged(object sender, EventArgs e)
        {
            this.endAfterRangeTb.Visible = true;
            this.endDateRangeDP.Visible = false;
        }

        private void neverRangeRB_CheckedChanged(object sender, EventArgs e)
        {
            this.endAfterRangeTb.Visible = false;
            this.endDateRangeDP.Visible = false;
        }

        private void dailyRRB_CheckedChanged(object sender, EventArgs e)
        {
            this.weeklyGBX.Hide();
            this.monthlyGBX.Hide();
            this.onMonthLV.Hide();
        }

        private void sundayChBx_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
