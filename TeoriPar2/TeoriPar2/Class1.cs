/*
 Colecciones genéricas de .NET… 
-	tienen mejor desempeño que las colecciones clásicas.  X
-	Son estáticas
-	Son fuertemente tipadas.       X
-	No tienen seguridad de tipos.
Marque las respuestas correctas para DataAdapter.Update()
-	Se ejecuta como un proceso de lotes                              X
-	Actualiza el origen de datos solamente por ediciones de filas
-	Actualiza filas en el DataSet para que coincida con las del origen de datos
-	Actualiza el origen de datos ya sea por inserción, edición o borrado de filas.  X
-	Se ejecuta por cada fila individualmente
¿Cuáles de las siguientes colecciones existen en el espacio de nombre System.Collections.Generic?
-	SortedDictionary      X
-	SortedArray
-	Stack           X
-	Tree
Los métodos estáticos pueden ser declarados como virtual
-	Verdadero
-	Falso     X
La palabra clave virtual se usa para indicar que un método puede ser sobrescrito en clases derivadas, pero los métodos estáticos pertenecen a la clase en sí y no pueden ser sobrescritos por las clases derivadas


Especifique la línea de código para configurar el evento Click de miBoton
 private void miBoton_Click(object sender, System.EventArgs e)
  {
     //Agregar código aquí
  }
miBoton.Click += new EventHandler(miBoton_Click);

Palabra clave para prevenir la herencia de una clase
-	Static
-	Sealed     X
-	Private

Si deseo reutilizar la funcionalidad del constructor de “ClasePadre”. El siguiente fragmento de código es:
class ClaseDerivada: ClasePadre 
{
    public ClaseDerivada() { base(); } 
}
-	Correcto
-	Incorrecto   X
Debería ser: public ClaseDerivada() : base() { }

Dado el siguiente código, indique la salida correcta:
string s1= "20000 leguas de viaje submarino";
string s2;
s2 s1.Substring(6, 3);
Console.WriteLine(s2);

Seleccione una o más de una:
-	“le”
-	“egu”
-	“leg”     X
-	“00 leg”
si especifico 6 entonces cuenta desde 1 hasta 6 y el siguiente numero (7) es al que va a tomar

Control existente en la biblioteca de Clases .NET para Windows Forms para elegir una fecha y hora
Respuesta:  DateTimePicker

Considere el siguiente fragmento de código. Marque las respuestas correctas:
interface IMiInterfaz
{
    void metodo1();
    void metodo2();
}
class MiClaseIMiInterfaz
{
    private int i;
    void IMiInterfaz.metodo1()
    {
    // Código
    }
}

Seleccione una o más de una:
A.	El compilador arrojará un error porque la interfaz está parcialmente implementada  X
B.	IMiInterfaz debería heredar explícitamente de la clase Object (las interfaces no heredan de la clase Object)
C.	MiClase es abstracta
D.	MiClase puede tener miembros de instancia.  X

Especifique el tipo de variable fd (Sin namespace, ni object, ni var, ni dynamic):
       fd;
fd new FileInfo("C:\\file.txt");
fd new DirectoryInfo("C:\\folder");

respuesta: FileSystemInfo

Form.Show() permite mostrar un formulario de manera:
-	No modal  X
-	Modal

Elija la opción que más representa al uso adecuado de un DataSet tipado:

//Alternativa 1
DataRow motoRow motoRow "Marca"] inventarioTable.NewRow(); "Honda";
motoRow["Color"] = "Amarillo";
inventarioTable.Rows.Add(motoRow);

//Alternativa 2
MotosDataSet.InventarioRow motoRow =
InventarioTable.NewInventarioRow();
motoRow.Marca motoRow.Color = "Amarillo";
"Honda";
inventarioTable.AddInventarioRow(motoRow);

Seleccione una:
-	Alternativa 1
-	Ninguna de las dos
-	Alternativa 2      X

Las interfaces pueden tener declaraciones de propiedades
-	Verdadero  X
-	Falso

Especifique el tipo de la variable reloj (ni object, ni var, ni dynamic)
************ reloj new************();
reloj.Start();
Thread.Sleep(10000);
reloj.Stop();
TimeSpants reloj. Elapsed;

- respuesta	Stopwatch

Las interfaces pueden contener métodos con implementación
-	Verdadero
-	Falso     X

Considere el siguiente fragmento de código. Marque las respuestas correctas
public class Prueba
{
    public void Procedimiento<M>(Marg)
    {
        Console.Write(arg);
    }
}
class MyProgram
{
    static void Main(string[] args)
    {
        Prueba p = new Prueba();
        p.Procedimiento<string>("PROG "); 
        p.Procedimiento<int>(3);
    }
}
Seleccione una o más de una:
-	El programa arrojará un error en tiempo de ejecución
-	Se imprimirá “PROG 3”              x
-	El compilador arrojará un error
-	Una clase no genérica no puede contener métodos genéricos

¿Qué control de Windows Forms usaría si debe seleccionar una alternativa de tres excluyentes entre sí? (no incluya namespaces) 
-RESPUESTA	RadioButtons

Si dt perteneciese a una DataSet este debería ser:
protected void EnlazarDataTable() 
{
    SqlConnection con = new SqlConnection("connection string");
    con.Open();
    SqlCommand cmd = new SqlCommand("consulta", con);
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    DataTable dt = new DataTable();
    da.Fill(dt);
    grid.DataSource = dt;
    grid.DataBind();
}
Seleccione una:
-	Tipado
-	No tipado           X
-	Ninguna de las dos


Pregunta 2: Conceptos para conexión a Base de Datos. ADO.NET [Puntos 10]
*
¿Cuál de las siguientes opciones describe mejor el uso de DataReader en C#?
•	DataReader se utiliza para ejecutar consultas SQL y obtener un único valor de resultado.
•	DataReader se utiliza para leer datos de una base de datos de forma secuencial y optimizada en términos de memoria.   X
•	DataReader se utiliza para insertar, actualizar o eliminar registros en una base de datos.
•	DataReader se utiliza para conectarse a servicios web y consumir datos en formato JSON o XML.

 */