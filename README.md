# Proyecto "Generala"

Hola, este es mi proyecto para una materia de segundo año de la universidad. Consiste en representar el juego de mesa "La generala" con Windows Forms C# .NET

## ¿En qué consiste?

Bueno, básicamente es el juego de mesa "la generala" y unos aspectos técnicos agregados que tienen que ver con la materia para la cual lo presente y voy a detallar abajo.

### Estructura de 4 capas

El proyecto esta dividido en cuatro capas:
 * Interfaz de usuario - UI
 * Reglas de negocio - BLL
 * Acceso de datos - DAL
 * Entidades de negocio - BE

### Base de datos para persistir información

Utiliza SQL Server para persistir los datos tantos del juego como de los usuarios.

### XML

XLM para almacenar los movimientos de los jugadores durante la partida.

### Sistema de Login/Signin para usuarios

Un sistema de registros de usuario para crear cuentas y consultar sus respectivas estadísticas.