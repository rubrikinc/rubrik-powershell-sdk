// DevOpsCloudNativeExocompute.cs
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
    #region DevOpsCloudNativeExocompute
    public class DevOpsCloudNativeExocompute: BaseType
    {
        #region members

        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        [JsonProperty("cloudType")]
        public CloudServiceProvider? CloudType { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        [JsonProperty("region")]
        public CloudRegion? Region { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DevOpsCloudNativeExocompute";
    }

    public DevOpsCloudNativeExocompute Set(
        CloudServiceProvider? CloudType = null,
        System.String? HostName = null,
        System.String? Id = null,
        CloudRegion? Region = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( HostName != null ) {
            this.HostName = HostName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Region != null ) {
            this.Region = Region;
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
        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (this.HostName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostName\n" ;
            } else {
                s += ind + "hostName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        if (this.Region != null) {
            var fspec = this.Region.AsFieldSpec(conf.Child("region"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "region" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudServiceProvider? CloudType
        // GraphQL -> cloudType: CloudServiceProvider! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new CloudServiceProvider();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        if (ec.Includes("hostName",true))
        {
            if(this.HostName == null) {

                this.HostName = "FETCH";

            } else {


            }
        }
        else if (this.HostName != null && ec.Excludes("hostName",true))
        {
            this.HostName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
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
        //      C# -> CloudRegion? Region
        // GraphQL -> region: CloudRegion (type)
        if (ec.Includes("region",false))
        {
            if(this.Region == null) {

                this.Region = new CloudRegion();
                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            } else {

                this.Region.ApplyExploratoryFieldSpec(ec.NewChild("region"));

            }
        }
        else if (this.Region != null && ec.Excludes("region",false))
        {
            this.Region = null;
        }
    }


    #endregion

    } // class DevOpsCloudNativeExocompute
    
    #endregion

    public static class ListDevOpsCloudNativeExocomputeExtensions
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
            this List<DevOpsCloudNativeExocompute> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DevOpsCloudNativeExocompute> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DevOpsCloudNativeExocompute> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DevOpsCloudNativeExocompute());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DevOpsCloudNativeExocompute> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types