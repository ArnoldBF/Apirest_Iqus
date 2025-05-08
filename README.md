# API REST - CRUD de Productos

Esta es una API RESTful desarrollada como parte de una **prueba técnica para una entrevista laboral**. La API permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) sobre una entidad llamada **Producto**.

## 📌 Tecnologías utilizadas

- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server 
- Postman (para documentación interactiva)
- C#

## 📦 Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/ArnoldBF/Apirest_Iqus.git
   cd Apirest_Iqus
2. Restaura los paquetes y aplica las migrationes:
   ```bash
   dotnet restore
   dotnet ef database update --project Infrastructure --startup-project Api
3. Ejecita la aplicacion:
   ```bash
   dotnet run --project Api
4. Accede a la documentacion:
   ```bash
   https://documenter.getpostman.com/view/29212507/2sB2j7epqF 
