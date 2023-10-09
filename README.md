# API de Sistema Escolar

Esta é uma API desenvolvida em .NET para um sistema escolar que permite o gerenciamento de alunos, disciplinas e notas. Ela inclui recursos de CRUD (Create, Read, Update, Delete) para essas entidades, utiliza relacionamentos entre tabelas, mapeamento de modelos e implementa autenticação JWT para proteger os endpoints.

## Funcionalidades

- **Alunos**: Crie, liste, atualize e exclua informações de alunos.
- **Disciplinas**: Gerencie disciplinas, atribua alunos a disciplinas e liste disciplinas por aluno.
- **Notas**: Registre notas para alunos em disciplinas específicas.

## Tecnologias Utilizadas

- **.NET Core**: Framework de desenvolvimento.
- **Entity Framework Core**: ORM para mapeamento objeto-relacional.
- **SQL Server**: Banco de dados utilizado para armazenar dados.
- **JSON Web Tokens (JWT)**: Autenticação e autorização de endpoints.
- **Swagger**: Documentação interativa da API.

## Configuração

1. Clone este repositório em sua máquina local.

   ```bash
   git clone https://github.com/seu-usuario/sua-api-escolar.git
2. Abra o projeto em seu ambiente de desenvolvimento preferido (por exemplo, Visual Studio ou Visual Studio Code).

Configure sua conexão com o banco de dados SQL Server no arquivo appsettings.json:
```bash
"ConnectionStrings": {
    "DefaultConnection": "SuaConnectionString"
}
