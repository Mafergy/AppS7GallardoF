using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppS6GallardoF.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS6GallardoF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaRegistro : ContentPage
    {
        private SQLiteAsyncConnection con;
        private ObservableCollection<Estudiante> tablaEstudiantes;
        public ConsultaRegistro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
            consulta();
        }
        public async void consulta()
        {
            var registros = await con.Table<Estudiante>().ToListAsync();
            tablaEstudiantes = new ObservableCollection<Estudiante>(registros);
            ListaUsuario.ItemsSource = tablaEstudiantes;
        }

        private void ListaUsuario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Obj = (Estudiante)e.SelectedItem;
            var item = Obj.Id.ToString();
            int Id = Convert.ToInt32(item);
            try
            {
                Navigation.PushAsync(new Elemento(Id));
            }
            catch(Exception ex)
            {

            }
        }
    }
}