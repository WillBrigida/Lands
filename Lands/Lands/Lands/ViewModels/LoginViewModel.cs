using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { this.SetProperty ( ref email , value); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (this.password != value)
                {
                    this.SetProperty( ref password , value);
                }
            }
        }

        private bool isEnabled;

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { this.SetProperty ( ref isEnabled , value); }
        }


        private bool isRunning;

        public bool IsRunning
        {
            get { return isRunning; }
            set {this.SetProperty(ref  isRunning , value); }
        }


        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {

            if (string.IsNullOrEmpty(this.Email ))
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
            this.IsEnabled = true;
        }
    }
}