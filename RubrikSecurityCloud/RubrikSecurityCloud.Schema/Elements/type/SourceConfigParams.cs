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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "SourceConfigParams";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? CassandraYaml
        // GraphQL -> cassandraYaml: [String!]! (scalar)
        if (this.CassandraYaml != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cassandraYaml\n" ;
            } else {
                s += ind + "cassandraYaml\n" ;
            }
        }
        //      C# -> List<System.String>? DseYaml
        // GraphQL -> dseYaml: [String!]! (scalar)
        if (this.DseYaml != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dseYaml\n" ;
            } else {
                s += ind + "dseYaml\n" ;
            }
        }
        //      C# -> System.String? HttpsCertificate
        // GraphQL -> httpsCertificate: String! (scalar)
        if (this.HttpsCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "httpsCertificate\n" ;
            } else {
                s += ind + "httpsCertificate\n" ;
            }
        }
        //      C# -> System.String? JmxUser
        // GraphQL -> jmxUser: String! (scalar)
        if (this.JmxUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jmxUser\n" ;
            } else {
                s += ind + "jmxUser\n" ;
            }
        }
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (this.SourceDbUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceDbUser\n" ;
            } else {
                s += ind + "sourceDbUser\n" ;
            }
        }
        //      C# -> System.Int32? SourceHttpsPort
        // GraphQL -> sourceHttpsPort: Int! (scalar)
        if (this.SourceHttpsPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceHttpsPort\n" ;
            } else {
                s += ind + "sourceHttpsPort\n" ;
            }
        }
        //      C# -> System.Int32? SourcePort
        // GraphQL -> sourcePort: Int! (scalar)
        if (this.SourcePort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourcePort\n" ;
            } else {
                s += ind + "sourcePort\n" ;
            }
        }
        //      C# -> System.Int32? SourceRpcPort
        // GraphQL -> sourceRpcPort: Int! (scalar)
        if (this.SourceRpcPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceRpcPort\n" ;
            } else {
                s += ind + "sourceRpcPort\n" ;
            }
        }
        //      C# -> CassandraSslOptions? SslOptions
        // GraphQL -> sslOptions: CassandraSslOptions (type)
        if (this.SslOptions != null) {
            var fspec = this.SslOptions.AsFieldSpec(conf.Child("sslOptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sslOptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? CassandraYaml
        // GraphQL -> cassandraYaml: [String!]! (scalar)
        if (ec.Includes("cassandraYaml",true))
        {
            if(this.CassandraYaml == null) {

                this.CassandraYaml = new List<System.String>();

            } else {


            }
        }
        else if (this.CassandraYaml != null && ec.Excludes("cassandraYaml",true))
        {
            this.CassandraYaml = null;
        }
        //      C# -> List<System.String>? DseYaml
        // GraphQL -> dseYaml: [String!]! (scalar)
        if (ec.Includes("dseYaml",true))
        {
            if(this.DseYaml == null) {

                this.DseYaml = new List<System.String>();

            } else {


            }
        }
        else if (this.DseYaml != null && ec.Excludes("dseYaml",true))
        {
            this.DseYaml = null;
        }
        //      C# -> System.String? HttpsCertificate
        // GraphQL -> httpsCertificate: String! (scalar)
        if (ec.Includes("httpsCertificate",true))
        {
            if(this.HttpsCertificate == null) {

                this.HttpsCertificate = "FETCH";

            } else {


            }
        }
        else if (this.HttpsCertificate != null && ec.Excludes("httpsCertificate",true))
        {
            this.HttpsCertificate = null;
        }
        //      C# -> System.String? JmxUser
        // GraphQL -> jmxUser: String! (scalar)
        if (ec.Includes("jmxUser",true))
        {
            if(this.JmxUser == null) {

                this.JmxUser = "FETCH";

            } else {


            }
        }
        else if (this.JmxUser != null && ec.Excludes("jmxUser",true))
        {
            this.JmxUser = null;
        }
        //      C# -> System.String? SourceDbUser
        // GraphQL -> sourceDbUser: String! (scalar)
        if (ec.Includes("sourceDbUser",true))
        {
            if(this.SourceDbUser == null) {

                this.SourceDbUser = "FETCH";

            } else {


            }
        }
        else if (this.SourceDbUser != null && ec.Excludes("sourceDbUser",true))
        {
            this.SourceDbUser = null;
        }
        //      C# -> System.Int32? SourceHttpsPort
        // GraphQL -> sourceHttpsPort: Int! (scalar)
        if (ec.Includes("sourceHttpsPort",true))
        {
            if(this.SourceHttpsPort == null) {

                this.SourceHttpsPort = Int32.MinValue;

            } else {


            }
        }
        else if (this.SourceHttpsPort != null && ec.Excludes("sourceHttpsPort",true))
        {
            this.SourceHttpsPort = null;
        }
        //      C# -> System.Int32? SourcePort
        // GraphQL -> sourcePort: Int! (scalar)
        if (ec.Includes("sourcePort",true))
        {
            if(this.SourcePort == null) {

                this.SourcePort = Int32.MinValue;

            } else {


            }
        }
        else if (this.SourcePort != null && ec.Excludes("sourcePort",true))
        {
            this.SourcePort = null;
        }
        //      C# -> System.Int32? SourceRpcPort
        // GraphQL -> sourceRpcPort: Int! (scalar)
        if (ec.Includes("sourceRpcPort",true))
        {
            if(this.SourceRpcPort == null) {

                this.SourceRpcPort = Int32.MinValue;

            } else {


            }
        }
        else if (this.SourceRpcPort != null && ec.Excludes("sourceRpcPort",true))
        {
            this.SourceRpcPort = null;
        }
        //      C# -> CassandraSslOptions? SslOptions
        // GraphQL -> sslOptions: CassandraSslOptions (type)
        if (ec.Includes("sslOptions",false))
        {
            if(this.SslOptions == null) {

                this.SslOptions = new CassandraSslOptions();
                this.SslOptions.ApplyExploratoryFieldSpec(ec.NewChild("sslOptions"));

            } else {

                this.SslOptions.ApplyExploratoryFieldSpec(ec.NewChild("sslOptions"));

            }
        }
        else if (this.SslOptions != null && ec.Excludes("sslOptions",false))
        {
            this.SslOptions = null;
        }
    }


    #endregion

    } // class SourceConfigParams
    
    #endregion

    public static class ListSourceConfigParamsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SourceConfigParams> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SourceConfigParams> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SourceConfigParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceConfigParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SourceConfigParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types