using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftJoin_LinQ
{
    internal class Colegio
    {
        //Atributos
        private int idAsignatura;
        private int idAlumno;
        private string curso;
        private string asignatura;

        //Propiedades
        public int IdAsignatura { get => idAsignatura; set => idAsignatura = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Asignatura { get => asignatura; set => asignatura = value; }
    }
}
