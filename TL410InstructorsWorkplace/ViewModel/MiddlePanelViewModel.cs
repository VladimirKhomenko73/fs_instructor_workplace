using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class MiddlePanelViewModel : INPCBase
    {
        private int ngLValue;
        private int ngRValue;
        private int nvLValue;
        private int nvRValue;
        private int tmtLValue;
        private int tmtRValue;
        private int mkLValue;
        private int mkRValue;
        private int poLValue;
        private int poRValue;
        private int toLValue;
        private int toRValue;
        private int gpLValue;
        private int gpRValue;
        private int ptLValue;
        private int ptRValue;
        private int hydValue;

        private Parameter ngLParameterValue;
        private Parameter ngRParameterValue;
        private Parameter nvLParameterValue;
        private Parameter nvRParameterValue;
        private Parameter tmtLParameterValue;
        private Parameter tmtRParameterValue;
        private Parameter mkLParameterValue;
        private Parameter mkRParameterValue;
        private Parameter poLParameterValue;
        private Parameter poRParameterValue;
        private Parameter toLParameterValue;
        private Parameter toRParameterValue;
        private Parameter gpLParameterValue;
        private Parameter gpRParameterValue;
        private Parameter ptLParameterValue;
        private Parameter ptRParameterValue;
        private Parameter hydParameterValue;

        #region Constructor
        public MiddlePanelViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("ng1"))
            {
                ngLParameter = Mediator.GetBufferedParameter("ng1");
            }
            else
            {
                ngLParameter = new Parameter("ng1", 0);
            }
            if (Mediator.ContainsBufferedParameter("ng2"))
            {
                ngRParameter = Mediator.GetBufferedParameter("ng2");
            }
            else
            {
                ngRParameter = new Parameter("ng2", 0);
            }
            if (Mediator.ContainsBufferedParameter("nv1"))
            {
                nvLParameter = Mediator.GetBufferedParameter("nv1");
            }
            else
            {
                nvLParameter = new Parameter("nv1", 0);
            }
            if (Mediator.ContainsBufferedParameter("nv2"))
            {
                nvRParameter = Mediator.GetBufferedParameter("nv2");
            }
            else
            {
                nvRParameter = new Parameter("nv2", 0);
            }
            if (Mediator.ContainsBufferedParameter("tmt1"))
            {
                tmtLParameter = Mediator.GetBufferedParameter("tmt1");
            }
            else
            {
                tmtLParameter = new Parameter("tmt1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tmt2"))
            {
                tmtRParameter = Mediator.GetBufferedParameter("tmt2");
            }
            else
            {
                tmtRParameter = new Parameter("tmt2", 0);
            }
            if (Mediator.ContainsBufferedParameter("mk1"))
            {
                mkLParameter = Mediator.GetBufferedParameter("mk1");
            }
            else
            {
                mkLParameter = new Parameter("mk1", 0);
            }
            if (Mediator.ContainsBufferedParameter("mk2"))
            {
                mkRParameter = Mediator.GetBufferedParameter("mk2");
            }
            else
            {
                mkRParameter = new Parameter("mk2", 0);
            }
            if (Mediator.ContainsBufferedParameter("po1"))
            {
                poLParameter = Mediator.GetBufferedParameter("po1");
            }
            else
            {
                poLParameter = new Parameter("po1", 0);
            }
            if (Mediator.ContainsBufferedParameter("po2"))
            {
                poRParameter = Mediator.GetBufferedParameter("po2");
            }
            else
            {
                poRParameter = new Parameter("po2", 0);
            }
            if (Mediator.ContainsBufferedParameter("to1"))
            {
                toLParameter = Mediator.GetBufferedParameter("to1");
            }
            else
            {
                toLParameter = new Parameter("to1", 0);
            }
            if (Mediator.ContainsBufferedParameter("to2"))
            {
                toRParameter = Mediator.GetBufferedParameter("to2");
            }
            else
            {
                toRParameter = new Parameter("to2", 0);
            }
            if (Mediator.ContainsBufferedParameter("gp1"))
            {
                gpLParameter = Mediator.GetBufferedParameter("gp1");
            }
            else
            {
                gpLParameter = new Parameter("gp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("gp2"))
            {
                gpRParameter = Mediator.GetBufferedParameter("gp2");
            }
            else
            {
                gpRParameter = new Parameter("gp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("tp1"))
            {
                ptLParameter = Mediator.GetBufferedParameter("tp1");
            }
            else
            {
                ptLParameter = new Parameter("tp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tp2"))
            {
                ptRParameter = Mediator.GetBufferedParameter("tp2");
            }
            else
            {
                ptRParameter = new Parameter("tp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("hyd"))
            {
                hydParameter = Mediator.GetBufferedParameter("hyd");
            }
            else
            {
                hydParameter = new Parameter("hyd", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~MiddlePanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties

        private Parameter ngLParameter
        {
            get { return ngLParameterValue; }
            set
            {
                ngLParameterValue = value;
                ngLOutput = value.GetValueAsInt();

            }
        }

        private Parameter ngRParameter
        {
            get { return ngRParameterValue; }
            set
            {
                ngRParameterValue = value;
                ngROutput = value.GetValueAsInt();

            }
        }
        private Parameter nvLParameter
        {
            get { return nvLParameterValue; }
            set
            {
                nvLParameterValue = value;
                nvLOutput = value.GetValueAsInt();

            }
        }
        private Parameter nvRParameter
        {
            get { return nvRParameterValue; }
            set
            {
                nvRParameterValue = value;
                nvROutput = value.GetValueAsInt();

            }
        }
        private Parameter tmtLParameter
        {
            get { return tmtLParameterValue; }
            set
            {
                tmtLParameterValue = value;
                tmtLOutput = value.GetValueAsInt();

            }
        }
        private Parameter tmtRParameter
        {
            get { return tmtRParameterValue; }
            set
            {
                tmtRParameterValue = value;
                tmtROutput = value.GetValueAsInt();

            }
        }
        private Parameter mkLParameter
        {
            get { return mkLParameterValue; }
            set
            {
                mkLParameterValue = value;
                mkLOutput = value.GetValueAsInt();

            }
        }
        private Parameter mkRParameter
        {
            get { return mkRParameterValue; }
            set
            {
                mkRParameterValue = value;
                mkROutput = value.GetValueAsInt();

            }
        }
        private Parameter poLParameter
        {
            get { return poLParameterValue; }
            set
            {
                poLParameterValue = value;
                poLOutput = value.GetValueAsInt();

            }
        }
        private Parameter poRParameter
        {
            get { return poRParameterValue; }
            set
            {
                poRParameterValue = value;
                poROutput = value.GetValueAsInt();

            }
        }
        private Parameter toLParameter
        {
            get { return toLParameterValue; }
            set
            {
                toLParameterValue = value;
                toLOutput = value.GetValueAsInt();

            }
        }
        private Parameter toRParameter
        {
            get { return toRParameterValue; }
            set
            {
                toRParameterValue = value;
                toROutput = value.GetValueAsInt();

            }
        }
        private Parameter gpLParameter
        {
            get { return gpLParameterValue; }
            set
            {
                gpLParameterValue = value;
                gpLOutput = value.GetValueAsInt();

            }
        }
        private Parameter gpRParameter
        {
            get { return gpRParameterValue; }
            set
            {
                gpRParameterValue = value;
                gpROutput = value.GetValueAsInt();

            }
        }
        private Parameter ptLParameter
        {
            get { return ptLParameterValue; }
            set
            {
                ptLParameterValue = value;
                ptLOutput = value.GetValueAsInt();

            }
        }
        private Parameter ptRParameter
        {
            get { return ptRParameterValue; }
            set
            {
                ptRParameterValue = value;
                ptROutput = value.GetValueAsInt();

            }
        }
        private Parameter hydParameter
        {
            get { return hydParameterValue; }
            set
            {
                hydParameterValue = value;
                hydOutput = value.GetValueAsInt();

            }
        }




        #endregion

        #region Output Values

        public int ngLOutput
        {
            get { return ngLValue; }
            set
            {
                ngLValue = value;
                OnPropertyChanged("ngLOutput");
            }
        }

        public int ngROutput
        {
            get { return ngRValue; }
            set
            {
                ngRValue = value;
                OnPropertyChanged("ngROutput");
            }
        }
        
        public int nvLOutput
        {
            get { return nvLValue; }
            set
            {
                int calibratedValue = value / 100;
                nvLValue = calibratedValue;
                OnPropertyChanged("nvLOutput");
            }
        }

        public int nvROutput
        {
            get { return nvRValue; }
            set
            {
                int calibratedValue = value / 100;
                nvRValue = calibratedValue;
                OnPropertyChanged("nvROutput");
            }
        }
        public int tmtLOutput
        {
            get { return tmtLValue; }
            set
            {
                tmtLValue = value;
                OnPropertyChanged("tmtLOutput");
            }
        }

        public int tmtROutput
        {
            get { return tmtRValue; }
            set
            {
                tmtRValue = value;
                OnPropertyChanged("tmtROutput");
            }
        }
        public int mkLOutput
        {
            get { return mkLValue; }
            set
            {
                mkLValue = value;
                OnPropertyChanged("mkLOutput");
            }
        }

        public int mkROutput
        {
            get { return mkRValue; }
            set
            {
               mkRValue = value;
               OnPropertyChanged("mkROutput");
            }
        }
        public int poLOutput
        {
            get { return poLValue; }
            set
            {
               poLValue = value;
               OnPropertyChanged("poLOutput");
            }
        }

        public int poROutput
        {
            get { return poRValue; }
            set
            {
                poRValue = value;
                OnPropertyChanged("poROutput");
            }
        }
        public int toLOutput
        {
            get { return toLValue; }
            set
            {
                toLValue = value;
                OnPropertyChanged("toLOutput");
            }
        }

        public int toROutput
        {
            get { return toRValue; }
            set
            {
                toRValue = value;
                OnPropertyChanged("toROutput");
            }
        }
        public int gpLOutput
        {
            get { return gpLValue; }
            set
            {
                gpLValue = value;
                OnPropertyChanged("gpLOutput");
            }
        }

        public int gpROutput
        {
            get { return gpRValue; }
            set
            {
                gpRValue = value;
                OnPropertyChanged("gpROutput");
            }
        }
        public int ptLOutput
        {
            get { return ptLValue; }
            set
            {
                ptLValue = value;
                OnPropertyChanged("ptLOutput");
            }
        }

        public int ptROutput
        {
            get { return ptRValue; }
            set
            {
                ptRValue = value;
                OnPropertyChanged("ptROutput");
            }
        }

        
        public int hydOutput
        {
            get { return hydValue; }
            set
            {
                hydValue = value;
                OnPropertyChanged("hydOutput");
            }
        }

        #endregion

        #region Registration Area
        [MediatorMessageSink("ng1")]
        private void ngLParameterUpdate(object updateParameter)
        {
            ngLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ng2")]
        private void ngRParameterUpdate(object updateParameter)
        {
            ngRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("nv1")]
        private void nvLParameterUpdate(object updateParameter)
        {
            nvLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("nv2")]
        private void nvRParameterUpdate(object updateParameter)
        {
            nvRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tmt1")]
        private void tmtLParameterUpdate(object updateParameter)
        {
            tmtLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tmt2")]
        private void tmtRParameterUpdate(object updateParameter)
        {
            tmtRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("mk1")]
        private void mkLParameterUpdate(object updateParameter)
        {
            mkLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("mk2")]
        private void mkRParameterUpdate(object updateParameter)
        {
            mkRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("po1")]
        private void poLParameterUpdate(object updateParameter)
        {
            poLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("po2")]
        private void poRParameterUpdate(object updateParameter)
        {
            poRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("to1")]
        private void toLParameterUpdate(object updateParameter)
        {
            toLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("to2")]
        private void toRParameterUpdate(object updateParameter)
        {
            toRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("gp1")]
        private void gpLParameterUpdate(object updateParameter)
        {
            gpLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("gp2")]
        private void gpRParameterUpdate(object updateParameter)
        {
            gpRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tp1")]
        private void ptLParameterUpdate(object updateParameter)
        {
            ptLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tp2")]
        private void ptRParameterUpdate(object updateParameter)
        {
            ptRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("hyd")]
        private void hydParameterUpdate(object updateParameter)
        {
            hydParameter = (Parameter)updateParameter;
        }
        #endregion
    }
}
