// K8sClusterInfo.cs
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
    #region K8sClusterInfo
    public class K8sClusterInfo: IFragment
    {
        #region members
        //      C# -> System.String? K8sVersion
        // GraphQL -> k8sVersion: String (scalar)
        [JsonProperty("k8sVersion")]
        public System.String? K8sVersion { get; set; }

        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        [JsonProperty("kuprClusterUuid")]
        public System.String? KuprClusterUuid { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> Cluster? AssociatedCdm
        // GraphQL -> associatedCdm: Cluster (type)
        [JsonProperty("associatedCdm")]
        public Cluster? AssociatedCdm { get; set; }

        //      C# -> K8sClusterType? Type
        // GraphQL -> type: K8sClusterType! (enum)
        [JsonProperty("type")]
        public K8sClusterType? Type { get; set; }

        #endregion

    #region methods

    public K8sClusterInfo Set(
        System.String? K8sVersion = null,
        System.String? KuprClusterUuid = null,
        System.Int32? Port = null,
        Cluster? AssociatedCdm = null,
        K8sClusterType? Type = null
    ) 
    {
        if ( K8sVersion != null ) {
            this.K8sVersion = K8sVersion;
        }
        if ( KuprClusterUuid != null ) {
            this.KuprClusterUuid = KuprClusterUuid;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( AssociatedCdm != null ) {
            this.AssociatedCdm = AssociatedCdm;
        }
        if ( Type != null ) {
            this.Type = Type;
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
            //      C# -> System.String? K8sVersion
            // GraphQL -> k8sVersion: String (scalar)
            if (this.K8sVersion != null)
            {
                 s += ind + "k8sVersion\n";

            }
            //      C# -> System.String? KuprClusterUuid
            // GraphQL -> kuprClusterUuid: UUID! (scalar)
            if (this.KuprClusterUuid != null)
            {
                 s += ind + "kuprClusterUuid\n";

            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port != null)
            {
                 s += ind + "port\n";

            }
            //      C# -> Cluster? AssociatedCdm
            // GraphQL -> associatedCdm: Cluster (type)
            if (this.AssociatedCdm != null)
            {
                 s += ind + "associatedCdm\n";

                 s += ind + "{\n" + 
                 this.AssociatedCdm.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> K8sClusterType? Type
            // GraphQL -> type: K8sClusterType! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? K8sVersion
            // GraphQL -> k8sVersion: String (scalar)
            if (this.K8sVersion == null && Exploration.Includes(parent + ".k8sVersion$"))
            {
                this.K8sVersion = new System.String("FETCH");
            }
            //      C# -> System.String? KuprClusterUuid
            // GraphQL -> kuprClusterUuid: UUID! (scalar)
            if (this.KuprClusterUuid == null && Exploration.Includes(parent + ".kuprClusterUuid$"))
            {
                this.KuprClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.Int32? Port
            // GraphQL -> port: Int! (scalar)
            if (this.Port == null && Exploration.Includes(parent + ".port$"))
            {
                this.Port = new System.Int32();
            }
            //      C# -> Cluster? AssociatedCdm
            // GraphQL -> associatedCdm: Cluster (type)
            if (this.AssociatedCdm == null && Exploration.Includes(parent + ".associatedCdm"))
            {
                this.AssociatedCdm = new Cluster();
                this.AssociatedCdm.ApplyExploratoryFragment(parent + ".associatedCdm");
            }
            //      C# -> K8sClusterType? Type
            // GraphQL -> type: K8sClusterType! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new K8sClusterType();
            }
        }


    #endregion

    } // class K8sClusterInfo
    #endregion

    public static class ListK8sClusterInfoExtensions
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
            this List<K8sClusterInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<K8sClusterInfo> list, 
            String parent = "")
        {
            var item = new K8sClusterInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types