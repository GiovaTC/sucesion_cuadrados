# programa en C# – sucesion de cuadrados

<img width="2559" height="1042" alt="image" src="https://github.com/user-attachments/assets/2f856c65-84fb-4b25-b414-ec0fd3800ceb" />

Este programa imprime una sucesión de cuadrados, que consiste en elevar al cuadrado los números naturales:

1², 2², 3², 4², 5², ... → 1, 4, 9, 16, 25, ...

yaml

---

## 🛠️ Instrucciones para Visual Studio 2022

1. Abre **Visual Studio 2022**.
2. Crea un **nuevo proyecto**:
   - **Tipo**: Aplicación de Consola (.NET Core o .NET 6/7)
   - **Lenguaje**: C#
3. Nombra tu proyecto, por ejemplo: `SucesionCuadrados`.

---

## 💻 Código en C# – Sucesión de Cuadrados

```csharp
using System;

namespace SucesionCuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos cuántos términos mostrar
            int cantidad = 10;

            Console.WriteLine("Sucesión de cuadrados:");

            for (int i = 1; i <= cantidad; i++)
            {
                int cuadrado = i * i;
                Console.Write(cuadrado + " ");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

🧾 ¿Qué hace este código?
Imprime los primeros 10 cuadrados:
1 4 9 16 25 36 49 64 81 100
Utiliza un bucle for desde 1 hasta 10, y en cada iteración calcula i * i.

