// PauseResumeArchivalUploadJobReply.cs
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
    #region PauseResumeArchivalUploadJobReply
    public class PauseResumeArchivalUploadJobReply: BaseType
    {
        #region members

        //      C# -> ArchivalUploadJobPauseAction? Action
        // GraphQL -> action: ArchivalUploadJobPauseAction! (enum)
        [JsonProperty("action")]
        public ArchivalUploadJobPauseAction? Action { get; set; }

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        [JsonProperty("jobInstanceId")]
        public System.String? JobInstanceId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PauseResumeArchivalUploadJobReply";
    }

    public PauseResumeArchivalUploadJobReply Set(
        ArchivalUploadJobPauseAction? Action = null,
        System.String? EventSeriesId = null,
        System.String? JobInstanceId = null
    ) 
    {
        if ( Action != null ) {
            this.Action = Action;
        }
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( JobInstanceId != null ) {
            this.JobInstanceId = JobInstanceId;
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
        //      C# -> ArchivalUploadJobPauseAction? Action
        // GraphQL -> action: ArchivalUploadJobPauseAction! (enum)
        if (this.Action != null) {
            if (conf.Flat) {
                s += conf.Prefix + "action\n" ;
            } else {
                s += ind + "action\n" ;
            }
        }
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (this.EventSeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventSeriesId\n" ;
            } else {
                s += ind + "eventSeriesId\n" ;
            }
        }
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (this.JobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "jobInstanceId\n" ;
            } else {
                s += ind + "jobInstanceId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ArchivalUploadJobPauseAction? Action
        // GraphQL -> action: ArchivalUploadJobPauseAction! (enum)
        if (ec.Includes("action",true))
        {
            if(this.Action == null) {

                this.Action = new ArchivalUploadJobPauseAction();

            } else {


            }
        }
        else if (this.Action != null && ec.Excludes("action",true))
        {
            this.Action = null;
        }
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        if (ec.Includes("eventSeriesId",true))
        {
            if(this.EventSeriesId == null) {

                this.EventSeriesId = "FETCH";

            } else {


            }
        }
        else if (this.EventSeriesId != null && ec.Excludes("eventSeriesId",true))
        {
            this.EventSeriesId = null;
        }
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        if (ec.Includes("jobInstanceId",true))
        {
            if(this.JobInstanceId == null) {

                this.JobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.JobInstanceId != null && ec.Excludes("jobInstanceId",true))
        {
            this.JobInstanceId = null;
        }
    }


    #endregion

    } // class PauseResumeArchivalUploadJobReply
    
    #endregion

    public static class ListPauseResumeArchivalUploadJobReplyExtensions
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
            this List<PauseResumeArchivalUploadJobReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PauseResumeArchivalUploadJobReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PauseResumeArchivalUploadJobReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PauseResumeArchivalUploadJobReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PauseResumeArchivalUploadJobReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types