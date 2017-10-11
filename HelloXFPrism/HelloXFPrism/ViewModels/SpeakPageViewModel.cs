using HelloXFPrism.Dependencies;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System.Threading.Tasks;

namespace HelloXFPrism.ViewModels
{
    public class SpeakPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;
        private IPageDialogService _dialogService;
        private ITextToSpeech _textToSpeech;

        private string _textToSay = "Hello Prism";

        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand { get; private set; }

        public DelegateCommand ShowDialogsCommand { get; private set; }

        public SpeakPageViewModel()
        {
            SpeakCommand = new DelegateCommand(Speak);
            ShowDialogsCommand = new DelegateCommand(async delegate { await ShowDialogs(); });
        }

        public SpeakPageViewModel(INavigationService navigationService, IPageDialogService dialogService, ITextToSpeech textToSpeech)
            : this()
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
            _textToSpeech = textToSpeech;
        }

        public void Speak()
        {
            _textToSpeech.Speak(_textToSay);
        }

        public async Task ShowDialogs()
        {
            await _dialogService?.DisplayAlertAsync("Display Alert", "This is a Display Alert made with Prism", "OK");

            await _dialogService.DisplayActionSheetAsync("ActionSheet", "Cancel", "Destroy", "Button01", "Button02", "Button03");

            IActionSheetButton b1 = ActionSheetButton.CreateButton("Button1",
                async delegate { await _dialogService?.DisplayAlertAsync("Display Alert", "Button 1 Pressed", "OK"); });
            IActionSheetButton b2 = ActionSheetButton.CreateCancelButton("Cancel",
                async delegate { await _dialogService?.DisplayAlertAsync("Display Alert", "Cancel Pressed", "OK"); });
            IActionSheetButton b3 = ActionSheetButton.CreateDestroyButton("Destroy",
                async delegate { await _dialogService?.DisplayAlertAsync("Display Alert", "Destroy Pressed", "OK"); });

            await _dialogService.DisplayActionSheetAsync("ActionSheet with IActionSheetButton", b1, b2, b3);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            System.Diagnostics.Debug.WriteLine($"{GetType().FullName}.OnNavigatedTo");

            foreach (var key in parameters.Keys)
            {
                System.Diagnostics.Debug.WriteLine($"{key} => {parameters[key]} ({parameters[key].GetType()})");
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
