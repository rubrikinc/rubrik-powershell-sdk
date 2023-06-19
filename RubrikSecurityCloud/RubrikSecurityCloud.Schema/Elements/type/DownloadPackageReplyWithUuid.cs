// DownloadPackageReplyWithUuid.cs
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
    #region DownloadPackageReplyWithUuid
    public class DownloadPackageReplyWithUuid: BaseType
    {
        #region members

        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        [JsonProperty("jobId")]
        public System.String? JobId { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }


        #endregion

    #region methods

    public DownloadPackageReplyWithUuid Set(
        System.String? JobId = null,
        System.String? Uuid = null
    ) 
    {
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
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
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        if (this.JobId != null) {
            s += ind + "jobId\n" ;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid != null) {
            s += ind + "uuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        if (this.JobId == null && Exploration.Includes(parent + ".jobId", true))
        {
            this.JobId = "FETCH";
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid == null && Exploration.Includes(parent + ".uuid", true))
        {
            this.Uuid = "FETCH";
        }
    }


    #endregion

    } // class DownloadPackageReplyWithUuid
    
    #endregion

    public static class ListDownloadPackageReplyWithUuidExtensions
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
            this List<DownloadPackageReplyWithUuid> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DownloadPackageReplyWithUuid> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadPackageReplyWithUuid());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types