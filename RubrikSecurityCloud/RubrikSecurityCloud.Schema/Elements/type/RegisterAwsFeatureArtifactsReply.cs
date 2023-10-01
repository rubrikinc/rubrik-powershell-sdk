// RegisterAwsFeatureArtifactsReply.cs
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
    #region RegisterAwsFeatureArtifactsReply
    public class RegisterAwsFeatureArtifactsReply: BaseType
    {
        #region members

        //      C# -> List<AwsRscAccountDetails>? AllAwsNativeIdtoRscIdMappings
        // GraphQL -> allAwsNativeIdtoRscIdMappings: [AwsRscAccountDetails!]! (type)
        [JsonProperty("allAwsNativeIdtoRscIdMappings")]
        public List<AwsRscAccountDetails>? AllAwsNativeIdtoRscIdMappings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RegisterAwsFeatureArtifactsReply";
    }

    public RegisterAwsFeatureArtifactsReply Set(
        List<AwsRscAccountDetails>? AllAwsNativeIdtoRscIdMappings = null
    ) 
    {
        if ( AllAwsNativeIdtoRscIdMappings != null ) {
            this.AllAwsNativeIdtoRscIdMappings = AllAwsNativeIdtoRscIdMappings;
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
        //      C# -> List<AwsRscAccountDetails>? AllAwsNativeIdtoRscIdMappings
        // GraphQL -> allAwsNativeIdtoRscIdMappings: [AwsRscAccountDetails!]! (type)
        if (this.AllAwsNativeIdtoRscIdMappings != null) {
            var fspec = this.AllAwsNativeIdtoRscIdMappings.AsFieldSpec(conf.Child("allAwsNativeIdtoRscIdMappings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allAwsNativeIdtoRscIdMappings {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsRscAccountDetails>? AllAwsNativeIdtoRscIdMappings
        // GraphQL -> allAwsNativeIdtoRscIdMappings: [AwsRscAccountDetails!]! (type)
        if (ec.Includes("allAwsNativeIdtoRscIdMappings",false))
        {
            if(this.AllAwsNativeIdtoRscIdMappings == null) {

                this.AllAwsNativeIdtoRscIdMappings = new List<AwsRscAccountDetails>();
                this.AllAwsNativeIdtoRscIdMappings.ApplyExploratoryFieldSpec(ec.NewChild("allAwsNativeIdtoRscIdMappings"));

            } else {

                this.AllAwsNativeIdtoRscIdMappings.ApplyExploratoryFieldSpec(ec.NewChild("allAwsNativeIdtoRscIdMappings"));

            }
        }
        else if (this.AllAwsNativeIdtoRscIdMappings != null && ec.Excludes("allAwsNativeIdtoRscIdMappings",false))
        {
            this.AllAwsNativeIdtoRscIdMappings = null;
        }
    }


    #endregion

    } // class RegisterAwsFeatureArtifactsReply
    
    #endregion

    public static class ListRegisterAwsFeatureArtifactsReplyExtensions
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
            this List<RegisterAwsFeatureArtifactsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RegisterAwsFeatureArtifactsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RegisterAwsFeatureArtifactsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RegisterAwsFeatureArtifactsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RegisterAwsFeatureArtifactsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types