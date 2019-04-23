using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosCursoNotas_POO_V7
{
    // Sin Arrays complejos
    //class Alumno
    //{
    //    public string Nombres { get; set; }
    //    public Curso[] CursoAlumno;
    //}
    //class Curso
    //{
    //    public int[] Notas=new int[4];
    //    public void VerificarNotas()
    //    {

    //    }
    //    public void IngresoNotas(int valornota=0)
    //    {

    //    }

    //}
    class Persona
    {
        public int IdPersona { get; set; }
    }
    class Profesor:Persona
    {
        public Alumno[] AlumnosProfesor;
        public Profesor(int cantiAlumno)
        {
            AlumnosProfesor = new Alumno[cantiAlumno];
        }
        public void RegistrarAlumno(int codAlumno,Alumno alumno)
        {
            AlumnosProfesor[codAlumno]= alumno;
        }
        public void RegistrarNotaAlumno(Alumno alumno,Nota nota,Curso curso)
        {
            alumno.CursoNotas.Add(curso, new Nota[4]);
            alumno.CursoNotas[curso][0] = nota;
        }
    }
    class Alumno:Persona
    {
        public Dictionary<Curso, Nota[]> CursoNotas;
        public Alumno()
        {
            CursoNotas = new Dictionary<Curso, Nota[]>();
        }
    }
    class Nota
    {
        public int ValorNota { get; set; }
    }
    class Curso
    {
        public string NomCurso { get; set; }
    }
}
