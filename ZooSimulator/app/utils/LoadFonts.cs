/*---------------------------------------
| Name: Lenard Pop
| Date: 26/10/2019
| Description (Explanations): 
|   Adding custom fonts to be able to use it throught the software
|
|--------------------------------------*/
using System;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ZooSimulator.Utils
{
    public class LoadFonts
    {
        private PrivateFontCollection fontCollection;
        public PrivateFontCollection Font { get => fontCollection; }

        public LoadFonts()
        {
            //Create your private font collection object.
            fontCollection = new PrivateFontCollection();

            AddFont(Properties.Resources.big_noodle_titling);
            AddFont(Properties.Resources.Champagne___Limousines);
        }

        private void AddFont(byte[] font)
        {
            // Select your font from the resources.
            int fontLength = font.Length;
            byte[] fontdata = font;

            // Create an unsafe memory block for the font data and copy the bytes to the unsafe memory block
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);

            // Pass the font to the font collection
            fontCollection.AddMemoryFont(data, fontLength);
        }
    }
}
