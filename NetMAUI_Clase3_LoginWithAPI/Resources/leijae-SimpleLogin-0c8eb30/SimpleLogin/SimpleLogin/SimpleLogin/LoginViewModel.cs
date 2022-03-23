using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleLogin
{
    class LoginViewModel
    {
        public LoginModel LoginModel { get; set; } = new LoginModel();
        public ICommand LoginCommand { get;}
        public ICommand ForgotPasswordCommand { get; }
        public ICommand ContinueCommand { get; }
        public ICommand RegisterCommand { get; }
        private Page _page;

        public LoginViewModel(Page page)
        {
            _page = page;
            RegisterCommand = new Command(async () => await RegisterAsync());
            LoginCommand = new Command(async () => await LoginAsync());
            ForgotPasswordCommand = new Command(async () => await ForgotPasswordAsync());
            ContinueCommand = new Command(async () => await ContinueAsGuestAsync());
        }

        private Task RegisterAsync()
        {
            return null;
        }

        private Task ContinueAsGuestAsync()
        {
            return null;
        }

        private Task ForgotPasswordAsync()
        {
            return null;
        }

        private  Task LoginAsync()
        {
            return null;
        }
    }
}
