CREATE TABLE [dbo].[Score] (
    [stuId]      VARCHAR (15) NOT NULL,
    [stuName]    VARCHAR (10) NOT NULL,
    [courseId]   INT NOT NULL,
    [courseName] VARCHAR (20) NOT NULL,
    [score]      INT          NULL,
    [term]       VARCHAR (10) NULL,
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'学生学号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Score', @level2type = N'COLUMN', @level2name = N'stuId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'学生姓名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Score', @level2type = N'COLUMN', @level2name = N'stuName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'课程编号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Score', @level2type = N'COLUMN', @level2name = N'courseId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'课程名字', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Score', @level2type = N'COLUMN', @level2name = N'courseName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'成绩', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Score', @level2type = N'COLUMN', @level2name = N'score';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'学期', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Score', @level2type = N'COLUMN', @level2name = N'term';

