CREATE TABLE [dbo].[Course] (
    [courseId]   INT NOT NULL,
    [courseName] VARCHAR (20) NOT NULL,
    [type]       NCHAR (2)    NULL,
    [point]      FLOAT (53)   NULL,
    PRIMARY KEY CLUSTERED ([courseId]) 
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'课程编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Course', @level2type = N'COLUMN', @level2name = N'courseId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'课程名字', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Course', @level2type = N'COLUMN', @level2name = N'courseName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'类型', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Course', @level2type = N'COLUMN', @level2name = N'type';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'学分', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Course', @level2type = N'COLUMN', @level2name = N'point';

