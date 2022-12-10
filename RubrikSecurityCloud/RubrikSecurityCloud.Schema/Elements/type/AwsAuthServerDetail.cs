// AwsAuthServerDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:25.
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
    #region AwsAuthServerDetail
    public class AwsAuthServerDetail: IFragment
    {
        #region members
        //      C# -> System.String? Agency
        // GraphQL -> agency: String! (scalar)
        [JsonProperty("agency")]
        public System.String? Agency { get; set; }

        //      C# -> System.Int64? AuthServerCaCertId
        // GraphQL -> authServerCaCertId: Long! (scalar)
        [JsonProperty("authServerCaCertId")]
        public System.Int64? AuthServerCaCertId { get; set; }

        //      C# -> System.String? AuthServerHostName
        // GraphQL -> authServerHostName: String! (scalar)
        [JsonProperty("authServerHostName")]
        public System.String? AuthServerHostName { get; set; }

        //      C# -> System.Int64? AuthServerUserClientCertId
        // GraphQL -> authServerUserClientCertId: Long! (scalar)
        [JsonProperty("authServerUserClientCertId")]
        public System.Int64? AuthServerUserClientCertId { get; set; }

        //      C# -> System.String? RoleName
        // GraphQL -> roleName: String! (scalar)
        [JsonProperty("roleName")]
        public System.String? RoleName { get; set; }

        //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
        // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
        [JsonProperty("authServerAwsRegions")]
        public List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions { get; set; }

        #endregion

    #region methods

    public AwsAuthServerDetail Set(
        System.String? Agency = null,
        System.Int64? AuthServerCaCertId = null,
        System.String? AuthServerHostName = null,
        System.Int64? AuthServerUserClientCertId = null,
        System.String? RoleName = null,
        List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions = null
    ) 
    {
        if ( Agency != null ) {
            this.Agency = Agency;
        }
        if ( AuthServerCaCertId != null ) {
            this.AuthServerCaCertId = AuthServerCaCertId;
        }
        if ( AuthServerHostName != null ) {
            this.AuthServerHostName = AuthServerHostName;
        }
        if ( AuthServerUserClientCertId != null ) {
            this.AuthServerUserClientCertId = AuthServerUserClientCertId;
        }
        if ( RoleName != null ) {
            this.RoleName = RoleName;
        }
        if ( AuthServerAwsRegions != null ) {
            this.AuthServerAwsRegions = AuthServerAwsRegions;
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
            //      C# -> System.String? Agency
            // GraphQL -> agency: String! (scalar)
            if (this.Agency != null)
            {
                 s += ind + "agency\n";

            }
            //      C# -> System.Int64? AuthServerCaCertId
            // GraphQL -> authServerCaCertId: Long! (scalar)
            if (this.AuthServerCaCertId != null)
            {
                 s += ind + "authServerCaCertId\n";

            }
            //      C# -> System.String? AuthServerHostName
            // GraphQL -> authServerHostName: String! (scalar)
            if (this.AuthServerHostName != null)
            {
                 s += ind + "authServerHostName\n";

            }
            //      C# -> System.Int64? AuthServerUserClientCertId
            // GraphQL -> authServerUserClientCertId: Long! (scalar)
            if (this.AuthServerUserClientCertId != null)
            {
                 s += ind + "authServerUserClientCertId\n";

            }
            //      C# -> System.String? RoleName
            // GraphQL -> roleName: String! (scalar)
            if (this.RoleName != null)
            {
                 s += ind + "roleName\n";

            }
            //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
            // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
            if (this.AuthServerAwsRegions != null)
            {
                 s += ind + "authServerAwsRegions\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Agency
            // GraphQL -> agency: String! (scalar)
            if (this.Agency == null && Exploration.Includes(parent + ".agency$"))
            {
                this.Agency = new System.String("FETCH");
            }
            //      C# -> System.Int64? AuthServerCaCertId
            // GraphQL -> authServerCaCertId: Long! (scalar)
            if (this.AuthServerCaCertId == null && Exploration.Includes(parent + ".authServerCaCertId$"))
            {
                this.AuthServerCaCertId = new System.Int64();
            }
            //      C# -> System.String? AuthServerHostName
            // GraphQL -> authServerHostName: String! (scalar)
            if (this.AuthServerHostName == null && Exploration.Includes(parent + ".authServerHostName$"))
            {
                this.AuthServerHostName = new System.String("FETCH");
            }
            //      C# -> System.Int64? AuthServerUserClientCertId
            // GraphQL -> authServerUserClientCertId: Long! (scalar)
            if (this.AuthServerUserClientCertId == null && Exploration.Includes(parent + ".authServerUserClientCertId$"))
            {
                this.AuthServerUserClientCertId = new System.Int64();
            }
            //      C# -> System.String? RoleName
            // GraphQL -> roleName: String! (scalar)
            if (this.RoleName == null && Exploration.Includes(parent + ".roleName$"))
            {
                this.RoleName = new System.String("FETCH");
            }
            //      C# -> List<AwsAuthServerBasedCloudAccountRegion>? AuthServerAwsRegions
            // GraphQL -> authServerAwsRegions: [AwsAuthServerBasedCloudAccountRegion!]! (enum)
            if (this.AuthServerAwsRegions == null && Exploration.Includes(parent + ".authServerAwsRegions$"))
            {
                this.AuthServerAwsRegions = new List<AwsAuthServerBasedCloudAccountRegion>();
            }
        }


    #endregion

    } // class AwsAuthServerDetail
    #endregion

    public static class ListAwsAuthServerDetailExtensions
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
            this List<AwsAuthServerDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsAuthServerDetail> list, 
            String parent = "")
        {
            var item = new AwsAuthServerDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types