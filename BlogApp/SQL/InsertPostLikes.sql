USE [DemoTask_BlogSite]
GO

INSERT INTO [dbo].[PostLikes]
           ([PId]
           ,[UId]
           ,[LikeDateTime])
     VALUES
           (<PId, int,>
           ,<UId, int,>
           ,<LikeDateTime, datetime,>)
GO

