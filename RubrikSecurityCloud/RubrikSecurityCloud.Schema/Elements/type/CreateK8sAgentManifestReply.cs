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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> K8sAgentManifestInfo? Info
        // GraphQL -> info: K8sAgentManifestInfo! (type)
        if (this.Info != null) {
            var fspec = this.Info.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "info {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> K8sAgentManifestInfo? Info
        // GraphQL -> info: K8sAgentManifestInfo! (type)
        if (this.Info == null && Exploration.Includes(parent + ".info"))
        {
            this.Info = new K8sAgentManifestInfo();
            this.Info.ApplyExploratoryFieldSpec(parent + ".info");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateK8sAgentManifestReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateK8sAgentManifestReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types