INSERT INTO `sql5123046`.`users` (`Email`, `Password`, `DateCreated`) VALUES ('test@test.com', 'password', '2016-06-15');
INSERT INTO `sql5123046`.`users` (`Email`, `Password`, `DateCreated`) VALUES ('test2@test.com', 'letmein', '2016-06.15');

INSERT INTO `sql5123046`.`budgettypes` (`Title`, `Description`) VALUES ('Monthly', 'Monthly budget');
INSERT INTO `sql5123046`.`budgettypes` (`Title`, `Description`) VALUES ('Vacation', 'Vacation budget');
INSERT INTO `sql5123046`.`budgettypes` (`Title`) VALUES ('Business');
INSERT INTO `sql5123046`.`budgettypes` (`Title`, `Description`) VALUES ('Semester', 'Budget for a semester');
INSERT INTO `sql5123046`.`budgettypes` (`Title`, `Description`) VALUES ('Project', 'Budget for a software project');
INSERT INTO `sql5123046`.`budgettypes` (`Title`) VALUES ('Software');

INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Groceries');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Gas');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Night on the Town');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Food');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Entertainment');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Education');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Work');
INSERT INTO `sql5123046`.`expensecategories` (`Title`) VALUES ('Other');

INSERT INTO `sql5123046`.`billcategories` (`Title`, `Description`) VALUES ('Rent', 'Monthly Rent');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Car Note');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Business Space Rent');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Water');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Power');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Gas');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Internet + Cable');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Cell Phone');
INSERT INTO `sql5123046`.`billcategories` (`Title`) VALUES ('Medical');
INSERT INTO `sql5123046`.`billcategories` (`Title`, `Description`) VALUES ('Credit Card', 'BOA');
INSERT INTO `sql5123046`.`billcategories` (`Title`, `Description`) VALUES ('Credit Card', 'AMA');
INSERT INTO `sql5123046`.`billcategories` (`Title`, `Description`) VALUES ('Other', 'Any other form of bill');

INSERT INTO `sql5123046`.`earningcategories` (`Title`, `Description`) VALUES ('Paycheck', 'Work');
INSERT INTO `sql5123046`.`earningcategories` (`Title`, `Description`) VALUES ('Paycheck', 'Other');
INSERT INTO `sql5123046`.`earningcategories` (`Title`, `Description`) VALUES ('Lawn service', 'Helping out the county with low cost lawn service');
INSERT INTO `sql5123046`.`earningcategories` (`Title`) VALUES ('Software');
INSERT INTO `sql5123046`.`earningcategories` (`Title`) VALUES ('Consultation');
INSERT INTO `sql5123046`.`earningcategories` (`Title`) VALUES ('Other');

INSERT INTO `sql5123046`.`budgets` (`UserID`, `BudgetTypeID`, `Title`, `Description`, `DateCreated`) VALUES ('1', '1', 'June 2016', 'June 2016 Test Budget', '2016-06-01');
INSERT INTO `sql5123046`.`budgets` (`UserID`, `BudgetTypeID`, `Title`, `Description`, `DateCreated`) VALUES ('1', '1', 'July 2016', 'July 2016 Monthly Budget', '2016-07-01');
INSERT INTO `sql5123046`.`budgets` (`UserID`, `BudgetTypeID`, `Title`, `Description`, `DateCreated`) VALUES ('2', '2', 'Tybee Island Vacation Budget', 'August 2016', '2016-06-01');

INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `Description`, `DateCreated`) VALUES ('1', 'E', 'Paycheck', '1st of the month', '2016-06-01');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `DateCreated`) VALUES ('1', 'X', 'Groceries', '2016-06-03');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `DateCreated`) VALUES ('1', 'X', 'Gas', '2016-06-04');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `DateCreated`) VALUES ('1', 'X', 'Clothing', '2016-06-06');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `DateCreated`) VALUES ('1', 'B', 'Car Payment', '2016-06-10');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `DateCreated`) VALUES ('1', 'B', 'Cable & Internet', '2016-06-11');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `Description`, `DateCreated`) VALUES ('1', 'E', 'Paycheck', '2nd of the month', '2016-06-15');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `DateCreated`) VALUES ('1', 'X', 'Gas', '2016-06-17');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `Description`, `DateCreated`) VALUES ('1', 'X', 'Atlanta Falcons Tickets', 'Sep. 11th Game agains Bucs', '2016-06-29');
INSERT INTO `sql5123046`.`records` (`BudgetID`, `RecordType`, `Title`, `Description`, `DateCreated`) VALUES ('1', 'B', 'Rent', 'Rent for July', '2016-06-29');

INSERT INTO `sql5123046`.`expenses` (`RecordID`, `ExpenseCategoryID`, `Amount`, `DateSpent`) VALUES ('2', '1', '125.45', '2016-06-02');
INSERT INTO `sql5123046`.`expenses` (`RecordID`, `ExpenseCategoryID`, `Amount`, `DateSpent`) VALUES ('3', '2', '19.28', '2016-06-03');
INSERT INTO `sql5123046`.`expenses` (`RecordID`, `ExpenseCategoryID`, `Amount`, `DateSpent`) VALUES ('4', '8', '72.63', '2016-06-12');
INSERT INTO `sql5123046`.`expenses` (`RecordID`, `ExpenseCategoryID`, `Amount`, `DateSpent`) VALUES ('8', '2', '19.47', '2016-06-16');
INSERT INTO `sql5123046`.`expenses` (`RecordID`, `ExpenseCategoryID`, `Amount`, `DateSpent`) VALUES ('9', '5', '150.45', '2016-06-17');

INSERT INTO `sql5123046`.`earnings` (`RecordID`, `EarningCategoryID`, `Amount`, `DateEarned`) VALUES ('1', '1', '1696.56', '2016-06-01');
INSERT INTO `sql5123046`.`earnings` (`RecordID`, `EarningCategoryID`, `Amount`, `DateEarned`) VALUES ('7', '1', '1650.32', '2016-06-15');

INSERT INTO `sql5123046`.`bills` (`RecordID`, `BillCategoryID`, `Amount`, `DateDue`) VALUES ('5', '2', '425.72', '2016-06-14');
INSERT INTO `sql5123046`.`bills` (`RecordID`, `BillCategoryID`, `Amount`, `DateDue`, `DatePaid`) VALUES ('6', '7', '68.74', '2016-07-01', '2016-06-29');
INSERT INTO `sql5123046`.`bills` (`RecordID`, `BillCategoryID`, `Amount`, `DateDue`, `DatePaid`) VALUES ('10', '1', '1158.12', '2016-07-01', '2016-06-29');
