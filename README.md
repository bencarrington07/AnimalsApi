# AnimalsApi
API For gathering facts about animals.

## Run in Docker!
```
dotnet publish --os linux --arch x64 /t:PublishContainer -c Release .

docker run --name docker-net-example -p 8080:80 -d animalsapi:1.0.0
```
