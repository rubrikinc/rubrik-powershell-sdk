// BackupTaskDiagnosticInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    #region BackupTaskDiagnosticInfo
    public class BackupTaskDiagnosticInfo: IFragment
    {
        #region members
        //      C# -> DateTime? ExpectedEndTime
        // GraphQL -> expectedEndTime: DateTime (scalar)
        [JsonProperty("expectedEndTime")]
        public DateTime? ExpectedEndTime { get; set; }

        //      C# -> DateTime? QueueTime
        // GraphQL -> queueTime: DateTime (scalar)
        [JsonProperty("queueTime")]
        public DateTime? QueueTime { get; set; }

        //      C# -> DiagnosticTaskStatus? TaskStatus
        // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
        [JsonProperty("taskStatus")]
        public DiagnosticTaskStatus? TaskStatus { get; set; }

        #endregion

    #region methods

    public BackupTaskDiagnosticInfo Set(
        DateTime? ExpectedEndTime = null,
        DateTime? QueueTime = null,
        DiagnosticTaskStatus? TaskStatus = null
    ) 
    {
        if ( ExpectedEndTime != null ) {
            this.ExpectedEndTime = ExpectedEndTime;
        }
        if ( QueueTime != null ) {
            this.QueueTime = QueueTime;
        }
        if ( TaskStatus != null ) {
            this.TaskStatus = TaskStatus;
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
            //      C# -> DateTime? ExpectedEndTime
            // GraphQL -> expectedEndTime: DateTime (scalar)
            if (this.ExpectedEndTime != null)
            {
                 s += ind + "expectedEndTime\n";

            }
            //      C# -> DateTime? QueueTime
            // GraphQL -> queueTime: DateTime (scalar)
            if (this.QueueTime != null)
            {
                 s += ind + "queueTime\n";

            }
            //      C# -> DiagnosticTaskStatus? TaskStatus
            // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
            if (this.TaskStatus != null)
            {
                 s += ind + "taskStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ExpectedEndTime
            // GraphQL -> expectedEndTime: DateTime (scalar)
            if (this.ExpectedEndTime == null && Exploration.Includes(parent + ".expectedEndTime$"))
            {
                this.ExpectedEndTime = new DateTime();
            }
            //      C# -> DateTime? QueueTime
            // GraphQL -> queueTime: DateTime (scalar)
            if (this.QueueTime == null && Exploration.Includes(parent + ".queueTime$"))
            {
                this.QueueTime = new DateTime();
            }
            //      C# -> DiagnosticTaskStatus? TaskStatus
            // GraphQL -> taskStatus: DiagnosticTaskStatus! (enum)
            if (this.TaskStatus == null && Exploration.Includes(parent + ".taskStatus$"))
            {
                this.TaskStatus = new DiagnosticTaskStatus();
            }
        }


    #endregion

    } // class BackupTaskDiagnosticInfo
    #endregion

    public static class ListBackupTaskDiagnosticInfoExtensions
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
            this List<BackupTaskDiagnosticInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<BackupTaskDiagnosticInfo> list, 
            String parent = "")
        {
            var item = new BackupTaskDiagnosticInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types