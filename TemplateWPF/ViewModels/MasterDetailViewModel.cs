﻿using System;
using System.Collections.ObjectModel;
using System.Linq;

using GalaSoft.MvvmLight;

using TemplateWPF.Contracts.ViewModels;
using TemplateWPF.Core.Contracts.Services;
using TemplateWPF.Core.Models;

namespace TemplateWPF.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase, INavigationAware
    {
        private readonly ISampleDataService _sampleDataService;
        private SampleOrder _selected;

        public SampleOrder Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public MasterDetailViewModel(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            SampleItems.Clear();

            var data = await _sampleDataService.GetMasterDetailDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            Selected = SampleItems.First();
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
