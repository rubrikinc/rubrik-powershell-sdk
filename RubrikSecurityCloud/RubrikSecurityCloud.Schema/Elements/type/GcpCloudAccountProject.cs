// GcpCloudAccountProject.cs
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
    #region GcpCloudAccountProject
    public class GcpCloudAccountProject: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        [JsonProperty("organizationName")]
        public System.String? OrganizationName { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }

        //      C# -> System.Int64? ProjectNumber
        // GraphQL -> projectNumber: Long! (scalar)
        [JsonProperty("projectNumber")]
        public System.Int64? ProjectNumber { get; set; }

        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        [JsonProperty("roleId")]
        public System.String? RoleId { get; set; }

        //      C# -> System.Boolean? UsesGlobalConfig
        // GraphQL -> usesGlobalConfig: Boolean! (scalar)
        [JsonProperty("usesGlobalConfig")]
        public System.Boolean? UsesGlobalConfig { get; set; }


        #endregion

    #region methods

    public GcpCloudAccountProject Set(
        System.String? Id = null,
        System.String? Name = null,
        System.String? OrganizationName = null,
        System.String? ProjectId = null,
        System.Int64? ProjectNumber = null,
        System.String? RoleId = null,
        System.Boolean? UsesGlobalConfig = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrganizationName != null ) {
            this.OrganizationName = OrganizationName;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
        }
        if ( ProjectNumber != null ) {
            this.ProjectNumber = ProjectNumber;
        }
        if ( RoleId != null ) {
            this.RoleId = RoleId;
        }
        if ( UsesGlobalConfig != null ) {
            this.UsesGlobalConfig = UsesGlobalConfig;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        if (this.OrganizationName != null) {
            s += ind + "organizationName\n" ;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            s += ind + "projectId\n" ;
        }
        //      C# -> System.Int64? ProjectNumber
        // GraphQL -> projectNumber: Long! (scalar)
        if (this.ProjectNumber != null) {
            s += ind + "projectNumber\n" ;
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (this.RoleId != null) {
            s += ind + "roleId\n" ;
        }
        //      C# -> System.Boolean? UsesGlobalConfig
        // GraphQL -> usesGlobalConfig: Boolean! (scalar)
        if (this.UsesGlobalConfig != null) {
            s += ind + "usesGlobalConfig\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OrganizationName
        // GraphQL -> organizationName: String! (scalar)
        if (this.OrganizationName == null && Exploration.Includes(parent + ".organizationName", true))
        {
            this.OrganizationName = "FETCH";
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId == null && Exploration.Includes(parent + ".projectId", true))
        {
            this.ProjectId = "FETCH";
        }
        //      C# -> System.Int64? ProjectNumber
        // GraphQL -> projectNumber: Long! (scalar)
        if (this.ProjectNumber == null && Exploration.Includes(parent + ".projectNumber", true))
        {
            this.ProjectNumber = new System.Int64();
        }
        //      C# -> System.String? RoleId
        // GraphQL -> roleId: String! (scalar)
        if (this.RoleId == null && Exploration.Includes(parent + ".roleId", true))
        {
            this.RoleId = "FETCH";
        }
        //      C# -> System.Boolean? UsesGlobalConfig
        // GraphQL -> usesGlobalConfig: Boolean! (scalar)
        if (this.UsesGlobalConfig == null && Exploration.Includes(parent + ".usesGlobalConfig", true))
        {
            this.UsesGlobalConfig = true;
        }
    }


    #endregion

    } // class GcpCloudAccountProject
    
    #endregion

    public static class ListGcpCloudAccountProjectExtensions
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
            this List<GcpCloudAccountProject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types