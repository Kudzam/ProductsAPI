**ProductsAPI**

ProductsAPI is a simple RESTful API built to simulate products you might find in a supermarket or clothing retail store. It’s designed as a practical project to demonstrate core API functionality and database interactions.

The API supports full CRUD operations and is built using SQL Server with Code-First Migrations.

**Features & Technologies**

- CRUD operations (Create, Read, Update, Delete)
- Code-First Migrations
- SQL Server
- Scalar for API testing

**CRUD Endpoints**

The following CRUD operations are implemented in this API:
- GetProduct – Retrieves all products from the database.
- GetProductById – Retrieves a single product using its ID.
- AddProduct – Adds a new product to the catalogue.
- UpdateProduct – Updates an existing product.
- DeleteProduct – Deletes a product from the database.

**Testing**

Scalar was used to test the API endpoints. While tools like Postman or Swagger could have been used, Scalar was chosen to gain hands-on experience testing the API manually. Swagger was not used due to support limitations.

**Database & Migrations**

Code-First Migrations were used to create and manage the database schema, making it easier to update tables as the project evolves. SQL Server was chosen over alternatives like Cosmos DB to allow for future expansion, including adding related tables and building relationships within the database.
