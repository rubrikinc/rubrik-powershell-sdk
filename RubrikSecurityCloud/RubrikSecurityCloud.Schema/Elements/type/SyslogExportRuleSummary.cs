// SyslogExportRuleSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:49.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region SyslogExportRuleSummary
    public class SyslogExportRuleSummary: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
            // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
            if (this.SyslogCertificateInfo != null)
            {
                 s += ind + "syslogCertificateInfo\n";

                 s += ind + "{\n" + 
                 this.SyslogCertificateInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
            // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
            if (this.SyslogExportRuleFull != null)
            {
                 s += ind + "syslogExportRuleFull\n";

                 s += ind + "{\n" + 
                 this.SyslogExportRuleFull.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> SyslogCertificateInfo? SyslogCertificateInfo
            // GraphQL -> syslogCertificateInfo: SyslogCertificateInfo (type)
            if (this.SyslogCertificateInfo == null && Exploration.Includes(parent + ".syslogCertificateInfo"))
            {
                this.SyslogCertificateInfo = new SyslogCertificateInfo();
                this.SyslogCertificateInfo.ApplyExploratoryFragment(parent + ".syslogCertificateInfo");
            }
            //      C# -> SyslogExportRuleFull? SyslogExportRuleFull
            // GraphQL -> syslogExportRuleFull: SyslogExportRuleFull (type)
            if (this.SyslogExportRuleFull == null && Exploration.Includes(parent + ".syslogExportRuleFull"))
            {
                this.SyslogExportRuleFull = new SyslogExportRuleFull();
                this.SyslogExportRuleFull.ApplyExploratoryFragment(parent + ".syslogExportRuleFull");
            }
        }


    #endregion

    } // class SyslogExportRuleSummary
    #endregion

    public static class ListSyslogExportRuleSummaryExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<SyslogExportRuleSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SyslogExportRuleSummary> list, 
            String parent = "")
        {
            var item = new SyslogExportRuleSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types