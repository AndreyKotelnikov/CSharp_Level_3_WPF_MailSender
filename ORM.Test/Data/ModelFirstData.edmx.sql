
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/30/2019 11:50:35
-- Generated from EDMX file: C:\Users\Drago\source\repos\CSharp_Level_3_WPF_MailSender\ORM.Test\Data\ModelFirstData.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirstBase_30_10_2019_11_48];
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

-- Creating table 'ArtistMFSet'
CREATE TABLE [dbo].[ArtistMFSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SongMFSet'
CREATE TABLE [dbo].[SongMFSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Duration] float  NOT NULL,
    [Discription] nvarchar(max)  NULL
);
GO

-- Creating table 'SongMFArtistMF'
CREATE TABLE [dbo].[SongMFArtistMF] (
    [SongMF_Id] int  NOT NULL,
    [ArtistMF_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ArtistMFSet'
ALTER TABLE [dbo].[ArtistMFSet]
ADD CONSTRAINT [PK_ArtistMFSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SongMFSet'
ALTER TABLE [dbo].[SongMFSet]
ADD CONSTRAINT [PK_SongMFSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [SongMF_Id], [ArtistMF_Id] in table 'SongMFArtistMF'
ALTER TABLE [dbo].[SongMFArtistMF]
ADD CONSTRAINT [PK_SongMFArtistMF]
    PRIMARY KEY CLUSTERED ([SongMF_Id], [ArtistMF_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SongMF_Id] in table 'SongMFArtistMF'
ALTER TABLE [dbo].[SongMFArtistMF]
ADD CONSTRAINT [FK_SongMFArtistMF_SongMF]
    FOREIGN KEY ([SongMF_Id])
    REFERENCES [dbo].[SongMFSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ArtistMF_Id] in table 'SongMFArtistMF'
ALTER TABLE [dbo].[SongMFArtistMF]
ADD CONSTRAINT [FK_SongMFArtistMF_ArtistMF]
    FOREIGN KEY ([ArtistMF_Id])
    REFERENCES [dbo].[ArtistMFSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SongMFArtistMF_ArtistMF'
CREATE INDEX [IX_FK_SongMFArtistMF_ArtistMF]
ON [dbo].[SongMFArtistMF]
    ([ArtistMF_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------