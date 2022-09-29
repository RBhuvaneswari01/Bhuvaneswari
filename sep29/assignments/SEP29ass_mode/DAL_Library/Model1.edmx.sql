
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 17:59:03
-- Generated from EDMX file: D:\c#\basic codes\ConsoleApp1\SEP29ass_mode\DAL_Library\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BankDB];
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

-- Creating table 'borrowers'
CREATE TABLE [dbo].[borrowers] (
    [b_Id] int IDENTITY(1,1) NOT NULL,
    [b_name] nvarchar(max)  NOT NULL,
    [b_city] nvarchar(max)  NOT NULL,
    [b_state] nvarchar(max)  NOT NULL,
    [b_country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'loans'
CREATE TABLE [dbo].[loans] (
    [l_Id] int IDENTITY(1,1) NOT NULL,
    [l_type] nvarchar(max)  NOT NULL,
    [l_amount] int  NOT NULL,
    [l_duration] nvarchar(max)  NOT NULL,
    [l_roi] int  NOT NULL,
    [borrower_b_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [b_Id] in table 'borrowers'
ALTER TABLE [dbo].[borrowers]
ADD CONSTRAINT [PK_borrowers]
    PRIMARY KEY CLUSTERED ([b_Id] ASC);
GO

-- Creating primary key on [l_Id] in table 'loans'
ALTER TABLE [dbo].[loans]
ADD CONSTRAINT [PK_loans]
    PRIMARY KEY CLUSTERED ([l_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [borrower_b_Id] in table 'loans'
ALTER TABLE [dbo].[loans]
ADD CONSTRAINT [FK_borrowerloan]
    FOREIGN KEY ([borrower_b_Id])
    REFERENCES [dbo].[borrowers]
        ([b_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_borrowerloan'
CREATE INDEX [IX_FK_borrowerloan]
ON [dbo].[loans]
    ([borrower_b_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------