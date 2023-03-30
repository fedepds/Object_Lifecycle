//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            var cuantostrain = ($"Hay {Train.getCount()} trenes");
            Console.WriteLine($"En la expresión t1==t2: {t1==t2}. Esto es porque los objetos referenciados por ambas variables son diferentes, son objetos distintos, cada uno ocupando un espacio diferente en el heap de la memoria.");
            Console.WriteLine($"En la expresión t2==t3: {t2==t3}. Esto es porque los objetos referenciados por ambas variables son diferentes.");
        }
    }
}