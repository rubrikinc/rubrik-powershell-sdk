// LlmOperation.cs
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
    #region LlmOperation
    public class LlmOperation: BaseType
    {
        #region members

        //      C# -> LlmOperationStatus? Status
        // GraphQL -> status: LlmOperationStatus! (enum)
        [JsonProperty("status")]
        public LlmOperationStatus? Status { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.Int64? DownloadId
        // GraphQL -> downloadId: Long (scalar)
        [JsonProperty("downloadId")]
        public System.Int64? DownloadId { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? JobId
        // GraphQL -> jobId: String (scalar)
        [JsonProperty("jobId")]
        public System.String? JobId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.String? SerializedParams
        // GraphQL -> serializedParams: String! (scalar)
        [JsonProperty("serializedParams")]
        public System.String? SerializedParams { get; set; }

        //      C# -> System.String? SerializedResult
        // GraphQL -> serializedResult: String (scalar)
        [JsonProperty("serializedResult")]
        public System.String? SerializedResult { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LlmOperation";
    }

    public LlmOperation Set(
        LlmOperationStatus? Status = null,
        DateTime? CreatedAt = null,
        System.Int64? DownloadId = null,
        System.String? Error = null,
        System.String? Id = null,
        System.String? JobId = null,
        System.String? Name = null,
        System.Single? Progress = null,
        System.String? SerializedParams = null,
        System.String? SerializedResult = null,
        DateTime? UpdatedAt = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( DownloadId != null ) {
            this.DownloadId = DownloadId;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( SerializedParams != null ) {
            this.SerializedParams = SerializedParams;
        }
        if ( SerializedResult != null ) {
            this.SerializedResult = SerializedResult;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
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
        //      C# -> LlmOperationStatus? Status
        // GraphQL -> status: LlmOperationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.Int64? DownloadId
        // GraphQL -> downloadId: Long (scalar)
        if (this.DownloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadId\n" ;
            } else {
                s += ind + "downloadId\n" ;
            }
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String (scalar)
        if (this.JobId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobId\n" ;
            } else {
                s += ind + "jobId\n" ;
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
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.String? SerializedParams
        // GraphQL -> serializedParams: String! (scalar)
        if (this.SerializedParams != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serializedParams\n" ;
            } else {
                s += ind + "serializedParams\n" ;
            }
        }
        //      C# -> System.String? SerializedResult
        // GraphQL -> serializedResult: String (scalar)
        if (this.SerializedResult != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serializedResult\n" ;
            } else {
                s += ind + "serializedResult\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LlmOperationStatus? Status
        // GraphQL -> status: LlmOperationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new LlmOperationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.Int64? DownloadId
        // GraphQL -> downloadId: Long (scalar)
        if (ec.Includes("downloadId",true))
        {
            if(this.DownloadId == null) {

                this.DownloadId = new System.Int64();

            } else {


            }
        }
        else if (this.DownloadId != null && ec.Excludes("downloadId",true))
        {
            this.DownloadId = null;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String (scalar)
        if (ec.Includes("jobId",true))
        {
            if(this.JobId == null) {

                this.JobId = "FETCH";

            } else {


            }
        }
        else if (this.JobId != null && ec.Excludes("jobId",true))
        {
            this.JobId = null;
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
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.String? SerializedParams
        // GraphQL -> serializedParams: String! (scalar)
        if (ec.Includes("serializedParams",true))
        {
            if(this.SerializedParams == null) {

                this.SerializedParams = "FETCH";

            } else {


            }
        }
        else if (this.SerializedParams != null && ec.Excludes("serializedParams",true))
        {
            this.SerializedParams = null;
        }
        //      C# -> System.String? SerializedResult
        // GraphQL -> serializedResult: String (scalar)
        if (ec.Includes("serializedResult",true))
        {
            if(this.SerializedResult == null) {

                this.SerializedResult = "FETCH";

            } else {


            }
        }
        else if (this.SerializedResult != null && ec.Excludes("serializedResult",true))
        {
            this.SerializedResult = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
    }


    #endregion

    } // class LlmOperation
    
    #endregion

    public static class ListLlmOperationExtensions
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
            this List<LlmOperation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LlmOperation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LlmOperation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LlmOperation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LlmOperation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types