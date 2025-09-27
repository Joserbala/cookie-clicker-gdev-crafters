## Refactor
- Añadir factory de tarro con autoclicker en los tests.
- Buscar las últimas aserciones y reemplazarlas con Is.False.

## Features
- Mostrar precio de autoclicker.
- Aumentar las galletas por segundo.


## WIP

Queremos hacer que el botón de comprar autoclicker no sea interactuable cuando no se puede comprar.
Tenemos un test de vista en rojo que es lo último que haremos, es la meta a la que queremos llegar.
Decidimos resolver el problema de la notificación del estado de si se puede comprar mediante eventos.
Los eventos se llamarán en el Jar cada vez que cambia el Amount (private set).
Necesitaremos tests de dominio y de presentador probablemente.
