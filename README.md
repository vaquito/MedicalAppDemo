# MedicalAppDemo

Demo .net core 2.0 con MySQL, Angular y EF core. 

## configuración 

1. tener un motor de mySQL local. 

2. cambiar el conexion string del archivo: appsettings.json para apuntar a la base local. 

3. en la primera ejecución la aplicación generara la base de datos con datos de ejemplo. 

## Compilar

el compilado final se puede generar tanto en Visual studio 2017 community como por medio del CLI de .net core con el comando 

```
dotnet publish --output /C:\build_output
```
ejecutado sobre el proyecto FrontEnd. guía -> https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x


## Deploy
con la compilación lista debemos seguir la guía de instalación para IIS/Windows, para Apache/Linux o Docker según sea el caso

### IIS
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/iis/?view=aspnetcore-2.1&tabs=aspnetcore2x

### Apache
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-apache?view=aspnetcore-2.1&tabs=aspnetcore2x

### Docker
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/docker/?view=aspnetcore-2.1

