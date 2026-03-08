// ActivityRemediationStatus.cs
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
    #region ActivityRemediationStatus
    public class ActivityRemediationStatus: BaseType
    {
        #region members

        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        [JsonProperty("remediationType")]
        public RemediationType? RemediationType { get; set; }

        //      C# -> RemediationState? State
        // GraphQL -> state: RemediationState! (enum)
        [JsonProperty("state")]
        public RemediationState? State { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        [JsonProperty("remediationId")]
        public System.String? RemediationId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityRemediationStatus";
    }

    public ActivityRemediationStatus Set(
        RemediationType? RemediationType = null,
        RemediationState? State = null,
        DateTime? CreatedAt = null,
        System.String? RemediationId = null
    ) 
    {
        if ( RemediationType != null ) {
            this.RemediationType = RemediationType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( RemediationId != null ) {
            this.RemediationId = RemediationId;
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
        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        if (this.RemediationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationType\n" ;
            } else {
                s += ind + "remediationType\n" ;
            }
        }
        //      C# -> RemediationState? State
        // GraphQL -> state: RemediationState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
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
        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        if (this.RemediationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationId\n" ;
            } else {
                s += ind + "remediationId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RemediationType? RemediationType
        // GraphQL -> remediationType: RemediationType! (enum)
        if (ec.Includes("remediationType",true))
        {
            if(this.RemediationType == null) {

                this.RemediationType = new RemediationType();

            } else {


            }
        }
        else if (this.RemediationType != null && ec.Excludes("remediationType",true))
        {
            this.RemediationType = null;
        }
        //      C# -> RemediationState? State
        // GraphQL -> state: RemediationState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new RemediationState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
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
        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        if (ec.Includes("remediationId",true))
        {
            if(this.RemediationId == null) {

                this.RemediationId = "FETCH";

            } else {


            }
        }
        else if (this.RemediationId != null && ec.Excludes("remediationId",true))
        {
            this.RemediationId = null;
        }
    }


    #endregion

    } // class ActivityRemediationStatus
    
    #endregion

    public static class ListActivityRemediationStatusExtensions
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
            this List<ActivityRemediationStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivityRemediationStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivityRemediationStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityRemediationStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivityRemediationStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types