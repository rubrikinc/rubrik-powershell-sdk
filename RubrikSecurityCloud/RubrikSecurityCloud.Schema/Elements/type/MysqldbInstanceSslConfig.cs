// MysqldbInstanceSslConfig.cs
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
    #region MysqldbInstanceSslConfig
    public class MysqldbInstanceSslConfig: BaseType
    {
        #region members

        //      C# -> System.String? SslCaCertFile
        // GraphQL -> sslCaCertFile: String! (scalar)
        [JsonProperty("sslCaCertFile")]
        public System.String? SslCaCertFile { get; set; }

        //      C# -> System.String? SslCertFile
        // GraphQL -> sslCertFile: String! (scalar)
        [JsonProperty("sslCertFile")]
        public System.String? SslCertFile { get; set; }

        //      C# -> System.String? SslKeyFile
        // GraphQL -> sslKeyFile: String! (scalar)
        [JsonProperty("sslKeyFile")]
        public System.String? SslKeyFile { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MysqldbInstanceSslConfig";
    }

    public MysqldbInstanceSslConfig Set(
        System.String? SslCaCertFile = null,
        System.String? SslCertFile = null,
        System.String? SslKeyFile = null
    ) 
    {
        if ( SslCaCertFile != null ) {
            this.SslCaCertFile = SslCaCertFile;
        }
        if ( SslCertFile != null ) {
            this.SslCertFile = SslCertFile;
        }
        if ( SslKeyFile != null ) {
            this.SslKeyFile = SslKeyFile;
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
        //      C# -> System.String? SslCaCertFile
        // GraphQL -> sslCaCertFile: String! (scalar)
        if (this.SslCaCertFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCaCertFile\n" ;
            } else {
                s += ind + "sslCaCertFile\n" ;
            }
        }
        //      C# -> System.String? SslCertFile
        // GraphQL -> sslCertFile: String! (scalar)
        if (this.SslCertFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCertFile\n" ;
            } else {
                s += ind + "sslCertFile\n" ;
            }
        }
        //      C# -> System.String? SslKeyFile
        // GraphQL -> sslKeyFile: String! (scalar)
        if (this.SslKeyFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslKeyFile\n" ;
            } else {
                s += ind + "sslKeyFile\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? SslCaCertFile
        // GraphQL -> sslCaCertFile: String! (scalar)
        if (ec.Includes("sslCaCertFile",true))
        {
            if(this.SslCaCertFile == null) {

                this.SslCaCertFile = "FETCH";

            } else {


            }
        }
        else if (this.SslCaCertFile != null && ec.Excludes("sslCaCertFile",true))
        {
            this.SslCaCertFile = null;
        }
        //      C# -> System.String? SslCertFile
        // GraphQL -> sslCertFile: String! (scalar)
        if (ec.Includes("sslCertFile",true))
        {
            if(this.SslCertFile == null) {

                this.SslCertFile = "FETCH";

            } else {


            }
        }
        else if (this.SslCertFile != null && ec.Excludes("sslCertFile",true))
        {
            this.SslCertFile = null;
        }
        //      C# -> System.String? SslKeyFile
        // GraphQL -> sslKeyFile: String! (scalar)
        if (ec.Includes("sslKeyFile",true))
        {
            if(this.SslKeyFile == null) {

                this.SslKeyFile = "FETCH";

            } else {


            }
        }
        else if (this.SslKeyFile != null && ec.Excludes("sslKeyFile",true))
        {
            this.SslKeyFile = null;
        }
    }


    #endregion

    } // class MysqldbInstanceSslConfig
    
    #endregion

    public static class ListMysqldbInstanceSslConfigExtensions
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
            this List<MysqldbInstanceSslConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MysqldbInstanceSslConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MysqldbInstanceSslConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MysqldbInstanceSslConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MysqldbInstanceSslConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types