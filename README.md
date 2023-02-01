# AnimalsApi
API For gathering facts about animals.

[![CodeFactor](https://www.codefactor.io/repository/github/bencarrington07/animalsapi/badge)](https://www.codefactor.io/repository/github/bencarrington07/animalsapi)
[![CircleCI](https://dl.circleci.com/status-badge/img/gh/bencarrington07/AnimalsApi/tree/main.svg?style=svg)](https://dl.circleci.com/status-badge/redirect/gh/bencarrington07/AnimalsApi/tree/main)

## Run in Docker!
```
dotnet publish --os linux --arch x64 /t:PublishContainer -c Release .

docker run --name docker-net-example -p 8080:80 -d animalsapi:1.0.0
```
