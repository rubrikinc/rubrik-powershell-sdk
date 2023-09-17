// CdmMssqlDbReplicaAvailabilityInfo.cs
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
    #region CdmMssqlDbReplicaAvailabilityInfo
    public class CdmMssqlDbReplicaAvailabilityInfo: BaseType
    {
        #region members

        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        [JsonProperty("availabilityMode")]
        public System.String? AvailabilityMode { get; set; }

        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        [JsonProperty("replicaId")]
        public System.String? ReplicaId { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMssqlDbReplicaAvailabilityInfo";
    }

    public CdmMssqlDbReplicaAvailabilityInfo Set(
        System.String? AvailabilityMode = null,
        System.String? ReplicaId = null,
        System.String? Role = null
    ) 
    {
        if ( AvailabilityMode != null ) {
            this.AvailabilityMode = AvailabilityMode;
        }
        if ( ReplicaId != null ) {
            this.ReplicaId = ReplicaId;
        }
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
        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        if (this.AvailabilityMode != null) {
            s += ind + "availabilityMode\n" ;
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (this.ReplicaId != null) {
            s += ind + "replicaId\n" ;
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role != null) {
            s += ind + "role\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AvailabilityMode
        // GraphQL -> availabilityMode: String! (scalar)
        if (this.AvailabilityMode == null && ec.Includes("availabilityMode",true))
        {
            this.AvailabilityMode = "FETCH";
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (this.ReplicaId == null && ec.Includes("replicaId",true))
        {
            this.ReplicaId = "FETCH";
        }
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        if (this.Role == null && ec.Includes("role",true))
        {
            this.Role = "FETCH";
        }
    }


    #endregion

    } // class CdmMssqlDbReplicaAvailabilityInfo
    
    #endregion

    public static class ListCdmMssqlDbReplicaAvailabilityInfoExtensions
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
            this List<CdmMssqlDbReplicaAvailabilityInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmMssqlDbReplicaAvailabilityInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMssqlDbReplicaAvailabilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmMssqlDbReplicaAvailabilityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types