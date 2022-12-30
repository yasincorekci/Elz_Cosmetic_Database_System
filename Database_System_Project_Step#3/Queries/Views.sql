          /* ELZ COSMETIC DATABASE SYSTEM VIEWS */
/* 1) 150119667-Ege Eren Ellez (Group Representative)
   2) 150119703–Mert Akbal
   3) 150119858–Yasin Çörekci */

/*View 1--------------------------------------------------------------------------*/
create view OrderWithLogistics as
Select o.OrderID, l.LogisticID, o.TotalPrice FROM [dbo].LOGISTICS l
join [dbo].[ORDER] o on l.LogisticID = o.LogisticID

/*View 2 --------------------------------------------------------------------------*/

create view [dbo].[ProductType] as
SELECT p.ProductType,count(*) as Among FROM PRODUCT p
Group By p.ProductType
/*View 3 --------------------------------------------------------------------------*/

Create view [dbo].[DepartmentsOfEmployees] as
Select e.Ssn,e.FirstName +' ' + e.LastName as FullName,e.Dno,d.DName
From EMPLOYEE e inner join DEPARTMENT d on e.Dno=d.Dno

/*View 4 -------------------------------------------------------------------------- */

create view [dbo].[TopthirteenEarnerEmployee] as
SELECT Top 13 e.Ssn,e.FirstName + '' + e.LastName as FullName,e.Salary
From EMPLOYEE e
Order By e.Salary desc

/*View 5 -------------------------------------------------------------------------- */

create view [dbo].[avgsalaryEmployee] as
Select e.Dno, Count(*) NoOfEmp, Avg(e.Salary) AvgSalary
From Employee e
Group By e.Dno

/*View 6 --------------------------------------------------------------------------*/

CREATE VIEW [dbo].[ProfitOfProducts] as
Select p.ProductID ,p.ProductName,p.ProductSoldPrice- p.ProductBoughtPrice as Profit
From PRODUCT p

 /*View 7 -------------------------------------------------------------------------- */

Create view [dbo].[greaterEleventhousandsixhundredOfEmployees] as
Select d.Dno, d.DName, Count(*) NoOfEmp
From Employee e inner join Department d on e.Dno=d.Dno
Where d.Dno in
(Select e2.Dno
From Employee e2
Group By e2.Dno
Having Count(*)>=5)
and e.Salary<11600
Group By d.Dno, d.DName

 /*View 8 --------------------------------------------------------------------------*/

create view [dbo].[FindLogistics] as
select c.CustomerID, c.Gender,c.FirstName, c.LastName, l.LogisticID FROM LOGISTICS l 
join CUSTOMER c on l.LogisticID = c.LogisticID
where c.LogisticID = 153 





