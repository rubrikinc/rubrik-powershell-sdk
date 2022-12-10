// SapHanaHost.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
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
    #region SapHanaHost
    public class SapHanaHost: IFragment
    {
        #region members
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? SapHanaHostName
        // GraphQL -> sapHanaHostName: String (scalar)
        [JsonProperty("sapHanaHostName")]
        public System.String? SapHanaHostName { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> SapHanaHostHostType? HostType
        // GraphQL -> hostType: SapHanaHostHostType (enum)
        [JsonProperty("hostType")]
        public SapHanaHostHostType? HostType { get; set; }

        #endregion

    #region methods

    public SapHanaHost Set(
        System.String? HostName = null,
        System.String? HostUuid = null,
        System.String? SapHanaHostName = null,
        System.String? Status = null,
        SapHanaHostHostType? HostType = null
    ) 
    {
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( SapHanaHostName != null ) {
            this.SapHanaHostName = SapHanaHostName;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
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
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
            //      C# -> System.String? HostUuid
            // GraphQL -> hostUuid: String! (scalar)
            if (this.HostUuid != null)
            {
                 s += ind + "hostUuid\n";

            }
            //      C# -> System.String? SapHanaHostName
            // GraphQL -> sapHanaHostName: String (scalar)
            if (this.SapHanaHostName != null)
            {
                 s += ind + "sapHanaHostName\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> SapHanaHostHostType? HostType
            // GraphQL -> hostType: SapHanaHostHostType (enum)
            if (this.HostType != null)
            {
                 s += ind + "hostType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
            //      C# -> System.String? HostUuid
            // GraphQL -> hostUuid: String! (scalar)
            if (this.HostUuid == null && Exploration.Includes(parent + ".hostUuid$"))
            {
                this.HostUuid = new System.String("FETCH");
            }
            //      C# -> System.String? SapHanaHostName
            // GraphQL -> sapHanaHostName: String (scalar)
            if (this.SapHanaHostName == null && Exploration.Includes(parent + ".sapHanaHostName$"))
            {
                this.SapHanaHostName = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> SapHanaHostHostType? HostType
            // GraphQL -> hostType: SapHanaHostHostType (enum)
            if (this.HostType == null && Exploration.Includes(parent + ".hostType$"))
            {
                this.HostType = new SapHanaHostHostType();
            }
        }


    #endregion

    } // class SapHanaHost
    #endregion

    public static class ListSapHanaHostExtensions
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
            this List<SapHanaHost> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaHost> list, 
            String parent = "")
        {
            var item = new SapHanaHost();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types