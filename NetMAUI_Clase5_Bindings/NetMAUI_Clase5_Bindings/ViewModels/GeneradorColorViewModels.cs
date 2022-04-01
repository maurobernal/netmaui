using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMAUI_Clase5_Bindings.ViewModels;
public class GeneradorColorViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private Color _color;
    public Color color
    {
        get => _color;

        set
        {
            if (_color != value)
            {
                _color = value;
                _sat = _color.GetSaturation();
                _hue = _color.GetHue();
                _lum = _color.GetLuminosity();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("sat"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("hue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("lum"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("color"));
            }

        }
    }


    private double _hue;
    public double hue
    {
        get => _hue;

        set
        {
            if (_hue != value) color = Color.FromHsla(value, sat, lum);

        }
    }

    private double _sat;
    public double sat
    {
        get => _sat;
        set
        {
            if (_sat != value) color = Color.FromHsla(hue, value, lum);

        }
    }


    private double _lum;
    public double lum
    {
        get => _lum;

        set
        {
            if (value != _lum) color = Color.FromHsla(hue, sat, value);

        }
    }

}

