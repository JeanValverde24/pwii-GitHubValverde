# Usa una imagen base de Windows con soporte para .NET Framework 4.8
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2022

# Configura el directorio de trabajo dentro del contenedor
WORKDIR /inetpub/wwwroot

# Copia los archivos de tu aplicaci�n dentro del contenedor
COPY . .

# Exponer el puerto 80 para que la aplicaci�n sea accesible
EXPOSE 90
