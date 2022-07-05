CREATE TABLE [dbo].[TB_Clientes] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (300) NOT NULL,
    [Telefone] VARCHAR (13)  NOT NULL,
    [CPF]      VARCHAR (14)  NOT NULL,
    [Endereco] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_TB_Clientes] PRIMARY KEY CLUSTERED ([id] ASC)
);

