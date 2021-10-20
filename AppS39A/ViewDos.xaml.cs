using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS39A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
       
        public ViewDos(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;

        }
    }
}