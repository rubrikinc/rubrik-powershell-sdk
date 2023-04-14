// DownloadPackageStatusReply.cs
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
    #region DownloadPackageStatusReply
    public class DownloadPackageStatusReply: IFragment
    {
        #region members
        //      C# -> System.String? Availability
        // GraphQL -> availability: String! (scalar)
        [JsonProperty("availability")]
        public System.String? Availability { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        [JsonProperty("md5Sum")]
        public System.String? Md5Sum { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> DownloadJobInfo? DownloadJobInfo
        // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
        [JsonProperty("downloadJobInfo")]
        public DownloadJobInfo? DownloadJobInfo { get; set; }

        #endregion

    #region methods

    public DownloadPackageStatusReply Set(
        System.String? Availability = null,
        System.String? Description = null,
        System.String? Md5Sum = null,
        System.Int64? Size = null,
        System.String? Version = null,
        DownloadJobInfo? DownloadJobInfo = null
    ) 
    {
        if ( Availability != null ) {
            this.Availability = Availability;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Md5Sum != null ) {
            this.Md5Sum = Md5Sum;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( DownloadJobInfo != null ) {
            this.DownloadJobInfo = DownloadJobInfo;
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
            //      C# -> System.String? Availability
            // GraphQL -> availability: String! (scalar)
            if (this.Availability != null)
            {
                 s += ind + "availability\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? Md5Sum
            // GraphQL -> md5Sum: String! (scalar)
            if (this.Md5Sum != null)
            {
                 s += ind + "md5Sum\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> DownloadJobInfo? DownloadJobInfo
            // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
            if (this.DownloadJobInfo != null)
            {
                 s += ind + "downloadJobInfo\n";

                 s += ind + "{\n" + 
                 this.DownloadJobInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Availability
            // GraphQL -> availability: String! (scalar)
            if (this.Availability == null && Exploration.Includes(parent + ".availability$"))
            {
                this.Availability = new System.String("FETCH");
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? Md5Sum
            // GraphQL -> md5Sum: String! (scalar)
            if (this.Md5Sum == null && Exploration.Includes(parent + ".md5Sum$"))
            {
                this.Md5Sum = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? Version
            // GraphQL -> version: String! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.String("FETCH");
            }
            //      C# -> DownloadJobInfo? DownloadJobInfo
            // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
            if (this.DownloadJobInfo == null && Exploration.Includes(parent + ".downloadJobInfo"))
            {
                this.DownloadJobInfo = new DownloadJobInfo();
                this.DownloadJobInfo.ApplyExploratoryFragment(parent + ".downloadJobInfo");
            }
        }


    #endregion

    } // class DownloadPackageStatusReply
    #endregion

    public static class ListDownloadPackageStatusReplyExtensions
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
            this List<DownloadPackageStatusReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DownloadPackageStatusReply> list, 
            String parent = "")
        {
            var item = new DownloadPackageStatusReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types