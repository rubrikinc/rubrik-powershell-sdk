// K8sClusterPortsInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:38.
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
    #region K8sClusterPortsInfo
    public class K8sClusterPortsInfo: IFragment
    {
        #region members
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        [JsonProperty("kuprClusterUuid")]
        public System.String? KuprClusterUuid { get; set; }

        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        [JsonProperty("maxPort")]
        public System.Int32? MaxPort { get; set; }

        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        [JsonProperty("minPort")]
        public System.Int32? MinPort { get; set; }

        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        [JsonProperty("portRangeType")]
        public KuprClusterPortsType? PortRangeType { get; set; }

        #endregion

    #region methods

    public K8sClusterPortsInfo Set(
        System.String? KuprClusterUuid = null,
        System.Int32? MaxPort = null,
        System.Int32? MinPort = null,
        KuprClusterPortsType? PortRangeType = null
    ) 
    {
        if ( KuprClusterUuid != null ) {
            this.KuprClusterUuid = KuprClusterUuid;
        }
        if ( MaxPort != null ) {
            this.MaxPort = MaxPort;
        }
        if ( MinPort != null ) {
            this.MinPort = MinPort;
        }
        if ( PortRangeType != null ) {
            this.PortRangeType = PortRangeType;
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
            //      C# -> System.String? KuprClusterUuid
            // GraphQL -> kuprClusterUuid: UUID! (scalar)
            if (this.KuprClusterUuid != null)
            {
                 s += ind + "kuprClusterUuid\n";

            }
            //      C# -> System.Int32? MaxPort
            // GraphQL -> maxPort: Int! (scalar)
            if (this.MaxPort != null)
            {
                 s += ind + "maxPort\n";

            }
            //      C# -> System.Int32? MinPort
            // GraphQL -> minPort: Int! (scalar)
            if (this.MinPort != null)
            {
                 s += ind + "minPort\n";

            }
            //      C# -> KuprClusterPortsType? PortRangeType
            // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
            if (this.PortRangeType != null)
            {
                 s += ind + "portRangeType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? KuprClusterUuid
            // GraphQL -> kuprClusterUuid: UUID! (scalar)
            if (this.KuprClusterUuid == null && Exploration.Includes(parent + ".kuprClusterUuid$"))
            {
                this.KuprClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.Int32? MaxPort
            // GraphQL -> maxPort: Int! (scalar)
            if (this.MaxPort == null && Exploration.Includes(parent + ".maxPort$"))
            {
                this.MaxPort = new System.Int32();
            }
            //      C# -> System.Int32? MinPort
            // GraphQL -> minPort: Int! (scalar)
            if (this.MinPort == null && Exploration.Includes(parent + ".minPort$"))
            {
                this.MinPort = new System.Int32();
            }
            //      C# -> KuprClusterPortsType? PortRangeType
            // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
            if (this.PortRangeType == null && Exploration.Includes(parent + ".portRangeType$"))
            {
                this.PortRangeType = new KuprClusterPortsType();
            }
        }


    #endregion

    } // class K8sClusterPortsInfo
    #endregion

    public static class ListK8sClusterPortsInfoExtensions
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
            this List<K8sClusterPortsInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<K8sClusterPortsInfo> list, 
            String parent = "")
        {
            var item = new K8sClusterPortsInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types