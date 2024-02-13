// PrivateContainerRegistryReplyType.cs
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
    #region PrivateContainerRegistryReplyType
    public class PrivateContainerRegistryReplyType: BaseType
    {
        #region members

        //      C# -> PrivateContainerRegistryDetailsType? PcrDetails
        // GraphQL -> pcrDetails: PrivateContainerRegistryDetailsType (type)
        [JsonProperty("pcrDetails")]
        public PrivateContainerRegistryDetailsType? PcrDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrivateContainerRegistryReplyType";
    }

    public PrivateContainerRegistryReplyType Set(
        PrivateContainerRegistryDetailsType? PcrDetails = null
    ) 
    {
        if ( PcrDetails != null ) {
            this.PcrDetails = PcrDetails;
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
        //      C# -> PrivateContainerRegistryDetailsType? PcrDetails
        // GraphQL -> pcrDetails: PrivateContainerRegistryDetailsType (type)
        if (this.PcrDetails != null) {
            var fspec = this.PcrDetails.AsFieldSpec(conf.Child("pcrDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pcrDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PrivateContainerRegistryDetailsType? PcrDetails
        // GraphQL -> pcrDetails: PrivateContainerRegistryDetailsType (type)
        if (ec.Includes("pcrDetails",false))
        {
            if(this.PcrDetails == null) {

                this.PcrDetails = new PrivateContainerRegistryDetailsType();
                this.PcrDetails.ApplyExploratoryFieldSpec(ec.NewChild("pcrDetails"));

            } else {

                this.PcrDetails.ApplyExploratoryFieldSpec(ec.NewChild("pcrDetails"));

            }
        }
        else if (this.PcrDetails != null && ec.Excludes("pcrDetails",false))
        {
            this.PcrDetails = null;
        }
    }


    #endregion

    } // class PrivateContainerRegistryReplyType
    
    #endregion

    public static class ListPrivateContainerRegistryReplyTypeExtensions
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
            this List<PrivateContainerRegistryReplyType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PrivateContainerRegistryReplyType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrivateContainerRegistryReplyType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrivateContainerRegistryReplyType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrivateContainerRegistryReplyType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types