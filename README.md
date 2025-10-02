# ArbolBinario - Daniel Zambrano - dzambrano863@gmail.com

Árbol Binario en C# - Daniel Zambrano


- Este proyecto implementa un Árbol Binario de Búsqueda para solucionar la problematica de el ancestro común entre dos nodos, para la solución se implemento la estructura BST que es una estructura de datos jerárquica compuesta por nodos, Cada nodo tiene como máximo dos hijos:

    hijo izquierdo

    hijo derecho

Para cualquier nodo con valor X:

    Todos los valores en su subárbol izquierdo son menores que X.

    Todos los valores en su subárbol derecho son mayores que X.



Funcionalidades Implementadas

* Creación de un árbol binario de búsqueda (BST) a partir de un conjunto de valores.

* Inserción de nodos en el árbol, ignorando duplicados.

* Búsqueda de un nodo dentro del árbol.

* Recorridos en orden (InOrder) para verificar la estructura del árbol.

* Cálculo del Ancestro Común Más Cercano (LCA) entre dos nodos:

* Si ambos nodos están a la izquierda → busca en el subárbol izquierdo.

* Si ambos están a la derecha → busca en el subárbol derecho.

* Si se separan → el nodo actual es el ancestro común.
