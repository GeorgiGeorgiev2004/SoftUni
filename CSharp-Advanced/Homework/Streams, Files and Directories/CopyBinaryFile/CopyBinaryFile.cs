using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
namespace CopyBinaryFile
{
    using System;
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath,FileMode.Open))
            {
                using (FileStream fs = new FileStream(outputFilePath,FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[512];
                        int size = reader.Read(buffer, 0, buffer.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        fs.Write(buffer, 0, size);
                    }
                }
            }
                throw new NotImplementedException();
        }
    }
}
