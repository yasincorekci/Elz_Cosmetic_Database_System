     /* ELZ COSMETIC DATABASE SYSTEM STORED PROCEDURES */
/* 1) 150119667-Ege Eren Ellez (Group Representative)
   2) 150119703–Mert Akbal
   3) 150119858–Yasin Çörekci */

/*Stored Procedure 1 --------------------------------------------------------------------------*/

CREATE Procedure sp_AverageSalaryOfDepartment
  @dno int
As
Begin
	Select d.Dno,avg(e.Salary * 1.0) as AverageSalary
	From EMPLOYEE e inner join DEPARTMENT d on e.Dno=d.Dno
	Group By d.Dno
	Having @dno = d.Dno

End

exec sp_AverageSalaryOfDepartment 131

/*Stored Procedure 2 --------------------------------------------------------------------------*/
Create Procedure sp_NewProduct
@ID int,
@Name varchar(50),
@Brand varchar(50),
@Type varchar(50),
@Bought decimal,
@Sold decimal,
@SCode int
as
begin
Insert Into PRODUCT(ProductID, ProductName, ProductBrand, ProductType, ProductBoughtPrice, ProductSoldPrice, StorageCode)
Values (@ID, @Name, @Brand, @Type, @Bought, @Sold, @SCode)
end
 
exec sp_NewProduct 10033, 'AKNE KREMİ', 'SİNOZ', 'CİLT BAKIM ÜRÜNÜ', 120, 180, 1025
select * FROM PRODUCT
select * FROM STORAGE

/*Stored Procedure 3 --------------------------------------------------------------------------*/
Create Procedure sp_NewDepartment(
	@Dno int,
	@DName nvarchar(50),
	@ManagerSsn nvarchar(50),
	@NoOfWorkers int
)
As
Begin
	Insert Into DEPARTMENT
	Values (@Dno, @DName, @ManagerSsn, @NoOfWorkers)
End
exec sp_NewDepartment 201, 'Administrative affairs', 107641942,8
select * FROM DEPARTMENT

/*Stored Procedure 4--------------------------------------------------------------------------*/
CREATE Procedure sp_NewCustomer
	@CustomerID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Gender char(1),
	@Country nvarchar(25),
	@City nvarchar(25),
	@PostalCode nchar(5),
	@IbanNumber nvarchar(50)
As
Begin
	Insert Into CUSTOMER Values
		(@CustomerID,
		@FirstName,
		@LastName,
		@Gender,
		@Country,
		@City,
		@PostalCode,
		@IbanNumber,
		null)		
End
exec sp_NewCustomer 96145,'Sümeyye','Giresun','F','Türkiye','Sinop', 57431,TR520006251491782686421269
Select * from CUSTOMER  

/*Stored Procedure 5--------------------------------------------------------------------------*/
Create Procedure sp_DeleteCompany
	@TaxID int
As
Begin
	Delete From COMPANY
	
	Where TaxID=@TaxID
End

exec sp_DeleteCompany 852185181
select *From COMPANY

/*Stored Procedure 6--------------------------------------------------------------------------*/
Create Procedure sp_UpdateSalary
As
Begin
Update e
Set e.Salary=e.Salary*1.30
From Employee e inner join Department d on e.Dno=d.Dno
inner join (Select e.Ssn
From Employee e
Group By e.Ssn
Having Sum(e.Age)>30) e5 on e.Ssn=e.Ssn
Where d.DName='Quality Control'
END

sp_UpdateSalary
Select * from EMPLOYEE

/*Stored Procedure 7--------------------------------------------------------------------------*/

Create Procedure sp_EmptyCompany(
	@TaxID int
)
As
Begin
	Update COMPANY
	Set CompanyName=NULL
	Where TaxID=@TaxID
End
exec sp_EmptyCompany 25151512
select*from COMPANY


