// NcdVmImageUrl.cs
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
    #region NcdVmImageUrl
    public class NcdVmImageUrl: BaseType
    {
        #region members

        //      C# -> System.String? DownloadUrl
        // GraphQL -> downloadUrl: String! (scalar)
        [JsonProperty("downloadUrl")]
        public System.String? DownloadUrl { get; set; }

        //      C# -> System.String? Sha256
        // GraphQL -> sha256: String! (scalar)
        [JsonProperty("sha256")]
        public System.String? Sha256 { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdVmImageUrl";
    }

    public NcdVmImageUrl Set(
        System.String? DownloadUrl = null,
        System.String? Sha256 = null,
        System.Int64? Size = null
    ) 
    {
        if ( DownloadUrl != null ) {
            this.DownloadUrl = DownloadUrl;
        }
        if ( Sha256 != null ) {
            this.Sha256 = Sha256;
        }
        if ( Size != null ) {
            this.Size = Size;
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
        //      C# -> System.String? DownloadUrl
        // GraphQL -> downloadUrl: String! (scalar)
        if (this.DownloadUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadUrl\n" ;
            } else {
                s += ind + "downloadUrl\n" ;
            }
        }
        //      C# -> System.String? Sha256
        // GraphQL -> sha256: String! (scalar)
        if (this.Sha256 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha256\n" ;
            } else {
                s += ind + "sha256\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DownloadUrl
        // GraphQL -> downloadUrl: String! (scalar)
        if (ec.Includes("downloadUrl",true))
        {
            if(this.DownloadUrl == null) {

                this.DownloadUrl = "FETCH";

            } else {


            }
        }
        else if (this.DownloadUrl != null && ec.Excludes("downloadUrl",true))
        {
            this.DownloadUrl = null;
        }
        //      C# -> System.String? Sha256
        // GraphQL -> sha256: String! (scalar)
        if (ec.Includes("sha256",true))
        {
            if(this.Sha256 == null) {

                this.Sha256 = "FETCH";

            } else {


            }
        }
        else if (this.Sha256 != null && ec.Excludes("sha256",true))
        {
            this.Sha256 = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
    }


    #endregion

    } // class NcdVmImageUrl
    
    #endregion

    public static class ListNcdVmImageUrlExtensions
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
            this List<NcdVmImageUrl> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NcdVmImageUrl> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdVmImageUrl> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdVmImageUrl());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdVmImageUrl> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types