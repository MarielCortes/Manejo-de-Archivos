using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace Manejo_de_Archivos
{
   public class Class1
    {
        TextWriter archivo;
        String ruta, turuta;

        public void CrearArchivo(TextBox uno, RichTextBox dos)
        {
            if (uno.Text != "")
            {

                FolderBrowserDialog fod = new FolderBrowserDialog();
                fod.Description = "Seleccione la ruta donde desea guardar el documento";
                fod.RootFolder = Environment.SpecialFolder.Desktop;
                if (fod.ShowDialog() == DialogResult.OK)
                {
                    ruta = fod.SelectedPath;
                    String mensaje;
                    mensaje = dos.Text;
                    archivo = new StreamWriter(ruta + "\\" + uno.Text + ".txt");
                    archivo.Write(mensaje);
                    archivo.Close();
                    MessageBox.Show("correcto");
                }
            }
            else MessageBox.Show("no has escrito el nombre del archivo no podemos continuar porfavor escribe algo ");
        }

        public void CargarTexto(RichTextBox hola, TextBox tres)
        {
            hola.Text = "";

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos txt(*.txt)|*.txt";
            open.Title = "Archivos .txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                turuta = open.FileName;
                tres.Text = turuta;
                StreamReader file = new StreamReader(turuta);
                while (file.Peek() != -1)
                {
                    hola.Text += file.ReadLine() + "\n";
                }
                file.Close();
            }
            open.Dispose();
        }

        public void GuardarCambios(TextBox ma, RichTextBox so)
        {
            ma.Text = turuta;

            String mensaje;
            mensaje = so.Text;
            archivo = new StreamWriter(turuta);
            archivo.Write(mensaje);
            archivo.Close();
            MessageBox.Show("Edicion correcta");
        }

        public void FEHO(Label tu, Label yo)
        {
            tu.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            yo.Text = "Hora:  " + DateTime.Now.ToLongTimeString();
        }
    }
}
