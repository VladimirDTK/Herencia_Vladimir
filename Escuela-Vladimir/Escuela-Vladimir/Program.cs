using System;
using System.Collections.Generic;

class Escuela
{
    public List<Maestro> maestros = new List<Maestro>();
    public List<Alumno> alumnos = new List<Alumno>();
    public List<Administrativo> administrativos = new List<Administrativo>();
}
class Program
{
    static void Main(string[] args)
    {
        Escuela escuela = new Escuela();
        //
        escuela.maestros.Add(new Maestro("0000000001", "Roberto", "Roto", "Plas", new DateTime(1970, 2, 10), "ROBERT571234HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000002", "Maria", "Martinez", "Gonzalez", new DateTime(1985, 6, 15), "MARTINEZ850615HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000003", "Juan", "Jimenez", "Lopez", new DateTime(1978, 9, 25), "JIMENEZ780925HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000004", "Luisa", "Lopez", "Garcia", new DateTime(1990, 4, 3), "LOPEZ900403HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000005", "Pedro", "Perez", "Ramirez", new DateTime(1982, 1, 7), "PEREZ820107HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000006", "Ana", "Alvarez", "Flores", new DateTime(1988, 12, 12), "ALVAREZ881212HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000007", "Jorge", "Juarez", "Castro", new DateTime(1975, 7, 30), "JUAREZ750730HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000008", "Mariana", "Moreno", "Vega", new DateTime(1995, 11, 18), "MORENO951118HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000009", "Ricardo", "Ramirez", "Soto", new DateTime(1983, 8, 22), "RAMIREZ830822HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000010", "Laura", "Lara", "Gomez", new DateTime(1976, 5, 19), "LARA760519HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000011", "Carlos", "Castro", "Nava", new DateTime(1992, 2, 28), "CASTRO920228HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000012", "Erika", "Espinoza", "Rios", new DateTime(1986, 3, 8), "ESPINOZA860308HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000013", "Javier", "Jimenez", "Hernandez", new DateTime(1980, 7, 17), "JIMENEZ800717HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000014", "Martha", "Martinez", "Perez", new DateTime(1998, 10, 1), "MARTINEZ981001HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000015", "Daniel", "Diaz", "Vargas", new DateTime(1991, 9, 5), "DIAZ910905HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000016", "Karla", "Kramer", "Herrera", new DateTime(1973, 4, 20), "KRAMER730420HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000017", "Oscar", "Ortiz", "Mendoza", new DateTime(1987, 12, 31), "ORTIZ871231HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000018", "Sofia", "Sanchez", "Luna", new DateTime(1979, 8, 9), "SANCHEZ790809HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000019", "Hector", "Hernandez", "Guzman", new DateTime(1993, 6, 24), "HERNANDEZ930624HTDSMD"));
        escuela.maestros.Add(new Maestro("0000000020", "Fernanda", "Flores", "Duran", new DateTime(1984, 2, 14), "FLORES840214HTDSMD"));

        //
        escuela.alumnos.Add(new Alumno("0000000001", "Juan", "Pérez", "García", new DateTime(2005, 3, 12), "JUAPGAR050312HDFLR"));
        escuela.alumnos.Add(new Alumno("0000000002", "María", "González", "Hernández", new DateTime(2006, 5, 25), "MARGON060525MDFLNS"));
        escuela.alumnos.Add(new Alumno("0000000003", "Alberto", "Alonso", "Pérez", new DateTime(1975, 10, 3), "ALONSO751003HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000004", "Gabriela", "Garcia", "Santos", new DateTime(1982, 4, 27), "GARCIA820427HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000005", "Luis", "Lopez", "Jimenez", new DateTime(1977, 9, 18), "LOPEZ770918HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000006", "Mariana", "Mendez", "Rodriguez", new DateTime(1988, 5, 6), "MENDEZ880506HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000007", "Ricardo", "Ramos", "Ortiz", new DateTime(1990, 1, 15), "RAMOS900115HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000008", "Miguel", "Moreno", "Gonzalez", new DateTime(1980, 7, 28), "MORENO800728HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000009", "Ana", "Aguilar", "Perez", new DateTime(1974, 11, 22), "AGUILAR741122HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000010", "Pedro", "Perez", "Gomez", new DateTime(1986, 3, 11), "PEREZ860311HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000011", "Laura", "Lara", "Vega", new DateTime(1995, 9, 2), "LARA950902HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000012", "Carlos", "Castro", "Hernandez", new DateTime(1985, 12, 20), "CASTRO851220HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000013", "Isabel", "Ibarra", "Montoya", new DateTime(1976, 8, 5), "IBARRA760805HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000014", "Daniel", "Diaz", "Gutierrez", new DateTime(1991, 2, 28), "DIAZ910228HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000015", "Martha", "Mora", "Cabrera", new DateTime(1983, 7, 16), "MORA830716HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000016", "Javier", "Juarez", "Gallardo", new DateTime(1981, 4, 23), "JUAREZ810423HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000017", "Natalia", "Nuñez", "Villa", new DateTime(1992, 11, 9), "NUÑEZ921109HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000018", "Hugo", "Hernandez", "Mendez", new DateTime(1989, 6, 7), "HERNANDEZ890607HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000019", "Olivia", "Ortega", "Soto", new DateTime(1973, 3, 2), "ORTEGA730302HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000020", "Roberto", "Rojas", "Lopez", new DateTime(1987, 12, 19), "ROJAS871219HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000021", "Sara", "Sanchez", "Torres", new DateTime(1984, 9, 12), "SANCHEZ840912HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000022", "Luisa", "Lopez", "Garcia", new DateTime(1978, 5, 27), "LOPEZ780527HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000023", "Pedro", "Perez", "Castillo", new DateTime(1990, 1, 15), "PEREZ900115HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000024", "Lucia", "Lara", "Rojas", new DateTime(1982, 10, 20), "LARA821020HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000025", "Alberto", "Alvarez", "Molina", new DateTime(1979, 9, 2), "ALVAREZ790902HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000026", "Mariana", "Mendoza", "Ramos", new DateTime(1993, 12, 8), "MENDOZA931208HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000027", "Pablo", "Padilla", "Montes", new DateTime(1995, 6, 19), "PADILLA950619HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000028", "Ana", "Aguilar", "Galvan", new DateTime(1986, 3, 25), "AGUILAR860325HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000029", "Francisco", "Fernandez", "Ochoa", new DateTime(1980, 7, 12), "FERNANDEZ800712HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000030", "Carolina", "Cortes", "Santos", new DateTime(1992, 2, 14), "CORTES920214HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000031", "Mario", "Mora", "Ortega", new DateTime(1985, 11, 30), "MORA851130HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000032", "Elena", "Espinoza", "Villa", new DateTime(1991, 8, 22), "ESPINOZA910822HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000033", "Gabriel", "Gonzalez", "Hernandez", new DateTime(1977, 4, 6), "GONZALEZ770406HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000034", "Isabel", "Iglesias", "Solis", new DateTime(1983, 9, 17), "IGLESIAS830917HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000035", "Oscar", "Ortiz", "Pineda", new DateTime(1974, 7, 4), "ORTIZ740704HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000036", "Natalia", "Navarro", "Dominguez", new DateTime(1998, 2, 1), "NAVARRO980201HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000038", "Rafael", "Rocha", "Barrera", new DateTime(1988, 6, 11), "ROCHA880611HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000039", "Sara", "Soto", "Ponce", new DateTime(1981, 3, 18), "SOTO810318HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000040", "Tomas", "Torres", "Velasco", new DateTime(1990, 12, 27), "TORRES901227HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000041", "Veronica", "Valle", "Lopez", new DateTime(1986, 5, 14), "VALLE860514HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000042", "Ximena", "Xochitl", "Zamora", new DateTime(1979, 12, 3), "XOCHITL791203HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000043", "Yahir", "Yanez", "Carranza", new DateTime(1995, 1, 31), "YANEZ950131HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000044", "Zoe", "Zambrano", "Guzman", new DateTime(1984, 7, 27), "ZAMBRANO840727HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000045", "Ana", "Aguilera", "Gomez", new DateTime(1982, 6, 2), "AGUILERA820602HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000046", "Benjamin", "Bautista", "Jimenez", new DateTime(1976, 9, 12), "BAUTISTA760912HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000047", "Carla", "Cortes", "Lara", new DateTime(1993, 4, 19), "CORTES930419HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000048", "David", "Dominguez", "Mendoza", new DateTime(1989, 2, 23), "DOMINGUEZ890223HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000049", "Esmeralda", "Escobar", "Nuñez", new DateTime(1987, 10, 10), "ESCOBAR871010HTDSMD"));
        escuela.alumnos.Add(new Alumno("0000000050", "Federico", "Fernandez", "Ochoa", new DateTime(1978, 8, 8), "FERNANDEZ780808HTDSMD"));
        //
        escuela.administrativos.Add(new Administrativo("0000000001", "Carlos", "Sánchez", "Méndez", new DateTime(1980, 10, 8), "CARSAN801008HDFNDL"));
        escuela.administrativos.Add(new Administrativo("0000000002", "Ana", "Ramírez", "Jiménez", new DateTime(1975, 6, 16), "ANARAM750616MDFNMN"));
        escuela.administrativos.Add(new Administrativo("0000000003", "Gabriela", "Garcia", "Perez", new DateTime(1991, 11, 22), "GARCIA911122HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000004", "Hector", "Hernandez", "Quintero", new DateTime(1980, 3, 7), "HERNANDEZ800307HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000005", "Ivonne", "Ibarra", "Ramirez", new DateTime(1974, 12, 16), "IBARRA741216HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000006", "Julio", "Jimenez", "Santana", new DateTime(1997, 6, 9), "JIMENEZ970609HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000007", "Karla", "Kempis", "Tellez", new DateTime(1983, 9, 27), "KEMPIS830927HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000008", "Lorena", "Lopez", "Uribe", new DateTime(1990, 5, 4), "LOPEZ900504HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000009", "Mario", "Martinez", "Valenzuela", new DateTime(1973, 1, 29), "MARTINEZ730129HTDSMD"));
        escuela.administrativos.Add(new Administrativo("0000000010", "Natalia", "Nava", "Zarate", new DateTime(1985, 7, 13), "NAVA850713HTDSMD"));
        //

        Console.WriteLine("Maestros:");
        foreach (Maestro maestro in escuela.maestros)
        {
            maestro.MostrarDatos();
        }

        Console.WriteLine("Alumnos:");
        foreach (Alumno alumno in escuela.alumnos)
        {
            alumno.MostrarDatos();
        }

        Console.WriteLine("Administrativos:");
        foreach (Administrativo administrativo in escuela.administrativos)
        {
            administrativo.MostrarDatos();
        }
    }
}
