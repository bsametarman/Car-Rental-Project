using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName(); //yeni dosya oluşturuyor ve dosya yolunu döndürüyor
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream); //hedef sisteme dosya içeriğini kopyalıyor
                }
            }
            var result = newPath(file);
            File.Move(sourcepath, result); //taşınacak doysa adı, taşınan dosya için yeni yol ve isim.
            return result;
        }

        public static void Delete(string path)
        {
            File.Delete(path);
        }

        public static string Update(string sourcepath, IFormFile file)
        {
            var result = newPath(file);
            if (sourcepath.Length > 0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            File.Delete(sourcepath);
            return result;
        }
        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName); // dosya yolunu kapsıyor
            string fileExtension = ff.Extension; //dosya uzantılarını temsil ediyor

            string path = Environment.CurrentDirectory + @"\Images\"; //çalışılan dosya yolunu alır veya set eder
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
    
}
