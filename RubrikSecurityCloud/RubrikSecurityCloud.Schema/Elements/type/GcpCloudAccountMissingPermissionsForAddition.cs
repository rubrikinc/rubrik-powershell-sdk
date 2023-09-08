// GcpCloudAccountMissingPermissionsForAddition.cs
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
    #region GcpCloudAccountMissingPermissionsForAddition
    public class GcpCloudAccountMissingPermissionsForAddition: BaseType
    {
        #region members

        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountMissingPermissionsForAddition";
    }

    public GcpCloudAccountMissingPermissionsForAddition Set(
        List<System.String>? MissingPermissions = null,
        System.String? ProjectId = null
    ) 
    {
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
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
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (this.MissingPermissions != null) {
            s += ind + "missingPermissions\n" ;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            s += ind + "projectId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (this.MissingPermissions == null && ec.Includes("missingPermissions",true))
        {
            this.MissingPermissions = new List<System.String>();
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId == null && ec.Includes("projectId",true))
        {
            this.ProjectId = "FETCH";
        }
    }


    #endregion

    } // class GcpCloudAccountMissingPermissionsForAddition
    
    #endregion

    public static class ListGcpCloudAccountMissingPermissionsForAdditionExtensions
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
            this List<GcpCloudAccountMissingPermissionsForAddition> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountMissingPermissionsForAddition> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountMissingPermissionsForAddition());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GcpCloudAccountMissingPermissionsForAddition> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types