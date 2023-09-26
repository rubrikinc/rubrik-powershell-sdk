// FeatureListMinimumCdmVersionReply.cs
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
    #region FeatureListMinimumCdmVersionReply
    public class FeatureListMinimumCdmVersionReply: BaseType
    {
        #region members

        //      C# -> System.String? MinimumVersion
        // GraphQL -> minimumVersion: String! (scalar)
        [JsonProperty("minimumVersion")]
        public System.String? MinimumVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FeatureListMinimumCdmVersionReply";
    }

    public FeatureListMinimumCdmVersionReply Set(
        System.String? MinimumVersion = null
    ) 
    {
        if ( MinimumVersion != null ) {
            this.MinimumVersion = MinimumVersion;
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
        //      C# -> System.String? MinimumVersion
        // GraphQL -> minimumVersion: String! (scalar)
        if (this.MinimumVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minimumVersion\n" ;
            } else {
                s += ind + "minimumVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? MinimumVersion
        // GraphQL -> minimumVersion: String! (scalar)
        if (ec.Includes("minimumVersion",true))
        {
            if(this.MinimumVersion == null) {

                this.MinimumVersion = "FETCH";

            } else {


            }
        }
        else if (this.MinimumVersion != null && ec.Excludes("minimumVersion",true))
        {
            this.MinimumVersion = null;
        }
    }


    #endregion

    } // class FeatureListMinimumCdmVersionReply
    
    #endregion

    public static class ListFeatureListMinimumCdmVersionReplyExtensions
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
            this List<FeatureListMinimumCdmVersionReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FeatureListMinimumCdmVersionReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FeatureListMinimumCdmVersionReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FeatureListMinimumCdmVersionReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types