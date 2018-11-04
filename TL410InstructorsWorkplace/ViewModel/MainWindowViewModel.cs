using System;
using System.Windows.Controls;
using System.Windows.Input;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;

namespace TL410InstructorsWorkplace.ViewModel
{
    public class MainWindowViewModel : INPCBase
    {
        public ICommand SwitchViewsCommand { get; private set; }

        private UserControl _currentView;

        public UserControl CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                if (value != _currentView)
                {
                    _currentView = value;
                    OnPropertyChanged("CurrentView");
                }
            }
        }


        public MainWindowViewModel()
        {
            SwitchViewsCommand = new RelayCommand((parameter) => CurrentView = (UserControl)Activator.CreateInstance(parameter as Type));
            CurrentView = new View.Main();

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }

        #region Destructor
        ~MainWindowViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Registration Area
        [MediatorMessageSink("restart")]
        private void restartParameterUpdate(object updateParameter)
        {
            Parameter parameter = (Parameter)updateParameter;
            if (parameter.GetValueAsInt() == 1)
            {
                CurrentView = (UserControl)Activator.CreateInstance(CurrentView.GetType());
            }
        }
        [MediatorMessageSink("reset")]
        private void resetParameterUpdate(object updateParameter)
        {
            Parameter parameter = (Parameter)updateParameter;
            if (parameter.GetValueAsInt() == 1)
            {
                CurrentView = (UserControl)Activator.CreateInstance(CurrentView.GetType());
            }
        }
        #endregion
    }
}
