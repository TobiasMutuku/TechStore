using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebApplication1.UploadService
{
    public class LocalUploadService : IFileUploadService
    {
        private string environment;

        public LocalUploadService(string path) 
        { 
            this.environment = path;
        }

        public async System.Threading.Tasks.Task<string> UploadFileAsync(IFormFile file)
        {
            var filePath = System.IO.Path.Combine(environment, @"\img", file.FileName);
            using var fileStream = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
            await file.CopyToAsync(fileStream);
            return file.FileName;
        }
        
    }
}
