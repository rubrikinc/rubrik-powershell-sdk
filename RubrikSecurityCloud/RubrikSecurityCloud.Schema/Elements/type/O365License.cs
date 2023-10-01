// O365License.cs
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
    #region O365License
    public class O365License: BaseType
    {
        #region members

        //      C# -> O365LicenseDetails? LicenseDetails
        // GraphQL -> licenseDetails: O365LicenseDetails (type)
        [JsonProperty("licenseDetails")]
        public O365LicenseDetails? LicenseDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365License";
    }

    public O365License Set(
        O365LicenseDetails? LicenseDetails = null
    ) 
    {
        if ( LicenseDetails != null ) {
            this.LicenseDetails = LicenseDetails;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> O365LicenseDetails? LicenseDetails
        // GraphQL -> licenseDetails: O365LicenseDetails (type)
        if (this.LicenseDetails != null) {
            var fspec = this.LicenseDetails.AsFieldSpec(conf.Child("licenseDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365LicenseDetails? LicenseDetails
        // GraphQL -> licenseDetails: O365LicenseDetails (type)
        if (ec.Includes("licenseDetails",false))
        {
            if(this.LicenseDetails == null) {

                this.LicenseDetails = new O365LicenseDetails();
                this.LicenseDetails.ApplyExploratoryFieldSpec(ec.NewChild("licenseDetails"));

            } else {

                this.LicenseDetails.ApplyExploratoryFieldSpec(ec.NewChild("licenseDetails"));

            }
        }
        else if (this.LicenseDetails != null && ec.Excludes("licenseDetails",false))
        {
            this.LicenseDetails = null;
        }
    }


    #endregion

    } // class O365License
    
    #endregion

    public static class ListO365LicenseExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<O365License> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<O365License> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365License> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365License());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365License> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types