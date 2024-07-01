USE [DemoTask_BlogSite]
GO

INSERT INTO [dbo].[PostComments]
           ([PId]
           ,[UId]
           ,[CommentDateTime]
           ,[CommentContent])
     VALUES
           (<PId, int,>
           ,<UId, int,>
           ,<CommentDateTime, datetime,>
           ,<CommentContent, varchar(2000),>)
GO

