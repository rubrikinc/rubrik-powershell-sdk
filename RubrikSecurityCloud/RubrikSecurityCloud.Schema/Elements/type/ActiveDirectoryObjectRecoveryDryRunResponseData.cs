// ActiveDirectoryObjectRecoveryDryRunResponseData.cs
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
    #region ActiveDirectoryObjectRecoveryDryRunResponseData
    public class ActiveDirectoryObjectRecoveryDryRunResponseData: BaseType
    {
        #region members

        //      C# -> System.String? DistinguishedName
        // GraphQL -> distinguishedName: String! (scalar)
        [JsonProperty("distinguishedName")]
        public System.String? DistinguishedName { get; set; }

        //      C# -> System.Int64? Dnt
        // GraphQL -> dnt: Long! (scalar)
        [JsonProperty("dnt")]
        public System.Int64? Dnt { get; set; }

        //      C# -> System.Boolean? IsFailure
        // GraphQL -> isFailure: Boolean (scalar)
        [JsonProperty("isFailure")]
        public System.Boolean? IsFailure { get; set; }

        //      C# -> System.String? Operation
        // GraphQL -> operation: String! (scalar)
        [JsonProperty("operation")]
        public System.String? Operation { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }

        //      C# -> ActiveDirectoryObjectAttributesDiffResponseWithDetails? Attributes
        // GraphQL -> attributes: ActiveDirectoryObjectAttributesDiffResponseWithDetails! (type)
        [JsonProperty("attributes")]
        public ActiveDirectoryObjectAttributesDiffResponseWithDetails? Attributes { get; set; }

        //      C# -> ActiveDirectoryObjectRestoreFailedAttr? FailedAttributes
        // GraphQL -> failedAttributes: ActiveDirectoryObjectRestoreFailedAttr! (type)
        [JsonProperty("failedAttributes")]
        public ActiveDirectoryObjectRestoreFailedAttr? FailedAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryObjectRecoveryDryRunResponseData";
    }

    public ActiveDirectoryObjectRecoveryDryRunResponseData Set(
        System.String? DistinguishedName = null,
        System.Int64? Dnt = null,
        System.Boolean? IsFailure = null,
        System.String? Operation = null,
        System.String? Reason = null,
        ActiveDirectoryObjectAttributesDiffResponseWithDetails? Attributes = null,
        ActiveDirectoryObjectRestoreFailedAttr? FailedAttributes = null
    ) 
    {
        if ( DistinguishedName != null ) {
            this.DistinguishedName = DistinguishedName;
        }
        if ( Dnt != null ) {
            this.Dnt = Dnt;
        }
        if ( IsFailure != null ) {
            this.IsFailure = IsFailure;
        }
        if ( Operation != null ) {
            this.Operation = Operation;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
        }
        if ( Attributes != null ) {
            this.Attributes = Attributes;
        }
        if ( FailedAttributes != null ) {
            this.FailedAttributes = FailedAttributes;
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
        //      C# -> System.String? DistinguishedName
        // GraphQL -> distinguishedName: String! (scalar)
        if (this.DistinguishedName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "distinguishedName\n" ;
            } else {
                s += ind + "distinguishedName\n" ;
            }
        }
        //      C# -> System.Int64? Dnt
        // GraphQL -> dnt: Long! (scalar)
        if (this.Dnt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnt\n" ;
            } else {
                s += ind + "dnt\n" ;
            }
        }
        //      C# -> System.Boolean? IsFailure
        // GraphQL -> isFailure: Boolean (scalar)
        if (this.IsFailure != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isFailure\n" ;
            } else {
                s += ind + "isFailure\n" ;
            }
        }
        //      C# -> System.String? Operation
        // GraphQL -> operation: String! (scalar)
        if (this.Operation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operation\n" ;
            } else {
                s += ind + "operation\n" ;
            }
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String (scalar)
        if (this.Reason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reason\n" ;
            } else {
                s += ind + "reason\n" ;
            }
        }
        //      C# -> ActiveDirectoryObjectAttributesDiffResponseWithDetails? Attributes
        // GraphQL -> attributes: ActiveDirectoryObjectAttributesDiffResponseWithDetails! (type)
        if (this.Attributes != null) {
            var fspec = this.Attributes.AsFieldSpec(conf.Child("attributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "attributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ActiveDirectoryObjectRestoreFailedAttr? FailedAttributes
        // GraphQL -> failedAttributes: ActiveDirectoryObjectRestoreFailedAttr! (type)
        if (this.FailedAttributes != null) {
            var fspec = this.FailedAttributes.AsFieldSpec(conf.Child("failedAttributes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failedAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DistinguishedName
        // GraphQL -> distinguishedName: String! (scalar)
        if (ec.Includes("distinguishedName",true))
        {
            if(this.DistinguishedName == null) {

                this.DistinguishedName = "FETCH";

            } else {


            }
        }
        else if (this.DistinguishedName != null && ec.Excludes("distinguishedName",true))
        {
            this.DistinguishedName = null;
        }
        //      C# -> System.Int64? Dnt
        // GraphQL -> dnt: Long! (scalar)
        if (ec.Includes("dnt",true))
        {
            if(this.Dnt == null) {

                this.Dnt = new System.Int64();

            } else {


            }
        }
        else if (this.Dnt != null && ec.Excludes("dnt",true))
        {
            this.Dnt = null;
        }
        //      C# -> System.Boolean? IsFailure
        // GraphQL -> isFailure: Boolean (scalar)
        if (ec.Includes("isFailure",true))
        {
            if(this.IsFailure == null) {

                this.IsFailure = true;

            } else {


            }
        }
        else if (this.IsFailure != null && ec.Excludes("isFailure",true))
        {
            this.IsFailure = null;
        }
        //      C# -> System.String? Operation
        // GraphQL -> operation: String! (scalar)
        if (ec.Includes("operation",true))
        {
            if(this.Operation == null) {

                this.Operation = "FETCH";

            } else {


            }
        }
        else if (this.Operation != null && ec.Excludes("operation",true))
        {
            this.Operation = null;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String (scalar)
        if (ec.Includes("reason",true))
        {
            if(this.Reason == null) {

                this.Reason = "FETCH";

            } else {


            }
        }
        else if (this.Reason != null && ec.Excludes("reason",true))
        {
            this.Reason = null;
        }
        //      C# -> ActiveDirectoryObjectAttributesDiffResponseWithDetails? Attributes
        // GraphQL -> attributes: ActiveDirectoryObjectAttributesDiffResponseWithDetails! (type)
        if (ec.Includes("attributes",false))
        {
            if(this.Attributes == null) {

                this.Attributes = new ActiveDirectoryObjectAttributesDiffResponseWithDetails();
                this.Attributes.ApplyExploratoryFieldSpec(ec.NewChild("attributes"));

            } else {

                this.Attributes.ApplyExploratoryFieldSpec(ec.NewChild("attributes"));

            }
        }
        else if (this.Attributes != null && ec.Excludes("attributes",false))
        {
            this.Attributes = null;
        }
        //      C# -> ActiveDirectoryObjectRestoreFailedAttr? FailedAttributes
        // GraphQL -> failedAttributes: ActiveDirectoryObjectRestoreFailedAttr! (type)
        if (ec.Includes("failedAttributes",false))
        {
            if(this.FailedAttributes == null) {

                this.FailedAttributes = new ActiveDirectoryObjectRestoreFailedAttr();
                this.FailedAttributes.ApplyExploratoryFieldSpec(ec.NewChild("failedAttributes"));

            } else {

                this.FailedAttributes.ApplyExploratoryFieldSpec(ec.NewChild("failedAttributes"));

            }
        }
        else if (this.FailedAttributes != null && ec.Excludes("failedAttributes",false))
        {
            this.FailedAttributes = null;
        }
    }


    #endregion

    } // class ActiveDirectoryObjectRecoveryDryRunResponseData
    
    #endregion

    public static class ListActiveDirectoryObjectRecoveryDryRunResponseDataExtensions
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
            this List<ActiveDirectoryObjectRecoveryDryRunResponseData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryObjectRecoveryDryRunResponseData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryObjectRecoveryDryRunResponseData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryObjectRecoveryDryRunResponseData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryObjectRecoveryDryRunResponseData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types