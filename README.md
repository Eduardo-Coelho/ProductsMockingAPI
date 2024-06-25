# ProductsMockingAPI

This ASP.NET REST API serves as a foundational tool for developers aiming to create data-rich user interfaces. It simulates realistic Product data through HTTP endpoints, facilitating seamless integration and testing within applications. Leveraging ASP.NET's robust framework, developers can efficiently prototype and refine user experiences with mock data, ensuring scalability and performance in data-driven UI development.

`{
    "id": 2,
    "name": "product b",
    "price": 300,
    "amount": 100
}`

## Available Scripts

In the project directory, run first:

### `dotnet run`

## Debugging

1. Open the Debug view by clicking the Debug icon in the Activity Bar on the side of the window or by pressing Ctrl+Shift+D.

2. Select the .NET Core Launch (web) configuration from the dropdown at the top.

3. Click the green play button or press F5 to start debugging.

## Available endpoints

GET all `/api​/products`

GET by id `​/api​/products/{id}`

POST `​/api​/products`

PUT `/api​/products/{id}`

DELETE `/api​/products/{id}`
