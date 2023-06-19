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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (this.WebServerConfiguredWithCaSignedCertificate != null) {
            s += ind + "webServerConfiguredWithCaSignedCertificate\n" ;
        }
        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        if (this.Cert != null) {
            var fspec = this.Cert.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cert {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
        // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
        if (this.WebServerConfiguredWithCaSignedCertificate == null && Exploration.Includes(parent + ".webServerConfiguredWithCaSignedCertificate", true))
        {
            this.WebServerConfiguredWithCaSignedCertificate = true;
        }
        //      C# -> AddClusterCertificateReply? Cert
        // GraphQL -> cert: AddClusterCertificateReply (type)
        if (this.Cert == null && Exploration.Includes(parent + ".cert"))
        {
            this.Cert = new AddClusterCertificateReply();
            this.Cert.ApplyExploratoryFieldSpec(parent + ".cert");
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterWebSignedCertificateReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterWebSignedCertificateReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types