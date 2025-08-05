// AwsNativeAccountDetails.cs
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
    #region AwsNativeAccountDetails
    public class AwsNativeAccountDetails: BaseType
    {
        #region members

        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        [JsonProperty("status")]
        public AwsAccountStatus? Status { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<AwsNativeAccountEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AwsNativeAccountEnabledFeature!]! (type)
        [JsonProperty("enabledFeatures")]
        public List<AwsNativeAccountEnabledFeature>? EnabledFeatures { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeAccountDetails";
    }

    public AwsNativeAccountDetails Set(
        AwsAccountStatus? Status = null,
        System.String? Id = null,
        System.String? Name = null,
        List<AwsNativeAccountEnabledFeature>? EnabledFeatures = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( EnabledFeatures != null ) {
            this.EnabledFeatures = EnabledFeatures;
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
        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> List<AwsNativeAccountEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AwsNativeAccountEnabledFeature!]! (type)
        if (this.EnabledFeatures != null) {
            var fspec = this.EnabledFeatures.AsFieldSpec(conf.Child("enabledFeatures"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "enabledFeatures" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AwsAccountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> List<AwsNativeAccountEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AwsNativeAccountEnabledFeature!]! (type)
        if (ec.Includes("enabledFeatures",false))
        {
            if(this.EnabledFeatures == null) {

                this.EnabledFeatures = new List<AwsNativeAccountEnabledFeature>();
                this.EnabledFeatures.ApplyExploratoryFieldSpec(ec.NewChild("enabledFeatures"));

            } else {

                this.EnabledFeatures.ApplyExploratoryFieldSpec(ec.NewChild("enabledFeatures"));

            }
        }
        else if (this.EnabledFeatures != null && ec.Excludes("enabledFeatures",false))
        {
            this.EnabledFeatures = null;
        }
    }


    #endregion

    } // class AwsNativeAccountDetails
    
    #endregion

    public static class ListAwsNativeAccountDetailsExtensions
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
            this List<AwsNativeAccountDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsNativeAccountDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeAccountDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeAccountDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeAccountDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types