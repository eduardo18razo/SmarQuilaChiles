using System;
using System.Drawing;
using System.IO;

namespace QuilaChiles.Business.Utilidades
{
    public static class Imagenes
    {

        public static byte[] ImagenToByte(Image image)
        {
            byte[] buffer;
            try
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                buffer = ms.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return buffer;
        }

        public static Image ByteToImagen(byte[] byteArray)
        {
            if (byteArray == null)
                return null;
            MemoryStream memoryStream = new MemoryStream(byteArray, 0, byteArray.Length);
            memoryStream.Write(byteArray, 0, byteArray.Length);
            return Image.FromStream(memoryStream, true);
        }
    }
}
