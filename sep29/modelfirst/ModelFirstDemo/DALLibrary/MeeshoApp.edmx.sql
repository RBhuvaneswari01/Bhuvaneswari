
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 12:49:51
-- Generated from EDMX file: D:\c#\basic codes\ConsoleApp1\ModelFirstDemo\DALLibrary\MeeshoApp.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MeeshoDB];
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

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [custId] int IDENTITY(1,1) NOT NULL,
    [custname] nvarchar(max)  NOT NULL,
    [custaddress_streetname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'products'
CREATE TABLE [dbo].[products] (
    [prodId] int IDENTITY(1,1) NOT NULL,
    [prodname] nvarchar(max)  NOT NULL,
    [price] int  NOT NULL,
    [customer_custId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [custId] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [PK_customers]
    PRIMARY KEY CLUSTERED ([custId] ASC);
GO

-- Creating primary key on [prodId] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [PK_products]
    PRIMARY KEY CLUSTERED ([prodId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [customer_custId] in table 'products'
ALTER TABLE [dbo].[products]
ADD CONSTRAINT [FK_customerproduct]
    FOREIGN KEY ([customer_custId])
    REFERENCES [dbo].[customers]
        ([custId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_customerproduct'
CREATE INDEX [IX_FK_customerproduct]
ON [dbo].[products]
    ([customer_custId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------