🌍 [Leia em Português](README.pt-BR.md)

# Product Manager API

API RESTfulf developed as ASP.NET Core and OracleDB + EF Core to manage products.

## Routes

(Product)

- `GET api/products` - Get All products.
- `GET api/products/{id}` - Get product by Id.
- `POST api/products` - Create a New Product.
- `PUT api/products/{id}` - Update Product by Id.
- `DELETE api/products/{id}` - Delete Product by Id.

## Steps to run

1. Clone the repository:

```bash
git clone https://github.com/felipeclarindo/product-manager-api.git
```

2. Enter repository:

```bash
cd product-manager-api
```

3. Create and configure the `.env` file using the model in [.env.example](./.env.example)

4. Run migrations:

```bash
1. dotnet ef migrations add Initial
2. dotnet ef database update
3. dotnet ef database update
```

5. Run the api:

```bash
dotnet run
```

6. The api is avaible on:

- <http://localhost:5184/api>

## Contribution

Contributions are welcome! If you have suggestions for improvements, feel free to open an issue or submit a pull request.

## License

This project is licensed under the [GNU Affero License](https://www.gnu.org/licenses/agpl-3.0.html).
