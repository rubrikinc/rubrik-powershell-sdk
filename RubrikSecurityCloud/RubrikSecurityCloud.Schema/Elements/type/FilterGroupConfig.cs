// FilterGroupConfig.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region FilterGroupConfig
 
    public class FilterGroupConfig: BaseType, NestedFilterConfig
    {
        #region members

        //      C# -> LogicalOperator? LogicalOperator
        // GraphQL -> logicalOperator: LogicalOperator! (enum)
        [JsonProperty("logicalOperator")]
        public LogicalOperator? LogicalOperator { get; set; }

        //      C# -> List<PolicyFilter>? FiltersList
        // GraphQL -> filtersList: [PolicyFilter!]! (type)
        [JsonProperty("filtersList")]
        public List<PolicyFilter>? FiltersList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilterGroupConfig";
    }

    public FilterGroupConfig Set(
        LogicalOperator? LogicalOperator = null,
        List<PolicyFilter>? FiltersList = null
    ) 
    {
        if ( LogicalOperator != null ) {
            this.LogicalOperator = LogicalOperator;
        }
        if ( FiltersList != null ) {
            this.FiltersList = FiltersList;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> LogicalOperator? LogicalOperator
        // GraphQL -> logicalOperator: LogicalOperator! (enum)
        if (this.LogicalOperator != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalOperator\n" ;
            } else {
                s += ind + "logicalOperator\n" ;
            }
        }
        //      C# -> List<PolicyFilter>? FiltersList
        // GraphQL -> filtersList: [PolicyFilter!]! (type)
        if (this.FiltersList != null) {
            var fspec = this.FiltersList.AsFieldSpec(conf.Child("filtersList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filtersList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> LogicalOperator? LogicalOperator
        // GraphQL -> logicalOperator: LogicalOperator! (enum)
        if (ec.Includes("logicalOperator",true))
        {
            if(this.LogicalOperator == null) {

                this.LogicalOperator = new LogicalOperator();

            } else {


            }
        }
        else if (this.LogicalOperator != null && ec.Excludes("logicalOperator",true))
        {
            this.LogicalOperator = null;
        }
        //      C# -> List<PolicyFilter>? FiltersList
        // GraphQL -> filtersList: [PolicyFilter!]! (type)
        if (ec.Includes("filtersList",false))
        {
            if(this.FiltersList == null) {

                this.FiltersList = new List<PolicyFilter>();
                this.FiltersList.ApplyExploratoryFieldSpec(ec.NewChild("filtersList"));

            } else {

                this.FiltersList.ApplyExploratoryFieldSpec(ec.NewChild("filtersList"));

            }
        }
        else if (this.FiltersList != null && ec.Excludes("filtersList",false))
        {
            this.FiltersList = null;
        }
    }


    #endregion

    } // class FilterGroupConfig
    
    #endregion

    public static class ListFilterGroupConfigExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<FilterGroupConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilterGroupConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilterGroupConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilterGroupConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilterGroupConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types