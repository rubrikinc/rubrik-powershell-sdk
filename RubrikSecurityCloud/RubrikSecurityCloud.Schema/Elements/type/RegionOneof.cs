// RegionOneof.cs
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
    #region RegionOneof
    public class RegionOneof: BaseType
    {
        #region members

        //      C# -> AwsAuthServerBasedCloudAccountRegion? AuthServerRegion
        // GraphQL -> authServerRegion: AwsAuthServerBasedCloudAccountRegion (enum)
        [JsonProperty("authServerRegion")]
        public AwsAuthServerBasedCloudAccountRegion? AuthServerRegion { get; set; }

        //      C# -> AwsCloudAccountRegion? StandardRegion
        // GraphQL -> standardRegion: AwsCloudAccountRegion (enum)
        [JsonProperty("standardRegion")]
        public AwsCloudAccountRegion? StandardRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegionOneof";
    }

    public RegionOneof Set(
        AwsAuthServerBasedCloudAccountRegion? AuthServerRegion = null,
        AwsCloudAccountRegion? StandardRegion = null
    ) 
    {
        if ( AuthServerRegion != null ) {
            this.AuthServerRegion = AuthServerRegion;
        }
        if ( StandardRegion != null ) {
            this.StandardRegion = StandardRegion;
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
        //      C# -> AwsAuthServerBasedCloudAccountRegion? AuthServerRegion
        // GraphQL -> authServerRegion: AwsAuthServerBasedCloudAccountRegion (enum)
        if (this.AuthServerRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authServerRegion\n" ;
            } else {
                s += ind + "authServerRegion\n" ;
            }
        }
        //      C# -> AwsCloudAccountRegion? StandardRegion
        // GraphQL -> standardRegion: AwsCloudAccountRegion (enum)
        if (this.StandardRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "standardRegion\n" ;
            } else {
                s += ind + "standardRegion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AwsAuthServerBasedCloudAccountRegion? AuthServerRegion
        // GraphQL -> authServerRegion: AwsAuthServerBasedCloudAccountRegion (enum)
        if (ec.Includes("authServerRegion",true))
        {
            if(this.AuthServerRegion == null) {

                this.AuthServerRegion = new AwsAuthServerBasedCloudAccountRegion();

            } else {


            }
        }
        else if (this.AuthServerRegion != null && ec.Excludes("authServerRegion",true))
        {
            this.AuthServerRegion = null;
        }
        //      C# -> AwsCloudAccountRegion? StandardRegion
        // GraphQL -> standardRegion: AwsCloudAccountRegion (enum)
        if (ec.Includes("standardRegion",true))
        {
            if(this.StandardRegion == null) {

                this.StandardRegion = new AwsCloudAccountRegion();

            } else {


            }
        }
        else if (this.StandardRegion != null && ec.Excludes("standardRegion",true))
        {
            this.StandardRegion = null;
        }
    }


    #endregion

    } // class RegionOneof
    
    #endregion

    public static class ListRegionOneofExtensions
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
            this List<RegionOneof> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RegionOneof> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegionOneof> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegionOneof());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegionOneof> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types