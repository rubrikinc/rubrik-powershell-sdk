// MapCloudAccountExocomputeAccountResult.cs
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
    #region MapCloudAccountExocomputeAccountResult
    public class MapCloudAccountExocomputeAccountResult: BaseType
    {
        #region members

        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        [JsonProperty("applicationCloudAccountId")]
        public System.String? ApplicationCloudAccountId { get; set; }

        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        [JsonProperty("cloudFormationUrl")]
        public System.String? CloudFormationUrl { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Boolean? IsPendingCftApproval
        // GraphQL -> isPendingCftApproval: Boolean! (scalar)
        [JsonProperty("isPendingCftApproval")]
        public System.Boolean? IsPendingCftApproval { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MapCloudAccountExocomputeAccountResult";
    }

    public MapCloudAccountExocomputeAccountResult Set(
        System.String? ApplicationCloudAccountId = null,
        System.String? CloudFormationUrl = null,
        System.String? ErrorMessage = null,
        System.Boolean? IsPendingCftApproval = null
    ) 
    {
        if ( ApplicationCloudAccountId != null ) {
            this.ApplicationCloudAccountId = ApplicationCloudAccountId;
        }
        if ( CloudFormationUrl != null ) {
            this.CloudFormationUrl = CloudFormationUrl;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( IsPendingCftApproval != null ) {
            this.IsPendingCftApproval = IsPendingCftApproval;
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
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        if (this.ApplicationCloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationCloudAccountId\n" ;
            } else {
                s += ind + "applicationCloudAccountId\n" ;
            }
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (this.CloudFormationUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudFormationUrl\n" ;
            } else {
                s += ind + "cloudFormationUrl\n" ;
            }
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Boolean? IsPendingCftApproval
        // GraphQL -> isPendingCftApproval: Boolean! (scalar)
        if (this.IsPendingCftApproval != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPendingCftApproval\n" ;
            } else {
                s += ind + "isPendingCftApproval\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ApplicationCloudAccountId
        // GraphQL -> applicationCloudAccountId: UUID! (scalar)
        if (ec.Includes("applicationCloudAccountId",true))
        {
            if(this.ApplicationCloudAccountId == null) {

                this.ApplicationCloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationCloudAccountId != null && ec.Excludes("applicationCloudAccountId",true))
        {
            this.ApplicationCloudAccountId = null;
        }
        //      C# -> System.String? CloudFormationUrl
        // GraphQL -> cloudFormationUrl: String! (scalar)
        if (ec.Includes("cloudFormationUrl",true))
        {
            if(this.CloudFormationUrl == null) {

                this.CloudFormationUrl = "FETCH";

            } else {


            }
        }
        else if (this.CloudFormationUrl != null && ec.Excludes("cloudFormationUrl",true))
        {
            this.CloudFormationUrl = null;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Boolean? IsPendingCftApproval
        // GraphQL -> isPendingCftApproval: Boolean! (scalar)
        if (ec.Includes("isPendingCftApproval",true))
        {
            if(this.IsPendingCftApproval == null) {

                this.IsPendingCftApproval = true;

            } else {


            }
        }
        else if (this.IsPendingCftApproval != null && ec.Excludes("isPendingCftApproval",true))
        {
            this.IsPendingCftApproval = null;
        }
    }


    #endregion

    } // class MapCloudAccountExocomputeAccountResult
    
    #endregion

    public static class ListMapCloudAccountExocomputeAccountResultExtensions
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
            this List<MapCloudAccountExocomputeAccountResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MapCloudAccountExocomputeAccountResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MapCloudAccountExocomputeAccountResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MapCloudAccountExocomputeAccountResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MapCloudAccountExocomputeAccountResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types