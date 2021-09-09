using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkFlow
{
    public partial class WorkFlowRibbonMenu
    {
        private void WorkFlowRibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private void CustomCalendar_Click(object sender, RibbonControlEventArgs e)
        {

            Microsoft.Office.Interop.Outlook.Application oApp = Globals.ThisAddIn.Application;
            //NameSpace oNs = oApp.GetNamespace("MAPI");
            //MAPIFolder oInbox = oNs.GetDefaultFolder(OlDefaultFolders.olFolderInbox);
            //Items oItems = oInbox.Items;
            //MailItem oForm = oItems.Add("IPM.Note");
            //oForm.Display(false);
            //oApp.ActiveInspector().SetCurrentFormPage("FormRegion1");
            //Globals.ThisAddIn._inspectors.SetCurrentFormPage("FormRegion1");
            //MessageBox.Show("ola");

            //if (!(inspector.CurrentItem is Microsoft.Office.Interop.Outlook.TaskItem)) return;

            //var taskItem = (Microsoft.Office.Interop.Outlook.TaskItem)inspector.CurrentItem;

            //taskItem.Open += (ref bool cancel) =>
            //{
            //    try
            //    {
            //        inspector.SetCurrentFormPage("WorkFlow.FormRegion1");

            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            //};

            AddCalendar form = new AddCalendar();
            form.SetDesktopLocation(form.Width / 2, form.Height / 2);
            form.Show();


        }

        private void ExportExcel_Click(object sender, RibbonControlEventArgs e)
        {
            ExportToExcelForm exportToExcelForm = new ExportToExcelForm();
            exportToExcelForm.Show();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.SetDesktopLocation(addEvent.Height / 2, addEvent.Width / 2);
            addEvent.Show();
        }
    }
}
