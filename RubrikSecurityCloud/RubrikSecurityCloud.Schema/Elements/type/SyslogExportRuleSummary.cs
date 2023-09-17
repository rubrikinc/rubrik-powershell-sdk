// SyslogExportRuleSummary.cs
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
    #region SyslogExportRuleSummary
    public class SyslogExportRuleSummary: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
        // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
        [JsonProperty("syslogCertificateInfo")]
        public SyslogCertificateInfo? SyslogCertificateInfo { get; set; }

        //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
        // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
        [JsonProperty("syslogExportRuleFull")]
        public SyslogExportRuleFull? SyslogExportRuleFull { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SyslogExportRuleSummary";
    }

    public SyslogExportRuleSummary Set(
        System.String? Id = null,
        SyslogCertificateInfo? SyslogCertificateInfo = null,
        SyslogExportRuleFull? SyslogExportRuleFull = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SyslogCertificateInfo != null ) {
            this.SyslogCertificateInfo = SyslogCertificateInfo;
        }
        if ( SyslogExportRuleFull != null ) {
            this.SyslogExportRuleFull = SyslogExportRuleFull;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
        // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
        if (this.SyslogCertificateInfo != null) {
            var fspec = this.SyslogCertificateInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "syslogCertificateInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
        // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
        if (this.SyslogExportRuleFull != null) {
            var fspec = this.SyslogExportRuleFull.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "syslogExportRuleFull {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
        // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
        if (this.SyslogCertificateInfo == null && ec.Includes("syslogCertificateInfo",false))
        {
            this.SyslogCertificateInfo = new SyslogCertificateInfo();
            this.SyslogCertificateInfo.ApplyExploratoryFieldSpec(ec.NewChild("syslogCertificateInfo"));
        }
        //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
        // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
        if (this.SyslogExportRuleFull == null && ec.Includes("syslogExportRuleFull",false))
        {
            this.SyslogExportRuleFull = new SyslogExportRuleFull();
            this.SyslogExportRuleFull.ApplyExploratoryFieldSpec(ec.NewChild("syslogExportRuleFull"));
        }
    }


    #endregion

    } // class SyslogExportRuleSummary
    
    #endregion

    public static class ListSyslogExportRuleSummaryExtensions
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
            this List<SyslogExportRuleSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SyslogExportRuleSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SyslogExportRuleSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SyslogExportRuleSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types