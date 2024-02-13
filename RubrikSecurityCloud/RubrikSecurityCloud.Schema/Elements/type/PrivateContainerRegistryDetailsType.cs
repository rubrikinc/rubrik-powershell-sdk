// PrivateContainerRegistryDetailsType.cs
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
    #region PrivateContainerRegistryDetailsType
    public class PrivateContainerRegistryDetailsType: BaseType
    {
        #region members

        //      C# -> System.String? RegistryUrl
        // GraphQL -> registryUrl: String! (scalar)
        [JsonProperty("registryUrl")]
        public System.String? RegistryUrl { get; set; }

        //      C# -> PcrImagePullDetails? ImagePullDetails
        // GraphQL -> imagePullDetails: PcrImagePullDetails (union)
        [JsonProperty("imagePullDetails")]
        public PcrImagePullDetails? ImagePullDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrivateContainerRegistryDetailsType";
    }

    public PrivateContainerRegistryDetailsType Set(
        System.String? RegistryUrl = null,
        PcrImagePullDetails? ImagePullDetails = null
    ) 
    {
        if ( RegistryUrl != null ) {
            this.RegistryUrl = RegistryUrl;
        }
        if ( ImagePullDetails != null ) {
            this.ImagePullDetails = ImagePullDetails;
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
        //      C# -> System.String? RegistryUrl
        // GraphQL -> registryUrl: String! (scalar)
        if (this.RegistryUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "registryUrl\n" ;
            } else {
                s += ind + "registryUrl\n" ;
            }
        }
        //      C# -> PcrImagePullDetails? ImagePullDetails
        // GraphQL -> imagePullDetails: PcrImagePullDetails (union)
        if (this.ImagePullDetails != null) {
            var fspec = this.ImagePullDetails.AsFieldSpec(conf.Child("imagePullDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "imagePullDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RegistryUrl
        // GraphQL -> registryUrl: String! (scalar)
        if (ec.Includes("registryUrl",true))
        {
            if(this.RegistryUrl == null) {

                this.RegistryUrl = "FETCH";

            } else {


            }
        }
        else if (this.RegistryUrl != null && ec.Excludes("registryUrl",true))
        {
            this.RegistryUrl = null;
        }
        //      C# -> PcrImagePullDetails? ImagePullDetails
        // GraphQL -> imagePullDetails: PcrImagePullDetails (union)
        if (ec.Includes("imagePullDetails",false))
        {
            if(this.ImagePullDetails == null) {

                var impls = new List<PcrImagePullDetails>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("imagePullDetails"));
                this.ImagePullDetails = (PcrImagePullDetails)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<PcrImagePullDetails>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("imagePullDetails"));
                this.ImagePullDetails = (PcrImagePullDetails)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ImagePullDetails != null && ec.Excludes("imagePullDetails",false))
        {
            this.ImagePullDetails = null;
        }
    }


    #endregion

    } // class PrivateContainerRegistryDetailsType
    
    #endregion

    public static class ListPrivateContainerRegistryDetailsTypeExtensions
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
            this List<PrivateContainerRegistryDetailsType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PrivateContainerRegistryDetailsType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrivateContainerRegistryDetailsType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrivateContainerRegistryDetailsType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrivateContainerRegistryDetailsType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types