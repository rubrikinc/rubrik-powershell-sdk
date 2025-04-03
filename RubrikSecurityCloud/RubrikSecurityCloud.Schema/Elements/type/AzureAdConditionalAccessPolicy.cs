// AzureAdConditionalAccessPolicy.cs
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
    #region AzureAdConditionalAccessPolicy
    public class AzureAdConditionalAccessPolicy: BaseType
    {
        #region members

        //      C# -> AzureAdConditionalAccessPolicyStateEnumType? State
        // GraphQL -> state: AzureAdConditionalAccessPolicyStateEnumType! (enum)
        [JsonProperty("state")]
        public AzureAdConditionalAccessPolicyStateEnumType? State { get; set; }

        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        [JsonProperty("createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? ModifiedDateTime
        // GraphQL -> modifiedDateTime: DateTime (scalar)
        [JsonProperty("modifiedDateTime")]
        public DateTime? ModifiedDateTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdConditionalAccessPolicy";
    }

    public AzureAdConditionalAccessPolicy Set(
        AzureAdConditionalAccessPolicyStateEnumType? State = null,
        DateTime? CreatedDateTime = null,
        System.String? DisplayName = null,
        DateTime? ModifiedDateTime = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( CreatedDateTime != null ) {
            this.CreatedDateTime = CreatedDateTime;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( ModifiedDateTime != null ) {
            this.ModifiedDateTime = ModifiedDateTime;
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
        //      C# -> AzureAdConditionalAccessPolicyStateEnumType? State
        // GraphQL -> state: AzureAdConditionalAccessPolicyStateEnumType! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (this.CreatedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdDateTime\n" ;
            } else {
                s += ind + "createdDateTime\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> DateTime? ModifiedDateTime
        // GraphQL -> modifiedDateTime: DateTime (scalar)
        if (this.ModifiedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedDateTime\n" ;
            } else {
                s += ind + "modifiedDateTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdConditionalAccessPolicyStateEnumType? State
        // GraphQL -> state: AzureAdConditionalAccessPolicyStateEnumType! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new AzureAdConditionalAccessPolicyStateEnumType();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> DateTime? CreatedDateTime
        // GraphQL -> createdDateTime: DateTime (scalar)
        if (ec.Includes("createdDateTime",true))
        {
            if(this.CreatedDateTime == null) {

                this.CreatedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.CreatedDateTime != null && ec.Excludes("createdDateTime",true))
        {
            this.CreatedDateTime = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> DateTime? ModifiedDateTime
        // GraphQL -> modifiedDateTime: DateTime (scalar)
        if (ec.Includes("modifiedDateTime",true))
        {
            if(this.ModifiedDateTime == null) {

                this.ModifiedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.ModifiedDateTime != null && ec.Excludes("modifiedDateTime",true))
        {
            this.ModifiedDateTime = null;
        }
    }


    #endregion

    } // class AzureAdConditionalAccessPolicy
    
    #endregion

    public static class ListAzureAdConditionalAccessPolicyExtensions
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
            this List<AzureAdConditionalAccessPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdConditionalAccessPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdConditionalAccessPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdConditionalAccessPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdConditionalAccessPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types