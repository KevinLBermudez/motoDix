using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using System.Windows.Forms;
using System.Drawing;

namespace final_motoDix.helpers
{
    class clsCloudinary
    {
        public static Cloudinary cloud ;

        public clsCloudinary()
        {
            Account account = new Account("dhameorhz", "995748695649763", "IhOi2VxIm0Q6XJRgt_KqpqR0RKM");
            cloud = new Cloudinary(account);
        }


        public async Task<string> cargarImagen(string rutaFile)
        {
            try
            {
                string ruta;

                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(rutaFile)
                    
                };

                var uploadResult = await cloud.UploadAsync(uploadParams);

                ruta = uploadResult.SecureUrl.ToString();
                
                return ruta;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public string  cargarUnArchivo(Bunifu.UI.WinForms.BunifuPictureBox imagenCargada)
        {
            string ruta = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    imagenCargada.Image = Image.FromFile(fileDialog.FileName);

                    return ruta = fileDialog.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar la imagen, seleccione otra por favor");
                }
             

            }

            return null;

        }

    }


}
