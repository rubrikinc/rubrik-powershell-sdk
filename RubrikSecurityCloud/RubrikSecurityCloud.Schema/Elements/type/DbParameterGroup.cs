// DbParameterGroup.cs
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
    #region DbParameterGroup
    public class DbParameterGroup: BaseType
    {
        #region members

        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        [JsonProperty("rdsType")]
        public AwsNativeRdsType? RdsType { get; set; }

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        [JsonProperty("family")]
        public System.String? Family { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DbParameterGroup";
    }

    public DbParameterGroup Set(
        AwsNativeRdsType? RdsType = null,
        System.String? Arn = null,
        System.String? Family = null,
        System.String? Name = null
    ) 
    {
        if ( RdsType != null ) {
            this.RdsType = RdsType;
        }
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Family != null ) {
            this.Family = Family;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        if (this.RdsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rdsType\n" ;
            } else {
                s += ind + "rdsType\n" ;
            }
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "arn\n" ;
            } else {
                s += ind + "arn\n" ;
            }
        }
        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        if (this.Family != null) {
            if (conf.Flat) {
                s += conf.Prefix + "family\n" ;
            } else {
                s += ind + "family\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsNativeRdsType? RdsType
        // GraphQL -> rdsType: AwsNativeRdsType! (enum)
        if (ec.Includes("rdsType",true))
        {
            if(this.RdsType == null) {

                this.RdsType = new AwsNativeRdsType();

            } else {


            }
        }
        else if (this.RdsType != null && ec.Excludes("rdsType",true))
        {
            this.RdsType = null;
        }
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (ec.Includes("arn",true))
        {
            if(this.Arn == null) {

                this.Arn = "FETCH";

            } else {


            }
        }
        else if (this.Arn != null && ec.Excludes("arn",true))
        {
            this.Arn = null;
        }
        //      C# -> System.String? Family
        // GraphQL -> family: String! (scalar)
        if (ec.Includes("family",true))
        {
            if(this.Family == null) {

                this.Family = "FETCH";

            } else {


            }
        }
        else if (this.Family != null && ec.Excludes("family",true))
        {
            this.Family = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class DbParameterGroup
    
    #endregion

    public static class ListDbParameterGroupExtensions
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
            this List<DbParameterGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DbParameterGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DbParameterGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DbParameterGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DbParameterGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types