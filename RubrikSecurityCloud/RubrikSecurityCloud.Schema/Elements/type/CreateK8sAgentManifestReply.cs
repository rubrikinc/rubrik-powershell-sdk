// CreateK8sAgentManifestReply.cs
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
    #region CreateK8sAgentManifestReply
    public class CreateK8sAgentManifestReply: BaseType
    {
        #region members

        //      C# -> K8sAgentManifestInfo? Info
        // GraphQL -> info: K8sAgentManifestInfo! (type)
        [JsonProperty("info")]
        public K8sAgentManifestInfo? Info { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateK8sAgentManifestReply";
    }

    public CreateK8sAgentManifestReply Set(
        K8sAgentManifestInfo? Info = null
    ) 
    {
        if ( Info != null ) {
            this.Info = Info;
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
        //      C# -> K8sAgentManifestInfo? Info
        // GraphQL -> info: K8sAgentManifestInfo! (type)
        if (this.Info != null) {
            var fspec = this.Info.AsFieldSpec(conf.Child("info"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "info {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> K8sAgentManifestInfo? Info
        // GraphQL -> info: K8sAgentManifestInfo! (type)
        if (ec.Includes("info",false))
        {
            if(this.Info == null) {

                this.Info = new K8sAgentManifestInfo();
                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            } else {

                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            }
        }
        else if (this.Info != null && ec.Excludes("info",false))
        {
            this.Info = null;
        }
    }


    #endregion

    } // class CreateK8sAgentManifestReply
    
    #endregion

    public static class ListCreateK8sAgentManifestReplyExtensions
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
            this List<CreateK8sAgentManifestReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateK8sAgentManifestReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateK8sAgentManifestReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateK8sAgentManifestReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types