﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitachiEIP {
   class PrintFormatAttributes {

      #region Data Declarations

      Form1 parent;
      EIP EIP;
      TabPage tab;

      eipPrint_format[] attributes = new eipPrint_format[] {
         eipPrint_format.Message_Name,
         eipPrint_format.Print_Item,
         eipPrint_format.Number_Of_Columns,
         eipPrint_format.Format_Type,
         eipPrint_format.Insert_Column,
         eipPrint_format.Delete_Column,
         eipPrint_format.Add_Column,
         eipPrint_format.Number_Of_Print_Line_And_Print_Format,
         eipPrint_format.Format_Setup,
         eipPrint_format.Adding_Print_Items,
         eipPrint_format.Deleting_Print_Items,
         eipPrint_format.Print_Character_String,
         eipPrint_format.Line_Count,
         eipPrint_format.Line_Spacing,
         eipPrint_format.Dot_Matrix,
         eipPrint_format.InterCharacter_Space,
         eipPrint_format.Character_Bold,
         eipPrint_format.Barcode_Type,
         eipPrint_format.Readable_Code,
         eipPrint_format.Prefix_Code,
         eipPrint_format.X_and_Y_Coordinate,
         eipPrint_format.InterCharacter_SpaceII,
         eipPrint_format.Add_To_End_Of_String,
         eipPrint_format.Calendar_Offset,
         eipPrint_format.DIN_Print,
         eipPrint_format.EAN_Prefix,
         eipPrint_format.Barcode_Printing,
         eipPrint_format.QR_Error_Correction_Level,
      };

      int[,] validData;

      Label[] labels;
      TextBox[] texts;
      Button[] gets;
      Button[] sets;
      Button[] services;
      Button getAll;
      Button setAll;

      #endregion

      #region Constructors and destructors

      public PrintFormatAttributes(Form1 parent, EIP EIP, TabPage tab) {
         this.parent = parent;
         this.EIP = EIP;
         this.tab = tab;
         BuildControls();
      }

      #endregion

      #region Events handlers

      private void Get_Click(object sender, EventArgs e) {
         int tag = Convert.ToInt32(((Button)sender).Tag);
         texts[tag].Text = "Loading";
         if (EIP.ReadOneAttribute(eipClassCode.Print_format, (byte)attributes[tag], out string val, DataFormats.Decimal)) {
            texts[tag].Text = val;
         } else {
            texts[tag].Text = "#Error";
         }
         SetButtonEnables();
      }

      private void Set_Click(object sender, EventArgs e) {
         int tag = Convert.ToInt32(((Button)sender).Tag);
         if (!int.TryParse(texts[tag].Text, out int val)) {
            val = validData[tag, 0];
         }
         int len = ((int)attributes[tag] & 0xFF0000) >> 16;
         bool Success = EIP.WriteOneAttribute(eipClassCode.Print_format, (byte)attributes[tag], EIP.ToBytes((uint)val, len));
         SetButtonEnables();
      }

      private void GetAll_Click(object sender, EventArgs e) {
         for (int i = 0; i < gets.Length; i++) {
            if (gets[i] != null) {
               Get_Click(gets[i], null);
               parent.Refresh();
            }
         }
         SetButtonEnables();
      }

      private void SetAll_Click(object sender, EventArgs e) {
         for (int i = 0; i < sets.Length; i++) {
            if (gets[i] != null) {
               Set_Click(sets[i], null);
               parent.Refresh();
            }
         }
      }

      #endregion

      #region Service Routines

      public void BuildControls() {

         validData = new int[attributes.Length, 2];
         labels = new Label[attributes.Length];
         texts = new TextBox[attributes.Length];
         gets = new Button[attributes.Length];
         sets = new Button[attributes.Length];
         services = new Button[attributes.Length];

         for (int i = 0; i < attributes.Length; i++) {
            labels[i] = new Label() { Tag = i, TextAlign = System.Drawing.ContentAlignment.TopRight, Text = EIP.GetAttributeName(eipClassCode.Print_format, (uint)attributes[i]) };
            tab.Controls.Add(labels[i]);
            texts[i] = new TextBox() { Tag = i };
            tab.Controls.Add(texts[i]);
            if (((uint)attributes[i] & 0x200) > 0) {
               gets[i] = new Button() { Tag = i, Text = "Get" };
               gets[i].Click += Get_Click;
               tab.Controls.Add(gets[i]);
            }
            if (((uint)attributes[i] & 0x100) > 0) {
               sets[i] = new Button() { Tag = i, Text = "Set" };
               tab.Controls.Add(sets[i]);
            } else {
               texts[i].ReadOnly = true;
            }
            if (((uint)attributes[i] & 0x400) > 0) {
               services[i] = new Button() { Tag = i, Text = "Service" };
               tab.Controls.Add(services[i]);
            }
         }

         getAll = new Button() { Text = "Get All" };
         getAll.Click += GetAll_Click;
         tab.Controls.Add(getAll);
         setAll = new Button() { Text = "Set All" };
         tab.Controls.Add(setAll);
         setAll.Click += SetAll_Click;

      }

      public void ResizeControls(ref ResizeInfo R) {
         int tclHeight = (int)(tab.ClientSize.Height / R.H);
         int half = 17;
         for (int i = 0; i < labels.Length; i++) {
            int r;
            int c;
            float cw = 12.5f;
            if (i < half) {
               r = 2 + i * 2;
               c = 0;
            } else {
               r = 2 + (i - half) * 2;
               c = 1;
            }
            Utils.ResizeObject(ref R, labels[i], r, 0.25f + c * cw, 1.5f, 5.75f);
            Utils.ResizeObject(ref R, texts[i], r, 6.5f + c * cw, 1.5f, 2);
            if (gets[i] != null) {
               Utils.ResizeObject(ref R, gets[i], r, 9 + c * cw, 1.5f, 1.5f);
            }
            if (sets[i] != null) {
               Utils.ResizeObject(ref R, sets[i], r, 11 + c * cw, 1.5f, 1.5f);
            }
            if (services[i] != null) {
               Utils.ResizeObject(ref R, services[i], r, 9 + c * cw, 1.5f, 3.5f);
            }
         }
         Utils.ResizeObject(ref R, getAll, tclHeight - 3, 17, 2.5f, 4);
         Utils.ResizeObject(ref R, setAll, tclHeight - 3, 21.5f, 2.5f, 4);
      }

      private void SetButtonEnables() {

      }

      #endregion

   }
}
