using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Pages
{
    public class UploadModel : PageModel
    {
        [BindProperty, Display(Name = "File")]
        public IFormFile UploadedFile { get; set; }
        public void OnPost()
        {
            FileStream? fileStream = null;
            try
            {
                int yy = 1;
                string f1 = UploadedFile.FileName;

                fileStream = new FileStream(f1, FileMode.OpenOrCreate);
                UploadedFile.CopyTo(fileStream);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream?.Close();
                fileStream?.Dispose();
            }
        }


        public void OnGet()
        {
        }
    }
}

