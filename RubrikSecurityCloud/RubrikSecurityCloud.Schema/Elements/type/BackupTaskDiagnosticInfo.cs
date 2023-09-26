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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        if (this.TaskStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskStatus\n" ;
            } else {
                s += ind + "taskStatus\n" ;
            }
        }
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        if (this.ExpectedEndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expectedEndTime\n" ;
            } else {
                s += ind + "expectedEndTime\n" ;
            }
        }
        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        if (this.QueueTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "queueTime\n" ;
            } else {
                s += ind + "queueTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        if (ec.Includes("taskStatus",true))
        {
            if(this.TaskStatus == null) {

                this.TaskStatus = new DiagnosticTaskStatus();

            } else {


            }
        }
        else if (this.TaskStatus != null && ec.Excludes("taskStatus",true))
        {
            this.TaskStatus = null;
        }
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        if (ec.Includes("expectedEndTime",true))
        {
            if(this.ExpectedEndTime == null) {

                this.ExpectedEndTime = new DateTime();

            } else {


            }
        }
        else if (this.ExpectedEndTime != null && ec.Excludes("expectedEndTime",true))
        {
            this.ExpectedEndTime = null;
        }
        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        if (ec.Includes("queueTime",true))
        {
            if(this.QueueTime == null) {

                this.QueueTime = new DateTime();

            } else {


            }
        }
        else if (this.QueueTime != null && ec.Excludes("queueTime",true))
        {
            this.QueueTime = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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