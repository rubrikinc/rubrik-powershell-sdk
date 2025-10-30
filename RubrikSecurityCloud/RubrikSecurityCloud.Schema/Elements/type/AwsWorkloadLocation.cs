// AwsWorkloadLocation.cs
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
    #region AwsWorkloadLocation
 
    public class AwsWorkloadLocation: BaseType, SnappableLocationType
    {
        #region members

        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion! (enum)
        [JsonProperty("awsRegion")]
        public AwsNativeRegion? AwsRegion { get; set; }

        //      C# -> System.String? AccountRubrikId
        // GraphQL -> accountRubrikId: UUID! (scalar)
        [JsonProperty("accountRubrikId")]
        public System.String? AccountRubrikId { get; set; }

        //      C# -> System.String? AccountRubrikName
        // GraphQL -> accountRubrikName: String! (scalar)
        [JsonProperty("accountRubrikName")]
        public System.String? AccountRubrikName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsWorkloadLocation";
    }

    public AwsWorkloadLocation Set(
        AwsNativeRegion? AwsRegion = null,
        System.String? AccountRubrikId = null,
        System.String? AccountRubrikName = null
    ) 
    {
        if ( AwsRegion != null ) {
            this.AwsRegion = AwsRegion;
        }
        if ( AccountRubrikId != null ) {
            this.AccountRubrikId = AccountRubrikId;
        }
        if ( AccountRubrikName != null ) {
            this.AccountRubrikName = AccountRubrikName;
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
        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion! (enum)
        if (this.AwsRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsRegion\n" ;
            } else {
                s += ind + "awsRegion\n" ;
            }
        }
        //      C# -> System.String? AccountRubrikId
        // GraphQL -> accountRubrikId: UUID! (scalar)
        if (this.AccountRubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountRubrikId\n" ;
            } else {
                s += ind + "accountRubrikId\n" ;
            }
        }
        //      C# -> System.String? AccountRubrikName
        // GraphQL -> accountRubrikName: String! (scalar)
        if (this.AccountRubrikName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountRubrikName\n" ;
            } else {
                s += ind + "accountRubrikName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion! (enum)
        if (ec.Includes("awsRegion",true))
        {
            if(this.AwsRegion == null) {

                this.AwsRegion = new AwsNativeRegion();

            } else {


            }
        }
        else if (this.AwsRegion != null && ec.Excludes("awsRegion",true))
        {
            this.AwsRegion = null;
        }
        //      C# -> System.String? AccountRubrikId
        // GraphQL -> accountRubrikId: UUID! (scalar)
        if (ec.Includes("accountRubrikId",true))
        {
            if(this.AccountRubrikId == null) {

                this.AccountRubrikId = "FETCH";

            } else {


            }
        }
        else if (this.AccountRubrikId != null && ec.Excludes("accountRubrikId",true))
        {
            this.AccountRubrikId = null;
        }
        //      C# -> System.String? AccountRubrikName
        // GraphQL -> accountRubrikName: String! (scalar)
        if (ec.Includes("accountRubrikName",true))
        {
            if(this.AccountRubrikName == null) {

                this.AccountRubrikName = "FETCH";

            } else {


            }
        }
        else if (this.AccountRubrikName != null && ec.Excludes("accountRubrikName",true))
        {
            this.AccountRubrikName = null;
        }
    }


    #endregion

    } // class AwsWorkloadLocation
    
    #endregion

    public static class ListAwsWorkloadLocationExtensions
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
            this List<AwsWorkloadLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsWorkloadLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsWorkloadLocation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsWorkloadLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsWorkloadLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types