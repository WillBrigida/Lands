using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isRunning { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {

            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Ops!",
                    "Você esqueceu de digitar seu Email",
                    "Ok");
                return;
            }

                if (string.IsNullOrEmpty(this.Password))
                {
                    await Application.Current.MainPage.DisplayAlert(
                        "Ops!",
                        "Você esqueceu de digitar sua senha",
                        "Ok");
                    return;
                }

                if (this.Email != "will_brigida@hotmail.com" || this.Password != "123456")
                {
                    await Application.Current.MainPage.DisplayAlert(
                        "Ops!",
                        "Login ou Senha inválido! Verifique os dados informados e tente novamente",
                        "Ok");
                    return;
                }
            
        }

        public LoginViewModel()
        {

        }
    }
}