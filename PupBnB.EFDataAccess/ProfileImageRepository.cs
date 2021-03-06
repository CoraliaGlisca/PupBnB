using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using PupBnB.ApplicationLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class ProfileImageRepository : IProfileImageRepository
    {

        private IHostingEnvironment _hostingEnvironment;

        public ProfileImageRepository(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async void UploadImage(IFormFile file)
        {
            long totalBytes = file.Length;
            string filename = file.FileName.Trim('"');
            filename = EnsureFileName(filename);
            Console.WriteLine(filename);
            byte[] buffer = new byte[16 * 1024];
            using (FileStream output = System.IO.File.Create(GethpathAndFIleName(filename)))
            {
                using (Stream input = file.OpenReadStream())
                {
                    int readBytes;
                    while ((readBytes = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        await output.WriteAsync(buffer, 0, readBytes);
                        totalBytes += readBytes;
                    }
                }
            }
        }

        private string GethpathAndFIleName(string filename)
        {
            string path = _hostingEnvironment.WebRootPath + "\\uploads\\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            Directory.CreateDirectory(path);
            return path + filename;
        }

        private string EnsureFileName(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;
        }

       
    }
}

