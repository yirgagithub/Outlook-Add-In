
namespace WorkFlow
{
    partial class WorkFlowRibbonMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WorkFlowRibbonMenu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.flawlessribbon = this.Factory.CreateRibbonGroup();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.flawlessribbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabCalendar";
            this.tab1.Groups.Add(this.flawlessribbon);
            this.tab1.Label = "TabCalendar";
            this.tab1.Name = "tab1";
            // 
            // flawlessribbon
            // 
            this.flawlessribbon.Items.Add(this.menu1);
            this.flawlessribbon.Label = "Flawless";
            this.flawlessribbon.Name = "flawlessribbon";
            // 
            // menu1
            // 
            this.menu1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu1.Dynamic = true;
            this.menu1.Items.Add(this.button1);
            this.menu1.Items.Add(this.button3);
            this.menu1.Items.Add(this.button2);
            this.menu1.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu1.Label = "workflow";
            this.menu1.Name = "menu1";
            this.menu1.OfficeImageId = "BroadcastFromCurrent";
            this.menu1.ShowImage = true;
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Label = "Add Calendar";
            this.button1.Name = "button1";
            this.button1.OfficeImageId = "SmartArtAddShape";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CustomCalendar_Click);
            // 
            // button3
            // 
            this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button3.Label = "Add Event";
            this.button3.Name = "button3";
            this.button3.OfficeImageId = "CongratulatoryEvent";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Label = "Export To Excel";
            this.button2.Name = "button2";
            this.button2.OfficeImageId = "PivotExportToExcel";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ExportExcel_Click);
            // 
            // WorkFlowRibbonMenu
            // 
            this.Name = "WorkFlowRibbonMenu";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WorkFlowRibbonMenu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.flawlessribbon.ResumeLayout(false);
            this.flawlessribbon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup flawlessribbon;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
    }

    partial class ThisRibbonCollection
    {
        internal WorkFlowRibbonMenu WorkFlowRibbonMenu
        {
            get { return this.GetRibbon<WorkFlowRibbonMenu>(); }
        }
    }
}
