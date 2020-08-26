using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrismDemo.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _firstName;
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName,value); }
        }

        private string _secondName;
        /// <summary>
        /// Second Name
        /// </summary>
        public string SecondName
        {
            get { return _secondName; }
            set { SetProperty(ref _secondName, value);
                //UpdateCommand.RaiseCanExecuteChanged();
            }
        }

        private DateTime? _lastUpdated;
        /// <summary>
        /// Time
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return _lastUpdated; }
            set { SetProperty(ref _lastUpdated, value);
                //UpdateCommand.RaiseCanExecuteChanged();
            }
        }

        private IEventAggregator _eventAggregator;

        public DelegateCommand UpdateCommand { get; set; }

        public ViewAViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            UpdateCommand = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => FirstName).ObservesProperty(() => SecondName);
        }

        private bool CanExecute()
        {
            return !String.IsNullOrWhiteSpace(FirstName) && !String.IsNullOrWhiteSpace(SecondName);
        }

        private void Execute()
        {
            LastUpdated = DateTime.Now;

            _eventAggregator.GetEvent<UpdateEvent>().Publish(LastUpdated.ToString());
        }
    }
}
