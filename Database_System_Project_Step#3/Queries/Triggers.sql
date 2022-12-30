     /* ELZ COSMETIC DATABASE SYSTEM STORED PROCEDURES */
/* 1) 150119667-Ege Eren Ellez (Group Representative)
   2) 150119703–Mert Akbal
   3) 150119858–Yasin Çörekci */

/*Trigger 1 --------------------------------------------------------------------------*/

CREATE TRIGGER tg_OrdertoLogistics
on [dbo].[ORDER]
After Insert
As
Begin
Update LOGISTICS
Set OrderCount = OrderCount+1
Where LogisticID=(select LogisticID FROM inserted)
end

Insert Into [dbo].[ORDER](OrderID, LogisticID) Values (100028, 144)

/*Trigger 2 --------------------------------------------------------------------------*/

CREATE TRIGGER tg_DeleteOrdertoLogistics
on [dbo].[ORDER]
After Delete
As
Begin
Update LOGISTICS
Set OrderCount = OrderCount+1
Where LogisticID=(select LogisticID FROM deleted)
end

Insert Into [dbo].[ORDER](OrderID, LogisticID) Values (100028, 144)