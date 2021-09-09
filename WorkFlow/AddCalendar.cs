using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;

namespace WorkFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newCalendarName = this.textBox1.Text.ToString();


            MAPIFolder primaryCalendar = (Microsoft.Office.Interop.Outlook.MAPIFolder)
                Globals.ThisAddIn.Application.ActiveExplorer().Session.GetDefaultFolder(OlDefaultFolders.olFolderCalendar);

            bool isNew = false;

            foreach (MAPIFolder personalCalendar
                in primaryCalendar.Folders)
            {
                if (personalCalendar.Name == newCalendarName)
                {
                    isNew = true;
                    break;
                }
            }
            if (!isNew)
            {
                MAPIFolder personalCalendar = primaryCalendar
                    .Folders.Add(newCalendarName, OlDefaultFolders.olFolderCalendar);

                Globals.ThisAddIn.Application.ActiveExplorer().SelectFolder(primaryCalendar
                    .Folders[newCalendarName]);
                Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder.Display();

                //AppointmentItem newEvent =
                //    personalCalendar.Items.Add
                //    (OlItemType.olAppointmentItem)
                //    as AppointmentItem;
                //newEvent.Start = DateTime.Now.AddHours(1);
                //newEvent.End = DateTime.Now.AddHours(10);
                //newEvent.Subject = "New plan";
                //newEvent.Body = " Meet to discuss new plan.";
                //newEvent.Save();

                this.label2.Hide();
                this.Hide();
            }
            else
            {
                this.label2.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
