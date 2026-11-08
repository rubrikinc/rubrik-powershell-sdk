// ConfigResourceAwsLambda.cs
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
    #region ConfigResourceAwsLambda
    public class ConfigResourceAwsLambda: BaseType
    {
        #region members

        //      C# -> AwsLambdaPackageType? PackageType
        // GraphQL -> packageType: AwsLambdaPackageType! (enum)
        [JsonProperty("packageType")]
        public AwsLambdaPackageType? PackageType { get; set; }

        //      C# -> System.String? Runtime
        // GraphQL -> runtime: String! (scalar)
        [JsonProperty("runtime")]
        public System.String? Runtime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResourceAwsLambda";
    }

    public ConfigResourceAwsLambda Set(
        AwsLambdaPackageType? PackageType = null,
        System.String? Runtime = null
    ) 
    {
        if ( PackageType != null ) {
            this.PackageType = PackageType;
        }
        if ( Runtime != null ) {
            this.Runtime = Runtime;
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
        //      C# -> AwsLambdaPackageType? PackageType
        // GraphQL -> packageType: AwsLambdaPackageType! (enum)
        if (this.PackageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "packageType\n" ;
            } else {
                s += ind + "packageType\n" ;
            }
        }
        //      C# -> System.String? Runtime
        // GraphQL -> runtime: String! (scalar)
        if (this.Runtime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runtime\n" ;
            } else {
                s += ind + "runtime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsLambdaPackageType? PackageType
        // GraphQL -> packageType: AwsLambdaPackageType! (enum)
        if (ec.Includes("packageType",true))
        {
            if(this.PackageType == null) {

                this.PackageType = new AwsLambdaPackageType();

            } else {


            }
        }
        else if (this.PackageType != null && ec.Excludes("packageType",true))
        {
            this.PackageType = null;
        }
        //      C# -> System.String? Runtime
        // GraphQL -> runtime: String! (scalar)
        if (ec.Includes("runtime",true))
        {
            if(this.Runtime == null) {

                this.Runtime = "FETCH";

            } else {


            }
        }
        else if (this.Runtime != null && ec.Excludes("runtime",true))
        {
            this.Runtime = null;
        }
    }


    #endregion

    } // class ConfigResourceAwsLambda
    
    #endregion

    public static class ListConfigResourceAwsLambdaExtensions
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
            this List<ConfigResourceAwsLambda> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResourceAwsLambda> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResourceAwsLambda> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResourceAwsLambda());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResourceAwsLambda> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types