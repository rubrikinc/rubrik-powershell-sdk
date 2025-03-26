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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<BackupTaskDiagnosticInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BackupTaskDiagnosticInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BackupTaskDiagnosticInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BackupTaskDiagnosticInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BackupTaskDiagnosticInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types