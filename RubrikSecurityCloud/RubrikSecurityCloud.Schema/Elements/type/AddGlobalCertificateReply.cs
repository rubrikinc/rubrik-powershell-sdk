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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        if (this.Certificate != null) {
            var fspec = this.Certificate.AsFieldSpec(conf.Child("certificate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "certificate {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (this.ClusterErrors != null) {
            var fspec = this.ClusterErrors.AsFieldSpec(conf.Child("clusterErrors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterErrors {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> GlobalCertificate? Certificate
        // GraphQL -> certificate: GlobalCertificate! (type)
        if (ec.Includes("certificate",false))
        {
            if(this.Certificate == null) {

                this.Certificate = new GlobalCertificate();
                this.Certificate.ApplyExploratoryFieldSpec(ec.NewChild("certificate"));

            } else {

                this.Certificate.ApplyExploratoryFieldSpec(ec.NewChild("certificate"));

            }
        }
        else if (this.Certificate != null && ec.Excludes("certificate",false))
        {
            this.Certificate = null;
        }
        //      C# -> List<CertificateClusterOperationError>? ClusterErrors
        // GraphQL -> clusterErrors: [CertificateClusterOperationError!]! (type)
        if (ec.Includes("clusterErrors",false))
        {
            if(this.ClusterErrors == null) {

                this.ClusterErrors = new List<CertificateClusterOperationError>();
                this.ClusterErrors.ApplyExploratoryFieldSpec(ec.NewChild("clusterErrors"));

            } else {

                this.ClusterErrors.ApplyExploratoryFieldSpec(ec.NewChild("clusterErrors"));

            }
        }
        else if (this.ClusterErrors != null && ec.Excludes("clusterErrors",false))
        {
            this.ClusterErrors = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AddGlobalCertificateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddGlobalCertificateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddGlobalCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddGlobalCertificateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types