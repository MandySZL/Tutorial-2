using Prism.Mvvm; // You need this for BindableBase

namespace Tutorial2.ViewModels
{
    // Fix 1: Must be 'public abstract'
    // Fix 2: Fix typo 'BaseVieModel' -> 'BaseViewModel'
    // Fix 3: Inherit from 'BindableBase'
    public abstract class BaseViewModel : BindableBase
    {
        public BaseViewModel()
        {
        }
    }
}