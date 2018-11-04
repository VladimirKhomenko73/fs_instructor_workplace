using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;

namespace TL410InstructorsWorkplace.ViewModel
{
    class Message
    {
        private string messageValue;
        private string messageColor;

        public string MessageValue
        {
            get { return messageValue; }
            set { messageValue = value; }
        }
        public string MessageColor { get { return messageColor; } set { messageColor = value; } }

        public Message()
        {
            messageValue = "";
            messageColor = "White";
        }
        public Message(string mValue, string mColor)
        {
            messageValue = mValue;
            messageColor = mColor;
        }
    }

    class CrashPanelViewModel : INPCBase
    {
        public ICommand panelPositionCommand { get; private set; }

        private int posX;

        private string warnLight;

        private string arrowSign;

        private ObservableCollection<Message> messageList;

        private ObservableCollection<Message> threadSafemessageList;

        private IDictionary<string, int> paramDictionary;

        public ObservableCollection<Message> MessageList { get { return threadSafemessageList; } }

        public string ArrowSign
        {
            get
            {
                return arrowSign;
            }
            set
            {
                arrowSign = value;
                OnPropertyChanged("ArrowSign");
            }
        }

        public CrashPanelViewModel()
        {
            panelPositionCommand = new RelayCommand(ChangePosition);

            messageList = new ObservableCollection<Message>();

            threadSafemessageList = new ObservableCollection<Message>();

            messageList.CollectionChanged += MessageList_CollectionChanged;

            paramDictionary = new Dictionary<string, int>
            {
                { "ftf1", 0},
                { "ftf2", 0},
                { "fuv1", 0},
                { "fuv2", 0},
                { "fvpo", 0},
                { "fvkl", 0},
                { "fv4",  0},
                { "fgmx", 0}
            };

            PosX = 0;

            ArrowSign = "<";

            WarnLight = "Transparent";

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }

        private void MessageList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Action<Message> method = threadSafemessageList.Add;
            System.Windows.Application.Current.Dispatcher.BeginInvoke(method,messageList.Last());
        }

        #region Destructor
        ~CrashPanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        public int PosX
        {
            get
            {
                return posX;
            }
            set
            {
                posX = value;
                OnPropertyChanged("PosX");
            }
        }

        public string WarnLight
        {
            get
            {
                return warnLight;
            }
            set
            {
                warnLight = value;
                OnPropertyChanged("WarnLight");
            }
        }

        #region Registration Area
        [MediatorMessageSink("ftf1")]
        private void leftTurbineOverheatParameterUpdate(object updateParameter)
        {
            string dependentParamName = "tmt1";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение ТМТ ({0}) левой турбины в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt())) 
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Значение ТМТ ({0}) левой турбины пришло в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));
            }
        }
        [MediatorMessageSink("ftf2")]
        private void rightTurbineOverheatParameterUpdate(object updateParameter)
        {
            string dependentParamName = "tmt2";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение ТМТ ({0}) правой турбины в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if ((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Значение ТМТ ({0}) правой турбины пришло в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));
            }            
        }
        [MediatorMessageSink("fuv1")]
        private void leftPropOverspeedParameterUpdate(object updateParameter)
        {
            string dependentParamName = "mk1";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение оборотов ({0}) левого винта в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if ((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Обороты ({0}) левого винта пришли в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));
            }               
        }
        [MediatorMessageSink("fuv2")]
        private void rightPropOverspeedParameterUpdate(object updateParameter)
        {
            string dependentParamName = "mk2";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение оборотов ({0}) правого винта в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if ((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Обороты ({0}) правого винта пришли в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));

            }
        }
        [MediatorMessageSink("fvpo")]
        private void gearsOverspeedParameterUpdate(object updateParameter)
        {
            string dependentParamName = "vp";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение скорости ({0}) с шасси в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if ((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Cкорость ({0}) с шасси пришла в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));
            }


        }
        [MediatorMessageSink("fvkl")]
        private void flapsOverspeedParameterUpdate(object updateParameter)
        {
            string dependentParamName = "vp";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение скорости ({0}) с закрылками в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if ((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Скорости ({0}) с закрылками пришла в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));
            }
        }
        [MediatorMessageSink("fv4")]
        private void OverspeedParameterUpdate(object updateParameter)
        {
            string dependentParamName = "vp";
            string dependentParamValue = "null";
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter(dependentParamName))
            {
                dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
            }
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение скорости ({0}) в {1} цикле!", dependentParamValue, cycleParam), "Gold"));
                WarnLight = "Gold";
            }
            else if ((param.GetValueAsInt() == 0) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Cкорости ({0}) пришла в норму в {1} цикле!", dependentParamValue, cycleParam), "YellowGreen"));
            }

        }
        [MediatorMessageSink("fgmx")]
        private void TakeoffOverweightParameterUpdate(object updateParameter)
        {
            string cycleParam = "null";
            Parameter param = (Parameter)updateParameter;
            if (Mediator.ContainsBufferedParameter("cc"))
            {
                cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
            }
            if ((param.GetValueAsInt() == 1) && (paramDictionary[param.GetName()] != param.GetValueAsInt()))
            {
                paramDictionary[param.GetName()] = param.GetValueAsInt();
                messageList.Add(new Message(String.Format("ВНИМАНИЕ: Превышение веса при взлёте в {0} цикле!", cycleParam), "Gold"));
                WarnLight = "Gold";
            }
        }
        [MediatorMessageSink("fout")]
        private void OutOfRunwayParameterUpdate(object updateParameter)
        {
            Parameter param = (Parameter)updateParameter;
            if (param.GetValueAsDouble() != 0)
            {
                string cycleParam = "null";
                if (Mediator.ContainsBufferedParameter("cc"))
                {
                    cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
                }
                messageList.Add(new Message(String.Format("АВАРИЯ: Посадка вне полосы в {1} цикле!", cycleParam), "Red"));
                WarnLight = "Red";
            }
        }
        [MediatorMessageSink("fbpo")]
        private void LandingWithGearsUpParameterUpdate(object updateParameter)
        {
            Parameter param = (Parameter)updateParameter;
            if (param.GetValueAsDouble() != 0)
            {
                string cycleParam = "null";
                if (Mediator.ContainsBufferedParameter("cc"))
                {
                    cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
                }
                messageList.Add(new Message(String.Format("АВАРИЯ: Посадка без шасси в {1} цикле!", cycleParam), "Red"));
                WarnLight = "Red";
            }
        }
        [MediatorMessageSink("fvy4")]
        private void HighLandingVerticalSpeedParameterUpdate(object updateParameter)
        {
            Parameter param = (Parameter)updateParameter;
            if (param.GetValueAsDouble() != 0)
            {
                string dependentParamName = "vy";
                string dependentParamValue = "null";
                string cycleParam = "null";
                if (Mediator.ContainsBufferedParameter(dependentParamName))
                {
                    dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
                }
                if (Mediator.ContainsBufferedParameter("cc"))
                {
                    cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
                }
                messageList.Add(new Message(String.Format("АВАРИЯ: Превышение вертикальной скорости ({0}) при посадке в {1} цикле!", dependentParamValue, cycleParam), "Red"));
                WarnLight = "Red";
            }
        }
        [MediatorMessageSink("fgam")]
        private void LandingWingCrashParameterUpdate(object updateParameter)
        {
            Parameter param = (Parameter)updateParameter;
            if (param.GetValueAsDouble() != 0)
            {
                string dependentParamName = "gam";
                string dependentParamValue = "null";
                string cycleParam = "null";
                if (Mediator.ContainsBufferedParameter(dependentParamName))
                {
                    dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
                }
                if (Mediator.ContainsBufferedParameter("cc"))
                {
                    cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
                }
                messageList.Add(new Message(String.Format("АВАРИЯ: Удар крылом (крен {0}) при посадке в {1} цикле!", dependentParamValue, cycleParam), "Red"));
                WarnLight = "Red";
            }
        }
        [MediatorMessageSink("fthh")]
        private void LandingTailCrashParameterUpdate(object updateParameter)
        {
            Parameter param = (Parameter)updateParameter;
            if (param.GetValueAsDouble() != 0)
            {
                string dependentParamName = "th";
                string dependentParamValue = "null";
                string cycleParam = "null";
                if (Mediator.ContainsBufferedParameter(dependentParamName))
                {
                    dependentParamValue = Mediator.GetBufferedParameter(dependentParamName).GetValueAsString();
                }
                if (Mediator.ContainsBufferedParameter("cc"))
                {
                    cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
                }
                messageList.Add(new Message(String.Format("АВАРИЯ: Удар хвостом (тангаж {0}) при посадке в {1} цикле!", dependentParamValue, cycleParam), "Red"));
                WarnLight = "Red";
            }
        }
        [MediatorMessageSink("fgh")]
        private void LandingOverweightParameterUpdate(object updateParameter)
        {
            Parameter param = (Parameter)updateParameter;
            if (param.GetValueAsDouble() != 0)
            {
                string cycleParam = "null";
                if (Mediator.ContainsBufferedParameter("cc"))
                {
                    cycleParam = Mediator.GetBufferedParameter("cc").GetValueAsString();
                }
                messageList.Add(new Message(String.Format("АВАРИЯ: Превышение веса при посадке в {0} цикле", cycleParam), "Red"));
                WarnLight = "Red";
            }
        }
        [MediatorMessageSink("restart")]
        private void restartParameterUpdate(object updateParameter)
        {
            Parameter parameter = (Parameter)updateParameter;
            if (parameter.GetValueAsInt() == 1)
            {
                MessageList.Clear();
                WarnLight = "Transparent";
            }
        }
        [MediatorMessageSink("reset")]
        private void resetParameterUpdate(object updateParameter)
        {
            Parameter parameter = (Parameter)updateParameter;
            if (parameter.GetValueAsInt() == 1)
            {
                MessageList.Clear();
                WarnLight = "Transparent";
            }
        }
        #endregion

        private void ChangePosition(object obj)
        {
            if (PosX < 0)
            {
                PosX = 0;
                ArrowSign = "<";
                WarnLight = "Transparent";
            }
            else
            {
                PosX = -245;
                ArrowSign = ">";
                WarnLight = "Transparent";
            }
        }
    }
}
