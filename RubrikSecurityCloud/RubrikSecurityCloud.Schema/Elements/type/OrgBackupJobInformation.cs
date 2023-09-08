// OrgBackupJobInformation.cs
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
    #region OrgBackupJobInformation
    public class OrgBackupJobInformation: BaseType
    {
        #region members

        //      C# -> List<DailyOrgBackupJobInformation>? PerDayJobInfo
        // GraphQL -> perDayJobInfo: [DailyOrgBackupJobInformation!]! (type)
        [JsonProperty("perDayJobInfo")]
        public List<DailyOrgBackupJobInformation>? PerDayJobInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OrgBackupJobInformation";
    }

    public OrgBackupJobInformation Set(
        List<DailyOrgBackupJobInformation>? PerDayJobInfo = null
    ) 
    {
        if ( PerDayJobInfo != null ) {
            this.PerDayJobInfo = PerDayJobInfo;
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
        //      C# -> List<DailyOrgBackupJobInformation>? PerDayJobInfo
        // GraphQL -> perDayJobInfo: [DailyOrgBackupJobInformation!]! (type)
        if (this.PerDayJobInfo != null) {
            var fspec = this.PerDayJobInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "perDayJobInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DailyOrgBackupJobInformation>? PerDayJobInfo
        // GraphQL -> perDayJobInfo: [DailyOrgBackupJobInformation!]! (type)
        if (this.PerDayJobInfo == null && ec.Includes("perDayJobInfo",false))
        {
            this.PerDayJobInfo = new List<DailyOrgBackupJobInformation>();
            this.PerDayJobInfo.ApplyExploratoryFieldSpec(ec.NewChild("perDayJobInfo"));
        }
    }


    #endregion

    } // class OrgBackupJobInformation
    
    #endregion

    public static class ListOrgBackupJobInformationExtensions
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
            this List<OrgBackupJobInformation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OrgBackupJobInformation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OrgBackupJobInformation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<OrgBackupJobInformation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types