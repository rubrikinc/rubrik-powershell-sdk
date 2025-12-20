// RdsInstanceClassBatchResult.cs
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
    #region RdsInstanceClassBatchResult
    public class RdsInstanceClassBatchResult: BaseType
    {
        #region members

        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        [JsonProperty("dbEngine")]
        public AwsNativeRdsDbEngine? DbEngine { get; set; }

        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String (scalar)
        [JsonProperty("dbEngineVersion")]
        public System.String? DbEngineVersion { get; set; }

        //      C# -> List<System.String>? InstanceClasses
        // GraphQL -> instanceClasses: [String!]! (scalar)
        [JsonProperty("instanceClasses")]
        public List<System.String>? InstanceClasses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RdsInstanceClassBatchResult";
    }

    public RdsInstanceClassBatchResult Set(
        AwsNativeRdsDbEngine? DbEngine = null,
        System.String? DbEngineVersion = null,
        List<System.String>? InstanceClasses = null
    ) 
    {
        if ( DbEngine != null ) {
            this.DbEngine = DbEngine;
        }
        if ( DbEngineVersion != null ) {
            this.DbEngineVersion = DbEngineVersion;
        }
        if ( InstanceClasses != null ) {
            this.InstanceClasses = InstanceClasses;
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
        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        if (this.DbEngine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbEngine\n" ;
            } else {
                s += ind + "dbEngine\n" ;
            }
        }
        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String (scalar)
        if (this.DbEngineVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbEngineVersion\n" ;
            } else {
                s += ind + "dbEngineVersion\n" ;
            }
        }
        //      C# -> List<System.String>? InstanceClasses
        // GraphQL -> instanceClasses: [String!]! (scalar)
        if (this.InstanceClasses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceClasses\n" ;
            } else {
                s += ind + "instanceClasses\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsNativeRdsDbEngine? DbEngine
        // GraphQL -> dbEngine: AwsNativeRdsDbEngine! (enum)
        if (ec.Includes("dbEngine",true))
        {
            if(this.DbEngine == null) {

                this.DbEngine = new AwsNativeRdsDbEngine();

            } else {


            }
        }
        else if (this.DbEngine != null && ec.Excludes("dbEngine",true))
        {
            this.DbEngine = null;
        }
        //      C# -> System.String? DbEngineVersion
        // GraphQL -> dbEngineVersion: String (scalar)
        if (ec.Includes("dbEngineVersion",true))
        {
            if(this.DbEngineVersion == null) {

                this.DbEngineVersion = "FETCH";

            } else {


            }
        }
        else if (this.DbEngineVersion != null && ec.Excludes("dbEngineVersion",true))
        {
            this.DbEngineVersion = null;
        }
        //      C# -> List<System.String>? InstanceClasses
        // GraphQL -> instanceClasses: [String!]! (scalar)
        if (ec.Includes("instanceClasses",true))
        {
            if(this.InstanceClasses == null) {

                this.InstanceClasses = new List<System.String>();

            } else {


            }
        }
        else if (this.InstanceClasses != null && ec.Excludes("instanceClasses",true))
        {
            this.InstanceClasses = null;
        }
    }


    #endregion

    } // class RdsInstanceClassBatchResult
    
    #endregion

    public static class ListRdsInstanceClassBatchResultExtensions
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
            this List<RdsInstanceClassBatchResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RdsInstanceClassBatchResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RdsInstanceClassBatchResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RdsInstanceClassBatchResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RdsInstanceClassBatchResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types