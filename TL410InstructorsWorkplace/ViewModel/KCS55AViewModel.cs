using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class KCS55AViewModel : INPCBase
    {
        private double courseArrow;
        private double headingValue;
        private double courseShiftValue;
        private double glisShiftValue;
        private string noGlisValue;
        private string toIndicatorValue;
        private string fromIndicatorValue;

        private Parameter headingParameterValue;
        private Parameter courseShiftParameterValue;
        private Parameter glisShiftParameterValue;
        private Parameter noCourseParameterValue;
        private Parameter noGlisParameterValue;
        private Parameter vorIndicatorParameterValue;
        private Parameter modeParameterValue;
        private Parameter courseArrowParameterValue;

        #region Constructor
        public KCS55AViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("mode"))
            {
                modeParameter = Mediator.GetBufferedParameter("mode");
            }
            else
            {
                modeParameter = new Parameter("mode", 0);
            }
            if (Mediator.ContainsBufferedParameter("fkrs"))
            {
                noCourseParameter = Mediator.GetBufferedParameter("fkrs");
            }
            else
            {
                noCourseParameter = new Parameter("fkrs", 1);
            }
            if (Mediator.ContainsBufferedParameter("fgs"))
            {
                noGlisParameter = Mediator.GetBufferedParameter("fgs");
            }
            else
            {
                noGlisParameter = new Parameter("fgs", 1);
            }
            if (Mediator.ContainsBufferedParameter("car"))
            {
                courseArrowParameter = Mediator.GetBufferedParameter("car");
            }
            else
            {
                courseArrowParameter = new Parameter("car", 0);
            }
            if (Mediator.ContainsBufferedParameter("psi"))
            {
                headingParameter = Mediator.GetBufferedParameter("psi");
            }
            else
            {
                headingParameter = new Parameter("psi", 0);
            }
            if (Mediator.ContainsBufferedParameter("psii"))
            {
                courseShiftParameter = Mediator.GetBufferedParameter("psii");
            }
            else
            {
                courseShiftParameter = new Parameter("psii", 0);
            }
            if (Mediator.ContainsBufferedParameter("thi"))
            {
                glisShiftParameter = Mediator.GetBufferedParameter("thi");
            }
            else
            {
                glisShiftParameter = new Parameter("thi", 0);
            }
            if (Mediator.ContainsBufferedParameter("vor"))
            {
                vorIndicatorParameter = Mediator.GetBufferedParameter("vor");
                vorIndicatorParameterUpdate(vorIndicatorParameter);
            }
            else
            {
                vorIndicatorParameter = new Parameter("vor", 0);
                vorIndicatorParameterUpdate(vorIndicatorParameter);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion

        }
        #endregion

        #region Destructor
        ~KCS55AViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties
        private Parameter headingParameter
        {
            get { return headingParameterValue; }
            set
            {
                headingParameterValue = value;
                headingOutput = value.GetValueAsDouble();
            }
        }
        private Parameter courseShiftParameter
        {
            get { return courseShiftParameterValue; }
            set
            {
                courseShiftParameterValue = value;
                courseShiftOutput = value.GetValueAsDouble();
            }
        }
        private Parameter glisShiftParameter
        {
            get { return glisShiftParameterValue; }
            set
            {
                glisShiftParameterValue = value;
                glisShiftOutput = value.GetValueAsDouble();
            }
        }
        private Parameter noCourseParameter
        {
            get { return noCourseParameterValue; }
            set
            {
                noCourseParameterValue = value;
            }
        }
        private Parameter noGlisParameter
        {
            get { return noGlisParameterValue; }
            set
            {
                noGlisParameterValue = value;

            }
        }
       private Parameter vorIndicatorParameter
        {
            get { return vorIndicatorParameterValue; }
            set
            {
                vorIndicatorParameterValue = value;
            }
        }
        private Parameter modeParameter
        {
            get { return modeParameterValue; }
            set
            {
                modeParameterValue = value;
                if (value.GetValueAsInt() == 0)
                {
                    fromIndicatorOutput = "Hidden";
                    toIndicatorOutput = "Hidden";
                    noGlisOutput = "Visible";
                }
                else
                {
                    noGlisOutput = "Hidden";
                }
            }
        }
        private Parameter courseArrowParameter
        {
            get { return courseArrowParameterValue; }
            set
            {
                courseArrowParameterValue = value;
                courseArrow = value.GetValueAsDouble();
                courseArrowOutput = value.GetValueAsDouble();
            }
        }
        #endregion

        #region Output Values
        public double headingOutput
        {
            get { return headingValue; }
            set
            {
                headingValue = -value;
                OnPropertyChanged("headingOutput");
            }
        }
        public double courseShiftOutput
        {
            get { return courseShiftValue; }
            set
            {
                if (modeParameterValue.GetValueAsDouble() == 0)
                {
                    if (noCourseParameterValue.GetValueAsInt() == 0)
                    {
                        if (value > -3)
                        {
                            if (value < 3)
                            {
                                courseShiftValue = value * -16;
                            }
                            else
                            {
                                courseShiftValue = -48;
                            }
                        }
                        else
                        {
                            courseShiftValue = 48;
                        }
                    }
                    else
                    {
                        courseShiftValue = -48;
                    }
                }
                else
                {
                    
                    if (value > -10)
                    {
                        if (value < 10)
                        {
                            courseShiftValue = value * -4;
                        }
                        else
                        {
                            courseShiftValue = -40;
                        }
                    }
                    else
                    {
                        courseShiftValue = 40;
                    }

                }
                OnPropertyChanged("courseShiftOutput");
            }
        }
        public double glisShiftOutput
        {
            get { return glisShiftValue; }
            set
            {
                if (noGlisParameterValue.GetValueAsInt() == 0)
                {
                    if (value > -3)
                    {
                        if (value < 6)
                        {
                            glisShiftValue = value * -8;
                        }
                        else
                        {
                            glisShiftValue = -48;
                        }
                    }
                    else
                    {
                        glisShiftValue = 24;
                    }
                }
                else
                {
                    glisShiftValue = 24;
                }
                OnPropertyChanged("glisShiftOutput");
            }
        }
        public double courseArrowOutput
        {
            get { return courseArrow; }
            set
            {
                courseArrow = value;
                OnPropertyChanged("courseArrowOutput");
            }
        }
        public string noGlisOutput
        {
            get { return noGlisValue; }
            set
            {
                noGlisValue = value;
                OnPropertyChanged("noGlisOutput");
            }
        }
        public string toIndicatorOutput
        {
            get { return toIndicatorValue; }
            set
            {
                toIndicatorValue = value;
                OnPropertyChanged("toIndicatorOutput");
            }
        }
        public string fromIndicatorOutput
        {
            get { return fromIndicatorValue; }
            set
            {
                fromIndicatorValue = value;
                OnPropertyChanged("fromIndicatorOutput");
            }
        }
        #endregion

        #region Registration Area
        [MediatorMessageSink("mode")]
        private void modeParameterUpdate(object updateParameter)
        {
            modeParameter = (Parameter)updateParameter;            
        }
        [MediatorMessageSink("psi")]
        private void headingParameterUpdate(object updateParameter)
        {
            headingParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("thi")]
        private void glisShiftParameterUpdate(object updateParameter)
        {
            glisShiftParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("psii")]
        private void courseShiftParameterUpdate(object updateParameter)
        {
            if (modeParameter.GetValueAsInt() == 0)
            {
                courseShiftParameter = (Parameter)updateParameter;
            }
        }
        [MediatorMessageSink("fgs")]
        private void noGlisParameterUpdate(object updateParameter)
        {
            noGlisParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fkrs")]
        private void noCourseParameterUpdate(object updateParameter)
        {
            noCourseParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("car")]
        private void courseArrowParameterUpdate(object updateParameter)
        {
            courseArrowParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("vor")]
        private void vorIndicatorParameterUpdate(object updateParameter)
        {
            vorIndicatorParameter = (Parameter)updateParameter;
            if (modeParameterValue.GetValueAsInt() == 1)
            {
                noGlisOutput = "Hidden";
                double _value = vorIndicatorParameterValue.GetValueAsDouble();
                double value = vorIndicatorParameterValue.GetValueAsDouble();
                double _vorIndication = 0;
                if (value == 360)// I made a mistake and now all calculations in this propertie are starting from 0 to 359. Maybe sometimes later I will fix that.
                {
                    _value = 0;
                }

                #region to-from arrow property
                double _toFromIndicator = Math.Abs((360 + courseArrow) - (360 - _value));
                if ((_toFromIndicator > 90) && (_toFromIndicator < 270))
                {
                   fromIndicatorOutput = "Visible";
                   toIndicatorOutput = "Hidden";
                }
                else
                {
                    fromIndicatorOutput = "Hidden";
                    toIndicatorOutput = "Visible";
                }
                #endregion

                if (_value + courseArrow < -170)//&&(value+courseArrow > -190))
                {
                    if ((courseArrow < -350) && (_value < 10))
                    {
                        _vorIndication = (_value + 360) + courseArrow;//courseArrow has negative value
                        courseShiftOutput = -_vorIndication;
                    }
                    else
                    {
                        _vorIndication = _value + courseArrow + 180;//courseArrow has negative value
                        courseShiftOutput = _vorIndication;
                    }
                }
                else
                {
                    if (_value + courseArrow > 170)
                    {
                        if ((_value > 350) && (courseArrow > -10))
                        {
                            _vorIndication = (_value - 360) + courseArrow;//courseArrow has negative value
                            courseShiftOutput = (-_vorIndication);
                        }
                        else
                        {
                            _vorIndication = _value + courseArrow - 180;//courseArrow has negative value
                            courseShiftOutput = _vorIndication;
                        }
                    }
                    else
                    {
                        //if((courseArrow>-10)&&(value>350))
                        //{
                        //	_vorIndication = value+(courseArrow-360);//courseArrow has negative value
                        //	vor_shift(-_vorIndication);
                        //}
                        //else
                        //{
                        if ((_value + courseArrow > 170) && (courseArrow > -10))
                        {
                            _vorIndication = _value + courseArrow - 180;//courseArrow has negative value
                            courseShiftOutput = _vorIndication;
                        }
                        else
                        {

                            _vorIndication = _value + courseArrow;//courseArrow has negative value
                            courseShiftOutput = -_vorIndication;
                        }

                        //}
                    }
                }
            }
            else
            {
                fromIndicatorOutput = "Hidden";
                toIndicatorOutput = "Hidden";
                noGlisOutput = "Visible";
            }
        }

        #endregion

    }
}
