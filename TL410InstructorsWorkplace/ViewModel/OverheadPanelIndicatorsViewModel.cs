using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class OverheadPanelIndicatorsViewModel : INPCBase
    {
        #region Values area
        private string ipsPVD1Value;
        private string ipsPVD2Value;
        private string ipsPSNValue;
        private string ipsFOUNTValue;
        private string ipsSTATINDValue;
        private string ipsROTINDValue;
        private string ipsPROP1Value;
        private string ipsPROP2Value;
        private string ipsICESEPLValue;
        private string ipsICESEPRValue;

        private string seFANValue;
        private string seSAIValue;
        private string seSPPValue;

        private string lightFIREValue;
        private string lightANOValue;
        private string lightHL1Value;
        private string lightHL2Value;
        private string lightTAXWAY1Value;
        private string lightTAXWAY2Value;
        private string lightLAND1Value;
        private string lightLAND2Value;
        private string lightPASCAB1Value;
        private string lightPASCAB2Value;
        private string lightLGHTPANELValue;
        private string lightPILOTCABValue;
        private string lightINDPANELValue;

        private string rnSPU1Value;
        private string rnSPU2Value;
        private string rnUKV1Value;
        private string rnUKV2Value;
        private string rnKVValue;
        private string rnGIKValue;
        private string rnRVValue;
        private string rnSP50Value;
        private string rnARK1Value;
        private string rnARK2Value;
        private string rnSROValue;

        private string engFUELPUMPL1Value;
        private string engFUELPUMPL2Value;
        private string engFUELPUMPR1Value;
        private string engFUELPUMPR2Value;
        private string engFUELPUMPINGValue;
        private string engPUMPFLUGLValue;
        private string engPUMPFLUGRValue;
        private string engISOLVAVLELValue;
        private string engISOLVAVLERValue;
        private string engSTARTLValue;
        private string engSTARTRValue;

        private string apSERVOValue;
        private string apINDValue;

        private string bkINDValue;
        private string bkSIGNALValue;
        private string bkGEARSValue;
        private string bkFLAPSValue;
        private string bkTRIMValue;
        private string bkLIGHTValue;
        private string bkCEBOLValue;
        private string bkCEBORValue;
        private string bkFIRESIGValue;
        private string bkIPSCORPValue;
        private string bkICESEPLValue;
        private string bkICESEPRValue;

        private string pwsGENLValue;
        private string pwsGENRValue;
        private string pwsBATT1Value;
        private string pwsBATT2Value;
        private string pwsSWITCHBATValue;
        private string pwsSWITCHGENLValue;
        private string pwsSWITCHGENRValue;
        private string pwsTR115MValue;
        private string pwsTR115RValue;
        private string pwsTR361Value;
        private string pwsTR362Value;

        private Parameter ipsPVD1ParameterValue;
        private Parameter ipsPVD2ParameterValue;
        private Parameter ipsPSNParameterValue;
        private Parameter ipsFOUNTParameterValue;
        private Parameter ipsSTATINDParameterValue;
        private Parameter ipsROTINDParameterValue;
        private Parameter ipsPROP1ParameterValue;
        private Parameter ipsPROP2ParameterValue;
        private Parameter ipsICESEPLParameterValue;
        private Parameter ipsICESEPRParameterValue;

        private Parameter seFANParameterValue;
        private Parameter seSAIParameterValue;
        private Parameter seSPPParameterValue;

        private Parameter lightFIREParameterValue;
        private Parameter lightANOParameterValue;
        private Parameter lightHL1ParameterValue;
        private Parameter lightHL2ParameterValue;
        private Parameter lightTAXWAY1ParameterValue;
        private Parameter lightTAXWAY2ParameterValue;
        private Parameter lightLAND1ParameterValue;
        private Parameter lightLAND2ParameterValue;
        private Parameter lightPASCAB1ParameterValue;
        private Parameter lightPASCAB2ParameterValue;
        private Parameter lightLGHTPANELParameterValue;
        private Parameter lightPILOTCABParameterValue;
        private Parameter lightINDPANELParameterValue;

        private Parameter rnSPU1ParameterValue;
        private Parameter rnSPU2ParameterValue;
        private Parameter rnUKV1ParameterValue;
        private Parameter rnUKV2ParameterValue;
        private Parameter rnKVParameterValue;
        private Parameter rnGIKParameterValue;
        private Parameter rnRVParameterValue;
        private Parameter rnSP50ParameterValue;
        private Parameter rnARK1ParameterValue;
        private Parameter rnARK2ParameterValue;
        private Parameter rnSROParameterValue;

        private Parameter engFUELPUMPL1ParameterValue;
        private Parameter engFUELPUMPL2ParameterValue;
        private Parameter engFUELPUMPR1ParameterValue;
        private Parameter engFUELPUMPR2ParameterValue;
        private Parameter engFUELPUMPINGParameterValue;
        private Parameter engPUMPFLUGLParameterValue;
        private Parameter engPUMPFLUGRParameterValue;
        private Parameter engISOLVAVLELParameterValue;
        private Parameter engISOLVAVLERParameterValue;
        private Parameter engSTARTLParameterValue;
        private Parameter engSTARTRParameterValue;

        private Parameter apSERVOParameterValue;
        private Parameter apINDParameterValue;

        private Parameter bkINDParameterValue;
        private Parameter bkSIGNALParameterValue;
        private Parameter bkGEARSParameterValue;
        private Parameter bkFLAPSParameterValue;
        private Parameter bkTRIMParameterValue;
        private Parameter bkLIGHTParameterValue;
        private Parameter bkCEBOLParameterValue;
        private Parameter bkCEBORParameterValue;
        private Parameter bkFIRESIGParameterValue;
        private Parameter bkIPSCORPParameterValue;
        private Parameter bkICESEPLParameterValue;
        private Parameter bkICESEPRParameterValue;

        private Parameter pwsGENLParameterValue;
        private Parameter pwsGENRParameterValue;
        private Parameter pwsBATT1ParameterValue;
        private Parameter pwsBATT2ParameterValue;
        private Parameter pwsSWITCHBATParameterValue;
        private Parameter pwsSWITCHGENLParameterValue;
        private Parameter pwsSWITCHGENRParameterValue;
        private Parameter pwsTR115MParameterValue;
        private Parameter pwsTR115RParameterValue;
        private Parameter pwsTR361ParameterValue;
        private Parameter pwsTR362ParameterValue;
        #endregion

        #region Constructor
        public OverheadPanelIndicatorsViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsPVD1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsPVD2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsPSNParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsFOUNTParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsSTATINDParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsROTINDParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsPROP1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsPROP2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsICESEPLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                ipsICESEPRParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                seFANParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                seSAIParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                seSPPParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightFIREParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightHL1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightHL2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightTAXWAY1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightTAXWAY2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightLAND1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightLAND2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightPASCAB1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightPASCAB2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightPILOTCABParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightINDPANELParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightANOParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                lightLGHTPANELParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnSPU1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnSPU2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnUKV1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnUKV2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnKVParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnGIKParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnRVParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnSP50Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnARK1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnARK2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                rnSROParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engFUELPUMPL1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engFUELPUMPL2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engFUELPUMPR1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engFUELPUMPR2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engFUELPUMPINGParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engPUMPFLUGLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engPUMPFLUGRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engISOLVAVLELParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engISOLVAVLERParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engSTARTLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                engSTARTRParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                apSERVOParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                apINDParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkINDParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkSIGNALParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkGEARSParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkFLAPSParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkTRIMParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkLIGHTParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkCEBOLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkCEBORParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkFIRESIGParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkIPSCORPParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkICESEPLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                bkICESEPRParameter = Mediator.GetBufferedParameter("fsc1");
            }

            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsGENLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsGENRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsBATT1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsBATT2Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsSWITCHBATParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsSWITCHGENLParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsSWITCHGENRParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsTR115MParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsTR115RParameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsTR361Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                pwsTR362Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~OverheadPanelIndicatorsViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties

        private Parameter ipsPVD1Parameter
        {
            get { return ipsPVD1ParameterValue; }
            set
            {
                ipsPVD1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsPVD1Light = "CadetBlue";
                }
                else
                {
                    ipsPVD1Light = "Black";
                }

            }
        }

        private Parameter ipsPVD2Parameter
        {
            get { return ipsPVD2ParameterValue; }
            set
            {
                ipsPVD2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsPVD2Light = "CadetBlue";
                }
                else
                {
                    ipsPVD2Light = "Black";
                }

            }
        }

        private Parameter ipsPSNParameter
        {
            get { return ipsPSNParameterValue; }
            set
            {
                ipsPSNParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsPSNLight = "CadetBlue";
                }
                else
                {
                    ipsPSNLight = "Black";
                }

            }
        }

        private Parameter ipsFOUNTParameter
        {
            get { return ipsFOUNTParameterValue; }
            set
            {
                ipsFOUNTParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsFOUNTLight = "CadetBlue";
                }
                else
                {
                    ipsFOUNTLight = "Black";
                }

            }
        }

        private Parameter ipsSTATINDParameter
        {
            get { return ipsSTATINDParameterValue; }
            set
            {
                ipsSTATINDParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsSTATINDLight = "CadetBlue";
                }
                else
                {
                    ipsSTATINDLight = "Black";
                }

            }
        }

        private Parameter ipsROTINDParameter
        {
            get { return ipsROTINDParameterValue; }
            set
            {
                ipsROTINDParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsROTINDLight = "CadetBlue";
                }
                else
                {
                    ipsROTINDLight = "Black";
                }

            }
        }
        private Parameter ipsPROP1Parameter
        {
            get { return ipsPROP1ParameterValue; }
            set
            {
                ipsPROP1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsPROP1Light = "CadetBlue";
                }
                else
                {
                    ipsPROP1Light = "Black";
                }

            }
        }
        private Parameter ipsPROP2Parameter
        {
            get { return ipsPROP2ParameterValue; }
            set
            {
                ipsPROP2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsPROP2Light = "CadetBlue";
                }
                else
                {
                    ipsPROP2Light = "Black";
                }

            }
        }
        private Parameter ipsICESEPLParameter
        {
            get { return ipsICESEPLParameterValue; }
            set
            {
                ipsICESEPLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsICESEPLLight = "CadetBlue";
                }
                else
                {
                    ipsICESEPLLight = "Black";
                }

            }
        }
        private Parameter ipsICESEPRParameter
        {
            get { return ipsICESEPRParameterValue; }
            set
            {
                ipsICESEPRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    ipsICESEPRLight = "CadetBlue";
                }
                else
                {
                    ipsICESEPRLight = "Black";
                }

            }
        }
        private Parameter seFANParameter
        {
            get { return seFANParameterValue; }
            set
            {
                seFANParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    seFANLight = "CadetBlue";
                }
                else
                {
                    seFANLight = "Black";
                }

            }
        }
        private Parameter seSAIParameter
        {
            get { return seSAIParameterValue; }
            set
            {
                seSAIParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    seSAILight = "CadetBlue";
                }
                else
                {
                    seSAILight = "Black";
                }

            }
        }
        private Parameter seSPPParameter
        {
            get { return seSPPParameterValue; }
            set
            {
                seSPPParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    seSPPLight = "CadetBlue";
                }
                else
                {
                    seSPPLight = "Black";
                }

            }
        }
        private Parameter lightFIREParameter
        {
            get { return lightFIREParameterValue; }
            set
            {
                lightFIREParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightFIRELight = "CadetBlue";
                }
                else
                {
                    lightFIRELight = "Black";
                }

            }
        }
        private Parameter lightANOParameter
        {
            get { return lightANOParameterValue; }
            set
            {
                lightANOParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightANOLight = "CadetBlue";
                }
                else
                {
                    lightANOLight = "Black";
                }

            }
        }
        private Parameter lightHL1Parameter
        {
            get { return lightHL1ParameterValue; }
            set
            {
                lightHL1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightHL1Light = "CadetBlue";
                }
                else
                {
                    lightHL1Light = "Black";
                }

            }
        }
        private Parameter lightHL2Parameter
        {
            get { return lightHL2ParameterValue; }
            set
            {
                lightHL2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightHL2Light = "CadetBlue";
                }
                else
                {
                    lightHL2Light = "Black";
                }

            }
        }
        private Parameter lightTAXWAY1Parameter
        {
            get { return lightTAXWAY1ParameterValue; }
            set
            {
                lightTAXWAY1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightTAXWAY1Light = "CadetBlue";
                }
                else
                {
                    lightTAXWAY1Light = "Black";
                }

            }
        }
        private Parameter lightTAXWAY2Parameter
        {
            get { return lightTAXWAY2ParameterValue; }
            set
            {
                lightTAXWAY2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightTAXWAY2Light = "CadetBlue";
                }
                else
                {
                    lightTAXWAY2Light = "Black";
                }

            }
        }
        private Parameter lightLAND1Parameter
        {
            get { return lightLAND1ParameterValue; }
            set
            {
                lightLAND1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightLAND1Light = "CadetBlue";
                }
                else
                {
                    lightLAND1Light = "Black";
                }

            }
        }
        private Parameter lightLAND2Parameter
        {
            get { return lightLAND2ParameterValue; }
            set
            {
                lightLAND2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightLAND2Light = "CadetBlue";
                }
                else
                {
                    lightLAND2Light = "Black";
                }

            }
        }
        private Parameter lightPASCAB1Parameter
        {
            get { return lightPASCAB1ParameterValue; }
            set
            {
                lightPASCAB1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightPASCAB1Light = "CadetBlue";
                }
                else
                {
                    lightPASCAB1Light = "Black";
                }

            }
        }
        private Parameter lightPASCAB2Parameter
        {
            get { return lightPASCAB2ParameterValue; }
            set
            {
                lightPASCAB2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightPASCAB2Light = "CadetBlue";
                }
                else
                {
                    lightPASCAB2Light = "Black";
                }

            }
        }
        private Parameter lightLGHTPANELParameter
        {
            get { return lightLGHTPANELParameterValue; }
            set
            {
                lightLGHTPANELParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightLGHTPANELLight = "CadetBlue";
                }
                else
                {
                    lightLGHTPANELLight = "Black";
                }

            }
        }
        private Parameter lightPILOTCABParameter
        {
            get { return lightPILOTCABParameterValue; }
            set
            {
                lightPILOTCABParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightPILOTCABLight = "CadetBlue";
                }
                else
                {
                    lightPILOTCABLight = "Black";
                }

            }
        }
        private Parameter lightINDPANELParameter
        {
            get { return lightINDPANELParameterValue; }
            set
            {
                lightINDPANELParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    lightINDPANELLight = "CadetBlue";
                }
                else
                {
                    lightINDPANELLight = "Black";
                }

            }
        }
        private Parameter rnSPU1Parameter
        {
            get { return rnSPU1ParameterValue; }
            set
            {
                rnSPU1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnSPU1Light = "CadetBlue";
                }
                else
                {
                    rnSPU1Light = "Black";
                }

            }
        }
        private Parameter rnSPU2Parameter
        {
            get { return rnSPU2ParameterValue; }
            set
            {
                rnSPU2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnSPU2Light = "CadetBlue";
                }
                else
                {
                    rnSPU2Light = "Black";
                }

            }
        }
        private Parameter rnUKV1Parameter
        {
            get { return rnUKV1ParameterValue; }
            set
            {
                rnUKV1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnUKV1Light = "CadetBlue";
                }
                else
                {
                    rnUKV1Light = "Black";
                }

            }
        }
        private Parameter rnUKV2Parameter
        {
            get { return rnUKV2ParameterValue; }
            set
            {
                rnUKV2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnUKV2Light = "CadetBlue";
                }
                else
                {
                    rnUKV2Light = "Black";
                }

            }
        }
        private Parameter rnKVParameter
        {
            get { return rnKVParameterValue; }
            set
            {
                rnKVParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnKVLight = "CadetBlue";
                }
                else
                {
                    rnKVLight = "Black";
                }

            }
        }
        private Parameter rnGIKParameter
        {
            get { return rnGIKParameterValue; }
            set
            {
                rnGIKParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnGIKLight = "CadetBlue";
                }
                else
                {
                    rnGIKLight = "Black";
                }

            }
        }
        private Parameter rnRVParameter
        {
            get { return rnRVParameterValue; }
            set
            {
                rnRVParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnRVLight = "CadetBlue";
                }
                else
                {
                    rnRVLight = "Black";
                }

            }
        }
        private Parameter rnSP50Parameter
        {
            get { return rnSP50ParameterValue; }
            set
            {
                rnSP50ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnSP50Light = "CadetBlue";
                }
                else
                {
                    rnSP50Light = "Black";
                }

            }
        }
        private Parameter rnARK1Parameter
        {
            get { return rnARK1ParameterValue; }
            set
            {
                rnARK1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnARK1Light = "CadetBlue";
                }
                else
                {
                    rnARK1Light = "Black";
                }

            }
        }
        private Parameter rnARK2Parameter
        {
            get { return rnARK2ParameterValue; }
            set
            {
                rnARK2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnARK2Light = "CadetBlue";
                }
                else
                {
                    rnARK2Light = "Black";
                }

            }
        }
        private Parameter rnSROParameter
        {
            get { return rnSROParameterValue; }
            set
            {
                rnSROParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    rnSROLight = "CadetBlue";
                }
                else
                {
                    rnSROLight = "Black";
                }

            }
        }
        private Parameter engFUELPUMPL1Parameter
        {
            get { return engFUELPUMPL1ParameterValue; }
            set
            {
                engFUELPUMPL1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engFUELPUMPL1Light = "CadetBlue";
                }
                else
                {
                    engFUELPUMPL1Light = "Black";
                }

            }
        }
        private Parameter engFUELPUMPL2Parameter
        {
            get { return engFUELPUMPL2ParameterValue; }
            set
            {
                engFUELPUMPL2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engFUELPUMPL2Light = "CadetBlue";
                }
                else
                {
                    engFUELPUMPL2Light = "Black";
                }

            }
        }
        private Parameter engFUELPUMPR1Parameter
        {
            get { return engFUELPUMPR1ParameterValue; }
            set
            {
                engFUELPUMPR1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engFUELPUMPR1Light = "CadetBlue";
                }
                else
                {
                    engFUELPUMPR1Light = "Black";
                }

            }
        }
        private Parameter engFUELPUMPR2Parameter
        {
            get { return engFUELPUMPR2ParameterValue; }
            set
            {
                engFUELPUMPR2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engFUELPUMPR2Light = "CadetBlue";
                }
                else
                {
                    engFUELPUMPR2Light = "Black";
                }

            }
        }
        private Parameter engFUELPUMPINGParameter
        {
            get { return engFUELPUMPINGParameterValue; }
            set
            {
                engFUELPUMPINGParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engFUELPUMPINGLight = "CadetBlue";
                }
                else
                {
                    engFUELPUMPINGLight = "Black";
                }

            }
        }
        private Parameter engPUMPFLUGLParameter
        {
            get { return engPUMPFLUGLParameterValue; }
            set
            {
                engPUMPFLUGLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engPUMPFLUGLLight = "CadetBlue";
                }
                else
                {
                    engPUMPFLUGLLight = "Black";
                }

            }
        }
        private Parameter engPUMPFLUGRParameter
        {
            get { return engPUMPFLUGRParameterValue; }
            set
            {
                engPUMPFLUGRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engPUMPFLUGRLight = "CadetBlue";
                }
                else
                {
                    engPUMPFLUGRLight = "Black";
                }

            }
        }
        private Parameter engISOLVAVLELParameter
        {
            get { return engISOLVAVLELParameterValue; }
            set
            {
                engISOLVAVLELParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engISOLVAVLELLight = "CadetBlue";
                }
                else
                {
                    engISOLVAVLELLight = "Black";
                }

            }
        }
        private Parameter engISOLVAVLERParameter
        {
            get { return engISOLVAVLERParameterValue; }
            set
            {
                engISOLVAVLERParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engISOLVAVLERLight = "CadetBlue";
                }
                else
                {
                    engISOLVAVLERLight = "Black";
                }

            }
        }
        private Parameter engSTARTLParameter
        {
            get { return engSTARTLParameterValue; }
            set
            {
                engSTARTLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engSTARTLLight = "CadetBlue";
                }
                else
                {
                    engSTARTLLight = "Black";
                }

            }
        }
        private Parameter engSTARTRParameter
        {
            get { return engSTARTRParameterValue; }
            set
            {
                engSTARTRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    engSTARTRLight = "CadetBlue";
                }
                else
                {
                    engSTARTRLight = "Black";
                }

            }
        }
        private Parameter apSERVOParameter
        {
            get { return apSERVOParameterValue; }
            set
            {
                apSERVOParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    apSERVOLight = "CadetBlue";
                }
                else
                {
                    apSERVOLight = "Black";
                }

            }
        }
        private Parameter apINDParameter
        {
            get { return apINDParameterValue; }
            set
            {
                apINDParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    apINDLight = "CadetBlue";
                }
                else
                {
                    apINDLight = "Black";
                }

            }
        }
        private Parameter bkINDParameter
        {
            get { return bkINDParameterValue; }
            set
            {
                bkINDParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkINDLight = "CadetBlue";
                }
                else
                {
                    bkINDLight = "Black";
                }

            }
        }
        private Parameter bkSIGNALParameter
        {
            get { return bkSIGNALParameterValue; }
            set
            {
                bkSIGNALParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkSIGNALLight = "CadetBlue";
                }
                else
                {
                    bkSIGNALLight = "Black";
                }

            }
        }
        private Parameter bkGEARSParameter
        {
            get { return bkGEARSParameterValue; }
            set
            {
                bkGEARSParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkGEARSLight = "CadetBlue";
                }
                else
                {
                    bkGEARSLight = "Black";
                }

            }
        }
        private Parameter bkFLAPSParameter
        {
            get { return bkFLAPSParameterValue; }
            set
            {
                bkFLAPSParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkFLAPSLight = "CadetBlue";
                }
                else
                {
                    bkFLAPSLight = "Black";
                }

            }
        }
        private Parameter bkTRIMParameter
        {
            get { return bkTRIMParameterValue; }
            set
            {
                bkTRIMParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkTRIMLight = "CadetBlue";
                }
                else
                {
                    bkTRIMLight = "Black";
                }

            }
        }
        private Parameter bkLIGHTParameter
        {
            get { return bkLIGHTParameterValue; }
            set
            {
                bkLIGHTParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkLIGHTLight = "CadetBlue";
                }
                else
                {
                    bkLIGHTLight = "Black";
                }

            }
        }
        private Parameter bkCEBOLParameter
        {
            get { return bkCEBOLParameterValue; }
            set
            {
                bkCEBOLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkCEBOLLight = "CadetBlue";
                }
                else
                {
                    bkCEBOLLight = "Black";
                }

            }
        }
        private Parameter bkCEBORParameter
        {
            get { return bkCEBORParameterValue; }
            set
            {
                bkCEBORParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkCEBORLight = "CadetBlue";
                }
                else
                {
                    bkCEBORLight = "Black";
                }

            }
        }
        private Parameter bkFIRESIGParameter
        {
            get { return bkFIRESIGParameterValue; }
            set
            {
                bkFIRESIGParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkFIRESIGLight = "CadetBlue";
                }
                else
                {
                    bkFIRESIGLight = "Black";
                }

            }
        }
        private Parameter bkIPSCORPParameter
        {
            get { return bkIPSCORPParameterValue; }
            set
            {
                bkIPSCORPParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkIPSCORPLight = "CadetBlue";
                }
                else
                {
                    bkIPSCORPLight = "Black";
                }

            }
        }
        private Parameter bkICESEPLParameter
        {
            get { return bkICESEPLParameterValue; }
            set
            {
                bkICESEPLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkICESEPLLight = "CadetBlue";
                }
                else
                {
                    bkICESEPLLight = "Black";
                }

            }
        }
        private Parameter bkICESEPRParameter
        {
            get { return bkICESEPRParameterValue; }
            set
            {
                bkICESEPRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    bkICESEPRLight = "CadetBlue";
                }
                else
                {
                    bkICESEPRLight = "Black";
                }

            }
        }
        private Parameter pwsGENLParameter
        {
            get { return pwsGENLParameterValue; }
            set
            {
                pwsGENLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsGENLLight = "CadetBlue";
                }
                else
                {
                    pwsGENLLight = "Black";
                }

            }
        }
        private Parameter pwsGENRParameter
        {
            get { return pwsGENRParameterValue; }
            set
            {
                pwsGENRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsGENRLight = "CadetBlue";
                }
                else
                {
                    pwsGENRLight = "Black";
                }

            }
        }
        private Parameter pwsBATT1Parameter
        {
            get { return pwsBATT1ParameterValue; }
            set
            {
                pwsBATT1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsBATT1Light = "CadetBlue";
                }
                else
                {
                    pwsBATT1Light = "Black";
                }

            }
        }
        private Parameter pwsBATT2Parameter
        {
            get { return pwsBATT2ParameterValue; }
            set
            {
                pwsBATT2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsBATT2Light = "CadetBlue";
                }
                else
                {
                    pwsBATT2Light = "Black";
                }

            }
        }
        private Parameter pwsSWITCHBATParameter
        {
            get { return pwsSWITCHBATParameterValue; }
            set
            {
                pwsSWITCHBATParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsSWITCHBATLight = "CadetBlue";
                }
                else
                {
                    pwsSWITCHBATLight = "Black";
                }

            }
        }
        private Parameter pwsSWITCHGENLParameter
        {
            get { return pwsSWITCHGENLParameterValue; }
            set
            {
                pwsSWITCHGENLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsSWITCHGENLLight = "CadetBlue";
                }
                else
                {
                    pwsSWITCHGENLLight = "Black";
                }

            }
        }
        private Parameter pwsSWITCHGENRParameter
        {
            get { return pwsSWITCHGENRParameterValue; }
            set
            {
                pwsSWITCHGENRParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsSWITCHGENRLight = "CadetBlue";
                }
                else
                {
                    pwsSWITCHGENRLight = "Black";
                }

            }
        }
        private Parameter pwsTR115MParameter
        {
            get { return pwsTR115MParameterValue; }
            set
            {
                pwsTR115MParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsTR115MLight = "CadetBlue";
                }
                else
                {
                    pwsTR115MLight = "Black";
                }

            }
        }
        private Parameter pwsTR115RParameter
        {
            get { return pwsTR115RParameterValue; }
            set
            {
                pwsTR115RParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsTR115RLight = "CadetBlue";
                }
                else
                {
                    pwsTR115RLight = "Black";
                }

            }
        }
        private Parameter pwsTR361Parameter
        {
            get { return pwsTR361ParameterValue; }
            set
            {
                pwsTR361ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsTR361Light = "CadetBlue";
                }
                else
                {
                    pwsTR361Light = "Black";
                }

            }
        }
        private Parameter pwsTR362Parameter
        {
            get { return pwsTR362ParameterValue; }
            set
            {
                pwsTR362ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    pwsTR362Light = "CadetBlue";
                }
                else
                {
                    pwsTR362Light = "Black";
                }

            }
        }



        #endregion

        #region Light Values
        public string ipsPVD1Light
        {
            get { return ipsPVD1Value; }
            set
            {
                ipsPVD1Value = value;
                OnPropertyChanged("ipsPVD1Light");
            }
        }
        public string ipsPVD2Light
        {
            get { return ipsPVD2Value; }
            set
            {
                ipsPVD2Value = value;
                OnPropertyChanged("ipsPVD2Light");
            }
        }
        public string ipsPSNLight
        {
            get { return ipsPSNValue; }
            set
            {
                ipsPSNValue = value;
                OnPropertyChanged("ipsPSNLight");
            }
        }
        public string ipsFOUNTLight
        {
            get { return ipsFOUNTValue; }
            set
            {
                ipsFOUNTValue = value;
                OnPropertyChanged("ipsFOUNTLight");
            }
        }
        public string ipsSTATINDLight
        {
            get { return ipsSTATINDValue; }
            set
            {
                ipsSTATINDValue = value;
                OnPropertyChanged("ipsSTATINDLight");
            }
        }
        public string ipsROTINDLight
        {
            get { return ipsROTINDValue; }
            set
            {
                ipsROTINDValue = value;
                OnPropertyChanged("ipsROTINDLight");
            }
        }
        public string ipsPROP1Light
        {
            get { return ipsPROP1Value; }
            set
            {
                ipsPROP1Value = value;
                OnPropertyChanged("ipsPROP1Light");
            }
        }
        public string ipsPROP2Light
        {
            get { return ipsPROP2Value; }
            set
            {
                ipsPROP2Value = value;
                OnPropertyChanged("ipsPROP2Light");
            }
        }
        public string ipsICESEPLLight
        {
            get { return ipsICESEPLValue; }
            set
            {
                ipsICESEPLValue = value;
                OnPropertyChanged("ipsICESEPLLight");
            }
        }
        public string ipsICESEPRLight
        {
            get { return ipsICESEPRValue; }
            set
            {
                ipsICESEPRValue = value;
                OnPropertyChanged("ipsICESEPRLight");
            }
        }
        public string seFANLight
        {
            get { return seFANValue; }
            set
            {
                seFANValue = value;
                OnPropertyChanged("seFANLight");
            }
        }
        public string seSAILight
        {
            get { return seSAIValue; }
            set
            {
                seSAIValue = value;
                OnPropertyChanged("seSAILight");
            }
        }
        public string seSPPLight
        {
            get { return seSPPValue; }
            set
            {
                seSPPValue = value;
                OnPropertyChanged("seSPPLight");
            }
        }
        public string lightFIRELight
        {
            get { return lightFIREValue; }
            set
            {
                lightFIREValue = value;
                OnPropertyChanged("lightFIRELight");
            }
        }
        public string lightANOLight
        {
            get { return lightANOValue; }
            set
            {
                lightANOValue = value;
                OnPropertyChanged("lightANOLight");
            }
        }
        public string lightHL1Light
        {
            get { return lightHL1Value; }
            set
            {
                lightHL1Value = value;
                OnPropertyChanged("lightHL1Light");
            }
        }
        public string lightHL2Light
        {
            get { return lightHL2Value; }
            set
            {
                lightHL2Value = value;
                OnPropertyChanged("lightHL2Light");
            }
        }
        public string lightTAXWAY1Light
        {
            get { return lightTAXWAY1Value; }
            set
            {
                lightTAXWAY1Value = value;
                OnPropertyChanged("lightTAXWAY1Light");
            }
        }
        public string lightTAXWAY2Light
        {
            get { return lightTAXWAY2Value; }
            set
            {
                lightTAXWAY2Value = value;
                OnPropertyChanged("lightTAXWAY2Light");
            }
        }
        public string lightLAND1Light
        {
            get { return lightLAND1Value; }
            set
            {
                lightLAND1Value = value;
                OnPropertyChanged("lightLAND1Light");
            }
        }
        public string lightLAND2Light
        {
            get { return lightLAND2Value; }
            set
            {
                lightLAND2Value = value;
                OnPropertyChanged("lightLAND2Light");
            }
        }
        public string lightPASCAB1Light
        {
            get { return lightPASCAB1Value; }
            set
            {
                lightPASCAB1Value = value;
                OnPropertyChanged("lightPASCAB1Light");
            }
        }
        public string lightPASCAB2Light
        {
            get { return lightPASCAB2Value; }
            set
            {
                lightPASCAB2Value = value;
                OnPropertyChanged("lightPASCAB2Light");
            }
        }
        public string lightLGHTPANELLight
        {
            get { return lightLGHTPANELValue; }
            set
            {
                lightLGHTPANELValue = value;
                OnPropertyChanged("lightLGHTPANELLight");
            }
        }
        public string lightPILOTCABLight
        {
            get { return lightPILOTCABValue; }
            set
            {
                lightPILOTCABValue = value;
                OnPropertyChanged("lightPILOTCABLight");
            }
        }
        public string lightINDPANELLight
        {
            get { return lightINDPANELValue; }
            set
            {
                lightINDPANELValue = value;
                OnPropertyChanged("lightINDPANELLight");
            }
        }
        public string rnSPU1Light
        {
            get { return rnSPU1Value; }
            set
            {
                rnSPU1Value = value;
                OnPropertyChanged("rnSPU1Light");
            }
        }
        public string rnSPU2Light
        {
            get { return rnSPU2Value; }
            set
            {
                rnSPU2Value = value;
                OnPropertyChanged("rnSPU2Light");
            }
        }
        public string rnUKV1Light
        {
            get { return rnUKV1Value; }
            set
            {
                rnUKV1Value = value;
                OnPropertyChanged("rnUKV1Light");
            }
        }
        public string rnUKV2Light
        {
            get { return rnUKV2Value; }
            set
            {
                rnUKV2Value = value;
                OnPropertyChanged("rnUKV2Light");
            }
        }
        public string rnKVLight
        {
            get { return rnKVValue; }
            set
            {
                rnKVValue = value;
                OnPropertyChanged("rnKVLight");
            }
        }
        public string rnGIKLight
        {
            get { return rnGIKValue; }
            set
            {
                rnGIKValue = value;
                OnPropertyChanged("rnGIKLight");
            }
        }
        public string rnRVLight
        {
            get { return rnRVValue; }
            set
            {
                rnRVValue = value;
                OnPropertyChanged("rnRVLight");
            }
        }
        public string rnSP50Light
        {
            get { return rnSP50Value; }
            set
            {
                rnSP50Value = value;
                OnPropertyChanged("rnSP50Light");
            }
        }
        public string rnARK1Light
        {
            get { return rnARK1Value; }
            set
            {
                rnARK1Value = value;
                OnPropertyChanged("rnARK1Light");
            }
        }
        public string rnARK2Light
        {
            get { return rnARK2Value; }
            set
            {
                rnARK2Value = value;
                OnPropertyChanged("rnARK2Light");
            }
        }
        public string rnSROLight
        {
            get { return rnSROValue; }
            set
            {
                rnSROValue = value;
                OnPropertyChanged("rnSROLight");
            }
        }
        public string engFUELPUMPL1Light
        {
            get { return engFUELPUMPL1Value; }
            set
            {
                engFUELPUMPL1Value = value;
                OnPropertyChanged("engFUELPUMPL1Light");
            }
        }
        public string engFUELPUMPL2Light
        {
            get { return engFUELPUMPL2Value; }
            set
            {
                engFUELPUMPL2Value = value;
                OnPropertyChanged("engFUELPUMPL2Light");
            }
        }
        public string engFUELPUMPR1Light
        {
            get { return engFUELPUMPR1Value; }
            set
            {
                engFUELPUMPR1Value = value;
                OnPropertyChanged("engFUELPUMPR1Light");
            }
        }
        public string engFUELPUMPR2Light
        {
            get { return engFUELPUMPR2Value; }
            set
            {
                engFUELPUMPR2Value = value;
                OnPropertyChanged("engFUELPUMPR2Light");
            }
        }
        public string engFUELPUMPINGLight
        {
            get { return engFUELPUMPINGValue; }
            set
            {
                engFUELPUMPINGValue = value;
                OnPropertyChanged("engFUELPUMPINGLight");
            }
        }
        public string engPUMPFLUGLLight
        {
            get { return engPUMPFLUGLValue; }
            set
            {
                engPUMPFLUGLValue = value;
                OnPropertyChanged("engPUMPFLUGLLight");
            }
        }
        public string engPUMPFLUGRLight
        {
            get { return engPUMPFLUGRValue; }
            set
            {
                engPUMPFLUGRValue = value;
                OnPropertyChanged("engPUMPFLUGRLight");
            }
        }
        public string engISOLVAVLELLight
        {
            get { return engISOLVAVLELValue; }
            set
            {
                engISOLVAVLELValue = value;
                OnPropertyChanged("engISOLVAVLELLight");
            }
        }
        public string engISOLVAVLERLight
        {
            get { return engISOLVAVLERValue; }
            set
            {
                engISOLVAVLERValue = value;
                OnPropertyChanged("engISOLVAVLERLight");
            }
        }
        public string engSTARTLLight
        {
            get { return engSTARTLValue; }
            set
            {
                engSTARTLValue = value;
                OnPropertyChanged("engSTARTLLight");
            }
        }
        public string engSTARTRLight
        {
            get { return engSTARTRValue; }
            set
            {
                engSTARTRValue = value;
                OnPropertyChanged("engSTARTRLight");
            }
        }
        public string apSERVOLight
        {
            get { return apSERVOValue; }
            set
            {
                apSERVOValue = value;
                OnPropertyChanged("apSERVOLight");
            }
        }
        public string apINDLight
        {
            get { return apINDValue; }
            set
            {
                apINDValue = value;
                OnPropertyChanged("apINDLight");
            }
        }
        public string bkINDLight
        {
            get { return bkINDValue; }
            set
            {
                bkINDValue = value;
                OnPropertyChanged("bkINDLight");
            }
        }
        public string bkSIGNALLight
        {
            get { return bkSIGNALValue; }
            set
            {
                bkSIGNALValue = value;
                OnPropertyChanged("bkSIGNALLight");
            }
        }
        public string bkGEARSLight
        {
            get { return bkGEARSValue; }
            set
            {
                bkGEARSValue = value;
                OnPropertyChanged("bkGEARSLight");
            }
        }
        public string bkFLAPSLight
        {
            get { return bkFLAPSValue; }
            set
            {
                bkFLAPSValue = value;
                OnPropertyChanged("bkFLAPSLight");
            }
        }
        public string bkTRIMLight
        {
            get { return bkTRIMValue; }
            set
            {
                bkTRIMValue = value;
                OnPropertyChanged("bkTRIMLight");
            }
        }
        public string bkLIGHTLight
        {
            get { return bkLIGHTValue; }
            set
            {
                bkLIGHTValue = value;
                OnPropertyChanged("bkLIGHTLight");
            }
        }
        public string bkCEBOLLight
        {
            get { return bkCEBOLValue; }
            set
            {
                bkCEBOLValue = value;
                OnPropertyChanged("bkCEBOLLight");
            }
        }
        public string bkCEBORLight
        {
            get { return bkCEBORValue; }
            set
            {
                bkCEBORValue = value;
                OnPropertyChanged("bkCEBORLight");
            }
        }
        public string bkFIRESIGLight
        {
            get { return bkFIRESIGValue; }
            set
            {
                bkFIRESIGValue = value;
                OnPropertyChanged("bkFIRESIGLight");
            }
        }
        public string bkIPSCORPLight
        {
            get { return bkIPSCORPValue; }
            set
            {
                bkIPSCORPValue = value;
                OnPropertyChanged("bkIPSCORPLight");
            }
        }
        public string bkICESEPLLight
        {
            get { return bkICESEPLValue; }
            set
            {
                bkICESEPLValue = value;
                OnPropertyChanged("bkICESEPLLight");
            }
        }
        public string bkICESEPRLight
        {
            get { return bkICESEPRValue; }
            set
            {
                bkICESEPRValue = value;
                OnPropertyChanged("bkICESEPRLight");
            }
        }
        public string pwsGENLLight
        {
            get { return pwsGENLValue; }
            set
            {
                pwsGENLValue = value;
                OnPropertyChanged("pwsGENLLight");
            }
        }
        public string pwsGENRLight
        {
            get { return pwsGENRValue; }
            set
            {
                pwsGENRValue = value;
                OnPropertyChanged("pwsGENRLight");
            }
        }
        public string pwsBATT1Light
        {
            get { return pwsBATT1Value; }
            set
            {
                pwsBATT1Value = value;
                OnPropertyChanged("pwsBATT1Light");
            }
        }
        public string pwsBATT2Light
        {
            get { return pwsBATT2Value; }
            set
            {
                pwsBATT2Value = value;
                OnPropertyChanged("pwsBATT2Light");
            }
        }
        public string pwsSWITCHBATLight
        {
            get { return pwsSWITCHBATValue; }
            set
            {
                pwsSWITCHBATValue = value;
                OnPropertyChanged("pwsSWITCHBATLight");
            }
        }
        public string pwsSWITCHGENLLight
        {
            get { return pwsSWITCHGENLValue; }
            set
            {
                pwsSWITCHGENLValue = value;
                OnPropertyChanged("pwsSWITCHGENLLight");
            }
        }
        public string pwsSWITCHGENRLight
        {
            get { return pwsSWITCHGENRValue; }
            set
            {
                pwsSWITCHGENRValue = value;
                OnPropertyChanged("pwsSWITCHGENRLight");
            }
        }
        public string pwsTR115MLight
        {
            get { return pwsTR115MValue; }
            set
            {
                pwsTR115MValue = value;
                OnPropertyChanged("pwsTR115MLight");
            }
        }
        public string pwsTR115RLight
        {
            get { return pwsTR115RValue; }
            set
            {
                pwsTR115RValue = value;
                OnPropertyChanged("pwsTR115RLight");
            }
        }
        public string pwsTR361Light
        {
            get { return pwsTR361Value; }
            set
            {
                pwsTR361Value = value;
                OnPropertyChanged("pwsTR361Light");
            }
        }
        public string pwsTR362Light
        {
            get { return pwsTR362Value; }
            set
            {
                pwsTR362Value = value;
                OnPropertyChanged("pwsTR362Light");
            }
        }
        #endregion

        #region Registration Area

        [MediatorMessageSink("fsc1")]
        private void ipsPVD1ParameterUpdate(object updateParameter)
        {
            ipsPVD1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsPVD2ParameterUpdate(object updateParameter)
        {
            ipsPVD2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsPSNParameterUpdate(object updateParameter)
        {
            ipsPSNParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsFOUNTParameterUpdate(object updateParameter)
        {
            ipsFOUNTParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsSTATINDParameterUpdate(object updateParameter)
        {
            ipsSTATINDParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsROTINDParameterUpdate(object updateParameter)
        {
            ipsROTINDParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsPROP1ParameterUpdate(object updateParameter)
        {
            ipsPROP1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsPROP2ParameterUpdate(object updateParameter)
        {
            ipsPROP2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsICESEPLParameterUpdate(object updateParameter)
        {
            ipsICESEPLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void ipsICESEPRParameterUpdate(object updateParameter)
        {
            ipsICESEPRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void seFANParameterUpdate(object updateParameter)
        {
            seFANParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void seSAIParameterUpdate(object updateParameter)
        {
            seSAIParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void seSPPParameterUpdate(object updateParameter)
        {
            seSPPParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightFIREParameterUpdate(object updateParameter)
        {
            lightFIREParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightANOParameterUpdate(object updateParameter)
        {
            lightANOParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightHL1ParameterUpdate(object updateParameter)
        {
            lightHL1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightHL2ParameterUpdate(object updateParameter)
        {
            lightHL2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightTAXWAY1ParameterUpdate(object updateParameter)
        {
            lightTAXWAY1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightTAXWAY2ParameterUpdate(object updateParameter)
        {
            lightTAXWAY2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightLAND1ParameterUpdate(object updateParameter)
        {
            lightLAND1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightLAND2ParameterUpdate(object updateParameter)
        {
            lightLAND2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightPASCAB1ParameterUpdate(object updateParameter)
        {
            lightPASCAB1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightPASCAB2ParameterUpdate(object updateParameter)
        {
            lightPASCAB2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightLGHTPANELParameterUpdate(object updateParameter)
        {
            lightLGHTPANELParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightPILOTCABParameterUpdate(object updateParameter)
        {
            lightPILOTCABParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void lightINDPANELParameterUpdate(object updateParameter)
        {
            lightINDPANELParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnSPU1ParameterUpdate(object updateParameter)
        {
            rnSPU1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnSPU2ParameterUpdate(object updateParameter)
        {
            rnSPU2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnUKV1ParameterUpdate(object updateParameter)
        {
            rnUKV1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnUKV2ParameterUpdate(object updateParameter)
        {
            rnUKV2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnKVParameterUpdate(object updateParameter)
        {
            rnKVParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnGIKParameterUpdate(object updateParameter)
        {
            rnGIKParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnRVParameterUpdate(object updateParameter)
        {
            rnRVParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnSP50ParameterUpdate(object updateParameter)
        {
            rnSP50Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnARK1ParameterUpdate(object updateParameter)
        {
            rnARK1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnARK2ParameterUpdate(object updateParameter)
        {
            rnARK2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void rnSROParameterUpdate(object updateParameter)
        {
            rnSROParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engFUELPUMPL1ParameterUpdate(object updateParameter)
        {
            engFUELPUMPL1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engFUELPUMPL2ParameterUpdate(object updateParameter)
        {
            engFUELPUMPL2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engFUELPUMPR1ParameterUpdate(object updateParameter)
        {
            engFUELPUMPR1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engFUELPUMPR2ParameterUpdate(object updateParameter)
        {
            engFUELPUMPR2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engFUELPUMPINGParameterUpdate(object updateParameter)
        {
            engFUELPUMPINGParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engPUMPFLUGLParameterUpdate(object updateParameter)
        {
            engPUMPFLUGLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engPUMPFLUGRParameterUpdate(object updateParameter)
        {
            engPUMPFLUGRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engISOLVAVLELParameterUpdate(object updateParameter)
        {
            engISOLVAVLELParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engISOLVAVLERParameterUpdate(object updateParameter)
        {
            engISOLVAVLERParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engSTARTLParameterUpdate(object updateParameter)
        {
            engSTARTLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void engSTARTRParameterUpdate(object updateParameter)
        {
            engSTARTRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void apSERVOParameterUpdate(object updateParameter)
        {
            apSERVOParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void apINDParameterUpdate(object updateParameter)
        {
            apINDParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkINDParameterUpdate(object updateParameter)
        {
            bkINDParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkSIGNALParameterUpdate(object updateParameter)
        {
            bkSIGNALParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkGEARSParameterUpdate(object updateParameter)
        {
            bkGEARSParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkFLAPSParameterUpdate(object updateParameter)
        {
            bkFLAPSParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkTRIMParameterUpdate(object updateParameter)
        {
            bkTRIMParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkLIGHTParameterUpdate(object updateParameter)
        {
            bkLIGHTParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkCEBOLParameterUpdate(object updateParameter)
        {
            bkCEBOLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkCEBORParameterUpdate(object updateParameter)
        {
            bkCEBORParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkFIRESIGParameterUpdate(object updateParameter)
        {
            bkFIRESIGParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkIPSCORPParameterUpdate(object updateParameter)
        {
            bkIPSCORPParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkICESEPLParameterUpdate(object updateParameter)
        {
            bkICESEPLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void bkICESEPRParameterUpdate(object updateParameter)
        {
            bkICESEPRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsGENLParameterUpdate(object updateParameter)
        {
            pwsGENLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsGENRParameterUpdate(object updateParameter)
        {
            pwsGENRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsBATT1ParameterUpdate(object updateParameter)
        {
            pwsBATT1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsBATT2ParameterUpdate(object updateParameter)
        {
            pwsBATT2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsSWITCHBATParameterUpdate(object updateParameter)
        {
            pwsSWITCHBATParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsSWITCHGENLParameterUpdate(object updateParameter)
        {
            pwsSWITCHGENLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsSWITCHGENRParameterUpdate(object updateParameter)
        {
            pwsSWITCHGENRParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsTR115MParameterUpdate(object updateParameter)
        {
            pwsTR115MParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsTR115RParameterUpdate(object updateParameter)
        {
            pwsTR115RParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsTR361ParameterUpdate(object updateParameter)
        {
            pwsTR361Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fsc1")]
        private void pwsTR362ParameterUpdate(object updateParameter)
        {
            pwsTR362Parameter = (Parameter)updateParameter;
        }
        #endregion

    }
}
