# StudentsApi

**Source:**

https://code-maze.com/configure-postgresql-ef-core

## Postgres

```
CREATE TABLE public.students
(
  id uuid NOT NULL,
  name character varying(255) NOT NULL,
  age integer NOT NULL,
  PRIMARY KEY (id)
);

ALTER TABLE public.students
  OWNER to postgres;
```

## Endpoints

```
GET /api/Students
GET /api/Students/{id}

POST /api/Students
PUT /api/Students/{id}
DELETE /api/Students/{id}
```

## Postman

```json
{
  "info": {
    "_postman_id": "0b9bc1a7-ade0-472d-9209-668e8c8865e1",
    "name": "StudentsApi",
    "schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
  },
  "item": [
    {
      "name": "GetStudents",
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
          "raw": "https://localhost:5001/api/Students",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Students"
          ]
        }
      },
      "response": []
    },
    {
      "name": "GetStudent",
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
          "raw": "https://localhost:5001/api/Students/6461c251-f2b2-4e96-af8f-ce1180c1e7c6",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Students",
            "6461c251-f2b2-4e96-af8f-ce1180c1e7c6"
          ]
        }
      },
      "response": []
    },
    {
      "name": "PostStudent",
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
          "raw": "{\n  \"Name\": \"Chris Pratt\",\n  \"Age\": 40\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "url": {
          "raw": "https://localhost:5001/api/Students",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Students"
          ]
        }
      },
      "response": []
    },
    {
      "name": "PutStudent",
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
          "raw": "{\n  \"Id\": \"6461c251-f2b2-4e96-af8f-ce1180c1e7c6\",\n  \"Name\": \"John Pratt\",\n  \"Age\": 42\n}",
          "options": {
            "raw": {
              "language": "json"
            }
          }
        },
        "url": {
          "raw": "https://localhost:5001/api/Students/6461c251-f2b2-4e96-af8f-ce1180c1e7c6",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Students",
            "6461c251-f2b2-4e96-af8f-ce1180c1e7c6"
          ]
        }
      },
      "response": []
    },
    {
      "name": "DeleteStudent",
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
          "raw": "https://localhost:5001/api/Students/6461c251-f2b2-4e96-af8f-ce1180c1e7c6",
          "protocol": "https",
          "host": [
            "localhost"
          ],
          "port": "5001",
          "path": [
            "api",
            "Students",
            "6461c251-f2b2-4e96-af8f-ce1180c1e7c6"
          ]
        }
      },
      "response": []
    }
  ],
  "protocolProfileBehavior": {}
}
```
