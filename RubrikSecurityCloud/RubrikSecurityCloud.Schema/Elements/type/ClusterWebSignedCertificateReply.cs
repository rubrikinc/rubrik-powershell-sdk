// ClusterWebSignedCertificateReply.cs
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
    #region ClusterWebSignedCertificateReply
    public class ClusterWebSignedCertificateReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        [JsonProperty("webServerConfiguredWithCaSignedCertificate")]
        public System.Boolean? WebServerConfiguredWithCaSignedCertificate { get; set; }

        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        [JsonProperty("cert")]
        public AddClusterCertificateReply? Cert { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterWebSignedCertificateReply";
    }

    public ClusterWebSignedCertificateReply Set(
        System.Boolean? WebServerConfiguredWithCaSignedCertificate = null,
        AddClusterCertificateReply? Cert = null
    ) 
    {
        if ( WebServerConfiguredWithCaSignedCertificate != null ) {
            this.WebServerConfiguredWithCaSignedCertificate = WebServerConfiguredWithCaSignedCertificate;
        }
        if ( Cert != null ) {
            this.Cert = Cert;
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
        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (this.WebServerConfiguredWithCaSignedCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "webServerConfiguredWithCaSignedCertificate\n" ;
            } else {
                s += ind + "webServerConfiguredWithCaSignedCertificate\n" ;
            }
        }
        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        if (this.Cert != null) {
            var fspec = this.Cert.AsFieldSpec(conf.Child("cert"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cert {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (ec.Includes("webServerConfiguredWithCaSignedCertificate",true))
        {
            if(this.WebServerConfiguredWithCaSignedCertificate == null) {

                this.WebServerConfiguredWithCaSignedCertificate = true;

            } else {


            }
        }
        else if (this.WebServerConfiguredWithCaSignedCertificate != null && ec.Excludes("webServerConfiguredWithCaSignedCertificate",true))
        {
            this.WebServerConfiguredWithCaSignedCertificate = null;
        }
        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        if (ec.Includes("cert",false))
        {
            if(this.Cert == null) {

                this.Cert = new AddClusterCertificateReply();
                this.Cert.ApplyExploratoryFieldSpec(ec.NewChild("cert"));

            } else {

                this.Cert.ApplyExploratoryFieldSpec(ec.NewChild("cert"));

            }
        }
        else if (this.Cert != null && ec.Excludes("cert",false))
        {
            this.Cert = null;
        }
    }


    #endregion

    } // class ClusterWebSignedCertificateReply
    
    #endregion

    public static class ListClusterWebSignedCertificateReplyExtensions
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
            this List<ClusterWebSignedCertificateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterWebSignedCertificateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterWebSignedCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterWebSignedCertificateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types