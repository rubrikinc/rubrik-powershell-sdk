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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        if (this.PortNumber != null) {
            s += ind + "portNumber\n" ;
        }
        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        if (this.Protocol != null) {
            s += ind + "protocol\n" ;
        }
        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String! (scalar)
        if (this.ProxyServer != null) {
            s += ind + "proxyServer\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int! (scalar)
        if (this.PortNumber == null && Exploration.Includes(parent + ".portNumber", true))
        {
            this.PortNumber = Int32.MinValue;
        }
        //      C# -> System.String? Protocol
        // GraphQL -> protocol: String! (scalar)
        if (this.Protocol == null && Exploration.Includes(parent + ".protocol", true))
        {
            this.Protocol = "FETCH";
        }
        //      C# -> System.String? ProxyServer
        // GraphQL -> proxyServer: String! (scalar)
        if (this.ProxyServer == null && Exploration.Includes(parent + ".proxyServer", true))
        {
            this.ProxyServer = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = "FETCH";
        }
    }


    #endregion

    } // class ProxySettings
    
    #endregion

    public static class ListProxySettingsExtensions
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
            this List<ProxySettings> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ProxySettings> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ProxySettings());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types