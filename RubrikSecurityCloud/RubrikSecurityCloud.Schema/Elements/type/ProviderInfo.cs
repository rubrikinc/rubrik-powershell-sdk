// ProviderInfo.cs
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
    #region ProviderInfo
    public class ProviderInfo: BaseType
    {
        #region members

        //      C# -> FeedType? ProviderType
        // GraphQL -> providerType: FeedType! (enum)
        [JsonProperty("providerType")]
        public FeedType? ProviderType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ProviderId
        // GraphQL -> providerId: String! (scalar)
        [JsonProperty("providerId")]
        public System.String? ProviderId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProviderInfo";
    }

    public ProviderInfo Set(
        FeedType? ProviderType = null,
        System.String? Name = null,
        System.String? ProviderId = null
    ) 
    {
        if ( ProviderType != null ) {
            this.ProviderType = ProviderType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ProviderId != null ) {
            this.ProviderId = ProviderId;
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
        //      C# -> FeedType? ProviderType
        // GraphQL -> providerType: FeedType! (enum)
        if (this.ProviderType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "providerType\n" ;
            } else {
                s += ind + "providerType\n" ;
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
        //      C# -> System.String? ProviderId
        // GraphQL -> providerId: String! (scalar)
        if (this.ProviderId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "providerId\n" ;
            } else {
                s += ind + "providerId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> FeedType? ProviderType
        // GraphQL -> providerType: FeedType! (enum)
        if (ec.Includes("providerType",true))
        {
            if(this.ProviderType == null) {

                this.ProviderType = new FeedType();

            } else {


            }
        }
        else if (this.ProviderType != null && ec.Excludes("providerType",true))
        {
            this.ProviderType = null;
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
        //      C# -> System.String? ProviderId
        // GraphQL -> providerId: String! (scalar)
        if (ec.Includes("providerId",true))
        {
            if(this.ProviderId == null) {

                this.ProviderId = "FETCH";

            } else {


            }
        }
        else if (this.ProviderId != null && ec.Excludes("providerId",true))
        {
            this.ProviderId = null;
        }
    }


    #endregion

    } // class ProviderInfo
    
    #endregion

    public static class ListProviderInfoExtensions
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
            this List<ProviderInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProviderInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProviderInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProviderInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProviderInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types