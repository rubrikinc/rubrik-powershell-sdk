// RecoveryInfo.cs
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
    #region RecoveryInfo
    public class RecoveryInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? RecoveryCount
        // GraphQL -> recoveryCount: Int! (scalar)
        [JsonProperty("recoveryCount")]
        public System.Int32? RecoveryCount { get; set; }

        //      C# -> List<System.String>? RecoveryIds
        // GraphQL -> recoveryIds: [String!]! (scalar)
        [JsonProperty("recoveryIds")]
        public List<System.String>? RecoveryIds { get; set; }

        //      C# -> System.String? RecoveryType
        // GraphQL -> recoveryType: String! (scalar)
        [JsonProperty("recoveryType")]
        public System.String? RecoveryType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryInfo";
    }

    public RecoveryInfo Set(
        System.Int32? RecoveryCount = null,
        List<System.String>? RecoveryIds = null,
        System.String? RecoveryType = null
    ) 
    {
        if ( RecoveryCount != null ) {
            this.RecoveryCount = RecoveryCount;
        }
        if ( RecoveryIds != null ) {
            this.RecoveryIds = RecoveryIds;
        }
        if ( RecoveryType != null ) {
            this.RecoveryType = RecoveryType;
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
        //      C# -> System.Int32? RecoveryCount
        // GraphQL -> recoveryCount: Int! (scalar)
        if (this.RecoveryCount != null) {
            s += ind + "recoveryCount\n" ;
        }
        //      C# -> List<System.String>? RecoveryIds
        // GraphQL -> recoveryIds: [String!]! (scalar)
        if (this.RecoveryIds != null) {
            s += ind + "recoveryIds\n" ;
        }
        //      C# -> System.String? RecoveryType
        // GraphQL -> recoveryType: String! (scalar)
        if (this.RecoveryType != null) {
            s += ind + "recoveryType\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? RecoveryCount
        // GraphQL -> recoveryCount: Int! (scalar)
        if (this.RecoveryCount == null && ec.Includes("recoveryCount",true))
        {
            this.RecoveryCount = Int32.MinValue;
        }
        //      C# -> List<System.String>? RecoveryIds
        // GraphQL -> recoveryIds: [String!]! (scalar)
        if (this.RecoveryIds == null && ec.Includes("recoveryIds",true))
        {
            this.RecoveryIds = new List<System.String>();
        }
        //      C# -> System.String? RecoveryType
        // GraphQL -> recoveryType: String! (scalar)
        if (this.RecoveryType == null && ec.Includes("recoveryType",true))
        {
            this.RecoveryType = "FETCH";
        }
    }


    #endregion

    } // class RecoveryInfo
    
    #endregion

    public static class ListRecoveryInfoExtensions
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
            this List<RecoveryInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<RecoveryInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types