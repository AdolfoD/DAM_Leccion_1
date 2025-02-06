using DAM_Leccion_1.Model;

namespace DAM_Leccion_1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        public void Ejecutar()
        {
            PersonaModel personaModel = new PersonaModel()
            {
                Nombre = "Hola Bebé",
            };
            BindingContext = personaModel.Nombre;
            //txtNombre3.Text = personaModel.Nombre;

            // Binding personaBinding = new Binding();
            //personaBinding.Source = personaModel; //ORIGEN
            // personaBinding.Path = "Nombre";//RUTA
            //txtNombre3.SetBinding(Entry.TextProperty,personaBinding);//DESTINO FINAL
        }
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Asistente del sistema", "Se ah guardado el registro en DB", "Aceptar");
        }
    }

}
