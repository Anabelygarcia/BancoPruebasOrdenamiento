# Tarea 5.2 – Banco de Pruebas de Algoritmos de Ordenamiento

Aplicación de **Windows Forms en C#** que implementa y compara el rendimiento de varios algoritmos de ordenamiento clásicos.

## Características

- **Algoritmos implementados:**
  - Bubble Sort (optimizado)
  - Insertion Sort
  - Selection Sort
  - Merge Sort
  - Quick Sort
  - Heap Sort

- **Generación de datos:**
  - Tamaños: 10.000, 50.000 y 100.000 elementos
  - Tres condiciones de prueba:
    1. Datos en orden **aleatorio**
    2. Datos **previamente ordenados**
    3. Datos en **orden inverso**

- **Medición de tiempos** con `Stopwatch` (precisión en milisegundos)
- Interfaz gráfica intuitiva con tabla de resultados
- Advertencias de rendimiento para algoritmos O(n²) con tamaños grandes

## Requisitos

- Visual Studio 2022 (o superior) / Visual Studio Code + .NET 8 SDK
- Windows (porque usa Windows Forms)

## Cómo abrir y ejecutar

1. Descomprime el archivo ZIP
2. Abre el archivo `BancoPruebasOrdenamiento.sln` con Visual Studio
3. Presiona **F5** o haz clic en "Iniciar"
4. Selecciona el tamaño y los algoritmos que deseas probar
5. Haz clic en **Ejecutar Pruebas**

> **Recomendación:** Empieza siempre con **10.000** elementos.  
> Bubble, Insertion y Selection Sort con 50.000 o 100.000 elementos pueden tardar varios minutos.

## Estructura del proyecto

```
BancoPruebasOrdenamiento/
├── BancoPruebasOrdenamiento.sln
├── README.md
└── BancoPruebasOrdenamiento/
    ├── BancoPruebasOrdenamiento.csproj
    ├── Program.cs
    └── Form1.cs
```

## Para el reporte de la práctica

1. Ejecuta las pruebas y captura la tabla de resultados.
2. Copia los datos a Excel / Google Sheets.
3. Genera gráficas de tiempo de CPU (barras o líneas) comparando:
   - Algoritmos vs Tiempo
   - Condición de los datos (Aleatorio / Ordenado / Inverso)
4. Incluye análisis de complejidad teórica vs resultados experimentales.

## Autor

Proyecto desarrollado para la Tarea 5.2 – Práctica de programación y banco de pruebas de algoritmos de ordenamiento.
