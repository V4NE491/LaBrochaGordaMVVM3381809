namespace LaBrochaGordaMVVM3381809
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public class Cotizacion
        {
            public double PrecioPorMetroCuadrado { get; set; }
            public double MetrosCuadrados { get; set; }
            public double Total { get; set; }

            public void CalcularTotal()
            {
                Total = PrecioPorMetroCuadrado * MetrosCuadrados;
            }
        }

    }

}
