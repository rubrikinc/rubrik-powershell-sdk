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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "alwaysMounted {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        if (this.SlaBased != null) {
            var fspec = this.SlaBased.AsFieldSpec(conf.Child("slaBased"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaBased {\n" + fspec + ind + "}\n" ;
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
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ManagedVolumeInventoryStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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