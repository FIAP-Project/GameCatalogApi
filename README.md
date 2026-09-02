# GameCatalogApi

## Tema e Objetivo

A **GameCatalogApi** é uma Web API desenvolvida em **ASP.NET Core (.NET 10)** cujo tema é um **catálogo de jogos (GameCatalog)**. O objetivo da API é permitir o gerenciamento (cadastro, consulta, atualização e remoção) de jogos, cada um contendo informações como título, gênero, plataforma e preço.

## Integrantes

* Nome Completo - RM 000000
* Nome Completo - RM 000000
* Nome Completo - RM 000000

## Estrutura do Projeto

```
GameCatalogApi/
├── Controllers/    # Endpoints da API (GamesController)
├── DTOs/           # Objetos de transferência de dados (GameRequest)
├── Models/         # Entidades de domínio (Game)
├── Data/           # Contexto de dados em memória (AppDbContext)
└── Program.cs      # Configuração da aplicação
```

## Entidade Principal - Game

| Campo    | Tipo    | Descrição                  |
|----------|---------|-----------------------------|
| Id       | int     | Identificador único          |
| Title    | string  | Título do jogo               |
| Genre    | string  | Gênero do jogo                |
| Platform | string  | Plataforma do jogo            |
| Price    | decimal | Preço do jogo                 |

## Endpoints

| Método | Rota                       | Descrição                          |
|--------|----------------------------|--------------------------------------|
| GET    | /api/v1/games              | Lista todos os jogos                 |
| GET    | /api/v1/games/{id}         | Busca um jogo pelo identificador     |
| POST   | /api/v1/games              | Cria um novo jogo                    |
| PUT    | /api/v1/games/{id}         | Atualiza um jogo existente           |
| DELETE | /api/v1/games/{id}         | Remove um jogo pelo identificador    |

## Instruções de Execução

1. Certifique-se de ter o **.NET 10 SDK** instalado.
2. Clone o repositório e acesse a pasta do projeto:
   ```bash
   git clone <url-do-repositorio>
   cd GameCatalogApi/GameCatalogApi
   ```
3. Execute a aplicação:
   ```bash
   dotnet run
   ```
4. Acesse a documentação interativa (Swagger/OpenAPI) pela URL exibida no console (ex.: `https://localhost:5001/swagger` ou `/openapi/v1.json`).

## Exemplos de Chamadas

### Criar um jogo (POST)

```http
POST /api/v1/games
Content-Type: application/json

{
  "title": "The Legend of Zelda: Breath of the Wild",
  "genre": "Aventura",
  "platform": "Nintendo Switch",
  "price": 299.90
}
```

### Listar todos os jogos (GET)

```http
GET /api/v1/games
```

### Buscar um jogo por ID (GET)

```http
GET /api/v1/games/1
```

### Atualizar um jogo (PUT)

```http
PUT /api/v1/games/1
Content-Type: application/json

{
  "title": "The Legend of Zelda: Tears of the Kingdom",
  "genre": "Aventura",
  "platform": "Nintendo Switch",
  "price": 349.90
}
```

### Remover um jogo (DELETE)

```http
DELETE /api/v1/games/1
```

## Prints dos Testes no Swagger

> Adicione aqui os prints das chamadas realizadas no Swagger para cada endpoint (GET, POST, PUT, DELETE).
