using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Utils
{
    class ConverterImagem
    {
        public Image byteArrayToImage(byte[] byteArrayIn)

        {
            MemoryStream ms = new MemoryStream(byteArrayIn);

            Image returnImage = Image.FromStream(ms);

            return returnImage;

        }
    }
}
