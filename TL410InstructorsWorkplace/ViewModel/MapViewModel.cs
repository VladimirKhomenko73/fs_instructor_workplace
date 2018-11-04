using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;

namespace TL410InstructorsWorkplace.ViewModel
{
    class MapViewModel : INPCBase
    {
        private Canvas map = new Canvas();
        private Parameter xParameterValue;
        private Parameter yParameterValue;
        private Parameter headingParameterValue;
        private Parameter altitudeParameterValue;
        private LinkedList<object> mapXCoordinateList;
        private LinkedList<object> mapYCoordinateList;
        private LinkedList<object> mapHeadingList;
        private LinkedList<object> mapAltitudeList;
        private string xListName = "mapXCoordinateList";
        private string yListName = "mapYCoordinateList";
        private string headingListName = "mapHeadingList";
        private string altitudeListName = "mapAltitudeList";

        #region Constructor
        public MapViewModel()
        {

            #region First start check
            if (Mediator.ContainsBufferedParameter("xt"))
            {
                xParameterValue = Mediator.GetBufferedParameter("xt");
            }
            else
            {
                xParameterValue = new Parameter("xt", 0);
            }
            if (Mediator.ContainsBufferedParameter("zt"))
            {
                yParameterValue = Mediator.GetBufferedParameter("zt");
            }
            else
            {
                yParameterValue = new Parameter("zt", 0);
            }
            if (Mediator.ContainsBufferedParameter("psi"))
            {
                headingParameterValue = Mediator.GetBufferedParameter("psi");
            }
            else
            {
                headingParameterValue = new Parameter("psi", 0);
            }
            if (Mediator.ContainsBufferedParameter("h"))
            {
                altitudeParameterValue = Mediator.GetBufferedParameter("h");
            }
            else
            {
                altitudeParameterValue = new Parameter("h", 0);
            }

            if (Mediator.ContainsListInBuffer(xListName))
            {
                mapXCoordinateList = Mediator.GetListFromBuffer(xListName);
            }
            else
            {
                mapXCoordinateList = new LinkedList<object>();
                mapXCoordinateList.AddFirst(xParameterValue);
            }
            if (Mediator.ContainsListInBuffer(yListName))
            {
                mapYCoordinateList = Mediator.GetListFromBuffer(yListName);
            }
            else
            {
                mapYCoordinateList = new LinkedList<object>();
                mapYCoordinateList.AddFirst(yParameterValue);
            }
            if (Mediator.ContainsListInBuffer(headingListName))
            {
                mapHeadingList = Mediator.GetListFromBuffer(headingListName);
            }
            else
            {
                mapHeadingList = new LinkedList<object>();
                mapHeadingList.AddFirst(headingParameterValue);
            }
            if (Mediator.ContainsListInBuffer(altitudeListName))
            {
                mapAltitudeList = Mediator.GetListFromBuffer(altitudeListName);
            }
            else
            {
                mapAltitudeList = new LinkedList<object>();
                mapAltitudeList.AddFirst(altitudeParameterValue);
            }

            DrawOnCanvas(true);
            #endregion

            #region Mediator registration
            Mediator.Instance.Register(this);
            #endregion

        }
        #endregion

        #region Destructor
        ~MapViewModel()
        {
            Mediator.Instance.Unregister(this);
        }
        #endregion

        public Canvas mapSource
        {
            get
            {
                return map;
            }
            set
            {
                map = value;
                OnPropertyChanged("mapSource");
            }
        }

        #region Registration Area
        [MediatorMessageSink("xt")]
        private void xParameterUpdate(object updateParameter)
        {
            Parameter tempParameter = (Parameter)updateParameter;
            if (Math.Abs((tempParameter.GetTime().Second - xParameterValue.GetTime().Second)) >= 1)
            {
                xParameterValue = tempParameter;
                DrawOnCanvas();
                mapXCoordinateList.AddLast(xParameterValue);
                Mediator.AddListToBuffer(xListName, mapXCoordinateList);
            }
        }
        [MediatorMessageSink("zt")]
        private void yParameterUpdate(object updateParameter)
        {
            Parameter tempParameter = (Parameter)updateParameter;
            if (Math.Abs((tempParameter.GetTime().Second - yParameterValue.GetTime().Second)) >= 1)
            {
                yParameterValue = tempParameter;
                DrawOnCanvas();
                mapYCoordinateList.AddLast(yParameterValue);
                Mediator.AddListToBuffer(yListName, mapYCoordinateList);
            }
        }
        [MediatorMessageSink("psi")]
        private void headingParameterUpdate(object updateParameter)
        {
            Parameter tempParameter = (Parameter)updateParameter;
            if (Math.Abs((tempParameter.GetTime().Second - headingParameterValue.GetTime().Second)) >= 1)
            {
                headingParameterValue = tempParameter;
                DrawOnCanvas();
                mapHeadingList.AddLast(headingParameterValue);
                Mediator.AddListToBuffer(headingListName, mapHeadingList);
            }
        }
        [MediatorMessageSink("h")]
        private void altitudeParameterUpdate(object updateParameter)
        {
            Parameter tempParameter = (Parameter)updateParameter;
            if (Math.Abs((tempParameter.GetTime().Second - altitudeParameterValue.GetTime().Second)) >= 1)
            {
                altitudeParameterValue = tempParameter;
                DrawOnCanvas();
                mapAltitudeList.AddLast(altitudeParameterValue);
                Mediator.AddListToBuffer(altitudeListName, mapAltitudeList);
            }
        }
        #endregion

        #region Draw Control
        private void ThreadSafeDrawOnCanvas(bool firstDraw)
        {
            Canvas tempCanvas = new Canvas();
            SolidColorBrush lineBrush = new SolidColorBrush();
            lineBrush.Color = Colors.Black;

            Line newLine;

            Parameter tempOldXParameterValue;
            Parameter tempOldYParameterValue;

            LinkedListNode<object> nodeX;
            LinkedListNode<object> nodeY;
            for (nodeX = mapXCoordinateList.First, nodeY = mapYCoordinateList.First; (nodeX != null) && (nodeY != null); nodeX = nodeX.Next, nodeY = nodeY.Next)
            {
                newLine = new Line();
                newLine.Stroke = lineBrush;

                Parameter tempXParameterValue = (Parameter)nodeX.Value;
                Parameter tempYParameterValue = (Parameter)nodeY.Value;
                if (nodeX.Previous != null)
                {
                    tempOldXParameterValue = (Parameter)nodeX.Previous.Value;
                }
                else
                {
                    tempOldXParameterValue = (Parameter)nodeX.Value;
                }
                if (nodeY.Previous != null)
                {
                    tempOldYParameterValue = (Parameter)nodeY.Previous.Value;
                }
                else
                {
                    tempOldYParameterValue = (Parameter)nodeY.Value;
                }
                newLine.X1 = tempOldXParameterValue.GetValueAsDouble()*0.0175 + 350;
                newLine.Y1 = tempOldYParameterValue.GetValueAsDouble() * 0.0175 + 350;
                newLine.X2 = tempXParameterValue.GetValueAsDouble() * 0.0175 + 350;
                newLine.Y2 = tempYParameterValue.GetValueAsDouble() * 0.0175 + 350;

                tempCanvas.Children.Add(newLine);
            }
            newLine = new Line();
            tempOldXParameterValue = (Parameter)mapXCoordinateList.Last.Value;
            tempOldYParameterValue = (Parameter)mapYCoordinateList.Last.Value;
            newLine.X1 = tempOldXParameterValue.GetValueAsDouble() * 0.0175 + 350;
            newLine.Y1 = tempOldYParameterValue.GetValueAsDouble() * 0.0175 + 350;
            newLine.X2 = xParameterValue.GetValueAsDouble() * 0.0175 + 350;
            newLine.Y2 = yParameterValue.GetValueAsDouble() * 0.0175 + 350;
            tempCanvas.Children.Add(newLine);
            mapSource = tempCanvas;
        }

        private void DrawOnCanvas(bool firstDraw = false)
        {
            Action<bool> method = ThreadSafeDrawOnCanvas;
            System.Windows.Application.Current.Dispatcher.BeginInvoke(method, firstDraw);            
        }
        #endregion
    }
}
