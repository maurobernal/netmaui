using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetMAUI_Clase2_Calculator.ViewModels;
public class DecimalKeypadViewModel : INotifyPropertyChanged
{
    string entry = "0";
    public event PropertyChangedEventHandler PropertyChanged;

    public decimal first_term { get; set; }
    public decimal total { get; set; }
    public bool second_terms { get; set; }
    public bool newdigit { get; set; }
    public string operation { get; set; }

    public string Entry
    {
        get { return entry; }
        set
        {
            if (entry != value)
            {
                entry = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entry"));
            }
        }
    }


    public ICommand ClearCommand { private set; get; }
    public ICommand BackspaceCommand { private set; get; }
    public ICommand DigitCommand { private set; get; }
    public ICommand InverterCommand { private set; get; }
    public ICommand OperationCommand { private set; get; }


    public DecimalKeypadViewModel()
    {
        ClearCommand = new Command(
            execute: () =>
            {
                Entry = "0";
                total = 0;
                first_term = 0;
                second_terms = false;
                RefreshCanExecutes();
            });

        BackspaceCommand = new Command(
            execute: () =>
            {
                Entry = Entry.Substring(0, Entry.Length - 1);
                if (Entry == "") Entry = "0";
                RefreshCanExecutes();
            },
            canExecute: () => Entry.Length > 1 || Entry != "0"
            );

        DigitCommand = new Command<string>(
            execute: (string digito) =>
            {

               
                if (newdigit)
                {
                    Entry = digito;
                    newdigit = false;
                } else
                {
                    Entry += digito;

                }


                if (Entry.StartsWith("0") && !Entry.StartsWith("0."))
                    Entry = Entry[1..];
                RefreshCanExecutes();
            },
            canExecute: (string digito) =>
                !(digito == "." && Entry.Contains("."))
            );
        InverterCommand = new Command(
            execute: () =>
            {
                Entry = (decimal.Parse(Entry) * -1).ToString();

            },
            canExecute: () => Entry != "0"
            );
        OperationCommand = new Command<string>(
            execute: (string operador) =>
            {
                operation = operador;
                Resolve();
                RefreshCanExecutes();

            },
            canExecute: (string operador) => Entry != "0"

            );


    }

    void RefreshCanExecutes()
    {
        ((Command)BackspaceCommand).ChangeCanExecute();
        ((Command)DigitCommand).ChangeCanExecute();
        ((Command)InverterCommand).ChangeCanExecute();
        ((Command)OperationCommand).ChangeCanExecute();
    }

    void Resolve()
    {
        newdigit = true;
        if (second_terms)
        {
            if (operation =="+") total = total + first_term + decimal.Parse(Entry);
            if (operation == "-") total = total + first_term - decimal.Parse(Entry);
            if (operation == "/") total = total + first_term / decimal.Parse(Entry);
            if (operation == "*") total = total + first_term * decimal.Parse(Entry);
            second_terms = false;
            Entry = total.ToString();

        }
        else
        {
            first_term = decimal.Parse(Entry);
            second_terms = true;

        }

       
    }




}
