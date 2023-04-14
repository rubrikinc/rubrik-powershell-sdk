// SapHanaHostObject.cs
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
    #region SapHanaHostObject
    public class SapHanaHostObject: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostType
        // GraphQL -> hostType: String! (scalar)
        [JsonProperty("hostType")]
        public System.String? HostType { get; set; }

        //      C# -> System.String? HostUuid
        // GraphQL -> hostUuid: String! (scalar)
        [JsonProperty("hostUuid")]
        public System.String? HostUuid { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost! (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }

        #endregion

    #region methods

    public SapHanaHostObject Set(
        System.String? ClusterUuid = null,
        System.String? HostName = null,
        System.String? HostType = null,
        System.String? HostUuid = null,
        System.String? Status = null,
        PhysicalHost? Host = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        if ( HostUuid != null ) {
            this.HostUuid = HostUuid;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Host != null ) {
            this.Host = Host;
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
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
            //      C# -> System.String? HostType
            // GraphQL -> hostType: String! (scalar)
            if (this.HostType != null)
            {
                 s += ind + "hostType\n";

            }
            //      C# -> System.String? HostUuid
            // GraphQL -> hostUuid: String! (scalar)
            if (this.HostUuid != null)
            {
                 s += ind + "hostUuid\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> PhysicalHost? Host
            // GraphQL -> host: PhysicalHost! (type)
            if (this.Host != null)
            {
                 s += ind + "host\n";

                 s += ind + "{\n" + 
                 this.Host.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
            //      C# -> System.String? HostType
            // GraphQL -> hostType: String! (scalar)
            if (this.HostType == null && Exploration.Includes(parent + ".hostType$"))
            {
                this.HostType = new System.String("FETCH");
            }
            //      C# -> System.String? HostUuid
            // GraphQL -> hostUuid: String! (scalar)
            if (this.HostUuid == null && Exploration.Includes(parent + ".hostUuid$"))
            {
                this.HostUuid = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> PhysicalHost? Host
            // GraphQL -> host: PhysicalHost! (type)
            if (this.Host == null && Exploration.Includes(parent + ".host"))
            {
                this.Host = new PhysicalHost();
                this.Host.ApplyExploratoryFragment(parent + ".host");
            }
        }


    #endregion

    } // class SapHanaHostObject
    #endregion

    public static class ListSapHanaHostObjectExtensions
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
            this List<SapHanaHostObject> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaHostObject> list, 
            String parent = "")
        {
            var item = new SapHanaHostObject();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types