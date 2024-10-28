using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModel.Accounts
{
    public class UploadImageViewModel
    {
        [Required(ErrorMessage ="A imagem é necessária")]
        public string Base64Image { get; set; }
    }
}
