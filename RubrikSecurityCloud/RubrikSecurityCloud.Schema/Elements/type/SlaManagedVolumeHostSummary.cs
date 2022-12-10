// SlaManagedVolumeHostSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
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
    #region SlaManagedVolumeHostSummary
    public class SlaManagedVolumeHostSummary: IFragment
    {
        #region members
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? OperatingSystemType
        // GraphQL -> operatingSystemType: String! (scalar)
        [JsonProperty("operatingSystemType")]
        public System.String? OperatingSystemType { get; set; }

        //      C# -> System.String? RubrikBackupServiceStatus
        // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
        [JsonProperty("rubrikBackupServiceStatus")]
        public System.String? RubrikBackupServiceStatus { get; set; }

        #endregion

    #region methods

    public SlaManagedVolumeHostSummary Set(
        System.String? HostId = null,
        System.String? HostName = null,
        System.String? OperatingSystemType = null,
        System.String? RubrikBackupServiceStatus = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( OperatingSystemType != null ) {
            this.OperatingSystemType = OperatingSystemType;
        }
        if ( RubrikBackupServiceStatus != null ) {
            this.RubrikBackupServiceStatus = RubrikBackupServiceStatus;
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
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName != null)
            {
                 s += ind + "hostName\n";

            }
            //      C# -> System.String? OperatingSystemType
            // GraphQL -> operatingSystemType: String! (scalar)
            if (this.OperatingSystemType != null)
            {
                 s += ind + "operatingSystemType\n";

            }
            //      C# -> System.String? RubrikBackupServiceStatus
            // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
            if (this.RubrikBackupServiceStatus != null)
            {
                 s += ind + "rubrikBackupServiceStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String! (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? HostName
            // GraphQL -> hostName: String! (scalar)
            if (this.HostName == null && Exploration.Includes(parent + ".hostName$"))
            {
                this.HostName = new System.String("FETCH");
            }
            //      C# -> System.String? OperatingSystemType
            // GraphQL -> operatingSystemType: String! (scalar)
            if (this.OperatingSystemType == null && Exploration.Includes(parent + ".operatingSystemType$"))
            {
                this.OperatingSystemType = new System.String("FETCH");
            }
            //      C# -> System.String? RubrikBackupServiceStatus
            // GraphQL -> rubrikBackupServiceStatus: String! (scalar)
            if (this.RubrikBackupServiceStatus == null && Exploration.Includes(parent + ".rubrikBackupServiceStatus$"))
            {
                this.RubrikBackupServiceStatus = new System.String("FETCH");
            }
        }


    #endregion

    } // class SlaManagedVolumeHostSummary
    #endregion

    public static class ListSlaManagedVolumeHostSummaryExtensions
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
            this List<SlaManagedVolumeHostSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaManagedVolumeHostSummary> list, 
            String parent = "")
        {
            var item = new SlaManagedVolumeHostSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types