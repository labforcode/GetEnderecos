
# Docker
## Criação de Volume Docker
docker volume create enderecos-production

docker volume create enderecos-staging

docker volume create enderecos-development

## Inspeção de Volume Docker
docker volume inspect enderecos-production

docker volume inspect enderecos-staging

docker volume inspect enderecos-development

## Executar o container do Postgres para a API Endereços
docker run -ti --network=dev-local --ip 172.18.0.31 -p 5435:5432 --name enderecos-production -e "POSTGRES_PASSWORD=lab4code!" -v /var/lib/docker/volumes/enderecos-production/_data:/var/lib/postgresql/data -d postgres

docker run -ti --network=dev-local --ip 172.18.0.33 -p 5437:5432 --name enderecos-staging -e "POSTGRES_PASSWORD=lab4code!" -v /var/lib/docker/volumes/enderecos-staging/_data:/var/lib/postgresql/data -d postgres

docker run -ti --network=dev-local --ip 172.18.0.35 -p 5439:5432 --name enderecos-development -e "POSTGRES_PASSWORD=lab4code!" -v /var/lib/docker/volumes/enderecos-development/_data:/var/lib/postgresql/data -d postgres


# Migration

1 - Setar o projeto de Infra.Data como principal a ser executado

2- Pelo PowerShell, entrar na pasta D:\dev\sharp\GetEnderecos\src\5-Infra\5.1-Data\GetEnderecos.Infra.Data

3 - Executar o comando abaixo para setar o Ambiente em que deseja fazer o Migration

$Env:ASPNETCORE_ENVIRONMENT = "Production"
$Env:ASPNETCORE_ENVIRONMENT = "Staging"
$Env:ASPNETCORE_ENVIRONMENT = "Development"

4 - Então, executar o comando abaixo para gerar o Migration, de acordo com o ambiente setado anteriormente

dotnet ef migrations add production --context ApiDataContext -s D:\dev\sharp\GetEnderecos\src\1-Services\GetEnderecos.Api --verbose
dotnet ef migrations add staging --context ApiDataContext -s D:\dev\sharp\GetEnderecos\src\1-Services\GetEnderecos.Api --verbose
dotnet ef migrations add development --context ApiDataContext -s D:\dev\sharp\GetEnderecos\src\1-Services\GetEnderecos.Api --verbose


5 - Após a geração do Migration, executar o comando abaixo para atualizar a DataBase

dotnet ef database update --context ApiDataContext -s D:\dev\sharp\GetEnderecos\src\1-Services\GetEnderecos.Api --verbose