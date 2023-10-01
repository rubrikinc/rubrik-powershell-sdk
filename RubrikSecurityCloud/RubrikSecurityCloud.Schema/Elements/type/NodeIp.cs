// NodeIp.cs
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
    #region NodeIp
    public class NodeIp: BaseType
    {
        #region members

        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        [JsonProperty("ip")]
        public System.String? Ip { get; set; }

        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        [JsonProperty("node")]
        public System.String? Node { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NodeIp";
    }

    public NodeIp Set(
        System.String? Ip = null,
        System.String? Node = null
    ) 
    {
        if ( Ip != null ) {
            this.Ip = Ip;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (this.Ip != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ip\n" ;
            } else {
                s += ind + "ip\n" ;
            }
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        if (this.Node != null) {
            if (conf.Flat) {
                s += conf.Prefix + "node\n" ;
            } else {
                s += ind + "node\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (ec.Includes("ip",true))
        {
            if(this.Ip == null) {

                this.Ip = "FETCH";

            } else {


            }
        }
        else if (this.Ip != null && ec.Excludes("ip",true))
        {
            this.Ip = null;
        }
        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        if (ec.Includes("node",true))
        {
            if(this.Node == null) {

                this.Node = "FETCH";

            } else {


            }
        }
        else if (this.Node != null && ec.Excludes("node",true))
        {
            this.Node = null;
        }
    }


    #endregion

    } // class NodeIp
    
    #endregion

    public static class ListNodeIpExtensions
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
            this List<NodeIp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NodeIp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NodeIp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NodeIp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NodeIp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types