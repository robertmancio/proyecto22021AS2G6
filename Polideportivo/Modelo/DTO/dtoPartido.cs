﻿namespace Modelo.DTO
{
    public class dtoPartido
    {
        public int pkId { get; set; }
        public string equipo1 { get; set; }
        public string equipo2 { get; set; }
        public int anotacionesEquipo1 { get; set; }
        public int anotacionesEquipo2 { get; set; }
        public string campo { get; set; }
        public string fecha { get; set; }
        public int fkIdCampeonato { get; set; }
        public int fkIdEmpleado { get; set; }
        public int fkIdEstadoPartido { get; set; }
        public int fkIdFase { get; set; }

        public dtoPartido()
        {
        }

        public dtoPartido(int Id, string Equipo1, string Equipo2, string Campo, string Fecha, string Estado, int IdCampeonato, int IdEmpleado, int IdResultado, int IdEstado, int anotacion1, int anotacion2, int fase)
        {
            pkId = Id;
            equipo1 = Equipo1;
            equipo2 = Equipo2;
            campo = Campo;
            fecha = Fecha;
            fkIdFase = fase;
            fkIdCampeonato = IdCampeonato;
            fkIdEmpleado = IdEmpleado;
            fkIdEstadoPartido = IdEstado;
            anotacionesEquipo1 = anotacion1;
            anotacionesEquipo2 = anotacion2;

            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}