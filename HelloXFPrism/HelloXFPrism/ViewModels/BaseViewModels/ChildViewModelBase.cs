using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using System;

namespace HelloXFPrism.ViewModels.BaseViewModels
{
    public abstract class ChildViewModelBase : BindableBase, IActiveAware, INavigatingAware, IDestructible
    {
        protected bool HasInitialized { get; set; }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, RaiseIsActiveChanged); }
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
