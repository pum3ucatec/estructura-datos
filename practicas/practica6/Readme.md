# COLA DINAMICA CON NODOS

#### SE IMPLEMENTA UNA COLA CON LISTA ENLAZADA SIMPLE
- FIFO = *First In, First Out*: el primo en entrar es el primero en salir.
- Estructura: cada elmento es un **Nodo** que guarda un valor y una referencia al siguiente.
- La cola tiene dos punteros:
    - **frente**: desde aquí se desencola (sale).
    - **fondo**: desde aqui se encola (entra).
- Operaciones clave (```Encolar```
```Desencolar``` ``` Peek```) son **0(1)** (tiempo constante)

#### ESTRUCUTRA

``` ColaDinamica/
├─ Program.cs     // Menú y flujo del programa (interfaz por consola)
├─ Cola.cs        // Lógica de la cola (genérica, con nodos)
└─ Nodo.cs        // Definición del nodo genérico
``` 

**a) Nodo < T >**
   - Es la unidad minima de la lista enlazada
- ```Valor```: el dato que guarda (de tipo genérico T).
- ```Siguiente```: referencia al próximo nodo (o ```null``` si es el último).
- **Utilizamos T**: para que la cola funione con **cualquier tipo** (```String```,```int```)

**b) Cola  < T >**

// primer nodo (sale desde aquí)
```private Nodo<T>? frente;```

// último nodo (entra aquí)
```private Nodo<T>? fondo;```

```public int Conteo { get; private set; }``` 

```public bool EstaVacia => Conteo == 0;```

#### **REGLAS QUE SIEMPRE SE CUMPLEN**
- Si ```EstaVacia```: ```frente == null```;```fondo == null``` y ```Conteo == 0```
- Si al menos hay un elemento: ```frente != null``` y ```fondo != null```

### **Encolar**
// cola vacía
```   
if (fondo == null)
    {
        frente = nuevo;
        fondo  = nuevo;
    } 
```
// cola con elementos
``` 
else
    {
        fondo.Siguiente = nuevo;  // enlazo al final
        fondo = nuevo;            // muevo el fondo
    }
```
Asi aseguramos:
- Si estaba vacía, **frente** y **fondo** apuntan al mismo nodo.
- Si no, agregamos al final y actualizamos **fondo**

### **Desencolar**
// avanzo el frente
```
frente = frente.Siguiente;
```
// si quitamos el últimom, la cola queda coherente
```
if (frente == null)
    fondo = null;
```
 - **Nota**

    - Validamos vacío: ```InvalidOperationException```.
    - Si quitamos el ultimo elemento, tambien colocamos ```fondo = null```

### **Frente (Peek)**
//Se puede observar el primer elemento sin quitarlo
```
public T Peek()
{
    if (frente == null)
        throw new InvalidOperationException("La cola está vacía");
    return frente.Valor;
}
```
### **Mostrar()**
Recorre la lista desde ```frente``` hasta ```null``` y muestra todos los nodos:
```
public void Mostrar()
{
    if (EstaVacia) { Console.WriteLine("La cola está vacía."); return; }

    Console.Write("Cola: ");
    var actual = frente;
    while (actual != null)
    {
        Console.Write(actual.Valor + " ");
        actual = actual.Siguiente;
    }
    Console.WriteLine();
}
```
**c)** ```Program.cs``` **Menú y control de flujo**
 - **do/while** se repite hasta elegir ```0```
 - **switch** para organizar las opciones (Mostrar, Encolar, Desencolar, Peek, Vacío)
 - ```int.TryParse``` para validar la opcion ingresada
```
if (!int.TryParse(Console.ReadLine(), out opcion))
{
    Console.WriteLine("Opción inválida, intente de nuevo.");
    continue;
}
```
 - **Encolar**
```
Console.Write("Ingrese un valor: ");
string valor = Console.ReadLine()!;
cola.Encolar(valor);
```
 - **Desencolar**
```
try { Console.WriteLine($"Se eliminó: {cola.Desencolar()}"); }
catch (InvalidOperationException e) { Console.WriteLine(e.Message); }
```
 - **Peek**
```
try { Console.WriteLine($"Frente: {cola.Peek()}"); }
catch (InvalidOperationException e) { Console.WriteLine(e.Message); }
```
___
#### Ejecutamos: ```dotnet run``` 
- Opción 2 (Encolar) 
    - Ingresamos un valor(puede ser texto o numérico): **RAUL**
```
frente ─► [RAUL] ─► null
fondo       ▲
Conteo = 1
```
- Encolamos 2do dato: **GASTON**

```
frente ─► [RAUL] ─► [GASTON] ─► null
fondo                  ▲
Conteo = 2 
```
- Encolamos 3er dato: **GABRIEL**
```
frente ─► [RAUL] ─► [GASTON] ─► [GABRIEL] ─► null
fondo                               ▲
Conteo = 3
```
- Opción 4 (Peek) frente actual:
```
Muestra RAUL sin quitar de la cola
```
- Opción 3 (Desencolar) 1ra vez: sale **RAUL** de la cola
```
frente ─► [GASTON] ─► [GABRIEL] ─► null
fondo                     ▲
Conteo = 2
```
- Opción 3 (Desencolar) 2da vez: sale **GASTON** de la cola
```
frente ─► [GABRIEL] ─► null
fondo         ▲
Conteo = 1
```
- Opción 3 (Desencolar) 3ra vez: sale **GABRIEL** de la cola
```
frente ─► null
fondo  ─► null
Conteo = 0  (cola vacía)
```