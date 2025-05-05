// AwsRoleChainingDetails.cs
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
    #region AwsRoleChainingDetails
    public class AwsRoleChainingDetails: BaseType
    {
        #region members

        //      C# -> System.Int32? MappedAccountsCount
        // GraphQL -> mappedAccountsCount: Int! (scalar)
        [JsonProperty("mappedAccountsCount")]
        public System.Int32? MappedAccountsCount { get; set; }

        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        [JsonProperty("roleArn")]
        public System.String? RoleArn { get; set; }

        //      C# -> System.String? RoleUrl
        // GraphQL -> roleUrl: String! (scalar)
        [JsonProperty("roleUrl")]
        public System.String? RoleUrl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsRoleChainingDetails";
    }

    public AwsRoleChainingDetails Set(
        System.Int32? MappedAccountsCount = null,
        System.String? RoleArn = null,
        System.String? RoleUrl = null
    ) 
    {
        if ( MappedAccountsCount != null ) {
            this.MappedAccountsCount = MappedAccountsCount;
        }
        if ( RoleArn != null ) {
            this.RoleArn = RoleArn;
        }
        if ( RoleUrl != null ) {
            this.RoleUrl = RoleUrl;
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
        //      C# -> System.Int32? MappedAccountsCount
        // GraphQL -> mappedAccountsCount: Int! (scalar)
        if (this.MappedAccountsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mappedAccountsCount\n" ;
            } else {
                s += ind + "mappedAccountsCount\n" ;
            }
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (this.RoleArn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleArn\n" ;
            } else {
                s += ind + "roleArn\n" ;
            }
        }
        //      C# -> System.String? RoleUrl
        // GraphQL -> roleUrl: String! (scalar)
        if (this.RoleUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleUrl\n" ;
            } else {
                s += ind + "roleUrl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? MappedAccountsCount
        // GraphQL -> mappedAccountsCount: Int! (scalar)
        if (ec.Includes("mappedAccountsCount",true))
        {
            if(this.MappedAccountsCount == null) {

                this.MappedAccountsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.MappedAccountsCount != null && ec.Excludes("mappedAccountsCount",true))
        {
            this.MappedAccountsCount = null;
        }
        //      C# -> System.String? RoleArn
        // GraphQL -> roleArn: String! (scalar)
        if (ec.Includes("roleArn",true))
        {
            if(this.RoleArn == null) {

                this.RoleArn = "FETCH";

            } else {


            }
        }
        else if (this.RoleArn != null && ec.Excludes("roleArn",true))
        {
            this.RoleArn = null;
        }
        //      C# -> System.String? RoleUrl
        // GraphQL -> roleUrl: String! (scalar)
        if (ec.Includes("roleUrl",true))
        {
            if(this.RoleUrl == null) {

                this.RoleUrl = "FETCH";

            } else {


            }
        }
        else if (this.RoleUrl != null && ec.Excludes("roleUrl",true))
        {
            this.RoleUrl = null;
        }
    }


    #endregion

    } // class AwsRoleChainingDetails
    
    #endregion

    public static class ListAwsRoleChainingDetailsExtensions
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
            this List<AwsRoleChainingDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsRoleChainingDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsRoleChainingDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsRoleChainingDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsRoleChainingDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types