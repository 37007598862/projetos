# Blazor Aluno CRUD

This is a simple example of a student CRUD using Blazor Server. It allows you to add, edit, list, and delete students, using C# on both front-end and back-end.

## Features

- ✅ Create aluno
- 📝 Edit aluno
- 📋 List alunos
- ❌ Delete aluno

## To Start

1. Open the project in Visual Studio or via CLI.
2. In Program.cs, register the AlunoService service:

```csharp
builder.Services.AddSingleton<AlunoService>();
```

3. Add the /alunos route to NavMenu.razor or access it directly via URL.
4. Run the Blazor Server project and have fun!

---

by Cássio Andreatta
