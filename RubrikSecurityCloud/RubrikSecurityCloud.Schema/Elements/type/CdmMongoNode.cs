// CdmMongoNode.cs
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
    #region CdmMongoNode
    public class CdmMongoNode: BaseType
    {
        #region members

        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        [JsonProperty("host")]
        public System.String? Host { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: UUID! (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMongoNode";
    }

    public CdmMongoNode Set(
        System.String? Host = null,
        System.String? HostFid = null,
        System.Int32? Port = null
    ) 
    {
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (this.Host != null) {
            if (conf.Flat) {
                s += conf.Prefix + "host\n" ;
            } else {
                s += ind + "host\n" ;
            }
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: UUID! (scalar)
        if (this.HostFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostFid\n" ;
            } else {
                s += ind + "hostFid\n" ;
            }
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Host
        // GraphQL -> host: String! (scalar)
        if (ec.Includes("host",true))
        {
            if(this.Host == null) {

                this.Host = "FETCH";

            } else {


            }
        }
        else if (this.Host != null && ec.Excludes("host",true))
        {
            this.Host = null;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: UUID! (scalar)
        if (ec.Includes("hostFid",true))
        {
            if(this.HostFid == null) {

                this.HostFid = "FETCH";

            } else {


            }
        }
        else if (this.HostFid != null && ec.Excludes("hostFid",true))
        {
            this.HostFid = null;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = Int32.MinValue;

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
        }
    }


    #endregion

    } // class CdmMongoNode
    
    #endregion

    public static class ListCdmMongoNodeExtensions
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
            this List<CdmMongoNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmMongoNode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMongoNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmMongoNode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types