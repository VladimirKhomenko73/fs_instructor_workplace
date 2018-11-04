using System;
using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;

namespace TL410InstructorsWorkplace.ViewModel
{
    class ControlsVisualizationViewModel : INPCBase
    {
        #region Parameter value
        private Parameter delvParameterValue;
        private Parameter delkParameterValue;
        private Parameter delsParameterValue;

        private Parameter depLParameterValue;
        private Parameter depRParameterValue;
        private Parameter devLParameterValue;
        private Parameter devRParameterValue;

        private Parameter brkLParameterValue;
        private Parameter brkRParameterValue;
        #endregion

        #region Output value
        private double delvValue;
        private double delkValue;
        private double delsLValue;
        private double delsRValue;

        private double depLValue;
        private double depRValue;
        private double devLValue;
        private double devRValue;

        private int depLDigitValue;
        private int depRDigitValue;
        private int devLDigitValue;
        private int devRDigitValue;
        private int brkLValue;
        private int brkRValue;
        #endregion

        #region Constructor
        public ControlsVisualizationViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("dep1"))
            {
                depLParameter = Mediator.GetBufferedParameter("dep1");
            }
            else
            {
                depLParameter = new Parameter("dep1", 0);
            }
            if (Mediator.ContainsBufferedParameter("dep2"))
            {
                depRParameter = Mediator.GetBufferedParameter("dep2");
            }
            else
            {
                depRParameter = new Parameter("dep2", 0);
            }
            if (Mediator.ContainsBufferedParameter("dev1"))
            {
                devLParameter = Mediator.GetBufferedParameter("dev1");
            }
            else
            {
                devLParameter = new Parameter("dev1", 0);
            }
            if (Mediator.ContainsBufferedParameter("dev2"))
            {
                devRParameter = Mediator.GetBufferedParameter("dev2");
            }
            else
            {
                devRParameter = new Parameter("dev2", 0);
            }
            if (Mediator.ContainsBufferedParameter("delv"))
            {
                delvParameter = Mediator.GetBufferedParameter("delv");
            }
            else
            {
                delvParameter = new Parameter("delv", 0);
            }
            if (Mediator.ContainsBufferedParameter("delk"))
            {
                delkParameter = Mediator.GetBufferedParameter("delk");
            }
            else
            {
                delkParameter = new Parameter("delk", 0);
            }
            if (Mediator.ContainsBufferedParameter("dels"))
            {
                delsParameter = Mediator.GetBufferedParameter("dels");
            }
            else
            {
                delsParameter = new Parameter("dels", 0);
            }
            if (Mediator.ContainsBufferedParameter("pi1"))
            {
                brkLParameter = Mediator.GetBufferedParameter("pi1");
            }
            else
            {
                brkLParameter = new Parameter("pi1", 0);
            }
            if (Mediator.ContainsBufferedParameter("pi2"))
            {
                brkRParameter = Mediator.GetBufferedParameter("pi2");
            }
            else
            {
                brkRParameter = new Parameter("pi2", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }

        #endregion

        #region Destructor
        ~ControlsVisualizationViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties
        private Parameter depLParameter
        {
            get { return depLParameterValue; }
            set
            {
                depLParameterValue = value;
                depLOutput = value.GetValueAsInt();
                depLDigitOutput = value.GetValueAsInt();
            }
        }
        private Parameter depRParameter
        {
            get { return depRParameterValue; }
            set
            {
                depRParameterValue = value;
                depROutput = value.GetValueAsDouble();
                depRDigitOutput = value.GetValueAsInt();
            }
        }
        private Parameter devLParameter
        {
            get { return devLParameterValue; }
            set
            {
                devLParameterValue = value;
                devLOutput = value.GetValueAsDouble();
                devLDigitOutput = value.GetValueAsInt();
            }
        }
        private Parameter devRParameter
        {
            get { return devRParameterValue; }
            set
            {
                devRParameterValue = value;
                devROutput = value.GetValueAsDouble();
                devRDigitOutput = value.GetValueAsInt();
            }
        }
        private Parameter delvParameter
        {
            get { return delvParameterValue; }
            set
            {
                delvParameterValue = value;
                delvOutput = value.GetValueAsDouble();
            }
        }
        private Parameter delkParameter
        {
            get { return delkParameterValue; }
            set
            {
                delkParameterValue = value;
                delkOutput = value.GetValueAsDouble();
            }
        }
        private Parameter delsParameter
        {
            get { return delsParameterValue; }
            set
            {
                delsParameterValue = value;
                delsLOutput = value.GetValueAsDouble();
                delsROutput = value.GetValueAsDouble();
            }
        }
        private Parameter brkLParameter
        {
            get { return brkLParameterValue; }
            set
            {
                brkLParameterValue = value;
                brkLOutput = value.GetValueAsInt();

            }
        }
        private Parameter brkRParameter
        {
            get { return brkRParameterValue; }
            set
            {
                brkRParameterValue = value;
                brkROutput = value.GetValueAsInt();

            }
        }
        #endregion

        #region Output Values
        public double depLOutput
        {
            get { return depLValue; }
            set
            {
                if (value > 0)
                {
                    depLValue = value * -0.7;
                }
                else
                {
                    depLValue = value * -0.42;
                }
                OnPropertyChanged("depLOutput");
            }
        }
        public double depROutput
        {
            get { return depRValue; }
            set
            {
                if (value > 0)
                {
                    depRValue = value * -0.7;
                }
                else
                {
                    depRValue = value * -0.42;
                }
                OnPropertyChanged("depROutput");
            }
        }
        public double devLOutput
        {
            get { return devLValue; }
            set
            {
                if (value > 0)
                {
                    devLValue = value * -0.7;
                }
                else
                {
                    devLValue = value * -0.42;
                }
                OnPropertyChanged("devLOutput");
            }
        }
        public double devROutput
        {
            get { return devRValue; }
            set
            {
                if (value > 0)
                {
                    devRValue = value * -0.7;
                }
                else
                {
                    devRValue = value * -0.42;
                }
                OnPropertyChanged("devROutput");
            }
        }
        public double delvOutput
        {
            get { return delvValue; }
            set
            {
                delvValue = value * 1.875;
                OnPropertyChanged("delvOutput");
            }
        }
        public double delkOutput
        {
            get { return delkValue; }
            set
            {
                delkValue = value * 3.33;
                OnPropertyChanged("delkOutput");
            }
        }
        public double delsLOutput
        {
            get { return delsLValue; }
            set
            {
                delsLValue = value * -0.95;
                OnPropertyChanged("delsLOutput");
            }
        }
        public double delsROutput
        {
            get { return delsRValue; }
            set
            {
                delsRValue = value * 0.95;
                OnPropertyChanged("delsROutput");
            }
        }
        public int depLDigitOutput
        {
            get { return depLDigitValue; }
            set
            {
                depLDigitValue = value;
                OnPropertyChanged("depLDigitOutput");
            }
        }
        public int depRDigitOutput
        {
            get { return depRDigitValue; }
            set
            {
                depRDigitValue = value;
                OnPropertyChanged("depRDigitOutput");
            }
        }
        public int devLDigitOutput
        {
            get { return devLDigitValue; }
            set
            {
                devLDigitValue = value;
                OnPropertyChanged("devLDigitOutput");
            }
        }
        public int devRDigitOutput
        {
            get { return devRDigitValue; }
            set
            {
                devRDigitValue = value;
                OnPropertyChanged("devRDigitOutput");
            }
        }
        public int brkLOutput
        {
            get { return brkLValue; }
            set
            {
                brkLValue = value;
                OnPropertyChanged("brkLOutput");
            }
        }
        public int brkROutput
        {
            get { return brkRValue; }
            set
            {
                brkRValue = value;
                OnPropertyChanged("brkROutput");
            }
        }
        #endregion

        #region Registration Area
        [MediatorMessageSink("dep1")]
        private void depLParameterUpdate(object updateParameter)
        {
            depLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("dep2")]
        private void depRParameterUpdate(object updateParameter)
        {
            depRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("dev1")]
        private void devLParameterUpdate(object updateParameter)
        {
            devLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("dev2")]
        private void devRParameterUpdate(object updateParameter)
        {
            devRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("delv")]
        private void delvParameterUpdate(object updateParameter)
        {
            delvParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("delk")]
        private void delkParameterUpdate(object updateParameter)
        {
            delkParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("dels")]
        private void delsParameterUpdate(object updateParameter)
        {
            delsParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("pi1")]
        private void brkLParameterUpdate(object updateParameter)
        {
            brkLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("pi2")]
        private void brkRParameterUpdate(object updateParameter)
        {
            brkRParameter = (Parameter)updateParameter;
        }
        #endregion


    }
}
