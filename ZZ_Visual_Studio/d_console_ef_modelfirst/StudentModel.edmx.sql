
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2025 08:20:58
-- Generated from EDMX file: D:\SCVPB6\Y_Visual_Studio\d_console_ef_modelfirst\StudentModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [model_first];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [StuRoll] int IDENTITY(1,1) NOT NULL,
    [StudentName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Colleges'
CREATE TABLE [dbo].[Colleges] (
    [CollegeId] int IDENTITY(1,1) NOT NULL,
    [CollegeName] nvarchar(max)  NOT NULL,
    [CollegeAddress] nvarchar(max)  NOT NULL,
    [StudentStuRoll] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [StuRoll] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([StuRoll] ASC);
GO

-- Creating primary key on [CollegeId] in table 'Colleges'
ALTER TABLE [dbo].[Colleges]
ADD CONSTRAINT [PK_Colleges]
    PRIMARY KEY CLUSTERED ([CollegeId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentStuRoll] in table 'Colleges'
ALTER TABLE [dbo].[Colleges]
ADD CONSTRAINT [FK_StudentCollege]
    FOREIGN KEY ([StudentStuRoll])
    REFERENCES [dbo].[Students]
        ([StuRoll])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentCollege'
CREATE INDEX [IX_FK_StudentCollege]
ON [dbo].[Colleges]
    ([StudentStuRoll]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------