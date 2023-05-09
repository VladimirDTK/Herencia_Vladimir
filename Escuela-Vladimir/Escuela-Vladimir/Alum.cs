class Alumno
{
    public string matricula;
    public string nombre;
    public string apellidoPaterno;
    public string apellidoMaterno;
    public DateTime fechaNacimiento;
    public string curp;

    public Alumno(string matricula, string nombre, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string curp)
    {
        this.matricula = matricula;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.fechaNacimiento = fechaNacimiento;
        this.curp = curp;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Matrícula: {0}", matricula);
        Console.WriteLine("Nombre: {0} {1}", nombre, apellidoPaterno);
        Console.WriteLine("Fecha de nacimiento: {0}", fechaNacimiento);
        Console.WriteLine("CURP: {0}", curp);
        Console.WriteLine();
    }
}