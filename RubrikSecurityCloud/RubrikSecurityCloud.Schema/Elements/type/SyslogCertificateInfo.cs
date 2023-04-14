// SyslogCertificateInfo.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region SyslogCertificateInfo
    public class SyslogCertificateInfo: IFragment
    {
        #region members
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        [JsonProperty("serverCertificate")]
        public System.String? ServerCertificate { get; set; }

        //      C# -> System.String? ServerCertificateName
        // GraphQL -> serverCertificateName: String (scalar)
        [JsonProperty("serverCertificateName")]
        public System.String? ServerCertificateName { get; set; }

        #endregion

    #region methods

    public SyslogCertificateInfo Set(
        System.String? ServerCertificate = null,
        System.String? ServerCertificateName = null
    ) 
    {
        if ( ServerCertificate != null ) {
            this.ServerCertificate = ServerCertificate;
        }
        if ( ServerCertificateName != null ) {
            this.ServerCertificateName = ServerCertificateName;
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
            //      C# -> System.String? ServerCertificate
            // GraphQL -> serverCertificate: String (scalar)
            if (this.ServerCertificate != null)
            {
                 s += ind + "serverCertificate\n";

            }
            //      C# -> System.String? ServerCertificateName
            // GraphQL -> serverCertificateName: String (scalar)
            if (this.ServerCertificateName != null)
            {
                 s += ind + "serverCertificateName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ServerCertificate
            // GraphQL -> serverCertificate: String (scalar)
            if (this.ServerCertificate == null && Exploration.Includes(parent + ".serverCertificate$"))
            {
                this.ServerCertificate = new System.String("FETCH");
            }
            //      C# -> System.String? ServerCertificateName
            // GraphQL -> serverCertificateName: String (scalar)
            if (this.ServerCertificateName == null && Exploration.Includes(parent + ".serverCertificateName$"))
            {
                this.ServerCertificateName = new System.String("FETCH");
            }
        }


    #endregion

    } // class SyslogCertificateInfo
    #endregion

    public static class ListSyslogCertificateInfoExtensions
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
            this List<SyslogCertificateInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SyslogCertificateInfo> list, 
            String parent = "")
        {
            var item = new SyslogCertificateInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types