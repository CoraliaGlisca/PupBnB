using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IProfileImageRepository
    {
        void UploadImage(IFormFile file);
    }
}
