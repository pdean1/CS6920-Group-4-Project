-- Author: Patrick Dean
-- Date:   2016-06-14
-----------------------------------------------------------------------
-- Description
-- TODO
DROP DATABASE IF EXISTS sql5123046;

CREATE DATABASE sql5123046;

USE sql5123046;
/**
 * Creates the User Table
 * Notes:
 */
CREATE TABLE Users (
   UserID      INT UNSIGNED AUTO_INCREMENT NOT NULL,
   Email       VARCHAR(128)                NOT NULL,
   Password    VARCHAR(256)                NOT NULL,
   DateCreated DATETIME                    NOT NULL,
   DateUpdated DATETIME,
   CONSTRAINT User_PK PRIMARY KEY (UserID),
   CONSTRAINT User_Email_UK UNIQUE (Email)
); 

/**
 *
 */
 CREATE TABLE BudgetTypes (
   BudgetTypeID INT UNSIGNED AUTO_INCREMENT NOT NULL,
   Title        VARCHAR(64) NOT NULL,
   Description  VARCHAR(256),
   CONSTRAINT BudgetType_PK PRIMARY KEY (BudgetTypeID),
   CONSTRAINT BudgetType_Title_UK UNIQUE (Title)
 );
 
 /**
  *
  */
 CREATE TABLE Budgets (
   BudgetID     INT UNSIGNED AUTO_INCREMENT NOT NULL,
   UserID       INT UNSIGNED NOT NULL,
   BudgetTypeID INT UNSIGNED NOT NULL,
   Title        VARCHAR(64)  NOT NULL,
   Description  VARCHAR(256),
   DateCreated  DATETIME     NOT NULL,
   CONSTRAINT Budget_PK PRIMARY KEY (BudgetID),
   CONSTRAINT Budget_User_FK FOREIGN KEY (UserID) 
     REFERENCES Users (UserID)
     ON UPDATE CASCADE 
     ON DELETE CASCADE,
   CONSTRAINT Budget_BudgetType_FK FOREIGN KEY (BudgetTypeID) 
     REFERENCES BudgetTypes (BudgetTypeID),
   CONSTRAINT Budget_UserID_Title_UK UNIQUE (UserID, Title)
 );
 
 CREATE TABLE EarningCategories (
   EarningCategoryID INT UNSIGNED AUTO_INCREMENT NOT NULL,
   Title             VARCHAR(64) NOT NULL,
   Description       VARCHAR(256),
   CONSTRAINT BudgetCategory_PK PRIMARY KEY (EarningCategoryID)
 );
 
 CREATE TABLE Earnings (
   EarningID INT UNSIGNED AUTO_INCREMENT NOT NULL,
   BudgetID INT UNSIGNED NOT NULL,
   EarningCategoryID INT UNSIGNED NOT NULL,
   Title VARCHAR(64)  NOT NULL,
   Description VARCHAR(256),
   Amount NUMERIC(19,4) NOT NULL,
   DateEarned DATETIME NOT NULL,
   DateCreated DATETIME NOT NULL, 
   CONSTRAINT Earning_PK PRIMARY KEY (EarningID),
   CONSTRAINT Earning_Budget_FK FOREIGN KEY (BudgetID) 
     REFERENCES Budgets (BudgetID),
   CONSTRAINT Earning_EarningCategory_FK FOREIGN KEY (EarningCategoryID) 
     REFERENCES EarningCategories (EarningCategoryID)
 );
 
 CREATE TABLE BillCategories (
   BillCategoryID INT UNSIGNED AUTO_INCREMENT NOT NULL,
   Title VARCHAR(64)  NOT NULL,
   Description VARCHAR(256),
   CONSTRAINT BillCategory_PK PRIMARY KEY (BillCategoryID)
 );
 
 CREATE TABLE Bills (
   BillID INT UNSIGNED AUTO_INCREMENT NOT NULL,
   BudgetID INT UNSIGNED NOT NULL,
   BillCategoryID INT UNSIGNED NOT NULL,
   Title VARCHAR(64)  NOT NULL,
   Description VARCHAR(256),
   AmountDue NUMERIC(19,4) NOT NULL,
   DateDue DATETIME NOT NULL,
   DatePaid DATETIME,
   DateCreated DATETIME NOT NULL,
   CONSTRAINT Bill_PK PRIMARY KEY (BillID),
   CONSTRAINT Bill_Budget_FK FOREIGN KEY (BudgetID) 
     REFERENCES Budgets (BudgetID),
   CONSTRAINT Bill_BillCategory_FK FOREIGN KEY (BillCategoryID) 
     REFERENCES BillCategories (BillCategoryID)
 );
 
 CREATE TABLE Payments (
   PaymentID INT UNSIGNED AUTO_INCREMENT NOT NULL,
   BillID INT UNSIGNED NOT NULL,
   Title VARCHAR(64)  NOT NULL,
   Description VARCHAR(256),
   AmountPaid NUMERIC(19,4) NOT NULL,
   PaymentDate DATETIME NOT NULL,
   DateCreated DATETIME NOT NULL,
   CONSTRAINT Payment_PK PRIMARY KEY (PaymentID),
   CONSTRAINT Payment_Bill_FK FOREIGN KEY (BillID) 
     REFERENCES Bills (BillID)
 );