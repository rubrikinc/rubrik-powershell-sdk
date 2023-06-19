// ExportUrlSpecs.cs
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
    #region ExportUrlSpecs
    public class ExportUrlSpecs: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        if (this.BlobName != null) {
            s += ind + "blobName\n" ;
        }
        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        if (this.BlobSasUri != null) {
            s += ind + "blobSasUri\n" ;
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount != null) {
            s += ind + "polarisAccount\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        if (this.BlobName == null && Exploration.Includes(parent + ".blobName", true))
        {
            this.BlobName = "FETCH";
        }
        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        if (this.BlobSasUri == null && Exploration.Includes(parent + ".blobSasUri", true))
        {
            this.BlobSasUri = "FETCH";
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount == null && Exploration.Includes(parent + ".polarisAccount", true))
        {
            this.PolarisAccount = "FETCH";
        }
    }


    #endregion

    } // class ExportUrlSpecs
    
    #endregion

    public static class ListExportUrlSpecsExtensions
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
            this List<ExportUrlSpecs> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExportUrlSpecs> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ExportUrlSpecs());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types