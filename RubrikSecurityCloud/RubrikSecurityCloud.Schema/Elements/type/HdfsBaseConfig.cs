// HdfsBaseConfig.cs
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
    #region HdfsBaseConfig
    public class HdfsBaseConfig: BaseType
    {
        #region members

        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        [JsonProperty("apiToken")]
        public System.String? ApiToken { get; set; }

        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        [JsonProperty("kerberosTicket")]
        public System.String? KerberosTicket { get; set; }

        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        [JsonProperty("nameservices")]
        public System.String? Nameservices { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        [JsonProperty("hosts")]
        public List<HdfsHost>? Hosts { get; set; }


        #endregion

    #region methods

    public HdfsBaseConfig Set(
        System.String? ApiToken = null,
        System.String? KerberosTicket = null,
        System.String? Nameservices = null,
        System.String? Username = null,
        List<HdfsHost>? Hosts = null
    ) 
    {
        if ( ApiToken != null ) {
            this.ApiToken = ApiToken;
        }
        if ( KerberosTicket != null ) {
            this.KerberosTicket = KerberosTicket;
        }
        if ( Nameservices != null ) {
            this.Nameservices = Nameservices;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Hosts != null ) {
            this.Hosts = Hosts;
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
        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        if (this.ApiToken != null) {
            s += ind + "apiToken\n" ;
        }
        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        if (this.KerberosTicket != null) {
            s += ind + "kerberosTicket\n" ;
        }
        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        if (this.Nameservices != null) {
            s += ind + "nameservices\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        if (this.Hosts != null) {
            s += ind + "hosts {\n" + this.Hosts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        if (this.ApiToken == null && Exploration.Includes(parent + ".apiToken", true))
        {
            this.ApiToken = new System.String("FETCH");
        }
        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        if (this.KerberosTicket == null && Exploration.Includes(parent + ".kerberosTicket", true))
        {
            this.KerberosTicket = new System.String("FETCH");
        }
        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        if (this.Nameservices == null && Exploration.Includes(parent + ".nameservices", true))
        {
            this.Nameservices = new System.String("FETCH");
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        if (this.Hosts == null && Exploration.Includes(parent + ".hosts"))
        {
            this.Hosts = new List<HdfsHost>();
            this.Hosts.ApplyExploratoryFieldSpec(parent + ".hosts");
        }
    }


    #endregion

    } // class HdfsBaseConfig
    
    #endregion

    public static class ListHdfsBaseConfigExtensions
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
            this List<HdfsBaseConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HdfsBaseConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HdfsBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types