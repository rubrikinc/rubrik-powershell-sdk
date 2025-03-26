// AwsRscAccountDetails.cs
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
    #region AwsRscAccountDetails
    public class AwsRscAccountDetails: BaseType
    {
        #region members

        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        [JsonProperty("awsCloudAccountId")]
        public System.String? AwsCloudAccountId { get; set; }

        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        [JsonProperty("awsNativeId")]
        public System.String? AwsNativeId { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsRscAccountDetails";
    }

    public AwsRscAccountDetails Set(
        System.String? AwsCloudAccountId = null,
        System.String? AwsNativeId = null,
        System.String? Message = null
    ) 
    {
        if ( AwsCloudAccountId != null ) {
            this.AwsCloudAccountId = AwsCloudAccountId;
        }
        if ( AwsNativeId != null ) {
            this.AwsNativeId = AwsNativeId;
        }
        if ( Message != null ) {
            this.Message = Message;
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
        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        if (this.AwsCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsCloudAccountId\n" ;
            } else {
                s += ind + "awsCloudAccountId\n" ;
            }
        }
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsNativeId\n" ;
            } else {
                s += ind + "awsNativeId\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        if (ec.Includes("awsCloudAccountId",true))
        {
            if(this.AwsCloudAccountId == null) {

                this.AwsCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.AwsCloudAccountId != null && ec.Excludes("awsCloudAccountId",true))
        {
            this.AwsCloudAccountId = null;
        }
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (ec.Includes("awsNativeId",true))
        {
            if(this.AwsNativeId == null) {

                this.AwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AwsNativeId != null && ec.Excludes("awsNativeId",true))
        {
            this.AwsNativeId = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
    }


    #endregion

    } // class AwsRscAccountDetails
    
    #endregion

    public static class ListAwsRscAccountDetailsExtensions
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
            this List<AwsRscAccountDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsRscAccountDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsRscAccountDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsRscAccountDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsRscAccountDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types