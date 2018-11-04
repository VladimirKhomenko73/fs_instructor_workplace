using TL410InstructorsWorkplace.Model;
using TL410InstructorsWorkplace.Helpers;
using System;

namespace TL410InstructorsWorkplace.ViewModel
{
    class SignalPanelViewModel : INPCBase
    {
        private string fSC1Value;//
        private string fSC2Value;//
        private string fFI1Value;//
        private string fFI2Value;//
        private string fKR1Value;//Mk TMT
        private string fKR2Value;//Mk TMT
        private string fGP1Value;//
        private string fGP2Value;//
        private string fOL1Value;//
        private string fOL2Value;//
        private string fTP1Value;//
        private string fTP2Value;//
        private string fNISValue;//
        private string fTF1Value;//Mk TMT
        private string fTF2Value;//Mk TMT
        private string fUV1Value;//Mk TMT
        private string fUV2Value;//Mk TMT
        private string fFIRE1Value;
        private string fFIRE2Value;
        private string fCEBO1Value;
        private string fCEBO2Value;
        private string fISOLVAVLE1Value;
        private string fISOLVAVLE2Value;
        private string fGENERATOR1Value;
        private string fGENERATOR2Value;
        private string fICESEP1Value;
        private string fICESEP2Value;
        private string fIPSPROP1Value;
        private string fIPSPROP2Value;
        private string fHYD1Value;
        private string fHYD2Value;
        private string fTR1Value;
        private string fTR2Value;
        private string fTR3Value;
        private string fICEValue;
        private string fSTALLValue;
        private string fFASValue;
        private string fBATTValue;
        private string fCALLValue;
        private string fWHEELValue;
        private string fLOWALCValue;
        private string fFUELPUMPValue;
        private string fFBYPASS1Value;
        private string fFBYPASS2Value;

        private Parameter fSC1ParameterValue;
        private Parameter fSC2ParameterValue;
        private Parameter fFI1ParameterValue;
        private Parameter fFI2ParameterValue;
        private Parameter fKR1ParameterValue;
        private Parameter fKR2ParameterValue;
        private Parameter fGP1ParameterValue;
        private Parameter fGP2ParameterValue;
        private Parameter fOL1ParameterValue;
        private Parameter fOL2ParameterValue;
        private Parameter fTP1ParameterValue;
        private Parameter fTP2ParameterValue;
        private Parameter fNISParameterValue;
        private Parameter fTF1ParameterValue;
        private Parameter fTF2ParameterValue;
        private Parameter fUV1ParameterValue;
        private Parameter fUV2ParameterValue;
        private Parameter fFIRE1ParameterValue;
        private Parameter fFIRE2ParameterValue;
        private Parameter fCEBO1ParameterValue;
        private Parameter fCEBO2ParameterValue;
        private Parameter fISOLVAVLE1ParameterValue;
        private Parameter fISOLVAVLE2ParameterValue;
        private Parameter fGENERATOR1ParameterValue;
        private Parameter fGENERATOR2ParameterValue;
        private Parameter fICESEP1ParameterValue;
        private Parameter fICESEP2ParameterValue;
        private Parameter fIPSPROP1ParameterValue;
        private Parameter fIPSPROP2ParameterValue;
        private Parameter fHYD1ParameterValue;
        private Parameter fHYD2ParameterValue;
        private Parameter fTR1ParameterValue;
        private Parameter fTR2ParameterValue;
        private Parameter fTR3ParameterValue;
        private Parameter fICEParameterValue;
        private Parameter fSTALLParameterValue;
        private Parameter fFASParameterValue;
        private Parameter fBATTParameterValue;
        private Parameter fCALLParameterValue;
        private Parameter fWHEELParameterValue;
        private Parameter fLOWALCParameterValue;
        private Parameter fFUELPUMPParameterValue;
        private Parameter fFBYPASS1ParameterValue;
        private Parameter fFBYPASS2ParameterValue;



        #region Constructor
        public SignalPanelViewModel()
        {
            #region First start check
            if (Mediator.ContainsBufferedParameter("fsc1"))
            {
                fSC1Parameter = Mediator.GetBufferedParameter("fsc1");
            }
            else
            {
                fSC1Parameter = new Parameter("fsc1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fsc2"))
            {
                fSC2Parameter = Mediator.GetBufferedParameter("fsc2");
            }
            else
            {
                fSC2Parameter = new Parameter("fsc2", 0);
            }
            if (Mediator.ContainsBufferedParameter("ffi1"))
            {
                fFI1Parameter = Mediator.GetBufferedParameter("ffi1");
            }
            else
            {
                fFI1Parameter = new Parameter("ffi1", 0);
            }
            if (Mediator.ContainsBufferedParameter("ffi2"))
            {
                fFI2Parameter = Mediator.GetBufferedParameter("ffi2");
            }
            else
            {
                fFI2Parameter = new Parameter("ffi2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fkr1"))////////////!!!!!
            {
                fKR1Parameter = Mediator.GetBufferedParameter("fkr1");
            }
            else
            {
                fKR1Parameter = new Parameter("fkr1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fkr2"))////////!!!!!!!
            {
                fKR2Parameter = Mediator.GetBufferedParameter("fkr2");
            }
            else
            {
                fKR2Parameter = new Parameter("fkr2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fgp1"))
            {
                fGP1Parameter = Mediator.GetBufferedParameter("fgp1");
            }
            else
            {
                fGP1Parameter = new Parameter("fgp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fgp2"))
            {
                fGP2Parameter = Mediator.GetBufferedParameter("fgp2");
            }
            else
            {
                fGP2Parameter = new Parameter("fgp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fol1"))
            {
                fOL1Parameter = Mediator.GetBufferedParameter("fol1");
            }
            else
            {
                fOL1Parameter = new Parameter("fol1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fol2"))
            {
                fOL2Parameter = Mediator.GetBufferedParameter("fol2");
            }
            else
            {
                fOL2Parameter = new Parameter("fol2", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftp1"))
            {
                fTP1Parameter = Mediator.GetBufferedParameter("ftp1");
            }
            else
            {
                fTP1Parameter = new Parameter("ftp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftp2"))
            {
                fTP2Parameter = Mediator.GetBufferedParameter("ftp2");
            }
            else
            {
                fTP2Parameter = new Parameter("ftp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftf1"))///////!!!!
            {
                fTF1Parameter = Mediator.GetBufferedParameter("ftf1");
            }
            else
            {
                fTF1Parameter = new Parameter("ftf1", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftf2"))///////!!!!!
            {
                fTF2Parameter = Mediator.GetBufferedParameter("ftf2");
            }
            else
            {
                fTF2Parameter = new Parameter("ftf2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fuv1"))////////!!!!!
            {
                fUV1Parameter = Mediator.GetBufferedParameter("fuv1");
            }
            else
            {
                fUV1Parameter = new Parameter("fuv1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fuv2"))///////!!!!!!!!
            {
                fUV2Parameter = Mediator.GetBufferedParameter("fuv2");
            }
            else
            {
                fUV2Parameter = new Parameter("fuv2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fnis"))
            {
                fNISParameter = Mediator.GetBufferedParameter("fnis");
            }
            else
            {
                fNISParameter = new Parameter("fnis", 0);
            }
            if (Mediator.ContainsBufferedParameter("ffire1"))
            {
                fFIRE1Parameter = Mediator.GetBufferedParameter("ffire1");
            }
            else
            {
                fFIRE1Parameter = new Parameter("ffire1", 0);
            }
            if (Mediator.ContainsBufferedParameter("ffire2"))
            {
                fFIRE2Parameter = Mediator.GetBufferedParameter("ffire2");
            }
            else
            {
                fFIRE2Parameter = new Parameter("ffire2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fuec1"))
            {
                fCEBO1Parameter = Mediator.GetBufferedParameter("fuec1");
            }
            else
            {
                fCEBO1Parameter = new Parameter("fuec1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fuec2"))
            {
                fCEBO2Parameter = Mediator.GetBufferedParameter("fuec2");
            }
            else
            {
                fCEBO2Parameter = new Parameter("fuec2", 0);
            }
            if (Mediator.ContainsBufferedParameter("stk1"))
            {
                fISOLVAVLE1Parameter = Mediator.GetBufferedParameter("stk1");
            }
            else
            {
                fISOLVAVLE1Parameter = new Parameter("stk1", 0);
            }
            if (Mediator.ContainsBufferedParameter("stk2"))
            {
                fISOLVAVLE2Parameter = Mediator.GetBufferedParameter("stk2");
            }
            else
            {
                fISOLVAVLE2Parameter = new Parameter("stk2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fgen1"))
            {
                fGENERATOR1Parameter = Mediator.GetBufferedParameter("fgen1");
            }
            else
            {
                fGENERATOR1Parameter = new Parameter("fgen1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fgen2"))
            {
                fGENERATOR2Parameter = Mediator.GetBufferedParameter("fgen2");
            }
            else
            {
                fGENERATOR2Parameter = new Parameter("fgen2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fisep1"))
            {
                fICESEP1Parameter = Mediator.GetBufferedParameter("fisep1");
            }
            else
            {
                fICESEP1Parameter = new Parameter("fisep1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fisep2"))
            {
                fICESEP2Parameter = Mediator.GetBufferedParameter("fisep2");
            }
            else
            {
                fICESEP2Parameter = new Parameter("fisep2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fipsp1"))
            {
                fIPSPROP1Parameter = Mediator.GetBufferedParameter("fipsp1");
            }
            else
            {
                fIPSPROP1Parameter = new Parameter("fipsp1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fipsp2"))
            {
                fIPSPROP2Parameter = Mediator.GetBufferedParameter("fipsp2");
            }
            else
            {
                fIPSPROP2Parameter = new Parameter("fipsp2", 0);
            }
            if (Mediator.ContainsBufferedParameter("fhyd1"))
            {
                fHYD1Parameter = Mediator.GetBufferedParameter("fhyd1");
            }
            else
            {
                fHYD1Parameter = new Parameter("fhyd1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fhyd2"))
            {
                fHYD2Parameter = Mediator.GetBufferedParameter("fhyd2");
            }
            else
            {
                fHYD2Parameter = new Parameter("fhyd2", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftr1"))
            {
                fTR1Parameter = Mediator.GetBufferedParameter("ftr1");
            }
            else
            {
                fTR1Parameter = new Parameter("ftr1", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftr2"))
            {
                fTR2Parameter = Mediator.GetBufferedParameter("ftr2");
            }
            else
            {
                fTR2Parameter = new Parameter("ftr2", 0);
            }
            if (Mediator.ContainsBufferedParameter("ftr3"))
            {
                fTR3Parameter = Mediator.GetBufferedParameter("ftr3");
            }
            else
            {
                fTR3Parameter = new Parameter("ftr3", 0);
            }
            if (Mediator.ContainsBufferedParameter("fice"))
            {
                fICEParameter = Mediator.GetBufferedParameter("fice");
            }
            else
            {
                fICEParameter = new Parameter("fice", 0);
            }
            if (Mediator.ContainsBufferedParameter("fstall"))
            {
                fSTALLParameter = Mediator.GetBufferedParameter("fstall");
            }
            else
            {
                fSTALLParameter = new Parameter("fstall", 0);
            }
            if (Mediator.ContainsBufferedParameter("fep"))
            {
                fFASParameter = Mediator.GetBufferedParameter("fep");
            }
            else
            {
                fFASParameter = new Parameter("fep", 0);
            }
            if (Mediator.ContainsBufferedParameter("fbatt"))
            {
                fBATTParameter = Mediator.GetBufferedParameter("fbatt");
            }
            else
            {
                fBATTParameter = new Parameter("fbatt", 0);
            }
            if (Mediator.ContainsBufferedParameter("fcall"))
            {
                fCALLParameter = Mediator.GetBufferedParameter("fcall");
            }
            else
            {
                fCALLParameter = new Parameter("fcall", 0);
            }
            if (Mediator.ContainsBufferedParameter("pk"))
            {
                fWHEELParameter = Mediator.GetBufferedParameter("pk");
            }
            else
            {
                fWHEELParameter = new Parameter("pk", 0);
            }
            if (Mediator.ContainsBufferedParameter("falc"))
            {
                fLOWALCParameter = Mediator.GetBufferedParameter("falc");
            }
            else
            {
                fLOWALCParameter = new Parameter("falc", 0);
            }
            if (Mediator.ContainsBufferedParameter("fm5"))
            {
                fFUELPUMPParameter = Mediator.GetBufferedParameter("fm5");
            }
            else
            {
                fFUELPUMPParameter = new Parameter("fm5", 0);
            }
            if (Mediator.ContainsBufferedParameter("fbps1"))
            {
                fFBYPASS1Parameter = Mediator.GetBufferedParameter("fbps1");
            }
            else
            {
                fFBYPASS1Parameter = new Parameter("fbps1", 0);
            }
            if (Mediator.ContainsBufferedParameter("fbps2"))
            {
                fFBYPASS2Parameter = Mediator.GetBufferedParameter("fbps2");
            }
            else
            {
                fFBYPASS2Parameter = new Parameter("fbps2", 0);
            }

            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion
        }
        #endregion

        #region Destructor
        ~SignalPanelViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        #region Parameter properties

        private Parameter fSC1Parameter
        {
            get { return fSC1ParameterValue; }
            set
            {
                fSC1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fSC1Light = "Gold";
                }
                else
                {
                    fSC1Light = "Black";
                }
                
            }
        }
        private Parameter fSC2Parameter
        {
            get { return fSC2ParameterValue; }
            set
            {
                fSC2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fSC2Light = "Gold";
                }
                else
                {
                    fSC2Light = "Black";
                }

            }
        }

        private Parameter fFI1Parameter
        {
            get { return fFI1ParameterValue; }
            set
            {
                fFI1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFI1Light = "Gold";
                }
                else
                {
                    fFI1Light = "Black";
                }

            }
        }
        private Parameter fFI2Parameter
        {
            get { return fFI2ParameterValue; }
            set
            {
                fFI2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFI2Light = "Gold";
                }
                else
                {
                    fFI2Light = "Black";
                }

            }
        }

        private Parameter fKR1Parameter
        {
            get { return fKR1ParameterValue; }
            set
            {
                fKR1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fKR1Light = "Gold";
                }
                else
                {
                    fKR1Light = "Black";
                }

            }
        }
        private Parameter fKR2Parameter
        {
            get { return fKR2ParameterValue; }
            set
            {
                fKR2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fKR2Light = "Gold";
                }
                else
                {
                    fKR2Light = "Black";
                }

            }
        }

        private Parameter fGP1Parameter
        {
            get { return fGP1ParameterValue; }
            set
            {
                fGP1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fGP1Light = "Gold";
                }
                else
                {
                    fGP1Light = "Black";
                }

            }
        }
        private Parameter fGP2Parameter
        {
            get { return fGP2ParameterValue; }
            set
            {
                fGP2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fGP2Light = "Gold";
                }
                else
                {
                    fGP2Light = "Black";
                }

            }
        }
        private Parameter fOL1Parameter
        {
            get { return fOL1ParameterValue; }
            set
            {
                fOL1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fOL1Light = "Gold";
                }
                else
                {
                    fOL1Light = "Black";
                }

            }
        }
        private Parameter fOL2Parameter
        {
            get { return fOL2ParameterValue; }
            set
            {
                fOL2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fOL2Light = "Gold";
                }
                else
                {
                    fOL2Light = "Black";
                }

            }
        }

        private Parameter fTP1Parameter
        {
            get { return fTP1ParameterValue; }
            set
            {
                fTP1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTP1Light = "Gold";
                }
                else
                {
                    fTP1Light = "Black";
                }

            }
        }
        private Parameter fTP2Parameter
        {
            get { return fTP2ParameterValue; }
            set
            {
                fTP2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTP2Light = "Gold";
                }
                else
                {
                    fTP2Light = "Black";
                }

            }
        }

        private Parameter fTF1Parameter
        {
            get { return fTF1ParameterValue; }
            set
            {
                fTF1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTF1Light = "Gold";
                }
                else
                {
                    fTF1Light = "Black";
                }

            }
        }
        private Parameter fTF2Parameter
        {
            get { return fTF2ParameterValue; }
            set
            {
                fTF2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTF2Light = "Gold";
                }
                else
                {
                    fTF2Light = "Black";
                }

            }
        }

        private Parameter fUV1Parameter
        {
            get { return fUV1ParameterValue; }
            set
            {
                fUV1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fUV1Light = "Gold";
                }
                else
                {
                    fUV1Light = "Black";
                }

            }
        }
        private Parameter fUV2Parameter
        {
            get { return fUV2ParameterValue; }
            set
            {
                fUV2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fUV2Light = "Gold";
                }
                else
                {
                    fUV2Light = "Black";
                }

            }
        }

        private Parameter fNISParameter
        {
            get { return fNISParameterValue; }
            set
            {
                fNISParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fNISLight = "Gold";
                }
                else
                {
                    fNISLight = "Black";
                }

            }
        }

        private Parameter fFIRE1Parameter
        {
            get { return fFIRE1ParameterValue; }
            set
            {
                fFIRE1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFIRE1Light = "Red";
                }
                else
                {
                    fFIRE1Light = "Black";
                }

            }
        }
        private Parameter fFIRE2Parameter
        {
            get { return fFIRE2ParameterValue; }
            set
            {
                fFIRE2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFIRE2Light = "Red";
                }
                else
                {
                    fFIRE2Light = "Black";
                }

            }
        }
        private Parameter fCEBO1Parameter
        {
            get { return fCEBO1ParameterValue; }
            set
            {
                fCEBO1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fCEBO1Light = "Gold";
                }
                else
                {
                    fCEBO1Light = "Black";
                }

            }
        }
        private Parameter fCEBO2Parameter
        {
            get { return fCEBO2ParameterValue; }
            set
            {
                fCEBO2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fCEBO2Light = "Gold";
                }
                else
                {
                    fCEBO2Light = "Black";
                }

            }
        }
        private Parameter fISOLVAVLE1Parameter
        {
            get { return fISOLVAVLE1ParameterValue; }
            set
            {
                fISOLVAVLE1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fISOLVAVLE1Light = "Gold";
                }
                else
                {
                    fISOLVAVLE1Light = "Black";
                }

            }
        }
        private Parameter fISOLVAVLE2Parameter
        {
            get { return fISOLVAVLE2ParameterValue; }
            set
            {
                fISOLVAVLE2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fISOLVAVLE2Light = "Gold";
                }
                else
                {
                    fISOLVAVLE2Light = "Black";
                }

            }
        }
        private Parameter fGENERATOR1Parameter
        {
            get { return fGENERATOR1ParameterValue; }
            set
            {
                fGENERATOR1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fGENERATOR1Light = "Gold";
                }
                else
                {
                    fGENERATOR1Light = "Black";
                }

            }
        }
        private Parameter fGENERATOR2Parameter
        {
            get { return fGENERATOR2ParameterValue; }
            set
            {
                fGENERATOR2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fGENERATOR2Light = "Gold";
                }
                else
                {
                    fGENERATOR2Light = "Black";
                }

            }
        }
        private Parameter fICESEP1Parameter
        {
            get { return fICESEP1ParameterValue; }
            set
            {
                fICESEP1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fICESEP1Light = "GreenYellow";
                }
                else
                {
                    fICESEP1Light = "Black";
                }

            }
        }
        private Parameter fICESEP2Parameter
        {
            get { return fICESEP2ParameterValue; }
            set
            {
                fICESEP2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fICESEP2Light = "GreenYellow";
                }
                else
                {
                    fICESEP2Light = "Black";
                }

            }
        }
        private Parameter fIPSPROP1Parameter
        {
            get { return fIPSPROP1ParameterValue; }
            set
            {
                fIPSPROP1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fIPSPROP1Light = "Gold";
                }
                else
                {
                    fIPSPROP1Light = "Black";
                }

            }
        }
        private Parameter fIPSPROP2Parameter
        {
            get { return fIPSPROP2ParameterValue; }
            set
            {
                fIPSPROP2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fIPSPROP2Light = "Gold";
                }
                else
                {
                    fIPSPROP2Light = "Black";
                }

            }
        }
        private Parameter fHYD1Parameter
        {
            get { return fHYD1ParameterValue; }
            set
            {
                fHYD1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fHYD1Light = "Gold";
                }
                else
                {
                    fHYD1Light = "Black";
                }

            }
        }
        private Parameter fHYD2Parameter
        {
            get { return fHYD2ParameterValue; }
            set
            {
                fHYD2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fHYD2Light = "Gold";
                }
                else
                {
                    fHYD2Light = "Black";
                }

            }
        }
        private Parameter fTR1Parameter
        {
            get { return fTR1ParameterValue; }
            set
            {
                fTR1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTR1Light = "Gold";
                }
                else
                {
                    fTR1Light = "Black";
                }

            }
        }
        private Parameter fTR2Parameter
        {
            get { return fTR2ParameterValue; }
            set
            {
                fTR2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTR2Light = "Gold";
                }
                else
                {
                    fTR2Light = "Black";
                }

            }
        }
        private Parameter fTR3Parameter
        {
            get { return fTR3ParameterValue; }
            set
            {
                fTR3ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fTR3Light = "Gold";
                }
                else
                {
                    fTR3Light = "Black";
                }

            }
        }
        private Parameter fICEParameter
        {
            get { return fICEParameterValue; }
            set
            {
                fICEParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fICELight = "Gold";
                }
                else
                {
                    fICELight = "Black";
                }

            }
        }
        private Parameter fSTALLParameter
        {
            get { return fSTALLParameterValue; }
            set
            {
                fSTALLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fSTALLLight = "Red";
                }
                else
                {
                    fSTALLLight = "Black";
                }

            }
        }
        private Parameter fFASParameter
        {
            get { return fFASParameterValue; }
            set
            {
                fFASParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFASLight = "Red";
                }
                else
                {
                    fFASLight = "Black";
                }

            }
        }
        private Parameter fBATTParameter
        {
            get { return fBATTParameterValue; }
            set
            {
                fBATTParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fBATTLight = "Gold";
                }
                else
                {
                    fBATTLight = "Black";
                }

            }
        }
        private Parameter fCALLParameter
        {
            get { return fCALLParameterValue; }
            set
            {
                fCALLParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fCALLLight = "GhostWhite";
                }
                else
                {
                    fCALLLight = "Black";
                }

            }
        }
        private Parameter fWHEELParameter
        {
            get { return fWHEELParameterValue; }
            set
            {
                fWHEELParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fWHEELLight = "Gold";
                }
                else
                {
                    fWHEELLight = "Black";
                }

            }
        }
        private Parameter fLOWALCParameter
        {
            get { return fLOWALCParameterValue; }
            set
            {
                fLOWALCParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fLOWALCLight = "Gold";
                }
                else
                {
                    fLOWALCLight = "Black";
                }

            }
        }
        private Parameter fFUELPUMPParameter
        {
            get { return fFUELPUMPParameterValue; }
            set
            {
                fFUELPUMPParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFUELPUMPLight = "Gold";
                }
                else
                {
                    fFUELPUMPLight = "Black";
                }

            }
        }
        private Parameter fFBYPASS1Parameter
        {
            get { return fFBYPASS1ParameterValue; }
            set
            {
                fFBYPASS1ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFBYPASS1Light = "Gold";
                }
                else
                {
                    fFBYPASS1Light = "Black";
                }

            }
        }
        private Parameter fFBYPASS2Parameter
        {
            get { return fFBYPASS2ParameterValue; }
            set
            {
                fFBYPASS2ParameterValue = value;
                if (value.GetValueAsInt() == 1)
                {
                    fFBYPASS2Light = "Gold";
                }
                else
                {
                    fFBYPASS2Light = "Black";
                }

            }
        }

        #endregion

        #region Light Values

        public string fSC1Light
        {
            get { return fSC1Value; }
            set
            {
                fSC1Value = value;
                OnPropertyChanged("fSC1Light");
            }
        }
        public string fSC2Light
        {
            get { return fSC2Value; }
            set
            {
                fSC2Value = value;
                OnPropertyChanged("fSC2Light");
            }
        }

        public string fFI1Light
        {
            get { return fFI1Value; }
            set
            {
                fFI1Value = value;
                OnPropertyChanged("fFI1Light");
            }
        }
        public string fFI2Light
        {
            get { return fFI2Value; }
            set
            {
                fFI2Value = value;
                OnPropertyChanged("fFI2Light");
            }
        }

        public string fKR1Light
        {
            get { return fKR1Value; }
            set
            {
                fKR1Value = value;
                OnPropertyChanged("fKR1Light");
            }
        }
        public string fKR2Light
        {
            get { return fKR2Value; }
            set
            {
                fKR2Value = value;
                OnPropertyChanged("fKR2Light");
            }
        }

        public string fGP1Light
        {
            get { return fGP1Value; }
            set
            {
                fGP1Value = value;
                OnPropertyChanged("fGP1Light");
            }
        }
        public string fGP2Light
        {
            get { return fGP2Value; }
            set
            {
                fGP2Value = value;
                OnPropertyChanged("fGP2Light");
            }
        }

        public string fOL1Light
        {
            get { return fOL1Value; }
            set
            {
                fOL1Value = value;
                OnPropertyChanged("fOL1Light");
            }
        }
        public string fOL2Light
        {
            get { return fOL2Value; }
            set
            {
                fOL2Value = value;
                OnPropertyChanged("fOL2Light");
            }
        }

        public string fTP1Light
        {
            get { return fTP1Value; }
            set
            {
                fTP1Value = value;
                OnPropertyChanged("fTP1Light");
            }
        }
        public string fTP2Light
        {
            get { return fTP2Value; }
            set
            {
                fTP2Value = value;
                OnPropertyChanged("fTP2Light");
            }
        }

        public string fTF1Light
        {
            get { return fTF1Value; }
            set
            {
                fTF1Value = value;
                OnPropertyChanged("fTF1Light");
            }
        }
        public string fTF2Light
        {
            get { return fTF2Value; }
            set
            {
                fTF2Value = value;
                OnPropertyChanged("fTF2Light");
            }
        }

        public string fUV1Light
        {
            get { return fUV1Value; }
            set
            {
                fUV1Value = value;
                OnPropertyChanged("fUV1Light");
            }
        }
        public string fUV2Light
        {
            get { return fUV2Value; }
            set
            {
                fUV2Value = value;
                OnPropertyChanged("fUV2Light");
            }
        }

        public string fNISLight
        {
            get { return fNISValue; }
            set
            {
                fNISValue = value;
                OnPropertyChanged("fNISLight");
            }
        }

        public string fFIRE1Light
        {
            get { return fFIRE1Value; }
            set
            {
                fFIRE1Value = value;
                OnPropertyChanged("fFIRE1Light");
            }
        }
        public string fFIRE2Light
        {
            get { return fFIRE2Value; }
            set
            {
                fFIRE2Value = value;
                OnPropertyChanged("fFIRE2Light");
            }
        }
        public string fCEBO1Light
        {
            get { return fCEBO1Value; }
            set
            {
                fCEBO1Value = value;
                OnPropertyChanged("fCEBO1Light");
            }
        }
        public string fCEBO2Light
        {
            get { return fCEBO2Value; }
            set
            {
                fCEBO2Value = value;
                OnPropertyChanged("fCEBO2Light");
            }
        }
        public string fISOLVAVLE1Light
        {
            get { return fISOLVAVLE1Value; }
            set
            {
                fISOLVAVLE1Value = value;
                OnPropertyChanged("fISOLVAVLE1Light");
            }
        }
        public string fISOLVAVLE2Light
        {
            get { return fISOLVAVLE2Value; }
            set
            {
                fISOLVAVLE2Value = value;
                OnPropertyChanged("fISOLVAVLE2Light");
            }
        }
        public string fGENERATOR1Light
        {
            get { return fGENERATOR1Value; }
            set
            {
                fGENERATOR1Value = value;
                OnPropertyChanged("fGENERATOR1Light");
            }
        }
        public string fGENERATOR2Light
        {
            get { return fGENERATOR2Value; }
            set
            {
                fGENERATOR2Value = value;
                OnPropertyChanged("fGENERATOR2Light");
            }
        }
        public string fICESEP1Light
        {
            get { return fICESEP1Value; }
            set
            {
                fICESEP1Value = value;
                OnPropertyChanged("fICESEP1Light");
            }
        }
        public string fICESEP2Light
        {
            get { return fICESEP2Value; }
            set
            {
                fICESEP2Value = value;
                OnPropertyChanged("fICESEP2Light");
            }
        }
        public string fIPSPROP1Light
        {
            get { return fIPSPROP1Value; }
            set
            {
                fIPSPROP1Value = value;
                OnPropertyChanged("fIPSPROP1Light");
            }
        }
        public string fIPSPROP2Light
        {
            get { return fIPSPROP2Value; }
            set
            {
                fIPSPROP2Value = value;
                OnPropertyChanged("fIPSPROP2Light");
            }
        }
        public string fHYD1Light
        {
            get { return fHYD1Value; }
            set
            {
                fHYD1Value = value;
                OnPropertyChanged("fHYD1Light");
            }
        }
        public string fHYD2Light
        {
            get { return fHYD2Value; }
            set
            {
                fHYD2Value = value;
                OnPropertyChanged("fHYD2Light");
            }
        }
        public string fTR1Light
        {
            get { return fTR1Value; }
            set
            {
                fTR1Value = value;
                OnPropertyChanged("fTR1Light");
            }
        }
        public string fTR2Light
        {
            get { return fTR2Value; }
            set
            {
                fTR2Value = value;
                OnPropertyChanged("fTR2Light");
            }
        }
        public string fTR3Light
        {
            get { return fTR3Value; }
            set
            {
                fTR3Value = value;
                OnPropertyChanged("fTR3Light");
            }
        }
        public string fICELight
        {
            get { return fICEValue; }
            set
            {
                fICEValue = value;
                OnPropertyChanged("fICELight");
            }
        }
        public string fSTALLLight
        {
            get { return fSTALLValue; }
            set
            {
                fSTALLValue = value;
                OnPropertyChanged("fSTALLLight");
            }
        }
        public string fFASLight
        {
            get { return fFASValue; }
            set
            {
                fFASValue = value;
                OnPropertyChanged("fFASLight");
            }
        }
        public string fBATTLight
        {
            get { return fBATTValue; }
            set
            {
                fBATTValue = value;
                OnPropertyChanged("fBATTLight");
            }
        }
        public string fCALLLight
        {
            get { return fCALLValue; }
            set
            {
                fCALLValue = value;
                OnPropertyChanged("fCALLLight");
            }
        }
        public string fWHEELLight
        {
            get { return fWHEELValue; }
            set
            {
                fWHEELValue = value;
                OnPropertyChanged("fWHEELLight");
            }
        }
        public string fLOWALCLight
        {
            get { return fLOWALCValue; }
            set
            {
                fLOWALCValue = value;
                OnPropertyChanged("fLOWALCLight");
            }
        }
        public string fFUELPUMPLight
        {
            get { return fFUELPUMPValue; }
            set
            {
                fFUELPUMPValue = value;
                OnPropertyChanged("fFUELPUMPLight");
            }
        }
        public string fFBYPASS1Light
        {
            get { return fFBYPASS1Value; }
            set
            {
                fFBYPASS1Value = value;
                OnPropertyChanged("fFBYPASS1Light");
            }
        }
        public string fFBYPASS2Light
        {
            get { return fFBYPASS2Value; }
            set
            {
                fFBYPASS2Value = value;
                OnPropertyChanged("fFBYPASS2Light");
            }
        }

        #endregion

        #region Registration Area

        [MediatorMessageSink("fsc1")]
        private void fSC1ParameterUpdate(object updateParameter)
        {
            fSC1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("fsc2")]
        private void fSC2ParameterUpdate(object updateParameter)
        {
            fSC2Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("ffi1")]
        private void fFI1ParameterUpdate(object updateParameter)
        {
            fFI1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("ffi2")]
        private void fFI2ParameterUpdate(object updateParameter)
        {
            fFI2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fkr1")]///!!!
        private void fKR1ParameterUpdate(object updateParameter)
        {
            fKR1Parameter = (Parameter)updateParameter;
            if (fTF1Parameter.GetValueAsBool()||fUV1Parameter.GetValueAsBool()==true)
            {
                fKR1Parameter = new Parameter("fkr1",1);
            }
        }

        [MediatorMessageSink("fkr2")]////!!!
        private void fKR2ParameterUpdate(object updateParameter)
        {
            fKR2Parameter = (Parameter)updateParameter;
            if (fTF2Parameter.GetValueAsBool() || fUV2Parameter.GetValueAsBool() == true)
            {
                fKR2Parameter = new Parameter("fkr1", 1);
            }
        }
        [MediatorMessageSink("fgp1")]
        private void fGP1ParameterUpdate(object updateParameter)
        {
            fGP1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("fgp2")]
        private void fGP2ParameterUpdate(object updateParameter)
        {
            fGP2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fol1")]
        private void fOL1ParameterUpdate(object updateParameter)
        {
            fOL1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("fol2")]
        private void fOL2ParameterUpdate(object updateParameter)
        {
            fOL2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ftp1")]
        private void fTP1ParameterUpdate(object updateParameter)
        {
            fTP1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("ftp2")]
        private void fTP2ParameterUpdate(object updateParameter)
        {
            fTP2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ftf1")]/////
        private void fTF1ParameterUpdate(object updateParameter)
        {
            fTF1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("ftf2")]/////
        private void fTF2ParameterUpdate(object updateParameter)
        {
            fTF2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fuv1")]/////
        private void fUV1ParameterUpdate(object updateParameter)
        {
            fUV1Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("fuv2")]//////
        private void fUV2ParameterUpdate(object updateParameter)
        {
            fUV2Parameter = (Parameter)updateParameter;
        }

        [MediatorMessageSink("fnis")]
        private void fNISParameterUpdate(object updateParameter)
        {
            fNISParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ffire1")]
        private void fFIRE1ParameterUpdate(object updateParameter)
        {
            fFIRE1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ffire2")]
        private void fFIRE2ParameterUpdate(object updateParameter)
        {
            fFIRE2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fuec1")]
        private void fCEBO1ParameterUpdate(object updateParameter)
        {
            fCEBO1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fuec2")]
        private void fCEBO2ParameterUpdate(object updateParameter)
        {
            fCEBO2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("stk1")]
        private void fISOLVAVLE1ParameterUpdate(object updateParameter)
        {
            fISOLVAVLE1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("stk2")]
        private void fISOLVAVLE2ParameterUpdate(object updateParameter)
        {
            fISOLVAVLE2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fgen1")]
        private void fGENERATOR1ParameterUpdate(object updateParameter)
        {
            fGENERATOR1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fgen2")]
        private void fGENERATOR2ParameterUpdate(object updateParameter)
        {
            fGENERATOR2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fisep1")]
        private void fICESEP1ParameterUpdate(object updateParameter)
        {
            fICESEP1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fisep2")]
        private void fICESEP2ParameterUpdate(object updateParameter)
        {
            fICESEP2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fipsp1")]
        private void fIPSPROP1ParameterUpdate(object updateParameter)
        {
            fIPSPROP1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fipsp2")]
        private void fIPSPROP2ParameterUpdate(object updateParameter)
        {
            fIPSPROP2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fhyd1")]
        private void fHYD1ParameterUpdate(object updateParameter)
        {
            fHYD1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fhyd2")]
        private void fHYD2ParameterUpdate(object updateParameter)
        {
            fHYD2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ftr1")]
        private void fTR1ParameterUpdate(object updateParameter)
        {
            fTR1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ftr2")]
        private void fTR2ParameterUpdate(object updateParameter)
        {
            fTR2Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("ftr3")]
        private void fTR3ParameterUpdate(object updateParameter)
        {
            fTR3Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fice")]
        private void fICEParameterUpdate(object updateParameter)
        {
            fICEParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fstall")]
        private void fSTALLParameterUpdate(object updateParameter)
        {
            fSTALLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fep")]
        private void fFASParameterUpdate(object updateParameter)
        {
            fFASParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fbatt")]
        private void fBATTParameterUpdate(object updateParameter)
        {
            fBATTParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fcall")]
        private void fCALLParameterUpdate(object updateParameter)
        {
            fCALLParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("pk")]
        private void fWHEELParameterUpdate(object updateParameter)
        {
            fWHEELParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("falc")]
        private void fLOWALCParameterUpdate(object updateParameter)
        {
            fLOWALCParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fm5")]
        private void fFUELPUMPParameterUpdate(object updateParameter)
        {
            fFUELPUMPParameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fbps1")]
        private void fFBYPASS1ParameterUpdate(object updateParameter)
        {
            fFBYPASS1Parameter = (Parameter)updateParameter;
        }
        [MediatorMessageSink("fbps2")]
        private void fFBYPASS2ParameterUpdate(object updateParameter)
        {
            fFBYPASS2Parameter = (Parameter)updateParameter;
        }

        #endregion

    }
}
