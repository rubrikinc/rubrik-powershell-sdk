// DefenderAlertViolationDetails.cs
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
    #region DefenderAlertViolationDetails
 
    public class DefenderAlertViolationDetails: BaseType, ViolationDetailsUnion
    {
        #region members

        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        [JsonProperty("actorIdentityId")]
        public System.String? ActorIdentityId { get; set; }

        //      C# -> System.String? AlertWebUrl
        // GraphQL -> alertWebUrl: String! (scalar)
        [JsonProperty("alertWebUrl")]
        public System.String? AlertWebUrl { get; set; }

        //      C# -> System.String? DefenderAlertId
        // GraphQL -> defenderAlertId: String! (scalar)
        [JsonProperty("defenderAlertId")]
        public System.String? DefenderAlertId { get; set; }

        //      C# -> System.String? DetectionDescription
        // GraphQL -> detectionDescription: String! (scalar)
        [JsonProperty("detectionDescription")]
        public System.String? DetectionDescription { get; set; }

        //      C# -> System.String? DetectionName
        // GraphQL -> detectionName: String! (scalar)
        [JsonProperty("detectionName")]
        public System.String? DetectionName { get; set; }

        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        [JsonProperty("detectionTime")]
        public DateTime? DetectionTime { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? MitreTactic
        // GraphQL -> mitreTactic: String! (scalar)
        [JsonProperty("mitreTactic")]
        public System.String? MitreTactic { get; set; }

        //      C# -> List<System.String>? MitreTechniques
        // GraphQL -> mitreTechniques: [String!]! (scalar)
        [JsonProperty("mitreTechniques")]
        public List<System.String>? MitreTechniques { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? TargetIdentityId
        // GraphQL -> targetIdentityId: String! (scalar)
        [JsonProperty("targetIdentityId")]
        public System.String? TargetIdentityId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DefenderAlertViolationDetails";
    }

    public DefenderAlertViolationDetails Set(
        System.String? ActorIdentityId = null,
        System.String? AlertWebUrl = null,
        System.String? DefenderAlertId = null,
        System.String? DetectionDescription = null,
        System.String? DetectionName = null,
        DateTime? DetectionTime = null,
        DateTime? EndTime = null,
        System.String? MitreTactic = null,
        List<System.String>? MitreTechniques = null,
        DateTime? StartTime = null,
        System.String? TargetIdentityId = null
    ) 
    {
        if ( ActorIdentityId != null ) {
            this.ActorIdentityId = ActorIdentityId;
        }
        if ( AlertWebUrl != null ) {
            this.AlertWebUrl = AlertWebUrl;
        }
        if ( DefenderAlertId != null ) {
            this.DefenderAlertId = DefenderAlertId;
        }
        if ( DetectionDescription != null ) {
            this.DetectionDescription = DetectionDescription;
        }
        if ( DetectionName != null ) {
            this.DetectionName = DetectionName;
        }
        if ( DetectionTime != null ) {
            this.DetectionTime = DetectionTime;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( MitreTactic != null ) {
            this.MitreTactic = MitreTactic;
        }
        if ( MitreTechniques != null ) {
            this.MitreTechniques = MitreTechniques;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TargetIdentityId != null ) {
            this.TargetIdentityId = TargetIdentityId;
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
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (this.ActorIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityId\n" ;
            } else {
                s += ind + "actorIdentityId\n" ;
            }
        }
        //      C# -> System.String? AlertWebUrl
        // GraphQL -> alertWebUrl: String! (scalar)
        if (this.AlertWebUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "alertWebUrl\n" ;
            } else {
                s += ind + "alertWebUrl\n" ;
            }
        }
        //      C# -> System.String? DefenderAlertId
        // GraphQL -> defenderAlertId: String! (scalar)
        if (this.DefenderAlertId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defenderAlertId\n" ;
            } else {
                s += ind + "defenderAlertId\n" ;
            }
        }
        //      C# -> System.String? DetectionDescription
        // GraphQL -> detectionDescription: String! (scalar)
        if (this.DetectionDescription != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectionDescription\n" ;
            } else {
                s += ind + "detectionDescription\n" ;
            }
        }
        //      C# -> System.String? DetectionName
        // GraphQL -> detectionName: String! (scalar)
        if (this.DetectionName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectionName\n" ;
            } else {
                s += ind + "detectionName\n" ;
            }
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        if (this.DetectionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectionTime\n" ;
            } else {
                s += ind + "detectionTime\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? MitreTactic
        // GraphQL -> mitreTactic: String! (scalar)
        if (this.MitreTactic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mitreTactic\n" ;
            } else {
                s += ind + "mitreTactic\n" ;
            }
        }
        //      C# -> List<System.String>? MitreTechniques
        // GraphQL -> mitreTechniques: [String!]! (scalar)
        if (this.MitreTechniques != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mitreTechniques\n" ;
            } else {
                s += ind + "mitreTechniques\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? TargetIdentityId
        // GraphQL -> targetIdentityId: String! (scalar)
        if (this.TargetIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityId\n" ;
            } else {
                s += ind + "targetIdentityId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (ec.Includes("actorIdentityId",true))
        {
            if(this.ActorIdentityId == null) {

                this.ActorIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.ActorIdentityId != null && ec.Excludes("actorIdentityId",true))
        {
            this.ActorIdentityId = null;
        }
        //      C# -> System.String? AlertWebUrl
        // GraphQL -> alertWebUrl: String! (scalar)
        if (ec.Includes("alertWebUrl",true))
        {
            if(this.AlertWebUrl == null) {

                this.AlertWebUrl = "FETCH";

            } else {


            }
        }
        else if (this.AlertWebUrl != null && ec.Excludes("alertWebUrl",true))
        {
            this.AlertWebUrl = null;
        }
        //      C# -> System.String? DefenderAlertId
        // GraphQL -> defenderAlertId: String! (scalar)
        if (ec.Includes("defenderAlertId",true))
        {
            if(this.DefenderAlertId == null) {

                this.DefenderAlertId = "FETCH";

            } else {


            }
        }
        else if (this.DefenderAlertId != null && ec.Excludes("defenderAlertId",true))
        {
            this.DefenderAlertId = null;
        }
        //      C# -> System.String? DetectionDescription
        // GraphQL -> detectionDescription: String! (scalar)
        if (ec.Includes("detectionDescription",true))
        {
            if(this.DetectionDescription == null) {

                this.DetectionDescription = "FETCH";

            } else {


            }
        }
        else if (this.DetectionDescription != null && ec.Excludes("detectionDescription",true))
        {
            this.DetectionDescription = null;
        }
        //      C# -> System.String? DetectionName
        // GraphQL -> detectionName: String! (scalar)
        if (ec.Includes("detectionName",true))
        {
            if(this.DetectionName == null) {

                this.DetectionName = "FETCH";

            } else {


            }
        }
        else if (this.DetectionName != null && ec.Excludes("detectionName",true))
        {
            this.DetectionName = null;
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        if (ec.Includes("detectionTime",true))
        {
            if(this.DetectionTime == null) {

                this.DetectionTime = new DateTime();

            } else {


            }
        }
        else if (this.DetectionTime != null && ec.Excludes("detectionTime",true))
        {
            this.DetectionTime = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.String? MitreTactic
        // GraphQL -> mitreTactic: String! (scalar)
        if (ec.Includes("mitreTactic",true))
        {
            if(this.MitreTactic == null) {

                this.MitreTactic = "FETCH";

            } else {


            }
        }
        else if (this.MitreTactic != null && ec.Excludes("mitreTactic",true))
        {
            this.MitreTactic = null;
        }
        //      C# -> List<System.String>? MitreTechniques
        // GraphQL -> mitreTechniques: [String!]! (scalar)
        if (ec.Includes("mitreTechniques",true))
        {
            if(this.MitreTechniques == null) {

                this.MitreTechniques = new List<System.String>();

            } else {


            }
        }
        else if (this.MitreTechniques != null && ec.Excludes("mitreTechniques",true))
        {
            this.MitreTechniques = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? TargetIdentityId
        // GraphQL -> targetIdentityId: String! (scalar)
        if (ec.Includes("targetIdentityId",true))
        {
            if(this.TargetIdentityId == null) {

                this.TargetIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentityId != null && ec.Excludes("targetIdentityId",true))
        {
            this.TargetIdentityId = null;
        }
    }


    #endregion

    } // class DefenderAlertViolationDetails
    
    #endregion

    public static class ListDefenderAlertViolationDetailsExtensions
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
            this List<DefenderAlertViolationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DefenderAlertViolationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DefenderAlertViolationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DefenderAlertViolationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DefenderAlertViolationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types