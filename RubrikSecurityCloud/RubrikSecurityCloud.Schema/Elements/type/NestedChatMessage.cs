// NestedChatMessage.cs
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
    #region NestedChatMessage
    public class NestedChatMessage: BaseType
    {
        #region members

        //      C# -> NestedMessageType? MessageType
        // GraphQL -> messageType: NestedMessageType! (enum)
        [JsonProperty("messageType")]
        public NestedMessageType? MessageType { get; set; }

        //      C# -> NestedChatMessageAdditionalInfo? AdditionalInfo
        // GraphQL -> additionalInfo: NestedChatMessageAdditionalInfo (type)
        [JsonProperty("additionalInfo")]
        public NestedChatMessageAdditionalInfo? AdditionalInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NestedChatMessage";
    }

    public NestedChatMessage Set(
        NestedMessageType? MessageType = null,
        NestedChatMessageAdditionalInfo? AdditionalInfo = null
    ) 
    {
        if ( MessageType != null ) {
            this.MessageType = MessageType;
        }
        if ( AdditionalInfo != null ) {
            this.AdditionalInfo = AdditionalInfo;
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
        //      C# -> NestedMessageType? MessageType
        // GraphQL -> messageType: NestedMessageType! (enum)
        if (this.MessageType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "messageType\n" ;
            } else {
                s += ind + "messageType\n" ;
            }
        }
        //      C# -> NestedChatMessageAdditionalInfo? AdditionalInfo
        // GraphQL -> additionalInfo: NestedChatMessageAdditionalInfo (type)
        if (this.AdditionalInfo != null) {
            var fspec = this.AdditionalInfo.AsFieldSpec(conf.Child("additionalInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "additionalInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NestedMessageType? MessageType
        // GraphQL -> messageType: NestedMessageType! (enum)
        if (ec.Includes("messageType",true))
        {
            if(this.MessageType == null) {

                this.MessageType = new NestedMessageType();

            } else {


            }
        }
        else if (this.MessageType != null && ec.Excludes("messageType",true))
        {
            this.MessageType = null;
        }
        //      C# -> NestedChatMessageAdditionalInfo? AdditionalInfo
        // GraphQL -> additionalInfo: NestedChatMessageAdditionalInfo (type)
        if (ec.Includes("additionalInfo",false))
        {
            if(this.AdditionalInfo == null) {

                this.AdditionalInfo = new NestedChatMessageAdditionalInfo();
                this.AdditionalInfo.ApplyExploratoryFieldSpec(ec.NewChild("additionalInfo"));

            } else {

                this.AdditionalInfo.ApplyExploratoryFieldSpec(ec.NewChild("additionalInfo"));

            }
        }
        else if (this.AdditionalInfo != null && ec.Excludes("additionalInfo",false))
        {
            this.AdditionalInfo = null;
        }
    }


    #endregion

    } // class NestedChatMessage
    
    #endregion

    public static class ListNestedChatMessageExtensions
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
            this List<NestedChatMessage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NestedChatMessage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NestedChatMessage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NestedChatMessage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NestedChatMessage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types