// ExocomputeHealthChecksReply.cs
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
    #region ExocomputeHealthChecksReply
    public class ExocomputeHealthChecksReply: BaseType
    {
        #region members

        //      C# -> DateTime? ExecutionTime
        // GraphQL -> executionTime: DateTime (scalar)
        [JsonProperty("executionTime")]
        public DateTime? ExecutionTime { get; set; }

        //      C# -> List<HealthCheckResult>? Results
        // GraphQL -> results: [HealthCheckResult!]! (type)
        [JsonProperty("results")]
        public List<HealthCheckResult>? Results { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExocomputeHealthChecksReply";
    }

    public ExocomputeHealthChecksReply Set(
        DateTime? ExecutionTime = null,
        List<HealthCheckResult>? Results = null
    ) 
    {
        if ( ExecutionTime != null ) {
            this.ExecutionTime = ExecutionTime;
        }
        if ( Results != null ) {
            this.Results = Results;
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
        //      C# -> DateTime? ExecutionTime
        // GraphQL -> executionTime: DateTime (scalar)
        if (this.ExecutionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "executionTime\n" ;
            } else {
                s += ind + "executionTime\n" ;
            }
        }
        //      C# -> List<HealthCheckResult>? Results
        // GraphQL -> results: [HealthCheckResult!]! (type)
        if (this.Results != null) {
            var fspec = this.Results.AsFieldSpec(conf.Child("results"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "results" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? ExecutionTime
        // GraphQL -> executionTime: DateTime (scalar)
        if (ec.Includes("executionTime",true))
        {
            if(this.ExecutionTime == null) {

                this.ExecutionTime = new DateTime();

            } else {


            }
        }
        else if (this.ExecutionTime != null && ec.Excludes("executionTime",true))
        {
            this.ExecutionTime = null;
        }
        //      C# -> List<HealthCheckResult>? Results
        // GraphQL -> results: [HealthCheckResult!]! (type)
        if (ec.Includes("results",false))
        {
            if(this.Results == null) {

                this.Results = new List<HealthCheckResult>();
                this.Results.ApplyExploratoryFieldSpec(ec.NewChild("results"));

            } else {

                this.Results.ApplyExploratoryFieldSpec(ec.NewChild("results"));

            }
        }
        else if (this.Results != null && ec.Excludes("results",false))
        {
            this.Results = null;
        }
    }


    #endregion

    } // class ExocomputeHealthChecksReply
    
    #endregion

    public static class ListExocomputeHealthChecksReplyExtensions
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
            this List<ExocomputeHealthChecksReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExocomputeHealthChecksReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExocomputeHealthChecksReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExocomputeHealthChecksReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExocomputeHealthChecksReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types