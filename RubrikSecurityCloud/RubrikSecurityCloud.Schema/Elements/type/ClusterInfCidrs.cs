// ClusterInfCidrs.cs
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
    #region ClusterInfCidrs
    public class ClusterInfCidrs: BaseType
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> List<InterfaceCidr>? InterfaceCidr
        // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
        [JsonProperty("interfaceCidr")]
        public List<InterfaceCidr>? InterfaceCidr { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterInfCidrs";
    }

    public ClusterInfCidrs Set(
        System.String? ClusterId = null,
        System.String? ClusterName = null,
        List<InterfaceCidr>? InterfaceCidr = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( InterfaceCidr != null ) {
            this.InterfaceCidr = InterfaceCidr;
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
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> List<InterfaceCidr>? InterfaceCidr
        // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
        if (this.InterfaceCidr != null) {
            var fspec = this.InterfaceCidr.AsFieldSpec(conf.Child("interfaceCidr"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "interfaceCidr {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> List<InterfaceCidr>? InterfaceCidr
        // GraphQL -> interfaceCidr: [InterfaceCidr!]! (type)
        if (ec.Includes("interfaceCidr",false))
        {
            if(this.InterfaceCidr == null) {

                this.InterfaceCidr = new List<InterfaceCidr>();
                this.InterfaceCidr.ApplyExploratoryFieldSpec(ec.NewChild("interfaceCidr"));

            } else {

                this.InterfaceCidr.ApplyExploratoryFieldSpec(ec.NewChild("interfaceCidr"));

            }
        }
        else if (this.InterfaceCidr != null && ec.Excludes("interfaceCidr",false))
        {
            this.InterfaceCidr = null;
        }
    }


    #endregion

    } // class ClusterInfCidrs
    
    #endregion

    public static class ListClusterInfCidrsExtensions
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
            this List<ClusterInfCidrs> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterInfCidrs> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterInfCidrs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterInfCidrs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterInfCidrs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types