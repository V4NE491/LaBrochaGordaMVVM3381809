using System.ComponentModel;
using System.Runtime.CompilerServices;
using static LaBrochaGordaMVVM3381809.MainPage;

namespace LaBrochaGordaMVVM3381809.ViewModels
{
    public class CotizacionViewModel : INotifyPropertyChanged
    {
        private Cotizacion _cotizacion;

        public CotizacionViewModel()
        {
            _cotizacion = new Cotizacion();
        }

        public double PrecioPorMetroCuadrado
        {
            get => _cotizacion.PrecioPorMetroCuadrado;
            set
            {
                _cotizacion.PrecioPorMetroCuadrado = value;
                OnPropertyChanged();
                CalcularTotal();
            }
        }

        public double MetrosCuadrados
        {
            get => _cotizacion.MetrosCuadrados;
            set
            {
                _cotizacion.MetrosCuadrados = value;
                OnPropertyChanged();
                CalcularTotal();
            }
        }

        public double Total
        {
            get => _cotizacion.Total;
            private set
            {
                _cotizacion.Total = value;
                OnPropertyChanged();
            }
        }

        private void CalcularTotal()
        {
            _cotizacion.CalcularTotal();
            Total = _cotizacion.Total;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
