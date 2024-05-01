// CascadingArchivalSpec.cs
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
    #region CascadingArchivalSpec
    public class CascadingArchivalSpec: BaseType
    {
        #region members

        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        [JsonProperty("frequency")]
        public List<RetentionUnit>? Frequency { get; set; }

        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        [JsonProperty("archivalLocation")]
        public RscInterface<Target> ArchivalLocation { get; set; }

        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        [JsonProperty("archivalThreshold")]
        public Duration? ArchivalThreshold { get; set; }

        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        [JsonProperty("archivalTieringSpec")]
        public ArchivalTieringSpec? ArchivalTieringSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CascadingArchivalSpec";
    }

    public CascadingArchivalSpec Set(
        List<RetentionUnit>? Frequency = null,
        RscInterface<Target> ArchivalLocation = null,
        Duration? ArchivalThreshold = null,
        ArchivalTieringSpec? ArchivalTieringSpec = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( ArchivalLocation != null ) {
            this.ArchivalLocation = ArchivalLocation;
        }
        if ( ArchivalThreshold != null ) {
            this.ArchivalThreshold = ArchivalThreshold;
        }
        if ( ArchivalTieringSpec != null ) {
            this.ArchivalTieringSpec = ArchivalTieringSpec;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        if (this.Frequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequency\n" ;
            } else {
                s += ind + "frequency\n" ;
            }
        }
        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        if (this.ArchivalLocation != null) {
            var fspec = this.ArchivalLocation.AsFieldSpec(conf.Child("archivalLocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalLocation" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        if (this.ArchivalThreshold != null) {
            var fspec = this.ArchivalThreshold.AsFieldSpec(conf.Child("archivalThreshold"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalThreshold" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (this.ArchivalTieringSpec != null) {
            var fspec = this.ArchivalTieringSpec.AsFieldSpec(conf.Child("archivalTieringSpec"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archivalTieringSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RetentionUnit>? Frequency
        // GraphQL -> frequency: [RetentionUnit!]! (enum)
        if (ec.Includes("frequency",true))
        {
            if(this.Frequency == null) {

                this.Frequency = new List<RetentionUnit>();

            } else {


            }
        }
        else if (this.Frequency != null && ec.Excludes("frequency",true))
        {
            this.Frequency = null;
        }
        //      C# -> Target? ArchivalLocation
        // GraphQL -> archivalLocation: Target (interface)
        if (ec.Includes("archivalLocation",false))
        {
            if(this.ArchivalLocation == null) {

                this.ArchivalLocation = new RscInterface<Target>();
                this.ArchivalLocation.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocation"));

            } else {

                this.ArchivalLocation.ApplyExploratoryFieldSpec(ec.NewChild("archivalLocation"));

            }
        }
        else if (this.ArchivalLocation != null && ec.Excludes("archivalLocation",false))
        {
            this.ArchivalLocation = null;
        }
        //      C# -> Duration? ArchivalThreshold
        // GraphQL -> archivalThreshold: Duration (type)
        if (ec.Includes("archivalThreshold",false))
        {
            if(this.ArchivalThreshold == null) {

                this.ArchivalThreshold = new Duration();
                this.ArchivalThreshold.ApplyExploratoryFieldSpec(ec.NewChild("archivalThreshold"));

            } else {

                this.ArchivalThreshold.ApplyExploratoryFieldSpec(ec.NewChild("archivalThreshold"));

            }
        }
        else if (this.ArchivalThreshold != null && ec.Excludes("archivalThreshold",false))
        {
            this.ArchivalThreshold = null;
        }
        //      C# -> ArchivalTieringSpec? ArchivalTieringSpec
        // GraphQL -> archivalTieringSpec: ArchivalTieringSpec (type)
        if (ec.Includes("archivalTieringSpec",false))
        {
            if(this.ArchivalTieringSpec == null) {

                this.ArchivalTieringSpec = new ArchivalTieringSpec();
                this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalTieringSpec"));

            } else {

                this.ArchivalTieringSpec.ApplyExploratoryFieldSpec(ec.NewChild("archivalTieringSpec"));

            }
        }
        else if (this.ArchivalTieringSpec != null && ec.Excludes("archivalTieringSpec",false))
        {
            this.ArchivalTieringSpec = null;
        }
    }


    #endregion

    } // class CascadingArchivalSpec
    
    #endregion

    public static class ListCascadingArchivalSpecExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CascadingArchivalSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CascadingArchivalSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CascadingArchivalSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CascadingArchivalSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CascadingArchivalSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types