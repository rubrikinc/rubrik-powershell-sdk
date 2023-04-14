// RbaInstallerUrls.cs
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
    #region RbaInstallerUrls
    public class RbaInstallerUrls: IFragment
    {
        #region members
        //      C# -> System.String? DebianHashSha256
        // GraphQL -> debianHashSha256: String! (scalar)
        [JsonProperty("debianHashSha256")]
        public System.String? DebianHashSha256 { get; set; }

        //      C# -> System.String? DebianUrl
        // GraphQL -> debianUrl: String! (scalar)
        [JsonProperty("debianUrl")]
        public System.String? DebianUrl { get; set; }

        //      C# -> System.String? RpmHashSha256
        // GraphQL -> rpmHashSha256: String! (scalar)
        [JsonProperty("rpmHashSha256")]
        public System.String? RpmHashSha256 { get; set; }

        //      C# -> System.String? RpmUrl
        // GraphQL -> rpmUrl: String! (scalar)
        [JsonProperty("rpmUrl")]
        public System.String? RpmUrl { get; set; }

        //      C# -> System.String? WindowsHashSha256
        // GraphQL -> windowsHashSha256: String! (scalar)
        [JsonProperty("windowsHashSha256")]
        public System.String? WindowsHashSha256 { get; set; }

        //      C# -> System.String? WindowsUrl
        // GraphQL -> windowsUrl: String! (scalar)
        [JsonProperty("windowsUrl")]
        public System.String? WindowsUrl { get; set; }

        #endregion

    #region methods

    public RbaInstallerUrls Set(
        System.String? DebianHashSha256 = null,
        System.String? DebianUrl = null,
        System.String? RpmHashSha256 = null,
        System.String? RpmUrl = null,
        System.String? WindowsHashSha256 = null,
        System.String? WindowsUrl = null
    ) 
    {
        if ( DebianHashSha256 != null ) {
            this.DebianHashSha256 = DebianHashSha256;
        }
        if ( DebianUrl != null ) {
            this.DebianUrl = DebianUrl;
        }
        if ( RpmHashSha256 != null ) {
            this.RpmHashSha256 = RpmHashSha256;
        }
        if ( RpmUrl != null ) {
            this.RpmUrl = RpmUrl;
        }
        if ( WindowsHashSha256 != null ) {
            this.WindowsHashSha256 = WindowsHashSha256;
        }
        if ( WindowsUrl != null ) {
            this.WindowsUrl = WindowsUrl;
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
            //      C# -> System.String? DebianHashSha256
            // GraphQL -> debianHashSha256: String! (scalar)
            if (this.DebianHashSha256 != null)
            {
                 s += ind + "debianHashSha256\n";

            }
            //      C# -> System.String? DebianUrl
            // GraphQL -> debianUrl: String! (scalar)
            if (this.DebianUrl != null)
            {
                 s += ind + "debianUrl\n";

            }
            //      C# -> System.String? RpmHashSha256
            // GraphQL -> rpmHashSha256: String! (scalar)
            if (this.RpmHashSha256 != null)
            {
                 s += ind + "rpmHashSha256\n";

            }
            //      C# -> System.String? RpmUrl
            // GraphQL -> rpmUrl: String! (scalar)
            if (this.RpmUrl != null)
            {
                 s += ind + "rpmUrl\n";

            }
            //      C# -> System.String? WindowsHashSha256
            // GraphQL -> windowsHashSha256: String! (scalar)
            if (this.WindowsHashSha256 != null)
            {
                 s += ind + "windowsHashSha256\n";

            }
            //      C# -> System.String? WindowsUrl
            // GraphQL -> windowsUrl: String! (scalar)
            if (this.WindowsUrl != null)
            {
                 s += ind + "windowsUrl\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DebianHashSha256
            // GraphQL -> debianHashSha256: String! (scalar)
            if (this.DebianHashSha256 == null && Exploration.Includes(parent + ".debianHashSha256$"))
            {
                this.DebianHashSha256 = new System.String("FETCH");
            }
            //      C# -> System.String? DebianUrl
            // GraphQL -> debianUrl: String! (scalar)
            if (this.DebianUrl == null && Exploration.Includes(parent + ".debianUrl$"))
            {
                this.DebianUrl = new System.String("FETCH");
            }
            //      C# -> System.String? RpmHashSha256
            // GraphQL -> rpmHashSha256: String! (scalar)
            if (this.RpmHashSha256 == null && Exploration.Includes(parent + ".rpmHashSha256$"))
            {
                this.RpmHashSha256 = new System.String("FETCH");
            }
            //      C# -> System.String? RpmUrl
            // GraphQL -> rpmUrl: String! (scalar)
            if (this.RpmUrl == null && Exploration.Includes(parent + ".rpmUrl$"))
            {
                this.RpmUrl = new System.String("FETCH");
            }
            //      C# -> System.String? WindowsHashSha256
            // GraphQL -> windowsHashSha256: String! (scalar)
            if (this.WindowsHashSha256 == null && Exploration.Includes(parent + ".windowsHashSha256$"))
            {
                this.WindowsHashSha256 = new System.String("FETCH");
            }
            //      C# -> System.String? WindowsUrl
            // GraphQL -> windowsUrl: String! (scalar)
            if (this.WindowsUrl == null && Exploration.Includes(parent + ".windowsUrl$"))
            {
                this.WindowsUrl = new System.String("FETCH");
            }
        }


    #endregion

    } // class RbaInstallerUrls
    #endregion

    public static class ListRbaInstallerUrlsExtensions
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
            this List<RbaInstallerUrls> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RbaInstallerUrls> list, 
            String parent = "")
        {
            var item = new RbaInstallerUrls();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types