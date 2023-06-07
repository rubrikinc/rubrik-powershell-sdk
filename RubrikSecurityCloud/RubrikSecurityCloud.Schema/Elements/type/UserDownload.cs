// UserDownload.cs
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
    #region UserDownload
    public class UserDownload: BaseType
    {
        #region members

        //      C# -> DownloadIdentifierEnum? Identifier
        // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
        [JsonProperty("identifier")]
        public DownloadIdentifierEnum? Identifier { get; set; }

        //      C# -> DownloadStatusEnum? Status
        // GraphQL -> status: DownloadStatusEnum! (enum)
        [JsonProperty("status")]
        public DownloadStatusEnum? Status { get; set; }

        //      C# -> System.String? CompleteTime
        // GraphQL -> completeTime: String! (scalar)
        [JsonProperty("completeTime")]
        public System.String? CompleteTime { get; set; }

        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        [JsonProperty("createTime")]
        public System.String? CreateTime { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        [JsonProperty("progress")]
        public System.Int32? Progress { get; set; }


        #endregion

    #region methods

    public UserDownload Set(
        DownloadIdentifierEnum? Identifier = null,
        DownloadStatusEnum? Status = null,
        System.String? CompleteTime = null,
        System.String? CreateTime = null,
        System.Int64? Id = null,
        System.String? Name = null,
        System.Int32? Progress = null
    ) 
    {
        if ( Identifier != null ) {
            this.Identifier = Identifier;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CompleteTime != null ) {
            this.CompleteTime = CompleteTime;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
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
        //      C# -> DownloadIdentifierEnum? Identifier
        // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
        if (this.Identifier != null) {
            s += ind + "identifier\n" ;
        }
        //      C# -> DownloadStatusEnum? Status
        // GraphQL -> status: DownloadStatusEnum! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? CompleteTime
        // GraphQL -> completeTime: String! (scalar)
        if (this.CompleteTime != null) {
            s += ind + "completeTime\n" ;
        }
        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        if (this.CreateTime != null) {
            s += ind + "createTime\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress != null) {
            s += ind + "progress\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DownloadIdentifierEnum? Identifier
        // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
        if (this.Identifier == null && Exploration.Includes(parent + ".identifier", true))
        {
            this.Identifier = new DownloadIdentifierEnum();
        }
        //      C# -> DownloadStatusEnum? Status
        // GraphQL -> status: DownloadStatusEnum! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new DownloadStatusEnum();
        }
        //      C# -> System.String? CompleteTime
        // GraphQL -> completeTime: String! (scalar)
        if (this.CompleteTime == null && Exploration.Includes(parent + ".completeTime", true))
        {
            this.CompleteTime = "FETCH";
        }
        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        if (this.CreateTime == null && Exploration.Includes(parent + ".createTime", true))
        {
            this.CreateTime = "FETCH";
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress == null && Exploration.Includes(parent + ".progress", true))
        {
            this.Progress = Int32.MinValue;
        }
    }


    #endregion

    } // class UserDownload
    
    #endregion

    public static class ListUserDownloadExtensions
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
            this List<UserDownload> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UserDownload> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UserDownload());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types