using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using DemoProject5.Models;
namespace DemoProject5.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private MainModel _mainModel;
    public string NameInput { get; set; }
    public string AgeInput { get; set; }
    public string GenderInput { get; set; }
    public string ColorInput { get; set; }
    public RelayCommand AddPersonCommand { get; set; }
    public ObservableCollection<Person> People { get; set; }
   
    public MainViewModel(MainModel model)
    {
        _mainModel = model;
        _mainModel.CreatedPerson += ModelCreatedPerson;
        People = new ObservableCollection<Person>();
        AddPersonCommand = new RelayCommand(AddPerson);

        for (int i = 0; i < 5; i++)
        {
            _mainModel.GeneratePeople();
        }
    }

    private void ModelCreatedPerson(object? sender,PersonEventArgs args)
    {
        args.NewPerson.DeleteCommand = new RelayCommand(() => People.Remove(args.NewPerson));
        People.Add(args.NewPerson);   
    }

    private void  AddPerson()
    {
        Person jani = new Person(NameInput,AgeInput,GenderInput,ColorInput);
        jani.DeleteCommand = new RelayCommand(() => People.Remove(jani));
        People.Add(jani);
    }
}
