IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE TABLE [Comentarios] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NULL,
        [DataHora] datetime2 NOT NULL,
        [Conteudo] nvarchar(max) NULL,
        CONSTRAINT [PK_Comentarios] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE TABLE [Nutricionista] (
        [Cpf] nvarchar(11) NOT NULL,
        [Crn] int NOT NULL,
        [Nome] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [DataNascimento] date NOT NULL,
        [Senha] nvarchar(max) NULL,
        [Telefone] nvarchar(11) NOT NULL,
        CONSTRAINT [PK_Nutricionista] PRIMARY KEY ([Cpf])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE TABLE [PlanosAlimentares] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [Nomepaciente] nvarchar(max) NOT NULL,
        [Objetivo] nvarchar(max) NOT NULL,
        [Descricao] nvarchar(max) NOT NULL,
        [Observacao] nvarchar(max) NULL,
        CONSTRAINT [PK_PlanosAlimentares] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE TABLE [Receitas] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        [IngredienteQuantidade] nvarchar(max) NOT NULL,
        [MododePreparo] nvarchar(max) NOT NULL,
        [Observacoes] nvarchar(max) NULL,
        [Calorias] int NOT NULL,
        [Curtidas] int NOT NULL,
        CONSTRAINT [PK_Receitas] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE TABLE [Paciente] (
        [Cpf] nvarchar(11) NOT NULL,
        [Altura] float NOT NULL,
        [Peso] float NOT NULL,
        [Pagante] bit NOT NULL,
        [CpfNutricionista] nvarchar(max) NULL,
        [NutricionistaCpf] nvarchar(11) NULL,
        [Nome] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [DataNascimento] date NOT NULL,
        [Senha] nvarchar(max) NULL,
        [Telefone] nvarchar(11) NOT NULL,
        CONSTRAINT [PK_Paciente] PRIMARY KEY ([Cpf]),
        CONSTRAINT [FK_Paciente_Nutricionista_NutricionistaCpf] FOREIGN KEY ([NutricionistaCpf]) REFERENCES [Nutricionista] ([Cpf])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE TABLE [Refeicoes] (
        [Id] int NOT NULL IDENTITY,
        [Tipo] nvarchar(max) NOT NULL,
        [Hora] time NOT NULL,
        [PlanoAlimentarId] int NOT NULL,
        [ReceitaId] int NOT NULL,
        CONSTRAINT [PK_Refeicoes] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Refeicoes_PlanosAlimentares_PlanoAlimentarId] FOREIGN KEY ([PlanoAlimentarId]) REFERENCES [PlanosAlimentares] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Refeicoes_Receitas_ReceitaId] FOREIGN KEY ([ReceitaId]) REFERENCES [Receitas] ([Id]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE INDEX [IX_Paciente_NutricionistaCpf] ON [Paciente] ([NutricionistaCpf]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE INDEX [IX_Refeicoes_PlanoAlimentarId] ON [Refeicoes] ([PlanoAlimentarId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    CREATE INDEX [IX_Refeicoes_ReceitaId] ON [Refeicoes] ([ReceitaId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241118230101_foreignKey'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20241118230101_foreignKey', N'8.0.10');
END;
GO

COMMIT;
GO

