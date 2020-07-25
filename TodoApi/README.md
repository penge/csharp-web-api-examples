# TodoApi

**Source:**

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1

## Endpoints

```
GET /api/TodoItems
GET /api/TodoItems/{id}

POST /api/TodoItems
PUT /api/TodoItems/{id}
DELETE /api/TodoItems/{id}
```

## Postman

```json
{
  "info": {
    "_postman_id": "749efe5c-0934-4840-9077-b6149082c536",
    "name": "TodoApi",
    "schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
  },
  "item": [
    {
      "name": "GetTodoItems",
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
          "raw": "https://localhost:5001/api/TodoItems",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "TodoItems"
          ]
        }
      },
      "response": []
    },
    {
      "name": "GetTodoItem",
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
          "raw": "https://localhost:5001/api/TodoItems/1",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "TodoItems",
            "1"
          ]
        }
      },
      "response": []
    },
    {
      "name": "PostTodoItem",
      "request": {
        "method": "POST",
        "header": [
          {
            "key": "Content-Type",
            "value": "application/json",
            "type": "text"
          }
        ],
        "body": {
          "mode": "raw",
          "raw": "{\n  \"name\":\"walk dog\",\n  \"isComplete\":true\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "url": {
          "raw": "https://localhost:5001/api/TodoItems",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "TodoItems"
          ]
        }
      },
      "response": []
    },
    {
      "name": "PutTodoItem",
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
          "raw": "{\n  \"ID\":1,\n  \"name\":\"feed fish\",\n  \"isComplete\":true\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "url": {
          "raw": "https://localhost:5001/api/TodoItems/1",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "TodoItems",
            "1"
          ]
        }
      },
      "response": []
    },
    {
      "name": "DeleteTodoItem",
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
          "raw": "https://localhost:5001/api/TodoItems/1",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "TodoItems",
            "1"
          ]
        }
      },
      "response": []
    }
  ],
  "protocolProfileBehavior": {}
}
```

