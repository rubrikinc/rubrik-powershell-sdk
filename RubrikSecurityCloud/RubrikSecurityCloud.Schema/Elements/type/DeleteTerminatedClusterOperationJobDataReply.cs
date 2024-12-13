// DeleteTerminatedClusterOperationJobDataReply.cs
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
    #region DeleteTerminatedClusterOperationJobDataReply
    public class DeleteTerminatedClusterOperationJobDataReply: BaseType
    {
        #region members

        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        [JsonProperty("jobStatus")]
        public CdmJobStatus? JobStatus { get; set; }

        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        [JsonProperty("jobType")]
        public CcpJobType? JobType { get; set; }

        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        [JsonProperty("jobProgress")]
        public System.Int32? JobProgress { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteTerminatedClusterOperationJobDataReply";
    }

    public DeleteTerminatedClusterOperationJobDataReply Set(
        CdmJobStatus? JobStatus = null,
        CcpJobType? JobType = null,
        System.Int32? JobProgress = null,
        System.String? Message = null
    ) 
    {
        if ( JobStatus != null ) {
            this.JobStatus = JobStatus;
        }
        if ( JobType != null ) {
            this.JobType = JobType;
        }
        if ( JobProgress != null ) {
            this.JobProgress = JobProgress;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        if (this.JobStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobStatus\n" ;
            } else {
                s += ind + "jobStatus\n" ;
            }
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (this.JobType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobType\n" ;
            } else {
                s += ind + "jobType\n" ;
            }
        }
        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        if (this.JobProgress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobProgress\n" ;
            } else {
                s += ind + "jobProgress\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CdmJobStatus? JobStatus
        // GraphQL -> jobStatus: CdmJobStatus! (enum)
        if (ec.Includes("jobStatus",true))
        {
            if(this.JobStatus == null) {

                this.JobStatus = new CdmJobStatus();

            } else {


            }
        }
        else if (this.JobStatus != null && ec.Excludes("jobStatus",true))
        {
            this.JobStatus = null;
        }
        //      C# -> CcpJobType? JobType
        // GraphQL -> jobType: CcpJobType! (enum)
        if (ec.Includes("jobType",true))
        {
            if(this.JobType == null) {

                this.JobType = new CcpJobType();

            } else {


            }
        }
        else if (this.JobType != null && ec.Excludes("jobType",true))
        {
            this.JobType = null;
        }
        //      C# -> System.Int32? JobProgress
        // GraphQL -> jobProgress: Int! (scalar)
        if (ec.Includes("jobProgress",true))
        {
            if(this.JobProgress == null) {

                this.JobProgress = Int32.MinValue;

            } else {


            }
        }
        else if (this.JobProgress != null && ec.Excludes("jobProgress",true))
        {
            this.JobProgress = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
    }


    #endregion

    } // class DeleteTerminatedClusterOperationJobDataReply
    
    #endregion

    public static class ListDeleteTerminatedClusterOperationJobDataReplyExtensions
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
            this List<DeleteTerminatedClusterOperationJobDataReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DeleteTerminatedClusterOperationJobDataReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteTerminatedClusterOperationJobDataReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteTerminatedClusterOperationJobDataReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteTerminatedClusterOperationJobDataReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types