// LicenseConsumptionType.cs
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
    #region LicenseConsumptionType
    public class LicenseConsumptionType: BaseType
    {
        #region members

        //      C# -> System.Int64? FetbConsumed
        // GraphQL -> fetbConsumed: Long (scalar)
        [JsonProperty("fetbConsumed")]
        public System.Int64? FetbConsumed { get; set; }

        //      C# -> System.Int32? UsersProtected
        // GraphQL -> usersProtected: Int (scalar)
        [JsonProperty("usersProtected")]
        public System.Int32? UsersProtected { get; set; }

        //      C# -> ProtectedUserDetails? ProtectedUserDetails
        // GraphQL -> protectedUserDetails: ProtectedUserDetails (type)
        [JsonProperty("protectedUserDetails")]
        public ProtectedUserDetails? ProtectedUserDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicenseConsumptionType";
    }

    public LicenseConsumptionType Set(
        System.Int64? FetbConsumed = null,
        System.Int32? UsersProtected = null,
        ProtectedUserDetails? ProtectedUserDetails = null
    ) 
    {
        if ( FetbConsumed != null ) {
            this.FetbConsumed = FetbConsumed;
        }
        if ( UsersProtected != null ) {
            this.UsersProtected = UsersProtected;
        }
        if ( ProtectedUserDetails != null ) {
            this.ProtectedUserDetails = ProtectedUserDetails;
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
        //      C# -> System.Int64? FetbConsumed
        // GraphQL -> fetbConsumed: Long (scalar)
        if (this.FetbConsumed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fetbConsumed\n" ;
            } else {
                s += ind + "fetbConsumed\n" ;
            }
        }
        //      C# -> System.Int32? UsersProtected
        // GraphQL -> usersProtected: Int (scalar)
        if (this.UsersProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usersProtected\n" ;
            } else {
                s += ind + "usersProtected\n" ;
            }
        }
        //      C# -> ProtectedUserDetails? ProtectedUserDetails
        // GraphQL -> protectedUserDetails: ProtectedUserDetails (type)
        if (this.ProtectedUserDetails != null) {
            var fspec = this.ProtectedUserDetails.AsFieldSpec(conf.Child("protectedUserDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "protectedUserDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? FetbConsumed
        // GraphQL -> fetbConsumed: Long (scalar)
        if (ec.Includes("fetbConsumed",true))
        {
            if(this.FetbConsumed == null) {

                this.FetbConsumed = new System.Int64();

            } else {


            }
        }
        else if (this.FetbConsumed != null && ec.Excludes("fetbConsumed",true))
        {
            this.FetbConsumed = null;
        }
        //      C# -> System.Int32? UsersProtected
        // GraphQL -> usersProtected: Int (scalar)
        if (ec.Includes("usersProtected",true))
        {
            if(this.UsersProtected == null) {

                this.UsersProtected = Int32.MinValue;

            } else {


            }
        }
        else if (this.UsersProtected != null && ec.Excludes("usersProtected",true))
        {
            this.UsersProtected = null;
        }
        //      C# -> ProtectedUserDetails? ProtectedUserDetails
        // GraphQL -> protectedUserDetails: ProtectedUserDetails (type)
        if (ec.Includes("protectedUserDetails",false))
        {
            if(this.ProtectedUserDetails == null) {

                this.ProtectedUserDetails = new ProtectedUserDetails();
                this.ProtectedUserDetails.ApplyExploratoryFieldSpec(ec.NewChild("protectedUserDetails"));

            } else {

                this.ProtectedUserDetails.ApplyExploratoryFieldSpec(ec.NewChild("protectedUserDetails"));

            }
        }
        else if (this.ProtectedUserDetails != null && ec.Excludes("protectedUserDetails",false))
        {
            this.ProtectedUserDetails = null;
        }
    }


    #endregion

    } // class LicenseConsumptionType
    
    #endregion

    public static class ListLicenseConsumptionTypeExtensions
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
            this List<LicenseConsumptionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicenseConsumptionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicenseConsumptionType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicenseConsumptionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicenseConsumptionType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types