// SourceConfigParams.cs
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
    #region SourceConfigParams
    public class SourceConfigParams: BaseType
    {
        #region members

        //      C# -> List<System.String>? CassandraYaml
        // GraphQL -> cassandraYaml: [String!]! (scalar)
        [JsonProperty("cassandraYaml")]
        public List<System.String>? CassandraYaml { get; set; }

        //      C# -> List<System.String>? DseYaml
        // GraphQL -> dseYaml: [String!]! (scalar)
        [JsonProperty("dseYaml")]
        public List<System.String>? DseYaml { get; set; }

        //      C# -> System.String? HttpsCertificate
        // GraphQL -> httpsCertificate: String! (scalar)
        [JsonProperty("httpsCertificate")]
        public System.String? HttpsCertificate { get; set; }

        //      C# -> System.String? JmxUser
        // GraphQL -> jmxUser: String! (scalar)
        [JsonProperty("jmxUser")]
        public System.String? JmxUser { get; set; }

        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        [JsonProperty("sourceDbUser")]
        public System.String? SourceDbUser { get; set; }

        //      C# -> System.Int32? SourceHttpsPort
        // GraphQL -> sourceHttpsPort: Int! (scalar)
        [JsonProperty("sourceHttpsPort")]
        public System.Int32? SourceHttpsPort { get; set; }

        //      C# -> System.Int32? SourcePort
        // GraphQL -> sourcePort: Int! (scalar)
        [JsonProperty("sourcePort")]
        public System.Int32? SourcePort { get; set; }

        //      C# -> System.Int32? SourceRpcPort
        // GraphQL -> sourceRpcPort: Int! (scalar)
        [JsonProperty("sourceRpcPort")]
        public System.Int32? SourceRpcPort { get; set; }

        //      C# -> CassandraSslOptions? SslOptions
        // GraphQL -> sslOptions: CassandraSslOptions (type)
        [JsonProperty("sslOptions")]
        public CassandraSslOptions? SslOptions { get; set; }


        #endregion

    #region methods

    public SourceConfigParams Set(
        List<System.String>? CassandraYaml = null,
        List<System.String>? DseYaml = null,
        System.String? HttpsCertificate = null,
        System.String? JmxUser = null,
        System.String? SourceDbUser = null,
        System.Int32? SourceHttpsPort = null,
        System.Int32? SourcePort = null,
        System.Int32? SourceRpcPort = null,
        CassandraSslOptions? SslOptions = null
    ) 
    {
        if ( CassandraYaml != null ) {
            this.CassandraYaml = CassandraYaml;
        }
        if ( DseYaml != null ) {
            this.DseYaml = DseYaml;
        }
        if ( HttpsCertificate != null ) {
            this.HttpsCertificate = HttpsCertificate;
        }
        if ( JmxUser != null ) {
            this.JmxUser = JmxUser;
        }
        if ( SourceDbUser != null ) {
            this.SourceDbUser = SourceDbUser;
        }
        if ( SourceHttpsPort != null ) {
            this.SourceHttpsPort = SourceHttpsPort;
        }
        if ( SourcePort != null ) {
            this.SourcePort = SourcePort;
        }
        if ( SourceRpcPort != null ) {
            this.SourceRpcPort = SourceRpcPort;
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
        //      C# -> List<System.String>? CassandraYaml
        // GraphQL -> cassandraYaml: [String!]! (scalar)
        if (this.CassandraYaml != null) {
            s += ind + "cassandraYaml\n" ;
        }
        //      C# -> List<System.String>? DseYaml
        // GraphQL -> dseYaml: [String!]! (scalar)
        if (this.DseYaml != null) {
            s += ind + "dseYaml\n" ;
        }
        //      C# -> System.String? HttpsCertificate
        // GraphQL -> httpsCertificate: String! (scalar)
        if (this.HttpsCertificate != null) {
            s += ind + "httpsCertificate\n" ;
        }
        //      C# -> System.String? JmxUser
        // GraphQL -> jmxUser: String! (scalar)
        if (this.JmxUser != null) {
            s += ind + "jmxUser\n" ;
        }
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (this.SourceDbUser != null) {
            s += ind + "sourceDbUser\n" ;
        }
        //      C# -> System.Int32? SourceHttpsPort
        // GraphQL -> sourceHttpsPort: Int! (scalar)
        if (this.SourceHttpsPort != null) {
            s += ind + "sourceHttpsPort\n" ;
        }
        //      C# -> System.Int32? SourcePort
        // GraphQL -> sourcePort: Int! (scalar)
        if (this.SourcePort != null) {
            s += ind + "sourcePort\n" ;
        }
        //      C# -> System.Int32? SourceRpcPort
        // GraphQL -> sourceRpcPort: Int! (scalar)
        if (this.SourceRpcPort != null) {
            s += ind + "sourceRpcPort\n" ;
        }
        //      C# -> CassandraSslOptions? SslOptions
        // GraphQL -> sslOptions: CassandraSslOptions (type)
        if (this.SslOptions != null) {
            var fspec = this.SslOptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sslOptions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? CassandraYaml
        // GraphQL -> cassandraYaml: [String!]! (scalar)
        if (this.CassandraYaml == null && Exploration.Includes(parent + ".cassandraYaml", true))
        {
            this.CassandraYaml = new List<System.String>();
        }
        //      C# -> List<System.String>? DseYaml
        // GraphQL -> dseYaml: [String!]! (scalar)
        if (this.DseYaml == null && Exploration.Includes(parent + ".dseYaml", true))
        {
            this.DseYaml = new List<System.String>();
        }
        //      C# -> System.String? HttpsCertificate
        // GraphQL -> httpsCertificate: String! (scalar)
        if (this.HttpsCertificate == null && Exploration.Includes(parent + ".httpsCertificate", true))
        {
            this.HttpsCertificate = "FETCH";
        }
        //      C# -> System.String? JmxUser
        // GraphQL -> jmxUser: String! (scalar)
        if (this.JmxUser == null && Exploration.Includes(parent + ".jmxUser", true))
        {
            this.JmxUser = "FETCH";
        }
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (this.SourceDbUser == null && Exploration.Includes(parent + ".sourceDbUser", true))
        {
            this.SourceDbUser = "FETCH";
        }
        //      C# -> System.Int32? SourceHttpsPort
        // GraphQL -> sourceHttpsPort: Int! (scalar)
        if (this.SourceHttpsPort == null && Exploration.Includes(parent + ".sourceHttpsPort", true))
        {
            this.SourceHttpsPort = Int32.MinValue;
        }
        //      C# -> System.Int32? SourcePort
        // GraphQL -> sourcePort: Int! (scalar)
        if (this.SourcePort == null && Exploration.Includes(parent + ".sourcePort", true))
        {
            this.SourcePort = Int32.MinValue;
        }
        //      C# -> System.Int32? SourceRpcPort
        // GraphQL -> sourceRpcPort: Int! (scalar)
        if (this.SourceRpcPort == null && Exploration.Includes(parent + ".sourceRpcPort", true))
        {
            this.SourceRpcPort = Int32.MinValue;
        }
        //      C# -> CassandraSslOptions? SslOptions
        // GraphQL -> sslOptions: CassandraSslOptions (type)
        if (this.SslOptions == null && Exploration.Includes(parent + ".sslOptions"))
        {
            this.SslOptions = new CassandraSslOptions();
            this.SslOptions.ApplyExploratoryFieldSpec(parent + ".sslOptions");
        }
    }


    #endregion

    } // class SourceConfigParams
    
    #endregion

    public static class ListSourceConfigParamsExtensions
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
            this List<SourceConfigParams> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SourceConfigParams> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceConfigParams());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types