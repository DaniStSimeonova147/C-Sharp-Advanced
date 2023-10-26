using System;
using System.IO;
using System.IO.Compression;

namespace E06.ZipExtr
{
    class Program
    {
        static void Main(string[] args)
        {
            var zipFile = @"..\..\..\myNewzip.zip";
            var file = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {

                archive.CreateEntryFromFile(file, Path.GetFileName(file));

            }



            //string picFolderPath = ".";
            //string targetPath = "../../../result.zip";

            //ZipFile.CreateFromDirectory(picFolderPath, targetPath);

            //ZipFile.ExtractToDirectory(targetPath, "../../");

        }
    }
}
