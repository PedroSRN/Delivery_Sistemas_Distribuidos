CREATE TABLE [dbo].[TB_Produtos] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Nome]          VARCHAR (300)   NOT NULL,
    [Preco]         DECIMAL (18, 2) NOT NULL,
    [Quantidade]    INT             NOT NULL,
    [TipoDoProduto] VARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_TB_Produtos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

