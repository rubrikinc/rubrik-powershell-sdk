// CcesCloudUsage.cs
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
    #region CcesCloudUsage
    public class CcesCloudUsage: BaseType
    {
        #region members

        //      C# -> LicenseCloudProvider? CloudProvider
        // GraphQL -> cloudProvider: LicenseCloudProvider! (enum)
        [JsonProperty("cloudProvider")]
        public LicenseCloudProvider? CloudProvider { get; set; }

        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        [JsonProperty("frontEndBytesConsumed")]
        public System.Int64? FrontEndBytesConsumed { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CcesCloudUsage";
    }

    public CcesCloudUsage Set(
        LicenseCloudProvider? CloudProvider = null,
        System.Int64? FrontEndBytesConsumed = null
    ) 
    {
        if ( CloudProvider != null ) {
            this.CloudProvider = CloudProvider;
        }
        if ( FrontEndBytesConsumed != null ) {
            this.FrontEndBytesConsumed = FrontEndBytesConsumed;
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
        //      C# -> LicenseCloudProvider? CloudProvider
        // GraphQL -> cloudProvider: LicenseCloudProvider! (enum)
        if (this.CloudProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudProvider\n" ;
            } else {
                s += ind + "cloudProvider\n" ;
            }
        }
        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        if (this.FrontEndBytesConsumed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frontEndBytesConsumed\n" ;
            } else {
                s += ind + "frontEndBytesConsumed\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LicenseCloudProvider? CloudProvider
        // GraphQL -> cloudProvider: LicenseCloudProvider! (enum)
        if (ec.Includes("cloudProvider",true))
        {
            if(this.CloudProvider == null) {

                this.CloudProvider = new LicenseCloudProvider();

            } else {


            }
        }
        else if (this.CloudProvider != null && ec.Excludes("cloudProvider",true))
        {
            this.CloudProvider = null;
        }
        //      C# -> System.Int64? FrontEndBytesConsumed
        // GraphQL -> frontEndBytesConsumed: Long! (scalar)
        if (ec.Includes("frontEndBytesConsumed",true))
        {
            if(this.FrontEndBytesConsumed == null) {

                this.FrontEndBytesConsumed = new System.Int64();

            } else {


            }
        }
        else if (this.FrontEndBytesConsumed != null && ec.Excludes("frontEndBytesConsumed",true))
        {
            this.FrontEndBytesConsumed = null;
        }
    }


    #endregion

    } // class CcesCloudUsage
    
    #endregion

    public static class ListCcesCloudUsageExtensions
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
            this List<CcesCloudUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CcesCloudUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CcesCloudUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CcesCloudUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CcesCloudUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types