// ExternalArtifactMapReply.cs
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
    #region ExternalArtifactMapReply
    public class ExternalArtifactMapReply: BaseType
    {
        #region members

        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        [JsonProperty("externalArtifactKey")]
        public AwsCloudExternalArtifact? ExternalArtifactKey { get; set; }

        //      C# -> System.String? ExternalArtifactValue
        // GraphQL -> externalArtifactValue: String! (scalar)
        [JsonProperty("externalArtifactValue")]
        public System.String? ExternalArtifactValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExternalArtifactMapReply";
    }

    public ExternalArtifactMapReply Set(
        AwsCloudExternalArtifact? ExternalArtifactKey = null,
        System.String? ExternalArtifactValue = null
    ) 
    {
        if ( ExternalArtifactKey != null ) {
            this.ExternalArtifactKey = ExternalArtifactKey;
        }
        if ( ExternalArtifactValue != null ) {
            this.ExternalArtifactValue = ExternalArtifactValue;
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
        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        if (this.ExternalArtifactKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalArtifactKey\n" ;
            } else {
                s += ind + "externalArtifactKey\n" ;
            }
        }
        //      C# -> System.String? ExternalArtifactValue
        // GraphQL -> externalArtifactValue: String! (scalar)
        if (this.ExternalArtifactValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "externalArtifactValue\n" ;
            } else {
                s += ind + "externalArtifactValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudExternalArtifact? ExternalArtifactKey
        // GraphQL -> externalArtifactKey: AwsCloudExternalArtifact! (enum)
        if (ec.Includes("externalArtifactKey",true))
        {
            if(this.ExternalArtifactKey == null) {

                this.ExternalArtifactKey = new AwsCloudExternalArtifact();

            } else {


            }
        }
        else if (this.ExternalArtifactKey != null && ec.Excludes("externalArtifactKey",true))
        {
            this.ExternalArtifactKey = null;
        }
        //      C# -> System.String? ExternalArtifactValue
        // GraphQL -> externalArtifactValue: String! (scalar)
        if (ec.Includes("externalArtifactValue",true))
        {
            if(this.ExternalArtifactValue == null) {

                this.ExternalArtifactValue = "FETCH";

            } else {


            }
        }
        else if (this.ExternalArtifactValue != null && ec.Excludes("externalArtifactValue",true))
        {
            this.ExternalArtifactValue = null;
        }
    }


    #endregion

    } // class ExternalArtifactMapReply
    
    #endregion

    public static class ListExternalArtifactMapReplyExtensions
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
            this List<ExternalArtifactMapReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExternalArtifactMapReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExternalArtifactMapReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExternalArtifactMapReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExternalArtifactMapReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types