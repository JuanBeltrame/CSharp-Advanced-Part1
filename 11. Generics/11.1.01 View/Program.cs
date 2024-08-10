using _11._1._01_Library;

Torneo<EquipoBasquet> torneoBasquet = new("tBasquet");    

EquipoBasquet equipo1 = new("equipo1", DateTime.Now);
EquipoBasquet equipo2 = new("equipo2", DateTime.Now);

_ = torneoBasquet + equipo1;
_ = torneoBasquet + equipo2;

Console.WriteLine(torneoBasquet.Mostrar());