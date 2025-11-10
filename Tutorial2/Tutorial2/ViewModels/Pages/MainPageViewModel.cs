// Add using statements for Prism and your (future) Models
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;
// using Tutorial2.Models; // <-- Add this line after you complete Step 11

namespace Tutorial2.ViewModels.Pages
{
    // Fix 1: Must be 'public'
    // Fix 2: Must inherit from 'BaseViewModel'
    public class MainPageViewModel : BaseViewModel
    {
        // This is the code from your Step 4, adapted
        // public MyModel Model { get; set; } // <-- Uncomment this after Step 11

        private string _message = string.Empty;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); } // This is the Prism way
        }

        private int Counter { get; set; }

        public ICommand TestCommand { get; set; }

        public MainPageViewModel()
        {
            Message = "Click me.";
            // Model = new(); // <-- Uncomment this after Step 11
            TestCommand = new DelegateCommand(Count);
        }

        private void Count()
        {
            Counter++;
            Message = $"Clicked {Counter}";
        }
    }
}