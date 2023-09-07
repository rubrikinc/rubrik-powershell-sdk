// DailyOrgBackupJobInformation.cs
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
    #region DailyOrgBackupJobInformation
    public class DailyOrgBackupJobInformation: BaseType
    {
        #region members

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> List<JobStateCounts>? Counts
        // GraphQL -> counts: [JobStateCounts!]! (type)
        [JsonProperty("counts")]
        public List<JobStateCounts>? Counts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DailyOrgBackupJobInformation";
    }

    public DailyOrgBackupJobInformation Set(
        DateTime? StartTime = null,
        List<JobStateCounts>? Counts = null
    ) 
    {
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Counts != null ) {
            this.Counts = Counts;
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
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> List<JobStateCounts>? Counts
        // GraphQL -> counts: [JobStateCounts!]! (type)
        if (this.Counts != null) {
            var fspec = this.Counts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "counts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && ec.Includes("startTime",true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> List<JobStateCounts>? Counts
        // GraphQL -> counts: [JobStateCounts!]! (type)
        if (this.Counts == null && ec.Includes("counts",false))
        {
            this.Counts = new List<JobStateCounts>();
            this.Counts.ApplyExploratoryFieldSpec(ec.NewChild("counts"));
        }
    }


    #endregion

    } // class DailyOrgBackupJobInformation
    
    #endregion

    public static class ListDailyOrgBackupJobInformationExtensions
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
            this List<DailyOrgBackupJobInformation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DailyOrgBackupJobInformation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyOrgBackupJobInformation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<DailyOrgBackupJobInformation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types