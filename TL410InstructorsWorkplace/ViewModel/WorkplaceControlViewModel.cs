using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;

namespace TL410InstructorsWorkplace.ViewModel
{
    class WorkplaceControlViewModel : INPCBase
    {
        public ICommand StartCommand { get; private set; }
        public ICommand RestartCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }

        private Parameter stateParameter;

        private string buttonState;


        public Parameter StateParameter
        {
            get
            {
                return stateParameter;
            }
            set
            {
                stateParameter = value;
                int check = value.GetValueAsInt();
                if (check == 0 || check == 2)
                {
                    ButtonState = "START";
                }
                else
                {
                    ButtonState = "PAUSE";
                }
            }
        }

        public string ButtonState
        {
            get
            {
                return buttonState;
            }
            set
            {
                buttonState = value;
                OnPropertyChanged("ButtonState");
            }
        }

        public WorkplaceControlViewModel()
        {
            StartCommand = new RelayCommand(Start);
            RestartCommand = new RelayCommand(Restart);
            ResetCommand = new RelayCommand(Reset);
            #region First start check
            if (Mediator.ContainsBufferedParameter("start"))
            {
                StateParameter = Mediator.GetBufferedParameter("start");
            }
            else
            {
                StateParameter = new Parameter("start", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }

        #region Destructor
        ~WorkplaceControlViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        private void Start(object parameter)
        {
            int check = StateParameter.GetValueAsInt();
            if (check == 2)
            {
                Mediator.Instance.NotifyColleagues<object>("start", new Parameter("start", 1));
                //Mediator.Instance.CommunicatorSend(new Parameter("start", 1));
            }
            else
            {
                if (check == 0)
                {
                    Mediator.Instance.NotifyColleagues<object>("start", new Parameter("start", 1));
                    //Mediator.Instance.CommunicatorSend(new Parameter("start", 1));
                }
                else
                {
                    Mediator.Instance.NotifyColleagues<object>("start", new Parameter("start", 2));
                    //Mediator.Instance.CommunicatorSend(new Parameter("start", 2));
                }
            }
        }

        private void Restart(object parameter)
        {
            Mediator.ClearBufferedParameters();
            Mediator.Instance.NotifyColleagues<object>("restart", new Parameter("restart", 1));
            //Mediator.Instance.CommunicatorSend(new Parameter("restart", 1));
        }

        private void Reset(object parameter)
        {
            Mediator.ClearBufferedParameters();
            Mediator.Instance.NotifyColleagues<object>("reset", new Parameter("reset", 1));
            // Mediator.Instance.CommunicatorSend(new Parameter("reset", 1));
        }

        #region Registration Area
        [MediatorMessageSink("start")]
        private void restartParameterUpdate(object updateParameter)
        {
            StateParameter = (Parameter)updateParameter;
        }
        #endregion
    }
}
