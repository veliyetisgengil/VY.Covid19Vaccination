FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app 
#
# copy csproj and restore as distinct layers
COPY *.sln .
COPY src/VY.Covid19Vaccination.Presentation/*.csproj ./src/VY.Covid19Vaccination.Presentation/
COPY src/VY.Covid19Vaccination.Application/*.csproj ./src/VY.Covid19Vaccination.Application/
COPY src/VY.Covid19Vaccination.Domain/*.csproj ./src/VY.Covid19Vaccination.Domain/
COPY src/VY.Covid19Vaccination.Infrastrucure/*.csproj ./src/VY.Covid19Vaccination.Infrastrucure/ 
COPY tests/VY.Covid19Vaccination.UnitTest/*.csproj ./tests/VY.Covid19Vaccination.UnitTest/ 
#
RUN dotnet restore 
#
# copy everything else and build app
COPY src/VY.Covid19Vaccination.Presentation/. ./VY.Covid19Vaccination.Presentation/
COPY src/VY.Covid19Vaccination.Application/. ./VY.Covid19Vaccination.Application/
COPY src/VY.Covid19Vaccination.Domain/. ./VY.Covid19Vaccination.Domain/ 
COPY src/VY.Covid19Vaccination.Infrastrucure/. ./VY.Covid19Vaccination.Infrastrucure/ 
#
WORKDIR /app/VY.Covid19Vaccination.Presentation
RUN dotnet publish -c Release -o out 
#
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app 
#
COPY --from=build /app/VY.Covid19Vaccination.Presentation/out ./
ENTRYPOINT ["dotnet", "VY.Covid19Vaccination.Presentation.dll"]