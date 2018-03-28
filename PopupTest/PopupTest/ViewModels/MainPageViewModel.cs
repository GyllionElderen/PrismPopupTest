using PopupTest.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopupTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand OpenPopupCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            _navigationService = navigationService;

            Title = "Main Page";
            OpenPopupCommand = new DelegateCommand(OpenPopup);
        }

        private void OpenPopup()
        {
            _navigationService.NavigateAsync(nameof(TestPopup));
        }
    }
}
