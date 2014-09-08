
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/08/2014 09:49:15
-- Generated from EDMX file: C:\Users\EOFL\Documents\GitHub\WpfMvvmApplication1\WpfMvvmApplication1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'public') IS NULL EXECUTE(N'CREATE SCHEMA [public]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[public].[FK_cityfk]', 'F') IS NOT NULL
    ALTER TABLE [public].[FAMILIES] DROP CONSTRAINT [FK_cityfk];
GO
IF OBJECT_ID(N'[public].[FK_famfk]', 'F') IS NOT NULL
    ALTER TABLE [public].[CHILDRENS] DROP CONSTRAINT [FK_famfk];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[public].[CHILDRENS]', 'U') IS NOT NULL
    DROP TABLE [public].[CHILDRENS];
GO
IF OBJECT_ID(N'[public].[CITIES]', 'U') IS NOT NULL
    DROP TABLE [public].[CITIES];
GO
IF OBJECT_ID(N'[public].[CIVILITIES]', 'U') IS NOT NULL
    DROP TABLE [public].[CIVILITIES];
GO
IF OBJECT_ID(N'[public].[FAMILIES]', 'U') IS NOT NULL
    DROP TABLE [public].[FAMILIES];
GO
IF OBJECT_ID(N'[public].[FAMILYQUOTIENTS]', 'U') IS NOT NULL
    DROP TABLE [public].[FAMILYQUOTIENTS];
GO
IF OBJECT_ID(N'[public].[MEDECINS]', 'U') IS NOT NULL
    DROP TABLE [public].[MEDECINS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CHILDRENS'
CREATE TABLE [public].[CHILDRENS] (
    [LASTNAME] text  NULL,
    [FIRSTNAME] text  NULL,
    [BIRTHDATE] timestamp  NULL,
    [FAMILYID] int4  NULL,
    [GENDERID] int4  NULL,
    [EMT] bool  NULL,
    [HOSPITAL] bool  NULL,
    [CLINIC] bool  NULL,
    [CLINICID] int4  NULL,
    [BEPHOTOGRAPHY] bool  NULL,
    [PUBLICATIONPHOTOGRAPHY] bool  NULL,
    [OFFOUTPUTSSTRUCTURE] bool  NULL,
    [SWIM] bool  NULL,
    [BIKEOUTINGS] bool  NULL,
    [BOATOUTINGS] bool  NULL,
    [MEDECINEID] int4  NULL,
    [ID] int4  NOT NULL
);
GO

-- Creating table 'CITIES'
CREATE TABLE [public].[CITIES] (
    [ID] int4  NOT NULL,
    [CITY] text  NULL,
    [CP] text  NULL
);
GO

-- Creating table 'FAMILIES'
CREATE TABLE [public].[FAMILIES] (
    [LASTNAME] text  NULL,
    [FIRSTNAME] text  NULL,
    [ADRESS] text  NULL,
    [CITYID] int4  NULL,
    [TEL1] text  NULL,
    [TEL2] text  NULL,
    [TEL3] text  NULL,
    [ID] int4  NOT NULL
);
GO

-- Creating table 'MEDECINS'
CREATE TABLE [public].[MEDECINS] (
    [ID] int4  NOT NULL,
    [FULLNAME] text  NULL,
    [TEL] text  NULL
);
GO

-- Creating table 'CIVILITIES'
CREATE TABLE [public].[CIVILITIES] (
    [ID] int8  NOT NULL,
    [CIVILITY] text  NULL
);
GO

-- Creating table 'FAMILYQUOTIENTS'
CREATE TABLE [public].[FAMILYQUOTIENTS] (
    [ID] int8  NOT NULL,
    [YEAR] int4  NULL,
    [FAMILYID] int4  NULL,
    [FAMILYQUOTIENT] float4  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'CHILDRENS'
ALTER TABLE [public].[CHILDRENS]
ADD CONSTRAINT [PK_CHILDRENS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CITIES'
ALTER TABLE [public].[CITIES]
ADD CONSTRAINT [PK_CITIES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FAMILIES'
ALTER TABLE [public].[FAMILIES]
ADD CONSTRAINT [PK_FAMILIES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MEDECINS'
ALTER TABLE [public].[MEDECINS]
ADD CONSTRAINT [PK_MEDECINS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CIVILITIES'
ALTER TABLE [public].[CIVILITIES]
ADD CONSTRAINT [PK_CIVILITIES]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'FAMILYQUOTIENTS'
ALTER TABLE [public].[FAMILYQUOTIENTS]
ADD CONSTRAINT [PK_FAMILYQUOTIENTS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CITYID] in table 'FAMILIES'
ALTER TABLE [public].[FAMILIES]
ADD CONSTRAINT [FK_cityfk]
    FOREIGN KEY ([CITYID])
    REFERENCES [public].[CITIES]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_cityfk'
CREATE INDEX [IX_FK_cityfk]
ON [public].[FAMILIES]
    ([CITYID]);
GO

-- Creating foreign key on [FAMILYID] in table 'CHILDRENS'
ALTER TABLE [public].[CHILDRENS]
ADD CONSTRAINT [FK_famfk]
    FOREIGN KEY ([FAMILYID])
    REFERENCES [public].[FAMILIES]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_famfk'
CREATE INDEX [IX_FK_famfk]
ON [public].[CHILDRENS]
    ([FAMILYID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------