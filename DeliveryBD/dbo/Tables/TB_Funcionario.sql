CREATE TABLE [dbo].[TB_Funcionario] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (300)  NOT NULL,
    [Cargo]          VARCHAR (200)  NOT NULL,
    [CPF]            VARCHAR (14)   NOT NULL,
    [Salario]        DECIMAL (5, 2) NOT NULL,
    [DataNascimento] DATETIME       NOT NULL,
    CONSTRAINT [PK_TB_Funcionario] PRIMARY KEY CLUSTERED ([id] ASC)
);

