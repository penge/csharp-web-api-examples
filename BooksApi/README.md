# BooksApi

**Source:**

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.1

## Mongo

```
mongo

use BookstoreDb

db.createCollection('Books')

db.Books.insertMany([
  {'Name':'Design Patterns','Price':54.93,'Category':'Computers','Author':'Ralph Johnson'},
  {'Name':'Clean Code','Price':43.15,'Category':'Computers','Author':'Robert C. Martin'}])

db.Books.find({}).pretty()
```

## Endpoints

```
GET /api/Books
GET /api/Books/{id}

POST /api/Books
PUT /api/Books/{id}
DELETE /api/Books/{id}
```

## Postman

```json
{
  "info": {
    "_postman_id": "61c70f9e-a454-4aec-9fbb-8538998e7b3f",
    "name": "BooksApi",
    "schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
  },
  "item": [
    {
      "name": "GetBooks",
      "request": {
        "method": "GET",
        "header": [
          {
            "key": "Content-Type",
            "type": "text",
            "value": "application/json"
          }
        ],
        "url": {
          "raw": "https://localhost:5001/api/Books",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Books"
          ]
        }
      },
      "response": []
    },
    {
      "name": "GetBook",
      "request": {
        "method": "GET",
        "header": [
          {
            "key": "Content-Type",
            "type": "text",
            "value": "application/json"
          }
        ],
        "url": {
          "raw": "https://localhost:5001/api/Books/5f1b68b62a126513df067853",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Books",
            "5f1b68b62a126513df067853"
          ]
        }
      },
      "response": []
    },
    {
      "name": "PostBook",
      "request": {
        "method": "POST",
        "header": [
          {
            "key": "Content-Type",
            "type": "text",
            "value": "application/json"
          }
        ],
        "body": {
          "mode": "raw",
          "raw": "{\n  \"bookName\": \"The Lord of the Rings\",\n  \"price\": 72.58,\n  \"category\": \"Fiction\",\n  \"author\": \"J‎.R.R. Tolkien\"\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "url": {
          "raw": "https://localhost:5001/api/Books",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Books"
          ]
        }
      },
      "response": []
    },
    {
      "name": "PutBook",
      "request": {
        "method": "PUT",
        "header": [
          {
            "key": "Content-Type",
            "type": "text",
            "value": "application/json"
          }
        ],
        "body": {
          "mode": "raw",
          "raw": "{\n  \"id\": \"5f1ba0b9bb2233365f17b448\",\n  \"bookName\": \"The Lord of the Rings\",\n  \"price\": 64.22,\n  \"category\": \"Fiction\",\n  \"author\": \"J‎.R.R. Tolkien\"\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "url": {
          "raw": "https://localhost:5001/api/Books/5f1ba0b9bb2233365f17b448",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Books",
            "5f1ba0b9bb2233365f17b448"
          ]
        }
      },
      "response": []
    },
    {
      "name": "DeleteBook",
      "request": {
        "method": "DELETE",
        "header": [
          {
            "key": "Content-Type",
            "type": "text",
            "value": "application/json"
          }
        ],
        "url": {
          "raw": "https://localhost:5001/api/Books/5f1ba0b9bb2233365f17b448",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Books",
            "5f1ba0b9bb2233365f17b448"
          ]
        }
      },
      "response": []
    }
  ],
  "protocolProfileBehavior": {}
}
```
