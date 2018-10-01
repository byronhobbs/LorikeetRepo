CREATE DATABASE LorikeetApp
CHARACTER SET latin1
COLLATE latin1_swedish_ci;
-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8';
-- No objects to export
--
-- Set default database
--
USE LorikeetApp;

--
-- Create table `Member`
--
CREATE TABLE Member (
  MemberID int(11) NOT NULL,
  Aboriginal tinyint(1) DEFAULT NULL,
  Agency tinyint(1) DEFAULT NULL,
  Archived tinyint(1) DEFAULT NULL,
  BirthdayCard tinyint(1) DEFAULT NULL,
  Country varchar(50) DEFAULT NULL,
  CountryOfOrigin varchar(200) DEFAULT NULL,
  DateAltered datetime DEFAULT NULL,
  DateJoined datetime DEFAULT NULL,
  DateOfBirth datetime DEFAULT NULL,
  EmailAddress varchar(50) DEFAULT NULL,
  FirstName varchar(100) NOT NULL,
  MobileNumber varchar(20) DEFAULT NULL,
  PostCode varchar(7) DEFAULT NULL,
  ReceiveByMail tinyint(1) DEFAULT NULL,
  ReceiveNewsletter tinyint(1) DEFAULT NULL,
  Sex tinyint(1) DEFAULT NULL,
  State varchar(50) DEFAULT NULL,
  StreetAddress varchar(200) DEFAULT NULL,
  Studying tinyint(1) DEFAULT NULL,
  Suburb varchar(50) DEFAULT NULL,
  Surname varchar(100) NOT NULL,
  TelephoneNumber varchar(20) DEFAULT NULL,
  Volunteering tinyint(1) DEFAULT NULL,
  Working tinyint(1) DEFAULT NULL,
  ReturnToSender tinyint(1) DEFAULT NULL,
  PRIMARY KEY (MemberID)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

CREATE TABLE Login (
  LoginID int(11) NOT NULL AUTO_INCREMENT,
  Access int(11) DEFAULT NULL,
  LoginName varchar(50) DEFAULT NULL,
  LoginPass varchar(50) DEFAULT NULL,
  Pin int(11) DEFAULT NULL,
  PRIMARY KEY (LoginID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Staff`
--
CREATE TABLE Staff (
  StaffID int(11) NOT NULL AUTO_INCREMENT,
  LoginID int(11) NOT NULL,
  StaffName varchar(50) NOT NULL,
  PRIMARY KEY (StaffID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Lunch`
--
CREATE TABLE Lunch (
  LunchID int(11) NOT NULL AUTO_INCREMENT,
  Date datetime NOT NULL,
  Main tinyint(1) NOT NULL,
  Name varchar(50) NOT NULL,
  Paid tinyint(1) NOT NULL,
  StaffID int(11) DEFAULT NULL,
  TakeAway tinyint(1) NOT NULL,
  PRIMARY KEY (LunchID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE Lunch
ADD CONSTRAINT FK_Lunch_Staff FOREIGN KEY (StaffID)
REFERENCES Staff (StaffID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `DebitSystem`
--
CREATE TABLE DebitSystem (
  DebitID int(11) NOT NULL AUTO_INCREMENT,
  Credit decimal(18, 2) DEFAULT NULL,
  Date datetime NOT NULL,
  Debit decimal(18, 2) DEFAULT NULL,
  Details varchar(200) DEFAULT NULL,
  MemberID int(11) NOT NULL,
  RunningTotal decimal(18, 2) DEFAULT NULL,
  StaffID int(11) NOT NULL,
  PRIMARY KEY (DebitID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE DebitSystem
ADD CONSTRAINT FK_DebitSystem_Member FOREIGN KEY (MemberID)
REFERENCES Member (MemberID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create foreign key
--
ALTER TABLE DebitSystem
ADD CONSTRAINT FK_DebitSystem_Staff FOREIGN KEY (StaffID)
REFERENCES Staff (StaffID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `Guest`
--
CREATE TABLE Guest (
  GuestID int(11) NOT NULL AUTO_INCREMENT,
  FullName varchar(100) NOT NULL,
  Picture longblob NOT NULL,
  PRIMARY KEY (GuestID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `SignIn`
--
CREATE TABLE SignIn (
  SigninID int(11) NOT NULL AUTO_INCREMENT,
  GuestID int(11) DEFAULT NULL,
  MemberID int(11) DEFAULT NULL,
  MethodOfSigningIn varchar(50) DEFAULT NULL,
  Timein datetime DEFAULT NULL,
  Timeout datetime DEFAULT NULL,
  PRIMARY KEY (SigninID)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE SignIn
ADD CONSTRAINT FK_SignIn_Guest FOREIGN KEY (GuestID)
REFERENCES Guest (GuestID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create foreign key
--
ALTER TABLE SignIn
ADD CONSTRAINT FK_SignIn_Member FOREIGN KEY (MemberID)
REFERENCES Member (MemberID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `Resources`
--
CREATE TABLE Resources (
  UniqueID int(11) NOT NULL AUTO_INCREMENT,
  Color int(11) DEFAULT NULL,
  CustomField1 varchar(20) DEFAULT NULL,
  Image longblob DEFAULT NULL,
  ResourceID int(11) NOT NULL,
  ResourceName varchar(50) DEFAULT NULL,
  PRIMARY KEY (UniqueID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Picture`
--
CREATE TABLE Picture (
  PictureID int(11) NOT NULL AUTO_INCREMENT,
  MemberFacialRecognition longblob DEFAULT NULL,
  MemberID int(11) NOT NULL,
  MemberPicture longblob NOT NULL,
  PictureName varchar(256) NOT NULL,
  TimeStamp datetime DEFAULT NULL,
  PRIMARY KEY (PictureID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE Picture
ADD CONSTRAINT FK_Picture_Member FOREIGN KEY (MemberID)
REFERENCES Member (MemberID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `Note`
--
CREATE TABLE Note (
  NotesID int(11) NOT NULL AUTO_INCREMENT,
  Date datetime DEFAULT NULL,
  Editable tinyint(1) DEFAULT NULL,
  MemberID int(11) DEFAULT NULL,
  Notes varchar(255) DEFAULT NULL,
  StaffID int(11) DEFAULT NULL,
  PRIMARY KEY (NotesID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Menu`
--
CREATE TABLE Menu (
  MenuID int(11) NOT NULL AUTO_INCREMENT,
  DateMade datetime NOT NULL,
  MenuName varchar(200) NOT NULL,
  PRIMARY KEY (MenuID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `MedicationName`
--
CREATE TABLE MedicationName (
  MedicationNameID int(11) NOT NULL AUTO_INCREMENT,
  MedicationName varchar(20) NOT NULL,
  PRIMARY KEY (MedicationNameID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Medication`
--
CREATE TABLE Medication (
  MedicationID int(11) NOT NULL AUTO_INCREMENT,
  MedicationNameID int(11) NOT NULL,
  MemberID int(11) NOT NULL,
  PRIMARY KEY (MedicationID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE Medication
ADD CONSTRAINT FK_Medication_Member FOREIGN KEY (MemberID)
REFERENCES Member (MemberID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `Log`
--
CREATE TABLE Log (
  LogID int(11) NOT NULL AUTO_INCREMENT,
  DateTime datetime NOT NULL,
  ErrorCode int(11) NOT NULL,
  Message varchar(255) NOT NULL,
  RefreshCode int(11) NOT NULL,
  StaffID int(11) NOT NULL,
  PRIMARY KEY (LogID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 59,
AVG_ROW_LENGTH = 315,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Labels`
--
CREATE TABLE Labels (
  LabelID int(11) NOT NULL AUTO_INCREMENT,
  Color int(11) DEFAULT NULL,
  DisplayName varchar(50) DEFAULT NULL,
  MenuCaption varchar(50) DEFAULT NULL,
  Shortcut varchar(20) DEFAULT NULL,
  PRIMARY KEY (LabelID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `DiagnosisName`
--
CREATE TABLE DiagnosisName (
  DiagnosisNameID int(11) NOT NULL AUTO_INCREMENT,
  DiagnosisName varchar(255) NOT NULL,
  PRIMARY KEY (DiagnosisNameID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Diagnosis`
--
CREATE TABLE Diagnosis (
  DiagnosisID int(11) NOT NULL AUTO_INCREMENT,
  DiagnosisNameID int(11) NOT NULL,
  MemberID int(11) NOT NULL,
  PRIMARY KEY (DiagnosisID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE Diagnosis
ADD CONSTRAINT FK_Diagnosis_Member FOREIGN KEY (MemberID)
REFERENCES Member (MemberID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `Contact`
--
CREATE TABLE Contact (
  ContactID int(11) NOT NULL AUTO_INCREMENT,
  ContactAddress varchar(500) DEFAULT NULL,
  ContactName varchar(500) DEFAULT NULL,
  ContactPhone varchar(20) DEFAULT NULL,
  ContactType varchar(500) DEFAULT NULL,
  MemberID int(11) NOT NULL,
  PRIMARY KEY (ContactID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create foreign key
--
ALTER TABLE Contact
ADD CONSTRAINT FK_Contact_Member FOREIGN KEY (MemberID)
REFERENCES Member (MemberID) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Create table `AttendanceNumbers`
--
CREATE TABLE AttendanceNumbers (
  AttendanceNumbersID int(11) NOT NULL AUTO_INCREMENT,
  Date datetime DEFAULT NULL,
  Number int(11) DEFAULT NULL,
  PRIMARY KEY (AttendanceNumbersID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Attendance`
--
CREATE TABLE Attendance (
  AttendanceID int(11) NOT NULL AUTO_INCREMENT,
  Date datetime NOT NULL,
  MemberID int(11) DEFAULT NULL,
  PRIMARY KEY (AttendanceID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `AppointmentsNumbers`
--
CREATE TABLE AppointmentsNumbers (
  AppointmentsNumbers int(11) NOT NULL AUTO_INCREMENT,
  Date datetime DEFAULT NULL,
  LabelID int(11) DEFAULT NULL,
  Number int(11) DEFAULT NULL,
  PRIMARY KEY (AppointmentsNumbers)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `Appointments`
--
CREATE TABLE Appointments (
  UniqueID int(11) NOT NULL AUTO_INCREMENT,
  AllDay tinyint(1) DEFAULT NULL,
  CustomField1 varchar(20) DEFAULT NULL,
  Description varchar(20) DEFAULT NULL,
  EndDate datetime DEFAULT NULL,
  Label int(11) DEFAULT NULL,
  Location varchar(50) DEFAULT NULL,
  RecurrenceInfo varchar(20) DEFAULT NULL,
  ReminderInfo varchar(20) DEFAULT NULL,
  ResourceID int(11) DEFAULT NULL,
  ResourceIDs varchar(20) DEFAULT NULL,
  StartDate datetime DEFAULT NULL,
  Status int(11) DEFAULT NULL,
  Subject varchar(50) DEFAULT NULL,
  TimeZoneId varchar(20) DEFAULT NULL,
  Type int(11) DEFAULT NULL,
  PRIMARY KEY (UniqueID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;

--
-- Create table `AppointmentMember`
--
CREATE TABLE AppointmentMember (
  MemberActivityID int(11) NOT NULL AUTO_INCREMENT,
  AppointmentsID int(11) NOT NULL,
  MemberID int(11) NOT NULL,
  PRIMARY KEY (MemberActivityID)
)
ENGINE = INNODB,
CHARACTER SET latin1,
COLLATE latin1_swedish_ci;



CREATE TABLE GeocodeCache (
  GeocodeCacheID int(11) NOT NULL AUTO_INCREMENT,
  Location varchar(255) NOT NULL,
  Latitude decimal(15,10) NOT NULL,
  Longitude decimal(15,10) NOT NULL,
  PRIMARY KEY (GeocodeCacheID)
)
  ENGINE = INNODB,
  CHARACTER SET latin1,
  COLLATE latin1_swedish_ci;