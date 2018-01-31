To build and test

```
dotnet restore
dotnet build
dotnet run --project OpenRastaCore
```

You can test the api using this GET, double check the port number after running `dotnet run`.

```http
GET http://localhost:5000/tasks
```

```http
HTTP/1.1 200 OK
Date: Wed, 31 Jan 2018 18:20:07 GMT
Content-Type: application/json
Server: Kestrel
Content-Length: 55

[
  {
    "id": 1,
    "title": "Title 1"
  },
  {
    "id": 2,
    "title": "Title 2"
  }
]
```

```
docker-compose up --build
```

if after you are having troubles running again
```
docker-compose down
```
to clean up left over bits and run
```
docker-compose up --build --force-recreate
```