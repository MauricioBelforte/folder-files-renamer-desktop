using System;
using System.IO;
using System.Windows.Forms;

namespace RenombraArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes dejar este evento vac�o si no necesitas hacer nada al cargar el formulario.
        }

        private void lblArrastreCarpeta_Click(object sender, EventArgs e)
        {
            // Este evento est� vac�o, pero se mantiene si lo creaste en el dise�ador.
        }

        // ------------------------------------------------------------------
        // L�gica de arrastrar y soltar la carpeta
        // ------------------------------------------------------------------

        private void pnlZonaArrastre_DragEnter(object sender, DragEventArgs e)
        {
            // Verificar si lo que se arrastra es una �nica carpeta
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                // Si solo se arrastra un elemento y es una carpeta
                if (paths.Length == 1 && Directory.Exists(paths[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                    pnlZonaArrastre.BackColor = System.Drawing.Color.LightBlue; // Efecto visual al arrastrar
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pnlZonaArrastre_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            string rutaCarpetaOriginal = paths[0];

            try
            {
                string nombreCarpeta = Path.GetFileName(rutaCarpetaOriginal);
                string[] archivos = Directory.GetFiles(rutaCarpetaOriginal);
                int contador = 1;

                lblEstado.Text = $"Renombrando archivos en la carpeta '{nombreCarpeta}'...";
                pnlZonaArrastre.BackColor = System.Drawing.SystemColors.Control; // Volver al color original

                foreach (string archivoOriginal in archivos)
                {
                    // Solo procesamos archivos, no otras carpetas si las hubiera
                    if (File.Exists(archivoOriginal))
                    {
                        string extension = Path.GetExtension(archivoOriginal);
                        string nuevoNombre = $"{nombreCarpeta}-{contador}{extension}";
                        string nuevaRutaCompleta = Path.Combine(rutaCarpetaOriginal, nuevoNombre);
                        File.Move(archivoOriginal, nuevaRutaCompleta);
                        contador++;
                    }
                }

                lblEstado.Text = $"�Listo! Se han renombrado {contador - 1} archivos en la carpeta '{nombreCarpeta}'.";
            }
            catch (Exception ex)
            {
                lblEstado.Text = $"Error al procesar la carpeta: {ex.Message}";
                pnlZonaArrastre.BackColor = System.Drawing.Color.Red;
            }
            finally
            {
                // Restablecer el color del panel para el siguiente uso
                pnlZonaArrastre.BackColor = System.Drawing.SystemColors.Control;
            }
        }
    }
}