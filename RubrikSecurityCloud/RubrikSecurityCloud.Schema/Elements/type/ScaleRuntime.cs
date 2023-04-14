// ScaleRuntime.cs
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
    #region ScaleRuntime
    public class ScaleRuntime: IFragment
    {
        #region members
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        [JsonProperty("deadline")]
        public DateTime? Deadline { get; set; }

        //      C# -> System.Int32? NewCount
        // GraphQL -> newCount: Int! (scalar)
        [JsonProperty("newCount")]
        public System.Int32? NewCount { get; set; }

        //      C# -> System.Int32? OldCount
        // GraphQL -> oldCount: Int! (scalar)
        [JsonProperty("oldCount")]
        public System.Int32? OldCount { get; set; }

        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        [JsonProperty("taskchainUuid")]
        public System.String? TaskchainUuid { get; set; }

        #endregion

    #region methods

    public ScaleRuntime Set(
        DateTime? Deadline = null,
        System.Int32? NewCount = null,
        System.Int32? OldCount = null,
        System.String? TaskchainUuid = null
    ) 
    {
        if ( Deadline != null ) {
            this.Deadline = Deadline;
        }
        if ( NewCount != null ) {
            this.NewCount = NewCount;
        }
        if ( OldCount != null ) {
            this.OldCount = OldCount;
        }
        if ( TaskchainUuid != null ) {
            this.TaskchainUuid = TaskchainUuid;
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
            //      C# -> DateTime? Deadline
            // GraphQL -> deadline: DateTime (scalar)
            if (this.Deadline != null)
            {
                 s += ind + "deadline\n";

            }
            //      C# -> System.Int32? NewCount
            // GraphQL -> newCount: Int! (scalar)
            if (this.NewCount != null)
            {
                 s += ind + "newCount\n";

            }
            //      C# -> System.Int32? OldCount
            // GraphQL -> oldCount: Int! (scalar)
            if (this.OldCount != null)
            {
                 s += ind + "oldCount\n";

            }
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: String! (scalar)
            if (this.TaskchainUuid != null)
            {
                 s += ind + "taskchainUuid\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? Deadline
            // GraphQL -> deadline: DateTime (scalar)
            if (this.Deadline == null && Exploration.Includes(parent + ".deadline$"))
            {
                this.Deadline = new DateTime();
            }
            //      C# -> System.Int32? NewCount
            // GraphQL -> newCount: Int! (scalar)
            if (this.NewCount == null && Exploration.Includes(parent + ".newCount$"))
            {
                this.NewCount = new System.Int32();
            }
            //      C# -> System.Int32? OldCount
            // GraphQL -> oldCount: Int! (scalar)
            if (this.OldCount == null && Exploration.Includes(parent + ".oldCount$"))
            {
                this.OldCount = new System.Int32();
            }
            //      C# -> System.String? TaskchainUuid
            // GraphQL -> taskchainUuid: String! (scalar)
            if (this.TaskchainUuid == null && Exploration.Includes(parent + ".taskchainUuid$"))
            {
                this.TaskchainUuid = new System.String("FETCH");
            }
        }


    #endregion

    } // class ScaleRuntime
    #endregion

    public static class ListScaleRuntimeExtensions
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
            this List<ScaleRuntime> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ScaleRuntime> list, 
            String parent = "")
        {
            var item = new ScaleRuntime();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types