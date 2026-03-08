using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAcademicaV2.Modelos.Data
{
    internal class DatosDummie
    {
        public static List<ClaseAsignadaDummie> ObtenerClases()
        {
            return new List<ClaseAsignadaDummie>
            {
                new ClaseAsignadaDummie { CargaID = 1, Grado = "Prekínder", Seccion = "A", Asignatura = "Lenguaje" },
                new ClaseAsignadaDummie { CargaID = 2, Grado = "Prekínder", Seccion = "A", Asignatura = "Cognoscitiva" }
            };
        }

        public static List<EstudianteItemDummie> ObtenerEstudiantes()
        {
            return new List<EstudianteItemDummie>
            {
                new EstudianteItemDummie { EstudianteID = 1, Nombre = "Ana López", CargaID = 1 },
                new EstudianteItemDummie { EstudianteID = 2, Nombre = "Juan Pérez", CargaID = 1 },
                new EstudianteItemDummie { EstudianteID = 3, Nombre = "María Díaz", CargaID = 2 }
            };
        }
    }
}
