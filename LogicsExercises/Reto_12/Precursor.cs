using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LogicsExercises.Reto_12
{
    public class Precursor
    {
        public string Name { get; set; }
        public double CantidadHoras { get; set; }
        public Char Tipo { get; set; } //R = Regular / A = Auxiliar 

        public Precursor() { } // ← necesario para XML


        [JsonConstructor]
        public Precursor(string name, double cantidadHoras, char tipo)//"Added a parameterless constructor and aligned constructor parameter names to match property names so System.Text.Json can deserialize Precursor properly."
        {
            Name = name;
            CantidadHoras = cantidadHoras;
            Tipo = tipo;
        }


    }
}
