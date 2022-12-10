// CdmNodeDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:03.
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
    #region CdmNodeDetail
    public class CdmNodeDetail: IFragment
    {
        #region members
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DataIpAddress
        // GraphQL -> dataIpAddress: String! (scalar)
        [JsonProperty("dataIpAddress")]
        public System.String? DataIpAddress { get; set; }

        //      C# -> System.String? IpmiIpAddress
        // GraphQL -> ipmiIpAddress: String (scalar)
        [JsonProperty("ipmiIpAddress")]
        public System.String? IpmiIpAddress { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        #endregion

    #region methods

    public CdmNodeDetail Set(
        System.String? ClusterId = null,
        System.String? DataIpAddress = null,
        System.String? IpmiIpAddress = null,
        System.String? NodeId = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DataIpAddress != null ) {
            this.DataIpAddress = DataIpAddress;
        }
        if ( IpmiIpAddress != null ) {
            this.IpmiIpAddress = IpmiIpAddress;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
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
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.String? DataIpAddress
            // GraphQL -> dataIpAddress: String! (scalar)
            if (this.DataIpAddress != null)
            {
                 s += ind + "dataIpAddress\n";

            }
            //      C# -> System.String? IpmiIpAddress
            // GraphQL -> ipmiIpAddress: String (scalar)
            if (this.IpmiIpAddress != null)
            {
                 s += ind + "ipmiIpAddress\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: UUID! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? DataIpAddress
            // GraphQL -> dataIpAddress: String! (scalar)
            if (this.DataIpAddress == null && Exploration.Includes(parent + ".dataIpAddress$"))
            {
                this.DataIpAddress = new System.String("FETCH");
            }
            //      C# -> System.String? IpmiIpAddress
            // GraphQL -> ipmiIpAddress: String (scalar)
            if (this.IpmiIpAddress == null && Exploration.Includes(parent + ".ipmiIpAddress$"))
            {
                this.IpmiIpAddress = new System.String("FETCH");
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
        }


    #endregion

    } // class CdmNodeDetail
    #endregion

    public static class ListCdmNodeDetailExtensions
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
            this List<CdmNodeDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmNodeDetail> list, 
            String parent = "")
        {
            var item = new CdmNodeDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types