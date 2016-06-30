USE sql5123046;

CREATE OR REPLACE VIEW viewbillrecords AS 
SELECT 
  R.RecordID, 
  R.BudgetID, 
  R.RecordType, 
  R.Title, 
  R.Description, 
  B.Amount,
  B.DateDue,
  B.DatePaid,
  R.DateCreated
FROM `sql5123046`.`records` AS R 
JOIN `sql5123046`.`bills` AS B ON R.RecordID = B.RecordID 
WHERE R.RecordType = 'B';

CREATE OR REPLACE VIEW viewearningrecords AS 
SELECT 
  R.RecordID, 
  R.BudgetID, 
  R.RecordType, 
  R.Title, 
  R.Description, 
  E.Amount,
  E.DateEarned,
  R.DateCreated
FROM `sql5123046`.`records` AS R 
JOIN `sql5123046`.`earnings` AS E ON R.RecordID = E.RecordID 
WHERE R.RecordType = 'E';

CREATE OR REPLACE VIEW viewexpenserecords AS 
SELECT 
  R.RecordID, 
  R.BudgetID, 
  R.RecordType, 
  R.Title, 
  R.Description, 
  X.Amount,
  X.DateSpent,
  R.DateCreated
FROM `sql5123046`.`records` AS R 
JOIN `sql5123046`.`expenses` AS X ON R.RecordID = X.RecordID 
WHERE R.RecordType = 'X';