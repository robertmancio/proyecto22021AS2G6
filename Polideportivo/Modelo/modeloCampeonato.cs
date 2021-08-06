﻿namespace Modelo
{
    public class modeloCampeonato
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }
        public int fkIdDeporte { get; set; }
        public int fkIdTipoCampeonato { get; set; }

        public modeloCampeonato()
        {
        }

        public modeloCampeonato(int Id, string Nombre, string FechaInicio, string FechaFinal, int FkIdDeporte
            , int FkIdTipoCampeonato)
        {
            pkId = Id;
            nombre = Nombre;
            fechaInicio = FechaInicio;
            fechaFinal = FechaFinal;
            fkIdDeporte = FkIdDeporte;
            fkIdTipoCampeonato = FkIdTipoCampeonato;
        }
    }
}