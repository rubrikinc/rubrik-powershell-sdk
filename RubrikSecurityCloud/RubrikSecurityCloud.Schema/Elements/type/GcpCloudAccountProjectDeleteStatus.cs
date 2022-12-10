// GcpCloudAccountProjectDeleteStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:22.
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
    #region GcpCloudAccountProjectDeleteStatus
    public class GcpCloudAccountProjectDeleteStatus: IFragment
    {
        #region members
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        [JsonProperty("projectUuid")]
        public System.String? ProjectUuid { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }

        #endregion

    #region methods

    public GcpCloudAccountProjectDeleteStatus Set(
        System.String? Error = null,
        System.String? ProjectUuid = null,
        System.Boolean? Success = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( ProjectUuid != null ) {
            this.ProjectUuid = ProjectUuid;
        }
        if ( Success != null ) {
            this.Success = Success;
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
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

            }
            //      C# -> System.String? ProjectUuid
            // GraphQL -> projectUuid: String! (scalar)
            if (this.ProjectUuid != null)
            {
                 s += ind + "projectUuid\n";

            }
            //      C# -> System.Boolean? Success
            // GraphQL -> success: Boolean! (scalar)
            if (this.Success != null)
            {
                 s += ind + "success\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
            }
            //      C# -> System.String? ProjectUuid
            // GraphQL -> projectUuid: String! (scalar)
            if (this.ProjectUuid == null && Exploration.Includes(parent + ".projectUuid$"))
            {
                this.ProjectUuid = new System.String("FETCH");
            }
            //      C# -> System.Boolean? Success
            // GraphQL -> success: Boolean! (scalar)
            if (this.Success == null && Exploration.Includes(parent + ".success$"))
            {
                this.Success = new System.Boolean();
            }
        }


    #endregion

    } // class GcpCloudAccountProjectDeleteStatus
    #endregion

    public static class ListGcpCloudAccountProjectDeleteStatusExtensions
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
            this List<GcpCloudAccountProjectDeleteStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountProjectDeleteStatus> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountProjectDeleteStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types