// SnapshotDetails.cs
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
    #region SnapshotDetails
    public class SnapshotDetails: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        [JsonProperty("isOnDemandSnapshot")]
        public System.Boolean? IsOnDemandSnapshot { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotDetails";
    }

    public SnapshotDetails Set(
        System.Boolean? IsOnDemandSnapshot = null,
        DateTime? SnapshotTime = null
    ) 
    {
        if ( IsOnDemandSnapshot != null ) {
            this.IsOnDemandSnapshot = IsOnDemandSnapshot;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot != null) {
            s += ind + "isOnDemandSnapshot\n" ;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsOnDemandSnapshot
        // GraphQL -> isOnDemandSnapshot: Boolean! (scalar)
        if (this.IsOnDemandSnapshot == null && ec.Includes("isOnDemandSnapshot",true))
        {
            this.IsOnDemandSnapshot = true;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime == null && ec.Includes("snapshotTime",true))
        {
            this.SnapshotTime = new DateTime();
        }
    }


    #endregion

    } // class SnapshotDetails
    
    #endregion

    public static class ListSnapshotDetailsExtensions
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
            this List<SnapshotDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SnapshotDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types