using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.ViewModel;

[QueryProperty("Pokemon", "Pokemon")]

public class PokeDetailsViewModels : BaseViewModel
{
    public string Nombre { get; set; }
	public PokeDetailsViewModels()
	{

	}
}
