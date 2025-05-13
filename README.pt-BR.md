🌍 [Leia em Português](README.pt-BR.md)

# Mottu Mapping API

API RESTful desenvolvida com ASP.NET Core e OracleDB + EF Core para gerenciar produtos.

## Rotas

(Product)

- `GET api/motos` - Obter todas os Produtos.
- `GET api/products/{id}` - Obter Produto por ID.
- `POST api/products` - Criar um Novo produto.
- `PUT api/products/{id}` - Atualizar Produto por ID.
- `DELETE api/products/{id}` - Deletar Produto por ID.

## Passos para rodar

1. Clone o repositório:

```bash
git clone https://github.com/felipeclarindo/product-manager-api.git
```

2. Entre no repositório:

```bash
cd product-manager-api
```

3. Crie e configure o arquivo .env usando o modelo em [.env.example](./.env.example)

4. Execute as migrações:

```bash
1. dotnet ef migrations add Initial
2. dotnet ef database update
3. dotnet ef database update
```

5. Rode a API:

```bash
dotnet run
```

6. A API está disponível em:

- <http://localhost:5184/api>

## Contribuição

Contribuições são bem-vindas! Se você tiver sugestões de melhorias, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença

Este projeto está licenciado sob a [GNU Affero License](https://www.gnu.org/licenses/agpl-3.0.html).
