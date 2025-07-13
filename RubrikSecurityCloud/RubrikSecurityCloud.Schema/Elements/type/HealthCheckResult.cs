// HealthCheckResult.cs
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
    #region HealthCheckResult
    public class HealthCheckResult: BaseType
    {
        #region members

        //      C# -> ExoHealthCheckCategory? CheckCategory
        // GraphQL -> checkCategory: ExoHealthCheckCategory! (enum)
        [JsonProperty("checkCategory")]
        public ExoHealthCheckCategory? CheckCategory { get; set; }

        //      C# -> ExoHealthCheckType? CheckType
        // GraphQL -> checkType: ExoHealthCheckType! (enum)
        [JsonProperty("checkType")]
        public ExoHealthCheckType? CheckType { get; set; }

        //      C# -> System.String? CheckName
        // GraphQL -> checkName: String! (scalar)
        [JsonProperty("checkName")]
        public System.String? CheckName { get; set; }

        //      C# -> List<HealthCheckResultDetails>? Details
        // GraphQL -> details: [HealthCheckResultDetails!]! (type)
        [JsonProperty("details")]
        public List<HealthCheckResultDetails>? Details { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HealthCheckResult";
    }

    public HealthCheckResult Set(
        ExoHealthCheckCategory? CheckCategory = null,
        ExoHealthCheckType? CheckType = null,
        System.String? CheckName = null,
        List<HealthCheckResultDetails>? Details = null
    ) 
    {
        if ( CheckCategory != null ) {
            this.CheckCategory = CheckCategory;
        }
        if ( CheckType != null ) {
            this.CheckType = CheckType;
        }
        if ( CheckName != null ) {
            this.CheckName = CheckName;
        }
        if ( Details != null ) {
            this.Details = Details;
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
        //      C# -> ExoHealthCheckCategory? CheckCategory
        // GraphQL -> checkCategory: ExoHealthCheckCategory! (enum)
        if (this.CheckCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "checkCategory\n" ;
            } else {
                s += ind + "checkCategory\n" ;
            }
        }
        //      C# -> ExoHealthCheckType? CheckType
        // GraphQL -> checkType: ExoHealthCheckType! (enum)
        if (this.CheckType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "checkType\n" ;
            } else {
                s += ind + "checkType\n" ;
            }
        }
        //      C# -> System.String? CheckName
        // GraphQL -> checkName: String! (scalar)
        if (this.CheckName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "checkName\n" ;
            } else {
                s += ind + "checkName\n" ;
            }
        }
        //      C# -> List<HealthCheckResultDetails>? Details
        // GraphQL -> details: [HealthCheckResultDetails!]! (type)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ExoHealthCheckCategory? CheckCategory
        // GraphQL -> checkCategory: ExoHealthCheckCategory! (enum)
        if (ec.Includes("checkCategory",true))
        {
            if(this.CheckCategory == null) {

                this.CheckCategory = new ExoHealthCheckCategory();

            } else {


            }
        }
        else if (this.CheckCategory != null && ec.Excludes("checkCategory",true))
        {
            this.CheckCategory = null;
        }
        //      C# -> ExoHealthCheckType? CheckType
        // GraphQL -> checkType: ExoHealthCheckType! (enum)
        if (ec.Includes("checkType",true))
        {
            if(this.CheckType == null) {

                this.CheckType = new ExoHealthCheckType();

            } else {


            }
        }
        else if (this.CheckType != null && ec.Excludes("checkType",true))
        {
            this.CheckType = null;
        }
        //      C# -> System.String? CheckName
        // GraphQL -> checkName: String! (scalar)
        if (ec.Includes("checkName",true))
        {
            if(this.CheckName == null) {

                this.CheckName = "FETCH";

            } else {


            }
        }
        else if (this.CheckName != null && ec.Excludes("checkName",true))
        {
            this.CheckName = null;
        }
        //      C# -> List<HealthCheckResultDetails>? Details
        // GraphQL -> details: [HealthCheckResultDetails!]! (type)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                this.Details = new List<HealthCheckResultDetails>();
                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            } else {

                this.Details.ApplyExploratoryFieldSpec(ec.NewChild("details"));

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
    }


    #endregion

    } // class HealthCheckResult
    
    #endregion

    public static class ListHealthCheckResultExtensions
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
            this List<HealthCheckResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HealthCheckResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HealthCheckResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HealthCheckResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HealthCheckResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types