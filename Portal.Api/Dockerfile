# Use a imagem oficial do SDK do .NET para a construção da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Defina o diretório de trabalho dentro do contêiner
WORKDIR /app

# Copie os arquivos .csproj e restaure as dependências
COPY *.csproj ./
RUN dotnet restore

# Copie todos os arquivos do projeto para o contêiner
COPY . .

# Compile a aplicação em modo Release para otimizar o desempenho
RUN dotnet publish -c Release -o out

# Use uma imagem mais leve do .NET Runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Defina o diretório de trabalho dentro do contêiner
WORKDIR /app

# Copie os arquivos da build para a nova imagem
COPY --from=build /app/out .

# Exponha a porta que a aplicação usa
EXPOSE 80

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "WebApi.dll"]
