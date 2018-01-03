using System;

namespace EmployeeBox.ViewModels
{
    public class ContextState
    {
        public bool State { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FunctionName { get; set; }
        public string ClassName { get; set; }
    }
}