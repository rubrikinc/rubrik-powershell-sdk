// SegregatedObjectTypeConsumptionEntry.cs
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
    #region SegregatedObjectTypeConsumptionEntry
    public class SegregatedObjectTypeConsumptionEntry: BaseType
    {
        #region members

        //      C# -> ObjectState? ObjectState
        // GraphQL -> objectState: ObjectState! (enum)
        [JsonProperty("objectState")]
        public ObjectState? ObjectState { get; set; }

        //      C# -> O365SnappableType? ObjectType
        // GraphQL -> objectType: O365SnappableType! (enum)
        [JsonProperty("objectType")]
        public O365SnappableType? ObjectType { get; set; }

        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        [JsonProperty("protectionStatus")]
        public ProtectionStatusEnum? ProtectionStatus { get; set; }

        //      C# -> System.Int64? Bytes
        // GraphQL -> bytes: Long (scalar)
        [JsonProperty("bytes")]
        public System.Int64? Bytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SegregatedObjectTypeConsumptionEntry";
    }

    public SegregatedObjectTypeConsumptionEntry Set(
        ObjectState? ObjectState = null,
        O365SnappableType? ObjectType = null,
        ProtectionStatusEnum? ProtectionStatus = null,
        System.Int64? Bytes = null
    ) 
    {
        if ( ObjectState != null ) {
            this.ObjectState = ObjectState;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( Bytes != null ) {
            this.Bytes = Bytes;
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
        //      C# -> ObjectState? ObjectState
        // GraphQL -> objectState: ObjectState! (enum)
        if (this.ObjectState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectState\n" ;
            } else {
                s += ind + "objectState\n" ;
            }
        }
        //      C# -> O365SnappableType? ObjectType
        // GraphQL -> objectType: O365SnappableType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        if (this.ProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionStatus\n" ;
            } else {
                s += ind + "protectionStatus\n" ;
            }
        }
        //      C# -> System.Int64? Bytes
        // GraphQL -> bytes: Long (scalar)
        if (this.Bytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytes\n" ;
            } else {
                s += ind + "bytes\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ObjectState? ObjectState
        // GraphQL -> objectState: ObjectState! (enum)
        if (ec.Includes("objectState",true))
        {
            if(this.ObjectState == null) {

                this.ObjectState = new ObjectState();

            } else {


            }
        }
        else if (this.ObjectState != null && ec.Excludes("objectState",true))
        {
            this.ObjectState = null;
        }
        //      C# -> O365SnappableType? ObjectType
        // GraphQL -> objectType: O365SnappableType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new O365SnappableType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        if (ec.Includes("protectionStatus",true))
        {
            if(this.ProtectionStatus == null) {

                this.ProtectionStatus = new ProtectionStatusEnum();

            } else {


            }
        }
        else if (this.ProtectionStatus != null && ec.Excludes("protectionStatus",true))
        {
            this.ProtectionStatus = null;
        }
        //      C# -> System.Int64? Bytes
        // GraphQL -> bytes: Long (scalar)
        if (ec.Includes("bytes",true))
        {
            if(this.Bytes == null) {

                this.Bytes = new System.Int64();

            } else {


            }
        }
        else if (this.Bytes != null && ec.Excludes("bytes",true))
        {
            this.Bytes = null;
        }
    }


    #endregion

    } // class SegregatedObjectTypeConsumptionEntry
    
    #endregion

    public static class ListSegregatedObjectTypeConsumptionEntryExtensions
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
            this List<SegregatedObjectTypeConsumptionEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SegregatedObjectTypeConsumptionEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SegregatedObjectTypeConsumptionEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SegregatedObjectTypeConsumptionEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SegregatedObjectTypeConsumptionEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types