// MysqldbInstanceDetails.cs
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
    #region MysqldbInstanceDetails
    public class MysqldbInstanceDetails: BaseType
    {
        #region members

        //      C# -> MysqldbInstanceAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbInstanceAuthenticationType! (enum)
        [JsonProperty("authenticationType")]
        public MysqldbInstanceAuthenticationType? AuthenticationType { get; set; }

        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String! (scalar)
        [JsonProperty("bindIpAddress")]
        public System.String? BindIpAddress { get; set; }

        //      C# -> System.String? MysqlUserName
        // GraphQL -> mysqlUserName: String! (scalar)
        [JsonProperty("mysqlUserName")]
        public System.String? MysqlUserName { get; set; }

        //      C# -> System.String? SocketFile
        // GraphQL -> socketFile: String! (scalar)
        [JsonProperty("socketFile")]
        public System.String? SocketFile { get; set; }

        //      C# -> System.String? SystemUserName
        // GraphQL -> systemUserName: String! (scalar)
        [JsonProperty("systemUserName")]
        public System.String? SystemUserName { get; set; }

        //      C# -> MysqldbInstanceSslConfig? SslConfig
        // GraphQL -> sslConfig: MysqldbInstanceSslConfig (type)
        [JsonProperty("sslConfig")]
        public MysqldbInstanceSslConfig? SslConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MysqldbInstanceDetails";
    }

    public MysqldbInstanceDetails Set(
        MysqldbInstanceAuthenticationType? AuthenticationType = null,
        System.String? BindIpAddress = null,
        System.String? MysqlUserName = null,
        System.String? SocketFile = null,
        System.String? SystemUserName = null,
        MysqldbInstanceSslConfig? SslConfig = null
    ) 
    {
        if ( AuthenticationType != null ) {
            this.AuthenticationType = AuthenticationType;
        }
        if ( BindIpAddress != null ) {
            this.BindIpAddress = BindIpAddress;
        }
        if ( MysqlUserName != null ) {
            this.MysqlUserName = MysqlUserName;
        }
        if ( SocketFile != null ) {
            this.SocketFile = SocketFile;
        }
        if ( SystemUserName != null ) {
            this.SystemUserName = SystemUserName;
        }
        if ( SslConfig != null ) {
            this.SslConfig = SslConfig;
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
        //      C# -> MysqldbInstanceAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbInstanceAuthenticationType! (enum)
        if (this.AuthenticationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticationType\n" ;
            } else {
                s += ind + "authenticationType\n" ;
            }
        }
        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String! (scalar)
        if (this.BindIpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bindIpAddress\n" ;
            } else {
                s += ind + "bindIpAddress\n" ;
            }
        }
        //      C# -> System.String? MysqlUserName
        // GraphQL -> mysqlUserName: String! (scalar)
        if (this.MysqlUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mysqlUserName\n" ;
            } else {
                s += ind + "mysqlUserName\n" ;
            }
        }
        //      C# -> System.String? SocketFile
        // GraphQL -> socketFile: String! (scalar)
        if (this.SocketFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "socketFile\n" ;
            } else {
                s += ind + "socketFile\n" ;
            }
        }
        //      C# -> System.String? SystemUserName
        // GraphQL -> systemUserName: String! (scalar)
        if (this.SystemUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemUserName\n" ;
            } else {
                s += ind + "systemUserName\n" ;
            }
        }
        //      C# -> MysqldbInstanceSslConfig? SslConfig
        // GraphQL -> sslConfig: MysqldbInstanceSslConfig (type)
        if (this.SslConfig != null) {
            var fspec = this.SslConfig.AsFieldSpec(conf.Child("sslConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sslConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MysqldbInstanceAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbInstanceAuthenticationType! (enum)
        if (ec.Includes("authenticationType",true))
        {
            if(this.AuthenticationType == null) {

                this.AuthenticationType = new MysqldbInstanceAuthenticationType();

            } else {


            }
        }
        else if (this.AuthenticationType != null && ec.Excludes("authenticationType",true))
        {
            this.AuthenticationType = null;
        }
        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String! (scalar)
        if (ec.Includes("bindIpAddress",true))
        {
            if(this.BindIpAddress == null) {

                this.BindIpAddress = "FETCH";

            } else {


            }
        }
        else if (this.BindIpAddress != null && ec.Excludes("bindIpAddress",true))
        {
            this.BindIpAddress = null;
        }
        //      C# -> System.String? MysqlUserName
        // GraphQL -> mysqlUserName: String! (scalar)
        if (ec.Includes("mysqlUserName",true))
        {
            if(this.MysqlUserName == null) {

                this.MysqlUserName = "FETCH";

            } else {


            }
        }
        else if (this.MysqlUserName != null && ec.Excludes("mysqlUserName",true))
        {
            this.MysqlUserName = null;
        }
        //      C# -> System.String? SocketFile
        // GraphQL -> socketFile: String! (scalar)
        if (ec.Includes("socketFile",true))
        {
            if(this.SocketFile == null) {

                this.SocketFile = "FETCH";

            } else {


            }
        }
        else if (this.SocketFile != null && ec.Excludes("socketFile",true))
        {
            this.SocketFile = null;
        }
        //      C# -> System.String? SystemUserName
        // GraphQL -> systemUserName: String! (scalar)
        if (ec.Includes("systemUserName",true))
        {
            if(this.SystemUserName == null) {

                this.SystemUserName = "FETCH";

            } else {


            }
        }
        else if (this.SystemUserName != null && ec.Excludes("systemUserName",true))
        {
            this.SystemUserName = null;
        }
        //      C# -> MysqldbInstanceSslConfig? SslConfig
        // GraphQL -> sslConfig: MysqldbInstanceSslConfig (type)
        if (ec.Includes("sslConfig",false))
        {
            if(this.SslConfig == null) {

                this.SslConfig = new MysqldbInstanceSslConfig();
                this.SslConfig.ApplyExploratoryFieldSpec(ec.NewChild("sslConfig"));

            } else {

                this.SslConfig.ApplyExploratoryFieldSpec(ec.NewChild("sslConfig"));

            }
        }
        else if (this.SslConfig != null && ec.Excludes("sslConfig",false))
        {
            this.SslConfig = null;
        }
    }


    #endregion

    } // class MysqldbInstanceDetails
    
    #endregion

    public static class ListMysqldbInstanceDetailsExtensions
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
            this List<MysqldbInstanceDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MysqldbInstanceDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MysqldbInstanceDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MysqldbInstanceDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MysqldbInstanceDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types