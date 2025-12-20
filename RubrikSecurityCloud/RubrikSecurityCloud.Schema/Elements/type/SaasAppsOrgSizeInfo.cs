// SaasAppsOrgSizeInfo.cs
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
    #region SaasAppsOrgSizeInfo
    public class SaasAppsOrgSizeInfo: BaseType
    {
        #region members

        //      C# -> System.Int64? ConsumedSpaceInBytes
        // GraphQL -> consumedSpaceInBytes: Long! (scalar)
        [JsonProperty("consumedSpaceInBytes")]
        public System.Int64? ConsumedSpaceInBytes { get; set; }

        //      C# -> System.Int64? TotalSpaceInBytes
        // GraphQL -> totalSpaceInBytes: Long! (scalar)
        [JsonProperty("totalSpaceInBytes")]
        public System.Int64? TotalSpaceInBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasAppsOrgSizeInfo";
    }

    public SaasAppsOrgSizeInfo Set(
        System.Int64? ConsumedSpaceInBytes = null,
        System.Int64? TotalSpaceInBytes = null
    ) 
    {
        if ( ConsumedSpaceInBytes != null ) {
            this.ConsumedSpaceInBytes = ConsumedSpaceInBytes;
        }
        if ( TotalSpaceInBytes != null ) {
            this.TotalSpaceInBytes = TotalSpaceInBytes;
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
        //      C# -> System.Int64? ConsumedSpaceInBytes
        // GraphQL -> consumedSpaceInBytes: Long! (scalar)
        if (this.ConsumedSpaceInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "consumedSpaceInBytes\n" ;
            } else {
                s += ind + "consumedSpaceInBytes\n" ;
            }
        }
        //      C# -> System.Int64? TotalSpaceInBytes
        // GraphQL -> totalSpaceInBytes: Long! (scalar)
        if (this.TotalSpaceInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSpaceInBytes\n" ;
            } else {
                s += ind + "totalSpaceInBytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? ConsumedSpaceInBytes
        // GraphQL -> consumedSpaceInBytes: Long! (scalar)
        if (ec.Includes("consumedSpaceInBytes",true))
        {
            if(this.ConsumedSpaceInBytes == null) {

                this.ConsumedSpaceInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ConsumedSpaceInBytes != null && ec.Excludes("consumedSpaceInBytes",true))
        {
            this.ConsumedSpaceInBytes = null;
        }
        //      C# -> System.Int64? TotalSpaceInBytes
        // GraphQL -> totalSpaceInBytes: Long! (scalar)
        if (ec.Includes("totalSpaceInBytes",true))
        {
            if(this.TotalSpaceInBytes == null) {

                this.TotalSpaceInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSpaceInBytes != null && ec.Excludes("totalSpaceInBytes",true))
        {
            this.TotalSpaceInBytes = null;
        }
    }


    #endregion

    } // class SaasAppsOrgSizeInfo
    
    #endregion

    public static class ListSaasAppsOrgSizeInfoExtensions
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
            this List<SaasAppsOrgSizeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasAppsOrgSizeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasAppsOrgSizeInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasAppsOrgSizeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasAppsOrgSizeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types