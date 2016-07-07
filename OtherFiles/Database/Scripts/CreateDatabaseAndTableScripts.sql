-- Author: Patrick Dean
-- Date:   2016-06-14
-- ---------------------------------------------------------------------
-- Description
-- This script contains the queries for deleting a the database, 
-- creating the database, and creating the database's tables.
-- Special Considerations
-- In the table, Records, there is a field, RecordType Char(1), this 
-- currently has three possible values:
--   'E' - Earning
--   'B' - Bill
--   'X' - Expense
-- ---------------------------------------------------------------------
DROP DATABASE IF EXISTS sql5123046;

CREATE DATABASE sql5123046;

USE sql5123046;
-- =====================================================================
-- Users Table Creation Scripts                               
-- =====================================================================
CREATE TABLE users (
   UserID      INT UNSIGNED AUTO_INCREMENT NOT NULL,
   -- Email       VARCHAR(128)                NOT NULL,
   FirstName   VARCHAR(48)                 NOT NULL,
   LastName    VARCHAR(48)                 NOT NULL, -- Might want to consider making this a nullable field I know many people with only one name
   UserName    VARCHAR(24)                 NOT NULL,
   Password    VARCHAR(256)                NOT NULL,
   DateCreated DATETIME                    NOT NULL,
   DateUpdated DATETIME,
   CONSTRAINT User_PK PRIMARY KEY (UserID),
   -- CONSTRAINT User_Email_UK UNIQUE (Email)
   CONSTRAINT User_UserName_UK UNIQUE (UserName)
); 
-- =====================================================================
-- Budgets Table Creation Scripts                               
-- =====================================================================
CREATE TABLE budgets (
  BudgetID     INT UNSIGNED AUTO_INCREMENT NOT NULL,
  UserID       INT UNSIGNED NOT NULL,
  Title        VARCHAR(64)  NOT NULL,
  Description  VARCHAR(256),
  DateCreated  DATETIME     NOT NULL,
  CONSTRAINT Budget_PK PRIMARY KEY (BudgetID),
  CONSTRAINT Budget_User_FK FOREIGN KEY (UserID) 
    REFERENCES users (UserID),
  CONSTRAINT Budget_UserID_Title_UK UNIQUE (UserID, Title)
);
-- =====================================================================
-- Records Table Creation Scripts                               
-- =====================================================================
CREATE TABLE records (
  RecordID    INT UNSIGNED AUTO_INCREMENT NOT NULL,
  BudgetID    INT UNSIGNED                NOT NULL, 
  -- RecordType Defaults to 'E' for Earning
  -- Possible values
  -- 'E' - Earnings
  -- 'B' - Bills
  -- 'X' - Expenses
  RecordType  CHAR(1)                     NOT NULL DEFAULT 'E',
  Title       VARCHAR(64)                 NOT NULL,
  Description VARCHAR(256),
  DateCreated DATETIME                    NOT NULL,
  CONSTRAINT Record_PK PRIMARY KEY (RecordID),
  CONSTRAINT Record_Budget FOREIGN KEY (BudgetID) 
    REFERENCES budgets (BudgetID)
	  ON DELETE CASCADE
	  ON UPDATE CASCADE
);
-- =====================================================================
-- Earnings Table Creation Scripts                               
-- =====================================================================
CREATE TABLE earnings (
    RecordID INT UNSIGNED NOT NULL,
    Amount NUMERIC(19 , 4 ) NOT NULL,
    DateEarned DATETIME NOT NULL,
    CONSTRAINT Earning_PK PRIMARY KEY (RecordID),
    CONSTRAINT Earning_Record_PK FOREIGN KEY (RecordID)
      REFERENCES records (RecordID)
		ON DELETE CASCADE
	    ON UPDATE CASCADE
);
-- =====================================================================
-- Bills Table Creation Scripts                               
-- =====================================================================
CREATE TABLE bills (
  RecordID       INT UNSIGNED  NOT NULL,
  Amount         NUMERIC(19,4) NOT NULL,
  DateDue        DATETIME      NOT NULL,
  DatePaid       DATETIME,
  CONSTRAINT Bill_PK PRIMARY KEY (RecordID),
  CONSTRAINT Bill_Record_FK FOREIGN KEY (RecordID) 
    REFERENCES records (RecordID)
	  ON DELETE CASCADE
	  ON UPDATE CASCADE
); 
-- =====================================================================
-- Expenses Table Creation Scripts                               
-- ===================================================================== 
CREATE TABLE expenses (
  RecordID          INT UNSIGNED  NOT NULL,
  Amount            NUMERIC(19,4) NOT NULL,
  DateSpent         DateTime      NOT NULL,
  CONSTRAINT Expense_PK PRIMARY KEY (RecordID),
  CONSTRAINT Expense_Record_PK FOREIGN KEY (RecordID)  
    REFERENCES records (RecordID)
	  ON DELETE CASCADE
	  ON UPDATE CASCADE
);