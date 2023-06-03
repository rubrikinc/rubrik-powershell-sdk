// MongodbSourceConfigParams.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region MongodbSourceConfigParams
    public class MongodbSourceConfigParams: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (this.SourceDbUser != null) {
            s += ind + "sourceDbUser\n" ;
        }
        //      C# -> System.String? SourceNodeUser
        // GraphQL -> sourceNodeUser: String! (scalar)
        if (this.SourceNodeUser != null) {
            s += ind + "sourceNodeUser\n" ;
        }
        //      C# -> System.Int32? SourceSshPort
        // GraphQL -> sourceSshPort: Int! (scalar)
        if (this.SourceSshPort != null) {
            s += ind + "sourceSshPort\n" ;
        }
        //      C# -> List<MongodbHost>? IgnoreSecondaries
        // GraphQL -> ignoreSecondaries: [MongodbHost!]! (type)
        if (this.IgnoreSecondaries != null) {
            s += ind + "ignoreSecondaries {\n" + this.IgnoreSecondaries.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<MongodbHost>? MongodbHosts
        // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
        if (this.MongodbHosts != null) {
            s += ind + "mongodbHosts {\n" + this.MongodbHosts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MongodbSslOptions? SslOptions
        // GraphQL -> sslOptions: MongodbSslOptions (type)
        if (this.SslOptions != null) {
            s += ind + "sslOptions {\n" + this.SslOptions.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (this.SourceDbUser == null && Exploration.Includes(parent + ".sourceDbUser", true))
        {
            this.SourceDbUser = new System.String("FETCH");
        }
        //      C# -> System.String? SourceNodeUser
        // GraphQL -> sourceNodeUser: String! (scalar)
        if (this.SourceNodeUser == null && Exploration.Includes(parent + ".sourceNodeUser", true))
        {
            this.SourceNodeUser = new System.String("FETCH");
        }
        //      C# -> System.Int32? SourceSshPort
        // GraphQL -> sourceSshPort: Int! (scalar)
        if (this.SourceSshPort == null && Exploration.Includes(parent + ".sourceSshPort", true))
        {
            this.SourceSshPort = new System.Int32();
        }
        //      C# -> List<MongodbHost>? IgnoreSecondaries
        // GraphQL -> ignoreSecondaries: [MongodbHost!]! (type)
        if (this.IgnoreSecondaries == null && Exploration.Includes(parent + ".ignoreSecondaries"))
        {
            this.IgnoreSecondaries = new List<MongodbHost>();
            this.IgnoreSecondaries.ApplyExploratoryFieldSpec(parent + ".ignoreSecondaries");
        }
        //      C# -> List<MongodbHost>? MongodbHosts
        // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
        if (this.MongodbHosts == null && Exploration.Includes(parent + ".mongodbHosts"))
        {
            this.MongodbHosts = new List<MongodbHost>();
            this.MongodbHosts.ApplyExploratoryFieldSpec(parent + ".mongodbHosts");
        }
        //      C# -> MongodbSslOptions? SslOptions
        // GraphQL -> sslOptions: MongodbSslOptions (type)
        if (this.SslOptions == null && Exploration.Includes(parent + ".sslOptions"))
        {
            this.SslOptions = new MongodbSslOptions();
            this.SslOptions.ApplyExploratoryFieldSpec(parent + ".sslOptions");
        }
    }


    #endregion

    } // class MongodbSourceConfigParams
    
    #endregion

    public static class ListMongodbSourceConfigParamsExtensions
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
            this List<MongodbSourceConfigParams> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongodbSourceConfigParams> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MongodbSourceConfigParams());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types