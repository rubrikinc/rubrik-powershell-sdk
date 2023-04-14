// CassandraSslOptions.cs
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
    #region CassandraSslOptions
    public class CassandraSslOptions: IFragment
    {
        #region members
        //      C# -> System.Boolean? Ssl
        // GraphQL -> ssl: Boolean! (scalar)
        [JsonProperty("ssl")]
        public System.Boolean? Ssl { get; set; }

        //      C# -> System.String? SslCaCerts
        // GraphQL -> sslCaCerts: String! (scalar)
        [JsonProperty("sslCaCerts")]
        public System.String? SslCaCerts { get; set; }

        //      C# -> System.String? SslCertfile
        // GraphQL -> sslCertfile: String! (scalar)
        [JsonProperty("sslCertfile")]
        public System.String? SslCertfile { get; set; }

        //      C# -> System.String? SslKeyfile
        // GraphQL -> sslKeyfile: String! (scalar)
        [JsonProperty("sslKeyfile")]
        public System.String? SslKeyfile { get; set; }

        //      C# -> SourceSslCertReqs? SslCertRequirements
        // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
        [JsonProperty("sslCertRequirements")]
        public SourceSslCertReqs? SslCertRequirements { get; set; }

        #endregion

    #region methods

    public CassandraSslOptions Set(
        System.Boolean? Ssl = null,
        System.String? SslCaCerts = null,
        System.String? SslCertfile = null,
        System.String? SslKeyfile = null,
        SourceSslCertReqs? SslCertRequirements = null
    ) 
    {
        if ( Ssl != null ) {
            this.Ssl = Ssl;
        }
        if ( SslCaCerts != null ) {
            this.SslCaCerts = SslCaCerts;
        }
        if ( SslCertfile != null ) {
            this.SslCertfile = SslCertfile;
        }
        if ( SslKeyfile != null ) {
            this.SslKeyfile = SslKeyfile;
        }
        if ( SslCertRequirements != null ) {
            this.SslCertRequirements = SslCertRequirements;
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
            //      C# -> System.Boolean? Ssl
            // GraphQL -> ssl: Boolean! (scalar)
            if (this.Ssl != null)
            {
                 s += ind + "ssl\n";

            }
            //      C# -> System.String? SslCaCerts
            // GraphQL -> sslCaCerts: String! (scalar)
            if (this.SslCaCerts != null)
            {
                 s += ind + "sslCaCerts\n";

            }
            //      C# -> System.String? SslCertfile
            // GraphQL -> sslCertfile: String! (scalar)
            if (this.SslCertfile != null)
            {
                 s += ind + "sslCertfile\n";

            }
            //      C# -> System.String? SslKeyfile
            // GraphQL -> sslKeyfile: String! (scalar)
            if (this.SslKeyfile != null)
            {
                 s += ind + "sslKeyfile\n";

            }
            //      C# -> SourceSslCertReqs? SslCertRequirements
            // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
            if (this.SslCertRequirements != null)
            {
                 s += ind + "sslCertRequirements\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? Ssl
            // GraphQL -> ssl: Boolean! (scalar)
            if (this.Ssl == null && Exploration.Includes(parent + ".ssl$"))
            {
                this.Ssl = new System.Boolean();
            }
            //      C# -> System.String? SslCaCerts
            // GraphQL -> sslCaCerts: String! (scalar)
            if (this.SslCaCerts == null && Exploration.Includes(parent + ".sslCaCerts$"))
            {
                this.SslCaCerts = new System.String("FETCH");
            }
            //      C# -> System.String? SslCertfile
            // GraphQL -> sslCertfile: String! (scalar)
            if (this.SslCertfile == null && Exploration.Includes(parent + ".sslCertfile$"))
            {
                this.SslCertfile = new System.String("FETCH");
            }
            //      C# -> System.String? SslKeyfile
            // GraphQL -> sslKeyfile: String! (scalar)
            if (this.SslKeyfile == null && Exploration.Includes(parent + ".sslKeyfile$"))
            {
                this.SslKeyfile = new System.String("FETCH");
            }
            //      C# -> SourceSslCertReqs? SslCertRequirements
            // GraphQL -> sslCertRequirements: SourceSslCertReqs! (enum)
            if (this.SslCertRequirements == null && Exploration.Includes(parent + ".sslCertRequirements$"))
            {
                this.SslCertRequirements = new SourceSslCertReqs();
            }
        }


    #endregion

    } // class CassandraSslOptions
    #endregion

    public static class ListCassandraSslOptionsExtensions
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
            this List<CassandraSslOptions> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CassandraSslOptions> list, 
            String parent = "")
        {
            var item = new CassandraSslOptions();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types