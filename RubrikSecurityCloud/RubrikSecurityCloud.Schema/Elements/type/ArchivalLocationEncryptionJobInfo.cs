// ArchivalLocationEncryptionJobInfo.cs
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
    #region ArchivalLocationEncryptionJobInfo
    public class ArchivalLocationEncryptionJobInfo: BaseType
    {
        #region members

        //      C# -> ArchivalLocationEncryptionJobStatus? Status
        // GraphQL -> status: ArchivalLocationEncryptionJobStatus! (enum)
        [JsonProperty("status")]
        public ArchivalLocationEncryptionJobStatus? Status { get; set; }

        //      C# -> DateTime? CompletionTime
        // GraphQL -> completionTime: DateTime (scalar)
        [JsonProperty("completionTime")]
        public DateTime? CompletionTime { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Boolean? IsAutomaticEncryptionJob
        // GraphQL -> isAutomaticEncryptionJob: Boolean! (scalar)
        [JsonProperty("isAutomaticEncryptionJob")]
        public System.Boolean? IsAutomaticEncryptionJob { get; set; }

        //      C# -> DateTime? RequestedTime
        // GraphQL -> requestedTime: DateTime (scalar)
        [JsonProperty("requestedTime")]
        public DateTime? RequestedTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationEncryptionJobInfo";
    }

    public ArchivalLocationEncryptionJobInfo Set(
        ArchivalLocationEncryptionJobStatus? Status = null,
        DateTime? CompletionTime = null,
        System.String? ErrorMessage = null,
        System.Boolean? IsAutomaticEncryptionJob = null,
        DateTime? RequestedTime = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CompletionTime != null ) {
            this.CompletionTime = CompletionTime;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( IsAutomaticEncryptionJob != null ) {
            this.IsAutomaticEncryptionJob = IsAutomaticEncryptionJob;
        }
        if ( RequestedTime != null ) {
            this.RequestedTime = RequestedTime;
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
        //      C# -> ArchivalLocationEncryptionJobStatus? Status
        // GraphQL -> status: ArchivalLocationEncryptionJobStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? CompletionTime
        // GraphQL -> completionTime: DateTime (scalar)
        if (this.CompletionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completionTime\n" ;
            } else {
                s += ind + "completionTime\n" ;
            }
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Boolean? IsAutomaticEncryptionJob
        // GraphQL -> isAutomaticEncryptionJob: Boolean! (scalar)
        if (this.IsAutomaticEncryptionJob != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAutomaticEncryptionJob\n" ;
            } else {
                s += ind + "isAutomaticEncryptionJob\n" ;
            }
        }
        //      C# -> DateTime? RequestedTime
        // GraphQL -> requestedTime: DateTime (scalar)
        if (this.RequestedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestedTime\n" ;
            } else {
                s += ind + "requestedTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArchivalLocationEncryptionJobStatus? Status
        // GraphQL -> status: ArchivalLocationEncryptionJobStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ArchivalLocationEncryptionJobStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? CompletionTime
        // GraphQL -> completionTime: DateTime (scalar)
        if (ec.Includes("completionTime",true))
        {
            if(this.CompletionTime == null) {

                this.CompletionTime = new DateTime();

            } else {


            }
        }
        else if (this.CompletionTime != null && ec.Excludes("completionTime",true))
        {
            this.CompletionTime = null;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Boolean? IsAutomaticEncryptionJob
        // GraphQL -> isAutomaticEncryptionJob: Boolean! (scalar)
        if (ec.Includes("isAutomaticEncryptionJob",true))
        {
            if(this.IsAutomaticEncryptionJob == null) {

                this.IsAutomaticEncryptionJob = true;

            } else {


            }
        }
        else if (this.IsAutomaticEncryptionJob != null && ec.Excludes("isAutomaticEncryptionJob",true))
        {
            this.IsAutomaticEncryptionJob = null;
        }
        //      C# -> DateTime? RequestedTime
        // GraphQL -> requestedTime: DateTime (scalar)
        if (ec.Includes("requestedTime",true))
        {
            if(this.RequestedTime == null) {

                this.RequestedTime = new DateTime();

            } else {


            }
        }
        else if (this.RequestedTime != null && ec.Excludes("requestedTime",true))
        {
            this.RequestedTime = null;
        }
    }


    #endregion

    } // class ArchivalLocationEncryptionJobInfo
    
    #endregion

    public static class ListArchivalLocationEncryptionJobInfoExtensions
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
            this List<ArchivalLocationEncryptionJobInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationEncryptionJobInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationEncryptionJobInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationEncryptionJobInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationEncryptionJobInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types