IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    IF SCHEMA_ID(N'app') IS NULL EXEC(N'CREATE SCHEMA [app];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE TABLE [app].[Exam] (
        [Id] int NOT NULL IDENTITY,
        [Titre] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Exam] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE TABLE [app].[Subject] (
        [Id] int NOT NULL IDENTITY,
        [Titre] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [ExamId] int NOT NULL,
        CONSTRAINT [PK_Subject] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Subject_Exam_ExamId] FOREIGN KEY ([ExamId]) REFERENCES [app].[Exam] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE TABLE [app].[Question] (
        [Id] int NOT NULL IDENTITY,
        [Titre] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [SubjectId] int NOT NULL,
        CONSTRAINT [PK_Question] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Question_Subject_SubjectId] FOREIGN KEY ([SubjectId]) REFERENCES [app].[Subject] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE TABLE [app].[Response] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        [IsCorrect] bit NOT NULL,
        [QuestionId] int NOT NULL,
        CONSTRAINT [PK_Response] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Response_Question_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [app].[Question] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE INDEX [IX_Question_SubjectId] ON [app].[Question] ([SubjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE INDEX [IX_Response_QuestionId] ON [app].[Response] ([QuestionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    CREATE INDEX [IX_Subject_ExamId] ON [app].[Subject] ([ExamId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200828184149_20200828_20h39')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200828184149_20200828_20h39', N'3.1.7');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200831125005_test')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200831125005_test', N'3.1.7');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200831164313_20200831_18h43')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[app].[Response]') AND [c].[name] = N'Description');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [app].[Response] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [app].[Response] ALTER COLUMN [Description] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200831164313_20200831_18h43')
BEGIN
    ALTER TABLE [app].[Response] ADD [Titre] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200831164313_20200831_18h43')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[app].[Question]') AND [c].[name] = N'Titre');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [app].[Question] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [app].[Question] ALTER COLUMN [Titre] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200831164313_20200831_18h43')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[app].[Question]') AND [c].[name] = N'Description');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [app].[Question] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [app].[Question] ALTER COLUMN [Description] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200831164313_20200831_18h43')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200831164313_20200831_18h43', N'3.1.7');
END;

GO

