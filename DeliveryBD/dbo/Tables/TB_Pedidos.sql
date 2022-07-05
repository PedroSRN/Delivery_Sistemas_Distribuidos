CREATE TABLE [dbo].[TB_Pedidos] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Cliente_id]     INT            NOT NULL,
    [Produtos_id]    INT            NOT NULL,
    [Funcionario_id] INT            NOT NULL,
    [Observacao]     VARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_TB_Pedidos] PRIMARY KEY CLUSTERED ([Id] ASC)
);

