using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Zen.Barcode;

namespace Prints
{
    public class PrintBarcode
    {
        public void Print()
        {
            BarcodeDraw barcode = BarcodeDrawFactory.GetSymbology(BarcodeSymbology.Code93);
            Image img = barcode.Draw("1578", 25);
            img.Save("barcode93.png");
        }
    }
}
