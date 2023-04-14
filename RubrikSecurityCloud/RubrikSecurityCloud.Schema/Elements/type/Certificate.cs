// Certificate.cs
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
    #region Certificate
    public class Certificate: IFragment
    {
        #region members
        //      C# -> System.String? CertificateField
        // GraphQL -> certificate: String! (scalar)
        [JsonProperty("certificate")]
        public System.String? CertificateField { get; set; }

        //      C# -> System.Int64? CertificateId
        // GraphQL -> certificateId: Long! (scalar)
        [JsonProperty("certificateId")]
        public System.Int64? CertificateId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        [JsonProperty("expiringAt")]
        public DateTime? ExpiringAt { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? UsedBy
        // GraphQL -> usedBy: [String!]! (scalar)
        [JsonProperty("usedBy")]
        public List<System.String>? UsedBy { get; set; }

        #endregion

    #region methods

    public Certificate Set(
        System.String? CertificateField = null,
        System.Int64? CertificateId = null,
        System.String? Description = null,
        DateTime? ExpiringAt = null,
        System.Boolean? HasKey = null,
        System.String? Name = null,
        List<System.String>? UsedBy = null
    ) 
    {
        if ( CertificateField != null ) {
            this.CertificateField = CertificateField;
        }
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( ExpiringAt != null ) {
            this.ExpiringAt = ExpiringAt;
        }
        if ( HasKey != null ) {
            this.HasKey = HasKey;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( UsedBy != null ) {
            this.UsedBy = UsedBy;
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
            //      C# -> System.String? CertificateField
            // GraphQL -> certificate: String! (scalar)
            if (this.CertificateField != null)
            {
                 s += ind + "certificate\n";

            }
            //      C# -> System.Int64? CertificateId
            // GraphQL -> certificateId: Long! (scalar)
            if (this.CertificateId != null)
            {
                 s += ind + "certificateId\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> DateTime? ExpiringAt
            // GraphQL -> expiringAt: DateTime (scalar)
            if (this.ExpiringAt != null)
            {
                 s += ind + "expiringAt\n";

            }
            //      C# -> System.Boolean? HasKey
            // GraphQL -> hasKey: Boolean! (scalar)
            if (this.HasKey != null)
            {
                 s += ind + "hasKey\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> List<System.String>? UsedBy
            // GraphQL -> usedBy: [String!]! (scalar)
            if (this.UsedBy != null)
            {
                 s += ind + "usedBy\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CertificateField
            // GraphQL -> certificate: String! (scalar)
            if (this.CertificateField == null && Exploration.Includes(parent + ".certificate$"))
            {
                this.CertificateField = new System.String("FETCH");
            }
            //      C# -> System.Int64? CertificateId
            // GraphQL -> certificateId: Long! (scalar)
            if (this.CertificateId == null && Exploration.Includes(parent + ".certificateId$"))
            {
                this.CertificateId = new System.Int64();
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> DateTime? ExpiringAt
            // GraphQL -> expiringAt: DateTime (scalar)
            if (this.ExpiringAt == null && Exploration.Includes(parent + ".expiringAt$"))
            {
                this.ExpiringAt = new DateTime();
            }
            //      C# -> System.Boolean? HasKey
            // GraphQL -> hasKey: Boolean! (scalar)
            if (this.HasKey == null && Exploration.Includes(parent + ".hasKey$"))
            {
                this.HasKey = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> List<System.String>? UsedBy
            // GraphQL -> usedBy: [String!]! (scalar)
            if (this.UsedBy == null && Exploration.Includes(parent + ".usedBy$"))
            {
                this.UsedBy = new List<System.String>();
            }
        }


    #endregion

    } // class Certificate
    #endregion

    public static class ListCertificateExtensions
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
            this List<Certificate> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Certificate> list, 
            String parent = "")
        {
            var item = new Certificate();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types