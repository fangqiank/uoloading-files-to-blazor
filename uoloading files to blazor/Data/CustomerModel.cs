using System.Diagnostics;

namespace uoloading_files_to_blazor.Data
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "zhang san";
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FileName { get; set; }
    }
}
