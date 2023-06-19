// NcdSlaComplianceData.cs
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
    #region NcdSlaComplianceData
    public class NcdSlaComplianceData: BaseType
    {
        #region members

        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        [JsonProperty("jobsFailing")]
        public System.Int32? JobsFailing { get; set; }

        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        [JsonProperty("jobsPassing")]
        public System.Int32? JobsPassing { get; set; }

        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        [JsonProperty("timestamp")]
        public DateTime? Timestamp { get; set; }


        #endregion

    #region methods

    public NcdSlaComplianceData Set(
        System.Int32? JobsFailing = null,
        System.Int32? JobsPassing = null,
        DateTime? Timestamp = null
    ) 
    {
        if ( JobsFailing != null ) {
            this.JobsFailing = JobsFailing;
        }
        if ( JobsPassing != null ) {
            this.JobsPassing = JobsPassing;
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
        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        if (this.JobsFailing != null) {
            s += ind + "jobsFailing\n" ;
        }
        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        if (this.JobsPassing != null) {
            s += ind + "jobsPassing\n" ;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp != null) {
            s += ind + "timestamp\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? JobsFailing
        // GraphQL -> jobsFailing: Int! (scalar)
        if (this.JobsFailing == null && Exploration.Includes(parent + ".jobsFailing", true))
        {
            this.JobsFailing = Int32.MinValue;
        }
        //      C# -> System.Int32? JobsPassing
        // GraphQL -> jobsPassing: Int! (scalar)
        if (this.JobsPassing == null && Exploration.Includes(parent + ".jobsPassing", true))
        {
            this.JobsPassing = Int32.MinValue;
        }
        //      C# -> DateTime? Timestamp
        // GraphQL -> timestamp: DateTime (scalar)
        if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp", true))
        {
            this.Timestamp = new DateTime();
        }
    }


    #endregion

    } // class NcdSlaComplianceData
    
    #endregion

    public static class ListNcdSlaComplianceDataExtensions
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
            this List<NcdSlaComplianceData> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdSlaComplianceData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdSlaComplianceData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types