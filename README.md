# 📦 CrudDapper

Projeto de estudo desenvolvido em **.NET 10** com **Dapper**, focado na criação de uma API simples para gerenciamento de usuários.

---

## 🚀 Tecnologias Utilizadas

- [.NET 10](https://dotnet.microsoft.com/)
- [Dapper](https://github.com/DapperLib/Dapper)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Postman](https://www.postman.com/) — para teste das requisições

---

## 📋 Endpoints Disponíveis

### 🔵 Buscar todos os usuários
```http
GET /api/Usuario
```
Retorna a lista completa de usuários cadastrados.

---

### 🔵 Buscar usuário por ID
```http
GET /api/Usuario/{idUsuario}
```
Retorna os dados de um usuário específico pelo ID.

| Parâmetro   | Tipo  | Descrição              |
|-------------|-------|------------------------|
| `idUsuario` | `int` | ID do usuário desejado |

---

## 🗄️ Estrutura da Tabela

```sql
CREATE TABLE Usuarios (
    IdUsuario    INT           IDENTITY(1,1) PRIMARY KEY,
    NomeCompleto VARCHAR(100),
    Email        VARCHAR(100),
    Cargo        VARCHAR(100),
    CPF          VARCHAR(11),
    Salario      DECIMAL(18,0),
    Situacao     BIT,
    Senha        VARCHAR(100)
)
```

---

## ▶️ Como Executar

1. Clone o repositório
```bash
git clone https://github.com/seu-usuario/CrudDapper.git
```

2. Configure a string de conexão no `appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=SEU_BANCO;Trusted_Connection=True;"
}
```

3. Execute o projeto
```bash
dotnet run
```

4. Acesse a API em:
```
https://localhost:7079/api/Usuario
```

---

## 🧪 Testando com Postman

Importe a URL base `https://localhost:7079` no Postman e utilize os endpoints listados acima para testar as requisições GET.

---

## 📝 Observações

Este projeto foi desenvolvido com fins de **estudo e aprendizado**, explorando o uso do Dapper como micro-ORM para acesso a dados com .NET 10.
