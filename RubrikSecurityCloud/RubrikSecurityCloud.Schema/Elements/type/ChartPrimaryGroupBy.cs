// ChartPrimaryGroupBy.cs
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
    #region ChartPrimaryGroupBy
    public class ChartPrimaryGroupBy: BaseType
    {
        #region members

        //      C# -> DisplayableValue? Name
        // GraphQL -> name: DisplayableValue (interface)
        [JsonProperty("name")]
        public DisplayableValue? Name { get; set; }

        //      C# -> DisplayableValue? Value
        // GraphQL -> value: DisplayableValue (interface)
        [JsonProperty("value")]
        public DisplayableValue? Value { get; set; }

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }

        //      C# -> List<ChartSecondaryGroupBy>? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: [ChartSecondaryGroupBy!]! (type)
        [JsonProperty("secondaryGroupBy")]
        public List<ChartSecondaryGroupBy>? SecondaryGroupBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChartPrimaryGroupBy";
    }

    public ChartPrimaryGroupBy Set(
        DisplayableValue? Name = null,
        DisplayableValue? Value = null,
        List<Metadata>? Metadata = null,
        List<ChartSecondaryGroupBy>? SecondaryGroupBy = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( SecondaryGroupBy != null ) {
            this.SecondaryGroupBy = SecondaryGroupBy;
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
        //      C# -> DisplayableValue? Name
        // GraphQL -> name: DisplayableValue (interface)
        if (this.Name != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Name, conf.Child("name"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "name" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> DisplayableValue? Value
        // GraphQL -> value: DisplayableValue (interface)
        if (this.Value != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Value, conf.Child("value"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "value" + " " + "{\n" + fspec + ind + "}\n";
                }
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
        //      C# -> List<ChartSecondaryGroupBy>? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: [ChartSecondaryGroupBy!]! (type)
        if (this.SecondaryGroupBy != null) {
            var fspec = this.SecondaryGroupBy.AsFieldSpec(conf.Child("secondaryGroupBy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secondaryGroupBy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DisplayableValue? Name
        // GraphQL -> name: DisplayableValue (interface)
        if (ec.Includes("name",false))
        {
            if(this.Name == null) {

                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("name"));
                this.Name = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("name"));
                this.Name = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Name != null && ec.Excludes("name",false))
        {
            this.Name = null;
        }
        //      C# -> DisplayableValue? Value
        // GraphQL -> value: DisplayableValue (interface)
        if (ec.Includes("value",false))
        {
            if(this.Value == null) {

                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("value"));
                this.Value = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("value"));
                this.Value = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Value != null && ec.Excludes("value",false))
        {
            this.Value = null;
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
        //      C# -> List<ChartSecondaryGroupBy>? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: [ChartSecondaryGroupBy!]! (type)
        if (ec.Includes("secondaryGroupBy",false))
        {
            if(this.SecondaryGroupBy == null) {

                this.SecondaryGroupBy = new List<ChartSecondaryGroupBy>();
                this.SecondaryGroupBy.ApplyExploratoryFieldSpec(ec.NewChild("secondaryGroupBy"));

            } else {

                this.SecondaryGroupBy.ApplyExploratoryFieldSpec(ec.NewChild("secondaryGroupBy"));

            }
        }
        else if (this.SecondaryGroupBy != null && ec.Excludes("secondaryGroupBy",false))
        {
            this.SecondaryGroupBy = null;
        }
    }


    #endregion

    } // class ChartPrimaryGroupBy
    
    #endregion

    public static class ListChartPrimaryGroupByExtensions
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
            this List<ChartPrimaryGroupBy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ChartPrimaryGroupBy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ChartPrimaryGroupBy> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartPrimaryGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ChartPrimaryGroupBy> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types