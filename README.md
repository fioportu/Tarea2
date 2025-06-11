# Tarea Programada 2 - Cálculo de Triangulo

**Nombre:** Fiorella Portuguez Rojas  
**Carné:** FI22024660
**Repositorio:** [https://github.com/fioportu/Tarea2.git]

----------------------------------------------------------------------------

## Estructura del Proyecto

Este proyecto fue desarrollado en Visual Studio 2022 como una aplicación MVC en ASP.NET Framework. El código fuente se encuentra organizado en las siguientes carpetas:

- **Controllers/** Controlador principal (`TrianguloController.cs`)
- **Models/** Modelo con la lógica del triángulo (`Triangulo.cs`)
- **Views/Triangulo/** Vista principal (`Index.cshtml`)
- **TP2-Triangulo.sln** Archivo de solución de Visual Studio

Se han excluido las carpetas `bin/` y `obj/` como se indica en las instrucciones.

---

## Fuentes y recursos utilizados

- https://learn.microsoft.com/es-es/dotnet/api/system.math?view=net-8.0
- http://prepa8.unam.mx/academia/colegios/matematicas/paginacolmate/applets/matematicas_V/Applets_Geogebra/heron.html
- https://www.varsitytutors.com/hotmath/hotmath_help/spanish/topics/law-of-cosines
- https://www.cuemath.com/measurement/semi-perimeter-of-triangle/

---

## Prompts y respuestas de IA utilizadas

### ChatGPT (OpenAI)

**Prompt:**  
> ¿Cómo puedo calcular los tres ángulos de un triángulo conociendo sus lados usando C#?

**Respuesta resumida:**  
Puedes usar la Ley de los Cosenos para calcular los ángulos en radianes y luego convertirlos a grados:
```csharp
double alfa = Math.Acos((b² + c² - a²) / (2bc)) * (180 / Math.PI);

**Prompt:**  
> ¿Para qué sirve la clase Math en C# y cómo se usa?

**Respuesta resumida:**  
La clase Math en C# proporciona métodos y constantes matemáticas como funciones trigonométricas, logaritmos, raíces cuadradas, redondeo, potencias, etc. Es útil para realizar cálculos precisos en aplicaciones matemáticas, científicas o gráficas. Algunos ejemplos comunes son:
double raiz = Math.Sqrt(25);           // Devuelve 5
double angulo = Math.Acos(0.5);        // Devuelve el arcocoseno en radianes
double grados = angulo * (180 / Math.PI); // Convierte radianes a grados
double potencia = Math.Pow(2, 3);      // Devuelve 8
double redondeo = Math.Round(3.14159, 2); // Devuelve 3.14

