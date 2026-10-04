// CdmLocalConfigNodeValue.cs
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
    #region CdmLocalConfigNodeValue
    public class CdmLocalConfigNodeValue: BaseType
    {
        #region members

        //      C# -> CdmConfigParamState? State
        // GraphQL -> state: CdmConfigParamState! (enum)
        [JsonProperty("state")]
        public CdmConfigParamState? State { get; set; }

        //      C# -> System.String? CurrentValue
        // GraphQL -> currentValue: String! (scalar)
        [JsonProperty("currentValue")]
        public System.String? CurrentValue { get; set; }

        //      C# -> System.String? DefaultValue
        // GraphQL -> defaultValue: String! (scalar)
        [JsonProperty("defaultValue")]
        public System.String? DefaultValue { get; set; }

        //      C# -> DateTime? LastSyncedTime
        // GraphQL -> lastSyncedTime: DateTime (scalar)
        [JsonProperty("lastSyncedTime")]
        public DateTime? LastSyncedTime { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmLocalConfigNodeValue";
    }

    public CdmLocalConfigNodeValue Set(
        CdmConfigParamState? State = null,
        System.String? CurrentValue = null,
        System.String? DefaultValue = null,
        DateTime? LastSyncedTime = null,
        System.String? NodeId = null,
        System.String? NodeName = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( CurrentValue != null ) {
            this.CurrentValue = CurrentValue;
        }
        if ( DefaultValue != null ) {
            this.DefaultValue = DefaultValue;
        }
        if ( LastSyncedTime != null ) {
            this.LastSyncedTime = LastSyncedTime;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
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
        //      C# -> CdmConfigParamState? State
        // GraphQL -> state: CdmConfigParamState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? CurrentValue
        // GraphQL -> currentValue: String! (scalar)
        if (this.CurrentValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentValue\n" ;
            } else {
                s += ind + "currentValue\n" ;
            }
        }
        //      C# -> System.String? DefaultValue
        // GraphQL -> defaultValue: String! (scalar)
        if (this.DefaultValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultValue\n" ;
            } else {
                s += ind + "defaultValue\n" ;
            }
        }
        //      C# -> DateTime? LastSyncedTime
        // GraphQL -> lastSyncedTime: DateTime (scalar)
        if (this.LastSyncedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSyncedTime\n" ;
            } else {
                s += ind + "lastSyncedTime\n" ;
            }
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeId\n" ;
            } else {
                s += ind + "nodeId\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CdmConfigParamState? State
        // GraphQL -> state: CdmConfigParamState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new CdmConfigParamState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? CurrentValue
        // GraphQL -> currentValue: String! (scalar)
        if (ec.Includes("currentValue",true))
        {
            if(this.CurrentValue == null) {

                this.CurrentValue = "FETCH";

            } else {


            }
        }
        else if (this.CurrentValue != null && ec.Excludes("currentValue",true))
        {
            this.CurrentValue = null;
        }
        //      C# -> System.String? DefaultValue
        // GraphQL -> defaultValue: String! (scalar)
        if (ec.Includes("defaultValue",true))
        {
            if(this.DefaultValue == null) {

                this.DefaultValue = "FETCH";

            } else {


            }
        }
        else if (this.DefaultValue != null && ec.Excludes("defaultValue",true))
        {
            this.DefaultValue = null;
        }
        //      C# -> DateTime? LastSyncedTime
        // GraphQL -> lastSyncedTime: DateTime (scalar)
        if (ec.Includes("lastSyncedTime",true))
        {
            if(this.LastSyncedTime == null) {

                this.LastSyncedTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSyncedTime != null && ec.Excludes("lastSyncedTime",true))
        {
            this.LastSyncedTime = null;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (ec.Includes("nodeId",true))
        {
            if(this.NodeId == null) {

                this.NodeId = "FETCH";

            } else {


            }
        }
        else if (this.NodeId != null && ec.Excludes("nodeId",true))
        {
            this.NodeId = null;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
        }
    }


    #endregion

    } // class CdmLocalConfigNodeValue
    
    #endregion

    public static class ListCdmLocalConfigNodeValueExtensions
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
            this List<CdmLocalConfigNodeValue> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmLocalConfigNodeValue> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmLocalConfigNodeValue> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmLocalConfigNodeValue());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmLocalConfigNodeValue> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types