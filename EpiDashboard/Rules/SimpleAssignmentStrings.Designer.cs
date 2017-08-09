﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpiDashboard.Rules {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SimpleAssignmentStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SimpleAssignmentStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EpiDashboard.Rules.SimpleAssignmentStrings", typeof(SimpleAssignmentStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Date/Time
        ///    
        ///Adds the specified number of whole days to a given date field. The assigned value will also be a date..
        /// </summary>
        internal static string ADD_DAYS_DESCRIPTION {
            get {
                return ResourceManager.GetString("ADD_DAYS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the mean (average) of all numeric fields in a group. If a group has four number fields with values 2, 8, and 10, and 16, the resulting assign value will be 9. Missing values in the group are not ignored and will result in an unknown mean. Can optionally be set to include Yes/No fields and Comment Legal fields that are within the group. A &apos;Yes&apos; in a Yes/No field will count as a 1 and a &apos;No&apos; will count as a 0. Comment Legal fields will be converted from text to their numeri [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AVERAGE_NUMERIC_FIELDS_DESCRIPTION {
            get {
                return ResourceManager.GetString("AVERAGE_NUMERIC_FIELDS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Counts the number of checked checkboxes in a group. Any Yes/No fields in the group will be ignored. If the group is user-defined and includes boolean columns that are not part of an Epi Info 7 project, those boolean columns will be included..
        /// </summary>
        internal static string COUNT_CHECKED_CHECKBOXES_DESCRIPTION {
            get {
                return ResourceManager.GetString("COUNT_CHECKED_CHECKBOXES_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Counts the number of fields in a group that have been left blank or contain NULL values in the database. If the group does not contain any fields then the assigned value will be a 0..
        /// </summary>
        internal static string COUNT_MISSING_DESCRIPTION {
            get {
                return ResourceManager.GetString("COUNT_MISSING_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Counts the number of fields in a group that have not been left blank and do not contain NULL values in the database. If the group does not contain any fields then the assigned value will be a 0..
        /// </summary>
        internal static string COUNT_NOT_MISSING_DESCRIPTION {
            get {
                return ResourceManager.GetString("COUNT_NOT_MISSING_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the number of numeric fields in a group that have values between (inclusive) the specified upper and lower boundaries. Any Yes/No fields in the group will be ignored..
        /// </summary>
        internal static string COUNT_NUMERIC_BETWEEN_X_Y_DESCRIPTION {
            get {
                return ResourceManager.GetString("COUNT_NUMERIC_BETWEEN_X_Y_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the number of numeric fields in a group that have values outside the specified upper and lower boundaries. Any Yes/No fields in the group will be ignored..
        /// </summary>
        internal static string COUNT_NUMERIC_OUTSIDE_X_Y_DESCRIPTION {
            get {
                return ResourceManager.GetString("COUNT_NUMERIC_OUTSIDE_X_Y_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Counts the number of Yes-marked Yes/No fields in a group. Any checkbox fields or other boolean columns in the group will be ignored..
        /// </summary>
        internal static string COUNT_YES_YESNOFIELDS_DESCRIPTION {
            get {
                return ResourceManager.GetString("COUNT_YES_YESNOFIELDS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Day (Numeric):.
        /// </summary>
        internal static string DAY_NUMERIC {
            get {
                return ResourceManager.GetString("DAY_NUMERIC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the difference in days between two dates. Only complete days are assigned. If the actual difference is 7.8, the assigned value will be a 7. The starting date should be the the earlier of the two dates, otherwise negative values will be assigned..
        /// </summary>
        internal static string DAYS_DESCRIPTION {
            get {
                return ResourceManager.GetString("DAYS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Boolean
        ///    
        ///Determines if the value in a given drop-down list field (Legal values, Comment legal) is present in the corresponding code table. Such a scenario may occur if the list values were modified after data entry had started, or after data merging. The assigned value will be a &apos;Yes&apos; if the value is present and a &apos;No&apos; if the value is not present. Missing values are always considered &apos;not present&apos; in the code table..
        /// </summary>
        internal static string DDL_CHECK_DESCRIPTION {
            get {
                return ResourceManager.GetString("DDL_CHECK_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Boolean
        ///    
        ///Determine if more than the specified number of checkboxes are checked in a group. A &apos;Yes&apos; will be returned if the condition is met. Any Yes/No fields in the group will be ignored. If the group is user-defined and includes boolean columns that are not part of an Epi Info 7 project, those boolean columns will be included..
        /// </summary>
        internal static string DETERMINE_IF_N_CHECKBOXES_CHECKED_DESCRIPTION {
            get {
                return ResourceManager.GetString("DETERMINE_IF_N_CHECKBOXES_CHECKED_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Boolean
        ///    
        ///Determines if more than the specified number of fields within a group contain missing values. A &apos;Yes&apos; will be returned if the condition is met..
        /// </summary>
        internal static string DETERMINE_IF_N_MISSING_DESCRIPTION {
            get {
                return ResourceManager.GetString("DETERMINE_IF_N_MISSING_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Boolean
        ///    
        ///Determine if more than the specified number of Yes/No fields are marked Yes in a group. A &apos;Yes&apos; will be returned if the condition is met. Any checkbox fields or other boolean columns in the group are ignored..
        /// </summary>
        internal static string DETERMINE_IF_N_YESNOFIELDS_DESCRIPTION {
            get {
                return ResourceManager.GetString("DETERMINE_IF_N_YESNOFIELDS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination field is blank..
        /// </summary>
        internal static string ERROR_DESTINATION_FIELD_MISSING {
            get {
                return ResourceManager.GetString("ERROR_DESTINATION_FIELD_MISSING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination field name already exists as a column in this data set. Please use another name..
        /// </summary>
        internal static string ERROR_FIELD_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("ERROR_FIELD_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination field name already exists as a defined field with recoded values. Please use another field name..
        /// </summary>
        internal static string ERROR_FIELD_ALREADY_EXISTS_WITH_RECODED_DATA {
            get {
                return ResourceManager.GetString("ERROR_FIELD_ALREADY_EXISTS_WITH_RECODED_DATA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more required parameters are blank..
        /// </summary>
        internal static string ERROR_PARAMS_BLANK {
            get {
                return ResourceManager.GetString("ERROR_PARAMS_BLANK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assignment type is blank..
        /// </summary>
        internal static string ERROR_TYPE_MISSING {
            get {
                return ResourceManager.GetString("ERROR_TYPE_MISSING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the starting position of a given character. A -1 is returned if the character was not found..
        /// </summary>
        internal static string FINDTEXT_DESCRIPTION {
            get {
                return ResourceManager.GetString("FINDTEXT_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the difference in hours between two dates or date/times. Only complete hours are assigned. If the actual difference is 7.8, the assigned value will be a 7. The starting date/time should be the the earlier of the two date/times, otherwise negative values will be assigned..
        /// </summary>
        internal static string HOURS_DESCRIPTION {
            get {
                return ResourceManager.GetString("HOURS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Text
        ///    
        ///Converts all characters in the given text field to lower case..
        /// </summary>
        internal static string LOWERCASE_DESCRIPTION {
            get {
                return ResourceManager.GetString("LOWERCASE_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the maximum value of all non-missing numeric fields in a group. If a group has four number fields with values -12, 8, and 10, and 24, the resulting assign value will be 24. Missing values in the group are ignored. Any Yes/No fields in the group will be ignored..
        /// </summary>
        internal static string MAX_NUMERIC_FIELDS_DESCRIPTION {
            get {
                return ResourceManager.GetString("MAX_NUMERIC_FIELDS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the minimum value of all non-missing numeric fields in a group. If a group has four number fields with values -12, -8, and 10, and 17, the resulting assign value will be -12. Missing values in the group are ignored. Any Yes/No fields in the group will be ignored..
        /// </summary>
        internal static string MIN_NUMERIC_FIELDS_DESCRIPTION {
            get {
                return ResourceManager.GetString("MIN_NUMERIC_FIELDS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the difference in minutes between two dates or date/times. Only complete minutes are assigned. If the actual difference is 23.8, the assigned value will be a 23. The starting date/time should be the the earlier of the two date/times, otherwise negative values will be assigned..
        /// </summary>
        internal static string MINUTES_DESCRIPTION {
            get {
                return ResourceManager.GetString("MINUTES_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Month (Numeric):.
        /// </summary>
        internal static string MONTH_NUMERIC {
            get {
                return ResourceManager.GetString("MONTH_NUMERIC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the difference in months between two dates. Only complete months are assigned. If the actual difference is 7.8, the assigned value will be a 7. The starting date should be the the earlier of the two dates, otherwise negative values will be assigned..
        /// </summary>
        internal static string MONTHS_DESCRIPTION {
            get {
                return ResourceManager.GetString("MONTHS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Date
        ///
        ///This function transforms three numbers into a date format. Useful if date are stored in a text column and operations need to be carried out on the data.
        /// </summary>
        internal static string NUMBER_TO_DATE_DESCRIPTION {
            get {
                return ResourceManager.GetString("NUMBER_TO_DATE_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Text
        ///    
        ///Attempts to convert data stored as a number into text..
        /// </summary>
        internal static string NUMBER_TO_TEXT_DESCRIPTION {
            get {
                return ResourceManager.GetString("NUMBER_TO_TEXT_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination field already exists. Do you want to overwrite the data in this field?.
        /// </summary>
        internal static string OVERWRITE_FIELD_DATA {
            get {
                return ResourceManager.GetString("OVERWRITE_FIELD_DATA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Count:.
        /// </summary>
        internal static string PARAM_COUNT {
            get {
                return ResourceManager.GetString("PARAM_COUNT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Date field:.
        /// </summary>
        internal static string PARAM_DATE_FIELD {
            get {
                return ResourceManager.GetString("PARAM_DATE_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Days to add (whole days only):.
        /// </summary>
        internal static string PARAM_DAYS_TO_ADD {
            get {
                return ResourceManager.GetString("PARAM_DAYS_TO_ADD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drop-down list field:.
        /// </summary>
        internal static string PARAM_DDL_FIELD {
            get {
                return ResourceManager.GetString("PARAM_DDL_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End date:.
        /// </summary>
        internal static string PARAM_END_DATE {
            get {
                return ResourceManager.GetString("PARAM_END_DATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Position of the first character to extract:.
        /// </summary>
        internal static string PARAM_FIRST_CHARACTER {
            get {
                return ResourceManager.GetString("PARAM_FIRST_CHARACTER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group field:.
        /// </summary>
        internal static string PARAM_GROUP_FIELD {
            get {
                return ResourceManager.GetString("PARAM_GROUP_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include Comment Legal fields:.
        /// </summary>
        internal static string PARAM_INCLUDE_COMMENTLEGAL {
            get {
                return ResourceManager.GetString("PARAM_INCLUDE_COMMENTLEGAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include Yes/No fields:.
        /// </summary>
        internal static string PARAM_INCLUDE_YESNO {
            get {
                return ResourceManager.GetString("PARAM_INCLUDE_YESNO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lower bound:.
        /// </summary>
        internal static string PARAM_LOWER_BOUND {
            get {
                return ResourceManager.GetString("PARAM_LOWER_BOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number field:.
        /// </summary>
        internal static string PARAM_NUMBER_FIELD {
            get {
                return ResourceManager.GetString("PARAM_NUMBER_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of characters to extract:.
        /// </summary>
        internal static string PARAM_NUMBER_OF_CHARACTERS {
            get {
                return ResourceManager.GetString("PARAM_NUMBER_OF_CHARACTERS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The numeric field to round:.
        /// </summary>
        internal static string PARAM_NUMERIC_FIELD_TO_ROUND {
            get {
                return ResourceManager.GetString("PARAM_NUMERIC_FIELD_TO_ROUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To number of decimal places to round to:.
        /// </summary>
        internal static string PARAM_ROUND_TO {
            get {
                return ResourceManager.GetString("PARAM_ROUND_TO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start date:.
        /// </summary>
        internal static string PARAM_START_DATE {
            get {
                return ResourceManager.GetString("PARAM_START_DATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text field:.
        /// </summary>
        internal static string PARAM_TEXT_FIELD {
            get {
                return ResourceManager.GetString("PARAM_TEXT_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text field to search:.
        /// </summary>
        internal static string PARAM_TEXT_FIELD_TO_SEARCH {
            get {
                return ResourceManager.GetString("PARAM_TEXT_FIELD_TO_SEARCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The text string to search for:.
        /// </summary>
        internal static string PARAM_TEXT_TO_SEARCH_FOR {
            get {
                return ResourceManager.GetString("PARAM_TEXT_TO_SEARCH_FOR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upper bound:.
        /// </summary>
        internal static string PARAM_UPPER_BOUND {
            get {
                return ResourceManager.GetString("PARAM_UPPER_BOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Rounds a number to the given decimal place. If the number value is 8.3333333 and the decimal value is 2, then the result will be 8.33. A decimal value of 0 will force rounding to the nearest whole number..
        /// </summary>
        internal static string ROUND_DESCRIPTION {
            get {
                return ResourceManager.GetString("ROUND_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Date/Time
        ///    
        ///Keeps the DATE component of a DATE TIME value in tact while making the TIME component 0. Same effect as a FLOOR(datetime) function. The assigned value will also be a date..
        /// </summary>
        internal static string STRIP_DATE_DESCRIPTION {
            get {
                return ResourceManager.GetString("STRIP_DATE_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the length (in characters) of data in the specified text field. A text value of &apos;Jane&apos; would result in an assign value of 4. A text value of &apos;No data available&apos; would result in an assign value of 17..
        /// </summary>
        internal static string STRLEN_DESCRIPTION {
            get {
                return ResourceManager.GetString("STRLEN_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Text
        ///    
        ///Used to assign a field a portion of another field&apos;s text data. Useful for pulling out certain pieces of text from another field..
        /// </summary>
        internal static string SUBSTRING_DESCRIPTION {
            get {
                return ResourceManager.GetString("SUBSTRING_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the sum of all numeric fields in a group. If a group has four number fields with values 2, 8, and 10, and 16, the resulting assign value will be 36. Missing values in the group are not ignored and will result in an unknown sum. Can optionally be set to include Yes/No fields and Comment Legal fields that are within the group. A &apos;Yes&apos; in a Yes/No field will count as a 1 and a &apos;No&apos; will count as a 0. Comment Legal fields will be converted from text to their numeric equivalen [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SUM_NUMERIC_FIELDS_DESCRIPTION {
            get {
                return ResourceManager.GetString("SUM_NUMERIC_FIELDS_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Date
        ///Attempts to convert data stored as text into date data. Useful if date are stored in a text column and operations need to be carried out on the data. Cannot convert alpha-numeric data, e.g. &quot;A16&quot; could not be converted..
        /// </summary>
        internal static string TEXT_TO_DATE_DESCRIPTION {
            get {
                return ResourceManager.GetString("TEXT_TO_DATE_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Attempts to convert data stored as text into numeric data. Useful if numbers are stored in a text column and math operations need to be carried out on the data. Cannot convert alpha-numeric data, e.g. &quot;A16&quot; could not be converted..
        /// </summary>
        internal static string TEXT_TO_NUMBER_DESCRIPTION {
            get {
                return ResourceManager.GetString("TEXT_TO_NUMBER_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Text
        ///    
        ///Converts all characters in the given text field to upper case..
        /// </summary>
        internal static string UPPERCASE_DESCRIPTION {
            get {
                return ResourceManager.GetString("UPPERCASE_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Year (Numeric):.
        /// </summary>
        internal static string YEAR_NUMERIC {
            get {
                return ResourceManager.GetString("YEAR_NUMERIC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable type: Numeric
        ///    
        ///Finds the difference in years between two dates. Only complete years are assigned. If the actual difference in years is 7.8, the assigned value will be a 7. The starting date should be the the earlier of the two dates, otherwise negative values will be assigned..
        /// </summary>
        internal static string YEARS_DESCRIPTION {
            get {
                return ResourceManager.GetString("YEARS_DESCRIPTION", resourceCulture);
            }
        }
    }
}
