#### LISTA CIRCULAR
**DEFINICION**: Una lista circular es una lista lineal en la que el último nodo a punta al primero.

Las listas circulares evitan excepciones en la operaciones que se realicen sobre ellas. No existen casos especiales, cada nodo siempre tiene uno anterior y uno siguiente.
En algunas listas circulares se añade un nodo especial de cabecera, de ese modo se evita la única excepción posible, la de que la lista esté vacía.
```
Nodo.cs
public string Name { get; set; }
public Nodo Next { get; set; }
```
 - ```Name``` es un **dato** que almacena la informacion del nodo, de tipo ```string```.
 ```get; set;```permite leer y modificar su valor desde fuera de la clase.
 -  ```Next``` es el puntero al **siguiente nodo** de la lista.
    - Si el nodo es el **último de una lista lineal**, ```Next``` es ```null```.
    - Permite recorrer la lista hacia adelante.
    - Si el nodo pertenece a una **lista circular,**, ```Next``` apunta al primer nodo ```Root```.

```Next``` *es lo que permite **“enlazar”** nodos entre sí..*

**CONSTRUCTOR**
```
public Nodo(string name)
{
    this.Name = name;
    this.Next = null;
}
```
 - ```Nodo(string name)```: permite crear un nodo con un valor inicial:
```
Nodo n = new Nodo("RAUL");
```
  - ```this.Name = name;``` asigna el valor que se pasa al nodo.
  - ```this.Next = null;``` indica que, **al crear el nodo**, aún no está conectado a ningún otro nodo.


//
  **COMO FUNCIONA EN LA LISTA**
  1. **Lista simple lineal**
  Si insertas tres nodos ```"RAUL", "JOSE", "JUDAS":```

  ```Root → [RAUL] → [JOSE] → [JUDAS] → null```
   - Cada ```Next```apunta al siguiente nodo.
   - El último nodo (```JUDAS```) tiene ```Next = null```.
  2. **Lista simple circular**
   - Para que sea circular, al insertar se haces:

   ```ultimoNodo.Next = Root;```

   Entonces en memoria queda:
   ```
   Root → [RAUL] → [JOSE] → [JUDAS]
             ↑_______________↓ 
```
```
    JUDAS.Next = RAUL
```
 - Esto permite recorrer la lista infinitamente en círculo.

    - ```Name``` → almacena el dato del nodo.
    - ```Next``` → apunta al siguiente nodo.
    - Constructor inicializa el nodo **sin enlaces** ```(Next = null).```
    - En lista circular, luego de insertar se actualiza ```Next``` del último nodo para apuntar a ```Root```.