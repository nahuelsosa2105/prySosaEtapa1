using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaEtapa1
{
    public partial class frmMain : Form

    {
        public Bitmap guardarFirma;
        public frmMain()
        {
            InitializeComponent();
            pctFirma.MouseDown += pctFirma_MouseDown;
            pctFirma.MouseMove += pctFirma_MouseMove;
            pctFirma.MouseUp += pctFirma_MouseUp;

            guardarFirma = new Bitmap(pctFirma.Width, pctFirma.Height);
            pctFirma.Image = guardarFirma;
        }

        private Point ubicacionPrevia;
        private bool firmando = false;



       

        private void pctFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                firmando |= true;
                ubicacionPrevia = e.Location;
            }
        }

        private void pctFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (firmando)
            {
                using (Graphics firmita = Graphics.FromImage(guardarFirma))
                {
                    Pen pen = new Pen(Color.Black, 1);
                    firmita.DrawLine(pen, ubicacionPrevia, e.Location);
                }
                pctFirma.Invalidate();
                ubicacionPrevia = e.Location;

            }
        }

        private void pctFirma_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                firmando = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFirma();
        }

        public Bitmap firmaGuardada;

        private void btnFirmar_Click(object sender, EventArgs e)
        {
            if(guardarFirma != null)
            {
                try
                {
                    string carpetaImagenesFirmas = Path.Combine(Application.StartupPath, "Imagenes Firmas");

                    if (!Directory.Exists(carpetaImagenesFirmas))
                    {
                        Directory.CreateDirectory(carpetaImagenesFirmas);
                    }

                    string nombreArchivo = $"firma_{DateTime.Now.ToString("yyyy-MM-dd-HH,mm,ss")}.png";

                    string rutaArchivo = Path.Combine(carpetaImagenesFirmas, nombreArchivo);

                    guardarFirma.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show("¡Firma guardada con exito!");

                    LimpiarFirma();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al guardar la firma" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se registro ninguna firma, vuelva a intenrarlo");
            }
        }

        private void LimpiarFirma()
        {
            // Limpiar el bitmap que contiene la firma
            using (Graphics g = Graphics.FromImage(guardarFirma))
            {
                g.Clear(Color.White); // Limpia el bitmap con un fondo blanco
            }

            // Actualizar el PictureBox para mostrar el bitmap limpio
            pctFirma.Invalidate();
        }
    }

   
}
