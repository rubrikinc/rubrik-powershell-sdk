// NcdUsageOverTimeData.cs
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
    #region NcdUsageOverTimeData
    public class NcdUsageOverTimeData: BaseType
    {
        #region members

        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        [JsonProperty("changeInBytes")]
        public System.Int64? ChangeInBytes { get; set; }

        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        [JsonProperty("newInBytes")]
        public System.Int64? NewInBytes { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdUsageOverTimeData";
    }

    public NcdUsageOverTimeData Set(
        System.Int64? ChangeInBytes = null,
        System.Int64? NewInBytes = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( ChangeInBytes != null ) {
            this.ChangeInBytes = ChangeInBytes;
        }
        if ( NewInBytes != null ) {
            this.NewInBytes = NewInBytes;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        if (this.ChangeInBytes != null) {
            s += ind + "changeInBytes\n" ;
        }
        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        if (this.NewInBytes != null) {
            s += ind + "newInBytes\n" ;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ChangeInBytes
        // GraphQL -> changeInBytes: Long! (scalar)
        if (this.ChangeInBytes == null && ec.Includes("changeInBytes",true))
        {
            this.ChangeInBytes = new System.Int64();
        }
        //      C# -> System.Int64? NewInBytes
        // GraphQL -> newInBytes: Long! (scalar)
        if (this.NewInBytes == null && ec.Includes("newInBytes",true))
        {
            this.NewInBytes = new System.Int64();
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp == null && ec.Includes("timestamp",true))
        {
            this.Timestamp = new DateTime();
        }
    }


    #endregion

    } // class NcdUsageOverTimeData
    
    #endregion

    public static class ListNcdUsageOverTimeDataExtensions
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
            this List<NcdUsageOverTimeData> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdUsageOverTimeData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdUsageOverTimeData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NcdUsageOverTimeData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types