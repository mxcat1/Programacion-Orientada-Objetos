using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursoNotas_POO_V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor ProfeA1 = new Profesor(10);
            Alumno alumnoA1 = new Alumno() { IdPersona=0};
            //Por el momento el curso se registra afuera del profesor
            Curso cursoA1 = new Curso() { NomCurso="Matematica"};
            Nota notaA1 = new Nota() { ValorNota=13};
            ProfeA1.RegistrarAlumno(alumnoA1.IdPersona,alumnoA1);
            ProfeA1.RegistrarNotaAlumno(alumnoA1, notaA1, cursoA1);



        }
    }
}
