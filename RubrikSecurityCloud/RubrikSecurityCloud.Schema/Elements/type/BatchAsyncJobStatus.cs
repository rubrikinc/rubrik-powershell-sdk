// BatchAsyncJobStatus.cs
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
    #region BatchAsyncJobStatus
    public class BatchAsyncJobStatus: BaseType
    {
        #region members

        //      C# -> List<AsyncJobStatusJobError>? Errors
        // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
        [JsonProperty("errors")]
        public List<AsyncJobStatusJobError>? Errors { get; set; }

        //      C# -> List<AsyncJobStatusJobId>? JobIds
        // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
        [JsonProperty("jobIds")]
        public List<AsyncJobStatusJobId>? JobIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BatchAsyncJobStatus";
    }

    public BatchAsyncJobStatus Set(
        List<AsyncJobStatusJobError>? Errors = null,
        List<AsyncJobStatusJobId>? JobIds = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( JobIds != null ) {
            this.JobIds = JobIds;
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
        //      C# -> List<AsyncJobStatusJobError>? Errors
        // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(conf.Child("errors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "errors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AsyncJobStatusJobId>? JobIds
        // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
        if (this.JobIds != null) {
            var fspec = this.JobIds.AsFieldSpec(conf.Child("jobIds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "jobIds" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AsyncJobStatusJobError>? Errors
        // GraphQL -> errors: [AsyncJobStatusJobError!]! (type)
        if (ec.Includes("errors",false))
        {
            if(this.Errors == null) {

                this.Errors = new List<AsyncJobStatusJobError>();
                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            } else {

                this.Errors.ApplyExploratoryFieldSpec(ec.NewChild("errors"));

            }
        }
        else if (this.Errors != null && ec.Excludes("errors",false))
        {
            this.Errors = null;
        }
        //      C# -> List<AsyncJobStatusJobId>? JobIds
        // GraphQL -> jobIds: [AsyncJobStatusJobId!]! (type)
        if (ec.Includes("jobIds",false))
        {
            if(this.JobIds == null) {

                this.JobIds = new List<AsyncJobStatusJobId>();
                this.JobIds.ApplyExploratoryFieldSpec(ec.NewChild("jobIds"));

            } else {

                this.JobIds.ApplyExploratoryFieldSpec(ec.NewChild("jobIds"));

            }
        }
        else if (this.JobIds != null && ec.Excludes("jobIds",false))
        {
            this.JobIds = null;
        }
    }


    #endregion

    } // class BatchAsyncJobStatus
    
    #endregion

    public static class ListBatchAsyncJobStatusExtensions
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
            this List<BatchAsyncJobStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BatchAsyncJobStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BatchAsyncJobStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchAsyncJobStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BatchAsyncJobStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types