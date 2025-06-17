// InstancePropertiesReply.cs
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
    #region InstancePropertiesReply
    public class InstancePropertiesReply: BaseType
    {
        #region members

        //      C# -> List<InstanceProperties>? InstanceProperties
        // GraphQL -> instanceProperties: [InstanceProperties!]! (type)
        [JsonProperty("instanceProperties")]
        public List<InstanceProperties>? InstanceProperties { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InstancePropertiesReply";
    }

    public InstancePropertiesReply Set(
        List<InstanceProperties>? InstanceProperties = null
    ) 
    {
        if ( InstanceProperties != null ) {
            this.InstanceProperties = InstanceProperties;
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
        //      C# -> List<InstanceProperties>? InstanceProperties
        // GraphQL -> instanceProperties: [InstanceProperties!]! (type)
        if (this.InstanceProperties != null) {
            var fspec = this.InstanceProperties.AsFieldSpec(conf.Child("instanceProperties"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "instanceProperties" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<InstanceProperties>? InstanceProperties
        // GraphQL -> instanceProperties: [InstanceProperties!]! (type)
        if (ec.Includes("instanceProperties",false))
        {
            if(this.InstanceProperties == null) {

                this.InstanceProperties = new List<InstanceProperties>();
                this.InstanceProperties.ApplyExploratoryFieldSpec(ec.NewChild("instanceProperties"));

            } else {

                this.InstanceProperties.ApplyExploratoryFieldSpec(ec.NewChild("instanceProperties"));

            }
        }
        else if (this.InstanceProperties != null && ec.Excludes("instanceProperties",false))
        {
            this.InstanceProperties = null;
        }
    }


    #endregion

    } // class InstancePropertiesReply
    
    #endregion

    public static class ListInstancePropertiesReplyExtensions
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
            this List<InstancePropertiesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<InstancePropertiesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InstancePropertiesReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InstancePropertiesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InstancePropertiesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types