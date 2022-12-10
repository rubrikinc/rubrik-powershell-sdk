// ExportUrlSpecs.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
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
    #region ExportUrlSpecs
    public class ExportUrlSpecs: IFragment
    {
        #region members
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        [JsonProperty("blobName")]
        public System.String? BlobName { get; set; }

        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        [JsonProperty("blobSasUri")]
        public System.String? BlobSasUri { get; set; }

        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        [JsonProperty("polarisAccount")]
        public System.String? PolarisAccount { get; set; }

        #endregion

    #region methods

    public ExportUrlSpecs Set(
        System.String? BlobName = null,
        System.String? BlobSasUri = null,
        System.String? PolarisAccount = null
    ) 
    {
        if ( BlobName != null ) {
            this.BlobName = BlobName;
        }
        if ( BlobSasUri != null ) {
            this.BlobSasUri = BlobSasUri;
        }
        if ( PolarisAccount != null ) {
            this.PolarisAccount = PolarisAccount;
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
            //      C# -> System.String? BlobName
            // GraphQL -> blobName: String! (scalar)
            if (this.BlobName != null)
            {
                 s += ind + "blobName\n";

            }
            //      C# -> System.String? BlobSasUri
            // GraphQL -> blobSasUri: String! (scalar)
            if (this.BlobSasUri != null)
            {
                 s += ind + "blobSasUri\n";

            }
            //      C# -> System.String? PolarisAccount
            // GraphQL -> polarisAccount: String! (scalar)
            if (this.PolarisAccount != null)
            {
                 s += ind + "polarisAccount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? BlobName
            // GraphQL -> blobName: String! (scalar)
            if (this.BlobName == null && Exploration.Includes(parent + ".blobName$"))
            {
                this.BlobName = new System.String("FETCH");
            }
            //      C# -> System.String? BlobSasUri
            // GraphQL -> blobSasUri: String! (scalar)
            if (this.BlobSasUri == null && Exploration.Includes(parent + ".blobSasUri$"))
            {
                this.BlobSasUri = new System.String("FETCH");
            }
            //      C# -> System.String? PolarisAccount
            // GraphQL -> polarisAccount: String! (scalar)
            if (this.PolarisAccount == null && Exploration.Includes(parent + ".polarisAccount$"))
            {
                this.PolarisAccount = new System.String("FETCH");
            }
        }


    #endregion

    } // class ExportUrlSpecs
    #endregion

    public static class ListExportUrlSpecsExtensions
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
            this List<ExportUrlSpecs> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ExportUrlSpecs> list, 
            String parent = "")
        {
            var item = new ExportUrlSpecs();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types