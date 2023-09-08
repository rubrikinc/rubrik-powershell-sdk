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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ManagedVolumeStats? AlwaysMounted
        // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
        if (this.AlwaysMounted != null) {
            var fspec = this.AlwaysMounted.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "alwaysMounted {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        if (this.SlaBased != null) {
            var fspec = this.SlaBased.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaBased {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedVolumeStats? AlwaysMounted
        // GraphQL -> alwaysMounted: ManagedVolumeStats! (type)
        if (this.AlwaysMounted == null && ec.Includes("alwaysMounted",false))
        {
            this.AlwaysMounted = new ManagedVolumeStats();
            this.AlwaysMounted.ApplyExploratoryFieldSpec(ec.NewChild("alwaysMounted"));
        }
        //      C# -> ManagedVolumeStats? SlaBased
        // GraphQL -> slaBased: ManagedVolumeStats! (type)
        if (this.SlaBased == null && ec.Includes("slaBased",false))
        {
            this.SlaBased = new ManagedVolumeStats();
            this.SlaBased.ApplyExploratoryFieldSpec(ec.NewChild("slaBased"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<ManagedVolumeInventoryStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types