// CdmOracleRacNode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:57.
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
    #region CdmOracleRacNode
    public class CdmOracleRacNode: IFragment
    {
        #region members
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        [JsonProperty("status")]
        public HostConnectivityStatusEnum? Status { get; set; }

        #endregion

    #region methods

    public CdmOracleRacNode Set(
        System.String? HostFid = null,
        System.String? NodeName = null,
        HostConnectivityStatusEnum? Status = null
    ) 
    {
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
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
            //      C# -> System.String? HostFid
            // GraphQL -> hostFid: String (scalar)
            if (this.HostFid != null)
            {
                 s += ind + "hostFid\n";

            }
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String! (scalar)
            if (this.NodeName != null)
            {
                 s += ind + "nodeName\n";

            }
            //      C# -> HostConnectivityStatusEnum? Status
            // GraphQL -> status: HostConnectivityStatusEnum! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostFid
            // GraphQL -> hostFid: String (scalar)
            if (this.HostFid == null && Exploration.Includes(parent + ".hostFid$"))
            {
                this.HostFid = new System.String("FETCH");
            }
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String! (scalar)
            if (this.NodeName == null && Exploration.Includes(parent + ".nodeName$"))
            {
                this.NodeName = new System.String("FETCH");
            }
            //      C# -> HostConnectivityStatusEnum? Status
            // GraphQL -> status: HostConnectivityStatusEnum! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new HostConnectivityStatusEnum();
            }
        }


    #endregion

    } // class CdmOracleRacNode
    #endregion

    public static class ListCdmOracleRacNodeExtensions
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
            this List<CdmOracleRacNode> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmOracleRacNode> list, 
            String parent = "")
        {
            var item = new CdmOracleRacNode();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types