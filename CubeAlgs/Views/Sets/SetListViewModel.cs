using CubeAlgs.Data.Models;
using CubeAlgs.Repositories;
using CubeAlgs.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeAlgs.Views.Sets
{
    public class SetListViewModel
    {
        private readonly ISetService _setService = new SetService(new SetRepository());

        public SetListViewModel(
            //ISetService setService
            )
        {
            //_setService = setService;
            GetSets();
        }

        public ObservableCollection<Set> Sets { get; set; }

        private void GetSets()
        {
            if (DesignerProperties.GetIsInDesignMode(
                new System.Windows.DependencyObject())) return;

            var sets = _setService.GetSets().Result;
            Sets = new ObservableCollection<Set>(sets);
        }
    }
}
