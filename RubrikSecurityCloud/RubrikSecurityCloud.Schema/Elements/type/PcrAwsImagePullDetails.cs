// PcrAwsImagePullDetails.cs
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
    #region PcrAwsImagePullDetails
 
    public class PcrAwsImagePullDetails: BaseType, PcrImagePullDetails
    {
        #region members

        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        [JsonProperty("awsNativeId")]
        public System.String? AwsNativeId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PcrAwsImagePullDetails";
    }

    public PcrAwsImagePullDetails Set(
        System.String? AwsNativeId = null
    ) 
    {
        if ( AwsNativeId != null ) {
            this.AwsNativeId = AwsNativeId;
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
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsNativeId\n" ;
            } else {
                s += ind + "awsNativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (ec.Includes("awsNativeId",true))
        {
            if(this.AwsNativeId == null) {

                this.AwsNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AwsNativeId != null && ec.Excludes("awsNativeId",true))
        {
            this.AwsNativeId = null;
        }
    }


    #endregion

    } // class PcrAwsImagePullDetails
    
    #endregion

    public static class ListPcrAwsImagePullDetailsExtensions
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
            this List<PcrAwsImagePullDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PcrAwsImagePullDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PcrAwsImagePullDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PcrAwsImagePullDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PcrAwsImagePullDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types