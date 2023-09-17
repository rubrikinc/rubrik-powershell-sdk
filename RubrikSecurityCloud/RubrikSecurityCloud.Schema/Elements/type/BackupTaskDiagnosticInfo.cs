// BackupTaskDiagnosticInfo.cs
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
    #region BackupTaskDiagnosticInfo
    public class BackupTaskDiagnosticInfo: BaseType
    {
        #region members

        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        [JsonProperty("taskStatus")]
        public DiagnosticTaskStatus? TaskStatus { get; set; }

        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        [JsonProperty("expectedEndTime")]
        public DateTime? ExpectedEndTime { get; set; }

        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        [JsonProperty("queueTime")]
        public DateTime? QueueTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BackupTaskDiagnosticInfo";
    }

    public BackupTaskDiagnosticInfo Set(
        DiagnosticTaskStatus? TaskStatus = null,
        DateTime? ExpectedEndTime = null,
        DateTime? QueueTime = null
    ) 
    {
        if ( TaskStatus != null ) {
            this.TaskStatus = TaskStatus;
        }
        if ( ExpectedEndTime != null ) {
            this.ExpectedEndTime = ExpectedEndTime;
        }
        if ( QueueTime != null ) {
            this.QueueTime = QueueTime;
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
        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        if (this.TaskStatus != null) {
            s += ind + "taskStatus\n" ;
        }
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        if (this.ExpectedEndTime != null) {
            s += ind + "expectedEndTime\n" ;
        }
        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        if (this.QueueTime != null) {
            s += ind + "queueTime\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        if (this.TaskStatus == null && ec.Includes("taskStatus",true))
        {
            this.TaskStatus = new DiagnosticTaskStatus();
        }
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        if (this.ExpectedEndTime == null && ec.Includes("expectedEndTime",true))
        {
            this.ExpectedEndTime = new DateTime();
        }
        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        if (this.QueueTime == null && ec.Includes("queueTime",true))
        {
            this.QueueTime = new DateTime();
        }
    }


    #endregion

    } // class BackupTaskDiagnosticInfo
    
    #endregion

    public static class ListBackupTaskDiagnosticInfoExtensions
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
            this List<BackupTaskDiagnosticInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BackupTaskDiagnosticInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupTaskDiagnosticInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupTaskDiagnosticInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types