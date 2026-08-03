// DefenderIngestionStatus.cs
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
    #region DefenderIngestionStatus
    public class DefenderIngestionStatus: BaseType
    {
        #region members

        //      C# -> System.Int64? IntegrationId
        // GraphQL -> integrationId: Long! (scalar)
        [JsonProperty("integrationId")]
        public System.Int64? IntegrationId { get; set; }

        //      C# -> DateTime? LastRunStartTime
        // GraphQL -> lastRunStartTime: DateTime (scalar)
        [JsonProperty("lastRunStartTime")]
        public DateTime? LastRunStartTime { get; set; }

        //      C# -> DateTime? LastSuccessTime
        // GraphQL -> lastSuccessTime: DateTime (scalar)
        [JsonProperty("lastSuccessTime")]
        public DateTime? LastSuccessTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DefenderIngestionStatus";
    }

    public DefenderIngestionStatus Set(
        System.Int64? IntegrationId = null,
        DateTime? LastRunStartTime = null,
        DateTime? LastSuccessTime = null
    ) 
    {
        if ( IntegrationId != null ) {
            this.IntegrationId = IntegrationId;
        }
        if ( LastRunStartTime != null ) {
            this.LastRunStartTime = LastRunStartTime;
        }
        if ( LastSuccessTime != null ) {
            this.LastSuccessTime = LastSuccessTime;
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
        //      C# -> System.Int64? IntegrationId
        // GraphQL -> integrationId: Long! (scalar)
        if (this.IntegrationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "integrationId\n" ;
            } else {
                s += ind + "integrationId\n" ;
            }
        }
        //      C# -> DateTime? LastRunStartTime
        // GraphQL -> lastRunStartTime: DateTime (scalar)
        if (this.LastRunStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRunStartTime\n" ;
            } else {
                s += ind + "lastRunStartTime\n" ;
            }
        }
        //      C# -> DateTime? LastSuccessTime
        // GraphQL -> lastSuccessTime: DateTime (scalar)
        if (this.LastSuccessTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSuccessTime\n" ;
            } else {
                s += ind + "lastSuccessTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? IntegrationId
        // GraphQL -> integrationId: Long! (scalar)
        if (ec.Includes("integrationId",true))
        {
            if(this.IntegrationId == null) {

                this.IntegrationId = new System.Int64();

            } else {


            }
        }
        else if (this.IntegrationId != null && ec.Excludes("integrationId",true))
        {
            this.IntegrationId = null;
        }
        //      C# -> DateTime? LastRunStartTime
        // GraphQL -> lastRunStartTime: DateTime (scalar)
        if (ec.Includes("lastRunStartTime",true))
        {
            if(this.LastRunStartTime == null) {

                this.LastRunStartTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRunStartTime != null && ec.Excludes("lastRunStartTime",true))
        {
            this.LastRunStartTime = null;
        }
        //      C# -> DateTime? LastSuccessTime
        // GraphQL -> lastSuccessTime: DateTime (scalar)
        if (ec.Includes("lastSuccessTime",true))
        {
            if(this.LastSuccessTime == null) {

                this.LastSuccessTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSuccessTime != null && ec.Excludes("lastSuccessTime",true))
        {
            this.LastSuccessTime = null;
        }
    }


    #endregion

    } // class DefenderIngestionStatus
    
    #endregion

    public static class ListDefenderIngestionStatusExtensions
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
            this List<DefenderIngestionStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DefenderIngestionStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DefenderIngestionStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DefenderIngestionStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DefenderIngestionStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types