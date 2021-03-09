using App01_ConsultarCEP.Model;
using App01_ConsultarCEP.Service;
using System;
using Xamarin.Forms;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnSend.Clicked += FindCep;

            txtCEP.Completed += FindCep;
        }

        public void FindCep(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(txtCEP.Text))
                DisplayAlert("Erro", "Campo vazio!", "Ok");
            else
            {
                string cep = txtCEP.Text.Trim();
                cep = cep.Replace("-", "");

                if (IsValidCep(cep))
                {
                    try
                    {
                        Address address = ViaCepService.FindAddressByCep(cep);

                        if (address != null)
                            lblResult.Text = string.Format("Endereço: {0}, {1} - {2}, {3} - {4}, {5}",
                                address.logradouro, address.complemento, address.bairro, address.localidade,
                                address.uf, address.cep);
                        else
                            DisplayAlert("Erro", "Endereço não encontrado!", "OK");
                    }
                    catch (Exception e)
                    {
                        DisplayAlert("Erro", e.Message, "OK");
                    }
                }
                else
                {
                    DisplayAlert("Erro", "Cep inválido!", "Ok");
                }
            }
        }

        private bool IsValidCep(string cep)
        {
            if (cep.Length != 8)
                return false;

            if (!int.TryParse(cep, out _))
                return false;

            return true;
        }
    }
}