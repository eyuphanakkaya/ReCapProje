using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelpers
{
    public interface IFileHelper
    {
        string Upload(IFormFile fileHelper, string root);
        void Delete(string filePath);
        string Update(IFormFile fileHelper, string filePath, string root);
    }
}
