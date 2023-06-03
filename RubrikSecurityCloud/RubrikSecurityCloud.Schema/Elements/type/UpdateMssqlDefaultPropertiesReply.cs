// UpdateMssqlDefaultPropertiesReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateMssqlDefaultPropertiesReply
    public class UpdateMssqlDefaultPropertiesReply: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        if (this.CbtStatus != null) {
            s += ind + "cbtStatus\n" ;
        }
        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        if (this.LogBackupFrequencyInSeconds != null) {
            s += ind + "logBackupFrequencyInSeconds\n" ;
        }
        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        if (this.LogRetentionTimeInHours != null) {
            s += ind + "logRetentionTimeInHours\n" ;
        }
        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        if (this.ShouldUseDefaultBackupLocation != null) {
            s += ind + "shouldUseDefaultBackupLocation\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        if (this.CbtStatus == null && Exploration.Includes(parent + ".cbtStatus", true))
        {
            this.CbtStatus = true;
        }
        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        if (this.LogBackupFrequencyInSeconds == null && Exploration.Includes(parent + ".logBackupFrequencyInSeconds", true))
        {
            this.LogBackupFrequencyInSeconds = new System.Int64();
        }
        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        if (this.LogRetentionTimeInHours == null && Exploration.Includes(parent + ".logRetentionTimeInHours", true))
        {
            this.LogRetentionTimeInHours = new System.Int32();
        }
        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        if (this.ShouldUseDefaultBackupLocation == null && Exploration.Includes(parent + ".shouldUseDefaultBackupLocation", true))
        {
            this.ShouldUseDefaultBackupLocation = true;
        }
    }


    #endregion

    } // class UpdateMssqlDefaultPropertiesReply
    
    #endregion

    public static class ListUpdateMssqlDefaultPropertiesReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<UpdateMssqlDefaultPropertiesReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateMssqlDefaultPropertiesReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateMssqlDefaultPropertiesReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types