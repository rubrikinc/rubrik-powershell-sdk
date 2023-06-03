// SnapshotResult.cs
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
    #region SnapshotResult
    public class SnapshotResult: BaseType
    {
        #region members

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        [JsonProperty("snapshotTime")]
        public System.Int64? SnapshotTime { get; set; }


        #endregion

    #region methods

    public SnapshotResult Set(
        System.String? SnapshotFid = null,
        System.Int64? SnapshotTime = null
    ) 
    {
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid", true))
        {
            this.SnapshotFid = new System.String("FETCH");
        }
        //      C# -> System.Int64? SnapshotTime
        // GraphQL -> snapshotTime: Long! (scalar)
        if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime", true))
        {
            this.SnapshotTime = new System.Int64();
        }
    }


    #endregion

    } // class SnapshotResult
    
    #endregion

    public static class ListSnapshotResultExtensions
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
            this List<SnapshotResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types