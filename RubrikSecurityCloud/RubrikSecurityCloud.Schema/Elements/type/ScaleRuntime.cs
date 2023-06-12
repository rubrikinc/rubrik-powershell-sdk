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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ScaleRuntime
    public class ScaleRuntime: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (this.Deadline != null) {
            s += ind + "deadline\n" ;
        }
        //      C# -> System.Int32? NewCount
        // GraphQL -> newCount: Int! (scalar)
        if (this.NewCount != null) {
            s += ind + "newCount\n" ;
        }
        //      C# -> System.Int32? OldCount
        // GraphQL -> oldCount: Int! (scalar)
        if (this.OldCount != null) {
            s += ind + "oldCount\n" ;
        }
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        if (this.TaskchainUuid != null) {
            s += ind + "taskchainUuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? Deadline
        // GraphQL -> deadline: DateTime (scalar)
        if (this.Deadline == null && Exploration.Includes(parent + ".deadline", true))
        {
            this.Deadline = new DateTime();
        }
        //      C# -> System.Int32? NewCount
        // GraphQL -> newCount: Int! (scalar)
        if (this.NewCount == null && Exploration.Includes(parent + ".newCount", true))
        {
            this.NewCount = Int32.MinValue;
        }
        //      C# -> System.Int32? OldCount
        // GraphQL -> oldCount: Int! (scalar)
        if (this.OldCount == null && Exploration.Includes(parent + ".oldCount", true))
        {
            this.OldCount = Int32.MinValue;
        }
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: String! (scalar)
        if (this.TaskchainUuid == null && Exploration.Includes(parent + ".taskchainUuid", true))
        {
            this.TaskchainUuid = "FETCH";
        }
    }


    #endregion

    } // class ScaleRuntime
    
    #endregion

    public static class ListScaleRuntimeExtensions
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
            this List<ScaleRuntime> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ScaleRuntime> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ScaleRuntime());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types