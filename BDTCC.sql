USE [TCC]
GO
/****** Object:  Table [dbo].[Atendimento]    Script Date: 28/05/2018 23:34:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atendimento](
	[idAtendimento] [int] IDENTITY(1,1) NOT NULL,
	[idServico] [int] NULL,
	[dataAtendimento] [datetime] NULL,
	[precoAtendimento] [money] NULL,
	[idCliente] [int] NULL,
 CONSTRAINT [PK__Atendime__CCF8C80C3455378D] PRIMARY KEY CLUSTERED 
(
	[idAtendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nomeCliente] [varchar](50) NULL,
	[telefoneCliente] [varchar](50) NULL,
	[emailCliente] [varchar](50) NULL,
	[enderecoCliente] [varchar](100) NULL,
	[bairroCliente] [varchar](50) NULL,
	[identidadeCliente] [varchar](50) NULL,
	[celularCliente] [varchar](50) NULL,
	[nascCliente] [varchar](10) NULL,
	[pagamentosCliente] [money] NULL,
	[dataInfoCliente] [datetime] NULL,
 CONSTRAINT [PK__Cliente__885457EEA29B4807] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[idFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nomeFornecedor] [varchar](50) NULL,
	[enderecoFornecedor] [varchar](150) NULL,
	[identidadeFornecedor] [varchar](50) NULL,
	[telefoneFornecedor] [varchar](50) NULL,
	[emailFornecedor] [varchar](50) NULL,
	[dataInfoFornecedor] [datetime] NULL,
 CONSTRAINT [PK__Forneced__CBE1227C365C4F44] PRIMARY KEY CLUSTERED 
(
	[idFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecimento]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecimento](
	[idFornecimento] [int] NOT NULL,
	[idFornecedor] [int] NULL,
	[dataFornecimento] [datetime] NULL,
 CONSTRAINT [PK__Fornecim__1FDFF32AA70360FB] PRIMARY KEY CLUSTERED 
(
	[idFornecimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[idFuncionario] [int] NOT NULL,
	[telefoneFuncionario] [varchar](50) NULL,
	[enderecoFuncionario] [varchar](50) NULL,
	[nomeFuncionario] [varchar](50) NULL,
	[bairroFuncionario] [varchar](50) NULL,
	[celularFuncionario] [varchar](50) NULL,
	[pagamentoFuncionario] [money] NULL,
	[identidadeFuncionario] [varchar](50) NULL,
	[nascFuncionario] [nchar](10) NULL,
	[dataInfoFuncionario] [datetime] NULL,
 CONSTRAINT [PK__Funciona__B0A12295BBBDC859] PRIMARY KEY CLUSTERED 
(
	[idFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
	[idFornecedor] [int] NULL,
	[nomeProduto] [varchar](50) NULL,
	[estoqueProduto] [int] NULL,
	[dataInfo] [datetime] NULL,
 CONSTRAINT [PK__Produto__2E883C23F0B6B310] PRIMARY KEY CLUSTERED 
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos_Atendimento]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos_Atendimento](
	[idProduto] [int] NULL,
	[idAtendimento] [int] NULL,
	[quantidadeProduto] [decimal](18, 0) NULL,
	[idProduto_Atendimento] [int] NOT NULL,
 CONSTRAINT [PK_Produtos_Atendimento] PRIMARY KEY CLUSTERED 
(
	[idProduto_Atendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos_Fornecimento]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos_Fornecimento](
	[idFornecimento] [int] NULL,
	[idProduto] [int] NULL,
	[idProduto_Fornecimento] [int] NOT NULL,
	[quantidadeProduto] [int] NULL,
 CONSTRAINT [PK_Produtos_Fornecimento] PRIMARY KEY CLUSTERED 
(
	[idProduto_Fornecimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servico]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servico](
	[idServico] [int] IDENTITY(1,1) NOT NULL,
	[nomeServico] [varchar](50) NULL,
	[precoServico] [varchar](50) NULL,
	[dataInfoServico] [datetime] NULL,
 CONSTRAINT [PK__Servico__0E3EA441E187726F] PRIMARY KEY CLUSTERED 
(
	[idServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serviços_Atendimento]    Script Date: 28/05/2018 23:34:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serviços_Atendimento](
	[idAtendimento] [int] NULL,
	[idServico_Atendimento] [int] IDENTITY(1,1) NOT NULL,
	[idServico] [int] NULL,
 CONSTRAINT [PK_Serviços_Atendimento] PRIMARY KEY CLUSTERED 
(
	[idServico_Atendimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Atendimento]  WITH CHECK ADD  CONSTRAINT [FK__Atendimen__idSer__7D439ABD] FOREIGN KEY([idServico])
REFERENCES [dbo].[Servico] ([idServico])
GO
ALTER TABLE [dbo].[Atendimento] CHECK CONSTRAINT [FK__Atendimen__idSer__7D439ABD]
GO
ALTER TABLE [dbo].[Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Atendimento_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Atendimento] CHECK CONSTRAINT [FK_Atendimento_Cliente]
GO
ALTER TABLE [dbo].[Fornecimento]  WITH CHECK ADD  CONSTRAINT [FK__Fornecime__idFor__7F2BE32F] FOREIGN KEY([idFornecedor])
REFERENCES [dbo].[Fornecedor] ([idFornecedor])
GO
ALTER TABLE [dbo].[Fornecimento] CHECK CONSTRAINT [FK__Fornecime__idFor__7F2BE32F]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK__Produto__idForne__00200768] FOREIGN KEY([idFornecedor])
REFERENCES [dbo].[Fornecedor] ([idFornecedor])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK__Produto__idForne__00200768]
GO
ALTER TABLE [dbo].[Produtos_Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Atendimento_Atendimento] FOREIGN KEY([idAtendimento])
REFERENCES [dbo].[Atendimento] ([idAtendimento])
GO
ALTER TABLE [dbo].[Produtos_Atendimento] CHECK CONSTRAINT [FK_Produtos_Atendimento_Atendimento]
GO
ALTER TABLE [dbo].[Produtos_Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Atendimento_Produto] FOREIGN KEY([idProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[Produtos_Atendimento] CHECK CONSTRAINT [FK_Produtos_Atendimento_Produto]
GO
ALTER TABLE [dbo].[Produtos_Fornecimento]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Fornecimento_Fornecimento] FOREIGN KEY([idFornecimento])
REFERENCES [dbo].[Fornecimento] ([idFornecimento])
GO
ALTER TABLE [dbo].[Produtos_Fornecimento] CHECK CONSTRAINT [FK_Produtos_Fornecimento_Fornecimento]
GO
ALTER TABLE [dbo].[Produtos_Fornecimento]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Fornecimento_Produto] FOREIGN KEY([idProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[Produtos_Fornecimento] CHECK CONSTRAINT [FK_Produtos_Fornecimento_Produto]
GO
ALTER TABLE [dbo].[Serviços_Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Serviços_Atendimento_Atendimento] FOREIGN KEY([idAtendimento])
REFERENCES [dbo].[Atendimento] ([idAtendimento])
GO
ALTER TABLE [dbo].[Serviços_Atendimento] CHECK CONSTRAINT [FK_Serviços_Atendimento_Atendimento]
GO
ALTER TABLE [dbo].[Serviços_Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Serviços_Atendimento_Servico] FOREIGN KEY([idServico])
REFERENCES [dbo].[Servico] ([idServico])
GO
ALTER TABLE [dbo].[Serviços_Atendimento] CHECK CONSTRAINT [FK_Serviços_Atendimento_Servico]
GO
