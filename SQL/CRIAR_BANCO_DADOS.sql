USE [Teste]
GO

/****** Object:  Table [dbo].[NotaFiscal]    Script Date: 24/07/2015 11:58:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO
if object_id('dbo.NotaFiscalItem') is not null
	drop table dbo.NotaFiscalItem;
go

if object_id('dbo.NotaFiscal') is not null
	drop table dbo.NotaFiscal;
go

CREATE TABLE [dbo].[NotaFiscal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumeroNotaFiscal] [int] NULL,
	[Serie] [int] NULL,
	[NomeCliente] [varchar](50) NULL,
	[EstadoDestino] [varchar](50) NULL,
	[EstadoOrigem] [varchar](50) NULL,
 CONSTRAINT [PK_NotaFiscal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[NotaFiscalItem](
	[Id] [int]  IDENTITY(1,1) NOT NULL,
	[IdNotaFiscal] [int] NULL,
	[Cfop] [varchar](5) NULL,
	[TipoIcms] [varchar](20) NULL,
	[BaseIcms] [decimal](18, 5) NULL,
	[AliquotaIcms] [decimal](18, 5) NULL,
	[ValorIcms] [decimal](18, 5) NULL,
	[BaseIpi] [decimal](18, 5) NULL,
	[AliquotaIpi] [decimal](18, 5) NULL,
	[ValorIpi] [decimal](18, 5) NULL,
	[NomeProduto] [varchar](50) NULL,
	[CodigoProduto] [varchar](20) NULL,
	[Desconto] [decimal](18, 5) NULL,
	ValorItemPedido decimal(18,5) not null,
	Brinde bit not null
 CONSTRAINT [PK_NotaFiscalItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[NotaFiscalItem]  WITH CHECK ADD CONSTRAINT [FK_NotaFiscal] FOREIGN KEY([IdNotaFiscal])
REFERENCES [dbo].[NotaFiscal] ([Id])
GO

if OBJECT_ID('dbo.TratamentoFiscal') is not null
	drop table dbo.TratamentoFiscal;
go

create table dbo.TratamentoFiscal(
	Id int identity(1,1) not null,
	EstadoOrigem varchar(2) not null,
	EstadoDestino varchar(2) not null,
	Cfop varchar(5) not null,
	TipoIcms varchar(20) not null,
	AliquotaIcms decimal(18,5) not null,
	AliquotaIpi decimal(18,5) not null,
	ReducaoBaseIcms decimal(18,5) not null,
	Brinde bit not null,
	Desconto decimal(18,5),
	DataAlteracao datetime
)
go

CREATE SEQUENCE dbo.ObterNumeroNotaFiscal
    START WITH 1  
    INCREMENT BY 1 ;  
GO  
