using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.Model
{
    public class Pie : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string _description { get; set; }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }



        private string _pieName;

        public string PieName
        {
            get => _pieName;
            set
            {
                _pieName = value;
                RaisePropertyChanged(nameof(PieName));
            }
        }

        private double _price;

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        private string _imageUrl;

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChanged(nameof(ImageUrl));
            }
        }

        private bool _inStock;
        public bool InStock
        {
            get => _inStock;
            set
            {
                _inStock = value;
                RaisePropertyChanged(nameof(InStock));
            }
        }

        private DateTime _availableFromDate;

        public DateTime AvailableFromDate
        {
            get => _availableFromDate;
            set
            {
                _availableFromDate = value;
                RaisePropertyChanged(nameof(AvailableFromDate));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
