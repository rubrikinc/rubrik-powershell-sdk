// PolarisReportColumn.cs
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
    #region PolarisReportColumn
    public class PolarisReportColumn: BaseType
    {
        #region members

        //      C# -> System.Int32? ColumnWidth
        // GraphQL -> columnWidth: Int! (scalar)
        [JsonProperty("columnWidth")]
        public System.Int32? ColumnWidth { get; set; }

        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        [JsonProperty("default")]
        public System.Boolean? Default { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        [JsonProperty("sortable")]
        public System.Boolean? Sortable { get; set; }

        //      C# -> System.String? Tooltip
        // GraphQL -> tooltip: String! (scalar)
        [JsonProperty("tooltip")]
        public System.String? Tooltip { get; set; }

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportColumn";
    }

    public PolarisReportColumn Set(
        System.Int32? ColumnWidth = null,
        System.Boolean? Default = null,
        System.String? DisplayName = null,
        System.String? Name = null,
        System.Boolean? Sortable = null,
        System.String? Tooltip = null,
        List<Metadata>? Metadata = null
    ) 
    {
        if ( ColumnWidth != null ) {
            this.ColumnWidth = ColumnWidth;
        }
        if ( Default != null ) {
            this.Default = Default;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Sortable != null ) {
            this.Sortable = Sortable;
        }
        if ( Tooltip != null ) {
            this.Tooltip = Tooltip;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
        //      C# -> System.Int32? ColumnWidth
        // GraphQL -> columnWidth: Int! (scalar)
        if (this.ColumnWidth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "columnWidth\n" ;
            } else {
                s += ind + "columnWidth\n" ;
            }
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (this.Default != null) {
            if (conf.Flat) {
                s += conf.Prefix + "default\n" ;
            } else {
                s += ind + "default\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (this.Sortable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sortable\n" ;
            } else {
                s += ind + "sortable\n" ;
            }
        }
        //      C# -> System.String? Tooltip
        // GraphQL -> tooltip: String! (scalar)
        if (this.Tooltip != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tooltip\n" ;
            } else {
                s += ind + "tooltip\n" ;
            }
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ColumnWidth
        // GraphQL -> columnWidth: Int! (scalar)
        if (ec.Includes("columnWidth",true))
        {
            if(this.ColumnWidth == null) {

                this.ColumnWidth = Int32.MinValue;

            } else {


            }
        }
        else if (this.ColumnWidth != null && ec.Excludes("columnWidth",true))
        {
            this.ColumnWidth = null;
        }
        //      C# -> System.Boolean? Default
        // GraphQL -> default: Boolean! (scalar)
        if (ec.Includes("default",true))
        {
            if(this.Default == null) {

                this.Default = true;

            } else {


            }
        }
        else if (this.Default != null && ec.Excludes("default",true))
        {
            this.Default = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Boolean? Sortable
        // GraphQL -> sortable: Boolean! (scalar)
        if (ec.Includes("sortable",true))
        {
            if(this.Sortable == null) {

                this.Sortable = true;

            } else {


            }
        }
        else if (this.Sortable != null && ec.Excludes("sortable",true))
        {
            this.Sortable = null;
        }
        //      C# -> System.String? Tooltip
        // GraphQL -> tooltip: String! (scalar)
        if (ec.Includes("tooltip",true))
        {
            if(this.Tooltip == null) {

                this.Tooltip = "FETCH";

            } else {


            }
        }
        else if (this.Tooltip != null && ec.Excludes("tooltip",true))
        {
            this.Tooltip = null;
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new List<Metadata>();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
    }


    #endregion

    } // class PolarisReportColumn
    
    #endregion

    public static class ListPolarisReportColumnExtensions
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
            this List<PolarisReportColumn> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolarisReportColumn> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportColumn> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportColumn());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolarisReportColumn> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types