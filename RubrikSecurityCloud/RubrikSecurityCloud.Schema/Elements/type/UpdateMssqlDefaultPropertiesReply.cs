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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "UpdateMssqlDefaultPropertiesReply";
    }

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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? CbtStatus
        // GraphQL -> cbtStatus: Boolean! (scalar)
        if (this.CbtStatus == null && ec.Includes("cbtStatus",true))
        {
            this.CbtStatus = true;
        }
        //      C# -> System.Int64? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Long! (scalar)
        if (this.LogBackupFrequencyInSeconds == null && ec.Includes("logBackupFrequencyInSeconds",true))
        {
            this.LogBackupFrequencyInSeconds = new System.Int64();
        }
        //      C# -> System.Int32? LogRetentionTimeInHours
        // GraphQL -> logRetentionTimeInHours: Int (scalar)
        if (this.LogRetentionTimeInHours == null && ec.Includes("logRetentionTimeInHours",true))
        {
            this.LogRetentionTimeInHours = Int32.MinValue;
        }
        //      C# -> System.Boolean? ShouldUseDefaultBackupLocation
        // GraphQL -> shouldUseDefaultBackupLocation: Boolean (scalar)
        if (this.ShouldUseDefaultBackupLocation == null && ec.Includes("shouldUseDefaultBackupLocation",true))
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateMssqlDefaultPropertiesReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateMssqlDefaultPropertiesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateMssqlDefaultPropertiesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types