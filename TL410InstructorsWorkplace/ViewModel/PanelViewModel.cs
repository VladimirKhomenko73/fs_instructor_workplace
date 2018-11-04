using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    public class PanelViewModel : INPCBase
    {
        private double pitchValue;
        private double rollValue;
        private double speedValue;
        private double vSpeedValue;
        private double ballSlideValue;
        private double dme1Value;
        private double dme2Value;
        private int radioAttValue;

        private Parameter pitchParameterValue;
        private Parameter rollParameterValue;
        private Parameter speedParameterValue;
        private Parameter vSpeedParameterValue;
        private Parameter ballSlideParameterValue;
        private Parameter dme1ParameterValue;
        private Parameter dme2ParameterValue;
        private Parameter radioAttParameterValue;

        #region Constructor
        public PanelViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("th"))
            {
                pitchParameter = Mediator.GetBufferedParameter("th");
            }
            else
            {
                pitchParameter = new Parameter("th", 0);
            }

            if (Mediator.ContainsBufferedParameter("gam"))
            {
                rollParameter = Mediator.GetBufferedParameter("gam");
            }
            else
            {
                rollParameter = new Parameter("gam", 0);
            }

            if (Mediator.ContainsBufferedParameter("alku"))
            {
                ballSlideParameter = Mediator.GetBufferedParameter("alku");
            }
            else
            {
                ballSlideParameter = new Parameter("alku", 0);
            }

            if (Mediator.ContainsBufferedParameter("vp"))
            {
                speedParameter = Mediator.GetBufferedParameter("vp");
            }
            else
            {
                speedParameter = new Parameter("vp", 0);
            }

            if (Mediator.ContainsBufferedParameter("vy"))
            {
                vSpeedParameter = Mediator.GetBufferedParameter("vy");
            }
            else
            {
                vSpeedParameter = new Parameter("vy", 0);
            }

            if (Mediator.ContainsBufferedParameter("dme"))
            {
                dme1Parameter = Mediator.GetBufferedParameter("dme");
            }
            else
            {
                dme1Parameter = new Parameter("dme", 0);
            }
            if (Mediator.ContainsBufferedParameter("dme"))
            {
                dme2Parameter = Mediator.GetBufferedParameter("dme");
            }
            else
            {
                dme2Parameter = new Parameter("dme", 0);
            }
             if (Mediator.ContainsBufferedParameter("h1"))
            {
                radioAttParameter = Mediator.GetBufferedParameter("h1");
            }
            else
            {
                radioAttParameter = new Parameter("h1", 0);
            }


            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~PanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties
        private Parameter pitchParameter
        {
            get { return pitchParameterValue; }
            set
            {
                pitchParameterValue = value;
                Pitch = value.GetValueAsDouble();

            }
        }

        private Parameter rollParameter
        {
            get { return rollParameterValue; }
            set
            {
                rollParameterValue = value;
                Roll = value.GetValueAsDouble();
            }
        }

        private Parameter ballSlideParameter
        {
            get { return ballSlideParameterValue; }
            set
            {
                ballSlideParameterValue = value;
                BallSlide = value.GetValueAsDouble();
            }
        }

        private Parameter speedParameter
        {
            get { return speedParameterValue; }
            set
            {
                speedParameterValue = value;
                Speed = value.GetValueAsDouble();
            }
        }

        private Parameter vSpeedParameter
        {
            get { return vSpeedParameterValue; }
            set
            {
                vSpeedParameterValue = value;
                VSpeed = value.GetValueAsDouble();
            }
        }

        private Parameter dme1Parameter
        {
            get { return dme1ParameterValue; }
            set
            {
                dme1ParameterValue = value;
                DME1 = value.GetValueAsDouble();
            }
        }
        private Parameter dme2Parameter
        {
            get { return dme2ParameterValue; }
            set
            {
                dme2ParameterValue = value;
                DME2 = value.GetValueAsDouble();
            }
        }
        private Parameter radioAttParameter
        {
            get { return radioAttParameterValue; }
            set
            {
                radioAttParameterValue = value;
                RADIOATT = value.GetValueAsInt();
            }
        }


        public double Pitch
        {
            get { return pitchValue; }
            set
            {
                pitchValue = value;
                OnPropertyChanged("Pitch");
            }
        }

        public double Roll
        {
            get { return rollValue; }
            set
            {
                rollValue = -value;
                OnPropertyChanged("Roll");
            }
        }

        public double BallSlide
        {
            get { return ballSlideValue; }
            set
            {
                if (value > -0.305)
                {
                    if (value > 0.305)
                    {
                        ballSlideValue = 9;
                    }
                    else
                    {
                        ballSlideValue = value / 0.034;
                    }
                }
                else
                {
                    ballSlideValue = -9;
                }
                OnPropertyChanged("BallSlide");
            }
        }

        public double Speed
        {
            get { return speedValue; }
            set
            {
                if (value > 50)
                {
                    if (value > 100)
                    {
                        if (value > 150)
                        {
                            speedValue = 78 + ((value - 150) / 10) * 9;
                        }
                        else
                        {
                            speedValue = 38 + ((value - 100) / 10) * 8;
                        }

                    }
                    else
                    {
                        speedValue = 13 + (value - 50) / 2;
                    }
                }
                else
                {
                    speedValue = value * 0.24;
                }

                OnPropertyChanged("Speed");
            }
        }

        public double VSpeed
        {
            get { return vSpeedValue; }
            set
            {
                if (value > 0)
                {
                    if (value > 10)
                    {
                        if (value > 20)
                        {
                            vSpeedValue = 140 + ((value - 20) * 4);
                        }
                        else
                        {
                            vSpeedValue = 100 + ((value - 10) * 4);
                        }
                    }
                    else
                    {
                        vSpeedValue = (value * 10);
                    }
                }
                else
                {
                    if (value < -10)
                    {
                        if (value < -20)
                        {
                            vSpeedValue = -140 - ((-value - 20) * 4);
                        }
                        else
                        {
                            vSpeedValue = 100 + ((-value - 10) * 4);
                            vSpeedValue = -100 - ((-value - 10) * 4);
                        }
                    }
                    else
                    {
                        vSpeedValue = (value * 10);
                    }
                }

                OnPropertyChanged("VSpeed");
            }
        }

        public double DME1
        {
            get { return dme1Value; }
            set
            {
                dme1Value = value;
                OnPropertyChanged("DME1");
            }
        }

        public double DME2
        {
            get { return dme2Value; }
            set
            {
                dme2Value = value;
                OnPropertyChanged("DME2");
            }
        }

        public int RADIOATT
        {
            get { return radioAttValue; }
            set
            {
                radioAttValue = value;
                OnPropertyChanged("RADIOATT");
            }
        }

        #endregion

        #region Registration Area
        [MediatorMessageSink("th")]
        private void ngLParameterUpdate(object updateParameter)
        {
            pitchParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("gam")]
        private void gamParameterUpdate(object updateParameter)
        {
            rollParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("alku")]
        private void ballSlideParameterUpdate(object updateParameter)
        {
            ballSlideParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("vp")]
        private void vpParameterUpdate(object updateParameter)
        {
            speedParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("vy")]
        private void vyParameterUpdate(object updateParameter)
        {
            vSpeedParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("dme")]
        private void dme1ParameterUpdate(object updateParameter)
        {
            dme1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("dme")]
        private void dme2ParameterUpdate(object updateParameter)
        {
            dme2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("vy")]
        private void radioAttParameterUpdate(object updateParameter)
        {
            radioAttParameter = (Parameter)updateParameter;
        }
        #endregion
    }
}
