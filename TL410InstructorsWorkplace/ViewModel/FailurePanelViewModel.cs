using System;
using System.Windows.Controls;
using System.Windows.Input;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;

namespace TL410InstructorsWorkplace.ViewModel
{
    class FailurePanelViewModel : INPCBase
    {
        public ICommand sendCommand { get; private set; }
        public ICommand sendSliderCommand { get; private set; }
        public ICommand sendAttitudeIndicatorLCommand { get; private set; }
        public ICommand sendAttitudeIndicatorRCommand { get; private set; }

        #region Parameter value
        #region Power failure
        private Parameter busDeadShotParameterValue;
        private Parameter genFailureParameterValue;
        private Parameter transducerFailure1ParameterValue;
        private Parameter transducerFailure3ParameterValue;
        #endregion

        #region Airframe failure
        private Parameter icingParameterValue;
        private Parameter hydraulicFailureParameterValue;
        private Parameter cycFailureParameterValue;
        private Parameter generalPressureFailureParameterValue;
        private Parameter gearsFailureParameterValue;
        private Parameter flapsFailureParameterValue;
        private Parameter breakLFailureParameterValue;
        private Parameter breakRFailureParameterValue;
        private Parameter staticPressureFailureParameterValue;
        private Parameter aileronTrimTabFailureParameterValue;
        private Parameter rudderTrimTabFailureParameterValue;
        #endregion

        #region Engines failure
        private Parameter fireLParameterValue;
        private Parameter fireRParameterValue;
        private Parameter engStopLParameterValue;
        private Parameter engStopRParameterValue;
        private Parameter engHoldupLParameterValue;
        private Parameter engHoldupRParameterValue;
        private Parameter tmtLParameterValue;
        private Parameter tmtRParameterValue;
        private Parameter oilPressureFailureLParameterValue;
        private Parameter oilPressureFailureRParameterValue;
        private Parameter oilTemaperatureLParameterValue;
        private Parameter oilTemaperatureRParameterValue;
        private Parameter propOverspeedLParameterValue;
        private Parameter propOverspeedRParameterValue;
        private Parameter featheringMotorFailureLParameterValue;
        private Parameter featheringMotorFailureRParameterValue;
        private Parameter fuelPressureFailureLParameterValue;
        private Parameter fuelPressureFailureRParameterValue;
        private Parameter ceboLFailureParameterValue;
        private Parameter ceboRFailureParameterValue;
        private Parameter fuelFlowLFailureParameterValue;
        private Parameter fuelFlowRFailureParameterValue;
        #endregion

        #region Avionics failure
        private Parameter reserveAttitudeIndicatorFailureParameterValue;
        private Parameter UKV1FailureParameterValue;
        private Parameter GMKFailureParameterValue;
        private Parameter radioAltimeterFailureParameterValue;
        private Parameter RMIFailureParameterValue;
        private Parameter radioFailureParameterValue;
        private Parameter ilsFailureParameterValue;
        private Parameter markerBeaconLightFailureParameterValue;
        private Parameter markerBeaconSoundFailureParameterValue;
        private Parameter rpmIndicatorLFailureParameterValue;
        private Parameter rpmIndicatorRFailureParameterValue;
        private Parameter mkIndicatorLFailureParameterValue;
        private Parameter mkIndicatorRFailureParameterValue;
        private Parameter attitudeIndicatorPitchDriftLParameterValue;
        private Parameter attitudeIndicatorPitchDriftRParameterValue;
        private Parameter attitudeIndicatorRollDriftLParameterValue;
        private Parameter attitudeIndicatorRollDriftRParameterValue;
        #endregion
        #endregion




        #region Output value
        #region Power failure
        private string busDeadShotOutputValue;
        private string genFailureOutputValue;
        private string transducerFailure1OutputValue;
        private string transducerFailure3OutputValue;
        #endregion

        #region Airframe failure
        private string icingOutputValue;
        private string hydraulicFailureOutputValue;
        private string cycFailureOutputValue;
        private string generalPressureFailureOutputValue;
        private string gearsFailureOutputValue;
        private string flapsFailureOutputValue;
        private string breakLFailureOutputValue;
        private string breakRFailureOutputValue;
        private string staticPressureFailureOutputValue;
        private double aileronTrimTabFailureOutputValue;
        private double rudderTrimTabFailureOutputValue;
        #endregion

        #region Engines failure
        private string fireLOutputValue;
        private string fireROutputValue;
        private string engStopLOutputValue;
        private string engStopROutputValue;
        private string engHoldupLOutputValue;
        private string engHoldupROutputValue;
        private string tmtLOutputValue;
        private string tmtROutputValue;
        private string oilPressureFailureLOutputValue;
        private string oilPressureFailureROutputValue;
        private string oilTemaperatureLOutputValue;
        private string oilTemaperatureROutputValue;
        private string propOverspeedLOutputValue;
        private string propOverspeedROutputValue;
        private string featheringMotorFailureLOutputValue;
        private string featheringMotorFailureROutputValue;
        private string fuelPressureFailureLOutputValue;
        private string fuelPressureFailureROutputValue;
        private string ceboLFailureOutputValue;
        private string ceboRFailureOutputValue;
        private string fuelFlowLFailureOutputValue;
        private string fuelFlowRFailureOutputValue;
        #endregion

        #region Avionics failure
        private string reserveAttitudeIndicatorFailureOutputValue;
        private string UKV1FailureOutputValue;
        private string GMKFailureOutputValue;
        private string radioAltimeterFailureOutputValue;
        private string RMIFailureOutputValue;
        private string radioFailureOutputValue;
        private string ilsFailureOutputValue;
        private string markerBeaconLightFailureOutputValue;
        private string markerBeaconSoundFailureOutputValue;
        private string rpmIndicatorLFailureOutputValue;
        private string rpmIndicatorRFailureOutputValue;
        private string mkIndicatorLFailureOutputValue;
        private string mkIndicatorRFailureOutputValue;
        private double attitudeIndicatorPitchDriftLOutputValue;
        private double attitudeIndicatorPitchDriftROutputValue;
        private double attitudeIndicatorRollDriftLOutputValue;
        private double attitudeIndicatorRollDriftROutputValue;
        #endregion
        #endregion

        #region Input value
        #region Airframe failure
        private double aileronTrimTabFailureInputValue;
        private double rudderTrimTabFailureInputValue;
        #endregion

        #region Avionics failure
        private double attitudeIndicatorPitchDriftLInputValue;
        private double attitudeIndicatorPitchDriftRInputValue;
        private double attitudeIndicatorRollDriftLInputValue;
        private double attitudeIndicatorRollDriftRInputValue;
        #endregion
        #endregion

        #region Constructor
        public FailurePanelViewModel()
        {
            sendCommand = new RelayCommand(Send);
            sendSliderCommand = new RelayCommand(sliderSend);
            sendAttitudeIndicatorLCommand = new RelayCommand(attitudeIndicatorDriftL);
            sendAttitudeIndicatorRCommand = new RelayCommand(attitudeIndicatorDriftR);

            #region First start check

            #region Power
            if (Mediator.ContainsBufferedParameter("123"))
            {
                busDeadShotParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                busDeadShotParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                genFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                genFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                transducerFailure1Parameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                transducerFailure1Parameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                transducerFailure3Parameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                transducerFailure3Parameter = new Parameter("123", 0);
            }
            #endregion

            #region Airframe
            if (Mediator.ContainsBufferedParameter("123"))
            {
                icingParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                icingParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                hydraulicFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                hydraulicFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                cycFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                cycFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                generalPressureFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                generalPressureFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                gearsFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                gearsFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                flapsFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                flapsFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                breakLFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                breakLFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                breakRFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                breakRFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("fst1"))
            {
                staticPressureFailureParameter = Mediator.GetBufferedParameter("fst1");
            }
            else
            {
                staticPressureFailureParameter = new Parameter("fst1", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                aileronTrimTabFailureParameter = Mediator.GetBufferedParameter("123");
                aileronTrimTabFailureOutput = aileronTrimTabFailureParameter.GetValueAsDouble();
                aileronTrimTabFailureInput = aileronTrimTabFailureParameter.GetValueAsDouble();
            }
            else
            {
                aileronTrimTabFailureParameter = new Parameter("123", 0);
                aileronTrimTabFailureOutput = aileronTrimTabFailureParameter.GetValueAsDouble();
                aileronTrimTabFailureInput = aileronTrimTabFailureParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                rudderTrimTabFailureParameter = Mediator.GetBufferedParameter("123");
                rudderTrimTabFailureOutput = rudderTrimTabFailureParameter.GetValueAsDouble();
                rudderTrimTabFailureInput = rudderTrimTabFailureParameter.GetValueAsDouble();
            }
            else
            {
                rudderTrimTabFailureParameter = new Parameter("123", 0);
                rudderTrimTabFailureOutput = rudderTrimTabFailureParameter.GetValueAsDouble();
                rudderTrimTabFailureInput = rudderTrimTabFailureParameter.GetValueAsDouble();
            }
            #endregion

            #region Engine
            if (Mediator.ContainsBufferedParameter("123"))
            {
                fireLParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                fireLParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                fireRParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                fireRParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("fef1"))
            {
                engStopLParameter = Mediator.GetBufferedParameter("fef1");
            }
            else
            {
                engStopLParameter = new Parameter("fef1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fef2"))
            {
                engStopRParameter = Mediator.GetBufferedParameter("fef2");
            }
            else
            {
                engStopRParameter = new Parameter("fef2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fvis1"))
            {
                engHoldupLParameter = Mediator.GetBufferedParameter("fvis1");
            }
            else
            {
                engHoldupLParameter = new Parameter("fvis1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fvis2"))
            {
                engHoldupRParameter = Mediator.GetBufferedParameter("fvis2");
            }
            else
            {
                engHoldupRParameter = new Parameter("fvis2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fztt1"))
            {
                tmtLParameter = Mediator.GetBufferedParameter("fztt1");
            }
            else
            {
                tmtLParameter = new Parameter("fztt1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fztt2"))
            {
                tmtRParameter = Mediator.GetBufferedParameter("fztt2");
            }
            else
            {
                tmtRParameter = new Parameter("fztt2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fztp1"))
            {
                oilPressureFailureLParameter = Mediator.GetBufferedParameter("fztp1");
            }
            else
            {
                oilPressureFailureLParameter = new Parameter("fztp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fztp2"))
            {
                oilPressureFailureRParameter = Mediator.GetBufferedParameter("fztp2");
            }
            else
            {
                oilPressureFailureRParameter = new Parameter("fztp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzto1"))
            {
                oilTemaperatureLParameter = Mediator.GetBufferedParameter("fzto1");
            }
            else
            {
                oilTemaperatureLParameter = new Parameter("fzto1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzto1"))
            {
                oilTemaperatureRParameter = Mediator.GetBufferedParameter("fzto1");
            }
            else
            {
                oilTemaperatureRParameter = new Parameter("fzto1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzrv1"))
            {
                propOverspeedLParameter = Mediator.GetBufferedParameter("fzrv1");
            }
            else
            {
                propOverspeedLParameter = new Parameter("fzrv1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzrv2"))
            {
                propOverspeedRParameter = Mediator.GetBufferedParameter("fzrv2");
            }
            else
            {
                propOverspeedRParameter = new Parameter("fzrv2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzpr1"))
            {
                featheringMotorFailureLParameter = Mediator.GetBufferedParameter("fzpr1");
            }
            else
            {
                featheringMotorFailureLParameter = new Parameter("fzpr1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzpr2"))
            {
                featheringMotorFailureRParameter = Mediator.GetBufferedParameter("fzpr2");
            }
            else
            {
                featheringMotorFailureRParameter = new Parameter("fzpr2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fztp1"))
            {
                fuelPressureFailureLParameter = Mediator.GetBufferedParameter("fztp1");
            }
            else
            {
                fuelPressureFailureLParameter = new Parameter("fztp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fztp2"))
            {
                fuelPressureFailureRParameter = Mediator.GetBufferedParameter("fztp2");
            }
            else
            {
                fuelPressureFailureRParameter = new Parameter("fztp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                ceboLFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                ceboLFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                ceboRFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                ceboRFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzns1"))
            {
                fuelFlowLFailureParameter = Mediator.GetBufferedParameter("fzns1");
            }
            else
            {
                fuelFlowLFailureParameter = new Parameter("fzns1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fzns2"))
            {
                fuelFlowRFailureParameter = Mediator.GetBufferedParameter("fzns2");
            }
            else
            {
                fuelFlowRFailureParameter = new Parameter("fzns2", 0);
            }
            #endregion

            #region Avionics
            if (Mediator.ContainsBufferedParameter("123"))
            {
                reserveAttitudeIndicatorFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                reserveAttitudeIndicatorFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                UKV1FailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                UKV1FailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                GMKFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                GMKFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                radioAltimeterFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                radioAltimeterFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                RMIFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                RMIFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                radioFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                radioFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                ilsFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                ilsFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                markerBeaconLightFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                markerBeaconLightFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                markerBeaconSoundFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                markerBeaconSoundFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                rpmIndicatorLFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                rpmIndicatorLFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                rpmIndicatorRFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                rpmIndicatorRFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                mkIndicatorLFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                mkIndicatorLFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                mkIndicatorRFailureParameter = Mediator.GetBufferedParameter("123");
            }
            else
            {
                mkIndicatorRFailureParameter = new Parameter("123", 0);
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                attitudeIndicatorPitchDriftLParameter = Mediator.GetBufferedParameter("123");
                attitudeIndicatorPitchDriftLOutput = attitudeIndicatorPitchDriftLParameter.GetValueAsDouble();
                attitudeIndicatorPitchDriftLInput = attitudeIndicatorPitchDriftLParameter.GetValueAsDouble();
            }
            else
            {
                attitudeIndicatorPitchDriftLParameter = new Parameter("123", 0);
                attitudeIndicatorPitchDriftLOutput = attitudeIndicatorPitchDriftLParameter.GetValueAsDouble();
                attitudeIndicatorPitchDriftLInput = attitudeIndicatorPitchDriftLParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("123"))
            {
                attitudeIndicatorPitchDriftRParameter = Mediator.GetBufferedParameter("123");
                attitudeIndicatorPitchDriftROutput = attitudeIndicatorPitchDriftRParameter.GetValueAsDouble();
                attitudeIndicatorPitchDriftRInput = attitudeIndicatorPitchDriftRParameter.GetValueAsDouble();
            }
            else
            {
                attitudeIndicatorPitchDriftRParameter = new Parameter("123", 0);
                attitudeIndicatorPitchDriftROutput = attitudeIndicatorPitchDriftRParameter.GetValueAsDouble();
                attitudeIndicatorPitchDriftRInput = attitudeIndicatorPitchDriftRParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("1231"))
            {
                attitudeIndicatorRollDriftLParameter = Mediator.GetBufferedParameter("1231");
                attitudeIndicatorRollDriftLOutput = attitudeIndicatorRollDriftLParameter.GetValueAsDouble();
                attitudeIndicatorRollDriftLInput = attitudeIndicatorRollDriftLParameter.GetValueAsDouble();
            }
            else
            {
                attitudeIndicatorRollDriftLParameter = new Parameter("1231", 0);
                attitudeIndicatorRollDriftLOutput = attitudeIndicatorRollDriftLParameter.GetValueAsDouble();
                attitudeIndicatorRollDriftLInput = attitudeIndicatorRollDriftLParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("1231"))
            {
                attitudeIndicatorRollDriftRParameter = Mediator.GetBufferedParameter("1231");
                attitudeIndicatorRollDriftROutput = attitudeIndicatorRollDriftRParameter.GetValueAsDouble();
                attitudeIndicatorRollDriftRInput = attitudeIndicatorRollDriftRParameter.GetValueAsDouble();
            }
            else
            {
                attitudeIndicatorRollDriftRParameter = new Parameter("1231", 0);
                attitudeIndicatorRollDriftROutput = attitudeIndicatorRollDriftRParameter.GetValueAsDouble();
                attitudeIndicatorRollDriftRInput = attitudeIndicatorRollDriftRParameter.GetValueAsDouble();
            }
            #endregion

            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~FailurePanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties

        #region Power parameters
        public Parameter busDeadShotParameter
        {
            get
            {
                return busDeadShotParameterValue;
            }
            set
            {
                busDeadShotParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    busDeadShotOutput = "Gold";
                }
                else
                {
                    busDeadShotOutput = "Black";
                }
            }
        }
        public Parameter genFailureParameter
        {
            get
            {
                return genFailureParameterValue;
            }
            set
            {
                genFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    genFailureOutput = "Gold";
                }
                else
                {
                    genFailureOutput = "Black";
                }
            }
        }
        public Parameter transducerFailure1Parameter
        {
            get
            {
                return transducerFailure1ParameterValue;
            }
            set
            {
                transducerFailure1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    transducerFailure1Output = "Gold";
                }
                else
                {
                    transducerFailure1Output = "Black";
                }
            }
        }
        public Parameter transducerFailure3Parameter
        {
            get
            {
                return transducerFailure3ParameterValue;
            }
            set
            {
                transducerFailure3ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    transducerFailure3Output = "Gold";
                }
                else
                {
                    transducerFailure3Output = "Black";
                }
            }
        }
        #endregion

        #region Airframe parameters
        public Parameter icingParameter
        {
            get
            {
                return icingParameterValue;
            }
            set
            {
                icingParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    icingOutput = "Gold";
                }
                else
                {
                    icingOutput = "Black";
                }
            }
        }
        public Parameter hydraulicFailureParameter
        {
            get
            {
                return hydraulicFailureParameterValue;
            }
            set
            {
                hydraulicFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    hydraulicFailureOutput = "Gold";
                }
                else
                {
                    hydraulicFailureOutput = "Black";
                }
            }
        }
        public Parameter cycFailureParameter
        {
            get
            {
                return cycFailureParameterValue;
            }
            set
            {
                cycFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    cycFailureOutput = "Gold";
                }
                else
                {
                    cycFailureOutput = "Black";
                }
            }
        }
        public Parameter generalPressureFailureParameter
        {
            get
            {
                return generalPressureFailureParameterValue;
            }
            set
            {
                generalPressureFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    generalPressureFailureOutput = "Gold";
                }
                else
                {
                    generalPressureFailureOutput = "Black";
                }
            }
        }
        public Parameter gearsFailureParameter
        {
            get
            {
                return gearsFailureParameterValue;
            }
            set
            {
                gearsFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    gearsFailureOutput = "Gold";
                }
                else
                {
                    gearsFailureOutput = "Black";
                }
            }
        }
        public Parameter flapsFailureParameter
        {
            get
            {
                return flapsFailureParameterValue;
            }
            set
            {
                flapsFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    flapsFailureOutput = "Gold";
                }
                else
                {
                    flapsFailureOutput = "Black";
                }
            }
        }
        public Parameter breakLFailureParameter
        {
            get
            {
                return breakLFailureParameterValue;
            }
            set
            {
                breakLFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    breakLFailureOutput = "Gold";
                }
                else
                {
                    breakLFailureOutput = "Black";
                }
            }
        }
        public Parameter breakRFailureParameter
        {
            get
            {
                return breakRFailureParameterValue;
            }
            set
            {
                breakRFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    breakRFailureOutput = "Gold";
                }
                else
                {
                    breakRFailureOutput = "Black";
                }
            }
        }
        public Parameter staticPressureFailureParameter
        {
            get
            {
                return staticPressureFailureParameterValue;
            }
            set
            {
                staticPressureFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    staticPressureFailureOutput = "Gold";
                }
                else
                {
                    staticPressureFailureOutput = "Black";
                }
            }
        }
        public Parameter aileronTrimTabFailureParameter
        {
            get
            {
                return aileronTrimTabFailureParameterValue;
            }
            set
            {
                aileronTrimTabFailureParameterValue = value;
                OnPropertyChanged("aileronTrimTabFailureParameter");
            }
        }
        public Parameter rudderTrimTabFailureParameter
        {
            get
            {
                return rudderTrimTabFailureParameterValue;
            }
            set
            {
                rudderTrimTabFailureParameterValue = value;
                OnPropertyChanged("rudderTrimTabFailureParameter");
            }
        }
        #endregion

        #region Engine parameters
        public Parameter fireLParameter
        {
            get
            {
                return fireLParameterValue;
            }
            set
            {
                fireLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fireLOutput = "Gold";
                }
                else
                {
                    fireLOutput = "Black";
                }
            }
        }
        public Parameter fireRParameter
        {
            get
            {
                return fireRParameterValue;
            }
            set
            {
                fireRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fireROutput = "Gold";
                }
                else
                {
                    fireROutput = "Black";
                }
            }
        }
        public Parameter engStopLParameter
        {
            get
            {
                return engStopLParameterValue;
            }
            set
            {
                engStopLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engStopLOutput = "Gold";
                }
                else
                {
                    engStopLOutput = "Black";
                }
            }
        }
        public Parameter engStopRParameter
        {
            get
            {
                return engStopRParameterValue;
            }
            set
            {
                engStopRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engStopROutput = "Gold";
                }
                else
                {
                    engStopROutput = "Black";
                }
            }
        }
        public Parameter engHoldupLParameter
        {
            get
            {
                return engHoldupLParameterValue;
            }
            set
            {
                engHoldupLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engHoldupLOutput = "Gold";
                }
                else
                {
                    engHoldupLOutput = "Black";
                }
            }
        }
        public Parameter engHoldupRParameter
        {
            get
            {
                return engHoldupRParameterValue;
            }
            set
            {
                engHoldupRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engHoldupROutput = "Gold";
                }
                else
                {
                    engHoldupROutput = "Black";
                }
            }
        }
        public Parameter tmtLParameter
        {
            get
            {
                return tmtLParameterValue;
            }
            set
            {
                tmtLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    tmtLOutput = "Gold";
                }
                else
                {
                    tmtLOutput = "Black";
                }
            }
        }
        public Parameter tmtRParameter
        {
            get
            {
                return tmtRParameterValue;
            }
            set
            {
                tmtRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    tmtROutput = "Gold";
                }
                else
                {
                    tmtROutput = "Black";
                }
            }
        }
        public Parameter oilPressureFailureLParameter
        {
            get
            {
                return oilPressureFailureLParameterValue;
            }
            set
            {
                oilPressureFailureLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    oilPressureFailureLOutput = "Gold";
                }
                else
                {
                    oilPressureFailureLOutput = "Black";
                }
            }
        }
        public Parameter oilPressureFailureRParameter
        {
            get
            {
                return oilPressureFailureRParameterValue;
            }
            set
            {
                oilPressureFailureRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    oilPressureFailureROutput = "Gold";
                }
                else
                {
                    oilPressureFailureROutput = "Black";
                }
            }
        }
        public Parameter oilTemaperatureLParameter
        {
            get
            {
                return oilTemaperatureLParameterValue;
            }
            set
            {
                oilTemaperatureLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    oilTemaperatureLOutput = "Gold";
                }
                else
                {
                    oilTemaperatureLOutput = "Black";
                }
            }
        }
        public Parameter oilTemaperatureRParameter
        {
            get
            {
                return oilTemaperatureRParameterValue;
            }
            set
            {
                oilTemaperatureRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    oilTemaperatureROutput = "Gold";
                }
                else
                {
                    oilTemaperatureROutput = "Black";
                }
            }
        }
        public Parameter propOverspeedLParameter
        {
            get
            {
                return propOverspeedLParameterValue;
            }
            set
            {
                propOverspeedLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    propOverspeedLOutput = "Gold";
                }
                else
                {
                    propOverspeedLOutput = "Black";
                }
            }
        }
        public Parameter propOverspeedRParameter
        {
            get
            {
                return propOverspeedRParameterValue;
            }
            set
            {
                propOverspeedRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    propOverspeedROutput = "Gold";
                }
                else
                {
                    propOverspeedROutput = "Black";
                }
            }
        }
        public Parameter featheringMotorFailureLParameter
        {
            get
            {
                return featheringMotorFailureLParameterValue;
            }
            set
            {
                featheringMotorFailureLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    featheringMotorFailureLOutput = "Gold";
                }
                else
                {
                    featheringMotorFailureLOutput = "Black";
                }
            }
        }
        public Parameter featheringMotorFailureRParameter
        {
            get
            {
                return featheringMotorFailureRParameterValue;
            }
            set
            {
                featheringMotorFailureRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    featheringMotorFailureROutput = "Gold";
                }
                else
                {
                    featheringMotorFailureROutput = "Black";
                }
            }
        }
        public Parameter fuelPressureFailureLParameter
        {
            get
            {
                return fuelPressureFailureLParameterValue;
            }
            set
            {
                fuelPressureFailureLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fuelPressureFailureLOutput = "Gold";
                }
                else
                {
                    fuelPressureFailureLOutput = "Black";
                }
            }
        }
        public Parameter fuelPressureFailureRParameter
        {
            get
            {
                return fuelPressureFailureRParameterValue;
            }
            set
            {
                fuelPressureFailureRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fuelPressureFailureROutput = "Gold";
                }
                else
                {
                    fuelPressureFailureROutput = "Black";
                }
            }
        }
        public Parameter ceboLFailureParameter
        {
            get
            {
                return ceboLFailureParameterValue;
            }
            set
            {
                ceboLFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ceboLFailureOutput = "Gold";
                }
                else
                {
                    ceboLFailureOutput = "Black";
                }
            }
        }
        public Parameter ceboRFailureParameter
        {
            get
            {
                return ceboRFailureParameterValue;
            }
            set
            {
                ceboRFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ceboRFailureOutput = "Gold";
                }
                else
                {
                    ceboRFailureOutput = "Black";
                }
            }
        }
        public Parameter fuelFlowLFailureParameter
        {
            get
            {
                return fuelFlowLFailureParameterValue;
            }
            set
            {
                fuelFlowLFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fuelFlowLFailureOutput = "Gold";
                }
                else
                {
                    fuelFlowLFailureOutput = "Black";
                }
            }
        }
        public Parameter fuelFlowRFailureParameter
        {
            get
            {
                return fuelFlowRFailureParameterValue;
            }
            set
            {
                fuelFlowRFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fuelFlowRFailureOutput = "Gold";
                }
                else
                {
                    fuelFlowRFailureOutput = "Black";
                }
            }
        }
        #endregion

        #region Avionics parameters
        public Parameter reserveAttitudeIndicatorFailureParameter
        {
            get
            {
                return reserveAttitudeIndicatorFailureParameterValue;
            }
            set
            {
                reserveAttitudeIndicatorFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    reserveAttitudeIndicatorFailureOutput = "Gold";
                }
                else
                {
                    reserveAttitudeIndicatorFailureOutput = "Black";
                }
            }
        }
        public Parameter UKV1FailureParameter
        {
            get
            {
                return UKV1FailureParameterValue;
            }
            set
            {
                UKV1FailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    UKV1FailureOutput = "Gold";
                }
                else
                {
                    UKV1FailureOutput = "Black";
                }
            }
        }
        public Parameter GMKFailureParameter
        {
            get
            {
                return GMKFailureParameterValue;
            }
            set
            {
                GMKFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    GMKFailureOutput = "Gold";
                }
                else
                {
                    GMKFailureOutput = "Black";
                }
            }
        }
        public Parameter radioAltimeterFailureParameter
        {
            get
            {
                return radioAltimeterFailureParameterValue;
            }
            set
            {
                radioAltimeterFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    radioAltimeterFailureOutput = "Gold";
                }
                else
                {
                    radioAltimeterFailureOutput = "Black";
                }
            }
        }
        public Parameter RMIFailureParameter
        {
            get
            {
                return RMIFailureParameterValue;
            }
            set
            {
                RMIFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    RMIFailureOutput = "Gold";
                }
                else
                {
                    RMIFailureOutput = "Black";
                }
            }
        }
        public Parameter radioFailureParameter
        {
            get
            {
                return radioFailureParameterValue;
            }
            set
            {
                radioFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    radioFailureOutput = "Gold";
                }
                else
                {
                    radioFailureOutput = "Black";
                }
            }
        }
        public Parameter ilsFailureParameter
        {
            get
            {
                return ilsFailureParameterValue;
            }
            set
            {
                ilsFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ilsFailureOutput = "Gold";
                }
                else
                {
                    ilsFailureOutput = "Black";
                }
            }
        }
        public Parameter markerBeaconLightFailureParameter
        {
            get
            {
                return markerBeaconLightFailureParameterValue;
            }
            set
            {
                markerBeaconLightFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    markerBeaconLightFailureOutput = "Gold";
                }
                else
                {
                    markerBeaconLightFailureOutput = "Black";
                }
            }
        }
        public Parameter markerBeaconSoundFailureParameter
        {
            get
            {
                return markerBeaconSoundFailureParameterValue;
            }
            set
            {
                markerBeaconSoundFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    markerBeaconSoundFailureOutput = "Gold";
                }
                else
                {
                    markerBeaconSoundFailureOutput = "Black";
                }
            }
        }
        public Parameter rpmIndicatorLFailureParameter
        {
            get
            {
                return rpmIndicatorLFailureParameterValue;
            }
            set
            {
                rpmIndicatorLFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rpmIndicatorLFailureOutput = "Gold";
                }
                else
                {
                    rpmIndicatorLFailureOutput = "Black";
                }
            }
        }
        public Parameter rpmIndicatorRFailureParameter
        {
            get
            {
                return rpmIndicatorRFailureParameterValue;
            }
            set
            {
                rpmIndicatorRFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rpmIndicatorRFailureOutput = "Gold";
                }
                else
                {
                    rpmIndicatorRFailureOutput = "Black";
                }
            }
        }
        public Parameter mkIndicatorLFailureParameter
        {
            get
            {
                return mkIndicatorLFailureParameterValue;
            }
            set
            {
                mkIndicatorLFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    mkIndicatorLFailureOutput = "Gold";
                }
                else
                {
                    mkIndicatorLFailureOutput = "Black";
                }
            }
        }
        public Parameter mkIndicatorRFailureParameter
        {
            get
            {
                return mkIndicatorRFailureParameterValue;
            }
            set
            {
                mkIndicatorRFailureParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    mkIndicatorRFailureOutput = "Gold";
                }
                else
                {
                    mkIndicatorRFailureOutput = "Black";
                }
            }
        }
        public Parameter attitudeIndicatorPitchDriftLParameter
        {
            get
            {
                return attitudeIndicatorPitchDriftLParameterValue;
            }
            set
            {
                attitudeIndicatorPitchDriftLParameterValue = value;
            }
        }
        public Parameter attitudeIndicatorPitchDriftRParameter
        {
            get
            {
                return attitudeIndicatorPitchDriftRParameterValue;
            }
            set
            {
                attitudeIndicatorPitchDriftRParameterValue = value;
            }
        }
        public Parameter attitudeIndicatorRollDriftLParameter
        {
            get
            {
                return attitudeIndicatorRollDriftLParameterValue;
            }
            set
            {
                attitudeIndicatorRollDriftLParameterValue = value;
            }
        }
        public Parameter attitudeIndicatorRollDriftRParameter
        {
            get
            {
                return attitudeIndicatorRollDriftRParameterValue;
            }
            set
            {
                attitudeIndicatorRollDriftRParameterValue = value;
            }
        }
        #endregion

        #endregion

        #region Output Values

        #region Power output
        public string busDeadShotOutput
        {
            get { return busDeadShotOutputValue; }
            set
            {
                busDeadShotOutputValue = value;
                OnPropertyChanged("busDeadShotOutput");
            }
        }
        public string genFailureOutput
        {
            get { return genFailureOutputValue; }
            set
            {
                genFailureOutputValue = value;
                OnPropertyChanged("genFailureOutput");
            }
        }
        public string transducerFailure1Output
        {
            get { return transducerFailure1OutputValue; }
            set
            {
                transducerFailure1OutputValue = value;
                OnPropertyChanged("transducerFailure1Output");
            }
        }
        public string transducerFailure3Output
        {
            get { return transducerFailure3OutputValue; }
            set
            {
                transducerFailure3OutputValue = value;
                OnPropertyChanged("transducerFailure3Output");
            }
        }
        #endregion

        #region Airframe output
        public string icingOutput
        {
            get { return icingOutputValue; }
            set
            {
                icingOutputValue = value;
                OnPropertyChanged("icingOutput");
            }
        }
        public string hydraulicFailureOutput
        {
            get { return hydraulicFailureOutputValue; }
            set
            {
                hydraulicFailureOutputValue = value;
                OnPropertyChanged("hydraulicFailureOutput");
            }
        }
        public string cycFailureOutput
        {
            get { return cycFailureOutputValue; }
            set
            {
                cycFailureOutputValue = value;
                OnPropertyChanged("cycFailureOutput");
            }
        }
        public string generalPressureFailureOutput
        {
            get { return generalPressureFailureOutputValue; }
            set
            {
                generalPressureFailureOutputValue = value;
                OnPropertyChanged("generalPressureFailureOutput");
            }
        }
        public string gearsFailureOutput
        {
            get { return gearsFailureOutputValue; }
            set
            {
                gearsFailureOutputValue = value;
                OnPropertyChanged("gearsFailureOutput");
            }
        }
        public string flapsFailureOutput
        {
            get { return flapsFailureOutputValue; }
            set
            {
                flapsFailureOutputValue = value;
                OnPropertyChanged("flapsFailureOutput");
            }
        }
        public string breakLFailureOutput
        {
            get { return breakLFailureOutputValue; }
            set
            {
                breakLFailureOutputValue = value;
                OnPropertyChanged("breakLFailureOutput");
            }
        }
        public string breakRFailureOutput
        {
            get { return breakRFailureOutputValue; }
            set
            {
                breakRFailureOutputValue = value;
                OnPropertyChanged("breakRFailureOutput");
            }
        }
        public string staticPressureFailureOutput
        {
            get { return staticPressureFailureOutputValue; }
            set
            {
                staticPressureFailureOutputValue = value;
                OnPropertyChanged("staticPressureFailureOutput");
            }
        }
        public double aileronTrimTabFailureOutput
        {
            get { return aileronTrimTabFailureOutputValue; }
            set
            {
                aileronTrimTabFailureOutputValue = value;
                OnPropertyChanged("aileronTrimTabFailureOutput");
            }
        }
        public double rudderTrimTabFailureOutput
        {
            get { return rudderTrimTabFailureOutputValue; }
            set
            {
                rudderTrimTabFailureOutputValue = value;
                OnPropertyChanged("rudderTrimTabFailureOutput");
            }
        }
        #endregion

        #region Engine output
        public string fireLOutput
        {
            get { return fireLOutputValue; }
            set
            {
                fireLOutputValue = value;
                OnPropertyChanged("fireLOutput");
            }
        }
        public string fireROutput
        {
            get { return fireROutputValue; }
            set
            {
                fireROutputValue = value;
                OnPropertyChanged("fireROutput");
            }
        }
        public string engStopLOutput
        {
            get { return engStopLOutputValue; }
            set
            {
                engStopLOutputValue = value;
                OnPropertyChanged("engStopLOutput");
            }
        }
        public string engStopROutput
        {
            get { return engStopROutputValue; }
            set
            {
                engStopROutputValue = value;
                OnPropertyChanged("engStopROutput");
            }
        }
        public string engHoldupLOutput
        {
            get { return engHoldupLOutputValue; }
            set
            {
                engHoldupLOutputValue = value;
                OnPropertyChanged("engHoldupLOutput");
            }
        }
        public string engHoldupROutput
        {
            get { return engHoldupROutputValue; }
            set
            {
                engHoldupROutputValue = value;
                OnPropertyChanged("engHoldupROutput");
            }
        }
        public string tmtLOutput
        {
            get { return tmtLOutputValue; }
            set
            {
                tmtLOutputValue = value;
                OnPropertyChanged("tmtLOutput");
            }
        }
        public string tmtROutput
        {
            get { return tmtROutputValue; }
            set
            {
                tmtROutputValue = value;
                OnPropertyChanged("tmtROutput");
            }
        }
        public string oilPressureFailureLOutput
        {
            get { return oilPressureFailureLOutputValue; }
            set
            {
                oilPressureFailureLOutputValue = value;
                OnPropertyChanged("oilPressureFailureLOutput");
            }
        }
        public string oilPressureFailureROutput
        {
            get { return oilPressureFailureROutputValue; }
            set
            {
                oilPressureFailureROutputValue = value;
                OnPropertyChanged("oilPressureFailureROutput");
            }
        }
        public string oilTemaperatureLOutput
        {
            get { return oilTemaperatureLOutputValue; }
            set
            {
                oilTemaperatureLOutputValue = value;
                OnPropertyChanged("oilTemaperatureLOutput");
            }
        }
        public string oilTemaperatureROutput
        {
            get { return oilTemaperatureROutputValue; }
            set
            {
                oilTemaperatureROutputValue = value;
                OnPropertyChanged("oilTemaperatureROutput");
            }
        }
        public string propOverspeedLOutput
        {
            get { return propOverspeedLOutputValue; }
            set
            {
                propOverspeedLOutputValue = value;
                OnPropertyChanged("propOverspeedLOutput");
            }
        }
        public string propOverspeedROutput
        {
            get { return propOverspeedROutputValue; }
            set
            {
                propOverspeedROutputValue = value;
                OnPropertyChanged("propOverspeedROutput");
            }
        }
        public string featheringMotorFailureLOutput
        {
            get { return featheringMotorFailureLOutputValue; }
            set
            {
                featheringMotorFailureLOutputValue = value;
                OnPropertyChanged("featheringMotorFailureLOutput");
            }
        }
        public string featheringMotorFailureROutput
        {
            get { return featheringMotorFailureROutputValue; }
            set
            {
                featheringMotorFailureROutputValue = value;
                OnPropertyChanged("featheringMotorFailureROutput");
            }
        }
        public string fuelPressureFailureLOutput
        {
            get { return fuelPressureFailureLOutputValue; }
            set
            {
                fuelPressureFailureLOutputValue = value;
                OnPropertyChanged("fuelPressureFailureLOutput");
            }
        }
        public string fuelPressureFailureROutput
        {
            get { return fuelPressureFailureROutputValue; }
            set
            {
                fuelPressureFailureROutputValue = value;
                OnPropertyChanged("fuelPressureFailureROutput");
            }
        }
        public string ceboLFailureOutput
        {
            get { return ceboLFailureOutputValue; }
            set
            {
                ceboLFailureOutputValue = value;
                OnPropertyChanged("ceboLFailureOutput");
            }
        }
        public string ceboRFailureOutput
        {
            get { return ceboRFailureOutputValue; }
            set
            {
                ceboRFailureOutputValue = value;
                OnPropertyChanged("ceboRFailureOutput");
            }
        }
        public string fuelFlowLFailureOutput
        {
            get { return fuelFlowLFailureOutputValue; }
            set
            {
                fuelFlowLFailureOutputValue = value;
                OnPropertyChanged("fuelFlowLFailureOutput");
            }
        }
        public string fuelFlowRFailureOutput
        {
            get { return fuelFlowRFailureOutputValue; }
            set
            {
                fuelFlowRFailureOutputValue = value;
                OnPropertyChanged("fuelFlowRFailureOutput");
            }
        }
        #endregion

        #region Avionics output
        public string reserveAttitudeIndicatorFailureOutput
        {
            get { return reserveAttitudeIndicatorFailureOutputValue; }
            set
            {
                reserveAttitudeIndicatorFailureOutputValue = value;
                OnPropertyChanged("reserveAttitudeIndicatorFailureOutput");
            }
        }
        public string UKV1FailureOutput
        {
            get { return UKV1FailureOutputValue; }
            set
            {
                UKV1FailureOutputValue = value;
                OnPropertyChanged("UKV1FailureOutput");
            }
        }
        public string GMKFailureOutput
        {
            get { return GMKFailureOutputValue; }
            set
            {
                GMKFailureOutputValue = value;
                OnPropertyChanged("GMKFailureOutput");
            }
        }
        public string radioAltimeterFailureOutput
        {
            get { return radioAltimeterFailureOutputValue; }
            set
            {
                radioAltimeterFailureOutputValue = value;
                OnPropertyChanged("radioAltimeterFailureOutput");
            }
        }
        public string RMIFailureOutput
        {
            get { return RMIFailureOutputValue; }
            set
            {
                RMIFailureOutputValue = value;
                OnPropertyChanged("RMIFailureOutput");
            }
        }
        public string radioFailureOutput
        {
            get { return radioFailureOutputValue; }
            set
            {
                radioFailureOutputValue = value;
                OnPropertyChanged("radioFailureOutput");
            }
        }
        public string ilsFailureOutput
        {
            get { return ilsFailureOutputValue; }
            set
            {
                ilsFailureOutputValue = value;
                OnPropertyChanged("ilsFailureOutput");
            }
        }
        public string markerBeaconLightFailureOutput
        {
            get { return markerBeaconLightFailureOutputValue; }
            set
            {
                markerBeaconLightFailureOutputValue = value;
                OnPropertyChanged("markerBeaconLightFailureOutput");
            }
        }
        public string markerBeaconSoundFailureOutput
        {
            get { return markerBeaconSoundFailureOutputValue; }
            set
            {
                markerBeaconSoundFailureOutputValue = value;
                OnPropertyChanged("markerBeaconSoundFailureOutput");
            }
        }
        public string rpmIndicatorLFailureOutput
        {
            get { return rpmIndicatorLFailureOutputValue; }
            set
            {
                rpmIndicatorLFailureOutputValue = value;
                OnPropertyChanged("rpmIndicatorLFailureOutput");
            }
        }
        public string rpmIndicatorRFailureOutput
        {
            get { return rpmIndicatorRFailureOutputValue; }
            set
            {
                rpmIndicatorRFailureOutputValue = value;
                OnPropertyChanged("rpmIndicatorRFailureOutput");
            }
        }
        public string mkIndicatorLFailureOutput
        {
            get { return mkIndicatorLFailureOutputValue; }
            set
            {
                mkIndicatorLFailureOutputValue = value;
                OnPropertyChanged("mkIndicatorLFailureOutput");
            }
        }
        public string mkIndicatorRFailureOutput
        {
            get { return mkIndicatorRFailureOutputValue; }
            set
            {
                mkIndicatorRFailureOutputValue = value;
                OnPropertyChanged("mkIndicatorRFailureOutput");
            }
        }
        public double attitudeIndicatorPitchDriftLOutput
        {
            get { return attitudeIndicatorPitchDriftLOutputValue; }
            set
            {
                attitudeIndicatorPitchDriftLOutputValue = value;
                OnPropertyChanged("attitudeIndicatorPitchDriftLOutput");
            }
        }
        public double attitudeIndicatorPitchDriftROutput
        {
            get { return attitudeIndicatorPitchDriftROutputValue; }
            set
            {
                attitudeIndicatorPitchDriftROutputValue = value;
                OnPropertyChanged("attitudeIndicatorPitchDriftROutput");
            }
        }
        public double attitudeIndicatorRollDriftLOutput
        {
            get { return attitudeIndicatorRollDriftLOutputValue; }
            set
            {
                attitudeIndicatorRollDriftLOutputValue = value;
                OnPropertyChanged("attitudeIndicatorRollDriftLOutput");
            }
        }
        public double attitudeIndicatorRollDriftROutput
        {
            get { return attitudeIndicatorRollDriftROutputValue; }
            set
            {
                attitudeIndicatorRollDriftROutputValue = value;
                OnPropertyChanged("attitudeIndicatorRollDriftROutput");
            }
        }
        #endregion

        #endregion

        #region Input Values

        #region Airframe inputs
        public double aileronTrimTabFailureInput
        {
            get { return aileronTrimTabFailureInputValue; }
            set
            {
                aileronTrimTabFailureInputValue = value;
                aileronTrimTabFailureParameter = new Parameter("123", value);
                OnPropertyChanged("aileronTrimTabFailureInput");
            }
        }

        public double rudderTrimTabFailureInput
        {
            get { return rudderTrimTabFailureInputValue; }
            set
            {
                rudderTrimTabFailureInputValue = value;
                rudderTrimTabFailureParameter = new Parameter("123", value);
                OnPropertyChanged("rudderTrimTabFailureInput");
            }
        }
        #endregion

        #region Avionics
        public double attitudeIndicatorPitchDriftLInput
        {
            get { return attitudeIndicatorPitchDriftLInputValue; }
            set
            {
                attitudeIndicatorPitchDriftLInputValue = value;
                attitudeIndicatorPitchDriftLParameter = new Parameter("123", value);
                OnPropertyChanged("attitudeIndicatorPitchDriftLInput");
            }
        }
        public double attitudeIndicatorPitchDriftRInput
        {
            get { return attitudeIndicatorPitchDriftRInputValue; }
            set
            {
                attitudeIndicatorPitchDriftRInputValue = value;
                attitudeIndicatorPitchDriftRParameter = new Parameter("123", value);
                OnPropertyChanged("attitudeIndicatorPitchDriftRInput");
            }
        }
        public double attitudeIndicatorRollDriftLInput
        {
            get { return attitudeIndicatorRollDriftLInputValue; }
            set
            {
                attitudeIndicatorRollDriftLInputValue = value;
                attitudeIndicatorRollDriftLParameter = new Parameter("1231", value);
                OnPropertyChanged("attitudeIndicatorRollDriftLInput");
            }
        }
        public double attitudeIndicatorRollDriftRInput
        {
            get { return attitudeIndicatorRollDriftRInputValue; }
            set
            {
                attitudeIndicatorRollDriftRInputValue = value;
                attitudeIndicatorRollDriftRParameter = new Parameter("1231", value);
                OnPropertyChanged("attitudeIndicatorRollDriftRInput");
            }
        }
        #endregion
        #endregion

        #region Registration Area

        #region Power
        [MediatorMessageSink("123")]
        private void busDeadShotParameterUpdate(object updateParameter)
        {
            busDeadShotParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void genFailureParameterParameterUpdate(object updateParameter)
        {
            genFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void transducerFailure1ParameterUpdate(object updateParameter)
        {
            transducerFailure1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void transducerFailure3ParameterUpdate(object updateParameter)
        {
            transducerFailure3Parameter = (Parameter)updateParameter;
        }
        #endregion

        #region Airframe
        [MediatorMessageSink("123")]
        private void icingParameterUpdate(object updateParameter)
        {
            icingParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void hydraulicFailureParameterUpdate(object updateParameter)
        {
            hydraulicFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void cycFailureParameterUpdate(object updateParameter)
        {
            cycFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void generalPressureFailureParameterUpdate(object updateParameter)
        {
            generalPressureFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void gearsFailureParameterUpdate(object updateParameter)
        {
            gearsFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void flapsFailureParameterUpdate(object updateParameter)
        {
            flapsFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void breakLFailureParameterUpdate(object updateParameter)
        {
            breakLFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void breakRFailureParameterUpdate(object updateParameter)
        {
            breakRFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fst1")]
        private void staticPressureFailureParameterUpdate(object updateParameter)
        {
            staticPressureFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void aileronTrimTabFailureParameterUpdate(object updateParameter)
        {
            aileronTrimTabFailureParameter = (Parameter)updateParameter;
            aileronTrimTabFailureOutput = aileronTrimTabFailureParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("123")]
        private void rudderTrimTabFailureParameterUpdate(object updateParameter)
        {
            rudderTrimTabFailureParameter = (Parameter)updateParameter;
            rudderTrimTabFailureOutput = rudderTrimTabFailureParameter.GetValueAsDouble();
        }
        #endregion

        #region Engine
        [MediatorMessageSink("123")]
        private void fireLParameterUpdate(object updateParameter)
        {
            fireLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void fireRParameterUpdate(object updateParameter)
        {
            fireRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fef1")]
        private void engStopLParameterUpdate(object updateParameter)
        {
            engStopLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fef2")]
        private void engStopRParameterUpdate(object updateParameter)
        {
            engStopRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fvis1")]
        private void engHoldupLParameterUpdate(object updateParameter)
        {
            engHoldupLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fvis2")]
        private void engHoldupRParameterUpdate(object updateParameter)
        {
            engHoldupRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fztt1")]
        private void tmtLParameterUpdate(object updateParameter)
        {
            tmtLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fztt2")]
        private void tmtRParameterUpdate(object updateParameter)
        {
            tmtRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzol1")]
        private void oilPressureFailureLParameterUpdate(object updateParameter)
        {
            oilPressureFailureLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzol2")]
        private void oilPressureFailureRParameterUpdate(object updateParameter)
        {
            oilPressureFailureRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzto1")]
        private void oilTemaperatureLParameterUpdate(object updateParameter)
        {
            oilTemaperatureLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzto2")]
        private void oilTemaperatureRParameterUpdate(object updateParameter)
        {
            oilTemaperatureRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzrv1")]
        private void propOverspeedLParameterUpdate(object updateParameter)
        {
            propOverspeedLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzrv2")]
        private void propOverspeedRParameterUpdate(object updateParameter)
        {
            propOverspeedRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzpr1")]
        private void featheringMotorFailureLParameterUpdate(object updateParameter)
        {
            featheringMotorFailureLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzpr2")]
        private void featheringMotorFailureRParameterUpdate(object updateParameter)
        {
            featheringMotorFailureRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fztp1")]
        private void fuelPressureFailureLParameterUpdate(object updateParameter)
        {
            fuelPressureFailureLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fztp2")]
        private void fuelPressureFailureRParameterUpdate(object updateParameter)
        {
            fuelPressureFailureRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void ceboLFailureParameterUpdate(object updateParameter)
        {
            ceboLFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void ceboRFailureParameterUpdate(object updateParameter)
        {
            ceboRFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzns1")]
        private void fuelFlowLFailureParameterUpdate(object updateParameter)
        {
            fuelFlowLFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fzns2")]
        private void fuelFlowRFailureParameterUpdate(object updateParameter)
        {
            fuelFlowRFailureParameter = (Parameter)updateParameter;
        }
        #endregion

        #region Avionics 
        [MediatorMessageSink("123")]
        private void reserveAttitudeIndicatorFailureParameterUpdate(object updateParameter)
        {
            reserveAttitudeIndicatorFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void UKV1FailureParameterUpdate(object updateParameter)
        {
            UKV1FailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void GMKFailureParameterUpdate(object updateParameter)
        {
            GMKFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void radioAltimeterFailureParameterUpdate(object updateParameter)
        {
            radioAltimeterFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void RMIFailureParameterUpdate(object updateParameter)
        {
            RMIFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void radioFailureParameterUpdate(object updateParameter)
        {
            radioFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void ilsFailureParameterUpdate(object updateParameter)
        {
            ilsFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void markerBeaconLightFailureParameterUpdate(object updateParameter)
        {
            markerBeaconLightFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void markerBeaconSoundFailureParameterUpdate(object updateParameter)
        {
            markerBeaconSoundFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void rpmIndicatorLFailureParameterUpdate(object updateParameter)
        {
            rpmIndicatorLFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void rpmIndicatorRFailureParameterUpdate(object updateParameter)
        {
            rpmIndicatorRFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void mkIndicatorLFailureParameterUpdate(object updateParameter)
        {
            mkIndicatorLFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void mkIndicatorRFailureParameterUpdate(object updateParameter)
        {
            mkIndicatorRFailureParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("123")]
        private void attitudeIndicatorPitchDriftLParameterUpdate(object updateParameter)
        {
            attitudeIndicatorPitchDriftLParameter = (Parameter)updateParameter;
            attitudeIndicatorPitchDriftLOutput = attitudeIndicatorPitchDriftLParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("123")]
        private void attitudeIndicatorPitchDriftRParameterUpdate(object updateParameter)
        {
            attitudeIndicatorPitchDriftRParameter = (Parameter)updateParameter;
            attitudeIndicatorPitchDriftROutput = attitudeIndicatorPitchDriftRParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("1231")]
        private void attitudeIndicatorRollDriftLParameterUpdate(object updateParameter)
        {
            attitudeIndicatorRollDriftLParameter = (Parameter)updateParameter;
            attitudeIndicatorRollDriftLOutput = attitudeIndicatorRollDriftLParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("1231")]
        private void attitudeIndicatorRollDriftRParameterUpdate(object updateParameter)
        {
            attitudeIndicatorRollDriftRParameter = (Parameter)updateParameter;
            attitudeIndicatorRollDriftROutput = attitudeIndicatorRollDriftRParameter.GetValueAsDouble();
        }
        #endregion

        #endregion
        private void Send(object parameter)
        {
            Parameter outputParameter = (Parameter)parameter;
            if (outputParameter.GetValueAsInt() == 1)
            {
                outputParameter.SetValue(0);
            }
            else
            {
                outputParameter.SetValue(1);
            }
            Mediator.Instance.CommunicatorSend(outputParameter);
        }

        private void sliderSend(object parameter)
        {
            Parameter outputParameter = (Parameter)parameter;
            Mediator.Instance.CommunicatorSend(outputParameter);
        }

        private void attitudeIndicatorDriftL(object parameter)
        {
            Mediator.Instance.CommunicatorSend(attitudeIndicatorPitchDriftLParameter);
            Mediator.Instance.CommunicatorSend(attitudeIndicatorRollDriftLParameter);
        }
        private void attitudeIndicatorDriftR(object parameter)
        {
            Mediator.Instance.CommunicatorSend(attitudeIndicatorPitchDriftRParameter);
            Mediator.Instance.CommunicatorSend(attitudeIndicatorRollDriftRParameter);
        }
    }
}
