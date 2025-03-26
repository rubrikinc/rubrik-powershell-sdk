// ProxySettings.cs
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
    #region ProxySettings
    public class ProxySettings: BaseType
    {
        #region members

        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        [JsonProperty("portNumber")]
        public System.Int32? PortNumber { get; set; }

        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        [JsonProperty("protocol")]
        public System.String? Protocol { get; set; }

        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String! (scalar)
        [JsonProperty("proxyServer")]
        public System.String? ProxyServer { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProxySettings";
    }

    public ProxySettings Set(
        System.Int32? PortNumber = null,
        System.String? Protocol = null,
        System.String? ProxyServer = null,
        System.String? Username = null
    ) 
    {
        if ( PortNumber != null ) {
            this.PortNumber = PortNumber;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( ProxyServer != null ) {
            this.ProxyServer = ProxyServer;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        if (this.PortNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "portNumber\n" ;
            } else {
                s += ind + "portNumber\n" ;
            }
        }
        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        if (this.Protocol != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protocol\n" ;
            } else {
                s += ind + "protocol\n" ;
            }
        }
        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String! (scalar)
        if (this.ProxyServer != null) {
            if (conf.Flat) {
                s += conf.Prefix + "proxyServer\n" ;
            } else {
                s += ind + "proxyServer\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        if (ec.Includes("portNumber",true))
        {
            if(this.PortNumber == null) {

                this.PortNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.PortNumber != null && ec.Excludes("portNumber",true))
        {
            this.PortNumber = null;
        }
        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        if (ec.Includes("protocol",true))
        {
            if(this.Protocol == null) {

                this.Protocol = "FETCH";

            } else {


            }
        }
        else if (this.Protocol != null && ec.Excludes("protocol",true))
        {
            this.Protocol = null;
        }
        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String! (scalar)
        if (ec.Includes("proxyServer",true))
        {
            if(this.ProxyServer == null) {

                this.ProxyServer = "FETCH";

            } else {


            }
        }
        else if (this.ProxyServer != null && ec.Excludes("proxyServer",true))
        {
            this.ProxyServer = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
    }


    #endregion

    } // class ProxySettings
    
    #endregion

    public static class ListProxySettingsExtensions
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
            this List<ProxySettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProxySettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProxySettings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProxySettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProxySettings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types