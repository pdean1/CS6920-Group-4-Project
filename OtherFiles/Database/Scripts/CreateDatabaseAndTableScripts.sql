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
CREATE TABLE Users (
   UserID      INT UNSIGNED AUTO_INCREMENT NOT NULL,
   Email       VARCHAR(128)                NOT NULL,
   Password    VARCHAR(256)                NOT NULL,
   DateCreated DATETIME                    NOT NULL,
   DateUpdated DATETIME,
   CONSTRAINT User_PK PRIMARY KEY (UserID),
   CONSTRAINT User_Email_UK UNIQUE (Email)
); 
-- =====================================================================
-- BudgetTypes Table Creation Scripts                               
-- =====================================================================
CREATE TABLE BudgetTypes (
  BudgetTypeID INT UNSIGNED AUTO_INCREMENT NOT NULL,
  Title        VARCHAR(64)                 NOT NULL,
  Description  VARCHAR(256),
  CONSTRAINT BudgetType_PK PRIMARY KEY (BudgetTypeID)
);
-- =====================================================================
-- ExpenseCategories Table Creation Scripts                               
-- =====================================================================
CREATE TABLE ExpenseCategories (
  ExpenseCategoryID INT UNSIGNED AUTO_INCREMENT NOT NULL,
  Title             VARCHAR(64)                 NOT NULL,
  Description       VARCHAR(256),
  CONSTRAINT ExpenseCategory_PK PRIMARY KEY (ExpenseCategoryID)
);
-- =====================================================================
-- BillCategories Table Creation Scripts                               
-- =====================================================================
CREATE TABLE BillCategories (
  BillCategoryID INT UNSIGNED AUTO_INCREMENT NOT NULL,
  Title VARCHAR(64)                          NOT NULL,
  Description VARCHAR(256),
  CONSTRAINT BillCategory_PK PRIMARY KEY (BillCategoryID)
);
-- =====================================================================
-- EarningCategories Table Creation Scripts                               
-- =====================================================================
CREATE TABLE EarningCategories (
  EarningCategoryID INT UNSIGNED AUTO_INCREMENT NOT NULL,
  Title             VARCHAR(64) NOT NULL,
  Description       VARCHAR(256),
  CONSTRAINT EarningCategory_PK PRIMARY KEY (EarningCategoryID)
);
-- =====================================================================
-- Budgets Table Creation Scripts                               
-- =====================================================================
CREATE TABLE Budgets (
  BudgetID     INT UNSIGNED AUTO_INCREMENT NOT NULL,
  UserID       INT UNSIGNED NOT NULL,
  BudgetTypeID INT UNSIGNED NOT NULL,
  Title        VARCHAR(64)  NOT NULL,
  Description  VARCHAR(256),
  DateCreated  DATETIME     NOT NULL,
  CONSTRAINT Budget_PK PRIMARY KEY (BudgetID),
  CONSTRAINT Budget_User_FK FOREIGN KEY (UserID) 
    REFERENCES Users (UserID),
  CONSTRAINT Budget_BudgetType_FK FOREIGN KEY (BudgetTypeID) 
    REFERENCES BudgetTypes (BudgetTypeID),
  CONSTRAINT Budget_UserID_Title_UK UNIQUE (UserID, Title)
);
-- =====================================================================
-- Records Table Creation Scripts                               
-- =====================================================================
CREATE TABLE Records (
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
    REFERENCES Budgets (BudgetID)
);
-- =====================================================================
-- Earnings Table Creation Scripts                               
-- =====================================================================
CREATE TABLE Earnings (
    RecordID INT UNSIGNED NOT NULL,
    EarningCategoryID INT UNSIGNED NOT NULL,
    Amount NUMERIC(19 , 4 ) NOT NULL,
    DateEarned DATETIME NOT NULL,
    CONSTRAINT Earning_PK PRIMARY KEY (RecordID),
    CONSTRAINT Earning_Record_PK FOREIGN KEY (RecordID)
        REFERENCES Records (RecordID),
    CONSTRAINT Earning_EarningCategory_FK FOREIGN KEY (EarningCategoryID)
        REFERENCES EarningCategories (EarningCategoryID)
);
-- =====================================================================
-- Bills Table Creation Scripts                               
-- =====================================================================
CREATE TABLE Bills (
  RecordID       INT UNSIGNED  NOT NULL,
  BillCategoryID INT UNSIGNED  NOT NULL,
  Amount         NUMERIC(19,4) NOT NULL,
  DateDue        DATETIME      NOT NULL,
  DatePaid       DATETIME,
  CONSTRAINT Bill_PK PRIMARY KEY (RecordID),
  CONSTRAINT Bill_Record_FK FOREIGN KEY (RecordID) 
    REFERENCES Records (RecordID),
  CONSTRAINT Bill_BillCategory_FK FOREIGN KEY (BillCategoryID) 
    REFERENCES BillCategories (BillCategoryID)
); 
-- =====================================================================
-- Expenses Table Creation Scripts                               
-- ===================================================================== 
CREATE TABLE Expenses (
  RecordID          INT UNSIGNED  NOT NULL,
  ExpenseCategoryID INT UNSIGNED  NOT NULL,
  Amount            NUMERIC(19,4) NOT NULL,
  DateSpent         DateTime      NOT NULL,
  CONSTRAINT Expense_PK PRIMARY KEY (RecordID),
  CONSTRAINT Expense_Record_PK FOREIGN KEY (RecordID)  
    REFERENCES Records (RecordID),
  CONSTRAINT Expense_Cateogry_FK FOREIGN KEY (ExpenseCategoryID)
    REFERENCES ExpenseCategories (ExpenseCategoryID)
);