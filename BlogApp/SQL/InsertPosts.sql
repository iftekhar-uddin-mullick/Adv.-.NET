USE [DemoTask_BlogSite]
GO

INSERT INTO [dbo].[Posts]
           ([PostTitle]
           ,[PostContent]
           ,[UId])
     VALUES
           (<PostTitle, varchar(255),>
           ,<PostContent, varchar(5000),>
           ,<UId, int,>)
GO

