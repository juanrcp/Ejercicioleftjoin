using System.Collections.Generic;
using System;
using leftJoin_LinQ;

//Lista de personas
List<Person> personList = new List<Person>();

//Lenamos la lista
personList.Add(
    new Person
    {
        //Id = Guid.NewGuid(),
        Id = 1,
        Name = "Genesis",
        Age = 24
    });

personList.Add(
    new Person
    {
        //Id = Guid.NewGuid(),
        Id = 2,
        Name = "Luis",
        Age = 23
    });

//Lista del colegio
List<Colegio> colegioList = new List<Colegio>();

//Lenamos la lista
colegioList.Add(
    new Colegio
    {
        IdAsignatura = 1,
        IdAlumno = 2,
        Curso = "1º",
        Asignatura = "Matematicas"
    });

colegioList.Add(
    new Colegio
    {
        IdAsignatura = 2,
        IdAlumno = 3,
        Curso = "2º",
        Asignatura = "Lengua"
    });

//Hacemos la query
var alumnos = from p in personList 
              
              join co in colegioList
               on p.Id equals co.IdAlumno into PersonasColegio
             from pco in PersonasColegio.DefaultIfEmpty()
             select new Person
             {
                 Id = p.Id,
             };

//Mostramos el resultado
foreach (Person alumno in alumnos)
{
    Console.WriteLine("El alumno es: " + alumno.Id);
}