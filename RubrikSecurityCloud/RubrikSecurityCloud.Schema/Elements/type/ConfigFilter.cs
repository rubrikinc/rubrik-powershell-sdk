// ConfigFilter.cs
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
    #region ConfigFilter
    public class ConfigFilter: BaseType
    {
        #region members

        //      C# -> List<System.String>? FilterHeader
        // GraphQL -> filterHeader: [String!]! (scalar)
        [JsonProperty("filterHeader")]
        public List<System.String>? FilterHeader { get; set; }

        //      C# -> ReportFilter? Filter
        // GraphQL -> filter: ReportFilter! (type)
        [JsonProperty("filter")]
        public ReportFilter? Filter { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigFilter";
    }

    public ConfigFilter Set(
        List<System.String>? FilterHeader = null,
        ReportFilter? Filter = null
    ) 
    {
        if ( FilterHeader != null ) {
            this.FilterHeader = FilterHeader;
        }
        if ( Filter != null ) {
            this.Filter = Filter;
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
        //      C# -> List<System.String>? FilterHeader
        // GraphQL -> filterHeader: [String!]! (scalar)
        if (this.FilterHeader != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filterHeader\n" ;
            } else {
                s += ind + "filterHeader\n" ;
            }
        }
        //      C# -> ReportFilter? Filter
        // GraphQL -> filter: ReportFilter! (type)
        if (this.Filter != null) {
            var fspec = this.Filter.AsFieldSpec(conf.Child("filter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? FilterHeader
        // GraphQL -> filterHeader: [String!]! (scalar)
        if (ec.Includes("filterHeader",true))
        {
            if(this.FilterHeader == null) {

                this.FilterHeader = new List<System.String>();

            } else {


            }
        }
        else if (this.FilterHeader != null && ec.Excludes("filterHeader",true))
        {
            this.FilterHeader = null;
        }
        //      C# -> ReportFilter? Filter
        // GraphQL -> filter: ReportFilter! (type)
        if (ec.Includes("filter",false))
        {
            if(this.Filter == null) {

                this.Filter = new ReportFilter();
                this.Filter.ApplyExploratoryFieldSpec(ec.NewChild("filter"));

            } else {

                this.Filter.ApplyExploratoryFieldSpec(ec.NewChild("filter"));

            }
        }
        else if (this.Filter != null && ec.Excludes("filter",false))
        {
            this.Filter = null;
        }
    }


    #endregion

    } // class ConfigFilter
    
    #endregion

    public static class ListConfigFilterExtensions
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
            this List<ConfigFilter> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigFilter> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigFilter> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigFilter());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigFilter> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types