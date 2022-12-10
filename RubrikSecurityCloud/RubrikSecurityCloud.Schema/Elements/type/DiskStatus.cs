// DiskStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:17.
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
    #region DiskStatus
    public class DiskStatus: IFragment
    {
        #region members
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        [JsonProperty("diskType")]
        public System.String? DiskType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        [JsonProperty("isDegraded")]
        public System.Boolean? IsDegraded { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        #endregion

    #region methods

    public DiskStatus Set(
        System.String? DiskType = null,
        System.String? Id = null,
        System.Boolean? IsDegraded = null,
        System.Boolean? IsEncrypted = null,
        System.String? NodeId = null,
        System.String? Status = null
    ) 
    {
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDegraded != null ) {
            this.IsDegraded = IsDegraded;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
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
            //      C# -> System.String? DiskType
            // GraphQL -> diskType: String! (scalar)
            if (this.DiskType != null)
            {
                 s += ind + "diskType\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsDegraded
            // GraphQL -> isDegraded: Boolean! (scalar)
            if (this.IsDegraded != null)
            {
                 s += ind + "isDegraded\n";

            }
            //      C# -> System.Boolean? IsEncrypted
            // GraphQL -> isEncrypted: Boolean! (scalar)
            if (this.IsEncrypted != null)
            {
                 s += ind + "isEncrypted\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DiskType
            // GraphQL -> diskType: String! (scalar)
            if (this.DiskType == null && Exploration.Includes(parent + ".diskType$"))
            {
                this.DiskType = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsDegraded
            // GraphQL -> isDegraded: Boolean! (scalar)
            if (this.IsDegraded == null && Exploration.Includes(parent + ".isDegraded$"))
            {
                this.IsDegraded = new System.Boolean();
            }
            //      C# -> System.Boolean? IsEncrypted
            // GraphQL -> isEncrypted: Boolean! (scalar)
            if (this.IsEncrypted == null && Exploration.Includes(parent + ".isEncrypted$"))
            {
                this.IsEncrypted = new System.Boolean();
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
        }


    #endregion

    } // class DiskStatus
    #endregion

    public static class ListDiskStatusExtensions
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
            this List<DiskStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DiskStatus> list, 
            String parent = "")
        {
            var item = new DiskStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types