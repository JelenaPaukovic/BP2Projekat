
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2021 18:51:30
-- Generated from EDMX file: C:\Users\Jelena\Desktop\TeniskiTurniri - Copy\TeniskiTurniri\ModelTeniskiTurniri.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TeniskiTurniri];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GledalacProdaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdajeSet] DROP CONSTRAINT [FK_GledalacProdaje];
GO
IF OBJECT_ID(N'[dbo].[FK_IgracUcestvuje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UcestvujeSet] DROP CONSTRAINT [FK_IgracUcestvuje];
GO
IF OBJECT_ID(N'[dbo].[FK_KoloOdrzavanje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KoloSet] DROP CONSTRAINT [FK_KoloOdrzavanje];
GO
IF OBJECT_ID(N'[dbo].[FK_MecKolo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MecSet] DROP CONSTRAINT [FK_MecKolo];
GO
IF OBJECT_ID(N'[dbo].[FK_MecStadion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MecSet] DROP CONSTRAINT [FK_MecStadion];
GO
IF OBJECT_ID(N'[dbo].[FK_NagradaUcestvuje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UcestvujeSet] DROP CONSTRAINT [FK_NagradaUcestvuje];
GO
IF OBJECT_ID(N'[dbo].[FK_OrganizatorTurnir_Organizator]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrganizatorTurnir] DROP CONSTRAINT [FK_OrganizatorTurnir_Organizator];
GO
IF OBJECT_ID(N'[dbo].[FK_OrganizatorTurnir_Turnir]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrganizatorTurnir] DROP CONSTRAINT [FK_OrganizatorTurnir_Turnir];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdajeTurnir]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdajeSet] DROP CONSTRAINT [FK_ProdajeTurnir];
GO
IF OBJECT_ID(N'[dbo].[FK_TurnirGledalac_Gledalac]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TurnirGledalac] DROP CONSTRAINT [FK_TurnirGledalac_Gledalac];
GO
IF OBJECT_ID(N'[dbo].[FK_TurnirGledalac_Turnir]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TurnirGledalac] DROP CONSTRAINT [FK_TurnirGledalac_Turnir];
GO
IF OBJECT_ID(N'[dbo].[FK_TurnirKategorija]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TurnirSet] DROP CONSTRAINT [FK_TurnirKategorija];
GO
IF OBJECT_ID(N'[dbo].[FK_TurnirOdrzavanje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OdrzavanjeSet] DROP CONSTRAINT [FK_TurnirOdrzavanje];
GO
IF OBJECT_ID(N'[dbo].[FK_UcestvujeMec_Mec]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UcestvujeMec] DROP CONSTRAINT [FK_UcestvujeMec_Mec];
GO
IF OBJECT_ID(N'[dbo].[FK_UcestvujeMec_Ucestvuje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UcestvujeMec] DROP CONSTRAINT [FK_UcestvujeMec_Ucestvuje];
GO
IF OBJECT_ID(N'[dbo].[FK_UcestvujeOprema]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UcestvujeSet] DROP CONSTRAINT [FK_UcestvujeOprema];
GO
IF OBJECT_ID(N'[dbo].[FK_UcestvujeTurnir]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UcestvujeSet] DROP CONSTRAINT [FK_UcestvujeTurnir];
GO
IF OBJECT_ID(N'[dbo].[FK_UlaznicaObicnaUlaznica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ObicnaUlaznicaSet] DROP CONSTRAINT [FK_UlaznicaObicnaUlaznica];
GO
IF OBJECT_ID(N'[dbo].[FK_UlaznicaProdaje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdajeSet] DROP CONSTRAINT [FK_UlaznicaProdaje];
GO
IF OBJECT_ID(N'[dbo].[FK_UlaznicaVipUlaznica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VipUlaznicaSet] DROP CONSTRAINT [FK_UlaznicaVipUlaznica];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GledalacSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GledalacSet];
GO
IF OBJECT_ID(N'[dbo].[IgracSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IgracSet];
GO
IF OBJECT_ID(N'[dbo].[KategorijaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KategorijaSet];
GO
IF OBJECT_ID(N'[dbo].[KoloSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KoloSet];
GO
IF OBJECT_ID(N'[dbo].[MecSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MecSet];
GO
IF OBJECT_ID(N'[dbo].[NagradaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NagradaSet];
GO
IF OBJECT_ID(N'[dbo].[ObicnaUlaznicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObicnaUlaznicaSet];
GO
IF OBJECT_ID(N'[dbo].[OdrzavanjeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OdrzavanjeSet];
GO
IF OBJECT_ID(N'[dbo].[OpremaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OpremaSet];
GO
IF OBJECT_ID(N'[dbo].[OrganizatorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrganizatorSet];
GO
IF OBJECT_ID(N'[dbo].[OrganizatorTurnir]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrganizatorTurnir];
GO
IF OBJECT_ID(N'[dbo].[ProdajeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdajeSet];
GO
IF OBJECT_ID(N'[dbo].[StadionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StadionSet];
GO
IF OBJECT_ID(N'[dbo].[TurnirGledalac]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TurnirGledalac];
GO
IF OBJECT_ID(N'[dbo].[TurnirSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TurnirSet];
GO
IF OBJECT_ID(N'[dbo].[UcestvujeMec]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UcestvujeMec];
GO
IF OBJECT_ID(N'[dbo].[UcestvujeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UcestvujeSet];
GO
IF OBJECT_ID(N'[dbo].[UlaznicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UlaznicaSet];
GO
IF OBJECT_ID(N'[dbo].[VipUlaznicaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VipUlaznicaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UlaznicaSet'
CREATE TABLE [dbo].[UlaznicaSet] (
    [idu] int  NOT NULL,
    [datom] datetime  NOT NULL,
    [vreme] time  NOT NULL,
    [brreda] int  NOT NULL,
    [brsed] int  NOT NULL,
    [tipu] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrganizatorSet'
CREATE TABLE [dbo].[OrganizatorSet] (
    [idor] int  NOT NULL,
    [nazor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NagradaSet'
CREATE TABLE [dbo].[NagradaSet] (
    [idn] int IDENTITY(1,1) NOT NULL,
    [nazn] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'VipUlaznicaSet'
CREATE TABLE [dbo].[VipUlaznicaSet] (
    [oznv] nvarchar(max)  NOT NULL,
    [idvu] int  NOT NULL,
    [Ulaznica_idu] int  NOT NULL
);
GO

-- Creating table 'ObicnaUlaznicaSet'
CREATE TABLE [dbo].[ObicnaUlaznicaSet] (
    [ozno] nvarchar(max)  NOT NULL,
    [idou] int  NOT NULL,
    [Ulaznica_idu] int  NOT NULL
);
GO

-- Creating table 'GledalacSet'
CREATE TABLE [dbo].[GledalacSet] (
    [idg] int  NOT NULL
);
GO

-- Creating table 'IgracSet'
CREATE TABLE [dbo].[IgracSet] (
    [idig] int  NOT NULL,
    [imei] nvarchar(max)  NOT NULL,
    [przi] nvarchar(max)  NOT NULL,
    [datri] datetime  NOT NULL,
    [drzi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KategorijaSet'
CREATE TABLE [dbo].[KategorijaSet] (
    [idkat] int  NOT NULL,
    [nazkat] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StadionSet'
CREATE TABLE [dbo].[StadionSet] (
    [idst] int  NOT NULL,
    [nazst] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OpremaSet'
CREATE TABLE [dbo].[OpremaSet] (
    [ido] int  NOT NULL,
    [nazo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProdajeSet'
CREATE TABLE [dbo].[ProdajeSet] (
    [Ulaznica_idu] int  NOT NULL,
    [Turnir_idtur] int  NOT NULL,
    [Gledalac_idg] int  NULL
);
GO

-- Creating table 'UcestvujeSet'
CREATE TABLE [dbo].[UcestvujeSet] (
    [Igrac_idig] int  NOT NULL,
    [Nagrada_idn] int  NULL,
    [Turnir_idtur] int  NOT NULL,
    [Oprema_ido] int  NOT NULL
);
GO

-- Creating table 'TurnirSet'
CREATE TABLE [dbo].[TurnirSet] (
    [idtur] int  NOT NULL,
    [naztur] nvarchar(max)  NOT NULL,
    [mestotur] nvarchar(max)  NOT NULL,
    [datpt] datetime  NOT NULL,
    [datzt] datetime  NOT NULL,
    [Kategorija_idkat] int  NOT NULL
);
GO

-- Creating table 'MecSet'
CREATE TABLE [dbo].[MecSet] (
    [idm] int  NOT NULL,
    [datom] datetime  NOT NULL,
    [brg] int  NOT NULL,
    [stdm] nvarchar(max)  NOT NULL,
    [imeig] nvarchar(max)  NOT NULL,
    [przig] nvarchar(max)  NOT NULL,
    [Stadion_idst] int  NOT NULL,
    [Kolo_idk] int  NOT NULL,
    [KoloOdrzavanje_idod] int  NOT NULL,
    [KoloOdrzavanjeTurnir_idtur] int  NOT NULL
);
GO

-- Creating table 'KoloSet'
CREATE TABLE [dbo].[KoloSet] (
    [idk] int  NOT NULL,
    [Odrzavanje_idod] int  NOT NULL,
    [OdrzavanjeTurnir_idtur] int  NOT NULL
);
GO

-- Creating table 'OdrzavanjeSet'
CREATE TABLE [dbo].[OdrzavanjeSet] (
    [idod] int  NOT NULL,
    [datpo] datetime  NOT NULL,
    [datzo] datetime  NOT NULL,
    [Turnir_idtur] int  NOT NULL
);
GO

-- Creating table 'OrganizatorTurnir'
CREATE TABLE [dbo].[OrganizatorTurnir] (
    [Organizator_idor] int  NOT NULL,
    [Turnir_idtur] int  NOT NULL
);
GO

-- Creating table 'UcestvujeMec'
CREATE TABLE [dbo].[UcestvujeMec] (
    [Ucestvuje_Igrac_idig] int  NOT NULL,
    [Ucestvuje_Turnir_idtur] int  NOT NULL,
    [Mec_idm] int  NOT NULL
);
GO

-- Creating table 'TurnirGledalac'
CREATE TABLE [dbo].[TurnirGledalac] (
    [Turnir_idtur] int  NOT NULL,
    [Gledalac_idg] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idu] in table 'UlaznicaSet'
ALTER TABLE [dbo].[UlaznicaSet]
ADD CONSTRAINT [PK_UlaznicaSet]
    PRIMARY KEY CLUSTERED ([idu] ASC);
GO

-- Creating primary key on [idor] in table 'OrganizatorSet'
ALTER TABLE [dbo].[OrganizatorSet]
ADD CONSTRAINT [PK_OrganizatorSet]
    PRIMARY KEY CLUSTERED ([idor] ASC);
GO

-- Creating primary key on [idn] in table 'NagradaSet'
ALTER TABLE [dbo].[NagradaSet]
ADD CONSTRAINT [PK_NagradaSet]
    PRIMARY KEY CLUSTERED ([idn] ASC);
GO

-- Creating primary key on [idvu] in table 'VipUlaznicaSet'
ALTER TABLE [dbo].[VipUlaznicaSet]
ADD CONSTRAINT [PK_VipUlaznicaSet]
    PRIMARY KEY CLUSTERED ([idvu] ASC);
GO

-- Creating primary key on [idou] in table 'ObicnaUlaznicaSet'
ALTER TABLE [dbo].[ObicnaUlaznicaSet]
ADD CONSTRAINT [PK_ObicnaUlaznicaSet]
    PRIMARY KEY CLUSTERED ([idou] ASC);
GO

-- Creating primary key on [idg] in table 'GledalacSet'
ALTER TABLE [dbo].[GledalacSet]
ADD CONSTRAINT [PK_GledalacSet]
    PRIMARY KEY CLUSTERED ([idg] ASC);
GO

-- Creating primary key on [idig] in table 'IgracSet'
ALTER TABLE [dbo].[IgracSet]
ADD CONSTRAINT [PK_IgracSet]
    PRIMARY KEY CLUSTERED ([idig] ASC);
GO

-- Creating primary key on [idkat] in table 'KategorijaSet'
ALTER TABLE [dbo].[KategorijaSet]
ADD CONSTRAINT [PK_KategorijaSet]
    PRIMARY KEY CLUSTERED ([idkat] ASC);
GO

-- Creating primary key on [idst] in table 'StadionSet'
ALTER TABLE [dbo].[StadionSet]
ADD CONSTRAINT [PK_StadionSet]
    PRIMARY KEY CLUSTERED ([idst] ASC);
GO

-- Creating primary key on [ido] in table 'OpremaSet'
ALTER TABLE [dbo].[OpremaSet]
ADD CONSTRAINT [PK_OpremaSet]
    PRIMARY KEY CLUSTERED ([ido] ASC);
GO

-- Creating primary key on [Ulaznica_idu], [Turnir_idtur] in table 'ProdajeSet'
ALTER TABLE [dbo].[ProdajeSet]
ADD CONSTRAINT [PK_ProdajeSet]
    PRIMARY KEY CLUSTERED ([Ulaznica_idu], [Turnir_idtur] ASC);
GO

-- Creating primary key on [Igrac_idig], [Turnir_idtur] in table 'UcestvujeSet'
ALTER TABLE [dbo].[UcestvujeSet]
ADD CONSTRAINT [PK_UcestvujeSet]
    PRIMARY KEY CLUSTERED ([Igrac_idig], [Turnir_idtur] ASC);
GO

-- Creating primary key on [idtur] in table 'TurnirSet'
ALTER TABLE [dbo].[TurnirSet]
ADD CONSTRAINT [PK_TurnirSet]
    PRIMARY KEY CLUSTERED ([idtur] ASC);
GO

-- Creating primary key on [idm] in table 'MecSet'
ALTER TABLE [dbo].[MecSet]
ADD CONSTRAINT [PK_MecSet]
    PRIMARY KEY CLUSTERED ([idm] ASC);
GO

-- Creating primary key on [idk], [Odrzavanje_idod], [OdrzavanjeTurnir_idtur] in table 'KoloSet'
ALTER TABLE [dbo].[KoloSet]
ADD CONSTRAINT [PK_KoloSet]
    PRIMARY KEY CLUSTERED ([idk], [Odrzavanje_idod], [OdrzavanjeTurnir_idtur] ASC);
GO

-- Creating primary key on [idod], [Turnir_idtur] in table 'OdrzavanjeSet'
ALTER TABLE [dbo].[OdrzavanjeSet]
ADD CONSTRAINT [PK_OdrzavanjeSet]
    PRIMARY KEY CLUSTERED ([idod], [Turnir_idtur] ASC);
GO

-- Creating primary key on [Organizator_idor], [Turnir_idtur] in table 'OrganizatorTurnir'
ALTER TABLE [dbo].[OrganizatorTurnir]
ADD CONSTRAINT [PK_OrganizatorTurnir]
    PRIMARY KEY CLUSTERED ([Organizator_idor], [Turnir_idtur] ASC);
GO

-- Creating primary key on [Ucestvuje_Igrac_idig], [Ucestvuje_Turnir_idtur], [Mec_idm] in table 'UcestvujeMec'
ALTER TABLE [dbo].[UcestvujeMec]
ADD CONSTRAINT [PK_UcestvujeMec]
    PRIMARY KEY CLUSTERED ([Ucestvuje_Igrac_idig], [Ucestvuje_Turnir_idtur], [Mec_idm] ASC);
GO

-- Creating primary key on [Turnir_idtur], [Gledalac_idg] in table 'TurnirGledalac'
ALTER TABLE [dbo].[TurnirGledalac]
ADD CONSTRAINT [PK_TurnirGledalac]
    PRIMARY KEY CLUSTERED ([Turnir_idtur], [Gledalac_idg] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Ulaznica_idu] in table 'VipUlaznicaSet'
ALTER TABLE [dbo].[VipUlaznicaSet]
ADD CONSTRAINT [FK_UlaznicaVipUlaznica]
    FOREIGN KEY ([Ulaznica_idu])
    REFERENCES [dbo].[UlaznicaSet]
        ([idu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UlaznicaVipUlaznica'
CREATE INDEX [IX_FK_UlaznicaVipUlaznica]
ON [dbo].[VipUlaznicaSet]
    ([Ulaznica_idu]);
GO

-- Creating foreign key on [Ulaznica_idu] in table 'ObicnaUlaznicaSet'
ALTER TABLE [dbo].[ObicnaUlaznicaSet]
ADD CONSTRAINT [FK_UlaznicaObicnaUlaznica]
    FOREIGN KEY ([Ulaznica_idu])
    REFERENCES [dbo].[UlaznicaSet]
        ([idu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UlaznicaObicnaUlaznica'
CREATE INDEX [IX_FK_UlaznicaObicnaUlaznica]
ON [dbo].[ObicnaUlaznicaSet]
    ([Ulaznica_idu]);
GO

-- Creating foreign key on [Ulaznica_idu] in table 'ProdajeSet'
ALTER TABLE [dbo].[ProdajeSet]
ADD CONSTRAINT [FK_UlaznicaProdaje]
    FOREIGN KEY ([Ulaznica_idu])
    REFERENCES [dbo].[UlaznicaSet]
        ([idu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Organizator_idor] in table 'OrganizatorTurnir'
ALTER TABLE [dbo].[OrganizatorTurnir]
ADD CONSTRAINT [FK_OrganizatorTurnir_Organizator]
    FOREIGN KEY ([Organizator_idor])
    REFERENCES [dbo].[OrganizatorSet]
        ([idor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Turnir_idtur] in table 'OrganizatorTurnir'
ALTER TABLE [dbo].[OrganizatorTurnir]
ADD CONSTRAINT [FK_OrganizatorTurnir_Turnir]
    FOREIGN KEY ([Turnir_idtur])
    REFERENCES [dbo].[TurnirSet]
        ([idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrganizatorTurnir_Turnir'
CREATE INDEX [IX_FK_OrganizatorTurnir_Turnir]
ON [dbo].[OrganizatorTurnir]
    ([Turnir_idtur]);
GO

-- Creating foreign key on [Turnir_idtur] in table 'ProdajeSet'
ALTER TABLE [dbo].[ProdajeSet]
ADD CONSTRAINT [FK_ProdajeTurnir]
    FOREIGN KEY ([Turnir_idtur])
    REFERENCES [dbo].[TurnirSet]
        ([idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdajeTurnir'
CREATE INDEX [IX_FK_ProdajeTurnir]
ON [dbo].[ProdajeSet]
    ([Turnir_idtur]);
GO

-- Creating foreign key on [Gledalac_idg] in table 'ProdajeSet'
ALTER TABLE [dbo].[ProdajeSet]
ADD CONSTRAINT [FK_GledalacProdaje]
    FOREIGN KEY ([Gledalac_idg])
    REFERENCES [dbo].[GledalacSet]
        ([idg])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GledalacProdaje'
CREATE INDEX [IX_FK_GledalacProdaje]
ON [dbo].[ProdajeSet]
    ([Gledalac_idg]);
GO

-- Creating foreign key on [Igrac_idig] in table 'UcestvujeSet'
ALTER TABLE [dbo].[UcestvujeSet]
ADD CONSTRAINT [FK_IgracUcestvuje]
    FOREIGN KEY ([Igrac_idig])
    REFERENCES [dbo].[IgracSet]
        ([idig])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Nagrada_idn] in table 'UcestvujeSet'
ALTER TABLE [dbo].[UcestvujeSet]
ADD CONSTRAINT [FK_NagradaUcestvuje]
    FOREIGN KEY ([Nagrada_idn])
    REFERENCES [dbo].[NagradaSet]
        ([idn])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NagradaUcestvuje'
CREATE INDEX [IX_FK_NagradaUcestvuje]
ON [dbo].[UcestvujeSet]
    ([Nagrada_idn]);
GO

-- Creating foreign key on [Ucestvuje_Igrac_idig], [Ucestvuje_Turnir_idtur] in table 'UcestvujeMec'
ALTER TABLE [dbo].[UcestvujeMec]
ADD CONSTRAINT [FK_UcestvujeMec_Ucestvuje]
    FOREIGN KEY ([Ucestvuje_Igrac_idig], [Ucestvuje_Turnir_idtur])
    REFERENCES [dbo].[UcestvujeSet]
        ([Igrac_idig], [Turnir_idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Mec_idm] in table 'UcestvujeMec'
ALTER TABLE [dbo].[UcestvujeMec]
ADD CONSTRAINT [FK_UcestvujeMec_Mec]
    FOREIGN KEY ([Mec_idm])
    REFERENCES [dbo].[MecSet]
        ([idm])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UcestvujeMec_Mec'
CREATE INDEX [IX_FK_UcestvujeMec_Mec]
ON [dbo].[UcestvujeMec]
    ([Mec_idm]);
GO

-- Creating foreign key on [Turnir_idtur] in table 'UcestvujeSet'
ALTER TABLE [dbo].[UcestvujeSet]
ADD CONSTRAINT [FK_UcestvujeTurnir]
    FOREIGN KEY ([Turnir_idtur])
    REFERENCES [dbo].[TurnirSet]
        ([idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UcestvujeTurnir'
CREATE INDEX [IX_FK_UcestvujeTurnir]
ON [dbo].[UcestvujeSet]
    ([Turnir_idtur]);
GO

-- Creating foreign key on [Oprema_ido] in table 'UcestvujeSet'
ALTER TABLE [dbo].[UcestvujeSet]
ADD CONSTRAINT [FK_UcestvujeOprema]
    FOREIGN KEY ([Oprema_ido])
    REFERENCES [dbo].[OpremaSet]
        ([ido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UcestvujeOprema'
CREATE INDEX [IX_FK_UcestvujeOprema]
ON [dbo].[UcestvujeSet]
    ([Oprema_ido]);
GO

-- Creating foreign key on [Kategorija_idkat] in table 'TurnirSet'
ALTER TABLE [dbo].[TurnirSet]
ADD CONSTRAINT [FK_TurnirKategorija]
    FOREIGN KEY ([Kategorija_idkat])
    REFERENCES [dbo].[KategorijaSet]
        ([idkat])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurnirKategorija'
CREATE INDEX [IX_FK_TurnirKategorija]
ON [dbo].[TurnirSet]
    ([Kategorija_idkat]);
GO

-- Creating foreign key on [Turnir_idtur] in table 'OdrzavanjeSet'
ALTER TABLE [dbo].[OdrzavanjeSet]
ADD CONSTRAINT [FK_TurnirOdrzavanje]
    FOREIGN KEY ([Turnir_idtur])
    REFERENCES [dbo].[TurnirSet]
        ([idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurnirOdrzavanje'
CREATE INDEX [IX_FK_TurnirOdrzavanje]
ON [dbo].[OdrzavanjeSet]
    ([Turnir_idtur]);
GO

-- Creating foreign key on [Turnir_idtur] in table 'TurnirGledalac'
ALTER TABLE [dbo].[TurnirGledalac]
ADD CONSTRAINT [FK_TurnirGledalac_Turnir]
    FOREIGN KEY ([Turnir_idtur])
    REFERENCES [dbo].[TurnirSet]
        ([idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Gledalac_idg] in table 'TurnirGledalac'
ALTER TABLE [dbo].[TurnirGledalac]
ADD CONSTRAINT [FK_TurnirGledalac_Gledalac]
    FOREIGN KEY ([Gledalac_idg])
    REFERENCES [dbo].[GledalacSet]
        ([idg])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TurnirGledalac_Gledalac'
CREATE INDEX [IX_FK_TurnirGledalac_Gledalac]
ON [dbo].[TurnirGledalac]
    ([Gledalac_idg]);
GO

-- Creating foreign key on [Stadion_idst] in table 'MecSet'
ALTER TABLE [dbo].[MecSet]
ADD CONSTRAINT [FK_MecStadion]
    FOREIGN KEY ([Stadion_idst])
    REFERENCES [dbo].[StadionSet]
        ([idst])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecStadion'
CREATE INDEX [IX_FK_MecStadion]
ON [dbo].[MecSet]
    ([Stadion_idst]);
GO

-- Creating foreign key on [Odrzavanje_idod], [OdrzavanjeTurnir_idtur] in table 'KoloSet'
ALTER TABLE [dbo].[KoloSet]
ADD CONSTRAINT [FK_KoloOdrzavanje]
    FOREIGN KEY ([Odrzavanje_idod], [OdrzavanjeTurnir_idtur])
    REFERENCES [dbo].[OdrzavanjeSet]
        ([idod], [Turnir_idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KoloOdrzavanje'
CREATE INDEX [IX_FK_KoloOdrzavanje]
ON [dbo].[KoloSet]
    ([Odrzavanje_idod], [OdrzavanjeTurnir_idtur]);
GO

-- Creating foreign key on [Kolo_idk], [KoloOdrzavanje_idod], [KoloOdrzavanjeTurnir_idtur] in table 'MecSet'
ALTER TABLE [dbo].[MecSet]
ADD CONSTRAINT [FK_MecKolo]
    FOREIGN KEY ([Kolo_idk], [KoloOdrzavanje_idod], [KoloOdrzavanjeTurnir_idtur])
    REFERENCES [dbo].[KoloSet]
        ([idk], [Odrzavanje_idod], [OdrzavanjeTurnir_idtur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecKolo'
CREATE INDEX [IX_FK_MecKolo]
ON [dbo].[MecSet]
    ([Kolo_idk], [KoloOdrzavanje_idod], [KoloOdrzavanjeTurnir_idtur]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------