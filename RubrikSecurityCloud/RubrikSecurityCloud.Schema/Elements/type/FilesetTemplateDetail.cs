// FilesetTemplateDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
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
    #region FilesetTemplateDetail
    public class FilesetTemplateDetail: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? HostCount
            // GraphQL -> hostCount: Int (scalar)
            if (this.HostCount != null)
            {
                 s += ind + "hostCount\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean (scalar)
            if (this.IsArchived != null)
            {
                 s += ind + "isArchived\n";

            }
            //      C# -> System.Boolean? IsCreatedByKupr
            // GraphQL -> isCreatedByKupr: Boolean (scalar)
            if (this.IsCreatedByKupr != null)
            {
                 s += ind + "isCreatedByKupr\n";

            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> System.Int32? ShareCount
            // GraphQL -> shareCount: Int (scalar)
            if (this.ShareCount != null)
            {
                 s += ind + "shareCount\n";

            }
            //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
            // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
            if (this.FilesetTemplateCreate != null)
            {
                 s += ind + "filesetTemplateCreate\n";

                 s += ind + "{\n" + 
                 this.FilesetTemplateCreate.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? HostCount
            // GraphQL -> hostCount: Int (scalar)
            if (this.HostCount == null && Exploration.Includes(parent + ".hostCount$"))
            {
                this.HostCount = new System.Int32();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsArchived
            // GraphQL -> isArchived: Boolean (scalar)
            if (this.IsArchived == null && Exploration.Includes(parent + ".isArchived$"))
            {
                this.IsArchived = new System.Boolean();
            }
            //      C# -> System.Boolean? IsCreatedByKupr
            // GraphQL -> isCreatedByKupr: Boolean (scalar)
            if (this.IsCreatedByKupr == null && Exploration.Includes(parent + ".isCreatedByKupr$"))
            {
                this.IsCreatedByKupr = new System.Boolean();
            }
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> System.Int32? ShareCount
            // GraphQL -> shareCount: Int (scalar)
            if (this.ShareCount == null && Exploration.Includes(parent + ".shareCount$"))
            {
                this.ShareCount = new System.Int32();
            }
            //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
            // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
            if (this.FilesetTemplateCreate == null && Exploration.Includes(parent + ".filesetTemplateCreate"))
            {
                this.FilesetTemplateCreate = new FilesetTemplateCreate();
                this.FilesetTemplateCreate.ApplyExploratoryFragment(parent + ".filesetTemplateCreate");
            }
        }


    #endregion

    } // class FilesetTemplateDetail
    #endregion

    public static class ListFilesetTemplateDetailExtensions
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
            this List<FilesetTemplateDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetTemplateDetail> list, 
            String parent = "")
        {
            var item = new FilesetTemplateDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types