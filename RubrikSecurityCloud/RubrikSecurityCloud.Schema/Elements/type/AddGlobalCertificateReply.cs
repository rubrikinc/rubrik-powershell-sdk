// AddGlobalCertificateReply.cs
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
    #region AddGlobalCertificateReply
    public class AddGlobalCertificateReply: BaseType
    {
        #region members

        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        [JsonProperty("certificate")]
        public GlobalCertificate? Certificate { get; set; }

        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        [JsonProperty("clusterErrors")]
        public List<CertificateClusterOperationError>? ClusterErrors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddGlobalCertificateReply";
    }

    public AddGlobalCertificateReply Set(
        GlobalCertificate? Certificate = null,
        List<CertificateClusterOperationError>? ClusterErrors = null
    ) 
    {
        if ( Certificate != null ) {
            this.Certificate = Certificate;
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
        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        if (this.Certificate != null) {
            var fspec = this.Certificate.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "certificate {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        if (this.Certificate == null && Exploration.Includes(parent + ".certificate"))
        {
            this.Certificate = new GlobalCertificate();
            this.Certificate.ApplyExploratoryFieldSpec(parent + ".certificate");
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

    } // class AddGlobalCertificateReply
    
    #endregion

    public static class ListAddGlobalCertificateReplyExtensions
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
            this List<AddGlobalCertificateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddGlobalCertificateReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddGlobalCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types