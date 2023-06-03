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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region DownloadPackageStatusReply
    public class DownloadPackageStatusReply: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Availability
        // GraphQL -> availability: String! (scalar)
        if (this.Availability != null) {
            s += ind + "availability\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (this.Md5Sum != null) {
            s += ind + "md5Sum\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            s += ind + "version\n" ;
        }
        //      C# -> DownloadJobInfo? DownloadJobInfo
        // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
        if (this.DownloadJobInfo != null) {
            s += ind + "downloadJobInfo {\n" + this.DownloadJobInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Availability
        // GraphQL -> availability: String! (scalar)
        if (this.Availability == null && Exploration.Includes(parent + ".availability", true))
        {
            this.Availability = new System.String("FETCH");
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = new System.String("FETCH");
        }
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (this.Md5Sum == null && Exploration.Includes(parent + ".md5Sum", true))
        {
            this.Md5Sum = new System.String("FETCH");
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version == null && Exploration.Includes(parent + ".version", true))
        {
            this.Version = new System.String("FETCH");
        }
        //      C# -> DownloadJobInfo? DownloadJobInfo
        // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
        if (this.DownloadJobInfo == null && Exploration.Includes(parent + ".downloadJobInfo"))
        {
            this.DownloadJobInfo = new DownloadJobInfo();
            this.DownloadJobInfo.ApplyExploratoryFieldSpec(parent + ".downloadJobInfo");
        }
    }


    #endregion

    } // class DownloadPackageStatusReply
    
    #endregion

    public static class ListDownloadPackageStatusReplyExtensions
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
            this List<DownloadPackageStatusReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DownloadPackageStatusReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadPackageStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types