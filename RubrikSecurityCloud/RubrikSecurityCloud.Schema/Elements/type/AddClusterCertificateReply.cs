// AddClusterCertificateReply.cs
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
    #region AddClusterCertificateReply
    public class AddClusterCertificateReply: IFragment
    {
        #region members
        //      C# -> System.String? CertId
        // GraphQL -> certId: String! (scalar)
        [JsonProperty("certId")]
        public System.String? CertId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? Expiration
        // GraphQL -> expiration: DateTime (scalar)
        [JsonProperty("expiration")]
        public DateTime? Expiration { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> System.Boolean? IsTrusted
        // GraphQL -> isTrusted: Boolean (scalar)
        [JsonProperty("isTrusted")]
        public System.Boolean? IsTrusted { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PemFile
        // GraphQL -> pemFile: String! (scalar)
        [JsonProperty("pemFile")]
        public System.String? PemFile { get; set; }

        //      C# -> System.String? UsedBy
        // GraphQL -> usedBy: String! (scalar)
        [JsonProperty("usedBy")]
        public System.String? UsedBy { get; set; }

        #endregion

    #region methods

    public AddClusterCertificateReply Set(
        System.String? CertId = null,
        System.String? Description = null,
        DateTime? Expiration = null,
        System.Boolean? HasKey = null,
        System.Boolean? IsTrusted = null,
        System.String? Name = null,
        System.String? PemFile = null,
        System.String? UsedBy = null
    ) 
    {
        if ( CertId != null ) {
            this.CertId = CertId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Expiration != null ) {
            this.Expiration = Expiration;
        }
        if ( HasKey != null ) {
            this.HasKey = HasKey;
        }
        if ( IsTrusted != null ) {
            this.IsTrusted = IsTrusted;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PemFile != null ) {
            this.PemFile = PemFile;
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
            //      C# -> System.String? CertId
            // GraphQL -> certId: String! (scalar)
            if (this.CertId != null)
            {
                 s += ind + "certId\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> DateTime? Expiration
            // GraphQL -> expiration: DateTime (scalar)
            if (this.Expiration != null)
            {
                 s += ind + "expiration\n";

            }
            //      C# -> System.Boolean? HasKey
            // GraphQL -> hasKey: Boolean! (scalar)
            if (this.HasKey != null)
            {
                 s += ind + "hasKey\n";

            }
            //      C# -> System.Boolean? IsTrusted
            // GraphQL -> isTrusted: Boolean (scalar)
            if (this.IsTrusted != null)
            {
                 s += ind + "isTrusted\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? PemFile
            // GraphQL -> pemFile: String! (scalar)
            if (this.PemFile != null)
            {
                 s += ind + "pemFile\n";

            }
            //      C# -> System.String? UsedBy
            // GraphQL -> usedBy: String! (scalar)
            if (this.UsedBy != null)
            {
                 s += ind + "usedBy\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CertId
            // GraphQL -> certId: String! (scalar)
            if (this.CertId == null && Exploration.Includes(parent + ".certId$"))
            {
                this.CertId = new System.String("FETCH");
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> DateTime? Expiration
            // GraphQL -> expiration: DateTime (scalar)
            if (this.Expiration == null && Exploration.Includes(parent + ".expiration$"))
            {
                this.Expiration = new DateTime();
            }
            //      C# -> System.Boolean? HasKey
            // GraphQL -> hasKey: Boolean! (scalar)
            if (this.HasKey == null && Exploration.Includes(parent + ".hasKey$"))
            {
                this.HasKey = new System.Boolean();
            }
            //      C# -> System.Boolean? IsTrusted
            // GraphQL -> isTrusted: Boolean (scalar)
            if (this.IsTrusted == null && Exploration.Includes(parent + ".isTrusted$"))
            {
                this.IsTrusted = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? PemFile
            // GraphQL -> pemFile: String! (scalar)
            if (this.PemFile == null && Exploration.Includes(parent + ".pemFile$"))
            {
                this.PemFile = new System.String("FETCH");
            }
            //      C# -> System.String? UsedBy
            // GraphQL -> usedBy: String! (scalar)
            if (this.UsedBy == null && Exploration.Includes(parent + ".usedBy$"))
            {
                this.UsedBy = new System.String("FETCH");
            }
        }


    #endregion

    } // class AddClusterCertificateReply
    #endregion

    public static class ListAddClusterCertificateReplyExtensions
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
            this List<AddClusterCertificateReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AddClusterCertificateReply> list, 
            String parent = "")
        {
            var item = new AddClusterCertificateReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types