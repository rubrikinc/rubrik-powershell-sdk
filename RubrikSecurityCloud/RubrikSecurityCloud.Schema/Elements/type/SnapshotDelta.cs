// SnapshotDelta.cs
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
    #region SnapshotDelta
    public class SnapshotDelta: BaseType
    {
        #region members

        //      C# -> DeltaType? DeltaType
        // GraphQL -> deltaType: DeltaType! (enum)
        [JsonProperty("deltaType")]
        public DeltaType? DeltaType { get; set; }

        //      C# -> System.Int64? DeltaAmount
        // GraphQL -> deltaAmount: Long! (scalar)
        [JsonProperty("deltaAmount")]
        public System.Int64? DeltaAmount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotDelta";
    }

    public SnapshotDelta Set(
        DeltaType? DeltaType = null,
        System.Int64? DeltaAmount = null
    ) 
    {
        if ( DeltaType != null ) {
            this.DeltaType = DeltaType;
        }
        if ( DeltaAmount != null ) {
            this.DeltaAmount = DeltaAmount;
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
        //      C# -> DeltaType? DeltaType
        // GraphQL -> deltaType: DeltaType! (enum)
        if (this.DeltaType != null) {
            s += ind + "deltaType\n" ;
        }
        //      C# -> System.Int64? DeltaAmount
        // GraphQL -> deltaAmount: Long! (scalar)
        if (this.DeltaAmount != null) {
            s += ind + "deltaAmount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DeltaType? DeltaType
        // GraphQL -> deltaType: DeltaType! (enum)
        if (this.DeltaType == null && Exploration.Includes(parent + ".deltaType", true))
        {
            this.DeltaType = new DeltaType();
        }
        //      C# -> System.Int64? DeltaAmount
        // GraphQL -> deltaAmount: Long! (scalar)
        if (this.DeltaAmount == null && Exploration.Includes(parent + ".deltaAmount", true))
        {
            this.DeltaAmount = new System.Int64();
        }
    }


    #endregion

    } // class SnapshotDelta
    
    #endregion

    public static class ListSnapshotDeltaExtensions
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
            this List<SnapshotDelta> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotDelta> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotDelta());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types