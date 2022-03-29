using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetMAUI_Clase4_MVVM.ViewModel;
public class ContadorViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private int _contador = 0;
    public string Contador_Mensaje
    {
        get => $"Contador:{_contador.ToString()}";
    }
    public int Contador
    {
        get => _contador;
        set
        {
            _contador = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Contador_Mensaje"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Log"));
        }
    }
    public string Log
    {
        get=> $"Log:{DateTime.Now.ToString("yyyy/MM/dd hh:MM:ss")}";
    }

    public ICommand ActualizarContador { private set; get; }

    public ContadorViewModel()
    {
        ActualizarContador = new Command(
            execute: () => { Contador++;ValidarCanExecute(); },
            canExecute: () => (Contador < 10)
            );
    }

    public void ValidarCanExecute()
    {
        ((Command)ActualizarContador).ChangeCanExecute();
    }

}

