CREATE TABLE [dbo].[Student] (
    [stuId]      VARCHAR (15) NOT NULL,
    [stuName]    VARCHAR (10) NOT NULL,
    [sex]        NCHAR (1)    NULL,
    [department] VARCHAR (10) NULL,
    [class]      VARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([stuId] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'学号', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Student', @level2type = N'COLUMN', @level2name = N'stuId';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'学生姓名', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Student', @level2type = N'COLUMN', @level2name = N'stuName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'性别', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Student', @level2type = N'COLUMN', @level2name = N'sex';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'系别', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Student', @level2type = N'COLUMN', @level2name = N'department';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'专业班级', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Student', @level2type = N'COLUMN', @level2name = N'class';

