// RequestedMatchDetails.cs
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
    #region RequestedMatchDetails
    public class RequestedMatchDetails: BaseType
    {
        #region members

        //      C# -> List<HashType>? RequestedHashTypes
        // GraphQL -> requestedHashTypes: [HashType!] (enum)
        [JsonProperty("requestedHashTypes")]
        public List<HashType>? RequestedHashTypes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RequestedMatchDetails";
    }

    public RequestedMatchDetails Set(
        List<HashType>? RequestedHashTypes = null
    ) 
    {
        if ( RequestedHashTypes != null ) {
            this.RequestedHashTypes = RequestedHashTypes;
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
        //      C# -> List<HashType>? RequestedHashTypes
        // GraphQL -> requestedHashTypes: [HashType!] (enum)
        if (this.RequestedHashTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestedHashTypes\n" ;
            } else {
                s += ind + "requestedHashTypes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<HashType>? RequestedHashTypes
        // GraphQL -> requestedHashTypes: [HashType!] (enum)
        if (ec.Includes("requestedHashTypes",true))
        {
            if(this.RequestedHashTypes == null) {

                this.RequestedHashTypes = new List<HashType>();

            } else {


            }
        }
        else if (this.RequestedHashTypes != null && ec.Excludes("requestedHashTypes",true))
        {
            this.RequestedHashTypes = null;
        }
    }


    #endregion

    } // class RequestedMatchDetails
    
    #endregion

    public static class ListRequestedMatchDetailsExtensions
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
            this List<RequestedMatchDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RequestedMatchDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RequestedMatchDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RequestedMatchDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RequestedMatchDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types