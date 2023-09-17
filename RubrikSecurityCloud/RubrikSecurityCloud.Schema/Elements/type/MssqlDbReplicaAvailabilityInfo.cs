// MssqlDbReplicaAvailabilityInfo.cs
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
    #region MssqlDbReplicaAvailabilityInfo
    public class MssqlDbReplicaAvailabilityInfo: BaseType
    {
        #region members

        //      C# -> MssqlDbReplicaAvailabilityInfoRole? Role
        // GraphQL -> role: MssqlDbReplicaAvailabilityInfoRole! (enum)
        [JsonProperty("role")]
        public MssqlDbReplicaAvailabilityInfoRole? Role { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDbReplicaAvailabilityInfo";
    }

    public MssqlDbReplicaAvailabilityInfo Set(
        MssqlDbReplicaAvailabilityInfoRole? Role = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
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
        //      C# -> MssqlDbReplicaAvailabilityInfoRole? Role
        // GraphQL -> role: MssqlDbReplicaAvailabilityInfoRole! (enum)
        if (this.Role != null) {
            s += ind + "role\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlDbReplicaAvailabilityInfoRole? Role
        // GraphQL -> role: MssqlDbReplicaAvailabilityInfoRole! (enum)
        if (this.Role == null && ec.Includes("role",true))
        {
            this.Role = new MssqlDbReplicaAvailabilityInfoRole();
        }
    }


    #endregion

    } // class MssqlDbReplicaAvailabilityInfo
    
    #endregion

    public static class ListMssqlDbReplicaAvailabilityInfoExtensions
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
            this List<MssqlDbReplicaAvailabilityInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbReplicaAvailabilityInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbReplicaAvailabilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDbReplicaAvailabilityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types