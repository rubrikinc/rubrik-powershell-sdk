// ClusterWebCertAndIpmi.cs
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
    #region ClusterWebCertAndIpmi
    public class ClusterWebCertAndIpmi: IFragment
    {
        #region members
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        [JsonProperty("certInfo")]
        public ClusterWebSignedCertificateReply? CertInfo { get; set; }

        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        [JsonProperty("ipmiInfo")]
        public ModifyIpmiReply? IpmiInfo { get; set; }

        #endregion

    #region methods

    public ClusterWebCertAndIpmi Set(
        System.String? ClusterUuid = null,
        System.String? Error = null,
        ClusterWebSignedCertificateReply? CertInfo = null,
        ModifyIpmiReply? IpmiInfo = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( CertInfo != null ) {
            this.CertInfo = CertInfo;
        }
        if ( IpmiInfo != null ) {
            this.IpmiInfo = IpmiInfo;
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
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

            }
            //      C# -> ClusterWebSignedCertificateReply? CertInfo
            // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
            if (this.CertInfo != null)
            {
                 s += ind + "certInfo\n";

                 s += ind + "{\n" + 
                 this.CertInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ModifyIpmiReply? IpmiInfo
            // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
            if (this.IpmiInfo != null)
            {
                 s += ind + "ipmiInfo\n";

                 s += ind + "{\n" + 
                 this.IpmiInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
            }
            //      C# -> ClusterWebSignedCertificateReply? CertInfo
            // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
            if (this.CertInfo == null && Exploration.Includes(parent + ".certInfo"))
            {
                this.CertInfo = new ClusterWebSignedCertificateReply();
                this.CertInfo.ApplyExploratoryFragment(parent + ".certInfo");
            }
            //      C# -> ModifyIpmiReply? IpmiInfo
            // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
            if (this.IpmiInfo == null && Exploration.Includes(parent + ".ipmiInfo"))
            {
                this.IpmiInfo = new ModifyIpmiReply();
                this.IpmiInfo.ApplyExploratoryFragment(parent + ".ipmiInfo");
            }
        }


    #endregion

    } // class ClusterWebCertAndIpmi
    #endregion

    public static class ListClusterWebCertAndIpmiExtensions
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
            this List<ClusterWebCertAndIpmi> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterWebCertAndIpmi> list, 
            String parent = "")
        {
            var item = new ClusterWebCertAndIpmi();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types