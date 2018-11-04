using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class CentralConsolePanelViewModel : INPCBase
    {
        private double stkLValue;
        private double stkRValue;
        private int appLValue;
        private int appRValue;
        private int delvValue;
        private int delkValue;
        private int delsValue;

        private int stkLDigitValue;
        private int stkRDigitValue;

        private string tkLValue;
        private string tkRValue;
        private string extingMainLValue;
        private string extingMainRValue;
        private string extingSecondLValue;
        private string extingSecondRValue;
        private string gearsValue;
        private string limCheckLValue;
        private string limCheckRValue;
        private string ipsCheckValue;
        private string ignCheckLValue;
        private string ignCheckRValue;
        private string startLValue;
        private string startRValue;
        private string ignLValue;
        private string ignRValue;
        private string scLValue;
        private string scRValue;
        private string flaps0Value;
        private string flaps15Value;
        private string flaps35Value;
        private string emrgGearsValue;
        private string emrgFlapsValue;
        private string wheelValue;

        private Parameter tkLParameterValue;
        private Parameter tkRParameterValue;
        private Parameter stkLParameterValue;
        private Parameter stkRParameterValue;
        private Parameter appLParameterValue;
        private Parameter appRParameterValue;
        private Parameter delvParameterValue;
        private Parameter delkParameterValue;
        private Parameter delsParameterValue;

        private Parameter extingMainLParameterValue;
        private Parameter extingMainRParameterValue;
        private Parameter extingSecondLParameterValue;
        private Parameter extingSecondRParameterValue;
        private Parameter gearsParameterValue;
        private Parameter limCheckLParameterValue;
        private Parameter limCheckRParameterValue;
        private Parameter ipsCheckParameterValue;
        private Parameter ignCheckLParameterValue;
        private Parameter ignCheckRParameterValue;
        private Parameter startLParameterValue;
        private Parameter startRParameterValue;
        private Parameter ignLParameterValue;
        private Parameter ignRParameterValue;
        private Parameter scLParameterValue;
        private Parameter scRParameterValue;
        private Parameter flaps0ParameterValue;
        private Parameter flaps15ParameterValue;
        private Parameter flaps35ParameterValue;
        private Parameter emrgGearsParameterValue;
        private Parameter emrgFlapsParameterValue;
        private Parameter wheelParameterValue;



        #region Constructor
        public CentralConsolePanelViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("tppa1"))
            {
                tkLParameter = Mediator.GetBufferedParameter("tppa1");
            }
            else
            {
                tkLParameter = new Parameter("tppa1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tppa2"))
            {
                tkRParameter = Mediator.GetBufferedParameter("tppa2");
            }
            else
            {
                tkRParameter = new Parameter("tppa2", 0);
            }
            if (Mediator.ContainsBufferedParameter("stk1"))
            {
                stkLParameter = Mediator.GetBufferedParameter("stk1");
            }
            else
            {
                stkLParameter = new Parameter("stk1", 0);
            }
            if (Mediator.ContainsBufferedParameter("stk2"))
            {
                stkRParameter = Mediator.GetBufferedParameter("stk2");
            }
            else
            {
                stkRParameter = new Parameter("stk2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                appLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                appLParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                appRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                appRParameter = new Parameter("fsc1", 0);
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

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                extingMainLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                extingMainLParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                extingMainRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                extingMainRParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                extingSecondLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                extingSecondLParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                extingSecondRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                extingSecondRParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("pod"))
            {
                gearsParameter = Mediator.GetBufferedParameter("pod");
            }
            else
            {
                gearsParameter = new Parameter("pod", 0);
            }
            if (Mediator.ContainsBufferedParameter("kom1"))
            {
                limCheckLParameter = Mediator.GetBufferedParameter("kom1");
            }
            else
            {
                limCheckLParameter = new Parameter("kom1", 0);
            }
            if (Mediator.ContainsBufferedParameter("kom2"))
            {
                limCheckRParameter = Mediator.GetBufferedParameter("kom2");
            }
            else
            {
                limCheckRParameter = new Parameter("kom2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsCheckParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                ipsCheckParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ignCheckLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                ignCheckLParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ignCheckRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                ignCheckRParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tls1"))
            {
                startLParameter = Mediator.GetBufferedParameter("tls1");
            }
            else
            {
                startLParameter = new Parameter("tls1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tls2"))
            {
                startRParameter = Mediator.GetBufferedParameter("tls2");
            }
            else
            {
                startRParameter = new Parameter("tls2", 0);
            }
            if (Mediator.ContainsBufferedParameter("tlz1"))
            {
                ignLParameter = Mediator.GetBufferedParameter("tlz1");
            }
            else
            {
                ignLParameter = new Parameter("tlz1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tlz2"))
            {
                ignRParameter = Mediator.GetBufferedParameter("tlz2");
            }
            else
            {
                ignRParameter = new Parameter("tlz2", 0);
            }
            if (Mediator.ContainsBufferedParameter("tlp1"))
            {
                scLParameter = Mediator.GetBufferedParameter("tlp1");
            }
            else
            {
                scLParameter = new Parameter("tlp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("tlp2"))
            {
                scRParameter = Mediator.GetBufferedParameter("tlp2");
            }
            else
            {
                scRParameter = new Parameter("tlp2", 0);
            }
            //if (Mediator.ContainsBufferedParameter("kl0"))
            //{
            //    flaps0Parameter = Mediator.GetBufferedParameter("kl0");
            //}
            //else
            //{
            //    flaps0Parameter = new Parameter("kl0", 0);
            //}
            if (Mediator.ContainsBufferedParameter("kl1"))
            {
                flaps15Parameter = Mediator.GetBufferedParameter("kl1");
            }
            else
            {
                flaps0Parameter = new Parameter("kl0", 1);
                flaps15Parameter = new Parameter("kl1", 0);
            }
            if (Mediator.ContainsBufferedParameter("kl2"))
            {
                flaps35Parameter = Mediator.GetBufferedParameter("kl2");
            }
            else
            {
                if (flaps15Parameter.GetValueAsInt() == 0)
                {
                    flaps0Parameter = new Parameter("kl0", 1);
                }
                flaps35Parameter = new Parameter("kl2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                emrgGearsParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                emrgGearsParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                emrgFlapsParameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                emrgFlapsParameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("pk"))
            {
                wheelParameter = Mediator.GetBufferedParameter("pk");
            }
            else
            {
                wheelParameter = new Parameter("pk", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~CentralConsolePanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties
        private Parameter tkLParameter
        {
            get { return tkLParameterValue; }
            set
            {
                tkLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    tkLLight = "CadetBlue";
                }
                else
                {
                    tkLLight = "Black";
                }
            }
        }
        private Parameter tkRParameter
        {
            get { return tkRParameterValue; }
            set
            {
                tkRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    tkRLight = "CadetBlue";
                }
                else
                {
                    tkRLight = "Black";
                }
            }
        }
        private Parameter stkLParameter
        {
            get { return stkLParameterValue; }
            set
            {
                stkLParameterValue = value;
                stkLOutput = value.GetValueAsDouble();
                stkLDigitOutput = value.GetValueAsInt();
            }
        }
        private Parameter stkRParameter
        {
            get { return stkRParameterValue; }
            set
            {
                stkRParameterValue = value;
                stkROutput = value.GetValueAsDouble();
                stkRDigitOutput = value.GetValueAsInt();
            }
        }
        private Parameter appLParameter
        {
            get { return appLParameterValue; }
            set
            {
                appLParameterValue = value;
                appLOutput = value.GetValueAsInt();
            }
        }
        private Parameter appRParameter
        {
            get { return appRParameterValue; }
            set
            {
                appRParameterValue = value;
                appROutput = value.GetValueAsInt();
            }
        }
        private Parameter delvParameter
        {
            get { return delvParameterValue; }
            set
            {
                delvParameterValue = value;
                delvOutput = value.GetValueAsInt();
            }
        }
        private Parameter delkParameter
        {
            get { return delkParameterValue; }
            set
            {
                delkParameterValue = value;
                delkOutput = value.GetValueAsInt();
            }
        }
        private Parameter delsParameter
        {
            get { return delsParameterValue; }
            set
            {
                delsParameterValue = value;
                delsOutput = value.GetValueAsInt();
            }
        }
        private Parameter extingMainLParameter
        {
            get { return extingMainLParameterValue; }
            set
            {
                extingMainLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    extingMainLLight = "CadetBlue";
                }
                else
                {
                    extingMainLLight = "Black";
                }

            }
        }
        private Parameter extingMainRParameter
        {
            get { return extingMainRParameterValue; }
            set
            {
                extingMainRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    extingMainRLight = "CadetBlue";
                }
                else
                {
                    extingMainRLight = "Black";
                }

            }
        }
        private Parameter extingSecondLParameter
        {
            get { return extingSecondLParameterValue; }
            set
            {
                extingSecondLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    extingSecondLLight = "CadetBlue";
                }
                else
                {
                    extingSecondLLight = "Black";
                }

            }
        }
        private Parameter extingSecondRParameter
        {
            get { return extingSecondRParameterValue; }
            set
            {
                extingSecondRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    extingSecondRLight = "CadetBlue";
                }
                else
                {
                    extingSecondRLight = "Black";
                }

            }
        }
        private Parameter gearsParameter
        {
            get { return gearsParameterValue; }
            set
            {
                gearsParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    gearsLight = "CadetBlue";
                }
                else
                {
                    gearsLight = "Black";
                }

            }
        }
        private Parameter limCheckLParameter
        {
            get { return limCheckLParameterValue; }
            set
            {
                limCheckLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    limCheckLLight = "CadetBlue";
                }
                else
                {
                    limCheckLLight = "Black";
                }

            }
        }
        private Parameter limCheckRParameter
        {
            get { return limCheckRParameterValue; }
            set
            {
                limCheckRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    limCheckRLight = "CadetBlue";
                }
                else
                {
                    limCheckRLight = "Black";
                }

            }
        }
        private Parameter ipsCheckParameter
        {
            get { return ipsCheckParameterValue; }
            set
            {
                ipsCheckParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsCheckLight = "CadetBlue";
                }
                else
                {
                    ipsCheckLight = "Black";
                }

            }
        }
        private Parameter ignCheckLParameter
        {
            get { return ignCheckLParameterValue; }
            set
            {
                ignCheckLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ignCheckLLight = "CadetBlue";
                }
                else
                {
                    ignCheckLLight = "Black";
                }

            }
        }
        private Parameter ignCheckRParameter
        {
            get { return ignCheckRParameterValue; }
            set
            {
                ignCheckRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ignCheckRLight = "CadetBlue";
                }
                else
                {
                    ignCheckRLight = "Black";
                }

            }
        }
        private Parameter startLParameter
        {
            get { return startLParameterValue; }
            set
            {
                startLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    startLLight = "CadetBlue";
                }
                else
                {
                    startLLight = "Black";
                }

            }
        }
        private Parameter startRParameter
        {
            get { return startRParameterValue; }
            set
            {
                startRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    startRLight = "CadetBlue";
                }
                else
                {
                    startRLight = "Black";
                }

            }
        }
        private Parameter ignLParameter
        {
            get { return ignLParameterValue; }
            set
            {
                ignLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ignLLight = "CadetBlue";
                }
                else
                {
                    ignLLight = "Black";
                }

            }
        }
        private Parameter ignRParameter
        {
            get { return ignRParameterValue; }
            set
            {
                ignRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ignRLight = "CadetBlue";
                }
                else
                {
                    ignRLight = "Black";
                }

            }
        }
        private Parameter scLParameter
        {
            get { return scLParameterValue; }
            set
            {
                scLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    scLLight = "CadetBlue";
                }
                else
                {
                    scLLight = "Black";
                }

            }
        }
        private Parameter scRParameter
        {
            get { return scRParameterValue; }
            set
            {
                scRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    scRLight = "CadetBlue";
                }
                else
                {
                    scRLight = "Black";
                }

            }
        }
        private Parameter flaps0Parameter
        {
            get { return flaps0ParameterValue; }
            set
            {
                flaps0ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    flaps0Light = "CadetBlue";
                }
                else
                {
                    flaps0Light = "Black";
                }

            }
        }
        private Parameter flaps15Parameter
        {
            get { return flaps15ParameterValue; }
            set
            {
                flaps15ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    flaps15Light = "CadetBlue";
                }
                else
                {
                    flaps15Light = "Black";
                }

            }
        }
        private Parameter flaps35Parameter
        {
            get { return flaps35ParameterValue; }
            set
            {
                flaps35ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    flaps35Light = "CadetBlue";
                }
                else
                {
                    flaps35Light = "Black";
                }

            }
        }
        private Parameter emrgGearsParameter
        {
            get { return emrgGearsParameterValue; }
            set
            {
                emrgGearsParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    emrgGearsLight = "CadetBlue";
                }
                else
                {
                    emrgGearsLight = "Black";
                }

            }
        }
        private Parameter emrgFlapsParameter
        {
            get { return emrgFlapsParameterValue; }
            set
            {
                emrgFlapsParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    emrgFlapsLight = "CadetBlue";
                }
                else
                {
                    emrgFlapsLight = "Black";
                }

            }
        }
        private Parameter wheelParameter
        {
            get { return wheelParameterValue; }
            set
            {
                wheelParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    wheelLight = "CadetBlue";
                }
                else
                {
                    wheelLight = "Black";
                }

            }
        }
        #endregion

        #region Output Values
        public double stkLOutput
        {
            get { return stkLValue; }
            set
            {
                stkLValue = -value;
                OnPropertyChanged("stkLOutput");
            }
        }
        public double stkROutput
        {
            get { return stkRValue; }
            set
            {
                stkRValue = -value;
                OnPropertyChanged("stkROutput");
            }
        }
        public int appLOutput
        {
            get { return appLValue; }
            set
            {
                appLValue = value;
                OnPropertyChanged("appLOutput");
            }
        }
        public int appROutput
        {
            get { return appRValue; }
            set
            {
                appRValue = value;
                OnPropertyChanged("appROutput");
            }
        }
        public int delvOutput
        {
            get { return delvValue; }
            set
            {
                delvValue = value;
                OnPropertyChanged("delvOutput");
            }
        }
        public int delkOutput
        {
            get { return delkValue; }
            set
            {
                delkValue = value;
                OnPropertyChanged("delkOutput");
            }
        }
        public int delsOutput
        {
            get { return delsValue; }
            set
            {
                delsValue = value;
                OnPropertyChanged("delsOutput");
            }
        }
        public int stkLDigitOutput
        {
            get { return stkLDigitValue; }
            set
            {
                stkLDigitValue = value;
                OnPropertyChanged("stkLDigitOutput");
            }
        }
        public int stkRDigitOutput
        {
            get { return stkRDigitValue; }
            set
            {
                stkRDigitValue = value;
                OnPropertyChanged("stkRDigitOutput");
            }
        }
        #endregion

        #region Light Values
        public string tkLLight
        {
            get { return tkLValue; }
            set
            {
                tkLValue = value;
                OnPropertyChanged("tkLLight");
            }
        }
        public string tkRLight
        {
            get { return tkRValue; }
            set
            {
                tkRValue = value;
                OnPropertyChanged("tkRLight");
            }
        }
        public string extingMainLLight
        {
            get { return extingMainLValue; }
            set
            {
                extingMainLValue = value;
                OnPropertyChanged("extingMainLLight");
            }
        }
        public string extingMainRLight
        {
            get { return extingMainRValue; }
            set
            {
                extingMainRValue = value;
                OnPropertyChanged("extingMainRLight");
            }
        }
        public string extingSecondLLight
        {
            get { return extingSecondLValue; }
            set
            {
                extingSecondLValue = value;
                OnPropertyChanged("extingSecondLLight");
            }
        }
        public string extingSecondRLight
        {
            get { return extingSecondRValue; }
            set
            {
                extingSecondRValue = value;
                OnPropertyChanged("extingSecondRLight");
            }
        }
        public string gearsLight
        {
            get { return gearsValue; }
            set
            {
                gearsValue = value;
                OnPropertyChanged("gearsLight");
            }
        }
        public string limCheckLLight
        {
            get { return limCheckLValue; }
            set
            {
                limCheckLValue = value;
                OnPropertyChanged("limCheckLLight");
            }
        }
        public string limCheckRLight
        {
            get { return limCheckRValue; }
            set
            {
                limCheckRValue = value;
                OnPropertyChanged("limCheckRLight");
            }
        }
        public string ipsCheckLight
        {
            get { return ipsCheckValue; }
            set
            {
                ipsCheckValue = value;
                OnPropertyChanged("ipsCheckLight");
            }
        }
        public string ignCheckLLight
        {
            get { return ignCheckLValue; }
            set
            {
                ignCheckLValue = value;
                OnPropertyChanged("ignCheckLLight");
            }
        }
        public string ignCheckRLight
        {
            get { return ignCheckRValue; }
            set
            {
                ignCheckRValue = value;
                OnPropertyChanged("ignCheckRLight");
            }
        }
        public string startLLight
        {
            get { return startLValue; }
            set
            {
                startLValue = value;
                OnPropertyChanged("startLLight");
            }
        }
        public string startRLight
        {
            get { return startRValue; }
            set
            {
                startRValue = value;
                OnPropertyChanged("startRLight");
            }
        }
        public string ignLLight
        {
            get { return ignLValue; }
            set
            {
                ignLValue = value;
                OnPropertyChanged("ignLLight");
            }
        }
        public string ignRLight
        {
            get { return ignRValue; }
            set
            {
                ignRValue = value;
                OnPropertyChanged("ignRLight");
            }
        }
        public string scLLight
        {
            get { return scLValue; }
            set
            {
                scLValue = value;
                OnPropertyChanged("scLLight");
            }
        }
        public string scRLight
        {
            get { return scRValue; }
            set
            {
                scRValue = value;
                OnPropertyChanged("scRLight");
            }
        }
        public string flaps0Light
        {
            get { return flaps0Value; }
            set
            {
                flaps0Value = value;
                OnPropertyChanged("flaps0Light");
            }
        }
        public string flaps15Light
        {
            get { return flaps15Value; }
            set
            {
                flaps15Value = value;
                OnPropertyChanged("flaps15Light");
            }
        }
        public string flaps35Light
        {
            get { return flaps35Value; }
            set
            {
                flaps35Value = value;
                OnPropertyChanged("flaps35Light");
            }
        }
        public string emrgGearsLight
        {
            get { return emrgGearsValue; }
            set
            {
                emrgGearsValue = value;
                OnPropertyChanged("emrgGearsLight");
            }
        }
        public string emrgFlapsLight
        {
            get { return emrgFlapsValue; }
            set
            {
                emrgFlapsValue = value;
                OnPropertyChanged("emrgFlapsLight");
            }
        }
        public string wheelLight
        {
            get { return wheelValue; }
            set
            {
                wheelValue = value;
                OnPropertyChanged("wheelLight");
            }
        }
        #endregion

        #region Registration Area

        [MediatorMessageSink("tppa1")]
        private void tkLParameterUpdate(object updateParameter)
        {
            tkLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tppa2")]
        private void tkRParameterUpdate(object updateParameter)
        {
            tkRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("stk1")]
        private void stkLParameterUpdate(object updateParameter)
        {
            stkLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("stk2")]
        private void stkRParameterUpdate(object updateParameter)
        {
            stkRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void appLParameterUpdate(object updateParameter)
        {
            appLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void appRParameterUpdate(object updateParameter)
        {
            appRParameter = (Parameter)updateParameter;
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

        [MediatorMessageSink("fsc1")]
        private void extingMainLParameterUpdate(object updateParameter)
        {
            extingMainLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void extingMainRParameterUpdate(object updateParameter)
        {
            extingMainRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void extingSecondLParameterUpdate(object updateParameter)
        {
            extingSecondLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void extingSecondRParameterUpdate(object updateParameter)
        {
            extingSecondRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("pod")]
        private void gearsParameterUpdate(object updateParameter)
        {
            gearsParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("kom1")]
        private void limCheckLParameterUpdate(object updateParameter)
        {
            limCheckLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("kom2")]
        private void limCheckRParameterUpdate(object updateParameter)
        {
            limCheckRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsCheckParameterUpdate(object updateParameter)
        {
            ipsCheckParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ignCheckLParameterUpdate(object updateParameter)
        {
            ignCheckLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ignCheckRParameterUpdate(object updateParameter)
        {
            ignCheckRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tls1")]
        private void startLParameterUpdate(object updateParameter)
        {
            startLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tls2")]
        private void startRParameterUpdate(object updateParameter)
        {
            startRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tlz1")]
        private void ignLParameterUpdate(object updateParameter)
        {
            ignLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tlz2")]
        private void ignRParameterUpdate(object updateParameter)
        {
            ignRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tlp1")]
        private void scLParameterUpdate(object updateParameter)
        {
            scLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("tlp2")]
        private void scRParameterUpdate(object updateParameter)
        {
            scRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("kl0")]
        private void flaps0ParameterUpdate(object updateParameter)
        {
            flaps0Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("kl1")]
        private void flaps15ParameterUpdate(object updateParameter)
        {
            flaps15Parameter = (Parameter)updateParameter;
            if (!flaps15Parameter.GetValueAsBool() && !flaps35Parameter.GetValueAsBool() == true)
            {
                flaps0Parameter = new Parameter("kl0", 1);
            }
            else
            {
                if (flaps15Parameter.GetValueAsBool() || flaps35Parameter.GetValueAsBool() == true)
                {
                    flaps0Parameter = new Parameter("kl0", 0);
                }
            }
        }
        [MediatorMessageSink("kl2")]
        private void flaps35ParameterUpdate(object updateParameter)
        {
            flaps35Parameter = (Parameter)updateParameter;
            if (!flaps15Parameter.GetValueAsBool() && !flaps35Parameter.GetValueAsBool() == true)
            {
                flaps0Parameter = new Parameter("kl0", 1);
            }
            else
            {
                if (flaps15Parameter.GetValueAsBool() || flaps35Parameter.GetValueAsBool() == true)
                {
                    flaps0Parameter = new Parameter("kl0", 0);
                }
            }
        }
        [MediatorMessageSink("fsc1")]
        private void emrgGearsParameterUpdate(object updateParameter)
        {
            emrgGearsParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void emrgFlapsParameterUpdate(object updateParameter)
        {
            emrgFlapsParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("pk")]
        private void wheelParameterUpdate(object updateParameter)
        {
            wheelParameter = (Parameter)updateParameter;
        }
        #endregion
    }
}
