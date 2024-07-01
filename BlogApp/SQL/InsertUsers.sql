USE [DemoTask_BlogSite]
GO

INSERT INTO [dbo].[Users]
           ([Username]
           ,[Password]
           ,[Role]
           ,[Status]
           ,[Name])
     VALUES
           (<Username, varchar(25),>
           ,<Password, varchar(50),>
           ,<Role, varchar(10),>
           ,<Status, varchar(8),>
           ,<Name, varchar(50),>)
GO

