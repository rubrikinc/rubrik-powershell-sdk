// SlaIdToObjectCount.cs
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
    #region SlaIdToObjectCount
    public class SlaIdToObjectCount: BaseType
    {
        #region members

        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        [JsonProperty("objectCount")]
        public System.Int32? ObjectCount { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SLAIdToObjectCount";
    }

    public SlaIdToObjectCount Set(
        System.Int32? ObjectCount = null,
        System.String? SlaId = null
    ) 
    {
        if ( ObjectCount != null ) {
            this.ObjectCount = ObjectCount;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
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
        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        if (this.ObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectCount\n" ;
            } else {
                s += ind + "objectCount\n" ;
            }
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (this.SlaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaId\n" ;
            } else {
                s += ind + "slaId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        if (ec.Includes("objectCount",true))
        {
            if(this.ObjectCount == null) {

                this.ObjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ObjectCount != null && ec.Excludes("objectCount",true))
        {
            this.ObjectCount = null;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (ec.Includes("slaId",true))
        {
            if(this.SlaId == null) {

                this.SlaId = "FETCH";

            } else {


            }
        }
        else if (this.SlaId != null && ec.Excludes("slaId",true))
        {
            this.SlaId = null;
        }
    }


    #endregion

    } // class SlaIdToObjectCount
    
    #endregion

    public static class ListSlaIdToObjectCountExtensions
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
            this List<SlaIdToObjectCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaIdToObjectCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaIdToObjectCount> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaIdToObjectCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaIdToObjectCount> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types