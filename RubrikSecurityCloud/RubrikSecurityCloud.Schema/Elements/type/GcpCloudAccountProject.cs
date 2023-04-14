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

namespace Rubrik.SecurityCloud.Types
{
    #region GcpCloudAccountProject
    public class GcpCloudAccountProject: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OrganizationName
            // GraphQL -> organizationName: String! (scalar)
            if (this.OrganizationName != null)
            {
                 s += ind + "organizationName\n";

            }
            //      C# -> System.String? ProjectId
            // GraphQL -> projectId: String! (scalar)
            if (this.ProjectId != null)
            {
                 s += ind + "projectId\n";

            }
            //      C# -> System.Int64? ProjectNumber
            // GraphQL -> projectNumber: Long! (scalar)
            if (this.ProjectNumber != null)
            {
                 s += ind + "projectNumber\n";

            }
            //      C# -> System.String? RoleId
            // GraphQL -> roleId: String! (scalar)
            if (this.RoleId != null)
            {
                 s += ind + "roleId\n";

            }
            //      C# -> System.Boolean? UsesGlobalConfig
            // GraphQL -> usesGlobalConfig: Boolean! (scalar)
            if (this.UsesGlobalConfig != null)
            {
                 s += ind + "usesGlobalConfig\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OrganizationName
            // GraphQL -> organizationName: String! (scalar)
            if (this.OrganizationName == null && Exploration.Includes(parent + ".organizationName$"))
            {
                this.OrganizationName = new System.String("FETCH");
            }
            //      C# -> System.String? ProjectId
            // GraphQL -> projectId: String! (scalar)
            if (this.ProjectId == null && Exploration.Includes(parent + ".projectId$"))
            {
                this.ProjectId = new System.String("FETCH");
            }
            //      C# -> System.Int64? ProjectNumber
            // GraphQL -> projectNumber: Long! (scalar)
            if (this.ProjectNumber == null && Exploration.Includes(parent + ".projectNumber$"))
            {
                this.ProjectNumber = new System.Int64();
            }
            //      C# -> System.String? RoleId
            // GraphQL -> roleId: String! (scalar)
            if (this.RoleId == null && Exploration.Includes(parent + ".roleId$"))
            {
                this.RoleId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? UsesGlobalConfig
            // GraphQL -> usesGlobalConfig: Boolean! (scalar)
            if (this.UsesGlobalConfig == null && Exploration.Includes(parent + ".usesGlobalConfig$"))
            {
                this.UsesGlobalConfig = new System.Boolean();
            }
        }


    #endregion

    } // class GcpCloudAccountProject
    #endregion

    public static class ListGcpCloudAccountProjectExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GcpCloudAccountProject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountProject> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountProject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types