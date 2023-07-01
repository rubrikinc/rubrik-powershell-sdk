// FilesetTemplateDetail.cs
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
    #region FilesetTemplateDetail
    public class FilesetTemplateDetail: BaseType
    {
        #region members

        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int (scalar)
        [JsonProperty("hostCount")]
        public System.Int32? HostCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        [JsonProperty("isCreatedByKupr")]
        public System.Boolean? IsCreatedByKupr { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.Int32? ShareCount
        // GraphQL -> shareCount: Int (scalar)
        [JsonProperty("shareCount")]
        public System.Int32? ShareCount { get; set; }

        //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
        // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
        [JsonProperty("filesetTemplateCreate")]
        public FilesetTemplateCreate? FilesetTemplateCreate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetTemplateDetail";
    }

    public FilesetTemplateDetail Set(
        System.Int32? HostCount = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsCreatedByKupr = null,
        System.String? PrimaryClusterId = null,
        System.Int32? ShareCount = null,
        FilesetTemplateCreate? FilesetTemplateCreate = null
    ) 
    {
        if ( HostCount != null ) {
            this.HostCount = HostCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsCreatedByKupr != null ) {
            this.IsCreatedByKupr = IsCreatedByKupr;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( ShareCount != null ) {
            this.ShareCount = ShareCount;
        }
        if ( FilesetTemplateCreate != null ) {
            this.FilesetTemplateCreate = FilesetTemplateCreate;
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
        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int (scalar)
        if (this.HostCount != null) {
            s += ind + "hostCount\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            s += ind + "isArchived\n" ;
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (this.IsCreatedByKupr != null) {
            s += ind + "isCreatedByKupr\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        //      C# -> System.Int32? ShareCount
        // GraphQL -> shareCount: Int (scalar)
        if (this.ShareCount != null) {
            s += ind + "shareCount\n" ;
        }
        //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
        // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
        if (this.FilesetTemplateCreate != null) {
            var fspec = this.FilesetTemplateCreate.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "filesetTemplateCreate {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int (scalar)
        if (this.HostCount == null && Exploration.Includes(parent + ".hostCount", true))
        {
            this.HostCount = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived", true))
        {
            this.IsArchived = true;
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (this.IsCreatedByKupr == null && Exploration.Includes(parent + ".isCreatedByKupr", true))
        {
            this.IsCreatedByKupr = true;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
        //      C# -> System.Int32? ShareCount
        // GraphQL -> shareCount: Int (scalar)
        if (this.ShareCount == null && Exploration.Includes(parent + ".shareCount", true))
        {
            this.ShareCount = Int32.MinValue;
        }
        //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
        // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
        if (this.FilesetTemplateCreate == null && Exploration.Includes(parent + ".filesetTemplateCreate"))
        {
            this.FilesetTemplateCreate = new FilesetTemplateCreate();
            this.FilesetTemplateCreate.ApplyExploratoryFieldSpec(parent + ".filesetTemplateCreate");
        }
    }


    #endregion

    } // class FilesetTemplateDetail
    
    #endregion

    public static class ListFilesetTemplateDetailExtensions
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
            this List<FilesetTemplateDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FilesetTemplateDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetTemplateDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types