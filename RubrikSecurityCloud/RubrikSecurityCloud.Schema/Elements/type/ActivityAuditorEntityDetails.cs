// ActivityAuditorEntityDetails.cs
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
    #region ActivityAuditorEntityDetails
    public class ActivityAuditorEntityDetails: BaseType
    {
        #region members

        //      C# -> IdentityDetails? IdentityDetails
        // GraphQL -> identityDetails: IdentityDetails (type)
        [JsonProperty("identityDetails")]
        public IdentityDetails? IdentityDetails { get; set; }

        //      C# -> TenantDetails? TenantDetails
        // GraphQL -> tenantDetails: TenantDetails (type)
        [JsonProperty("tenantDetails")]
        public TenantDetails? TenantDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActivityAuditorEntityDetails";
    }

    public ActivityAuditorEntityDetails Set(
        IdentityDetails? IdentityDetails = null,
        TenantDetails? TenantDetails = null
    ) 
    {
        if ( IdentityDetails != null ) {
            this.IdentityDetails = IdentityDetails;
        }
        if ( TenantDetails != null ) {
            this.TenantDetails = TenantDetails;
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
        //      C# -> IdentityDetails? IdentityDetails
        // GraphQL -> identityDetails: IdentityDetails (type)
        if (this.IdentityDetails != null) {
            var fspec = this.IdentityDetails.AsFieldSpec(conf.Child("identityDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "identityDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TenantDetails? TenantDetails
        // GraphQL -> tenantDetails: TenantDetails (type)
        if (this.TenantDetails != null) {
            var fspec = this.TenantDetails.AsFieldSpec(conf.Child("tenantDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tenantDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IdentityDetails? IdentityDetails
        // GraphQL -> identityDetails: IdentityDetails (type)
        if (ec.Includes("identityDetails",false))
        {
            if(this.IdentityDetails == null) {

                this.IdentityDetails = new IdentityDetails();
                this.IdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("identityDetails"));

            } else {

                this.IdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("identityDetails"));

            }
        }
        else if (this.IdentityDetails != null && ec.Excludes("identityDetails",false))
        {
            this.IdentityDetails = null;
        }
        //      C# -> TenantDetails? TenantDetails
        // GraphQL -> tenantDetails: TenantDetails (type)
        if (ec.Includes("tenantDetails",false))
        {
            if(this.TenantDetails == null) {

                this.TenantDetails = new TenantDetails();
                this.TenantDetails.ApplyExploratoryFieldSpec(ec.NewChild("tenantDetails"));

            } else {

                this.TenantDetails.ApplyExploratoryFieldSpec(ec.NewChild("tenantDetails"));

            }
        }
        else if (this.TenantDetails != null && ec.Excludes("tenantDetails",false))
        {
            this.TenantDetails = null;
        }
    }


    #endregion

    } // class ActivityAuditorEntityDetails
    
    #endregion

    public static class ListActivityAuditorEntityDetailsExtensions
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
            this List<ActivityAuditorEntityDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActivityAuditorEntityDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActivityAuditorEntityDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActivityAuditorEntityDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActivityAuditorEntityDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types