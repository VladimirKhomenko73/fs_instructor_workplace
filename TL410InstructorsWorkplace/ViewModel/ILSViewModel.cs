using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class ILSViewModel : INPCBase
    {
        private double ILSCourseShiftValue;
        private double ILSGlisShiftValue;
        private string ILSNoCourseValue;
        private string ILSNoGlisValue;
        private string ILSOuterMarkerValue;
        private string ILSMiddleMarkerValue;
        private string ILSInnerMarkerValue;

        private Parameter ILSCourseShiftParameterValue;
        private Parameter ILSGlisShiftParameterValue;
        private Parameter ILSNoCourseParameterValue;
        private Parameter ILSNoGlisParameterValue;
        private Parameter ILSOuterMarkerParameterValue;
        private Parameter ILSMiddleMarkerParameterValue;
        private Parameter ILSInnerMarkerParameterValue;

        #region Constructor
        public ILSViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("fkrs"))
            {
                ILSNoCourseParameter = Mediator.GetBufferedParameter("fkrs");
            }
            else
            {
                ILSNoCourseParameter = new Parameter("fkrs", 1);
            }
            if (Mediator.ContainsBufferedParameter("fgs"))
            {
                ILSNoGlisParameter = Mediator.GetBufferedParameter("fgs");
            }
            else
            {
                ILSNoGlisParameter = new Parameter("fgs", 1);
            }
            if (Mediator.ContainsBufferedParameter("psii"))
            {
                ILSCourseShiftParameter = Mediator.GetBufferedParameter("psii");
            }
            else
            {
                ILSCourseShiftParameter = new Parameter("psii", 0);
            }
            if (Mediator.ContainsBufferedParameter("thi"))
            {
                ILSGlisShiftParameter = Mediator.GetBufferedParameter("thi");
            }
            else
            {
                ILSGlisShiftParameter = new Parameter("thi", 0);
            }
            if (Mediator.ContainsBufferedParameter("mrd"))
            {
                ILSOuterMarkerParameter = Mediator.GetBufferedParameter("mrd");
            }
            else
            {
                ILSOuterMarkerParameter = new Parameter("mrd", 0);
            }
            if (Mediator.ContainsBufferedParameter("fmrt"))
            {
                ILSMiddleMarkerParameter = Mediator.GetBufferedParameter("fmrt");
            }
            else
            {
                ILSMiddleMarkerParameter = new Parameter("fmrt", 0);
            }
            if (Mediator.ContainsBufferedParameter("mrb"))
            {
                ILSInnerMarkerParameter = Mediator.GetBufferedParameter("mrb");
            }
            else
            {
                ILSInnerMarkerParameter = new Parameter("mrb", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion

        }
        #endregion

        #region Destructor
        ~ILSViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties
        private Parameter ILSCourseShiftParameter
        {
            get { return ILSCourseShiftParameterValue; }
            set
            {
                ILSCourseShiftParameterValue = value;
                ILSCourseShiftOutput = value.GetValueAsDouble();
            }
        }
        private Parameter ILSGlisShiftParameter
        {
            get { return ILSGlisShiftParameterValue; }
            set
            {
                ILSGlisShiftParameterValue = value;
                ILSGlisShiftOutput = value.GetValueAsDouble();
            }
        }
        private Parameter ILSNoCourseParameter
        {
            get { return ILSNoCourseParameterValue; }
            set
            {
                ILSNoCourseParameterValue = value;
                if (ILSNoCourseParameterValue.GetValueAsInt() == 1)
                {
                    ILSNoCourseOutput = "Visible";
                }
                else
                {
                    ILSNoCourseOutput = "Hidden";
                }
            }
        }
        private Parameter ILSNoGlisParameter
        {
            get { return ILSNoGlisParameterValue; }
            set
            {
                ILSNoGlisParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ILSNoGlisOutput = "Visible";
                }
                else
                {
                    ILSNoGlisOutput = "Hidden";
                }
            }
        }
        private Parameter ILSOuterMarkerParameter
        {
            get { return ILSOuterMarkerParameterValue; }
            set
            {
                ILSOuterMarkerParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ILSOuterMarkerOutput = "Visible";
                }
                else
                {
                    ILSOuterMarkerOutput = "Hidden";
                }
            }
        }
        private Parameter ILSMiddleMarkerParameter
        {
            get { return ILSMiddleMarkerParameterValue; }
            set
            {
                ILSMiddleMarkerParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ILSMiddleMarkerOutput = "Visible";
                }
                else
                {
                    ILSMiddleMarkerOutput = "Hidden";
                }
            }
        }
        private Parameter ILSInnerMarkerParameter
        {
            get { return ILSInnerMarkerParameterValue; }
            set
            {
                ILSInnerMarkerParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ILSInnerMarkerOutput = "Visible";
                }
                else
                {
                    ILSInnerMarkerOutput = "Hidden";
                }
            }
        }
        #endregion

        #region Output Values
        public double ILSCourseShiftOutput
        {
            get { return ILSCourseShiftValue; }
            set
            {
                if (ILSNoCourseParameterValue.GetValueAsBool() == false)
                {
                    if (value > -12)
                    {
                        if (value > 12)
                        {
                            ILSCourseShiftValue = -58;
                        }
                        else
                        {
                            ILSCourseShiftValue = value * -4.83;
                        }
                    }
                    else
                    {
                        ILSCourseShiftValue = 58;
                    }
                }
                else
                {
                    ILSCourseShiftValue = -58;
                }
                OnPropertyChanged("ILSCourseShiftOutput");
            }
        }
        public double ILSGlisShiftOutput
        {
            get { return ILSGlisShiftValue; }
            set
            {
                if (ILSNoGlisParameterValue.GetValueAsBool() == false)
                {
                    if (value > -12)
                    {
                        if (value > 12)
                        {
                            ILSGlisShiftValue = -58;
                        }
                        else
                        {
                            ILSGlisShiftValue = value * -4.83;
                        }
                    }
                    else
                    {
                        ILSGlisShiftValue = 58;
                    }
                }
                else
                {
                    ILSGlisShiftValue = 58;
                }
                OnPropertyChanged("ILSGlisShiftOutput");
            }
        }

        public string ILSNoCourseOutput
        {
            get { return ILSNoCourseValue; }
            set
            {
                ILSNoCourseValue = value;
                OnPropertyChanged("ILSNoCourseOutput");
            }
        }
        public string ILSNoGlisOutput
        {
            get { return ILSNoGlisValue; }
            set
            {
                ILSNoGlisValue = value;
                OnPropertyChanged("ILSNoGlisOutput");
            }
        }
        public string ILSOuterMarkerOutput
        {
            get { return ILSOuterMarkerValue; }
            set
            {
                ILSOuterMarkerValue = value;
                OnPropertyChanged("ILSOuterMarkerOutput");
            }
        }
        public string ILSMiddleMarkerOutput
        {
            get { return ILSMiddleMarkerValue; }
            set
            {
                ILSMiddleMarkerValue = value;
                OnPropertyChanged("ILSMiddleMarkerOutput");
            }
        }
        public string ILSInnerMarkerOutput
        {
            get { return ILSInnerMarkerValue; }
            set
            {
                ILSInnerMarkerValue = value;
                OnPropertyChanged("ILSInnerMarkerOutput");
            }
        }
        #endregion

        #region Registration Area

        [MediatorMessageSink("psii")]
        private void ILSCourseShiftParameterUpdate(object updateParameter)
        {
            ILSCourseShiftParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("thi")]
        private void ILSGlisShiftParameterUpdate(object updateParameter)
        {
            ILSGlisShiftParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fkrs")]
        private void ILSNoCourseParameterUpdate(object updateParameter)
        {
            ILSNoCourseParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fgs")]
        private void ILSNoGlisParameterUpdate(object updateParameter)
        {
            ILSNoGlisParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("mrd")]
        private void ILSOuterMarkerParameterUpdate(object updateParameter)
        {
            ILSOuterMarkerParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fmrt")]
        private void ILSMiddleMarkerParameterUpdate(object updateParameter)
        {
            ILSMiddleMarkerParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("mrb")]
        private void ILSInnerMarkerParameterUpdate(object updateParameter)
        {
            ILSInnerMarkerParameter = (Parameter)updateParameter;
        }
        #endregion
    }
}