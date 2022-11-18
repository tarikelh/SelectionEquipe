
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/18/2022 17:24:12
-- Generated from EDMX file: C:\Users\Admin Stagiaire\Documents\C#\SelectionEquipe\TEST\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [test];
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

-- Creating table 'Poste'
CREATE TABLE [dbo].[Poste] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Joueur'
CREATE TABLE [dbo].[Joueur] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PosteJoueur'
CREATE TABLE [dbo].[PosteJoueur] (
    [Poste_Id] int  NOT NULL,
    [Joueur_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Poste'
ALTER TABLE [dbo].[Poste]
ADD CONSTRAINT [PK_Poste]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Joueur'
ALTER TABLE [dbo].[Joueur]
ADD CONSTRAINT [PK_Joueur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Poste_Id], [Joueur_Id] in table 'PosteJoueur'
ALTER TABLE [dbo].[PosteJoueur]
ADD CONSTRAINT [PK_PosteJoueur]
    PRIMARY KEY CLUSTERED ([Poste_Id], [Joueur_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Poste_Id] in table 'PosteJoueur'
ALTER TABLE [dbo].[PosteJoueur]
ADD CONSTRAINT [FK_PosteJoueur_Poste]
    FOREIGN KEY ([Poste_Id])
    REFERENCES [dbo].[Poste]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Joueur_Id] in table 'PosteJoueur'
ALTER TABLE [dbo].[PosteJoueur]
ADD CONSTRAINT [FK_PosteJoueur_Joueur]
    FOREIGN KEY ([Joueur_Id])
    REFERENCES [dbo].[Joueur]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PosteJoueur_Joueur'
CREATE INDEX [IX_FK_PosteJoueur_Joueur]
ON [dbo].[PosteJoueur]
    ([Joueur_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------