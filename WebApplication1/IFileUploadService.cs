using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1.UploadService
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file);
        
    }
}
