// HotAddProxyVmInfo.cs
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
    #region HotAddProxyVmInfo
    public class HotAddProxyVmInfo: IFragment
    {
        #region members
        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? UsedPortCount
        // GraphQL -> usedPortCount: Int! (scalar)
        [JsonProperty("usedPortCount")]
        public System.Int32? UsedPortCount { get; set; }

        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String! (scalar)
        [JsonProperty("vcenterName")]
        public System.String? VcenterName { get; set; }

        //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
        // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
        [JsonProperty("proxyNetworkInfo")]
        public HotAddNetworkConfigWithName? ProxyNetworkInfo { get; set; }

        //      C# -> HotAddProxyVmStatusType? Status
        // GraphQL -> status: HotAddProxyVmStatusType! (enum)
        [JsonProperty("status")]
        public HotAddProxyVmStatusType? Status { get; set; }

        #endregion

    #region methods

    public HotAddProxyVmInfo Set(
        System.String? ComputeClusterName = null,
        System.String? DatastoreName = null,
        System.String? HostName = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? UsedPortCount = null,
        System.String? VcenterName = null,
        HotAddNetworkConfigWithName? ProxyNetworkInfo = null,
        HotAddProxyVmStatusType? Status = null
    ) 
    {
        if ( ComputeClusterName != null ) {
            this.ComputeClusterName = ComputeClusterName;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( UsedPortCount != null ) {
            this.UsedPortCount = UsedPortCount;
        }
        if ( VcenterName != null ) {
            this.VcenterName = VcenterName;
        }
        if ( ProxyNetworkInfo != null ) {
            this.ProxyNetworkInfo = ProxyNetworkInfo;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? ComputeClusterName
            // GraphQL -> computeClusterName: String (scalar)
            if (this.ComputeClusterName != null)
            {
                 s += ind + "computeClusterName\n";

            }
            //      C# -> System.String? DatastoreName
            // GraphQL -> datastoreName: String! (scalar)
            if (this.DatastoreName != null)
            {
                 s += ind + "datastoreName\n";

            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
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
            //      C# -> System.Int32? UsedPortCount
            // GraphQL -> usedPortCount: Int! (scalar)
            if (this.UsedPortCount != null)
            {
                 s += ind + "usedPortCount\n";

            }
            //      C# -> System.String? VcenterName
            // GraphQL -> vcenterName: String! (scalar)
            if (this.VcenterName != null)
            {
                 s += ind + "vcenterName\n";

            }
            //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
            // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
            if (this.ProxyNetworkInfo != null)
            {
                 s += ind + "proxyNetworkInfo\n";

                 s += ind + "{\n" + 
                 this.ProxyNetworkInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> HotAddProxyVmStatusType? Status
            // GraphQL -> status: HotAddProxyVmStatusType! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ComputeClusterName
            // GraphQL -> computeClusterName: String (scalar)
            if (this.ComputeClusterName == null && Exploration.Includes(parent + ".computeClusterName$"))
            {
                this.ComputeClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? DatastoreName
            // GraphQL -> datastoreName: String! (scalar)
            if (this.DatastoreName == null && Exploration.Includes(parent + ".datastoreName$"))
            {
                this.DatastoreName = new System.String("FETCH");
            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
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
            //      C# -> System.Int32? UsedPortCount
            // GraphQL -> usedPortCount: Int! (scalar)
            if (this.UsedPortCount == null && Exploration.Includes(parent + ".usedPortCount$"))
            {
                this.UsedPortCount = new System.Int32();
            }
            //      C# -> System.String? VcenterName
            // GraphQL -> vcenterName: String! (scalar)
            if (this.VcenterName == null && Exploration.Includes(parent + ".vcenterName$"))
            {
                this.VcenterName = new System.String("FETCH");
            }
            //      C# -> HotAddNetworkConfigWithName? ProxyNetworkInfo
            // GraphQL -> proxyNetworkInfo: HotAddNetworkConfigWithName (type)
            if (this.ProxyNetworkInfo == null && Exploration.Includes(parent + ".proxyNetworkInfo"))
            {
                this.ProxyNetworkInfo = new HotAddNetworkConfigWithName();
                this.ProxyNetworkInfo.ApplyExploratoryFragment(parent + ".proxyNetworkInfo");
            }
            //      C# -> HotAddProxyVmStatusType? Status
            // GraphQL -> status: HotAddProxyVmStatusType! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new HotAddProxyVmStatusType();
            }
        }


    #endregion

    } // class HotAddProxyVmInfo
    #endregion

    public static class ListHotAddProxyVmInfoExtensions
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
            this List<HotAddProxyVmInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HotAddProxyVmInfo> list, 
            String parent = "")
        {
            var item = new HotAddProxyVmInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types