﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epi;
using Epi.Fields;

namespace EpiDashboard
{
    public class DuplicatesListParameters : GadgetParametersBase
    {
        public bool SortColumnsByTabOrder { get; set; }
        public bool UsePromptsForColumnNames { get; set; }
        public bool ShowColumnHeadings { get; set; }
        public bool ShowLineColumn { get; set; }
        public bool ShowNullLabels { get; set; }
        public string PrimaryGroupField { get; set; }
        public string SecondaryGroupField { get; set; }

        /// <summary>
        /// Gets/sets the names of the columns used for custom sorting
        /// </summary>
        public List<string> CustomUserColumnSort { get; set; }
        public List<string> KeyColumnNames { get; set; }
        
        public DuplicatesListParameters()
            : base()
        {
            SortColumnsByTabOrder = false;
            UsePromptsForColumnNames = false;
            ShowColumnHeadings = true;
            ShowLineColumn = true;
            ShowNullLabels = true;
            PrimaryGroupField = String.Empty;
            SecondaryGroupField = String.Empty;
            GadgetTitle = "Duplicates List";
            CustomUserColumnSort = new List<string>();
            KeyColumnNames = new List<string>();
        }
    }
}
