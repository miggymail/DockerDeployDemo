dotnet new webapi --n DockerAPI
code --r DockerAPI

docker build -t DockerImageName	. -> build docker image with name
docker images	-> list available docker images
docker run -p 8080:80 ImageName	-> map docker image port to public port

docker ps     -> list running containers
docker stop

Docker Image == Class
Docker Container == Object Instance
Run SQL Server In Docker

docker --version

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Pa$$w0rd2019' -e 'MSSQL_PID=Express' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest-ubuntu

docker exec -it 0ac7fcd0bf0d /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'Pa$$w0rd2019'

docker-compose up	-> execute docker-compose.yml