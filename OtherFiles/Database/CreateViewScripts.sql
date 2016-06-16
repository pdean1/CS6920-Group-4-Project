USE sql5123046;

CREATE OR REPLACE VIEW ViewBillRecords AS 
SELECT 
  R.RecordID, 
  R.BudgetID, 
  R.RecordType, 
  R.Title, 
  R.Description, 
  B.BillCategoryID,
  BC.Title AS BillCategoryTitle,
  BC.Description AS BillCategoryDescription,
  B.Amount,
  B.DateDue,
  B.DatePaid,
  R.DateCreated
FROM `sql5123046`.`records` AS R 
JOIN `sql5123046`.`Bills` AS B ON R.RecordID = B.RecordID 
JOIN `sql5123046`.`BillCategories` AS BC ON B.BillCategoryID = BC.BillCategoryID
WHERE R.RecordType = 'B';

CREATE OR REPLACE VIEW ViewEarningRecords AS 
SELECT 
  R.RecordID, 
  R.BudgetID, 
  R.RecordType, 
  R.Title, 
  R.Description, 
  E.EarningCategoryID,
  EC.Title AS Earning,
  EC.Description AS EarningCategoryDescription,
  E.Amount,
  E.DateEarned,
  R.DateCreated
FROM `sql5123046`.`records` AS R 
JOIN `sql5123046`.`earnings` AS E ON R.RecordID = E.RecordID 
JOIN `sql5123046`.`earningcategories` AS EC ON E.EarningCategoryID = EC.EarningCategoryID
WHERE R.RecordType = 'E';

CREATE OR REPLACE VIEW ViewExpenseRecords AS 
SELECT 
  R.RecordID, 
  R.BudgetID, 
  R.RecordType, 
  R.Title, 
  R.Description, 
  X.ExpenseCategoryID,
  XC.Title AS ExpenseCategoryTitle,
  XC.Description AS ExpenseCategoryDescription,
  X.Amount,
  X.DateSpent,
  R.DateCreated
FROM `sql5123046`.`records` AS R 
JOIN `sql5123046`.`expenses` AS X ON R.RecordID = X.RecordID 
JOIN `sql5123046`.`expensecategories` AS XC ON X.ExpenseCategoryID = XC.ExpenseCategoryID
WHERE R.RecordType = 'X';