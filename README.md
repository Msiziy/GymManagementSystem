# UKZN Gym Management System

## Overview

The UKZN Gym Management System is a desktop-based gym management application developed for UKZN Sport to automate and streamline daily gym operations. The system replaces manual paper-based processes with a centralized, database-driven solution that manages members, staff, training sessions, membership plans, payments, and reporting.

The application was developed using C# Windows Forms and SQL Server 2018, following a 3-tier architecture consisting of the Presentation Layer, Business Logic Layer, and Data Layer.

---

## Project Information

| Item                 | Description                                     |
| -------------------- | ----------------------------------------------- |
| System Name          | UKZN Gym Management System                      |
| Development Language | C# (.NET Framework 4.7.2)                       |
| IDE                  | Visual Studio 2022                              |
| Database             | SQL Server 2018                                 |
| UI Framework         | Windows Forms (WinForms) with Guna2 UI Controls |
| Reporting Tool       | SAP Crystal Reports                             |
| Architecture         | 3-Tier Client-Server Architecture               |

---

## Problem Statement

Many gym facilities rely on manual record keeping for member registration, payment tracking, trainer scheduling, and report generation. These manual processes often lead to:

* Lost or duplicated records
* Payment tracking errors
* Scheduling conflicts
* Poor reporting capabilities
* Inefficient administrative processes

The UKZN Gym Management System addresses these challenges by automating gym operations and providing a centralized management platform.

---

## System Features

### Authentication & Access Control

* Secure Login System
* Password Reset Functionality
* Role-Based Access Control
* Show/Hide Password Feature

### Member Management

* Register New Members
* Update Member Details
* View Member Profiles
* Search Members
* Manage Free and Premium Membership Plans

### Staff Management

* Register Staff Members
* Update Staff Information
* View Trainers
* Manage Staff Accounts

### Training Session Management

* Book Training Sessions
* Assign Trainers
* View Training Schedules
* Manage Trainer Availability
* View Session Attendance

### Payment Management

* Process Membership Payments
* View Payment History
* Generate Payment Confirmations
* Track Outstanding Payments

### Reporting

* Member Reports
* Payment Reports
* Training Session Reports
* Dashboard Statistics

---

## User Roles

### Manager

Managers have access to:

* Staff Management
* Membership Plan Management
* System Reports
* Dashboard Statistics
* Session Monitoring
* Payment Monitoring

### Receptionist

Receptionists can:

* Register Members
* Update Member Information
* Process Payments
* Book Training Sessions
* Search Members
* View Registrations

### Trainer

Trainers can:

* View Scheduled Sessions
* Manage Availability
* View Personal Dashboard
* Access Session Information

---

## Database Structure

### Main Tables

#### Member

Stores member information including:

* Member_ID, Personal Details, Contact Information, Membership Information, Emergency Contact Information

#### Staff

Stores staff information including:

* Staff_ID, Personal Details, Role Information, Contact Details

#### Membership

Stores membership plan details:

* Membership_ID, Member_ID, Plan Type, Start Date, End Date, Status, Monthly Fee

#### Payment

Stores payment records:

* Payment_ID, Member_ID, Membership_ID, Payment Date, Amount Paid, Payment Method

#### Training_Session

Stores training session information:

* Session_ID, Member_ID, Staff_ID, Session Date, Session Type, Attendance, Duration, Status

#### Time_Slot

Stores available session times:

* Time_ID, Start Time, End Time, Slot Description

#### Login

Stores user authentication information:

* Login_ID, Staff_ID, Email, Password, User Role

---

## System Architecture

The system follows a 3-Tier Architecture:

### Presentation Layer

* Windows Forms User Interface
* MDI Parent Forms
* User Interaction Components

### Business Logic Layer

* Input Validation
* Business Rules
* Error Handling
* Data Processing

### Data Layer

* SQL Server Database
* Typed DataSets
* TableAdapters
* Stored Procedures

---

## Reports Implemented

The system includes the following Crystal Reports:

### Member Report

Displays:

* Member Information
* Membership Details
* Registration Information

### Payment Report

Displays:

* Payment Transactions
* Membership Payments
* Revenue Information

### Training Session Report

Displays:

* Session Details
* Trainer Assignments
* Attendance Information

---

## Error Handling

The system includes:

* Try-Catch Exception Handling
* ErrorProvider Validation Controls
* Duplicate Record Detection
* Required Field Validation
* Numeric Validation
* Date Validation
* Database Error Handling

---

### Database Connection

The application connects to the UKZN SQL Server database through a configured connection string within the application settings.

---

## How to Run the Project

How to Run the Project
Prerequisites

Before running the application, ensure the following software is installed:

Visual Studio 2022
.NET Framework 4.7.2 or later
Microsoft SQL Server 2018 or later
SQL Server Management Studio (SSMS)
SAP Crystal Reports Runtime(2022) for Visual Studio

Setup Instructions
Clone or download the repository from GitHub.
Open the solution file (.sln) using Visual Studio 2022.
Build the solution (Build > Build Solution).
Run the application.

Login Credentials
 - Manager
  Email: mahlangum@ukzn.ac.za 
  Password: Madoda$Sport

- Trainer
  Email: kwanelefaniza2@gmail.com
  Password: Gym@123
  
- Receptionist
  Email: siyandakhethelo5@gmail.com
  Password: Siyanda@2005

********

Crystal Reports Requirement

To generate and print reports successfully, the SAP Crystal Reports Runtime must be installed on the machine running the application.

If Crystal Reports Runtime is not installed:

Reports may fail to load.
Report viewers may display errors.
Printing functionality may not work correctly.

Therefore, managers intending to generate Member Reports, Payment Reports, or Training Session Reports should install the Crystal Reports Runtime before using the reporting features.

## Testing Summary

The following major functionalities were successfully tested:

* Login Authentication
* Role Validation
* Password Verification
* Member Registration
* Duplicate Record Detection
* Payment Processing
* Training Session Booking
* Search Functionality
* Crystal Report Generation
* Input Validation

All test cases passed successfully.

---

## Future Enhancements

Potential future improvements include:

* Email Notifications
* SMS Appointment Reminders
* Online Member Portal
* Mobile Application Integration
* Advanced Analytics Dashboard
* Online Payment Gateway Integration

---


## License

This project was developed as part of the Applied Systems Analysis (ISTN3AS) module at the University of KwaZulu-Natal for academic purposes.
