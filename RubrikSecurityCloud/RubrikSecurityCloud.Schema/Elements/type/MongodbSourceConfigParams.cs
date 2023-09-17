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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "MongodbSourceConfigParams";
    }

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
            var fspec = this.IgnoreSecondaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ignoreSecondaries {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<MongodbHost>? MongodbHosts
        // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
        if (this.MongodbHosts != null) {
            var fspec = this.MongodbHosts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mongodbHosts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MongodbSslOptions? SslOptions
        // GraphQL -> sslOptions: MongodbSslOptions (type)
        if (this.SslOptions != null) {
            var fspec = this.SslOptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sslOptions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (this.SourceDbUser == null && ec.Includes("sourceDbUser",true))
        {
            this.SourceDbUser = "FETCH";
        }
        //      C# -> System.String? SourceNodeUser
        // GraphQL -> sourceNodeUser: String! (scalar)
        if (this.SourceNodeUser == null && ec.Includes("sourceNodeUser",true))
        {
            this.SourceNodeUser = "FETCH";
        }
        //      C# -> System.Int32? SourceSshPort
        // GraphQL -> sourceSshPort: Int! (scalar)
        if (this.SourceSshPort == null && ec.Includes("sourceSshPort",true))
        {
            this.SourceSshPort = Int32.MinValue;
        }
        //      C# -> List<MongodbHost>? IgnoreSecondaries
        // GraphQL -> ignoreSecondaries: [MongodbHost!]! (type)
        if (this.IgnoreSecondaries == null && ec.Includes("ignoreSecondaries",false))
        {
            this.IgnoreSecondaries = new List<MongodbHost>();
            this.IgnoreSecondaries.ApplyExploratoryFieldSpec(ec.NewChild("ignoreSecondaries"));
        }
        //      C# -> List<MongodbHost>? MongodbHosts
        // GraphQL -> mongodbHosts: [MongodbHost!]! (type)
        if (this.MongodbHosts == null && ec.Includes("mongodbHosts",false))
        {
            this.MongodbHosts = new List<MongodbHost>();
            this.MongodbHosts.ApplyExploratoryFieldSpec(ec.NewChild("mongodbHosts"));
        }
        //      C# -> MongodbSslOptions? SslOptions
        // GraphQL -> sslOptions: MongodbSslOptions (type)
        if (this.SslOptions == null && ec.Includes("sslOptions",false))
        {
            this.SslOptions = new MongodbSslOptions();
            this.SslOptions.ApplyExploratoryFieldSpec(ec.NewChild("sslOptions"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongodbSourceConfigParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongodbSourceConfigParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongodbSourceConfigParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types