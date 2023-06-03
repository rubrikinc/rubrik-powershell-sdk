// MissedSnapshotCommon.cs
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
    #region MissedSnapshotCommon
    public class MissedSnapshotCommon: BaseType
    {
        #region members

        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        [JsonProperty("archivalLocationType")]
        public List<System.String>? ArchivalLocationType { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }


        #endregion

    #region methods

    public MissedSnapshotCommon Set(
        List<System.String>? ArchivalLocationType = null,
        DateTime? Date = null
    ) 
    {
        if ( ArchivalLocationType != null ) {
            this.ArchivalLocationType = ArchivalLocationType;
        }
        if ( Date != null ) {
            this.Date = Date;
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
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        if (this.ArchivalLocationType != null) {
            s += ind + "archivalLocationType\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        if (this.ArchivalLocationType == null && Exploration.Includes(parent + ".archivalLocationType", true))
        {
            this.ArchivalLocationType = new List<System.String>();
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime! (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
    }


    #endregion

    } // class MissedSnapshotCommon
    
    #endregion

    public static class ListMissedSnapshotCommonExtensions
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
            this List<MissedSnapshotCommon> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MissedSnapshotCommon> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MissedSnapshotCommon());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types