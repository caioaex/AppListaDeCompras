using AppListaDeCompras.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDeCompras.ViewModels
{
    public partial class ListToBuyViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListToBuy> _ListToBuy;

        public ListToBuyViewModel() 
        {
            ListToBuy = new ObservableCollection<ListToBuy>()
            {
                new ListToBuy()
                {
                    Name = "Minha lista",
                    Users = new List<User>()
                    { 
                        new() { Name = "Caio", Email= "caio@gmail.com"},
                        new() { Name = "João", Email= "joão@gmail.com"}
                    },
                    Products = new List<Product>() 
                    {
                        new() {  },
                        new() {  },
                        new() {  },
                    }
                },
                new ListToBuy()
                {
                    Name = "Minha lista 2",
                    Users = new List<User>()
                    {
                        new() { Name = "Caio", Email= "caio@gmail.com"}
                    }
                }
            };
        }
    }
}
