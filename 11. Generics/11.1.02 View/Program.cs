using _11._1._02_Library;

Recibo recibo1 = new();
Factura factura1 = new(123);
Factura factura2 = new(456);

Contabilidad<Factura,Recibo> contabilidad = new();

contabilidad += recibo1;
contabilidad += factura1;
contabilidad += factura2;

foreach (Factura item in contabilidad.egresos)
{
    Console.WriteLine(item.Numero);
}

foreach (Recibo item in contabilidad.ingresos)
{
    Console.WriteLine(item.Numero);
}   