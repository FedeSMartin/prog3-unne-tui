
using practica3sep;

Producto producto1 = new Producto();

producto1.nombre = "papas fritas";
producto1.cantidad = 10;
producto1.peso = 102;
producto1.precio = 1200.35;

Producto producto2 = new();

producto2.nombre = "caramelos";
producto2.cantidad = 200;
producto2.peso = 700;
producto2.precio = 3000;

Console.WriteLine("Tipo de producto: " + producto1.nombre + "; Precio: $" + producto1.precio +
                    "; Peso por paquete: " + producto1.peso + "grs.; Cantidad por envase: " + producto1.cantidad + " unidades.\n");

Console.WriteLine("Tipo de producto: " + producto2.nombre + "; Precio: $" + producto2.precio +
                    "; Peso por paquete: " + producto2.peso + "grs.; Cantidad por envase: " + producto2.cantidad + " unidades.\n");