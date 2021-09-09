using Microsoft.Office.Interop.Excel;
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
    public partial class ExportToExcelForm : Form
    {
        public ExportToExcelForm()
        {
            InitializeComponent();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;
                Workbook newWorkbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                
                MAPIFolder CurrentCalendar = Globals.ThisAddIn.Application.ActiveExplorer().CurrentFolder;

                Worksheet caldendarWorksheet = newWorkbook.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing) as Microsoft.Office.Interop.Excel.Worksheet;
                caldendarWorksheet.Name = CurrentCalendar.Name;
                
                caldendarWorksheet.Cells[1, "A"] = "Event Name";
                caldendarWorksheet.Cells[1, "B"] = "Event Subject";
                caldendarWorksheet.Cells[1, "C"] = "Start Date";
                caldendarWorksheet.Cells[1, "D"] = "End Date";
                caldendarWorksheet.Cells[1, "E"] = "Worked Hour";

                Items rangeAppts = GetAppointmentsInRange(CurrentCalendar);

                if (rangeAppts != null)
                {
                    //when we have a very large events date this might be a problem
                    int row = 1;
                    foreach (AppointmentItem appt in rangeAppts)
                    {
                        row++;
                        caldendarWorksheet.Cells[row, "A"] = appt.Subject;
                        caldendarWorksheet.Cells[row, "B"] = appt.Body;
                        caldendarWorksheet.Cells[row, "C"] = appt.Start.ToString("g");
                        caldendarWorksheet.Cells[row, "D"] = appt.End.ToString("g");
                        caldendarWorksheet.Cells[row, "E"] = Math.Round(appt.Duration/60.0,2) +" hour/s";
                    }
                }

                //autofix excel columns size(some columns in excel hide because of the content length)
                caldendarWorksheet.Columns[1].AutoFit();
                caldendarWorksheet.Columns[2].AutoFit();
                caldendarWorksheet.Columns[3].AutoFit();
                caldendarWorksheet.Columns[4].AutoFit();
                caldendarWorksheet.Columns[5].AutoFit();
                

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + CurrentCalendar.Name + DateTime.Now.ToFileTimeUtc() + ".xlsx";
                caldendarWorksheet.SaveAs(path, XlFileFormat.xlOpenXMLWorkbook);
                excelApp.Visible = false;
                excelApp.Quit();
                this.Hide();
            }
            catch (System.Exception exception)
            {
                // show some error to the users
                Debug.WriteLine("exception exporting to excel " + exception.Message);
            }

        }

        private Items GetAppointmentsInRange(MAPIFolder folder)
        {
            DateTime startDate = this.startDateDP.Value;
            DateTime endDate = this.endDateDP.Value;
            string filter = "[Start] >= '"+ startDate.ToString("g")+ "' AND [End] <= '"+ endDate.ToString("g") + "'";
            Debug.WriteLine(filter);
            
            try
            {
                Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }

