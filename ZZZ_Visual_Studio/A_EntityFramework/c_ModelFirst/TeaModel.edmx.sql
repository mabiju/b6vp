
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/10/2026 17:08:41
-- Generated from EDMX file: D:\B6_VP\ZZZ_Visual_Studio\A_EntityFramework\c_ModelFirst\TeaModel.edmx
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

-- Creating table 'Teas'
CREATE TABLE [dbo].[Teas] (
    [TeaId] int IDENTITY(1,1) NOT NULL,
    [TeaName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Factories'
CREATE TABLE [dbo].[Factories] (
    [FactoryId] int IDENTITY(1,1) NOT NULL,
    [FactoryName] nvarchar(max)  NOT NULL,
    [FactoryAddress] nvarchar(max)  NOT NULL,
    [TeaTeaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TeaId] in table 'Teas'
ALTER TABLE [dbo].[Teas]
ADD CONSTRAINT [PK_Teas]
    PRIMARY KEY CLUSTERED ([TeaId] ASC);
GO

-- Creating primary key on [FactoryId] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [PK_Factories]
    PRIMARY KEY CLUSTERED ([FactoryId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeaTeaId] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [FK_TeaFactory]
    FOREIGN KEY ([TeaTeaId])
    REFERENCES [dbo].[Teas]
        ([TeaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeaFactory'
CREATE INDEX [IX_FK_TeaFactory]
ON [dbo].[Factories]
    ([TeaTeaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------