// AllEnabledFeaturesForAccountReply.cs
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
    #region AllEnabledFeaturesForAccountReply
    public class AllEnabledFeaturesForAccountReply: BaseType
    {
        #region members

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AllEnabledFeaturesForAccountReply";
    }

    public AllEnabledFeaturesForAccountReply Set(
        List<CloudAccountFeature>? Features = null
    ) 
    {
        if ( Features != null ) {
            this.Features = Features;
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
        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        if (this.Features != null) {
            if (conf.Flat) {
                s += conf.Prefix + "features\n" ;
            } else {
                s += ind + "features\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        if (ec.Includes("features",true))
        {
            if(this.Features == null) {

                this.Features = new List<CloudAccountFeature>();

            } else {


            }
        }
        else if (this.Features != null && ec.Excludes("features",true))
        {
            this.Features = null;
        }
    }


    #endregion

    } // class AllEnabledFeaturesForAccountReply
    
    #endregion

    public static class ListAllEnabledFeaturesForAccountReplyExtensions
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
            this List<AllEnabledFeaturesForAccountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AllEnabledFeaturesForAccountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AllEnabledFeaturesForAccountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AllEnabledFeaturesForAccountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types