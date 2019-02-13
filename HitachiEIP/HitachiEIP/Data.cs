﻿using System;
using System.Collections.Generic;

namespace HitachiEIP {

   public static class Data {

      #region Attribute raw data tables

      // Print Data Management (Class Code 0x66) Complete!
      public static int[][] PrintDataManagement = new int[][] {
         new int[] { 0X64, 0, 0, 1, 0, 0, 0, 0, 9, 0, -1, 2, 0, 1, 2000}, // Select Message
         new int[] { 0X65, 1, 0, 0, 15, 1, 0, 0, 10, 0, -1},       // Store Print Data
         new int[] { 0X67, 1, 0, 0, 2, 0, 1, 2000, 3, 0, -1},      // Delete Print Data
         new int[] { 0X69, 1, 0, 0, 10, 1, 0, 0, 7, 0, -1},        // Print Data Name
         new int[] { 0X6A, 0, 1, 0, 0, 0, 0, 0, 6, 1, -1, 2, 0, 1, 2000}, // List of Messages
         new int[] { 0X6B, 1, 0, 0, 4, 0, 1, 2000, 8, 0, -1},      // Print Data Number
         new int[] { 0X6C, 1, 0, 0, 14, 1, 0, 14, 1, 0, -1},       // Change Create Group Name
         new int[] { 0X6D, 1, 0, 0, 1, 0, 1, 99, 4, 0, -1},        // Group Deletion
         new int[] { 0X6F, 0, 1, 0, 1, 0, 1, 99, 5, 1, -1},        // List of Groups
         new int[] { 0X70, 1, 0, 0, 2, 0, 1, 99, 2, 0, -1},        // Change Group Number
      };

      // Print Format (Class Code 0x67)
      public static int[][] PrintFormat = new int[][] {
         new int[] { 0X64, 0, 1, 0, 1, 0, 0, 0, 20, 1, -1},       // Message Name
         new int[] { 0X65, 0, 1, 0, 1, 0, 0, 99, 25, 0, -1},      // Print Item
         new int[] { 0X66, 0, 1, 0, 1, 0, 1, 100, 21, 0, -1},     // Number Of Columns
         new int[] { 0X67, 0, 1, 0, 1, 0, 1, 3, 14, 0, -1},       // Format Type
         new int[] { 0X69, 0, 0, 1, 1, 0, 0, 99, 15, 0, -1},      // Insert Column
         new int[] { 0X6A, 0, 0, 1, 1, 0, 0, 99, 8, 0, -1},       // Delete Column
         new int[] { 0X6B, 0, 0, 1, 1, 0, 0, 0, 1, 0, -1},        // Add Column
         new int[] { 0X6C, 1, 0, 0, 1, 0, 0, 1, 22, 0, -1},       // Number Of Print Line And Print Format
         new int[] { 0X6D, 1, 0, 0, 1, 0, 0, 2, 13, 0, -1},       // Format Setup
         new int[] { 0X6E, 0, 0, 1, 1, 0, 0, 0, 3, 0, -1},        // Adding Print Items
         new int[] { 0X6F, 0, 0, 1, 1, 0, 1, 100, 9, 0, -1},      // Deleting Print Items
         new int[] { 0X71, 1, 1, 0, 750, 1, 0, 0, 24, 0, -1},     // Print Character String
         new int[] { 0X72, 1, 1, 0, 1, 0, 1, 6, 18, 0, -1},       // Line Count
         new int[] { 0X73, 1, 1, 0, 1, 0, 0, 2, 19, 0, -1},       // Line Spacing
         new int[] { 0X74, 1, 1, 0, 1, 0, 1, 16, 11, 0, 14},      // Dot Matrix
         new int[] { 0X75, 1, 1, 0, 1, 0, 0, 26, 16, 0, -1},      // InterCharacter Space
         new int[] { 0X76, 1, 1, 0, 1, 0, 1, 9, 7, 0, 0},         // Character Bold
         new int[] { 0X77, 1, 1, 0, 1, 0, 0, 27, 5, 0, 9},        // Barcode Type
         new int[] { 0X78, 1, 1, 0, 1, 0, 0, 2, 27, 0, 8},        // Readable Code
         new int[] { 0X79, 1, 1, 0, 1, 0, 0, 99, 23, 0, -1},      // Prefix Code
         new int[] { 0X7A, 1, 1, 0, 3, 4, 0, 0, 28, 0, -1},       // X and Y Coordinate
         new int[] { 0X7B, 1, 1, 0, 2, 0, 0, 99, 17, 0, -1},      // InterCharacter SpaceII
         new int[] { 0X8A, 1, 0, 0, 750, 1, 0, 0, 2, 0, -1},      // Add To End Of String
         new int[] { 0X8D, 1, 1, 0, 1, 0, 0, 1, 6, 0, 13},        // Calendar Offset
         new int[] { 0X8E, 1, 1, 0, 1, 0, 0, 1, 10, 0, 1},        // DIN Print
         new int[] { 0X8F, 1, 1, 0, 1, 0, 0, 1, 12, 0, 12},       // EAN Prefix
         new int[] { 0X90, 1, 1, 0, 1, 0, 0, 1, 4, 0, 10},        // Barcode Printing
         new int[] { 0X91, 1, 1, 0, 1, 0, 0, 1, 26, 0, 11},       // QR Error Correction Level
     };

      // Print Specification (Class Code 0x68)
      public static int[][] PrintSpecification = new int[][] {
         new int[] { 0X64, 1, 1, 0, 1, 0, 0, 99, 2, 0, -1},         // Character Height
         new int[] { 0X65, 1, 1, 0, 1, 0, 1, 16, 8, 0, -1},         // Ink Drop Use
         new int[] { 0X66, 1, 1, 0, 1, 0, 0, 3, 6, 0, 17},          // High Speed Print
         new int[] { 0X67, 1, 1, 0, 2, 0, 0, 3999, 4, 0, -1},       // Character Width
         new int[] { 0X68, 1, 1, 0, 1, 0, 0, 3, 3, 0, 15},          // Character Orientation
         new int[] { 0X69, 1, 1, 0, 2, 0, 0, 9999, 11, 0, -1},      // Print Start Delay Forward
         new int[] { 0X6A, 1, 1, 0, 2, 0, 0, 9999, 10, 0, -1},      // Print Start Delay Reverse
         new int[] { 0X6B, 1, 1, 0, 1, 0, 0, 2, 14, 0, 16},         // Product Speed Matching
         new int[] { 0X6C, 1, 1, 0, 2, 0, 0, 999, 15, 0, -1},       // Pulse Rate Division Factor
         new int[] { 0X6D, 1, 1, 0, 1, 0, 0, 1, 18, 0, -1},         // Speed Compensation
         new int[] { 0X6E, 1, 1, 0, 2, 0, 0, 9999, 9, 0, -1},       // Line Speed
         new int[] { 0X6F, 1, 1, 0, 1, 0, 0, 99, 5, 0, -1},         // Distance Between Print Head And Object
         new int[] { 0X70, 1, 1, 0, 1, 0, 0, 99, 13, 0, -1},        // Print Target Width
         new int[] { 0X71, 1, 1, 0, 1, 0, 0, 99, 1, 0, -1},         // Actual Print Width
         new int[] { 0X72, 1, 1, 0, 2, 0, 0, 9999, 16, 0, -1},      // Repeat Count
         new int[] { 0X73, 1, 1, 0, 3, 0, 0, 99999, 17, 0, -1},     // Repeat Interval
         new int[] { 0X74, 1, 1, 0, 2, 0, 0, 999, 21, 0, -1},       // Target Sensor Timer
         new int[] { 0X75, 1, 1, 0, 1, 0, 0, 1, 20, 0, 18},         // Target Sensor Filter
         new int[] { 0X76, 1, 1, 0, 2, 0, 0, 9999, 19, 0, -1},      // Targer Sensor Filter Value
         new int[] { 0X77, 1, 1, 0, 1, 0, 0, 2, 7, 0, -1},          // Ink Drop Charge Rule
         new int[] { 0X78, 1, 1, 0, 2, 0, -50, +50, 12, 0, -1},     // Print Start Position Adjustment Value
      };

      // Calendar (Class Code = 0x69) Complete!
      public static int[][] Calendar = new int[][] {
         new int[] { 0X65, 0, 1, 0, 1, 0, 0, 0, 10, 0, -1},      // Shift Count Condition
         new int[] { 0X66, 0, 1, 0, 1, 0, 0, 8, 3, 0, -1},       // First Calendar Block Number
         new int[] { 0X67, 0, 1, 0, 1, 0, 0, 8, 1, 0, -1},       // Calendar Block Number In Item
         new int[] { 0X68, 1, 1, 0, 1, 0, 0, 99, 8, 0, -1},      // Offset Year
         new int[] { 0X69, 1, 1, 0, 1, 0, 0, 99, 7, 0, -1},      // Offset Month
         new int[] { 0X6A, 1, 1, 0, 2, 0, 0, 1999, 4, 0, -1},    // Offset Day
         new int[] { 0X6B, 1, 1, 0, 2, 0, -23, 99, 5, 0, -1},    // Offset Hour
         new int[] { 0X6C, 1, 1, 0, 2, 0, -59, 99, 6, 0, -1},    // Offset Minute
         new int[] { 0X6D, 1, 1, 0, 1, 0, 0, 2, 32, 0, 2},       // Zero Suppress Year
         new int[] { 0X6E, 1, 1, 0, 1, 0, 0, 2, 30, 0, 2},       // Zero Suppress Month
         new int[] { 0X6F, 1, 1, 0, 1, 0, 0, 2, 26, 0, 2},       // Zero Suppress Day
         new int[] { 0X70, 1, 1, 0, 1, 0, 0, 2, 28, 0, 2},       // Zero Suppress Hour
         new int[] { 0X71, 1, 1, 0, 1, 0, 0, 2, 29, 0, 2},       // Zero Suppress Minute
         new int[] { 0X72, 1, 1, 0, 1, 0, 0, 2, 31, 0, 2},       // Zero Suppress Weeks
         new int[] { 0X73, 1, 1, 0, 1, 0, 0, 2, 27, 0, 2},       // Zero Suppress Day Of Week
         new int[] { 0X74, 1, 1, 0, 1, 0, 0, 1, 21, 0, 1},       // Substitute Rule Year
         new int[] { 0X75, 1, 1, 0, 1, 0, 0, 1, 19, 0, 1},       // Substitute Rule Month
         new int[] { 0X76, 1, 1, 0, 1, 0, 0, 1, 15, 0, 1},       // Substitute Rule Day
         new int[] { 0X77, 1, 1, 0, 1, 0, 0, 1, 17, 0, 1},       // Substitute Rule Hour
         new int[] { 0X78, 1, 1, 0, 1, 0, 0, 1, 18, 0, 1},       // Substitute Rule Minute
         new int[] { 0X79, 1, 1, 0, 1, 0, 0, 1, 20, 0, 1},       // Substitute Rule Weeks
         new int[] { 0X7A, 1, 1, 0, 1, 0, 0, 1, 16, 0, 1},       // Substitute Rule Day Of Week
         new int[] { 0X7B, 1, 1, 0, 3, 1, 0, 0, 24, 0, -1},      // Time Count Start Value
         new int[] { 0X7C, 1, 1, 0, 3, 1, 0, 0, 22, 0, -1},      // Time Count End Value
         new int[] { 0X7D, 1, 1, 0, 3, 1, 0, 0, 23, 0, -1},      // Time Count Reset Value
         new int[] { 0X7E, 1, 1, 0, 1, 0, 0, 23, 9, 0, -1},      // Reset Time Value
         new int[] { 0X7F, 1, 1, 0, 1, 0, 1, 6, 25, 0, -1},      // Update Interval Value
         new int[] { 0X80, 1, 1, 0, 1, 0, 0, 23, 13, 0, -1},     // Shift Start Hour
         new int[] { 0X81, 1, 1, 0, 1, 0, 0, 59, 14, 0, -1},     // Shift Start Minute
         new int[] { 0X82, 1, 1, 0, 1, 0, 0, 23, 11, 0, -1},     // Shift End Hour
         new int[] { 0X83, 1, 1, 0, 1, 0, 0, 59, 12, 0, -1},     // Shift End Minute
         new int[] { 0X84, 1, 1, 0, 10, 1, 0, 0, 2, 0, -1},      // Count String Value
      };

      // User Pattern (Class Code 0x6B) Complete!
      public static int[][] UserPattern = new int[][] {
         new int[] { 0X64, 1, 1, 0, 0, 0, 0, 0, 1, 1, -1}, // User Pattern Fixed
         new int[] { 0X65, 1, 1, 0, 0, 0, 0, 0, 2, 1, -1}, // User Pattern Free
     };

      // Substitution Rules(Class Code 0x6C) Complete!
      public static int[][] SubstitutionRules = new int[][] {
         new int[] { 0X64, 1, 1, 0, 1, 0, 1, 99, 3, 0, -1},    // Number
         new int[] { 0X65, 1, 1, 0, 1, 1, 0, 0, 2, 1, -1},     // Name
         new int[] { 0X66, 1, 1, 0, 2, 0, 0, 0, 1, 0, -1},     // Start Year
         new int[] { 0X67, 1, 1, 0, 3, 1, 0, 0, 10, 0, -1},    // Year
         new int[] { 0X68, 1, 1, 0, 0, 1, 0, 0, 8, 0, -1},     // Month
         new int[] { 0X69, 1, 1, 0, 0, 1, 0, 0, 4, 0, -1},     // Day
         new int[] { 0X6A, 1, 1, 0, 0, 1, 0, 0, 6, 0, -1},     // Hour
         new int[] { 0X6B, 1, 1, 0, 0, 1, 0, 0, 7, 0, -1},     // Minute
         new int[] { 0X6C, 1, 1, 0, 0, 1, 0, 0, 9, 0, -1},     // Week
         new int[] { 0X6D, 1, 1, 0, 0, 1, 0, 0, 5, 0, -1},     // Day Of Week
      };

      // Enviroment Setting (Class Code 0x71) Complete!
      public static int[][] EnviromentSetting = new int[][] {
         new int[] { 0X65, 1, 1, 0, 12, 2, 0, 0, 5, 0, -1},    // Current Time
         new int[] { 0X66, 1, 1, 0, 12, 2, 0, 0, 1, 0, -1},    // Calendar Date Time
         new int[] { 0X67, 1, 1, 0, 1, 0, 1, 2, 2, 0, 4},      // Calendar Date Time Availibility
         new int[] { 0X68, 1, 1, 0, 1, 0, 1, 2, 4, 0, 3},      // Clock System
         new int[] { 0X69, 0, 1, 0, 16, 0, 0, 0, 8, 0, -1},    // User Environment Information
         new int[] { 0X6A, 0, 1, 0, 12, 0, 0, 0, 3, 0, -1},    // Cirulation Control Setting Value
         new int[] { 0X6B, 1, 0, 0, 2, 0, 0, 0, 7, 0, -1},     // Usage Time Of Circulation Control
         new int[] { 0X6C, 1, 0, 0, 0, 0, 0, 0, 6, 0, -1},     // Reset Usage Time Of Citculation Control
      };

      // Unit Information (Class Code 0x73) Complete!
      public static int[][] UnitInformation = new int[][] {
         new int[] { 0X64, 0, 1, 0, 64, 1, 0, 0, 20, 0, -1},       // Unit Information
         new int[] { 0X6B, 0, 1, 0, 12, 1, 0, 0, 15, 0, -1},       // Model Name
         new int[] { 0X6C, 0, 1, 0, 8, 0, 0, 0, 17, 0, -1},        // Serial Number
         new int[] { 0X6D, 0, 1, 0, 28, 1, 0, 0, 8, 0, -1},        // Ink Name
         new int[] { 0X6E, 0, 1, 0, 1, 0, 0, 0, 9, 0, -1},         // Input Mode
         new int[] { 0X6F, 0, 1, 0, 2, 0, 240, 1000, 11, 0, -1},   // Maximum Character Count
         new int[] { 0X70, 0, 1, 0, 2, 0, 300, 2000, 13, 0, -1},   // Maximum Registered Message Count
         new int[] { 0X71, 0, 1, 0, 1, 0, 1, 2, 1, 0, -1},         // Barcode Information
         new int[] { 0X72, 0, 1, 0, 1, 0, 0, 0, 21, 0, -1},        // Usable Character Size
         new int[] { 0X73, 0, 1, 0, 1, 0, 3, 8, 10, 0, -1},        // Maximum Calendar And Count
         new int[] { 0X74, 0, 1, 0, 1, 0, 48, 99, 14, 0, -1},      // Maximum Substitution Rule
         new int[] { 0X75, 0, 1, 0, 1, 0, 0, 99, 18, 0, -1},       // Shift Code And Time Count
         new int[] { 0X76, 0, 1, 0, 1, 0, 0, 0, 3, 0, -1},         // Chimney And DIN Print
         new int[] { 0X77, 0, 1, 0, 1, 0, 0, 0, 12, 0, -1},        // Maximum Line Count
         new int[] { 0X78, 0, 1, 0, 5, 1, 0, 0, 2, 0, -1},         // Basic Software Version
         new int[] { 0X79, 0, 1, 0, 5, 1, 0, 0, 4, 0, -1},         // Controller Software Version
         new int[] { 0X7A, 0, 1, 0, 5, 1, 0, 0, 5, 0, -1},         // Engine M Software Version
         new int[] { 0X7B, 0, 1, 0, 5, 1, 0, 0, 6, 0, -1},         // Engine S Software Version
         new int[] { 0X7C, 0, 1, 0, 5, 1, 0, 0, 7, 0, -1},         // First Language Version
         new int[] { 0X7D, 0, 1, 0, 5, 1, 0, 0, 16, 0, -1},        // Second Language Version
         new int[] { 0X7E, 0, 1, 0, 5, 1, 0, 0, 19, 1, -1},        // Software Option Version
      };

      // Operation Management (Class Code 0x74) Complete!
      public static int[][] OperationManagement = new int[][] {
         new int[] { 0X64, 0, 1, 0, 2, 1, 0, 0, 12, 0, -1},   // Operating Management
         new int[] { 0X65, 1, 1, 0, 2, 0, 0, 0, 9, 0, -1},    // Ink Operating Time
         new int[] { 0X66, 1, 1, 0, 2, 0, 0, 0, 1, 0, -1},    // Alarm Time
         new int[] { 0X67, 1, 1, 0, 2, 0, 0, 0, 13, 0, -1},   // Print Count
         new int[] { 0X68, 0, 1, 0, 2, 0, 0, 0, 3, 0, -1},    // Communications Environment
         new int[] { 0X69, 0, 1, 0, 2, 0, 0, 0, 4, 0, -1},    // Cumulative Operation Time
         new int[] { 0X6A, 0, 1, 0, 2, 1, 0, 0, 8, 0, -1},    // Ink And Makeup Name
         new int[] { 0X6B, 0, 1, 0, 2, 0, 0, 0, 11, 0, -1},   // Ink Viscosity
         new int[] { 0X6C, 0, 1, 0, 2, 0, 0, 0, 10, 0, -1},   // Ink Pressure
         new int[] { 0X6D, 0, 1, 0, 2, 0, 0, 0, 2, 0, -1},    // Ambient Temperature
         new int[] { 0X6E, 0, 1, 0, 2, 0, 0, 0, 5, 0, -1},    // Deflection Voltage
         new int[] { 0X6F, 0, 1, 0, 2, 0, 0, 0, 7, 0, -1},    // Excitation VRef Setup Value
         new int[] { 0X70, 0, 1, 0, 2, 0, 0, 0, 6, 0, -1},    // Excitation Frequency
     };

      // IJP Operation (Class Code 0x75) Complete!
      public static int[][] IJPOperation = new int[][] {
         new int[] { 0X64, 0, 1, 0, 1, 3, 0, 0, 7, 0, -1},    // Remote operation information
         new int[] { 0X66, 0, 1, 0, 6, 3, 0, 0, 4, 0, -1},    // Fault and warning history
         new int[] { 0X67, 0, 1, 0, 1, 3, 0, 0, 6, 0, -1},    // Operating condition
         new int[] { 0X68, 0, 1, 0, 1, 3, 0, 0, 10, 0, -1},   // Warning condition
         new int[] { 0X6A, 0, 1, 0, 10, 2, 0, 0, 1, 0, -1},   // Date and time information
         new int[] { 0X6B, 0, 1, 0, 1, 3, 0, 0, 3, 0, -1},    // Error code
         new int[] { 0X6C, 0, 0, 1, 0, 3, 0, 0, 8, 0, -1},    // Start Remote Operation
         new int[] { 0X6D, 0, 0, 1, 0, 3, 0, 0, 9, 0, -1},    // Stop Remote Operation
         new int[] { 0X6E, 0, 0, 1, 0, 3, 0, 0, 2, 0, -1},    // Deflection voltage control
         new int[] { 0X6F, 1, 1, 0, 1, 0, 0, 1, 5, 0, 5},     // Online Offline
      };

      // Count (Class Code 0x79) Complete!
      public static int[][] Count = new int[][] {
         new int[] { 0X66, 0, 1, 0, 0, 0, 0, 0, 12, 0, -1},   // Number Of Count Block
         new int[] { 0X67, 1, 1, 0, 0, 1, 0, 0, 9, 0, -1},    // Initial Value
         new int[] { 0X68, 1, 1, 0, 0, 1, 0, 0, 4, 0, -1},    // Count Range 1
         new int[] { 0X69, 1, 1, 0, 0, 1, 0, 0, 5, 0, -1},    // Count Range 2
         new int[] { 0X6A, 1, 1, 0, 0, 0, 0, 0, 15, 0, -1},   // Update Unit Halfway
         new int[] { 0X6B, 1, 1, 0, 0, 0, 0, 0, 16, 0, -1},   // Update Unit Unit
         new int[] { 0X6C, 1, 1, 0, 1, 0, 0, 0, 8, 0, -1},    // Increment Value
         new int[] { 0X6D, 1, 1, 0, 1, 0, 1, 2, 7, 0, 7},     // Direction Value
         new int[] { 0X6E, 1, 1, 0, 0, 1, 0, 0, 10, 0, -1},   // Jump From
         new int[] { 0X6F, 1, 1, 0, 0, 1, 0, 0, 11, 0, -1},   // Jump To
         new int[] { 0X70, 1, 1, 0, 0, 1, 0, 0, 13, 0, -1},   // Reset Value
         new int[] { 0X71, 1, 1, 0, 1, 0, 0, 0, 14, 0, 6},    // Type Of Reset Signal
         new int[] { 0X72, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1},     // Availibility Of External Count
         new int[] { 0X73, 1, 1, 0, 1, 0, 0, 0, 2, 0, 1},     // Availibility Of Zero Suppression
         new int[] { 0X74, 1, 1, 0, 0, 0, 0, 0, 3, 0, -1},    // Count Multiplier
         new int[] { 0X75, 1, 1, 0, 0, 0, 0, 0, 6, 0, -1},    // Count Skip
      };

      // Index (Class Code 0x7A) Complete!
      public static int[][] Index = new int[][] {
         new int[] { 0X64, 1, 1, 0, 1, 0, 0, 2, 10, 0, -1},     // Start Stop Management Flag
         new int[] { 0X65, 1, 1, 0, 1, 0, 0, 1, 1, 0, -1},      // Automatic reflection
         new int[] { 0X66, 1, 1, 0, 2, 0, 1, 100, 6, 0, -1},    // Item Count
         new int[] { 0X67, 1, 1, 0, 2, 0, 0, 99, 4, 0, -1},     // Column
         new int[] { 0X68, 1, 1, 0, 1, 0, 1, 6, 7, 0, 0},       // Line
         new int[] { 0X69, 1, 1, 0, 2, 0, 1, 1000, 3, 0, -1},   // Character position
         new int[] { 0X6A, 1, 1, 0, 2, 0, 1, 2000, 9, 0, -1},   // Print Data Message Number
         new int[] { 0X6B, 1, 1, 0, 1, 0, 1, 99, 8, 0, -1},     // Print Data Group Data
         new int[] { 0X6C, 1, 1, 0, 1, 0, 1, 99, 11, 0, -1},    // Substitution Rules Setting
         new int[] { 0X6D, 1, 1, 0, 1, 0, 1, 19, 12, 0, -1},    // User Pattern Size
         new int[] { 0X6E, 1, 1, 0, 1, 0, 1, 8, 5, 0, 0},       // Count Block
         new int[] { 0X6F, 1, 1, 0, 1, 0, 1, 8, 2, 0, 0},       // Calendar Block
      };

      #endregion

      #region Conversion Tables

      // Attribute DropDown conversion
      public static string[][] DropDowns = new string[][] {
         new string[] { },                                            // 0 - Just decimal values
         new string[] { "Disable", "Enable" },                        // 1 - Enable and disable
         new string[] { "Disable", "Space Fill", "Character Fill" },  // 2 - Disable, space fill, character fill
         new string[] { "TwentyFour Hour", "Twelve Hour" },           // 3 - 12 & 24 hour
         new string[] { "Current Time", "Stop Clock" },               // 4 - Current time or stop clock
         new string[] { "Off Line", "On Line" },                      // 5 - Offline/Online
         new string[] { "None", "Signal 1", "Signal 2" },             // 6 - None, Signal 1, Signal 2
         new string[] { "Up", "Down" },                               // 7 - Up/Down
         new string[] { "None", "5X5", "5X7" },                       // 8 - Readable Code 5X5 or 5X7
         new string[] { "not used", "code 39", "ITF", "NW-7", "EAN-13", "DM8x32", "DM16x16", "DM16x36",
                        "DM16x48", "DM18x18", "DM20x20", "DM22x22", "DM24x24", "Code 128 (Code set B)",
                        "Code 128 (Code set C)", "UPC-A", "UPC-E", "EAN-8", "QR21x21", "QR25x25", "QR29x29",
                        "GS1 DataBar (Limited)", "GS1 DataBar (Omnidirectional)", "GS1 DataBar (Stacked)", "DM14x14", },
                                                                      // 9 - Barcode Types
         new string[] { "Normal", "Reverse" },                        // 10 - Normal/reverse
         new string[] { "M 15%", "Q 25%" },                           // 11 - M 15%, Q 25%
         new string[] { "Edit Message", "Print Format" },             // 12 - Edit/Print
         new string[] { "From Yesterday", "From Today" },             // 13 - From Yesterday/Today
         new string[] { "4x5", "5x5", "5x8(5x7)", "9x8(9x7)", "7x10", "10x12", "12x16", "18x24", "24x32",
                        "11x11", "5x3(Chimney)", "5x5(Chimney)", "7x5(Chimney)", "QR33", "30x40", "36x48"  },
                                                                      // 14 - Font Types
         new string[] { "Normal/Forward", "Normal/Reverse",
                         "Inverted/Forward", "Inverted/Reverse",},    // 15 - Orientation
         new string[] { "None", "Encoder", "Auto" },                  // 16 - Product speed matching
         new string[] { "HM", "NM", "QM", "SM" },                     // 17 - High Speed Print
         new string[] { "Time Setup", "Until End of Print" },         // 18 - Target Sensor Filter
         new string[] { "4x5", "5x5", "5x8(5x7)", "9x8(9x7)", "7x10", "10x12", "12x16", "18x24", "24x32",
                        "11x11", "5x3(Chimney)", "5x5(Chimney)", "7x5(Chimney)", "30x40", "36x48"  },
                                                                      // 19 - User Pattern Font Types
      };

      // Class Codes to Attributes
      public static Type[] ClassCodeAttributes = new Type[] {
            typeof(ccPDM),   // 0x66 Print data management function
            typeof(ccPF),    // 0x67 Print format function
            typeof(ccPS),    // 0x68 Print specification function
            typeof(ccCal),   // 0x69 Calendar function
            typeof(ccUP),    // 0x6B User pattern function
            typeof(ccSR),    // 0x6C Substitution rules function
            typeof(ccES),    // 0x71 Enviroment setting function
            typeof(ccUI),    // 0x73 Unit Information function
            typeof(ccOM),    // 0x74 Operation management function
            typeof(ccIJP),   // 0x75 IJP operation function
            typeof(ccCount), // 0x79 Count function
            typeof(ccIDX),   // 0x7A Index function
         };

      // Class Names
      public static string[] ClassNames = Enum.GetNames(typeof(ClassCode));

      // Class Codes
      public static ClassCode[] ClassCodes = (ClassCode[])Enum.GetValues(typeof(ClassCode));

      // Class Codes with Sort Order
      public static int[,] ClassCodeSort = new int[,] {
         { 0X66, 7},   // Print data management function
         { 0X67, 8},   // Print format function
         { 0X68, 9},   // Print specification function
         { 0X69, 1},   // Calendar function
         { 0X6B, 12},  // User pattern function
         { 0X6C, 10},  // Substitution rules function
         { 0X71, 3},   // Enviroment setting function
         { 0X73, 11},  // Unit Information function
         { 0X74, 6},   // Operation management function
         { 0X75, 4},   // IJP operation function
         { 0X79, 2},   // Count function
         { 0X7A, 5},   // Index function
      };

      // Class Codes to Data Tables Conversion
      public static int[][][] ClassCodeData = new int[][][] {
            PrintDataManagement,           // 0x66 Print data management function
            PrintFormat,                   // 0x67 Print format function
            PrintSpecification,            // 0x68 Print specification function
            Calendar,                      // 0x69 Calendar function
            UserPattern,                   // 0x6B User pattern function
            SubstitutionRules,             // 0x6C Substitution rules function
            EnviromentSetting,             // 0x71 Enviroment setting function
            UnitInformation,               // 0x73 Unit Information function
            OperationManagement,           // 0x74 Operation management function
            IJPOperation,                  // 0x75 IJP operation function
            Count,                         // 0x79 Count function
            Index,                         // 0x7A Index function
         };

      #endregion

      #region Service Routines

      // Lookup for getting attributes associated with a Class/Function
      public static Dictionary<ClassCode, byte, AttrData> AttrDict;

      // Get attribute data for an arbitrary class/attribute
      public static AttrData GetAttrData(ClassCode Class, byte attr) {
         int[][] tab = ClassCodeData[Array.IndexOf(ClassCodes, Class)];
         for (int j = 0; j < tab.Length; j++) {
            if ((byte)tab[j][0] == attr) {
               return new AttrData(tab[j]);
            }
         }
         return null;
      }

      // Build the Attribute Dictionary
      public static void BuildAttributeDictionary() {
         if (AttrDict == null) {
            AttrDict = new Dictionary<ClassCode, byte, AttrData>();
            for (int i = 0; i < ClassCodes.Length; i++) {
               int[] ClassAttr = (int[])ClassCodeAttributes[i].GetEnumValues();
               for (int j = 0; j < ClassAttr.Length; j++) {
                  AttrDict.Add(ClassCodes[i], (byte)ClassAttr[j], GetAttrData(ClassCodes[i], (Byte)ClassAttr[j]));
               }
            }
         }
      }

      #endregion

   }

   public class ClassCodeData {

      #region Properties and Constructor

      // Class Codes = { 
      //   [0] = value, 
      //   [1] = AlphaSortOrder }

      int[] values;

      public byte Val { get { return (byte)values[0]; } }
      public int Order { get { return values[1] - 1; } }

      public ClassCodeData(int[] values) {
         this.values = values;
      }

      #endregion

   }

   public class AttrDataII<t> {
      public AttrDataII(t Val, GSS acc, Prop data, Prop data2, bool Ignore = false) {

      }

      public AttrDataII(t Val, GSS acc, Prop data, bool Ignore = false) {

      }

   }

   public class AttrData {

      #region Properties and Constructor

      // Class Code Attributes = {
      //   [0] = Value
      //   [1] = Set Available
      //   [2] = Get Available
      //   [3] = Service Available
      //   [4] = Data Length
      //   [5] = Format
      //   [6] = Min Value
      //   [7] = Max Value
      //   [8] = AlphaSortOrder 
      //   [9] = Ignore due to error
      //   [10] = Drop Down
      //   [11] = Data Length
      //   [12] = Format
      //   [13] = Min Value
      //   [14] = Max Value

      public byte Val { get; set; } = 0;
      public bool HasSet { get; set; } = false;
      public bool HasGet { get; set; } = false;
      public bool HasService { get; set; } = false;
      public int Order { get; set; } = 0;
      public bool Ignore { get; set; } = false;
      public int DropDown { get; set; } = -1;

      public Prop Data { get; set; }
      public Prop Get { get; set; }
      public Prop Set { get; set; }
      public Prop Service { get; set; }

      public AttrData() {

      }

      public AttrData(int[] values) {
         Val = (byte)values[0];
         HasSet = values[1] > 0;
         HasGet = values[2] > 0;
         HasService = values[3] > 0;
         Order = values[8] - 1;
         Ignore = values[9] > 0;
         DropDown = values[10];

         Data = new Prop(values[4], (DataFormats)values[5], values[6], values[7]);
         if (HasSet) {
            Set = Data;
         }
         if (values.Length == 11) {
            if (HasGet) {
               Get = new Prop(0, DataFormats.Decimal, 0, 0);
            } else if (HasService) {
               Service = Get = new Prop(0, DataFormats.Decimal, 0, 0);
            }
         } else {
            if (HasGet) {
               Get = new Prop(values[11], (DataFormats)values[12], values[13], values[14]);
            } else if (HasService) {
               Service = new Prop(values[11], (DataFormats)values[12], values[13], values[14]);
            }
         }

      }

      #endregion

   }

   public class Dictionary<TKey1, TKey2, TValue> 
      : Dictionary<Tuple<TKey1, TKey2>, TValue>, IDictionary<Tuple<TKey1, TKey2>, TValue> {

      #region Constructor and methods

      public TValue this[TKey1 key1, TKey2 key2] {
         get { return base[Tuple.Create(key1, key2)]; }
         set { base[Tuple.Create(key1, key2)] = value; }
      }

      public void Add(TKey1 key1, TKey2 key2, TValue value) {
         base.Add(Tuple.Create(key1, key2), value);
      }

      #endregion

   }

   public class Prop {

      #region Constructors, properties and methods

      public int Len { get; set; }
      public DataFormats Fmt { get; set; }
      public long Min { get; set; }
      public long Max { get; set; }
      public fmtDD DropDown { get; set; }

      public Prop(int Len, DataFormats Fmt, long Min, long Max, fmtDD DropDown = fmtDD.None) {
         this.Len = Len;
         this.Fmt = Fmt;
         this.Min = Min;
         this.Max = Max;
         this.DropDown = DropDown;
      }

      #endregion

   }
}
