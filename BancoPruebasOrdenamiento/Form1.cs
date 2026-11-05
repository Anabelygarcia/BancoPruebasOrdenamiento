using System.Diagnostics;

namespace BancoPruebasOrdenamiento
{
    public partial class Form1 : Form
    {
        // Tamaños de prueba
        private readonly int[] tamanos = { 10000, 50000, 100000 };

        public Form1()
        {
            InitializeComponent();

            // Seleccionar valores por defecto
            cmbTamano.SelectedIndex = 0; // 10,000

            // Marcar los algoritmos eficientes por defecto
            clbAlgoritmos.SetItemChecked(3, true); // Merge Sort
            clbAlgoritmos.SetItemChecked(4, true); // Quick Sort
            clbAlgoritmos.SetItemChecked(5, true); // Heap Sort

            // Centrar texto de las columnas numéricas
            foreach (DataGridViewColumn col in dgvResultados.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgvResultados.Columns["colAlgoritmo"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
        }

        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            lblEstado.Text = "Resultados limpiados. Listo para ejecutar nuevas pruebas.";
            lblEstado.ForeColor = Color.DarkGreen;
        }

        private async void BtnEjecutar_Click(object? sender, EventArgs e)
        {
            if (clbAlgoritmos.CheckedItems.Count == 0)
            {
                MessageBox.Show("Marca al menos un algoritmo con el check.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Advertencia para algoritmos O(n²) con tamaños grandes
            bool tieneCuadraticos = false;
            foreach (string alg in clbAlgoritmos.CheckedItems)
            {
                if (alg is "Bubble Sort" or "Insertion Sort" or "Selection Sort")
                    tieneCuadraticos = true;
            }

            int[] tamanosAProbar = ObtenerTamanos();
            bool tamanosGrandes = tamanosAProbar.Any(t => t >= 50000);

            if (tieneCuadraticos && tamanosGrandes)
            {
                var result = MessageBox.Show(
                    "Has seleccionado algoritmos O(n²) (Bubble, Insertion o Selection) con tamaños de 50.000 o 100.000 elementos.\n\n" +
                    "Esto puede tardar MUCHOS minutos (incluso horas en casos extremos).\n\n" +
                    "¿Deseas continuar de todas formas?",
                    "Advertencia de rendimiento",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;
            }

            await EjecutarPruebas(clbAlgoritmos.CheckedItems.Cast<string>().ToList(), tamanosAProbar);
        }

        /// <summary>
        /// Ejecuta únicamente el algoritmo que está seleccionado (resaltado) en la lista.
        /// </summary>
        private async void BtnEjecutarUno_Click(object? sender, EventArgs e)
        {
            if (clbAlgoritmos.SelectedItem == null)
            {
                MessageBox.Show(
                    "Haz clic en un algoritmo de la lista para seleccionarlo (debe quedar resaltado en azul),\n" +
                    "y luego presiona este botón.",
                    "Selecciona un algoritmo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string alg = clbAlgoritmos.SelectedItem.ToString()!;
            int[] tamanosAProbar = ObtenerTamanos();

            bool esCuadratico = alg is "Bubble Sort" or "Insertion Sort" or "Selection Sort";
            bool tamanosGrandes = tamanosAProbar.Any(t => t >= 50000);

            if (esCuadratico && tamanosGrandes)
            {
                var result = MessageBox.Show(
                    $"Has elegido {alg} (algoritmo O(n²)) con tamaños de 50.000 o 100.000 elementos.\n\n" +
                    "Esto puede tardar MUCHOS minutos.\n\n¿Deseas continuar?",
                    "Advertencia de rendimiento",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;
            }

            await EjecutarPruebas(new List<string> { alg }, tamanosAProbar);
        }

        private int[] ObtenerTamanos()
        {
            if (cmbTamano.SelectedIndex == 3)
                return tamanos;
            return new[] { tamanos[cmbTamano.SelectedIndex] };
        }

        private async Task EjecutarPruebas(List<string> algoritmos, int[] tamanosAProbar)
        {
            btnEjecutar.Enabled = false;
            btnEjecutarUno.Enabled = false;
            clbAlgoritmos.Enabled = false;
            cmbTamano.Enabled = false;

            int totalPruebas = tamanosAProbar.Length * algoritmos.Count;
            int pruebaActual = 0;
            progressBar.Maximum = totalPruebas;
            progressBar.Value = 0;

            await Task.Run(() =>
            {
                foreach (int n in tamanosAProbar)
                {
                    int[] aleatorio = GenerarAleatorio(n);
                    int[] ordenado = (int[])aleatorio.Clone();
                    Array.Sort(ordenado);
                    int[] inverso = (int[])ordenado.Clone();
                    Array.Reverse(inverso);

                    foreach (string alg in algoritmos)
                    {
                        this.Invoke(() =>
                        {
                            lblEstado.Text = $"Ejecutando {alg} con {n:N0} elementos...";
                            lblEstado.ForeColor = Color.DarkBlue;
                        });

                        double tAleatorio = MedirTiempo(alg, (int[])aleatorio.Clone());
                        double tOrdenado = MedirTiempo(alg, (int[])ordenado.Clone());
                        double tInverso = MedirTiempo(alg, (int[])inverso.Clone());
                        double promedio = (tAleatorio + tOrdenado + tInverso) / 3.0;

                        this.Invoke(() =>
                        {
                            dgvResultados.Rows.Add(
                                alg,
                                n.ToString("N0"),
                                tAleatorio.ToString("F2"),
                                tOrdenado.ToString("F2"),
                                tInverso.ToString("F2"),
                                promedio.ToString("F2")
                            );

                            pruebaActual++;
                            progressBar.Value = pruebaActual;
                        });
                    }
                }
            });

            lblEstado.Text = "✓ Pruebas completadas correctamente. Copia los datos a Excel para generar gráficas.";
            lblEstado.ForeColor = Color.DarkGreen;
            btnEjecutar.Enabled = true;
            btnEjecutarUno.Enabled = true;
            clbAlgoritmos.Enabled = true;
            cmbTamano.Enabled = true;
            progressBar.Value = 0;
        }

        private double MedirTiempo(string algoritmo, int[] datos)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Stopwatch sw = Stopwatch.StartNew();

            switch (algoritmo)
            {
                case "Bubble Sort":
                    BubbleSort(datos);
                    break;
                case "Insertion Sort":
                    InsertionSort(datos);
                    break;
                case "Selection Sort":
                    SelectionSort(datos);
                    break;
                case "Merge Sort":
                    MergeSort(datos, 0, datos.Length - 1);
                    break;
                case "Quick Sort":
                    QuickSort(datos, 0, datos.Length - 1);
                    break;
                case "Heap Sort":
                    HeapSort(datos);
                    break;
            }

            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        private int[] GenerarAleatorio(int n)
        {
            Random rnd = new Random(42); // Semilla fija para reproducibilidad
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(1, n * 10);
            return arr;
        }

        // ==================== ALGORITMOS DE ORDENAMIENTO ====================

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                        minIdx = j;
                }
                if (minIdx != i)
                    (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
            }
        }

        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                    arr[k++] = L[i++];
                else
                    arr[k++] = R[j++];
            }
            while (i < n1) arr[k++] = L[i++];
            while (j < n2) arr[k++] = R[j++];
        }

        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        private void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                (arr[0], arr[i]) = (arr[i], arr[0]);
                Heapify(arr, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest);
            }
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
