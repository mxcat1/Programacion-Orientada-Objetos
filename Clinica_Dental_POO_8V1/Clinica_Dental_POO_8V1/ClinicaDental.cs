using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Dental_POO_8V1
{
    class ClinicaDental
    {
        Cliente Clientecli;
        //Doctor[] DoctoresOdo;
        //AsistenteDental[] AsistenteOdo;
        Persona[,] DoctorAsistente;
        public ClinicaDental(int ndoctores)
        {
            Clientecli = new Cliente();
            DoctorAsistente = new Persona[ndoctores,2];
            DoctorAsistente[0, 0] = new Doctor();
            DoctorAsistente[0, 1] = new AsistenteDental();

        }

    }
    public class Persona
    {
        public string NomPersona { get; set; }
        public string ApePersona { get; set; }
        public int EdadPersona { get; set; }
    }
    public class Cliente :Persona
    {
        HistoriaClinica _HistoriaClinicaCliente;

        public HistoriaClinica HistoriaClinicaCliente
        {
            get { return _HistoriaClinicaCliente; }
            set { _HistoriaClinicaCliente = value; }
        }

        public Cliente()
        {
            HistoriaClinicaCliente = new HistoriaClinica();
        }

    }
    public class Doctor :Persona
    {
        Cita citaDoctorPaciente;

        public Cita CitaDoctorPaciente { get => citaDoctorPaciente; set => citaDoctorPaciente = value; }

        public void AtenderCita(Cita cita)
        {

        }
        public void GestionarCita(Cita cita)
        {

        }
    }
    public class AsistenteDental : Persona
    {
        public void RegistrarPaciente(Cliente cliente, Cliente cli, Doctor doc, DateTime fecha)
        {

        }
        public void RegistrarCita(Cita cita)
        {

        }
    }
    public class HistoriaClinica
    {
        Odontograma _odontogramaHC;
        Anamnesi _anamnesihc;
        public Odontograma OdontogramaHC { get => _odontogramaHC; set => _odontogramaHC = value; }
        public Anamnesi Anamnesihc { get => _anamnesihc; set => _anamnesihc = value; }
        public HistoriaClinica(int preguntasanamnesis=10)
        {
            OdontogramaHC = new Odontograma();
            Anamnesihc = new Anamnesi(preguntasanamnesis);
        }


    }
    public class Odontograma
    {
        PiezaDental[] _piezas;
        public PiezaDental[] Piezas { get => _piezas; set => _piezas = value; }
        public Odontograma()
        {
            _piezas = new PiezaDental[36];
        }

        
    }
    // la anamnesi es un documento donde se hace varias preguntas sobre el paciente incluye sus alergias
    // cirugias y mas
    public class Anamnesi
    {
        string[][,] _PreguntasRepuestas;
        public string[][,] PreguntasRepuestas1 { get => _PreguntasRepuestas; set => _PreguntasRepuestas = value; }
        public Anamnesi(int npreguntas)
        {
            PreguntasRepuestas1 = new string[npreguntas][,];
        }

        

        public void IngresarPregunta(int npregunta,string pregunta)
        {
            PreguntasRepuestas1[npregunta] = new string[,] { { pregunta,null} };
        }
        public void IngresarRespuesta(int npregunta, string pregunta, string respuesta)
        {
            PreguntasRepuestas1[npregunta][npregunta, npregunta+1] = respuesta;

        }
        
    }
    public class PiezaDental
    {
        TipoPieza tipoPiezadental;
        EstadoPieza estadoPieza;

        public TipoPieza TipoPiezadental { get => tipoPiezadental; set => tipoPiezadental = value; }
        public EstadoPieza EstadoPieza { get => estadoPieza; set => estadoPieza = value; }
    }
    public enum TipoPieza
    {
        DeLeche=1,Permanente=2
    }
    public enum EstadoPieza
    {
        conCuracion=1,Perfecto=2,ausente=3
    }
    public class Cita
    {
        Cliente ClienteCita;
        Doctor DoctorCita;
        DateTime FechaCita;

        public Cliente ClienteCita1 { get => ClienteCita; set => ClienteCita = value; }
        public Doctor DoctorCita1 { get => DoctorCita; set => DoctorCita = value; }
        public DateTime FechaCita1 { get => FechaCita; set => FechaCita = value; }
        public Cita(Cliente cli,Doctor doc,DateTime fecha)
        {
            ClienteCita = cli;
            DoctorCita = doc;
            FechaCita = fecha;
        }
    }
}
