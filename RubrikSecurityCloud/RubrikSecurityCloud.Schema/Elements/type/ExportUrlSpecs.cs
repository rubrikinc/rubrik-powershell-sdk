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

    public override string GetGqlTypeName() {
        return "ExportUrlSpecs";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        if (this.BlobName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blobName\n" ;
            } else {
                s += ind + "blobName\n" ;
            }
        }
        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        if (this.BlobSasUri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blobSasUri\n" ;
            } else {
                s += ind + "blobSasUri\n" ;
            }
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (this.PolarisAccount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "polarisAccount\n" ;
            } else {
                s += ind + "polarisAccount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BlobName
        // GraphQL -> blobName: String! (scalar)
        if (ec.Includes("blobName",true))
        {
            if(this.BlobName == null) {

                this.BlobName = "FETCH";

            } else {


            }
        }
        else if (this.BlobName != null && ec.Excludes("blobName",true))
        {
            this.BlobName = null;
        }
        //      C# -> System.String? BlobSasUri
        // GraphQL -> blobSasUri: String! (scalar)
        if (ec.Includes("blobSasUri",true))
        {
            if(this.BlobSasUri == null) {

                this.BlobSasUri = "FETCH";

            } else {


            }
        }
        else if (this.BlobSasUri != null && ec.Excludes("blobSasUri",true))
        {
            this.BlobSasUri = null;
        }
        //      C# -> System.String? PolarisAccount
        // GraphQL -> polarisAccount: String! (scalar)
        if (ec.Includes("polarisAccount",true))
        {
            if(this.PolarisAccount == null) {

                this.PolarisAccount = "FETCH";

            } else {


            }
        }
        else if (this.PolarisAccount != null && ec.Excludes("polarisAccount",true))
        {
            this.PolarisAccount = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExportUrlSpecs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExportUrlSpecs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExportUrlSpecs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types