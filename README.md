# 👤 InsightFlow-users-service

**Microservicio desarrollada como parte del Sistema de InsightFlow**  
Este microservicio representa el backend de una plataforma de creación, visualización, edición y eliminación de usuarios. 

---

## 📚 Descripción del proyecto

Este proyecto consiste en el desarrollo de un microservicio utilizando **.NET 9**, orientada a la gestión de productos del sistema InsightFlow 
La arquitectura sigue buenas prácticas de diseño, incluyendo los patrones **Repository**, lo que permite una separación clara de responsabilidades y facilita el mantenimiento y escalabilidad del sistema.

El foco del desarrollo actual está en la estructuración del backend para futuras integraciones frontend.

---

## 🧑‍💻 Autor

- **Ignacio Alfonso Morales Harnisch**
---

## 🧱 Tecnologías utilizadas

- [.NET 9](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-9)
- [Git](https://git-scm.com/)
- [Docker or Docker Desktop](https://docs.docker.com/)
- [Render](https://render.com/)
- UUID V4
- C#
- Patrones: Repository

---

## 🗂️ Estructura del proyecto

```
Src/
│
├── Controllers/        → Controladores donde se encuentran los endpoints
├── DTOs/               → Clases para transferencia de datos (CreateProductDto, ProductResponseDto, UpdateProductDto)
├── Interfaces/         → Interfaces de los servicios y repositorios
├── Models/             → Entidades del dominio: Product.
├── Repositories/       → Implementaciones de lógica de acceso a datos
├── Services/           → Servicios que interactuan con los controladores
├── Program.cs          → Configuración general del servidor y servicios
```

---

## ⚙️ Cómo ejecutar el proyecto de forma local

### 1. Clonar el repositorio

```bash
git clone https://github.com/Thetrolxs/insightflow-users-service.git
cd insightflow-users-service.git
```

### 2. Construir el proyecto de forma local
```bash
dotnet restore
```
### 2.2 Construir el proyecto de forma local
```bash
dotnet build
```

### 2.3 Construir el proyecto de forma local
```bash
dotnet run
```

## ⚙️ Visualizar el proyecto desplegado en: [InsightFlow-users-service](https://insightflow-users-service-qe8m.onrender.com/users/)

---
## 📖 Endpoints
| Metodo  | Endpoint | Descripción  |
| ------------- | ------------- | ------------- |
| POST | `/users/` | Se crea un nuevo producto |
| GET | `/users/` | Se obtiene una lista de productos |
| GET | `/users/{id}` | Se obtiene un producto en base a su ID |
| PATCH | `/users/{id}` | Se actualiza un producto en base a su ID |
| DELETE | `/users/{id}` | Se borra (softDelete) un producto en base a su ID |

## Postman

Para probar el backend usando "postman", se necesita instalar el programa [Postman]
Al abrir Postman y elegir un espacio de trabajo, debes hacer click en "Import" y seleccionar "InsightFlow-Users.postman_collection.json".
Dentro del proyecto se encuentra la URL del despliegue para realizar las pruebas correspondientes.

