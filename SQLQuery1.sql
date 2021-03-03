USE MASTER
CREATE DATABASE CUREHOSPITAL_DB
GO



USE	CUREHOSPITAL_DB
CREATE TABLE DoctorInformation
(
DoctorID INT PRIMARY KEY IDENTITY (1,2),
Name Varchar(50) Not Null,
ContactNo Varchar(15) Not Null,
Email Varchar(40) Not Null,
Department Varchar(40) Not Null,
DoctorImage Varchar(100) null
)
Go





--USE	CUREHOSPITAL_DB
--CREATE TABLE AdmissionInfo
--(
--AdmissionID INT PRIMARY KEY IDENTITY (1,3),
--AdmissionDate Varchar(50) Not Null

--)
--Go

USE	CUREHOSPITAL_DB
CREATE TABLE PatientInformation(
PatientID INT PRIMARY KEY IDENTITY (1,3),
Name Varchar(50) Not Null,
Age Varchar(50) Not Null,
Gender Varchar(20) Not Null,
ContactNo Varchar(15) Not Null,
Email Varchar(40) Not Null,
DoctorID int Foreign Key References DoctorInformation(DoctorID)
)
Go
