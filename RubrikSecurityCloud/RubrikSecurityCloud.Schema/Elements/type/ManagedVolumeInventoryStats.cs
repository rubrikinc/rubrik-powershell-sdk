// ManagedVolumeInventoryStats.cs
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
    #region ManagedVolumeInventoryStats
    public class ManagedVolumeInventoryStats: BaseType
    {
        #region members

        //      C# -> ManagedVolumeStats? AlwaysMounted
        // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
        [JsonProperty("alwaysMounted")]
        public ManagedVolumeStats? AlwaysMounted { get; set; }

        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        [JsonProperty("slaBased")]
        public ManagedVolumeStats? SlaBased { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeInventoryStats";
    }

    public ManagedVolumeInventoryStats Set(
        ManagedVolumeStats? AlwaysMounted = null,
        ManagedVolumeStats? SlaBased = null
    ) 
    {
        if ( AlwaysMounted != null ) {
            this.AlwaysMounted = AlwaysMounted;
        }
        if ( SlaBased != null ) {
            this.SlaBased = SlaBased;
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
        //      C# -> ManagedVolumeStats? AlwaysMounted
        // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
        if (this.AlwaysMounted != null) {
            var fspec = this.AlwaysMounted.AsFieldSpec(conf.Child("alwaysMounted"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "alwaysMounted" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        if (this.SlaBased != null) {
            var fspec = this.SlaBased.AsFieldSpec(conf.Child("slaBased"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaBased" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedVolumeStats? AlwaysMounted
        // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
        if (ec.Includes("alwaysMounted",false))
        {
            if(this.AlwaysMounted == null) {

                this.AlwaysMounted = new ManagedVolumeStats();
                this.AlwaysMounted.ApplyExploratoryFieldSpec(ec.NewChild("alwaysMounted"));

            } else {

                this.AlwaysMounted.ApplyExploratoryFieldSpec(ec.NewChild("alwaysMounted"));

            }
        }
        else if (this.AlwaysMounted != null && ec.Excludes("alwaysMounted",false))
        {
            this.AlwaysMounted = null;
        }
        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        if (ec.Includes("slaBased",false))
        {
            if(this.SlaBased == null) {

                this.SlaBased = new ManagedVolumeStats();
                this.SlaBased.ApplyExploratoryFieldSpec(ec.NewChild("slaBased"));

            } else {

                this.SlaBased.ApplyExploratoryFieldSpec(ec.NewChild("slaBased"));

            }
        }
        else if (this.SlaBased != null && ec.Excludes("slaBased",false))
        {
            this.SlaBased = null;
        }
    }


    #endregion

    } // class ManagedVolumeInventoryStats
    
    #endregion

    public static class ListManagedVolumeInventoryStatsExtensions
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
            this List<ManagedVolumeInventoryStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeInventoryStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeInventoryStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeInventoryStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeInventoryStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types