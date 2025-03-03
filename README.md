# Cafetería Mi U

Proyecto Académico aplicado con reglas de negocio mediante C#.

# Contexto
La cafetería de la Universidad "Cafeteria Mi U" está necesitando que usted le ayude con el desarrollo de una aplicación para determinar la cantidad normal, adicional y total de jamón que debe comprar para un día determinado de la semana y el valor total a pagar al proveedor. Las compras de jamón se hacen de lunes a sábado.

El valor de la libra de jamón, las cantidades por día de la semana y las adiciones (Quincena y Festiva) se
almacenan en un archivo plano (pedidos.txt). Toda la información por día está en una sola línea de código
separado por el carácter especial: Barra vertical (I). (Alt+124), expresados en cada línea de la siguiente forma:

```bash
(Dia|Vr.Unit_Ibr|Cant.LbrsNorm|Cant.LbrsQuinc|Cant.LbrsFest)
```
Notas:

1. Tener en cuenta que, si la compra se realiza un día que corresponde a quincena o es festivo se debe adicionar una cantidad adicional de libras a la cantidad. (Recomiendo utilizar CheckBox para dichos controles).
2. Si el día del pedido corresponde a quincena y es festivo, se deben sumar las adiciones en una sola.
3. Los sábados se realiza la compra teniendo en cuenta lo que se gastará el domingo, ya que el proveedor no
despacha los domingos.
4. Las cantidades y las adiciones varían en cualquier momento, según determine el administrador del café


## Detalles

Versión: .NET Framework 4.7.2