// GcpCloudAccountProjectForOauth.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    #region GcpCloudAccountProjectForOauth
    public class GcpCloudAccountProjectForOauth: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? MissingPermissions
            // GraphQL -> missingPermissions: [String!] (scalar)
            if (this.MissingPermissions != null)
            {
                 s += ind + "missingPermissions\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ProjectId
            // GraphQL -> projectId: String! (scalar)
            if (this.ProjectId != null)
            {
                 s += ind + "projectId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? MissingPermissions
            // GraphQL -> missingPermissions: [String!] (scalar)
            if (this.MissingPermissions == null && Exploration.Includes(parent + ".missingPermissions$"))
            {
                this.MissingPermissions = new List<System.String>();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ProjectId
            // GraphQL -> projectId: String! (scalar)
            if (this.ProjectId == null && Exploration.Includes(parent + ".projectId$"))
            {
                this.ProjectId = new System.String("FETCH");
            }
        }


    #endregion

    } // class GcpCloudAccountProjectForOauth
    #endregion

    public static class ListGcpCloudAccountProjectForOauthExtensions
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
            this List<GcpCloudAccountProjectForOauth> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountProjectForOauth> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountProjectForOauth();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types