
using Microsoft.Data.SqlClient;

var cadenaConexion = "Data Source=DESKTOP-FAP3MIT;Database=adoNet;Integrated Security=True;TrustServerCertificate=True";

Console.Write("Digite el id a eliminar: ");
var nombre = Console.ReadLine(); //1. se declara la variable local.

try
{



}
catch (Exception ex)
{
    Console.WriteLine("Conexion ha fallado");
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Fin");