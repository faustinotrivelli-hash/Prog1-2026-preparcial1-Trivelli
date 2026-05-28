# Corrección — Trivelli

> **Aviso importante:** Las soluciones se evalúan exclusivamente con los conceptos vistos en clase. Si se utilizan conceptos que no fueron parte del programa (frameworks externos, técnicas avanzadas no vistas, etc.), esas partes no serán tenidas en cuenta en la corrección.


## Nota general
**No aprobado** — Puntaje: 10/100

| Área | Obtenido | Máximo |
|---|---|---|
| Jerarquía de herencia | 5 | 25 |
| Sobrecarga de métodos | 0 | 25 |
| Lógica de costos | 2 | 20 |
| Validaciones y excepciones | 0 | 15 |
| Tests unitarios | 0 | 10 |
| Estructura de proyecto | 3 | 5 |
| **Total** | **10** | **100** |

## Correcciones de evaluación

### Jerarquía de herencia (5/25)

- `Vehiculos` no es `abstract`. Falta la keyword `abstract` en la declaración de la clase y no tiene ningún método `abstract`. (−10 pts)
- `Autos`, `Motos` y `Bicicletas` heredan de `Vehiculos`, pero ninguna usa `override` porque no hay método abstracto que sobreescribir. Se otorga 1 pt parcial por cada una (total 3 pts) dado que la herencia sintáctica existe pero el código no compila en varios casos.
- `Bicicletas.cs` línea 7: el constructor pasa `Marca` (propiedad estática) en lugar de `marca` (parámetro local) → error de compilación.
- `Motos.cs` línea 1: namespace incorrecto (`Apliacion` en lugar de `Aplicacion`) → no pertenece al mismo namespace que el resto del proyecto.
- `TipoMoto` es `int` en lugar de un enum `TipoMoto`. (−parcial)
- `Bicicleta` nombra la propiedad `CantCambios` en lugar de `CantidadMarchas`. (−parcial)
- `PrecioBaseDiario` es `double` en lugar de `decimal`. (−parcial)
- `Reservas.NumId` sólo tiene setter (`{set;}`), le falta el getter. No hay Id auto-incremental estático. (−parcial)
- No existe la clase `AlquilerService` con listas privadas de `Vehiculo` y `Reserva`. (−parcial)

### Sobrecarga de métodos (0/25)

- No se implementaron las sobrecargas de `CalcularCostoAlquiler`. El método en `Autos` se llama `CotizacionDeAlquileresAutos` y recibe parámetros diferentes a la firma requerida. No usa `override`.
- No existe la clase `AlquilerService`, por lo tanto no hay ninguna sobrecarga de `BuscarVehiculo`.

### Lógica de costos (2/20)

- **Auto (≤7 días, sin seguro):** La expresión `precioFinal = precioBaseDiario * cantDias` es la correcta para ese caso, pero la función entera no compila correctamente dado que el caso con seguro para ≤7 días es `precioBaseDiario * 0.10` (falta multiplicar por `cantDias` y por el factor de seguro). (0 pts)
- **Auto (>7 días):** No multiplica por `cantDias`. La fórmula `precioBaseDiario - (precioBaseDiario*0.15)` calcula el precio de un solo día con descuento. (0 pts)
- **Auto con seguro:** Aplica el 10% sólo al precio diario base, no sobre el total calculado. (0 pts)
- **Motos:** El código tiene un typo `precioBaseDirio` (error de compilación) en las líneas 18, 21 y 24. Además, la fórmula suma en lugar de multiplicar (`precioBaseDiario + precioBaseDiario * 0.60` en lugar de `precioBaseDiario * dias * 0.60`), y falta el parámetro `cantDias`. (0 pts)
- **Bicicletas:** `cantDias * 200` es la fórmula correcta. Se otorga el puntaje a pesar del tipo de retorno incorrecto (`int` en lugar de `decimal`) y el nombre del método incorrecto. (2 pts)

### Validaciones y excepciones (0/15)

- No se implementó ninguna validación. No hay `ArgumentException` para año de fabricación inválido, patente nula/vacía, ni días ≤ 0. No hay `InvalidOperationException` para búsquedas sin resultados.

### Tests unitarios (0/10)

- No existe ningún proyecto de tests unitarios en el repositorio.

### Estructura de proyecto (3/5)

- Existe el archivo `Solucion.sln`. (2 pts)
- Existe un proyecto de clases (`Clases/Clases.csproj`) que actúa como librería (sin `<OutputType>` explícito, lo que equivale a classlib en .NET SDK). Sin embargo, el nombre del proyecto es `Clases` y no `MovilYaService` como se requería. Se otorga 1 pt parcial. (1 pt)
- No existe ningún proyecto de tests `MovilYaServiceTests` con NUnit. (0 pts)

## Observaciones importantes

- El código presenta múltiples errores de compilación que impiden que el proyecto se ejecute: typo `precioBaseDirio` en `Motos.cs`, uso de `Marca` (propiedad) como argumento en `Bicicletas.cs`, namespace incorrecto en `Motos.cs`, y propiedad `NumId` sin getter en `Reservas.cs`.
- El diseño no respeta la jerarquía polimórfica requerida. El patrón central del ejercicio (clase abstracta con método abstracto sobreescrito en subclases) no fue implementado.
- Los métodos de cálculo tienen nombres propios inventados (`CotizacionDeAlquileresAutos`, `CotizacionDeAlquileresMotos`, etc.) en lugar de las firmas especificadas, y no son sobrecargas del método `CalcularCostoAlquiler`.
- La lógica de cálculo de costos para Autos y Motos es incorrecta en casi todos los casos, con errores matemáticos que producirían resultados erróneos incluso si el código compilara.
- Se recomienda releer el enunciado con atención y priorizar: (1) la declaración `abstract` de `Vehiculos` y del método `CalcularCostoAlquiler`, (2) el uso correcto de `override` en cada subclase, (3) las firmas exactas de los métodos requeridos, y (4) implementar las validaciones antes de agregar lógica de negocio compleja.
