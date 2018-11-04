using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;


namespace TL410InstructorsWorkplace.ViewModel
{
    class IKUViewModel : INPCBase
    {
        private double IKUBearing1;
        private double IKUBearing2;
        private double IKUHeading;

        private Parameter IKUBearing1ParameterValue;
        private Parameter IKUBearing2ParameterValue;
        private Parameter IKUHeadingParameterValue;

        #region Constructor
        public IKUViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("psr1"))
            {
                IKUBearing1Parameter = Mediator.GetBufferedParameter("psr1");
            }
            else
            {
                IKUBearing1Parameter = new Parameter("psr1", 0);
            }
            if (Mediator.ContainsBufferedParameter("psr2"))
            {
                IKUBearing2Parameter = Mediator.GetBufferedParameter("psr2");
            }
            else
            {
                IKUBearing2Parameter = new Parameter("psr2", 0);
            }
            if (Mediator.ContainsBufferedParameter("psi"))
            {
                IKUHeadingParameter = Mediator.GetBufferedParameter("psi");
            }
            else
            {
                IKUHeadingParameter = new Parameter("psi", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~IKUViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties

        private Parameter IKUBearing1Parameter
        {
            get { return IKUBearing1ParameterValue; }
            set
            {
                IKUBearing1ParameterValue = value;
                IKUBearing1Angle = value.GetValueAsInt();
            }
        }

        private Parameter IKUBearing2Parameter
        {
            get { return IKUBearing2ParameterValue; }
            set
            {
                IKUBearing2ParameterValue = value;
                IKUBearing2Angle = value.GetValueAsInt();
            }
        }

        private Parameter IKUHeadingParameter
        {
            get { return IKUHeadingParameterValue; }
            set
            {
                IKUHeadingParameterValue = value;
                IKUHeadingAngle = value.GetValueAsInt();
            }
        }
        #endregion

        #region Angle Values
        public double IKUBearing1Angle
        {
            get { return IKUBearing1; }
            set
            {
                double calibratedValue = value;
                if (calibratedValue < 0)
                {
                    calibratedValue = 360 + value;
                }
                IKUBearing1 = -calibratedValue;
                OnPropertyChanged("IKUBearing1Angle");
            }
        }
        public double IKUBearing2Angle
        {
            get { return IKUBearing2; }
            set
            {
                double calibratedValue = value;
                if (calibratedValue < 0)
                {
                    calibratedValue = 360 + value;
                }
                IKUBearing2 = -calibratedValue;
                OnPropertyChanged("IKUBearing2Angle");
            }
        }
        public double IKUHeadingAngle
        {
            get { return IKUHeading; }
            set
            {
                IKUHeading = -value;
                OnPropertyChanged("IKUHeadingAngle");
            }
        }
        #endregion

        #region Registration Area

        [MediatorMessageSink("psr1")]
        private void IKUBearing1ParameterUpdate(object updateParameter)
        {
            IKUBearing1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("psr2")]
        private void IKUBearing2ParameterUpdate(object updateParameter)
        {
            IKUBearing2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("psi")]
        private void IKUHeadingParameterUpdate(object updateParameter)
        {
            IKUHeadingParameter = (Parameter)updateParameter;
        }
        #endregion
    }
}
