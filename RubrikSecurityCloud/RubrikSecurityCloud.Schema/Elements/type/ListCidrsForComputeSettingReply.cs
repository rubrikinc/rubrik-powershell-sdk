// ListCidrsForComputeSettingReply.cs
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
    #region ListCidrsForComputeSettingReply
    public class ListCidrsForComputeSettingReply: BaseType
    {
        #region members

        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        [JsonProperty("clusterInterfaceCidrs")]
        public List<ClusterInfCidrs>? ClusterInterfaceCidrs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListCidrsForComputeSettingReply";
    }

    public ListCidrsForComputeSettingReply Set(
        List<ClusterInfCidrs>? ClusterInterfaceCidrs = null
    ) 
    {
        if ( ClusterInterfaceCidrs != null ) {
            this.ClusterInterfaceCidrs = ClusterInterfaceCidrs;
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
        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        if (this.ClusterInterfaceCidrs != null) {
            var fspec = this.ClusterInterfaceCidrs.AsFieldSpec(conf.Child("clusterInterfaceCidrs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterInterfaceCidrs {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClusterInfCidrs>? ClusterInterfaceCidrs
        // GraphQL -> clusterInterfaceCidrs: [ClusterInfCidrs!]! (type)
        if (ec.Includes("clusterInterfaceCidrs",false))
        {
            if(this.ClusterInterfaceCidrs == null) {

                this.ClusterInterfaceCidrs = new List<ClusterInfCidrs>();
                this.ClusterInterfaceCidrs.ApplyExploratoryFieldSpec(ec.NewChild("clusterInterfaceCidrs"));

            } else {

                this.ClusterInterfaceCidrs.ApplyExploratoryFieldSpec(ec.NewChild("clusterInterfaceCidrs"));

            }
        }
        else if (this.ClusterInterfaceCidrs != null && ec.Excludes("clusterInterfaceCidrs",false))
        {
            this.ClusterInterfaceCidrs = null;
        }
    }


    #endregion

    } // class ListCidrsForComputeSettingReply
    
    #endregion

    public static class ListListCidrsForComputeSettingReplyExtensions
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
            this List<ListCidrsForComputeSettingReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ListCidrsForComputeSettingReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ListCidrsForComputeSettingReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListCidrsForComputeSettingReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListCidrsForComputeSettingReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types