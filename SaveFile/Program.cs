using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SaveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(@"https://nsportal.ru/sites/default/files/2014/01/16/issledovatelskaya_rabota_po_osvoeniyu_kosmosa.docx",
                    "DocFile.txt");
            }
        }
    }
}
