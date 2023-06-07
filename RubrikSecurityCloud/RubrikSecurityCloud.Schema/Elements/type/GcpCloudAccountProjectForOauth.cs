// GcpCloudAccountProjectForOauth.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region GcpCloudAccountProjectForOauth
    public class GcpCloudAccountProjectForOauth: BaseType
    {
        #region members

        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!] (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }


        #endregion

    #region methods

    public GcpCloudAccountProjectForOauth Set(
        List<System.String>? MissingPermissions = null,
        System.String? Name = null,
        System.String? ProjectId = null
    ) 
    {
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        // GraphQL -> missingPermissions: [String!] (scalar)
        if (this.MissingPermissions != null) {
            s += ind + "missingPermissions\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            s += ind + "projectId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!] (scalar)
        if (this.MissingPermissions == null && Exploration.Includes(parent + ".missingPermissions", true))
        {
            this.MissingPermissions = new List<System.String>();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId == null && Exploration.Includes(parent + ".projectId", true))
        {
            this.ProjectId = "FETCH";
        }
    }


    #endregion

    } // class GcpCloudAccountProjectForOauth
    
    #endregion

    public static class ListGcpCloudAccountProjectForOauthExtensions
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
            this List<GcpCloudAccountProjectForOauth> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProjectForOauth> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProjectForOauth());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types