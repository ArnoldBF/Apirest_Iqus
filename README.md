# Aplicacion web - CRUD de Productos

Esta es una aplicacion web desarrollada como parte de una **prueba técnica para una entrevista laboral**. La API permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) sobre una entidad llamada 
**Producto** tambien cuenta con una aplicacion frontend.

## 📌 Tecnologías backend

- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server 
- Postman (para documentación interactiva)
- C#
## 📌 Tecnologías frontend
- Node
- Html
- Css
- Javascript
  

## 📦 Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/ArnoldBF/Apirest_Iqus.git
   cd Apirest_Iqus
2. Restaura los paquetes y aplica las migrationes:
   ```bash
   dotnet restore
   dotnet ef database update --project Infrastructure --startup-project Api
3. Ejecuta la aplicacion backend:
   ```bash
   dotnet run --project Api
4. Accede a la documentacion:
   ```bash
   https://documenter.getpostman.com/view/29212507/2sB2j7epqF
5. Para ejecutar el frontend es necesario instalar Node:
   ```bash
   https://nodejs.org/es
6. Instalar dependencias de frontend:
   ```bash
   cd .\Frontend
   npm install
7. Ejecuta la aplicacion frontend:
   ```bash
   cd .\src
   npx http-server --cors
   
