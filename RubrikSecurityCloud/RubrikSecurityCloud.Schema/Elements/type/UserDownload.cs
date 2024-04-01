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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "UserDownload";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DownloadIdentifierEnum? Identifier
        // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
        if (this.Identifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identifier\n" ;
            } else {
                s += ind + "identifier\n" ;
            }
        }
        //      C# -> DownloadStatusEnum? Status
        // GraphQL -> status: DownloadStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? CompleteTime
        // GraphQL -> completeTime: String! (scalar)
        if (this.CompleteTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completeTime\n" ;
            } else {
                s += ind + "completeTime\n" ;
            }
        }
        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        if (this.CreateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createTime\n" ;
            } else {
                s += ind + "createTime\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DownloadIdentifierEnum? Identifier
        // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
        if (ec.Includes("identifier",true))
        {
            if(this.Identifier == null) {

                this.Identifier = new DownloadIdentifierEnum();

            } else {


            }
        }
        else if (this.Identifier != null && ec.Excludes("identifier",true))
        {
            this.Identifier = null;
        }
        //      C# -> DownloadStatusEnum? Status
        // GraphQL -> status: DownloadStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new DownloadStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? CompleteTime
        // GraphQL -> completeTime: String! (scalar)
        if (ec.Includes("completeTime",true))
        {
            if(this.CompleteTime == null) {

                this.CompleteTime = "FETCH";

            } else {


            }
        }
        else if (this.CompleteTime != null && ec.Excludes("completeTime",true))
        {
            this.CompleteTime = null;
        }
        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        if (ec.Includes("createTime",true))
        {
            if(this.CreateTime == null) {

                this.CreateTime = "FETCH";

            } else {


            }
        }
        else if (this.CreateTime != null && ec.Excludes("createTime",true))
        {
            this.CreateTime = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = Int32.MinValue;

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
    }


    #endregion

    } // class UserDownload
    
    #endregion

    public static class ListUserDownloadExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<UserDownload> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UserDownload> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UserDownload> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UserDownload());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UserDownload> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types