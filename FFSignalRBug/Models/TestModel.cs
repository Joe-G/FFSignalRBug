using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FFSignalRBug.Models
{
    public class TestModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string someText { get; set; }

        [HiddenInput(DisplayValue=false)]
        public string ConnectionID { get; set; }
    }
}