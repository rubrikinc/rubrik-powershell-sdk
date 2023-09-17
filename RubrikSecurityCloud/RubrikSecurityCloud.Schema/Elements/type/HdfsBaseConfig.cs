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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "HdfsBaseConfig";
    }

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
            var fspec = this.Hosts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hosts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        if (this.ApiToken == null && ec.Includes("apiToken",true))
        {
            this.ApiToken = "FETCH";
        }
        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        if (this.KerberosTicket == null && ec.Includes("kerberosTicket",true))
        {
            this.KerberosTicket = "FETCH";
        }
        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        if (this.Nameservices == null && ec.Includes("nameservices",true))
        {
            this.Nameservices = "FETCH";
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username == null && ec.Includes("username",true))
        {
            this.Username = "FETCH";
        }
        //      C# -> List<HdfsHost>? Hosts
        // GraphQL -> hosts: [HdfsHost!]! (type)
        if (this.Hosts == null && ec.Includes("hosts",false))
        {
            this.Hosts = new List<HdfsHost>();
            this.Hosts.ApplyExploratoryFieldSpec(ec.NewChild("hosts"));
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HdfsBaseConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HdfsBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HdfsBaseConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types