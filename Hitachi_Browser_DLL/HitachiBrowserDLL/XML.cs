﻿using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace EIP_Lib {
   public partial class XML {

      #region Data Declarations

      Browser parent;

      EIP EIP;
      TabPage tab;

      // Tab Controls
      TabControl tclViewXML;
      TabPage tabTreeView;
      TabPage tabIndented;
      TabPage tabVerify;

      TreeView tvXML;
      TextBox txtIndentedView;
      TextBox txtVerify;

      // Operating Buttons
      Button cmdOpen;
      Button cmdClear;
      Button cmdGenerate;
      Button cmdSaveAs;
      Button cmdVerify;
      Button cmdSaveInPrinter;

      // Testing Buttons
      Label lblSelectXmlTest;
      ComboBox cbAvailableXmlTests;
      Button cmdBrowse;
      Button cmdSendFileToPrinter;
      Button cmdSendDisplayToPrinter;

      Label lblSelectHardTest;
      ComboBox cbAvailableHardTests;
      Button cmdRunHardTest;

      // XML Processing
      string XMLText = string.Empty;
      XmlDocument xmlDoc = null;
      enum ItemType {
         Unknown = 0,
         Text = 1,
         Date = 2,
         Counter = 3,
         Logo = 4,
         Link = 5,     // Not supported in the printer
         Prompt = 6,   // Not supported in the printer
      }

      // Make things easier to read
      Font courier = new Font("Courier New", 9);

      // Flag for Attribute Not Present
      const string N_A = "N!A";

      #endregion

      #region Constructors and destructors

      // Create class
      public XML(Browser parent, EIP EIP, TabPage tab) {
         this.parent = parent;
         this.EIP = EIP;
         this.tab = tab;

         BuildControls();

         BuildTestFileList();

         SetButtonEnables();
      }

      #endregion

      #region Form Control Events

      // Open a new XML file
      private void Open_Click(object sender, EventArgs e) {
         // Clear out any currently loaded file
         using (OpenFileDialog dlg = new OpenFileDialog()) {
            dlg.AutoUpgradeEnabled = true;
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            dlg.Multiselect = false;
            dlg.ValidateNames = true;
            dlg.Title = "Select XML formatted file!";
            dlg.Filter = "XML (*.xml)|*.xml|All (*.*)|*.*";
            DialogResult dlgResult = DialogResult.Retry;
            while (dlgResult == DialogResult.Retry) {
               dlgResult = dlg.ShowDialog();
               if (dlgResult == DialogResult.OK) {
                  try {
                     ProcessLabel(File.ReadAllText(dlg.FileName));
                  } catch (Exception ex) {
                     MessageBox.Show(parent, ex.Message, "Cannot load XML File!");
                  }
               }
            }
         }
         SetButtonEnables();
      }

      // Clear out the screens
      private void Clear_Click(object sender, EventArgs e) {
         txtIndentedView.Text = string.Empty;
         xmlDoc = null;
         tvXML.Nodes.Clear();
         XMLText = string.Empty;
         SetButtonEnables();
      }

      // Save the generated XML file
      private void SaveAs_Click(object sender, EventArgs e) {
         DialogResult dlgResult;
         string filename = string.Empty;

         using (SaveFileDialog saveFileDialog1 = new SaveFileDialog()) {
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "xml|*.xml";
            saveFileDialog1.Title = "Save Printer Layout to XML file";
            saveFileDialog1.FileName = filename;
            dlgResult = saveFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK && !String.IsNullOrEmpty(saveFileDialog1.FileName)) {
               filename = saveFileDialog1.FileName;
               using (Stream outfs = new FileStream(filename, FileMode.Create)) {
                  // Might have some possibilities here <TODO>
                  outfs.Write(EIP.Encode.GetBytes(XMLText), 0, XMLText.Length);
                  outfs.Flush();
                  outfs.Close();
                  SetButtonEnables();
               }
            }
         }
         SetButtonEnables();
      }

      #endregion

      #region Service Routines

      // Build XML page controls
      private void BuildControls() {
         tclViewXML = new TabControl() { Name = "tclViewXML", Font = courier };
         tabTreeView = new TabPage() { Name = "tabTreeView", Text = "Tree View" };
         tabIndented = new TabPage() { Name = "tabIndented", Text = "Indented View" };
         tabVerify = new TabPage() { Name = "tabVerify", Text = "Verify View" };

         tvXML = new TreeView() { Name = "tvXML", Font = courier };
         txtIndentedView = new TextBox() { Name = "txtIndentedView", Font = courier, Multiline = true, ScrollBars = ScrollBars.Both };
         txtVerify = new TextBox() { Name = "txtVerify", Font = courier, Multiline = true, ScrollBars = ScrollBars.Both };

         cmdOpen = new Button() { Text = "Open" };
         cmdOpen.Click += Open_Click;

         cmdClear = new Button() { Text = "Clear" };
         cmdClear.Click += Clear_Click;

         cmdGenerate = new Button() { Text = "Generate" };
         cmdGenerate.Click += Generate_Click;

         cmdSaveAs = new Button() { Text = "Save As" };
         cmdSaveAs.Click += SaveAs_Click;

         cmdSendFileToPrinter = new Button() { Text = "File To Printer" };
         cmdSendFileToPrinter.Click += SendFileToPrinter_Click;

         cmdSendDisplayToPrinter = new Button() { Text = "Display To Printer" };
         cmdSendDisplayToPrinter.Click += SendDisplayToPrinter_Click;

         tab.Controls.Add(tclViewXML);

         tclViewXML.Controls.Add(tabTreeView);
         tclViewXML.Controls.Add(tabIndented);
         tclViewXML.Controls.Add(tabVerify);

         tabTreeView.Controls.Add(tvXML);
         tabIndented.Controls.Add(txtIndentedView);
         tabVerify.Controls.Add(txtVerify);

         tab.Controls.Add(cmdOpen);
         tab.Controls.Add(cmdClear);
         tab.Controls.Add(cmdGenerate);
         tab.Controls.Add(cmdSaveAs);
         tab.Controls.Add(cmdSendFileToPrinter);
         tab.Controls.Add(cmdSendDisplayToPrinter);

         // Testing controls
         lblSelectXmlTest = new Label() { Text = "Select XML Test", TextAlign = ContentAlignment.BottomCenter };
         cbAvailableXmlTests = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };
         cbAvailableXmlTests.SelectedIndexChanged += cbAvailableTests_SelectedIndexChanged;
         cmdBrowse = new Button() { Text = "Browse" };
         cmdBrowse.Click += cmdBrowse_Click;

         lblSelectHardTest = new Label() { Text = "Select Hard Test", TextAlign = ContentAlignment.BottomCenter };
         cbAvailableHardTests = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };
         cbAvailableHardTests.Items.AddRange(
            new string[] {
               "Reset", "Shift Code", "Month Day SR", "Time Count",
               "Day of Week etc", "MDY hms", "Multi-Line", "Counter",
               "Comprehensive", "???" }
            );
         cbAvailableHardTests.SelectedIndexChanged += CbAvailableHardTests_SelectedIndexChanged;
         cmdRunHardTest = new Button() { Text = "Run Test" };
         cmdRunHardTest.Click += cmdRunHardTest_Click;

         cmdVerify = new Button() { Text = "Verify" };
         cmdVerify.Click += cmdVerify_Click;

         cmdSaveInPrinter = new Button() { Text = "Save In Printer" };
         cmdSaveInPrinter.Click += cmdSaveToPrinter_Click;

         tab.Controls.Add(lblSelectXmlTest);
         tab.Controls.Add(lblSelectHardTest);
         tab.Controls.Add(cbAvailableXmlTests);
         tab.Controls.Add(cbAvailableHardTests);
         tab.Controls.Add(cmdVerify);
         tab.Controls.Add(cmdBrowse);
         tab.Controls.Add(cmdSaveInPrinter);
         tab.Controls.Add(cmdRunHardTest);
      }

      private void CbAvailableHardTests_SelectedIndexChanged(object sender, EventArgs e) {
         SetButtonEnables();
      }

      // Called from parent
      public void ResizeControls(ref ResizeInfo R) {
         int tclHeight = (int)(tab.ClientSize.Height / R.H);
         int tclWidth = (int)(tab.ClientSize.Width / R.W);
         float offset = (int)(tab.ClientSize.Height - tclHeight * R.H);
         if (parent.tclClasses.SelectedIndex != parent.tclClasses.TabPages.IndexOf(tab)) {
            return;
         }
         R.offset = offset;
         Utils.ResizeObject(ref R, tclViewXML, 0, 1, tclHeight - 7, tclWidth - 1);
         {
            Utils.ResizeObject(ref R, tvXML, 1, 1, tclHeight - 12, tclWidth - 3);
            Utils.ResizeObject(ref R, txtIndentedView, 1, 1, tclHeight - 12, tclWidth - 3);
            Utils.ResizeObject(ref R, txtVerify, 1, 1, tclHeight - 12, tclWidth - 3);

            Utils.ResizeObject(ref R, cmdOpen, tclHeight - 6, 1, 2.5f, 4);
            Utils.ResizeObject(ref R, cmdClear, tclHeight - 3, 1, 2.5f, 4);

            Utils.ResizeObject(ref R, cmdGenerate, tclHeight - 6, 5.5f, 2.5f, 4);
            Utils.ResizeObject(ref R, cmdVerify, tclHeight - 3, 5.5f, 2.5f, 4);

            Utils.ResizeObject(ref R, cmdSaveAs, tclHeight - 6, 10, 2.5f, 4);
            Utils.ResizeObject(ref R, cmdSaveInPrinter, tclHeight - 3, 10, 2.5f, 4);

            Utils.ResizeObject(ref R, lblSelectXmlTest, tclHeight - 6, 14.5f, 1, 6);
            Utils.ResizeObject(ref R, cbAvailableXmlTests, tclHeight - 5, 14.5f, 2, 6);
            Utils.ResizeObject(ref R, cmdBrowse, tclHeight - 3, 14.5f, 2.5f, 6);

            Utils.ResizeObject(ref R, cmdSendFileToPrinter, tclHeight - 6, 21, 2.5f, 4);
            Utils.ResizeObject(ref R, cmdSendDisplayToPrinter, tclHeight - 3, 21, 2.5f, 4);

            Utils.ResizeObject(ref R, lblSelectHardTest, tclHeight - 6, 25.5f, 1, 5);
            Utils.ResizeObject(ref R, cbAvailableHardTests, tclHeight - 5, 25.5f, 2, 5);
            Utils.ResizeObject(ref R, cmdRunHardTest, tclHeight - 6, 31, 5.5f, 4);

         }
         R.offset = 0;
      }

      // Only allow buttons if conditions are right to process the request
      public void SetButtonEnables() {
         cmdSaveAs.Enabled = XMLText.Length > 0;
         cmdSendFileToPrinter.Enabled = xmlDoc != null;
         cmdSendDisplayToPrinter.Enabled = xmlDoc != null;
         cmdRunHardTest.Enabled = cbAvailableHardTests.SelectedIndex >= 0;
      }

      private void BuildTestFileList() {
         cbAvailableXmlTests.Items.Clear();
         try {
            string[] FileNames = Directory.GetFiles(parent.MessageFolder, "*.XML");
            Array.Sort(FileNames);
            for (int i = 0; i < FileNames.Length; i++) {
               cbAvailableXmlTests.Items.Add(Path.GetFileNameWithoutExtension(FileNames[i]));
            }
         } catch {

         }
      }

      #endregion

      #region Test Routines

      // Get the contents of one attribute
      private string GetAttribute<T>(T Attribute) where T : Enum {
         string val = string.Empty;
         AttrData attr = EIP.GetAttrData(Attribute);
         if (EIP.GetAttribute(attr.Class, attr.Val, EIP.Nodata)) {
            val = EIP.GetDataValue;
            if (attr.Data.Fmt == DataFormats.UTF8 || attr.Data.Fmt == DataFormats.UTF8N) {
               val = EIP.FromQuoted(val);
            } else if (attr.Data.DropDown != fmtDD.None) {
               string[] dd = EIP.DropDowns[(int)attr.Data.DropDown];
               long n = EIP.GetDecValue - attr.Data.Min;
               if (n >= 0 && n < dd.Length) {
                  val = dd[n];
               }
            }
         }
         return val;
      }

      // Get the contents of one attribute
      private string GetAttribute<T>(T Attribute, int n) where T : Enum {
         string val = string.Empty;
         AttrData attr = EIP.GetAttrData(Attribute);
         if (EIP.GetAttribute(attr.Class, attr.Val, EIP.FormatOutput(attr.Get, n))) {
            val = EIP.GetDataValue;
            if (attr.Data.Fmt == DataFormats.UTF8 || attr.Data.Fmt == DataFormats.UTF8N) {
               val = EIP.FromQuoted(val);
            }
         }
         return val;
      }

      // Verify send vs received
      private void cmdVerify_Click(object sender, EventArgs e) {

      }

      // Add text to all items (Control Deleted)
      private void cmdAddText_Click(object sender, EventArgs e) {
         // Add new logic here
      }

      // Create a message with text only (Control Deleted)
      private void cmdCreateText_Click(object sender, EventArgs e) {
         if (EIP.StartSession()) {
            if (EIP.ForwardOpen()) {
               try {
                  for (int step = 0; step < 3; step++) {
                     switch (step) {
                        case 0:
                           // Cleanup the display
                           CleanUpDisplay();
                           break;
                        case 1:
                           // Put in some items
                           for (int i = 0; i < 5; i++) {
                              EIP.ServiceAttribute(ccPF.Add_Column, 0);
                           }
                           break;
                        case 2:
                           // Set the text
                           SetText("Hello World");
                           break;
                     }
                  }
               } catch (EIPIOException e1) {
                  // In case of an EIP I/O error
                  string name = $"{EIP.GetAttributeName(e1.ClassCode, e1.Attribute)}";
                  string msg = $"EIP I/O Error on {e1.AccessCode}/{e1.ClassCode}/{name}";
                  MessageBox.Show(msg, "EIP I/O Error", MessageBoxButtons.OK);
               } catch (Exception e2) {
                  // You are on your own here
               }
            }
            EIP.ForwardClose();
         }
         EIP.EndSession();
      }

      private void cmdSaveToPrinter_Click(object sender, EventArgs e) {
         // A single command, no need to open/close the connection here
         byte[] data = EIP.Merge(EIP.ToBytes(4, 2), EIP.ToBytes(2, 1), EIP.ToBytes("AAA\x00"));
         AttrData attr = EIP.GetAttrData(ccPDM.Store_Print_Data);
         EIP.SetAttribute(attr.Class, attr.Val, data);
      }

      private void cmdBrowse_Click(object sender, EventArgs e) {
         using (FolderBrowserDialog dlg = new FolderBrowserDialog()) {
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = parent.MessageFolder;
            if (dlg.ShowDialog() == DialogResult.OK) {
               parent.MessageFolder = dlg.SelectedPath;
               BuildTestFileList();
            }
         }
      }

      #endregion

   }

}
