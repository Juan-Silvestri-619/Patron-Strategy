PATRÓN STRATEGY

**¿Qué es?**

Strategy es un patrón de diseño de comportamiento que permite definir diferentes algoritmos, encapsularlos en clases independientes e intercambiarlos sin modificar el código que los utiliza.

**¿Para qué se utiliza?**

Se utiliza cuando existen distintas formas de realizar una operación y queremos poder elegir entre ellas sin llenar una clase de condicionales (`if` o `switch`).

**Aplicación en el proyecto**

En este proyecto, el patrón Strategy permite calcular el costo de un envío según el medio de transporte seleccionado.

* `IShippingStrategy`: define el contrato que deben cumplir las estrategias.
* `GroundShippingStrategy`: calcula el costo del envío terrestre.
* `AirShippingStrategy`: calcula el costo del envío aéreo.
* `ShippingService`: utiliza la estrategia recibida para calcular el costo total, sin necesitar conocer los detalles de cada cálculo.
