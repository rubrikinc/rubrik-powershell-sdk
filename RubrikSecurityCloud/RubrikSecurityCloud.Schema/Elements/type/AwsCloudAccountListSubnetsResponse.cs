// AwsCloudAccountListSubnetsResponse.cs
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
    #region AwsCloudAccountListSubnetsResponse
    public class AwsCloudAccountListSubnetsResponse: BaseType
    {
        #region members

        //      C# -> List<CloudAccountSubnet>? Result
        // GraphQL -> result: [CloudAccountSubnet!]! (type)
        [JsonProperty("result")]
        public List<CloudAccountSubnet>? Result { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCloudAccountListSubnetsResponse";
    }

    public AwsCloudAccountListSubnetsResponse Set(
        List<CloudAccountSubnet>? Result = null
    ) 
    {
        if ( Result != null ) {
            this.Result = Result;
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
        //      C# -> List<CloudAccountSubnet>? Result
        // GraphQL -> result: [CloudAccountSubnet!]! (type)
        if (this.Result != null) {
            var fspec = this.Result.AsFieldSpec(conf.Child("result"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "result {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudAccountSubnet>? Result
        // GraphQL -> result: [CloudAccountSubnet!]! (type)
        if (ec.Includes("result",false))
        {
            if(this.Result == null) {

                this.Result = new List<CloudAccountSubnet>();
                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            } else {

                this.Result.ApplyExploratoryFieldSpec(ec.NewChild("result"));

            }
        }
        else if (this.Result != null && ec.Excludes("result",false))
        {
            this.Result = null;
        }
    }


    #endregion

    } // class AwsCloudAccountListSubnetsResponse
    
    #endregion

    public static class ListAwsCloudAccountListSubnetsResponseExtensions
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
            this List<AwsCloudAccountListSubnetsResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountListSubnetsResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountListSubnetsResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountListSubnetsResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountListSubnetsResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types