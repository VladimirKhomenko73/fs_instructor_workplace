using System;
using System.Windows.Controls;
using System.Windows.Input;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;

namespace TL410InstructorsWorkplace.ViewModel
{
    class ConditionPanelViewModel : INPCBase
    {
        public ICommand sendCommand { get; private set; }
        public ICommand sendSliderCommand { get; private set; }

        #region Parameter value
        private Parameter minimumCloudLevelParameterValue;
        private Parameter maximumCloudLevelParameterValue;
        private Parameter aerodromeLevelParameterValue;
        private Parameter runwayHeading1ParameterValue;
        private Parameter runwayHeading2ParameterValue;
        private Parameter windHeadingParameterValue;
        private Parameter windSpeedParameterValue;
        private Parameter landingRunwayVisibilityParameterValue;
        private Parameter takeoffRunwayVisibilityParameterValue;
        private Parameter pressureChangeParameterValue;
        private Parameter temperatureChangeParameterValue;
        private Parameter nightTimeParameterValue;
        private Parameter fuelLParameterValue;
        private Parameter fuelRParameterValue;
        private Parameter externalPowerSourceParameterValue;
        private Parameter chockParameterValue;
        private Parameter cargoWeightParameterValue;
        private Parameter cogParameterValue;
        #endregion

        #region Output value
        private double minimumCloudLevelOutputValue;
        private double maximumCloudLevelOutputValue;
        private double aerodromeLevelOutputValue;
        private double runwayHeading1OutputValue;
        private double runwayHeading2OutputValue;
        private double windHeadingOutputValue;
        private double windSpeedOutputValue;
        private double landingRunwayVisibilityOutputValue;
        private double takeoffRunwayVisibilityOutputValue;
        private double pressureChangeOutputValue;
        private double temperatureChangeOutputValue;
        private string nightTimeOutputValue;
        private double fuelLOutputValue;
        private double fuelROutputValue;
        private double cargoWeightOutputValue;
        private double cogOutputValue;
        private string externalPowerSourceOutputValue;
        private string chockOutputValue;
        #endregion

        #region Input value
        private double minimumCloudLevelInputValue;
        private double maximumCloudLevelInputValue;
        private double aerodromeLevelInputValue;
        private double runwayHeading1InputValue;
        private double runwayHeading2InputValue;
        private double windHeadingInputValue;
        private double windSpeedInputValue;
        private double landingRunwayVisibilityInputValue;
        private double takeoffRunwayVisibilityInputValue;
        private double pressureChangeInputValue;
        private double temperatureChangeInputValue;
        private double fuelLInputValue;
        private double fuelRInputValue;
        private double cargoWeightInputValue;
        private double cogInputValue;
        #endregion

        #region Constructor
        public ConditionPanelViewModel()
        {
            sendCommand = new RelayCommand(Send);
            sendSliderCommand = new RelayCommand(sliderSend);

            #region First start check

            if (Mediator.ContainsBufferedParameter("cdmn"))
            {
                minimumCloudLevelParameter = Mediator.GetBufferedParameter("cdmn");
                minimumCloudLevelOutput = minimumCloudLevelParameter.GetValueAsDouble();
                minimumCloudLevelInput = minimumCloudLevelParameter.GetValueAsDouble();
            }
            else
            {
                minimumCloudLevelParameter = new Parameter("cdmn", 0);
                minimumCloudLevelOutput = minimumCloudLevelParameter.GetValueAsDouble();
                minimumCloudLevelInput = minimumCloudLevelParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("cdmx"))
            {
                maximumCloudLevelParameter = Mediator.GetBufferedParameter("cdmx");
                maximumCloudLevelOutput = maximumCloudLevelParameter.GetValueAsDouble();
                maximumCloudLevelInput = maximumCloudLevelParameter.GetValueAsDouble();
            }
            else
            {
                maximumCloudLevelParameter = new Parameter("cdmx", 0);
                maximumCloudLevelOutput = maximumCloudLevelParameter.GetValueAsDouble();
                maximumCloudLevelInput = maximumCloudLevelParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("hl"))
            {
                aerodromeLevelParameter = Mediator.GetBufferedParameter("hl");
                aerodromeLevelOutput = aerodromeLevelParameter.GetValueAsDouble();
                aerodromeLevelInput = aerodromeLevelParameter.GetValueAsDouble();
            }
            else
            {
                aerodromeLevelParameter = new Parameter("hl", 0);
                aerodromeLevelOutput = aerodromeLevelParameter.GetValueAsDouble();
                aerodromeLevelInput = aerodromeLevelParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("psl1"))
            {
                runwayHeading1Parameter = Mediator.GetBufferedParameter("psl1");
                runwayHeading1Output = runwayHeading1Parameter.GetValueAsDouble();
                runwayHeading1Input = runwayHeading1Parameter.GetValueAsDouble();
            }
            else
            {
                runwayHeading1Parameter = new Parameter("psl1", 360);
                runwayHeading1Output = runwayHeading1Parameter.GetValueAsDouble();
                runwayHeading1Input = runwayHeading1Parameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("psl2"))
            {
                runwayHeading2Parameter = Mediator.GetBufferedParameter("psl2");
                runwayHeading2Output = runwayHeading2Parameter.GetValueAsDouble();
                runwayHeading2Input = runwayHeading2Parameter.GetValueAsDouble();
            }
            else
            {
                runwayHeading2Parameter = new Parameter("psl2", 360);
                runwayHeading2Output = runwayHeading2Parameter.GetValueAsDouble();
                runwayHeading2Input = runwayHeading2Parameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("psiv"))
            {
                windHeadingParameter = Mediator.GetBufferedParameter("psiv");
                windHeadingOutput = windHeadingParameter.GetValueAsDouble();
                windHeadingInput = windHeadingParameter.GetValueAsDouble();
            }
            else
            {
                windHeadingParameter = new Parameter("psiv", 360);
                windHeadingOutput = windHeadingParameter.GetValueAsDouble();
                windHeadingInput = windHeadingParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("vv"))
            {
                windSpeedParameter = Mediator.GetBufferedParameter("vv");
                windSpeedOutput = windSpeedParameter.GetValueAsDouble();
                windSpeedInput = windSpeedParameter.GetValueAsDouble();
            }
            else
            {
                windSpeedParameter = new Parameter("vv", 0);
                windSpeedOutput = windSpeedParameter.GetValueAsDouble();
                windSpeedInput = windSpeedParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("lrvl"))
            {
                landingRunwayVisibilityParameter = Mediator.GetBufferedParameter("lrvl");
                landingRunwayVisibilityOutput = landingRunwayVisibilityParameter.GetValueAsDouble();
                landingRunwayVisibilityInput = landingRunwayVisibilityParameter.GetValueAsDouble();
            }
            else
            {
                landingRunwayVisibilityParameter = new Parameter("lrvl", 0);
                landingRunwayVisibilityOutput = landingRunwayVisibilityParameter.GetValueAsDouble();
                landingRunwayVisibilityInput = landingRunwayVisibilityParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("trvl"))
            {
                takeoffRunwayVisibilityParameter = Mediator.GetBufferedParameter("trvl");
                takeoffRunwayVisibilityOutput = takeoffRunwayVisibilityParameter.GetValueAsDouble();
                takeoffRunwayVisibilityInput = takeoffRunwayVisibilityParameter.GetValueAsDouble();
            }
            else
            {
                takeoffRunwayVisibilityParameter = new Parameter("trvl", 0);
                takeoffRunwayVisibilityOutput = takeoffRunwayVisibilityParameter.GetValueAsDouble();
                takeoffRunwayVisibilityInput = takeoffRunwayVisibilityParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("depa"))
            {
                pressureChangeParameter = Mediator.GetBufferedParameter("depa");
                pressureChangeOutput = pressureChangeParameter.GetValueAsDouble();
                pressureChangeInput = pressureChangeParameter.GetValueAsDouble();
            }
            else
            {
                pressureChangeParameter = new Parameter("depa", 0);
                pressureChangeOutput = pressureChangeParameter.GetValueAsDouble();
                pressureChangeInput = pressureChangeParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("deto"))
            {
                temperatureChangeParameter = Mediator.GetBufferedParameter("deto");
                temperatureChangeOutput = temperatureChangeParameter.GetValueAsDouble();
                temperatureChangeInput = temperatureChangeParameter.GetValueAsDouble();
            }
            else
            {
                temperatureChangeParameter = new Parameter("deto", 0);
                temperatureChangeOutput = temperatureChangeParameter.GetValueAsDouble();
                temperatureChangeInput = temperatureChangeParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("nitt"))
            {
                nightTimeParameter = Mediator.GetBufferedParameter("nitt");
            }
            else
            {
                nightTimeParameter = new Parameter("nitt", 0);
            }
            if (Mediator.ContainsBufferedParameter("gp1"))
            {
                fuelLParameter = Mediator.GetBufferedParameter("gp1");
                fuelLOutput = fuelLParameter.GetValueAsDouble();
                fuelLInput = fuelLParameter.GetValueAsDouble();
            }
            else
            {
                fuelLParameter = new Parameter("gp1", 0);
                fuelLOutput = fuelLParameter.GetValueAsDouble();
                fuelLInput = fuelLParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("gp2"))
            {
                fuelRParameter = Mediator.GetBufferedParameter("gp2");
                fuelROutput = fuelRParameter.GetValueAsDouble();
                fuelRInput = fuelRParameter.GetValueAsDouble();
            }
            else
            {
                fuelRParameter = new Parameter("gp2", 0);
                fuelROutput = fuelRParameter.GetValueAsDouble();
                fuelRInput = fuelRParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("na"))
            {
                cargoWeightParameter = Mediator.GetBufferedParameter("na");
                cargoWeightOutput = cargoWeightParameter.GetValueAsDouble();
                cargoWeightInput = cargoWeightParameter.GetValueAsDouble();
            }
            else
            {
                cargoWeightParameter = new Parameter("na", 0);
                cargoWeightOutput = cargoWeightParameter.GetValueAsDouble();
                cargoWeightInput = cargoWeightParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("xtez"))
            {
                cogParameter = Mediator.GetBufferedParameter("xtez");
                cogOutput = cogParameter.GetValueAsDouble();
                cogInput = cogParameter.GetValueAsDouble();
            }
            else
            {
                cogParameter = new Parameter("xtez", 0);
                cogOutput = cogParameter.GetValueAsDouble();
                cogInput = cogParameter.GetValueAsDouble();
            }
            if (Mediator.ContainsBufferedParameter("fep"))
            {
                externalPowerSourceParameter = Mediator.GetBufferedParameter("fep");
            }
            else
            {
                externalPowerSourceParameter = new Parameter("fep", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsp"))
            {
                chockParameter = Mediator.GetBufferedParameter("fsp");
            }
            else
            {
                chockParameter = new Parameter("fsp", 0);
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion

        }
        #endregion

        #region Destructor
        ~ConditionPanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties
        public Parameter minimumCloudLevelParameter
        {
            get
            {
                return minimumCloudLevelParameterValue;
            }
            set
            {
                minimumCloudLevelParameterValue = value;
                OnPropertyChanged("minimumCloudLevelParameter");
            }
        }
        public Parameter maximumCloudLevelParameter
        {
            get
            {
                return maximumCloudLevelParameterValue;
            }
            set
            {
                maximumCloudLevelParameterValue = value;
                OnPropertyChanged("maximumCloudLevelParameter");
            }
        }
        public Parameter aerodromeLevelParameter
        {
            get
            {
                return aerodromeLevelParameterValue;
            }
            set
            {
                aerodromeLevelParameterValue = value;
                OnPropertyChanged("aerodromeLevelParameter");
            }
        }
        public Parameter runwayHeading1Parameter
        {
            get
            {
                return runwayHeading1ParameterValue;
            }
            set
            {
                runwayHeading1ParameterValue = value;
                OnPropertyChanged("runwayHeading1Parameter");
            }
        }
        public Parameter runwayHeading2Parameter
        {
            get
            {
                return runwayHeading2ParameterValue;
            }
            set
            {
                runwayHeading2ParameterValue = value;
                OnPropertyChanged("runwayHeading2Parameter");
            }
        }
        public Parameter windHeadingParameter
        {
            get
            {
                return windHeadingParameterValue;
            }
            set
            {
                windHeadingParameterValue = value;
                OnPropertyChanged("windHeadingParameter");
            }
        }
        public Parameter windSpeedParameter
        {
            get
            {
                return windSpeedParameterValue;
            }
            set
            {
                windSpeedParameterValue = value;
                OnPropertyChanged("windSpeedParameter");
            }
        }
        public Parameter landingRunwayVisibilityParameter
        {
            get
            {
                return landingRunwayVisibilityParameterValue;
            }
            set
            {
                landingRunwayVisibilityParameterValue = value;
                OnPropertyChanged("landingRunwayVisibilityParameter");
            }
        }
        public Parameter takeoffRunwayVisibilityParameter
        {
            get
            {
                return takeoffRunwayVisibilityParameterValue;
            }
            set
            {
                takeoffRunwayVisibilityParameterValue = value;
                OnPropertyChanged("takeoffRunwayVisibilityParameter");
            }
        }
        public Parameter pressureChangeParameter
        {
            get
            {
                return pressureChangeParameterValue;
            }
            set
            {
                pressureChangeParameterValue = value;
                OnPropertyChanged("pressureChangeParameter");
            }
        }
        public Parameter temperatureChangeParameter
        {
            get
            {
                return temperatureChangeParameterValue;
            }
            set
            {
                temperatureChangeParameterValue = value;
                OnPropertyChanged("temperatureChangeParameter");
            }
        }
        public Parameter nightTimeParameter
        {
            get
            {
                return nightTimeParameterValue;
            }
            set
            {
                nightTimeParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    nightTimeOutput = "Gold";
                }
                else
                {
                    nightTimeOutput = "Black";
                }
                OnPropertyChanged("nightTimeParameter");
            }
        }
        public Parameter fuelLParameter
        {
            get
            {
                return fuelLParameterValue;
            }
            set
            {
                fuelLParameterValue = value;
                OnPropertyChanged("fuelLParameter");
            }
        }
        public Parameter fuelRParameter
        {
            get
            {
                return fuelRParameterValue;
            }
            set
            {
                fuelRParameterValue = value;
                OnPropertyChanged("fuelRParameter");
            }
        }
        public Parameter cargoWeightParameter
        {
            get
            {
                return cargoWeightParameterValue;
            }
            set
            {
                cargoWeightParameterValue = value;
                OnPropertyChanged("cargoWeightParameter");
            }
        }
        public Parameter cogParameter
        {
            get
            {
                return cogParameterValue;
            }
            set
            {
                cogParameterValue = value;
                OnPropertyChanged("cogParameter");
            }
        }
        public Parameter externalPowerSourceParameter
        {
            get
            {
                return externalPowerSourceParameterValue;
            }
            set
            {
                externalPowerSourceParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    externalPowerSourceOutput = "Gold";
                }
                else
                {
                    externalPowerSourceOutput = "Black";
                }
                OnPropertyChanged("externalPowerSourceParameter");
            }
        }
        public Parameter chockParameter
        {
            get
            {
                return chockParameterValue;
            }
            set
            {
                chockParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    chockOutput = "Gold";
                }
                else
                {
                    chockOutput = "Black";
                }
                OnPropertyChanged("chockParameter");
            }
        }
        #endregion

        #region Output Values
        public double minimumCloudLevelOutput
        {
            get { return minimumCloudLevelOutputValue; }
            set
            {
                minimumCloudLevelOutputValue = value;
                OnPropertyChanged("minimumCloudLevelOutput");
            }
        }
        public double maximumCloudLevelOutput
        {
            get { return maximumCloudLevelOutputValue; }
            set
            {
                maximumCloudLevelOutputValue = value;
                OnPropertyChanged("maximumCloudLevelOutput");
            }
        }
        public double aerodromeLevelOutput
        {
            get { return aerodromeLevelOutputValue; }
            set
            {
                aerodromeLevelOutputValue = value;
                OnPropertyChanged("aerodromeLevelOutput");
            }
        }
        public double runwayHeading1Output
        {
            get { return runwayHeading1OutputValue; }
            set
            {
                runwayHeading1OutputValue = value;
                OnPropertyChanged("runwayHeading1Output");
            }
        }
        public double runwayHeading2Output
        {
            get { return runwayHeading2OutputValue; }
            set
            {
                runwayHeading2OutputValue = value;
                OnPropertyChanged("runwayHeading2Output");
            }
        }
        public double windHeadingOutput
        {
            get { return windHeadingOutputValue; }
            set
            {
                windHeadingOutputValue = value;
                OnPropertyChanged("windHeadingOutput");
            }
        }
        public double windSpeedOutput
        {
            get { return windSpeedOutputValue; }
            set
            {
                windSpeedOutputValue = value;
                OnPropertyChanged("windSpeedOutput");
            }
        }
        public double landingRunwayVisibilityOutput
        {
            get { return landingRunwayVisibilityOutputValue; }
            set
            {
                landingRunwayVisibilityOutputValue = value;
                OnPropertyChanged("landingRunwayVisibilityOutput");
            }
        }
        public double takeoffRunwayVisibilityOutput
        {
            get { return takeoffRunwayVisibilityOutputValue; }
            set
            {
                takeoffRunwayVisibilityOutputValue = value;
                OnPropertyChanged("takeoffRunwayVisibilityOutput");
            }
        }
        public double pressureChangeOutput
        {
            get { return pressureChangeOutputValue; }
            set
            {
                pressureChangeOutputValue = value;
                OnPropertyChanged("pressureChangeOutput");
            }
        }
        public double temperatureChangeOutput
        {
            get { return temperatureChangeOutputValue; }
            set
            {
                temperatureChangeOutputValue = value;
                OnPropertyChanged("temperatureChangeOutput");
            }
        }
        public string nightTimeOutput
        {
            get { return nightTimeOutputValue; }
            set
            {
                nightTimeOutputValue = value;
                OnPropertyChanged("nightTimeOutput");
            }
        }
        public double fuelLOutput
        {
            get { return fuelLOutputValue; }
            set
            {
                fuelLOutputValue = value;
                OnPropertyChanged("fuelLOutput");
            }
        }
        public double fuelROutput
        {
            get { return fuelROutputValue; }
            set
            {
                fuelROutputValue = value;
                OnPropertyChanged("fuelROutput");
            }
        }
        public double cargoWeightOutput
        {
            get { return cargoWeightOutputValue; }
            set
            {
                cargoWeightOutputValue = value;
                OnPropertyChanged("cargoWeightOutput");
            }
        }
        public double cogOutput
        {
            get { return cogOutputValue; }
            set
            {
                cogOutputValue = value;
                OnPropertyChanged("cogOutput");
            }
        }
        public string externalPowerSourceOutput
        {
            get { return externalPowerSourceOutputValue; }
            set
            {
                externalPowerSourceOutputValue = value;
                OnPropertyChanged("externalPowerSourceOutput");
            }
        }
        public string chockOutput
        {
            get { return chockOutputValue; }
            set
            {
                chockOutputValue = value;
                OnPropertyChanged("chockOutput");
            }
        }
        #endregion

        #region Input Values
        public double minimumCloudLevelInput
        {
            get { return minimumCloudLevelInputValue; }
            set
            {
                minimumCloudLevelInputValue = value;
                minimumCloudLevelParameter = new Parameter("cdmn", value);
                OnPropertyChanged("minimumCloudLevelInput");
            }
        }
        public double maximumCloudLevelInput
        {
            get { return maximumCloudLevelInputValue; }
            set
            {
                maximumCloudLevelInputValue = value;
                maximumCloudLevelParameter = new Parameter("cdmx", value);
                OnPropertyChanged("maximumCloudLevelInput");
            }
        }
        public double aerodromeLevelInput
        {
            get { return aerodromeLevelInputValue; }
            set
            {
                aerodromeLevelInputValue = value;
                aerodromeLevelParameter = new Parameter("hl", value);
                OnPropertyChanged("aerodromeLevelInput");
            }
        }
        public double runwayHeading1Input
        {
            get { return runwayHeading1InputValue; }
            set
            {
                runwayHeading1InputValue = value;
                runwayHeading1Parameter = new Parameter("psl1", value);
                OnPropertyChanged("runwayHeading1Input");
            }
        }
        public double runwayHeading2Input
        {
            get { return runwayHeading2InputValue; }
            set
            {
                runwayHeading2InputValue = value;
                runwayHeading2Parameter = new Parameter("psl2", value);
                OnPropertyChanged("runwayHeading2Input");
            }
        }
        public double windHeadingInput
        {
            get { return windHeadingInputValue; }
            set
            {
                windHeadingInputValue = value;
                windHeadingParameter = new Parameter("psiv", value);
                OnPropertyChanged("windHeadingInput");
            }
        }
        public double windSpeedInput
        {
            get { return windSpeedInputValue; }
            set
            {
                windSpeedInputValue = value;
                windSpeedParameter = new Parameter("vv", value);
                OnPropertyChanged("windSpeedInput");
            }
        }
        public double landingRunwayVisibilityInput
        {
            get { return landingRunwayVisibilityInputValue; }
            set
            {
                landingRunwayVisibilityInputValue = value;
                landingRunwayVisibilityParameter = new Parameter("lrvl", value);
                OnPropertyChanged("landingRunwayVisibilityInput");
            }
        }
        public double takeoffRunwayVisibilityInput
        {
            get { return takeoffRunwayVisibilityInputValue; }
            set
            {
                takeoffRunwayVisibilityInputValue = value;
                takeoffRunwayVisibilityParameter = new Parameter("trvl", value);
                OnPropertyChanged("takeoffRunwayVisibilityInput");
            }
        }
        public double pressureChangeInput
        {
            get { return pressureChangeInputValue; }
            set
            {
                pressureChangeInputValue = value;
                pressureChangeParameter = new Parameter("depa", value);
                OnPropertyChanged("pressureChangeInput");
            }
        }
        public double temperatureChangeInput
        {
            get { return temperatureChangeInputValue; }
            set
            {
                temperatureChangeInputValue = value;
                temperatureChangeParameter = new Parameter("deto", value);
                OnPropertyChanged("temperatureChangeInput");
            }
        }
        public double fuelLInput
        {
            get { return fuelLInputValue; }
            set
            {
                fuelLInputValue = value;
                fuelLParameter = new Parameter("psiv", value);
                OnPropertyChanged("fuelLInput");
            }
        }
        public double fuelRInput
        {
            get { return fuelRInputValue; }
            set
            {
                fuelRInputValue = value;
                fuelRParameter = new Parameter("psiv", value);
                OnPropertyChanged("fuelRInput");
            }
        }
        public double cargoWeightInput
        {
            get { return cargoWeightInputValue; }
            set
            {
                cargoWeightInputValue = value;
                cargoWeightParameter = new Parameter("na", value);
                OnPropertyChanged("cargoWeightInput");
            }
        }
        public double cogInput
        {
            get { return fuelRInputValue; }
            set
            {
                cogInputValue = value;
                cogParameter = new Parameter("xtez", value);
                OnPropertyChanged("cogInput");
            }
        }
        #endregion

        #region Registration Area
        [MediatorMessageSink("cdmn")]
        private void minimumCloudLevelParameterUpdate(object updateParameter)
        {
            minimumCloudLevelParameter = (Parameter)updateParameter;
            minimumCloudLevelOutput = minimumCloudLevelParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("cdmx")]
        private void maximumCloudLevelParameterUpdate(object updateParameter)
        {
            maximumCloudLevelParameter = (Parameter)updateParameter;
            maximumCloudLevelOutput = maximumCloudLevelParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("hl")]
        private void aerodromeLevelParameterUpdate(object updateParameter)
        {
            aerodromeLevelParameter = (Parameter)updateParameter;
            aerodromeLevelOutput = aerodromeLevelParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("psl1")]
        private void runwayHeading1ParameterUpdate(object updateParameter)
        {
            runwayHeading1Parameter = (Parameter)updateParameter;
            runwayHeading1Output = runwayHeading1Parameter.GetValueAsDouble();
        }
        [MediatorMessageSink("psl2")]
        private void runwayHeading2ParameterUpdate(object updateParameter)
        {
            runwayHeading2Parameter = (Parameter)updateParameter;
            runwayHeading2Output = runwayHeading2Parameter.GetValueAsDouble();
        }
        [MediatorMessageSink("psiv")]
        private void windHeadingParameterUpdate(object updateParameter)
        {
            windHeadingParameter = (Parameter)updateParameter;
            windHeadingOutput = windHeadingParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("vv")]
        private void windSpeedParameterUpdate(object updateParameter)
        {
            windSpeedParameter = (Parameter)updateParameter;
            windSpeedOutput = windSpeedParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("lrvl")]
        private void landingRunwayVisibilityParameterUpdate(object updateParameter)
        {
            landingRunwayVisibilityParameter = (Parameter)updateParameter;
            landingRunwayVisibilityOutput = landingRunwayVisibilityParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("trvl")]
        private void takeoffRunwayVisibilityParameterUpdate(object updateParameter)
        {
            takeoffRunwayVisibilityParameter = (Parameter)updateParameter;
            takeoffRunwayVisibilityOutput = takeoffRunwayVisibilityParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("depa")]
        private void pressureChangeParameterUpdate(object updateParameter)
        {
            pressureChangeParameter = (Parameter)updateParameter;
            pressureChangeOutput = pressureChangeParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("deto")]
        private void temperatureChangeParameterUpdate(object updateParameter)
        {
            temperatureChangeParameter = (Parameter)updateParameter;
            temperatureChangeOutput = temperatureChangeParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("nitt")]
        private void nightTimeParameterUpdate(object updateParameter)
        {
            nightTimeParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("gp1")]
        private void fuelLParameterUpdate(object updateParameter)
        {
            fuelLParameter = (Parameter)updateParameter;
            fuelLOutput = fuelLParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("gp2")]
        private void fuelRParameterUpdate(object updateParameter)
        {
            fuelRParameter = (Parameter)updateParameter;
            fuelROutput = fuelRParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("na")]
        private void cargoWeightParameterUpdate(object updateParameter)
        {
            cargoWeightParameter = (Parameter)updateParameter;
            cargoWeightOutput = cargoWeightParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("xtez")]
        private void cogParameterUpdate(object updateParameter)
        {
            cogParameter = (Parameter)updateParameter;
            cogOutput = cogParameter.GetValueAsDouble();
        }
        [MediatorMessageSink("fep")]
        private void externalPowerSourceParameterUpdate(object updateParameter)
        {
            externalPowerSourceParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsp")]
        private void chockParameterUpdate(object updateParameter)
        {
            chockParameter = (Parameter)updateParameter;
        }

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
    }
}
