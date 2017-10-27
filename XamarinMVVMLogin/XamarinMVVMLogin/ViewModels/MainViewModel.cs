using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinMVVMLogin.Services;
using XamarinMVVMLogin.Models;

namespace XamarinMVVMLogin.ViewModels
{
    public class MainViewModel
    {
        private Usuario usuario = new Usuario();
        LoginService service = new LoginService();

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(){}

        public Command LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (!string.IsNullOrEmpty(Usuario.Usuario_nome) && !string.IsNullOrEmpty(Usuario.Usuario_senha))
                    {
                        bool resp = await service.LoginAsync(Usuario.Usuario_nome, Usuario.Usuario_senha);
                    }
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
