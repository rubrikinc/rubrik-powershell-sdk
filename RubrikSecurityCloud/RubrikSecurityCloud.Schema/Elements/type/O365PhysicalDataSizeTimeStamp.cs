// O365PhysicalDataSizeTimeStamp.cs
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
    #region O365PhysicalDataSizeTimeStamp
    public class O365PhysicalDataSizeTimeStamp: BaseType
    {
        #region members

        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        [JsonProperty("physicalDataSizeInBytes")]
        public System.Int64? PhysicalDataSizeInBytes { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365PhysicalDataSizeTimeStamp";
    }

    public O365PhysicalDataSizeTimeStamp Set(
        System.Int64? PhysicalDataSizeInBytes = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( PhysicalDataSizeInBytes != null ) {
            this.PhysicalDataSizeInBytes = PhysicalDataSizeInBytes;
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
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (this.PhysicalDataSizeInBytes != null) {
            s += ind + "physicalDataSizeInBytes\n" ;
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
        //      C# -> System.Int64? PhysicalDataSizeInBytes
        // GraphQL -> physicalDataSizeInBytes: Long! (scalar)
        if (this.PhysicalDataSizeInBytes == null && ec.Includes("physicalDataSizeInBytes",true))
        {
            this.PhysicalDataSizeInBytes = new System.Int64();
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp == null && ec.Includes("timestamp",true))
        {
            this.Timestamp = new DateTime();
        }
    }


    #endregion

    } // class O365PhysicalDataSizeTimeStamp
    
    #endregion

    public static class ListO365PhysicalDataSizeTimeStampExtensions
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
            this List<O365PhysicalDataSizeTimeStamp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365PhysicalDataSizeTimeStamp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365PhysicalDataSizeTimeStamp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<O365PhysicalDataSizeTimeStamp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types