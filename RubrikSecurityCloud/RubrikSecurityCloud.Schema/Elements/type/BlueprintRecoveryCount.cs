// BlueprintRecoveryCount.cs
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
    #region BlueprintRecoveryCount
    public class BlueprintRecoveryCount: BaseType
    {
        #region members

        //      C# -> System.Int64? FailoverRecoveryCount
        // GraphQL -> failoverRecoveryCount: Long! (scalar)
        [JsonProperty("failoverRecoveryCount")]
        public System.Int64? FailoverRecoveryCount { get; set; }

        //      C# -> System.Int64? IsolatedRecoveryCount
        // GraphQL -> isolatedRecoveryCount: Long! (scalar)
        [JsonProperty("isolatedRecoveryCount")]
        public System.Int64? IsolatedRecoveryCount { get; set; }

        //      C# -> System.Int64? LocalRecoveryCount
        // GraphQL -> localRecoveryCount: Long! (scalar)
        [JsonProperty("localRecoveryCount")]
        public System.Int64? LocalRecoveryCount { get; set; }

        //      C# -> System.Int64? TestFailoverRecoveryCount
        // GraphQL -> testFailoverRecoveryCount: Long! (scalar)
        [JsonProperty("testFailoverRecoveryCount")]
        public System.Int64? TestFailoverRecoveryCount { get; set; }


        #endregion

    #region methods

    public BlueprintRecoveryCount Set(
        System.Int64? FailoverRecoveryCount = null,
        System.Int64? IsolatedRecoveryCount = null,
        System.Int64? LocalRecoveryCount = null,
        System.Int64? TestFailoverRecoveryCount = null
    ) 
    {
        if ( FailoverRecoveryCount != null ) {
            this.FailoverRecoveryCount = FailoverRecoveryCount;
        }
        if ( IsolatedRecoveryCount != null ) {
            this.IsolatedRecoveryCount = IsolatedRecoveryCount;
        }
        if ( LocalRecoveryCount != null ) {
            this.LocalRecoveryCount = LocalRecoveryCount;
        }
        if ( TestFailoverRecoveryCount != null ) {
            this.TestFailoverRecoveryCount = TestFailoverRecoveryCount;
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
        //      C# -> System.Int64? FailoverRecoveryCount
        // GraphQL -> failoverRecoveryCount: Long! (scalar)
        if (this.FailoverRecoveryCount != null) {
            s += ind + "failoverRecoveryCount\n" ;
        }
        //      C# -> System.Int64? IsolatedRecoveryCount
        // GraphQL -> isolatedRecoveryCount: Long! (scalar)
        if (this.IsolatedRecoveryCount != null) {
            s += ind + "isolatedRecoveryCount\n" ;
        }
        //      C# -> System.Int64? LocalRecoveryCount
        // GraphQL -> localRecoveryCount: Long! (scalar)
        if (this.LocalRecoveryCount != null) {
            s += ind + "localRecoveryCount\n" ;
        }
        //      C# -> System.Int64? TestFailoverRecoveryCount
        // GraphQL -> testFailoverRecoveryCount: Long! (scalar)
        if (this.TestFailoverRecoveryCount != null) {
            s += ind + "testFailoverRecoveryCount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? FailoverRecoveryCount
        // GraphQL -> failoverRecoveryCount: Long! (scalar)
        if (this.FailoverRecoveryCount == null && Exploration.Includes(parent + ".failoverRecoveryCount", true))
        {
            this.FailoverRecoveryCount = new System.Int64();
        }
        //      C# -> System.Int64? IsolatedRecoveryCount
        // GraphQL -> isolatedRecoveryCount: Long! (scalar)
        if (this.IsolatedRecoveryCount == null && Exploration.Includes(parent + ".isolatedRecoveryCount", true))
        {
            this.IsolatedRecoveryCount = new System.Int64();
        }
        //      C# -> System.Int64? LocalRecoveryCount
        // GraphQL -> localRecoveryCount: Long! (scalar)
        if (this.LocalRecoveryCount == null && Exploration.Includes(parent + ".localRecoveryCount", true))
        {
            this.LocalRecoveryCount = new System.Int64();
        }
        //      C# -> System.Int64? TestFailoverRecoveryCount
        // GraphQL -> testFailoverRecoveryCount: Long! (scalar)
        if (this.TestFailoverRecoveryCount == null && Exploration.Includes(parent + ".testFailoverRecoveryCount", true))
        {
            this.TestFailoverRecoveryCount = new System.Int64();
        }
    }


    #endregion

    } // class BlueprintRecoveryCount
    
    #endregion

    public static class ListBlueprintRecoveryCountExtensions
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
            this List<BlueprintRecoveryCount> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintRecoveryCount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintRecoveryCount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types