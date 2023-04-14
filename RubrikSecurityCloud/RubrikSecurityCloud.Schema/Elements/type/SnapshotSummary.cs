// SnapshotSummary.cs
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
    #region SnapshotSummary
    public class SnapshotSummary: IFragment
    {
        #region members
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> System.Boolean? IsRetentionLockApplied
        // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
        [JsonProperty("isRetentionLockApplied")]
        public System.Boolean? IsRetentionLockApplied { get; set; }

        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        [JsonProperty("snapshotRetentionInfo")]
        public SnapshotRetentionInfo? SnapshotRetentionInfo { get; set; }

        //      C# -> UnmanagedSnapshotType? SnapshotType
        // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public UnmanagedSnapshotType? SnapshotType { get; set; }

        #endregion

    #region methods

    public SnapshotSummary Set(
        DateTime? Date = null,
        System.String? Id = null,
        System.Boolean? IsCustomRetentionApplied = null,
        System.Boolean? IsRetentionLockApplied = null,
        SnapshotRetentionInfo? SnapshotRetentionInfo = null,
        UnmanagedSnapshotType? SnapshotType = null
    ) 
    {
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( IsRetentionLockApplied != null ) {
            this.IsRetentionLockApplied = IsRetentionLockApplied;
        }
        if ( SnapshotRetentionInfo != null ) {
            this.SnapshotRetentionInfo = SnapshotRetentionInfo;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
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
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsCustomRetentionApplied
            // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
            if (this.IsCustomRetentionApplied != null)
            {
                 s += ind + "isCustomRetentionApplied\n";

            }
            //      C# -> System.Boolean? IsRetentionLockApplied
            // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
            if (this.IsRetentionLockApplied != null)
            {
                 s += ind + "isRetentionLockApplied\n";

            }
            //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
            // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
            if (this.SnapshotRetentionInfo != null)
            {
                 s += ind + "snapshotRetentionInfo\n";

                 s += ind + "{\n" + 
                 this.SnapshotRetentionInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> UnmanagedSnapshotType? SnapshotType
            // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
            if (this.SnapshotType != null)
            {
                 s += ind + "snapshotType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsCustomRetentionApplied
            // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
            if (this.IsCustomRetentionApplied == null && Exploration.Includes(parent + ".isCustomRetentionApplied$"))
            {
                this.IsCustomRetentionApplied = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRetentionLockApplied
            // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
            if (this.IsRetentionLockApplied == null && Exploration.Includes(parent + ".isRetentionLockApplied$"))
            {
                this.IsRetentionLockApplied = new System.Boolean();
            }
            //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
            // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
            if (this.SnapshotRetentionInfo == null && Exploration.Includes(parent + ".snapshotRetentionInfo"))
            {
                this.SnapshotRetentionInfo = new SnapshotRetentionInfo();
                this.SnapshotRetentionInfo.ApplyExploratoryFragment(parent + ".snapshotRetentionInfo");
            }
            //      C# -> UnmanagedSnapshotType? SnapshotType
            // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
            if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType$"))
            {
                this.SnapshotType = new UnmanagedSnapshotType();
            }
        }


    #endregion

    } // class SnapshotSummary
    #endregion

    public static class ListSnapshotSummaryExtensions
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
            this List<SnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotSummary> list, 
            String parent = "")
        {
            var item = new SnapshotSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types