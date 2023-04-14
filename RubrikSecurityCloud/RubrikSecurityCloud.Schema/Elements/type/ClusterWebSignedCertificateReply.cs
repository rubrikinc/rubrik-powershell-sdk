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

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterWebSignedCertificateReply
    public class ClusterWebSignedCertificateReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
            // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
            if (this.WebServerConfiguredWithCaSignedCertificate != null)
            {
                 s += ind + "webServerConfiguredWithCaSignedCertificate\n";

            }
            //      C# -> AddClusterCertificateReply? Cert
            // GraphQL -> cert: AddClusterCertificateReply (type)
            if (this.Cert != null)
            {
                 s += ind + "cert\n";

                 s += ind + "{\n" + 
                 this.Cert.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? WebServerConfiguredWithCaSignedCertificate
            // GraphQL -> webServerConfiguredWithCaSignedCertificate: Boolean! (scalar)
            if (this.WebServerConfiguredWithCaSignedCertificate == null && Exploration.Includes(parent + ".webServerConfiguredWithCaSignedCertificate$"))
            {
                this.WebServerConfiguredWithCaSignedCertificate = new System.Boolean();
            }
            //      C# -> AddClusterCertificateReply? Cert
            // GraphQL -> cert: AddClusterCertificateReply (type)
            if (this.Cert == null && Exploration.Includes(parent + ".cert"))
            {
                this.Cert = new AddClusterCertificateReply();
                this.Cert.ApplyExploratoryFragment(parent + ".cert");
            }
        }


    #endregion

    } // class ClusterWebSignedCertificateReply
    #endregion

    public static class ListClusterWebSignedCertificateReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ClusterWebSignedCertificateReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterWebSignedCertificateReply> list, 
            String parent = "")
        {
            var item = new ClusterWebSignedCertificateReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types