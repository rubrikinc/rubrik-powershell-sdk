// K8sSnapshotInfo.cs
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
    #region K8sSnapshotInfo
    public class K8sSnapshotInfo: IFragment
    {
        #region members
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? Namespace
        // GraphQL -> namespace: String! (scalar)
        [JsonProperty("namespace")]
        public System.String? Namespace { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime! (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> List<PvcInformation>? PvcList
        // GraphQL -> pvcList: [PvcInformation!]! (type)
        [JsonProperty("pvcList")]
        public List<PvcInformation>? PvcList { get; set; }

        #endregion

    #region methods

    public K8sSnapshotInfo Set(
        DateTime? ExpirationTime = null,
        System.Boolean? IsArchived = null,
        System.String? Namespace = null,
        DateTime? SnapshotTime = null,
        List<PvcInformation>? PvcList = null
    ) 
    {
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( Namespace != null ) {
            this.Namespace = Namespace;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( PvcList != null ) {
            this.PvcList = PvcList;
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
            //      C# -> DateTime? ExpirationTime
            // GraphQL -> expirationTime: DateTime (scalar)
            if (this.ExpirationTime != null)
            {
                 s += ind + "expirationTime\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.String? Namespace
            // GraphQL -> namespace: String! (scalar)
            if (this.Namespace != null)
            {
                 s += ind + "namespace\n";

            }
            //      C# -> DateTime? SnapshotTime
            // GraphQL -> snapshotTime: DateTime! (scalar)
            if (this.SnapshotTime != null)
            {
                 s += ind + "snapshotTime\n";

            }
            //      C# -> List<PvcInformation>? PvcList
            // GraphQL -> pvcList: [PvcInformation!]! (type)
            if (this.PvcList != null)
            {
                 s += ind + "pvcList\n";

                 s += ind + "{\n" + 
                 this.PvcList.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ExpirationTime
            // GraphQL -> expirationTime: DateTime (scalar)
            if (this.ExpirationTime == null && Exploration.Includes(parent + ".expirationTime$"))
            {
                this.ExpirationTime = new DateTime();
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean! (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.String? Namespace
            // GraphQL -> namespace: String! (scalar)
            if (this.Namespace == null && Exploration.Includes(parent + ".namespace$"))
            {
                this.Namespace = new System.String("FETCH");
            }
            //      C# -> DateTime? SnapshotTime
            // GraphQL -> snapshotTime: DateTime! (scalar)
            if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime$"))
            {
                this.SnapshotTime = new DateTime();
            }
            //      C# -> List<PvcInformation>? PvcList
            // GraphQL -> pvcList: [PvcInformation!]! (type)
            if (this.PvcList == null && Exploration.Includes(parent + ".pvcList"))
            {
                this.PvcList = new List<PvcInformation>();
                this.PvcList.ApplyExploratoryFragment(parent + ".pvcList");
            }
        }


    #endregion

    } // class K8sSnapshotInfo
    #endregion

    public static class ListK8sSnapshotInfoExtensions
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
            this List<K8sSnapshotInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<K8sSnapshotInfo> list, 
            String parent = "")
        {
            var item = new K8sSnapshotInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types