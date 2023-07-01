// ArchiveK8sClusterReply.cs
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
    #region ArchiveK8sClusterReply
    public class ArchiveK8sClusterReply: BaseType
    {
        #region members

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchiveK8sClusterReply";
    }

    public ArchiveK8sClusterReply Set(
        System.String? ClusterId = null
    ) 
    {
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
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
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
    }


    #endregion

    } // class ArchiveK8sClusterReply
    
    #endregion

    public static class ListArchiveK8sClusterReplyExtensions
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
            this List<ArchiveK8sClusterReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchiveK8sClusterReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchiveK8sClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types