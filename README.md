\# Taller Práctico: Arquitectura Monolítica en ASP.NET Core MVC con Entity Framework Core y SQL Server



\*\*Institución:\*\* Universidad Técnica Luis Vargas Torres de Esmeraldas (UTLVTE)  

\*\*Carrera:\*\* Ingeniería en Tecnologías de la Información  

\*\*Materia:\*\* Arquitectura de Software  



\---



\## 1. Descripción del Proyecto

Este proyecto implementa una solución de arquitectura monolítica modular para la gestión académica, integrando el registro de estudiantes, asignaturas y control de matrículas mediante el patrón Modelo-Vista-Controlador (MVC). 



La persistencia de datos está desarrollada bajo el enfoque \*\*Code-First\*\* utilizando \*\*Entity Framework Core 9.0\*\* conectado a un motor relacional local \*\*Microsoft SQL Server (MSSQLSERVER)\*\*.



\---



\## 2. Tecnologías Utilizadas

\- \*\*Lenguaje:\*\* C# (.NET 9.0)

\- \*\*Framework Web:\*\* ASP.NET Core MVC

\- \*\*ORM:\*\* Entity Framework Core 9.0 (SqlServer, Tools, Design)

\- \*\*Base de Datos:\*\* Microsoft SQL Server

\- \*\*Administrador de BD:\*\* SQL Server Management Studio (SSMS)

\- \*\*Frontend:\*\* Razor Views, Bootstrap 5, HTML5



\---



\## 3. Modelo de Dominio y Relaciones

\- \*\*Estudiante:\*\* Cédula (índice único), Nombres, Apellidos, Correo Institucional, Carrera, Fecha de Registro y Estado Activo.

\- \*\*Asignatura:\*\* Código, Nombre de la Asignatura, Créditos y Nivel académico.

\- \*\*Matrícula:\*\* Entidad intermedia que materializa la relación \*\*Muchos a Muchos (N:M)\*\* entre Estudiantes y Asignaturas, incluyendo Claves Foráneas (`EstudianteId`, `AsignaturaId`), Fecha de Matrícula y Periodo Académico.



\---



\## 4. Instrucciones de Ejecución Local



1\. \*\*Clonar el repositorio:\*\*

&#x20;  ```bash

&#x20;  git clone <URL\_DE\_TU\_REPOSITORIO>

&#x20;  cd UtlvteMonolitoApp/UtlvteMonolito.Web

