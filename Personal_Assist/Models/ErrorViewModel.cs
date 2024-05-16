using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace _Personal_Assist_Beta.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

      
}
