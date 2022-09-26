using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PokeAPI.DTO;
using PokeAPI.Interfaces;
using Shiny.Push;
using Shiny.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.ViewModel;

public partial class PokeMasterViewModel: BaseViewModel
{

    [ObservableProperty]
    [NotifyPropertyChangedFor("CantReg")]
    bool isRefreshing;

    [ObservableProperty]
    int cantReg;

    public ObservableCollection<CollectionDTO> list { get; private set; }



    private readonly IPokeAPIService _pokeapiservice;
    private readonly IPushManager _pushManager;


    public PokeMasterViewModel(IPokeAPIService pokeapiservice, IPushManager pushManager)
    {

        _pokeapiservice = pokeapiservice;
        _pushManager = pushManager;








    }




    [RelayCommand]
    public async Task GetPokeList()
    {



        if(IsBusy) return;
        isRefreshing= true;
        if (list.Count > 0) list.Clear();
        var res= await _pokeapiservice.GetListAsync("type/1");
            list.Add(new CollectionDTO("type1", res.results));

        CantReg = res.count;
        IsBusy = false;
        IsRefreshing = false;

    }

    [RelayCommand]
    async Task GetPokeDetails(string name)
    {
        if (name == null || name=="") return;
        await Shell.Current.GoToAsync("PokeDetailsPage", true, new Dictionary<string, object> { { "Pokemon", name }
        });
    }


}

public class KeyValue : IKeyValueStoreFactory
{
    public string[] AvailableStores => throw new NotImplementedException();

    public IKeyValueStore DefaultStore => throw new NotImplementedException();

    public IKeyValueStore GetStore(string aliasName)
    {
        throw new NotImplementedException();
    }

    public bool HasStore(string aliasName)
    {
        throw new NotImplementedException();
    }

    public void SetDefaultStore(string aliasName)
    {
        throw new NotImplementedException();
    }
}
