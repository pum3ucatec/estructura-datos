#### LISTAS DOBLES
**DEFINICION**: Una lista doblemente enlazada es una lista lineal en la que cada nodo tiene dos enlaces, uno al nodo siguiente, y otro al anterior.

Las listas doblemente enlazadas no necesitan un nodo especial para acceder a ellas, pueden recorrerse en ambos sentidos a partir de cualquier nodo, esto es porque a partir de cualquier nodo, siempre es posible alcanzar cualquier nodo de la lista, hasta que se llega a uno de los extremos.
```
Nodo.cs
public string Name { get; set; }
public Nodo Next { get; set; }
public Nodo Prev { get; set; }
```
 - ```Name``` es un **dato** que almacena la informacion del nodo, de tipo ```string```.
 ```get; set;```permiten leer y escribir el valor desde fuera de la clase.
 -  ```Next``` es el puntero al **siguiente nodo** de la lista.
    - Si este nodo es el último, ```Next``` será ```null```.
    - Permite recorrer la lista hacia adelante.
 -  ```Prev``` es el puntero al **nodo anterior** de la lista.
    - Si este nodo es el primero, ```Prev``` será ```null```.
    - Permite recorrer la lista hacia atrás.

*Estas dos propiedades* (```Next```y```Prev```)*son las que hacen que la lista sea ***doblemente enlazada***. Se sabe que nodo está antes y quién está después.*

**CONSTRUCTOR**
```
public Nodo(string name)
{
    this.Name = name;
    this.Next = null;
    this.Prev = null;
}
```
 - ```public Nodo(string name)```: Este constructor permite crear un nodo con un nombre específico cuando se instancia:
```
Nodo n = new Nodo("RAUL");
```
  - ```this.Name = name;``` asigna el valor que se pasa al ```name``` del nodo.
  - ```this.Next = null; this.Prev = null;``` Inicializa los punteros a ```null```. Esto es importante porque al crear un nodo **aún no está conectado a ningún otro nodo**, y los punteros deben empezar vacíos.

  **COMO FUNCIONA EN LA LISTA**
  1. **Primer nodo**
   - ```Root``` apunta a este nodo.
   - ```Next```y```Prev```siguen siendo ```null```.
  2. **Segundo nodo**
   -  ```Prev``` del nuevo nodo apunta al primer nodo.
   - ```Next``` del primer nodo apunta al nuevo nodo.

   De este modo cada nodo queda **conectado en ambas direcciones**, lo que permite:
   - Recorrer hacia adelante usando ```Next```.
   - Recorrer hacia adelante usando ```Prev```.