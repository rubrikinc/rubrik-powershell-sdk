// UpdateGlobalCertificateReply.cs
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
    #region UpdateGlobalCertificateReply
    public class UpdateGlobalCertificateReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }

        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        [JsonProperty("clusterErrors")]
        public List<CertificateClusterOperationError>? ClusterErrors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateGlobalCertificateReply";
    }

    public UpdateGlobalCertificateReply Set(
        List<System.String>? ClusterUuids = null,
        List<CertificateClusterOperationError>? ClusterErrors = null
    ) 
    {
        if ( ClusterUuids != null ) {
            this.ClusterUuids = ClusterUuids;
        }
        if ( ClusterErrors != null ) {
            this.ClusterErrors = ClusterErrors;
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
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids != null) {
            s += ind + "clusterUuids\n" ;
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (this.ClusterErrors != null) {
            var fspec = this.ClusterErrors.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusterErrors {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        if (this.ClusterUuids == null && Exploration.Includes(parent + ".clusterUuids", true))
        {
            this.ClusterUuids = new List<System.String>();
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (this.ClusterErrors == null && Exploration.Includes(parent + ".clusterErrors"))
        {
            this.ClusterErrors = new List<CertificateClusterOperationError>();
            this.ClusterErrors.ApplyExploratoryFieldSpec(parent + ".clusterErrors");
        }
    }


    #endregion

    } // class UpdateGlobalCertificateReply
    
    #endregion

    public static class ListUpdateGlobalCertificateReplyExtensions
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
            this List<UpdateGlobalCertificateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateGlobalCertificateReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateGlobalCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types