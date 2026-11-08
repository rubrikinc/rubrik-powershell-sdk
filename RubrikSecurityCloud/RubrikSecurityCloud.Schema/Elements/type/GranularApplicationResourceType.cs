// GranularApplicationResourceType.cs
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
    #region GranularApplicationResourceType
    public class GranularApplicationResourceType: BaseType
    {
        #region members

        //      C# -> CloudNativeObjectType? CloudNativeObjectType
        // GraphQL -> cloudNativeObjectType: CloudNativeObjectType (enum)
        [JsonProperty("cloudNativeObjectType")]
        public CloudNativeObjectType? CloudNativeObjectType { get; set; }

        //      C# -> ConfigResourceType? ConfigResourceType
        // GraphQL -> configResourceType: ConfigResourceType (enum)
        [JsonProperty("configResourceType")]
        public ConfigResourceType? ConfigResourceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GranularApplicationResourceType";
    }

    public GranularApplicationResourceType Set(
        CloudNativeObjectType? CloudNativeObjectType = null,
        ConfigResourceType? ConfigResourceType = null
    ) 
    {
        if ( CloudNativeObjectType != null ) {
            this.CloudNativeObjectType = CloudNativeObjectType;
        }
        if ( ConfigResourceType != null ) {
            this.ConfigResourceType = ConfigResourceType;
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
        //      C# -> CloudNativeObjectType? CloudNativeObjectType
        // GraphQL -> cloudNativeObjectType: CloudNativeObjectType (enum)
        if (this.CloudNativeObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudNativeObjectType\n" ;
            } else {
                s += ind + "cloudNativeObjectType\n" ;
            }
        }
        //      C# -> ConfigResourceType? ConfigResourceType
        // GraphQL -> configResourceType: ConfigResourceType (enum)
        if (this.ConfigResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configResourceType\n" ;
            } else {
                s += ind + "configResourceType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudNativeObjectType? CloudNativeObjectType
        // GraphQL -> cloudNativeObjectType: CloudNativeObjectType (enum)
        if (ec.Includes("cloudNativeObjectType",true))
        {
            if(this.CloudNativeObjectType == null) {

                this.CloudNativeObjectType = new CloudNativeObjectType();

            } else {


            }
        }
        else if (this.CloudNativeObjectType != null && ec.Excludes("cloudNativeObjectType",true))
        {
            this.CloudNativeObjectType = null;
        }
        //      C# -> ConfigResourceType? ConfigResourceType
        // GraphQL -> configResourceType: ConfigResourceType (enum)
        if (ec.Includes("configResourceType",true))
        {
            if(this.ConfigResourceType == null) {

                this.ConfigResourceType = new ConfigResourceType();

            } else {


            }
        }
        else if (this.ConfigResourceType != null && ec.Excludes("configResourceType",true))
        {
            this.ConfigResourceType = null;
        }
    }


    #endregion

    } // class GranularApplicationResourceType
    
    #endregion

    public static class ListGranularApplicationResourceTypeExtensions
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
            this List<GranularApplicationResourceType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GranularApplicationResourceType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GranularApplicationResourceType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GranularApplicationResourceType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GranularApplicationResourceType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types