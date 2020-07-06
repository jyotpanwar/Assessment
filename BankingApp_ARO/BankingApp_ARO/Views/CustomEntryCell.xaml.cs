using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BankingApp_ARO.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankingApp_ARO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEntryCell : ViewCell
    {
        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create("LabelText", typeof(string),
            typeof(CustomEntryCell));
        public static readonly BindableProperty EntryTextProperty = BindableProperty.Create("EntryText", typeof(string),
            typeof(CustomEntryCell));
        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create("Placeholder", typeof(string),
            typeof(CustomEntryCell));

        //create event property to catch on comeplete event
        public static readonly BindableProperty EntryCompletedProperty =
        BindableProperty.Create("EntryCompleted", typeof(ICommand), typeof(CustomEntryCell), null);

        public ICommand EntryCompleted
        {
            get { return (ICommand)GetValue(EntryCompletedProperty); }
            set { SetValue(EntryCompletedProperty, value); }
        }

        public string LabelText
        {
            get
            {
                return (string)GetValue(LabelTextProperty);
            }
            set => SetValue(LabelTextProperty, value);
        }

        public string EntryText
        {
            get
            {
                return (string)GetValue(EntryTextProperty);
            }
            set
            {
                SetValue(EntryTextProperty, value);
            }
        }

        public string Placeholder
        {
            get
            {
                return (string)GetValue(PlaceholderProperty);
            }
            set
            {
                SetValue(PlaceholderProperty, value);
            }
        }

        public CustomEntryCell()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Entry_Completed(System.Object sender, System.EventArgs e)
        {
            if (EntryCompleted.CanExecute(sender))
            {
                EntryCompleted.Execute(sender);
            }
        }
    }
}
