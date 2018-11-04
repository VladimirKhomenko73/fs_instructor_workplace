using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class VD10KViewModel : INPCBase
    {
        private int PilotPressureValue;
        private double VD10KAltitudeKmValue;
        private double VD10KAltitudeMetValue;

        private Parameter VD10KPressureParameterValue;
        private Parameter VD10KAltitudeParameterValue;
        private Parameter PilotPressureParameterValue;

        #region Constructor
        public VD10KViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("depa"))
            {
                VD10KPressureParameter = Mediator.GetBufferedParameter("depa");
            }
            else
            {
                VD10KPressureParameter = new Parameter("depa", 760);
            }
            if (Mediator.ContainsBufferedParameter("ap1"))
            {
                PilotPressureParameter = Mediator.GetBufferedParameter("ap1");
            }
            else
            {
                PilotPressureParameter = new Parameter("ap1", 670);
            }
            if (Mediator.ContainsBufferedParameter("h"))
            {
                VD10KAltitudeParameter = Mediator.GetBufferedParameter("h");
            }
            else
            {
                VD10KAltitudeParameter = new Parameter("h", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~VD10KViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties

        private Parameter VD10KPressureParameter
        {
            get { return VD10KPressureParameterValue; }
            set
            {
                VD10KPressureParameterValue = value;                
            }
        }

        private Parameter VD10KAltitudeParameter
        {
            get { return VD10KAltitudeParameterValue; }
            set
            {
                VD10KAltitudeParameterValue = value;
                VD10KAltitudeKmAngle = value.GetValueAsDouble();
                VD10KAltitudeMetAngle = value.GetValueAsDouble();
            }
        }

        private Parameter PilotPressureParameter
        {
            get { return PilotPressureParameterValue; }
            set
            {
                PilotPressureParameterValue = value;
                PilotPressureOutput = value.GetValueAsInt();
            }
        }
        #endregion

        #region Angle Values
        public double VD10KAltitudeKmAngle
        {
            get { return VD10KAltitudeKmValue; }
            set
            {
                VD10KAltitudeKmValue = (value + ((PilotPressureValue - VD10KPressureParameterValue.GetValueAsInt()) * 11)) * 0.036;
                OnPropertyChanged("VD10KAltitudeKmAngle");
            }
        }

        public double VD10KAltitudeMetAngle
        {
            get { return VD10KAltitudeMetValue; }
            set
            {
                VD10KAltitudeMetValue = (value  + ((PilotPressureValue - VD10KPressureParameterValue.GetValueAsInt())*11)) * 0.36;
                OnPropertyChanged("VD10KAltitudeMetAngle");
            }
        }
        #endregion

        #region Output Values
        public int PilotPressureOutput
        {
            get { return PilotPressureValue; }
            set
            {
                PilotPressureValue = value;
                OnPropertyChanged("PilotPressureOutput");
            }
        }
        #endregion

        #region Registration Area

        [MediatorMessageSink("depa")]
        private void VD10KPressureParameterUpdate(object updateParameter)
        {
            VD10KPressureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ap1")]
        private void PilotPressureParameterUpdate(object updateParameter)
        {
            PilotPressureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("h")]
        private void VD10KAltitudeParameterUpdate(object updateParameter)
        {
            VD10KAltitudeParameter = (Parameter)updateParameter;
        }
        #endregion

    }
}
