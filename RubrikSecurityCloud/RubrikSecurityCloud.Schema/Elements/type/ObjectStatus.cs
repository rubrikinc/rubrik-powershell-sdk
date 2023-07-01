// ObjectStatus.cs
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
    #region ObjectStatus
    public class ObjectStatus: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        [JsonProperty("latestSnapshotResult")]
        public SnapshotResult? LatestSnapshotResult { get; set; }

        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        [JsonProperty("policyStatuses")]
        public List<PolicyStatus>? PolicyStatuses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectStatus";
    }

    public ObjectStatus Set(
        System.String? Id = null,
        SnapshotResult? LatestSnapshotResult = null,
        List<PolicyStatus>? PolicyStatuses = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LatestSnapshotResult != null ) {
            this.LatestSnapshotResult = LatestSnapshotResult;
        }
        if ( PolicyStatuses != null ) {
            this.PolicyStatuses = PolicyStatuses;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        if (this.LatestSnapshotResult != null) {
            var fspec = this.LatestSnapshotResult.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestSnapshotResult {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        if (this.PolicyStatuses != null) {
            var fspec = this.PolicyStatuses.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "policyStatuses {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        if (this.LatestSnapshotResult == null && Exploration.Includes(parent + ".latestSnapshotResult"))
        {
            this.LatestSnapshotResult = new SnapshotResult();
            this.LatestSnapshotResult.ApplyExploratoryFieldSpec(parent + ".latestSnapshotResult");
        }
        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        if (this.PolicyStatuses == null && Exploration.Includes(parent + ".policyStatuses"))
        {
            this.PolicyStatuses = new List<PolicyStatus>();
            this.PolicyStatuses.ApplyExploratoryFieldSpec(parent + ".policyStatuses");
        }
    }


    #endregion

    } // class ObjectStatus
    
    #endregion

    public static class ListObjectStatusExtensions
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
            this List<ObjectStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ObjectStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types