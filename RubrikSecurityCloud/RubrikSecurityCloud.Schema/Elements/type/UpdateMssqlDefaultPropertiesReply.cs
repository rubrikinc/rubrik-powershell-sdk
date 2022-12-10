// UpdateMssqlDefaultPropertiesReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:47.
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
    #region UpdateMssqlDefaultPropertiesReply
    public class UpdateMssqlDefaultPropertiesReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        [JsonProperty("cbtStatus")]
        public System.Boolean? CbtStatus { get; set; }

        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Int64? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        [JsonProperty("logRetentionTimeInHours")]
        public System.Int32? LogRetentionTimeInHours { get; set; }

        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        [JsonProperty("shouldUseDefaultBackupLocation")]
        public System.Boolean? ShouldUseDefaultBackupLocation { get; set; }

        #endregion

    #region methods

    public UpdateMssqlDefaultPropertiesReply Set(
        System.Boolean? CbtStatus = null,
        System.Int64? LogBackupFrequencyInSeconds = null,
        System.Int32? LogRetentionTimeInHours = null,
        System.Boolean? ShouldUseDefaultBackupLocation = null
    ) 
    {
        if ( CbtStatus != null ) {
            this.CbtStatus = CbtStatus;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogRetentionTimeInHours != null ) {
            this.LogRetentionTimeInHours = LogRetentionTimeInHours;
        }
        if ( ShouldUseDefaultBackupLocation != null ) {
            this.ShouldUseDefaultBackupLocation = ShouldUseDefaultBackupLocation;
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
            //      C# -> System.Boolean? CbtStatus
            // GraphQL -> cbtStatus: Boolean! (scalar)
            if (this.CbtStatus != null)
            {
                 s += ind + "cbtStatus\n";

            }
            //      C# -> System.Int64? LogBackupFrequencyInSeconds
            // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
            if (this.LogBackupFrequencyInSeconds != null)
            {
                 s += ind + "logBackupFrequencyInSeconds\n";

            }
            //      C# -> System.Int32? LogRetentionTimeInHours
            // GraphQL -> logRetentionTimeInHours: Int (scalar)
            if (this.LogRetentionTimeInHours != null)
            {
                 s += ind + "logRetentionTimeInHours\n";

            }
            //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
            // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
            if (this.ShouldUseDefaultBackupLocation != null)
            {
                 s += ind + "shouldUseDefaultBackupLocation\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? CbtStatus
            // GraphQL -> cbtStatus: Boolean! (scalar)
            if (this.CbtStatus == null && Exploration.Includes(parent + ".cbtStatus$"))
            {
                this.CbtStatus = new System.Boolean();
            }
            //      C# -> System.Int64? LogBackupFrequencyInSeconds
            // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
            if (this.LogBackupFrequencyInSeconds == null && Exploration.Includes(parent + ".logBackupFrequencyInSeconds$"))
            {
                this.LogBackupFrequencyInSeconds = new System.Int64();
            }
            //      C# -> System.Int32? LogRetentionTimeInHours
            // GraphQL -> logRetentionTimeInHours: Int (scalar)
            if (this.LogRetentionTimeInHours == null && Exploration.Includes(parent + ".logRetentionTimeInHours$"))
            {
                this.LogRetentionTimeInHours = new System.Int32();
            }
            //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
            // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
            if (this.ShouldUseDefaultBackupLocation == null && Exploration.Includes(parent + ".shouldUseDefaultBackupLocation$"))
            {
                this.ShouldUseDefaultBackupLocation = new System.Boolean();
            }
        }


    #endregion

    } // class UpdateMssqlDefaultPropertiesReply
    #endregion

    public static class ListUpdateMssqlDefaultPropertiesReplyExtensions
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
            this List<UpdateMssqlDefaultPropertiesReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateMssqlDefaultPropertiesReply> list, 
            String parent = "")
        {
            var item = new UpdateMssqlDefaultPropertiesReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types