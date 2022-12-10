// MongodbSourceConfigParams.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:44.
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
    #region MongodbSourceConfigParams
    public class MongodbSourceConfigParams: IFragment
    {
        #region members
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        [JsonProperty("sourceDbUser")]
        public System.String? SourceDbUser { get; set; }

        //      C# -> System.String? SourceNodeUser
        // GraphQL -> sourceNodeUser: String! (scalar)
        [JsonProperty("sourceNodeUser")]
        public System.String? SourceNodeUser { get; set; }

        //      C# -> System.Int32? SourceSshPort
        // GraphQL -> sourceSshPort: Int! (scalar)
        [JsonProperty("sourceSshPort")]
        public System.Int32? SourceSshPort { get; set; }

        //      C# -> List<MongodbHost>? IgnoreSecondaries
        // GraphQL -> ignoreSecondaries: [MongodbHost!]! (type)
        [JsonProperty("ignoreSecondaries")]
        public List<MongodbHost>? IgnoreSecondaries { get; set; }

        //      C# -> List<MongodbHost>? MongodbHosts
        // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
        [JsonProperty("mongodbHosts")]
        public List<MongodbHost>? MongodbHosts { get; set; }

        //      C# -> MongodbSslOptions? SslOptions
        // GraphQL -> sslOptions: MongodbSslOptions (type)
        [JsonProperty("sslOptions")]
        public MongodbSslOptions? SslOptions { get; set; }

        #endregion

    #region methods

    public MongodbSourceConfigParams Set(
        System.String? SourceDbUser = null,
        System.String? SourceNodeUser = null,
        System.Int32? SourceSshPort = null,
        List<MongodbHost>? IgnoreSecondaries = null,
        List<MongodbHost>? MongodbHosts = null,
        MongodbSslOptions? SslOptions = null
    ) 
    {
        if ( SourceDbUser != null ) {
            this.SourceDbUser = SourceDbUser;
        }
        if ( SourceNodeUser != null ) {
            this.SourceNodeUser = SourceNodeUser;
        }
        if ( SourceSshPort != null ) {
            this.SourceSshPort = SourceSshPort;
        }
        if ( IgnoreSecondaries != null ) {
            this.IgnoreSecondaries = IgnoreSecondaries;
        }
        if ( MongodbHosts != null ) {
            this.MongodbHosts = MongodbHosts;
        }
        if ( SslOptions != null ) {
            this.SslOptions = SslOptions;
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
            //      C# -> System.String? SourceDbUser
            // GraphQL -> sourceDbUser: String! (scalar)
            if (this.SourceDbUser != null)
            {
                 s += ind + "sourceDbUser\n";

            }
            //      C# -> System.String? SourceNodeUser
            // GraphQL -> sourceNodeUser: String! (scalar)
            if (this.SourceNodeUser != null)
            {
                 s += ind + "sourceNodeUser\n";

            }
            //      C# -> System.Int32? SourceSshPort
            // GraphQL -> sourceSshPort: Int! (scalar)
            if (this.SourceSshPort != null)
            {
                 s += ind + "sourceSshPort\n";

            }
            //      C# -> List<MongodbHost>? IgnoreSecondaries
            // GraphQL -> ignoreSecondaries: [MongodbHost!]! (type)
            if (this.IgnoreSecondaries != null)
            {
                 s += ind + "ignoreSecondaries\n";

                 s += ind + "{\n" + 
                 this.IgnoreSecondaries.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<MongodbHost>? MongodbHosts
            // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
            if (this.MongodbHosts != null)
            {
                 s += ind + "mongodbHosts\n";

                 s += ind + "{\n" + 
                 this.MongodbHosts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MongodbSslOptions? SslOptions
            // GraphQL -> sslOptions: MongodbSslOptions (type)
            if (this.SslOptions != null)
            {
                 s += ind + "sslOptions\n";

                 s += ind + "{\n" + 
                 this.SslOptions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SourceDbUser
            // GraphQL -> sourceDbUser: String! (scalar)
            if (this.SourceDbUser == null && Exploration.Includes(parent + ".sourceDbUser$"))
            {
                this.SourceDbUser = new System.String("FETCH");
            }
            //      C# -> System.String? SourceNodeUser
            // GraphQL -> sourceNodeUser: String! (scalar)
            if (this.SourceNodeUser == null && Exploration.Includes(parent + ".sourceNodeUser$"))
            {
                this.SourceNodeUser = new System.String("FETCH");
            }
            //      C# -> System.Int32? SourceSshPort
            // GraphQL -> sourceSshPort: Int! (scalar)
            if (this.SourceSshPort == null && Exploration.Includes(parent + ".sourceSshPort$"))
            {
                this.SourceSshPort = new System.Int32();
            }
            //      C# -> List<MongodbHost>? IgnoreSecondaries
            // GraphQL -> ignoreSecondaries: [MongodbHost!]! (type)
            if (this.IgnoreSecondaries == null && Exploration.Includes(parent + ".ignoreSecondaries"))
            {
                this.IgnoreSecondaries = new List<MongodbHost>();
                this.IgnoreSecondaries.ApplyExploratoryFragment(parent + ".ignoreSecondaries");
            }
            //      C# -> List<MongodbHost>? MongodbHosts
            // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
            if (this.MongodbHosts == null && Exploration.Includes(parent + ".mongodbHosts"))
            {
                this.MongodbHosts = new List<MongodbHost>();
                this.MongodbHosts.ApplyExploratoryFragment(parent + ".mongodbHosts");
            }
            //      C# -> MongodbSslOptions? SslOptions
            // GraphQL -> sslOptions: MongodbSslOptions (type)
            if (this.SslOptions == null && Exploration.Includes(parent + ".sslOptions"))
            {
                this.SslOptions = new MongodbSslOptions();
                this.SslOptions.ApplyExploratoryFragment(parent + ".sslOptions");
            }
        }


    #endregion

    } // class MongodbSourceConfigParams
    #endregion

    public static class ListMongodbSourceConfigParamsExtensions
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
            this List<MongodbSourceConfigParams> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MongodbSourceConfigParams> list, 
            String parent = "")
        {
            var item = new MongodbSourceConfigParams();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types