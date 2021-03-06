﻿namespace EIP_Lib {
   partial class Browser {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
         this.lblIPAddress = new System.Windows.Forms.Label();
         this.lblPort = new System.Windows.Forms.Label();
         this.txtIPAddress = new System.Windows.Forms.TextBox();
         this.txtPort = new System.Windows.Forms.TextBox();
         this.btnEndSession = new System.Windows.Forms.Button();
         this.btnStartSession = new System.Windows.Forms.Button();
         this.txtSessionID = new System.Windows.Forms.TextBox();
         this.lblSessionID = new System.Windows.Forms.Label();
         this.btnExit = new System.Windows.Forms.Button();
         this.btnForwardClose = new System.Windows.Forms.Button();
         this.btnForwardOpen = new System.Windows.Forms.Button();
         this.btnIssueGet = new System.Windows.Forms.Button();
         this.lblClassCode = new System.Windows.Forms.Label();
         this.cbClassCode = new System.Windows.Forms.ComboBox();
         this.lblFunction = new System.Windows.Forms.Label();
         this.cbFunction = new System.Windows.Forms.ComboBox();
         this.lbldataOut = new System.Windows.Forms.Label();
         this.txtDataBytesOut = new System.Windows.Forms.TextBox();
         this.txtStatus = new System.Windows.Forms.TextBox();
         this.lblStatus = new System.Windows.Forms.Label();
         this.txtDataOut = new System.Windows.Forms.TextBox();
         this.lblSaveFolder = new System.Windows.Forms.Label();
         this.txtSaveFolder = new System.Windows.Forms.TextBox();
         this.btnBrowse = new System.Windows.Forms.Button();
         this.btnViewTraffic = new System.Windows.Forms.Button();
         this.btnReadAll = new System.Windows.Forms.Button();
         this.tclClasses = new System.Windows.Forms.TabControl();
         this.tabIndex = new System.Windows.Forms.TabPage();
         this.tabIJPOperation = new System.Windows.Forms.TabPage();
         this.tabPrintManagement = new System.Windows.Forms.TabPage();
         this.tabPrintSpec = new System.Windows.Forms.TabPage();
         this.tabPrintFormat = new System.Windows.Forms.TabPage();
         this.tabCalendar = new System.Windows.Forms.TabPage();
         this.tabSubstitution = new System.Windows.Forms.TabPage();
         this.tabCount = new System.Windows.Forms.TabPage();
         this.tabUnitInformation = new System.Windows.Forms.TabPage();
         this.tabEnviroment = new System.Windows.Forms.TabPage();
         this.tabOpMgmt = new System.Windows.Forms.TabPage();
         this.tabUserPattern = new System.Windows.Forms.TabPage();
         this.tabXML = new System.Windows.Forms.TabPage();
         this.btnCom = new System.Windows.Forms.Button();
         this.lstErrors = new System.Windows.Forms.ListBox();
         this.cmLog = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.cmLogClear = new System.Windows.Forms.ToolStripMenuItem();
         this.cmLogView = new System.Windows.Forms.ToolStripMenuItem();
         this.btnStop = new System.Windows.Forms.Button();
         this.btnIssueSet = new System.Windows.Forms.Button();
         this.btnIssueService = new System.Windows.Forms.Button();
         this.btnManagementFlag = new System.Windows.Forms.Button();
         this.btnAutoReflection = new System.Windows.Forms.Button();
         this.txtCountOut = new System.Windows.Forms.TextBox();
         this.lblCountOut = new System.Windows.Forms.Label();
         this.btnProperties = new System.Windows.Forms.Button();
         this.lblCountIn = new System.Windows.Forms.Label();
         this.txtDataBytesIn = new System.Windows.Forms.TextBox();
         this.txtCountIn = new System.Windows.Forms.TextBox();
         this.txtDataIn = new System.Windows.Forms.TextBox();
         this.lbldataIn = new System.Windows.Forms.Label();
         this.btnReformat = new System.Windows.Forms.Button();
         this.btnRefresh = new System.Windows.Forms.Button();
         this.btnResetTraffic = new System.Windows.Forms.Button();
         this.lblSoftwareVersion = new System.Windows.Forms.Label();
         this.cbSoftwareVersion = new System.Windows.Forms.ComboBox();
         this.tclClasses.SuspendLayout();
         this.cmLog.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblIPAddress
         // 
         this.lblIPAddress.Location = new System.Drawing.Point(28, 4);
         this.lblIPAddress.Name = "lblIPAddress";
         this.lblIPAddress.Size = new System.Drawing.Size(95, 22);
         this.lblIPAddress.TabIndex = 2;
         this.lblIPAddress.Text = "IP Address";
         this.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // lblPort
         // 
         this.lblPort.Location = new System.Drawing.Point(28, 26);
         this.lblPort.Name = "lblPort";
         this.lblPort.Size = new System.Drawing.Size(95, 22);
         this.lblPort.TabIndex = 3;
         this.lblPort.Text = "Port";
         this.lblPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // txtIPAddress
         // 
         this.txtIPAddress.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtIPAddress.Location = new System.Drawing.Point(146, 4);
         this.txtIPAddress.Name = "txtIPAddress";
         this.txtIPAddress.Size = new System.Drawing.Size(175, 22);
         this.txtIPAddress.TabIndex = 4;
         this.txtIPAddress.Text = "192.168.168.100";
         this.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // txtPort
         // 
         this.txtPort.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtPort.Location = new System.Drawing.Point(146, 26);
         this.txtPort.Name = "txtPort";
         this.txtPort.Size = new System.Drawing.Size(175, 22);
         this.txtPort.TabIndex = 5;
         this.txtPort.Text = "44818";
         this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // btnEndSession
         // 
         this.btnEndSession.Location = new System.Drawing.Point(179, 118);
         this.btnEndSession.Name = "btnEndSession";
         this.btnEndSession.Size = new System.Drawing.Size(137, 31);
         this.btnEndSession.TabIndex = 7;
         this.btnEndSession.Text = "End Session";
         this.btnEndSession.UseVisualStyleBackColor = true;
         this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
         // 
         // btnStartSession
         // 
         this.btnStartSession.Location = new System.Drawing.Point(26, 118);
         this.btnStartSession.Name = "btnStartSession";
         this.btnStartSession.Size = new System.Drawing.Size(137, 31);
         this.btnStartSession.TabIndex = 6;
         this.btnStartSession.Text = "Start session";
         this.btnStartSession.UseVisualStyleBackColor = true;
         this.btnStartSession.Click += new System.EventHandler(this.btnStartSession_Click);
         // 
         // txtSessionID
         // 
         this.txtSessionID.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtSessionID.Location = new System.Drawing.Point(146, 54);
         this.txtSessionID.Name = "txtSessionID";
         this.txtSessionID.Size = new System.Drawing.Size(175, 22);
         this.txtSessionID.TabIndex = 9;
         this.txtSessionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // lblSessionID
         // 
         this.lblSessionID.Location = new System.Drawing.Point(28, 54);
         this.lblSessionID.Name = "lblSessionID";
         this.lblSessionID.Size = new System.Drawing.Size(95, 22);
         this.lblSessionID.TabIndex = 8;
         this.lblSessionID.Text = "Session ID";
         this.lblSessionID.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(1168, 565);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(89, 52);
         this.btnExit.TabIndex = 10;
         this.btnExit.Text = "Exit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // btnForwardClose
         // 
         this.btnForwardClose.Location = new System.Drawing.Point(179, 159);
         this.btnForwardClose.Name = "btnForwardClose";
         this.btnForwardClose.Size = new System.Drawing.Size(137, 31);
         this.btnForwardClose.TabIndex = 12;
         this.btnForwardClose.Text = "Fwd Close";
         this.btnForwardClose.UseVisualStyleBackColor = true;
         this.btnForwardClose.Click += new System.EventHandler(this.btnForwardClose_Click);
         // 
         // btnForwardOpen
         // 
         this.btnForwardOpen.Location = new System.Drawing.Point(26, 159);
         this.btnForwardOpen.Name = "btnForwardOpen";
         this.btnForwardOpen.Size = new System.Drawing.Size(137, 31);
         this.btnForwardOpen.TabIndex = 11;
         this.btnForwardOpen.Text = "Fwd Open";
         this.btnForwardOpen.UseVisualStyleBackColor = true;
         this.btnForwardOpen.Click += new System.EventHandler(this.btnForwardOpen_Click);
         // 
         // btnIssueGet
         // 
         this.btnIssueGet.Location = new System.Drawing.Point(26, 304);
         this.btnIssueGet.Name = "btnIssueGet";
         this.btnIssueGet.Size = new System.Drawing.Size(55, 22);
         this.btnIssueGet.TabIndex = 14;
         this.btnIssueGet.Text = "Get";
         this.btnIssueGet.UseVisualStyleBackColor = true;
         this.btnIssueGet.Visible = false;
         this.btnIssueGet.Click += new System.EventHandler(this.btnIssueGet_Click);
         // 
         // lblClassCode
         // 
         this.lblClassCode.Location = new System.Drawing.Point(26, 193);
         this.lblClassCode.Name = "lblClassCode";
         this.lblClassCode.Size = new System.Drawing.Size(293, 22);
         this.lblClassCode.TabIndex = 19;
         this.lblClassCode.Text = "Class Code";
         this.lblClassCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         // 
         // cbClassCode
         // 
         this.cbClassCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbClassCode.FormattingEnabled = true;
         this.cbClassCode.Location = new System.Drawing.Point(26, 222);
         this.cbClassCode.Name = "cbClassCode";
         this.cbClassCode.Size = new System.Drawing.Size(293, 24);
         this.cbClassCode.TabIndex = 18;
         this.cbClassCode.SelectedIndexChanged += new System.EventHandler(this.cbClassCode_SelectedIndexChanged);
         // 
         // lblFunction
         // 
         this.lblFunction.Location = new System.Drawing.Point(26, 249);
         this.lblFunction.Name = "lblFunction";
         this.lblFunction.Size = new System.Drawing.Size(293, 22);
         this.lblFunction.TabIndex = 21;
         this.lblFunction.Text = "Function Code";
         this.lblFunction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
         // 
         // cbFunction
         // 
         this.cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbFunction.FormattingEnabled = true;
         this.cbFunction.Location = new System.Drawing.Point(28, 274);
         this.cbFunction.Name = "cbFunction";
         this.cbFunction.Size = new System.Drawing.Size(293, 24);
         this.cbFunction.TabIndex = 20;
         this.cbFunction.SelectedIndexChanged += new System.EventHandler(this.cbFunction_SelectedIndexChanged);
         // 
         // lbldataOut
         // 
         this.lbldataOut.Location = new System.Drawing.Point(90, 402);
         this.lbldataOut.Name = "lbldataOut";
         this.lbldataOut.Size = new System.Drawing.Size(229, 22);
         this.lbldataOut.TabIndex = 22;
         this.lbldataOut.Text = "Data Out";
         this.lbldataOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtDataBytesOut
         // 
         this.txtDataBytesOut.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtDataBytesOut.Location = new System.Drawing.Point(28, 455);
         this.txtDataBytesOut.Name = "txtDataBytesOut";
         this.txtDataBytesOut.ReadOnly = true;
         this.txtDataBytesOut.Size = new System.Drawing.Size(288, 22);
         this.txtDataBytesOut.TabIndex = 23;
         this.txtDataBytesOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // txtStatus
         // 
         this.txtStatus.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtStatus.Location = new System.Drawing.Point(26, 377);
         this.txtStatus.Name = "txtStatus";
         this.txtStatus.ReadOnly = true;
         this.txtStatus.Size = new System.Drawing.Size(293, 22);
         this.txtStatus.TabIndex = 25;
         this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // lblStatus
         // 
         this.lblStatus.Location = new System.Drawing.Point(28, 352);
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(293, 22);
         this.lblStatus.TabIndex = 24;
         this.lblStatus.Text = "Status";
         this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtDataOut
         // 
         this.txtDataOut.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtDataOut.Location = new System.Drawing.Point(87, 427);
         this.txtDataOut.Name = "txtDataOut";
         this.txtDataOut.Size = new System.Drawing.Size(229, 22);
         this.txtDataOut.TabIndex = 26;
         this.txtDataOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // lblSaveFolder
         // 
         this.lblSaveFolder.Location = new System.Drawing.Point(164, 558);
         this.lblSaveFolder.Name = "lblSaveFolder";
         this.lblSaveFolder.Size = new System.Drawing.Size(76, 19);
         this.lblSaveFolder.TabIndex = 27;
         this.lblSaveFolder.Text = "Traffic/Log";
         this.lblSaveFolder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
         // 
         // txtSaveFolder
         // 
         this.txtSaveFolder.Location = new System.Drawing.Point(31, 553);
         this.txtSaveFolder.Name = "txtSaveFolder";
         this.txtSaveFolder.ReadOnly = true;
         this.txtSaveFolder.Size = new System.Drawing.Size(132, 22);
         this.txtSaveFolder.TabIndex = 28;
         this.txtSaveFolder.Text = "C:\\Temp\\EIP_Logs";
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(246, 556);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(66, 22);
         this.btnBrowse.TabIndex = 29;
         this.btnBrowse.Text = "Browse";
         this.btnBrowse.UseVisualStyleBackColor = true;
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // btnViewTraffic
         // 
         this.btnViewTraffic.Location = new System.Drawing.Point(883, 565);
         this.btnViewTraffic.Name = "btnViewTraffic";
         this.btnViewTraffic.Size = new System.Drawing.Size(89, 52);
         this.btnViewTraffic.TabIndex = 30;
         this.btnViewTraffic.Text = "View Traffic";
         this.btnViewTraffic.UseVisualStyleBackColor = true;
         this.btnViewTraffic.Click += new System.EventHandler(this.btnViewTraffic_Click);
         // 
         // btnReadAll
         // 
         this.btnReadAll.Location = new System.Drawing.Point(1073, 565);
         this.btnReadAll.Name = "btnReadAll";
         this.btnReadAll.Size = new System.Drawing.Size(89, 52);
         this.btnReadAll.TabIndex = 32;
         this.btnReadAll.Text = "Read All";
         this.btnReadAll.UseVisualStyleBackColor = true;
         this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
         // 
         // tclClasses
         // 
         this.tclClasses.Controls.Add(this.tabIndex);
         this.tclClasses.Controls.Add(this.tabIJPOperation);
         this.tclClasses.Controls.Add(this.tabPrintManagement);
         this.tclClasses.Controls.Add(this.tabPrintSpec);
         this.tclClasses.Controls.Add(this.tabPrintFormat);
         this.tclClasses.Controls.Add(this.tabCalendar);
         this.tclClasses.Controls.Add(this.tabSubstitution);
         this.tclClasses.Controls.Add(this.tabCount);
         this.tclClasses.Controls.Add(this.tabUnitInformation);
         this.tclClasses.Controls.Add(this.tabEnviroment);
         this.tclClasses.Controls.Add(this.tabOpMgmt);
         this.tclClasses.Controls.Add(this.tabUserPattern);
         this.tclClasses.Controls.Add(this.tabXML);
         this.tclClasses.Location = new System.Drawing.Point(371, 26);
         this.tclClasses.Multiline = true;
         this.tclClasses.Name = "tclClasses";
         this.tclClasses.SelectedIndex = 0;
         this.tclClasses.Size = new System.Drawing.Size(903, 503);
         this.tclClasses.TabIndex = 33;
         this.tclClasses.SelectedIndexChanged += new System.EventHandler(this.tclClasses_SelectedIndexChanged);
         // 
         // tabIndex
         // 
         this.tabIndex.Location = new System.Drawing.Point(4, 46);
         this.tabIndex.Name = "tabIndex";
         this.tabIndex.Padding = new System.Windows.Forms.Padding(3);
         this.tabIndex.Size = new System.Drawing.Size(895, 453);
         this.tabIndex.TabIndex = 0;
         this.tabIndex.Text = "Index (0x7A)";
         this.tabIndex.UseVisualStyleBackColor = true;
         // 
         // tabIJPOperation
         // 
         this.tabIJPOperation.Location = new System.Drawing.Point(4, 46);
         this.tabIJPOperation.Name = "tabIJPOperation";
         this.tabIJPOperation.Padding = new System.Windows.Forms.Padding(3);
         this.tabIJPOperation.Size = new System.Drawing.Size(895, 453);
         this.tabIJPOperation.TabIndex = 1;
         this.tabIJPOperation.Text = "IJP Operation (0x75)";
         this.tabIJPOperation.UseVisualStyleBackColor = true;
         // 
         // tabPrintManagement
         // 
         this.tabPrintManagement.Location = new System.Drawing.Point(4, 46);
         this.tabPrintManagement.Name = "tabPrintManagement";
         this.tabPrintManagement.Size = new System.Drawing.Size(895, 453);
         this.tabPrintManagement.TabIndex = 4;
         this.tabPrintManagement.Text = "Print Management (066)";
         this.tabPrintManagement.UseVisualStyleBackColor = true;
         // 
         // tabPrintSpec
         // 
         this.tabPrintSpec.Location = new System.Drawing.Point(4, 46);
         this.tabPrintSpec.Name = "tabPrintSpec";
         this.tabPrintSpec.Size = new System.Drawing.Size(895, 453);
         this.tabPrintSpec.TabIndex = 2;
         this.tabPrintSpec.Text = "Print Spec (0x68)";
         this.tabPrintSpec.UseVisualStyleBackColor = true;
         // 
         // tabPrintFormat
         // 
         this.tabPrintFormat.Location = new System.Drawing.Point(4, 46);
         this.tabPrintFormat.Name = "tabPrintFormat";
         this.tabPrintFormat.Size = new System.Drawing.Size(895, 453);
         this.tabPrintFormat.TabIndex = 3;
         this.tabPrintFormat.Text = "Print Format (0x67)";
         this.tabPrintFormat.UseVisualStyleBackColor = true;
         // 
         // tabCalendar
         // 
         this.tabCalendar.Location = new System.Drawing.Point(4, 46);
         this.tabCalendar.Name = "tabCalendar";
         this.tabCalendar.Size = new System.Drawing.Size(895, 453);
         this.tabCalendar.TabIndex = 5;
         this.tabCalendar.Text = "Calendar (0x69)";
         this.tabCalendar.UseVisualStyleBackColor = true;
         // 
         // tabSubstitution
         // 
         this.tabSubstitution.Location = new System.Drawing.Point(4, 46);
         this.tabSubstitution.Name = "tabSubstitution";
         this.tabSubstitution.Size = new System.Drawing.Size(895, 453);
         this.tabSubstitution.TabIndex = 6;
         this.tabSubstitution.Text = "Substitution (0x6C)";
         this.tabSubstitution.UseVisualStyleBackColor = true;
         // 
         // tabCount
         // 
         this.tabCount.Location = new System.Drawing.Point(4, 46);
         this.tabCount.Name = "tabCount";
         this.tabCount.Size = new System.Drawing.Size(895, 453);
         this.tabCount.TabIndex = 7;
         this.tabCount.Text = "Count (0x79)";
         this.tabCount.UseVisualStyleBackColor = true;
         // 
         // tabUnitInformation
         // 
         this.tabUnitInformation.Location = new System.Drawing.Point(4, 46);
         this.tabUnitInformation.Name = "tabUnitInformation";
         this.tabUnitInformation.Size = new System.Drawing.Size(895, 453);
         this.tabUnitInformation.TabIndex = 8;
         this.tabUnitInformation.Text = "Unit Information (0x73)";
         this.tabUnitInformation.UseVisualStyleBackColor = true;
         // 
         // tabEnviroment
         // 
         this.tabEnviroment.Location = new System.Drawing.Point(4, 46);
         this.tabEnviroment.Name = "tabEnviroment";
         this.tabEnviroment.Size = new System.Drawing.Size(895, 453);
         this.tabEnviroment.TabIndex = 9;
         this.tabEnviroment.Text = "Environment Settings (0x71)";
         this.tabEnviroment.UseVisualStyleBackColor = true;
         // 
         // tabOpMgmt
         // 
         this.tabOpMgmt.Location = new System.Drawing.Point(4, 46);
         this.tabOpMgmt.Name = "tabOpMgmt";
         this.tabOpMgmt.Size = new System.Drawing.Size(895, 453);
         this.tabOpMgmt.TabIndex = 10;
         this.tabOpMgmt.Text = "Operation Management (0x74)";
         this.tabOpMgmt.UseVisualStyleBackColor = true;
         // 
         // tabUserPattern
         // 
         this.tabUserPattern.Location = new System.Drawing.Point(4, 46);
         this.tabUserPattern.Name = "tabUserPattern";
         this.tabUserPattern.Size = new System.Drawing.Size(895, 453);
         this.tabUserPattern.TabIndex = 11;
         this.tabUserPattern.Text = "User Pattern (0x6B)";
         this.tabUserPattern.UseVisualStyleBackColor = true;
         // 
         // tabXML
         // 
         this.tabXML.Location = new System.Drawing.Point(4, 46);
         this.tabXML.Name = "tabXML";
         this.tabXML.Size = new System.Drawing.Size(895, 453);
         this.tabXML.TabIndex = 12;
         this.tabXML.Text = "XML Processing";
         this.tabXML.UseVisualStyleBackColor = true;
         // 
         // btnCom
         // 
         this.btnCom.BackColor = System.Drawing.Color.Red;
         this.btnCom.Location = new System.Drawing.Point(347, 565);
         this.btnCom.Name = "btnCom";
         this.btnCom.Size = new System.Drawing.Size(89, 52);
         this.btnCom.TabIndex = 34;
         this.btnCom.Text = "COM";
         this.btnCom.UseVisualStyleBackColor = false;
         this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
         // 
         // lstErrors
         // 
         this.lstErrors.ContextMenuStrip = this.cmLog;
         this.lstErrors.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.lstErrors.FormattingEnabled = true;
         this.lstErrors.ItemHeight = 16;
         this.lstErrors.Location = new System.Drawing.Point(26, 581);
         this.lstErrors.Name = "lstErrors";
         this.lstErrors.Size = new System.Drawing.Size(290, 36);
         this.lstErrors.TabIndex = 35;
         this.lstErrors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstErrors_MouseDoubleClick);
         // 
         // cmLog
         // 
         this.cmLog.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.cmLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmLogClear,
            this.cmLogView});
         this.cmLog.Name = "cmLog";
         this.cmLog.Size = new System.Drawing.Size(190, 52);
         // 
         // cmLogClear
         // 
         this.cmLogClear.Name = "cmLogClear";
         this.cmLogClear.Size = new System.Drawing.Size(189, 24);
         this.cmLogClear.Text = "Clear";
         this.cmLogClear.Click += new System.EventHandler(this.cmLogClear_Click);
         // 
         // cmLogView
         // 
         this.cmLogView.Name = "cmLogView";
         this.cmLogView.Size = new System.Drawing.Size(189, 24);
         this.cmLogView.Text = "View in Notepad";
         this.cmLogView.Click += new System.EventHandler(this.cmLogView_Click);
         // 
         // btnStop
         // 
         this.btnStop.Location = new System.Drawing.Point(788, 565);
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(89, 52);
         this.btnStop.TabIndex = 37;
         this.btnStop.Text = "Stop";
         this.btnStop.UseVisualStyleBackColor = true;
         this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
         // 
         // btnIssueSet
         // 
         this.btnIssueSet.Location = new System.Drawing.Point(87, 304);
         this.btnIssueSet.Name = "btnIssueSet";
         this.btnIssueSet.Size = new System.Drawing.Size(76, 22);
         this.btnIssueSet.TabIndex = 38;
         this.btnIssueSet.Text = "Set";
         this.btnIssueSet.UseVisualStyleBackColor = true;
         this.btnIssueSet.Visible = false;
         this.btnIssueSet.Click += new System.EventHandler(this.btnIssueSet_Click);
         // 
         // btnIssueService
         // 
         this.btnIssueService.Location = new System.Drawing.Point(179, 304);
         this.btnIssueService.Name = "btnIssueService";
         this.btnIssueService.Size = new System.Drawing.Size(137, 22);
         this.btnIssueService.TabIndex = 39;
         this.btnIssueService.Text = "Service";
         this.btnIssueService.UseVisualStyleBackColor = true;
         this.btnIssueService.Visible = false;
         this.btnIssueService.Click += new System.EventHandler(this.btnIssueService_Click);
         // 
         // btnManagementFlag
         // 
         this.btnManagementFlag.BackColor = System.Drawing.Color.Red;
         this.btnManagementFlag.Location = new System.Drawing.Point(567, 565);
         this.btnManagementFlag.Name = "btnManagementFlag";
         this.btnManagementFlag.Size = new System.Drawing.Size(113, 52);
         this.btnManagementFlag.TabIndex = 40;
         this.btnManagementFlag.Text = "S/S Management";
         this.btnManagementFlag.UseVisualStyleBackColor = false;
         this.btnManagementFlag.Click += new System.EventHandler(this.btnManagementFlag_Click);
         // 
         // btnAutoReflection
         // 
         this.btnAutoReflection.BackColor = System.Drawing.Color.Red;
         this.btnAutoReflection.Location = new System.Drawing.Point(442, 565);
         this.btnAutoReflection.Name = "btnAutoReflection";
         this.btnAutoReflection.Size = new System.Drawing.Size(119, 52);
         this.btnAutoReflection.TabIndex = 35;
         this.btnAutoReflection.Text = "Auto Reflection";
         this.btnAutoReflection.UseVisualStyleBackColor = false;
         this.btnAutoReflection.Click += new System.EventHandler(this.btnAutoReflection_Click);
         // 
         // txtCountOut
         // 
         this.txtCountOut.Location = new System.Drawing.Point(28, 427);
         this.txtCountOut.Name = "txtCountOut";
         this.txtCountOut.ReadOnly = true;
         this.txtCountOut.Size = new System.Drawing.Size(53, 22);
         this.txtCountOut.TabIndex = 41;
         this.txtCountOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // lblCountOut
         // 
         this.lblCountOut.Location = new System.Drawing.Point(25, 402);
         this.lblCountOut.Name = "lblCountOut";
         this.lblCountOut.Size = new System.Drawing.Size(66, 22);
         this.lblCountOut.TabIndex = 23;
         this.lblCountOut.Text = "#";
         this.lblCountOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnProperties
         // 
         this.btnProperties.Location = new System.Drawing.Point(26, 332);
         this.btnProperties.Name = "btnProperties";
         this.btnProperties.Size = new System.Drawing.Size(286, 22);
         this.btnProperties.TabIndex = 42;
         this.btnProperties.Text = "Properties";
         this.btnProperties.UseVisualStyleBackColor = true;
         this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
         // 
         // lblCountIn
         // 
         this.lblCountIn.Location = new System.Drawing.Point(22, 480);
         this.lblCountIn.Name = "lblCountIn";
         this.lblCountIn.Size = new System.Drawing.Size(66, 22);
         this.lblCountIn.TabIndex = 44;
         this.lblCountIn.Text = "#";
         this.lblCountIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtDataBytesIn
         // 
         this.txtDataBytesIn.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtDataBytesIn.Location = new System.Drawing.Point(26, 528);
         this.txtDataBytesIn.Name = "txtDataBytesIn";
         this.txtDataBytesIn.ReadOnly = true;
         this.txtDataBytesIn.Size = new System.Drawing.Size(288, 22);
         this.txtDataBytesIn.TabIndex = 45;
         this.txtDataBytesIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // txtCountIn
         // 
         this.txtCountIn.Location = new System.Drawing.Point(25, 505);
         this.txtCountIn.Name = "txtCountIn";
         this.txtCountIn.ReadOnly = true;
         this.txtCountIn.Size = new System.Drawing.Size(53, 22);
         this.txtCountIn.TabIndex = 47;
         this.txtCountIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // txtDataIn
         // 
         this.txtDataIn.Font = new System.Drawing.Font("Courier New", 7.8F);
         this.txtDataIn.Location = new System.Drawing.Point(84, 505);
         this.txtDataIn.Name = "txtDataIn";
         this.txtDataIn.Size = new System.Drawing.Size(229, 22);
         this.txtDataIn.TabIndex = 46;
         this.txtDataIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // lbldataIn
         // 
         this.lbldataIn.Location = new System.Drawing.Point(87, 480);
         this.lbldataIn.Name = "lbldataIn";
         this.lbldataIn.Size = new System.Drawing.Size(229, 22);
         this.lbldataIn.TabIndex = 43;
         this.lbldataIn.Text = "Data In";
         this.lbldataIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnReformat
         // 
         this.btnReformat.Location = new System.Drawing.Point(686, 557);
         this.btnReformat.Name = "btnReformat";
         this.btnReformat.Size = new System.Drawing.Size(89, 26);
         this.btnReformat.TabIndex = 48;
         this.btnReformat.Text = "Reformat";
         this.btnReformat.UseVisualStyleBackColor = true;
         this.btnReformat.Click += new System.EventHandler(this.btnReformat_Click);
         // 
         // btnRefresh
         // 
         this.btnRefresh.Location = new System.Drawing.Point(686, 589);
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.Size = new System.Drawing.Size(89, 26);
         this.btnRefresh.TabIndex = 49;
         this.btnRefresh.Text = "Refresh";
         this.btnRefresh.UseVisualStyleBackColor = true;
         this.btnRefresh.Visible = false;
         this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // btnResetTraffic
         // 
         this.btnResetTraffic.Location = new System.Drawing.Point(978, 565);
         this.btnResetTraffic.Name = "btnResetTraffic";
         this.btnResetTraffic.Size = new System.Drawing.Size(89, 52);
         this.btnResetTraffic.TabIndex = 50;
         this.btnResetTraffic.Text = "Reset Traffic";
         this.btnResetTraffic.UseVisualStyleBackColor = true;
         this.btnResetTraffic.Click += new System.EventHandler(this.btnResetTraffic_Click);
         // 
         // lblSoftwareVersion
         // 
         this.lblSoftwareVersion.Location = new System.Drawing.Point(12, 76);
         this.lblSoftwareVersion.Name = "lblSoftwareVersion";
         this.lblSoftwareVersion.Size = new System.Drawing.Size(128, 22);
         this.lblSoftwareVersion.TabIndex = 51;
         this.lblSoftwareVersion.Text = "MCode Vers";
         this.lblSoftwareVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // cbSoftwareVersion
         // 
         this.cbSoftwareVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cbSoftwareVersion.FormattingEnabled = true;
         this.cbSoftwareVersion.Items.AddRange(new object[] {
            "2.07",
            "3.01"});
         this.cbSoftwareVersion.Location = new System.Drawing.Point(146, 82);
         this.cbSoftwareVersion.Name = "cbSoftwareVersion";
         this.cbSoftwareVersion.Size = new System.Drawing.Size(173, 24);
         this.cbSoftwareVersion.TabIndex = 52;
         this.cbSoftwareVersion.SelectedIndexChanged += new System.EventHandler(this.cbSoftwareVersion_SelectedIndexChanged);
         // 
         // Browser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1288, 627);
         this.Controls.Add(this.cbSoftwareVersion);
         this.Controls.Add(this.lblSoftwareVersion);
         this.Controls.Add(this.btnResetTraffic);
         this.Controls.Add(this.btnRefresh);
         this.Controls.Add(this.btnReformat);
         this.Controls.Add(this.lblCountIn);
         this.Controls.Add(this.txtDataBytesIn);
         this.Controls.Add(this.txtCountIn);
         this.Controls.Add(this.txtDataIn);
         this.Controls.Add(this.lbldataIn);
         this.Controls.Add(this.btnProperties);
         this.Controls.Add(this.lblCountOut);
         this.Controls.Add(this.txtDataBytesOut);
         this.Controls.Add(this.txtCountOut);
         this.Controls.Add(this.btnAutoReflection);
         this.Controls.Add(this.btnManagementFlag);
         this.Controls.Add(this.btnIssueService);
         this.Controls.Add(this.btnIssueSet);
         this.Controls.Add(this.btnStop);
         this.Controls.Add(this.lstErrors);
         this.Controls.Add(this.btnCom);
         this.Controls.Add(this.tclClasses);
         this.Controls.Add(this.btnReadAll);
         this.Controls.Add(this.btnViewTraffic);
         this.Controls.Add(this.btnBrowse);
         this.Controls.Add(this.txtSaveFolder);
         this.Controls.Add(this.lblSaveFolder);
         this.Controls.Add(this.txtDataOut);
         this.Controls.Add(this.txtStatus);
         this.Controls.Add(this.lblStatus);
         this.Controls.Add(this.lbldataOut);
         this.Controls.Add(this.lblFunction);
         this.Controls.Add(this.cbFunction);
         this.Controls.Add(this.lblClassCode);
         this.Controls.Add(this.cbClassCode);
         this.Controls.Add(this.btnIssueGet);
         this.Controls.Add(this.btnForwardClose);
         this.Controls.Add(this.btnForwardOpen);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.txtSessionID);
         this.Controls.Add(this.lblSessionID);
         this.Controls.Add(this.btnEndSession);
         this.Controls.Add(this.btnStartSession);
         this.Controls.Add(this.txtPort);
         this.Controls.Add(this.txtIPAddress);
         this.Controls.Add(this.lblPort);
         this.Controls.Add(this.lblIPAddress);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Browser";
         this.Text = "Browse thru the Hitachi Printer";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HitachiBrowser_FormClosing);
         this.Load += new System.EventHandler(this.HitachiBrowser_Load);
         this.Resize += new System.EventHandler(this.HitachiBrowser_Resize);
         this.tclClasses.ResumeLayout(false);
         this.cmLog.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label lblIPAddress;
      private System.Windows.Forms.Label lblPort;
      private System.Windows.Forms.TextBox txtIPAddress;
      private System.Windows.Forms.TextBox txtPort;
      private System.Windows.Forms.Button btnEndSession;
      private System.Windows.Forms.Button btnStartSession;
      private System.Windows.Forms.TextBox txtSessionID;
      private System.Windows.Forms.Label lblSessionID;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnForwardClose;
      private System.Windows.Forms.Button btnForwardOpen;
      private System.Windows.Forms.Button btnIssueGet;
      private System.Windows.Forms.Label lblClassCode;
      private System.Windows.Forms.ComboBox cbClassCode;
      private System.Windows.Forms.Label lblFunction;
      private System.Windows.Forms.ComboBox cbFunction;
      private System.Windows.Forms.Label lbldataOut;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.Label lblSaveFolder;
      private System.Windows.Forms.TextBox txtSaveFolder;
      private System.Windows.Forms.Button btnBrowse;
      private System.Windows.Forms.Button btnViewTraffic;
      private System.Windows.Forms.Button btnReadAll;
      private System.Windows.Forms.Button btnCom;
      private System.Windows.Forms.ListBox lstErrors;
      private System.Windows.Forms.ContextMenuStrip cmLog;
      private System.Windows.Forms.ToolStripMenuItem cmLogClear;
      private System.Windows.Forms.ToolStripMenuItem cmLogView;
      private System.Windows.Forms.Button btnStop;
      public System.Windows.Forms.TabControl tclClasses;
      private System.Windows.Forms.Button btnIssueSet;
      private System.Windows.Forms.Button btnIssueService;
      private System.Windows.Forms.Button btnManagementFlag;
      private System.Windows.Forms.Button btnAutoReflection;
      private System.Windows.Forms.Label lblCountOut;
      public System.Windows.Forms.TextBox txtDataBytesOut;
      public System.Windows.Forms.TextBox txtStatus;
      public System.Windows.Forms.TextBox txtDataOut;
      public System.Windows.Forms.TextBox txtCountOut;
      private System.Windows.Forms.Button btnProperties;
      private System.Windows.Forms.Label lblCountIn;
      public System.Windows.Forms.TextBox txtDataBytesIn;
      public System.Windows.Forms.TextBox txtCountIn;
      public System.Windows.Forms.TextBox txtDataIn;
      private System.Windows.Forms.Label lbldataIn;
      private System.Windows.Forms.Button btnReformat;
      private System.Windows.Forms.Button btnRefresh;
      internal System.Windows.Forms.TabPage tabIndex;
      internal System.Windows.Forms.TabPage tabIJPOperation;
      internal System.Windows.Forms.TabPage tabPrintManagement;
      internal System.Windows.Forms.TabPage tabPrintSpec;
      internal System.Windows.Forms.TabPage tabPrintFormat;
      internal System.Windows.Forms.TabPage tabCalendar;
      internal System.Windows.Forms.TabPage tabSubstitution;
      internal System.Windows.Forms.TabPage tabCount;
      internal System.Windows.Forms.TabPage tabUnitInformation;
      internal System.Windows.Forms.TabPage tabEnviroment;
      internal System.Windows.Forms.TabPage tabOpMgmt;
      internal System.Windows.Forms.TabPage tabUserPattern;
      internal System.Windows.Forms.TabPage tabXML;
      private System.Windows.Forms.Button btnResetTraffic;
      private System.Windows.Forms.Label lblSoftwareVersion;
      public System.Windows.Forms.ComboBox cbSoftwareVersion;
   }
}

