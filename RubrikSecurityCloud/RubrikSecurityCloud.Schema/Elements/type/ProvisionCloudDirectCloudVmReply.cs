// ProvisionCloudDirectCloudVmReply.cs
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
    #region ProvisionCloudDirectCloudVmReply
    public class ProvisionCloudDirectCloudVmReply: BaseType
    {
        #region members

        //      C# -> CloudDirectCloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudDirectCloudProvider! (enum)
        [JsonProperty("cloudProvider")]
        public CloudDirectCloudProvider? CloudProvider { get; set; }

        //      C# -> System.String? CloudRegion
        // GraphQL -> cloudRegion: String! (scalar)
        [JsonProperty("cloudRegion")]
        public System.String? CloudRegion { get; set; }

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String! (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> RegionImageIds? RegionImageIds
        // GraphQL -> regionImageIds: RegionImageIds! (type)
        [JsonProperty("regionImageIds")]
        public RegionImageIds? RegionImageIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProvisionCloudDirectCloudVmReply";
    }

    public ProvisionCloudDirectCloudVmReply Set(
        CloudDirectCloudProvider? CloudProvider = null,
        System.String? CloudRegion = null,
        System.String? ImageId = null,
        System.String? UserData = null,
        RegionImageIds? RegionImageIds = null
    ) 
    {
        if ( CloudProvider != null ) {
            this.CloudProvider = CloudProvider;
        }
        if ( CloudRegion != null ) {
            this.CloudRegion = CloudRegion;
        }
        if ( ImageId != null ) {
            this.ImageId = ImageId;
        }
        if ( UserData != null ) {
            this.UserData = UserData;
        }
        if ( RegionImageIds != null ) {
            this.RegionImageIds = RegionImageIds;
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
        //      C# -> CloudDirectCloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudDirectCloudProvider! (enum)
        if (this.CloudProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudProvider\n" ;
            } else {
                s += ind + "cloudProvider\n" ;
            }
        }
        //      C# -> System.String? CloudRegion
        // GraphQL -> cloudRegion: String! (scalar)
        if (this.CloudRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudRegion\n" ;
            } else {
                s += ind + "cloudRegion\n" ;
            }
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "imageId\n" ;
            } else {
                s += ind + "imageId\n" ;
            }
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String! (scalar)
        if (this.UserData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userData\n" ;
            } else {
                s += ind + "userData\n" ;
            }
        }
        //      C# -> RegionImageIds? RegionImageIds
        // GraphQL -> regionImageIds: RegionImageIds! (type)
        if (this.RegionImageIds != null) {
            var fspec = this.RegionImageIds.AsFieldSpec(conf.Child("regionImageIds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionImageIds" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudDirectCloudProvider? CloudProvider
        // GraphQL -> cloudProvider: CloudDirectCloudProvider! (enum)
        if (ec.Includes("cloudProvider",true))
        {
            if(this.CloudProvider == null) {

                this.CloudProvider = new CloudDirectCloudProvider();

            } else {


            }
        }
        else if (this.CloudProvider != null && ec.Excludes("cloudProvider",true))
        {
            this.CloudProvider = null;
        }
        //      C# -> System.String? CloudRegion
        // GraphQL -> cloudRegion: String! (scalar)
        if (ec.Includes("cloudRegion",true))
        {
            if(this.CloudRegion == null) {

                this.CloudRegion = "FETCH";

            } else {


            }
        }
        else if (this.CloudRegion != null && ec.Excludes("cloudRegion",true))
        {
            this.CloudRegion = null;
        }
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (ec.Includes("imageId",true))
        {
            if(this.ImageId == null) {

                this.ImageId = "FETCH";

            } else {


            }
        }
        else if (this.ImageId != null && ec.Excludes("imageId",true))
        {
            this.ImageId = null;
        }
        //      C# -> System.String? UserData
        // GraphQL -> userData: String! (scalar)
        if (ec.Includes("userData",true))
        {
            if(this.UserData == null) {

                this.UserData = "FETCH";

            } else {


            }
        }
        else if (this.UserData != null && ec.Excludes("userData",true))
        {
            this.UserData = null;
        }
        //      C# -> RegionImageIds? RegionImageIds
        // GraphQL -> regionImageIds: RegionImageIds! (type)
        if (ec.Includes("regionImageIds",false))
        {
            if(this.RegionImageIds == null) {

                this.RegionImageIds = new RegionImageIds();
                this.RegionImageIds.ApplyExploratoryFieldSpec(ec.NewChild("regionImageIds"));

            } else {

                this.RegionImageIds.ApplyExploratoryFieldSpec(ec.NewChild("regionImageIds"));

            }
        }
        else if (this.RegionImageIds != null && ec.Excludes("regionImageIds",false))
        {
            this.RegionImageIds = null;
        }
    }


    #endregion

    } // class ProvisionCloudDirectCloudVmReply
    
    #endregion

    public static class ListProvisionCloudDirectCloudVmReplyExtensions
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
            this List<ProvisionCloudDirectCloudVmReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProvisionCloudDirectCloudVmReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProvisionCloudDirectCloudVmReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProvisionCloudDirectCloudVmReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProvisionCloudDirectCloudVmReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types