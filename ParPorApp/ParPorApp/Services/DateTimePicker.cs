using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ParPorApp.Services
{
    class DateTimePicker : StackLayout
    {
        private readonly DatePicker _date;
        private readonly TimePicker _time;

        public DateTimePicker()
        {
            // _display = Resolver.Resolve<IDisplay>();
            this.Orientation = StackOrientation.Horizontal;
            this.Padding = 2;
            _date = new DatePicker();
            // _date.Format = CultureInfo.DefaultThreadCurrentUICulture.DateTimeFormat.ShortDatePattern;
            // _date.WidthRequest = ((_display.Width / 2) / 3) * 2 - 50;
            _time = new TimePicker();
            // _time.Format = CultureInfo.DefaultThreadCurrentUICulture.DateTimeFormat.ShortTimePattern;
            // _time.WidthRequest = ((_display.Width / 2) / 3) - 10;
            this.Children.Add(_date);
            this.Children.Add(_time);
            this.BindingContextChanged += OnBindingContextChanged;
            _date.PropertyChanged += DateOnPropertyChanged;
            _time.PropertyChanged += TimeOnPropertyChanged;
        }

        private void TimeOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Time")
            {
                Value = _date.Date.Add(_time.Time);
            }
        }

        private void DateOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Date")
            {
                Value = _date.Date.Add(_time.Time);
            }
        }

        #region Value

        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create<DateTimePicker, DateTime>(
                p => p.Value, default(DateTime));

        public DateTime Value
        {
            get { return _date.Date.Add(_time.Time); }
            set
            {
                _date.SetValue(DatePicker.DateProperty, value);
                _time.SetValue(TimePicker.TimeProperty, value);
            }

            #endregion
        }

        private void OnBindingContextChanged(object sender, EventArgs eventArgs)
        {
            var dateTime = Value;
            _date.Date = dateTime.Date;
            _time.Time = dateTime.TimeOfDay;
        }
    }
}
