// ClusterDnsReply.cs
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
    #region ClusterDnsReply
    public class ClusterDnsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        [JsonProperty("domains")]
        public List<System.String>? Domains { get; set; }

        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        [JsonProperty("servers")]
        public List<System.String>? Servers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterDnsReply";
    }

    public ClusterDnsReply Set(
        List<System.String>? Domains = null,
        List<System.String>? Servers = null
    ) 
    {
        if ( Domains != null ) {
            this.Domains = Domains;
        }
        if ( Servers != null ) {
            this.Servers = Servers;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        if (this.Domains != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domains\n" ;
            } else {
                s += ind + "domains\n" ;
            }
        }
        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        if (this.Servers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "servers\n" ;
            } else {
                s += ind + "servers\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        if (ec.Includes("domains",true))
        {
            if(this.Domains == null) {

                this.Domains = new List<System.String>();

            } else {


            }
        }
        else if (this.Domains != null && ec.Excludes("domains",true))
        {
            this.Domains = null;
        }
        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        if (ec.Includes("servers",true))
        {
            if(this.Servers == null) {

                this.Servers = new List<System.String>();

            } else {


            }
        }
        else if (this.Servers != null && ec.Excludes("servers",true))
        {
            this.Servers = null;
        }
    }


    #endregion

    } // class ClusterDnsReply
    
    #endregion

    public static class ListClusterDnsReplyExtensions
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
            this List<ClusterDnsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterDnsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterDnsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterDnsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterDnsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types