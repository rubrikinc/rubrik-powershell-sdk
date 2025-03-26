// BatchTriggerExocomputeHealthCheckReply.cs
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
    #region BatchTriggerExocomputeHealthCheckReply
    public class BatchTriggerExocomputeHealthCheckReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? FailedConfigIds
        // GraphQL -> failedConfigIds: [UUID!]! (scalar)
        [JsonProperty("failedConfigIds")]
        public List<System.String>? FailedConfigIds { get; set; }

        //      C# -> List<System.String>? HealthCheckJobIds
        // GraphQL -> healthCheckJobIds: [String!]! (scalar)
        [JsonProperty("healthCheckJobIds")]
        public List<System.String>? HealthCheckJobIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BatchTriggerExocomputeHealthCheckReply";
    }

    public BatchTriggerExocomputeHealthCheckReply Set(
        List<System.String>? FailedConfigIds = null,
        List<System.String>? HealthCheckJobIds = null
    ) 
    {
        if ( FailedConfigIds != null ) {
            this.FailedConfigIds = FailedConfigIds;
        }
        if ( HealthCheckJobIds != null ) {
            this.HealthCheckJobIds = HealthCheckJobIds;
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
        //      C# -> List<System.String>? FailedConfigIds
        // GraphQL -> failedConfigIds: [UUID!]! (scalar)
        if (this.FailedConfigIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedConfigIds\n" ;
            } else {
                s += ind + "failedConfigIds\n" ;
            }
        }
        //      C# -> List<System.String>? HealthCheckJobIds
        // GraphQL -> healthCheckJobIds: [String!]! (scalar)
        if (this.HealthCheckJobIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "healthCheckJobIds\n" ;
            } else {
                s += ind + "healthCheckJobIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? FailedConfigIds
        // GraphQL -> failedConfigIds: [UUID!]! (scalar)
        if (ec.Includes("failedConfigIds",true))
        {
            if(this.FailedConfigIds == null) {

                this.FailedConfigIds = new List<System.String>();

            } else {


            }
        }
        else if (this.FailedConfigIds != null && ec.Excludes("failedConfigIds",true))
        {
            this.FailedConfigIds = null;
        }
        //      C# -> List<System.String>? HealthCheckJobIds
        // GraphQL -> healthCheckJobIds: [String!]! (scalar)
        if (ec.Includes("healthCheckJobIds",true))
        {
            if(this.HealthCheckJobIds == null) {

                this.HealthCheckJobIds = new List<System.String>();

            } else {


            }
        }
        else if (this.HealthCheckJobIds != null && ec.Excludes("healthCheckJobIds",true))
        {
            this.HealthCheckJobIds = null;
        }
    }


    #endregion

    } // class BatchTriggerExocomputeHealthCheckReply
    
    #endregion

    public static class ListBatchTriggerExocomputeHealthCheckReplyExtensions
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
            this List<BatchTriggerExocomputeHealthCheckReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<BatchTriggerExocomputeHealthCheckReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BatchTriggerExocomputeHealthCheckReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchTriggerExocomputeHealthCheckReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BatchTriggerExocomputeHealthCheckReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types