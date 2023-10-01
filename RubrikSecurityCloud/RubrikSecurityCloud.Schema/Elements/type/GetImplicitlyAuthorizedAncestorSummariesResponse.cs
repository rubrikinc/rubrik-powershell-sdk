// GetImplicitlyAuthorizedAncestorSummariesResponse.cs
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
    #region GetImplicitlyAuthorizedAncestorSummariesResponse
    public class GetImplicitlyAuthorizedAncestorSummariesResponse: BaseType
    {
        #region members

        //      C# -> List<ObjectSummary>? ObjectSummaries
        // GraphQL -> objectSummaries: [ObjectSummary!]! (type)
        [JsonProperty("objectSummaries")]
        public List<ObjectSummary>? ObjectSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetImplicitlyAuthorizedAncestorSummariesResponse";
    }

    public GetImplicitlyAuthorizedAncestorSummariesResponse Set(
        List<ObjectSummary>? ObjectSummaries = null
    ) 
    {
        if ( ObjectSummaries != null ) {
            this.ObjectSummaries = ObjectSummaries;
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
        //      C# -> List<ObjectSummary>? ObjectSummaries
        // GraphQL -> objectSummaries: [ObjectSummary!]! (type)
        if (this.ObjectSummaries != null) {
            var fspec = this.ObjectSummaries.AsFieldSpec(conf.Child("objectSummaries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectSummaries {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ObjectSummary>? ObjectSummaries
        // GraphQL -> objectSummaries: [ObjectSummary!]! (type)
        if (ec.Includes("objectSummaries",false))
        {
            if(this.ObjectSummaries == null) {

                this.ObjectSummaries = new List<ObjectSummary>();
                this.ObjectSummaries.ApplyExploratoryFieldSpec(ec.NewChild("objectSummaries"));

            } else {

                this.ObjectSummaries.ApplyExploratoryFieldSpec(ec.NewChild("objectSummaries"));

            }
        }
        else if (this.ObjectSummaries != null && ec.Excludes("objectSummaries",false))
        {
            this.ObjectSummaries = null;
        }
    }


    #endregion

    } // class GetImplicitlyAuthorizedAncestorSummariesResponse
    
    #endregion

    public static class ListGetImplicitlyAuthorizedAncestorSummariesResponseExtensions
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
            this List<GetImplicitlyAuthorizedAncestorSummariesResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GetImplicitlyAuthorizedAncestorSummariesResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetImplicitlyAuthorizedAncestorSummariesResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetImplicitlyAuthorizedAncestorSummariesResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetImplicitlyAuthorizedAncestorSummariesResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types