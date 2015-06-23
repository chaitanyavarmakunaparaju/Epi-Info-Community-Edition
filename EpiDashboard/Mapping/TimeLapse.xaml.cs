﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EpiDashboard.Mapping
{
    /// <summary>
    /// Interaction logic for TimeLapse.xaml
    /// </summary>
    public partial class TimeLapse : UserControl
    {

        private ClusterLayerProvider provider;
        private IMapControl mapControl;
        public event EventHandler Cancelled;
        public event EventHandler ChangesAccepted;

        public string TimeVariable
        {
            get
            {
                if (cmbVariable.SelectedIndex != -1)
                    return cmbVariable.SelectedItem.ToString();
                else
                    return null;
            }
        }

        # region Constructors
        public TimeLapse(List<DashboardHelper> dashboardHelpers, StandaloneMapControl mapControl, ESRI.ArcGIS.Client.Map myMap)
        {
            InitializeComponent();
            provider = new ClusterLayerProvider(myMap);
            this.mapControl = mapControl;
            mapControl.TimeVariableSet += new TimeVariableSetHandler(mapControl_TimeVariableSet);
            FillComboBox(dashboardHelpers);            
        }

        public TimeLapse(Epi.View view)
        {
            InitializeComponent();
            FillComboBox(view);
        }

        #endregion

        # region Private methods

        void mapControl_TimeVariableSet(string timeVariable)
        {
            provider.TimeVar = timeVariable;
        }

        private void FillComboBox(List<DashboardHelper> dashboardHelpers)
        {
            cmbVariable.Items.Clear();
            foreach (DashboardHelper dashboardHelper in dashboardHelpers)
            {
                ColumnDataType columnDataType = ColumnDataType.DateTime;
                List<string> dateFields = dashboardHelper.GetFieldsAsList(columnDataType);
                foreach (string dateField in dateFields)
                {
                    if (!cmbVariable.Items.Contains(dateField))
                    {
                        cmbVariable.Items.Add(dateField);
                    }
                }
            }
        }

        private void FillComboBox(Epi.View view)
        {
            cmbVariable.Items.Clear();
            foreach (Epi.Fields.Field f in view.Fields)
            {
                if ((f is Epi.Fields.DateField) || (f is Epi.Fields.DateTimeField) || (f is Epi.Fields.TimeField))
                {
                    cmbVariable.Items.Add(f.Name);
                }
            }
        }
      
        #endregion

        private void cmbVariable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnOK.IsEnabled = (cmbVariable.SelectedIndex != -1);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (Cancelled != null)
            {
                Cancelled(this, new EventArgs());
            }
        }       

        public void Closepopup()
        {
            if (ChangesAccepted != null)
            {
                ChangesAccepted(this, new EventArgs());
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            if (Cancelled != null)
            {
                Cancelled(this, new EventArgs());
            }
        }
    }
}