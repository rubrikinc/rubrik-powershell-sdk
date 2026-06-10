// FusionComputeNicSpec.cs
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
    #region FusionComputeNicSpec
    public class FusionComputeNicSpec: BaseType
    {
        #region members

        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        [JsonProperty("ip")]
        public System.String? Ip { get; set; }

        //      C# -> System.String? IpList
        // GraphQL -> ipList: String! (scalar)
        [JsonProperty("ipList")]
        public System.String? IpList { get; set; }

        //      C# -> List<System.String>? Ips6
        // GraphQL -> ips6: [String!]! (scalar)
        [JsonProperty("ips6")]
        public List<System.String>? Ips6 { get; set; }

        //      C# -> System.String? Mac
        // GraphQL -> mac: String! (scalar)
        [JsonProperty("mac")]
        public System.String? Mac { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PortGroupName
        // GraphQL -> portGroupName: String! (scalar)
        [JsonProperty("portGroupName")]
        public System.String? PortGroupName { get; set; }

        //      C# -> System.String? PortGroupUrn
        // GraphQL -> portGroupUrn: String! (scalar)
        [JsonProperty("portGroupUrn")]
        public System.String? PortGroupUrn { get; set; }

        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        [JsonProperty("sequenceNum")]
        public System.Int32? SequenceNum { get; set; }

        //      C# -> System.String? Uri
        // GraphQL -> uri: String! (scalar)
        [JsonProperty("uri")]
        public System.String? Uri { get; set; }

        //      C# -> System.String? Urn
        // GraphQL -> urn: String! (scalar)
        [JsonProperty("urn")]
        public System.String? Urn { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FusionComputeNicSpec";
    }

    public FusionComputeNicSpec Set(
        System.String? Ip = null,
        System.String? IpList = null,
        List<System.String>? Ips6 = null,
        System.String? Mac = null,
        System.String? Name = null,
        System.String? PortGroupName = null,
        System.String? PortGroupUrn = null,
        System.Int32? SequenceNum = null,
        System.String? Uri = null,
        System.String? Urn = null
    ) 
    {
        if ( Ip != null ) {
            this.Ip = Ip;
        }
        if ( IpList != null ) {
            this.IpList = IpList;
        }
        if ( Ips6 != null ) {
            this.Ips6 = Ips6;
        }
        if ( Mac != null ) {
            this.Mac = Mac;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PortGroupName != null ) {
            this.PortGroupName = PortGroupName;
        }
        if ( PortGroupUrn != null ) {
            this.PortGroupUrn = PortGroupUrn;
        }
        if ( SequenceNum != null ) {
            this.SequenceNum = SequenceNum;
        }
        if ( Uri != null ) {
            this.Uri = Uri;
        }
        if ( Urn != null ) {
            this.Urn = Urn;
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
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (this.Ip != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ip\n" ;
            } else {
                s += ind + "ip\n" ;
            }
        }
        //      C# -> System.String? IpList
        // GraphQL -> ipList: String! (scalar)
        if (this.IpList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipList\n" ;
            } else {
                s += ind + "ipList\n" ;
            }
        }
        //      C# -> List<System.String>? Ips6
        // GraphQL -> ips6: [String!]! (scalar)
        if (this.Ips6 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ips6\n" ;
            } else {
                s += ind + "ips6\n" ;
            }
        }
        //      C# -> System.String? Mac
        // GraphQL -> mac: String! (scalar)
        if (this.Mac != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mac\n" ;
            } else {
                s += ind + "mac\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PortGroupName
        // GraphQL -> portGroupName: String! (scalar)
        if (this.PortGroupName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "portGroupName\n" ;
            } else {
                s += ind + "portGroupName\n" ;
            }
        }
        //      C# -> System.String? PortGroupUrn
        // GraphQL -> portGroupUrn: String! (scalar)
        if (this.PortGroupUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "portGroupUrn\n" ;
            } else {
                s += ind + "portGroupUrn\n" ;
            }
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (this.SequenceNum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sequenceNum\n" ;
            } else {
                s += ind + "sequenceNum\n" ;
            }
        }
        //      C# -> System.String? Uri
        // GraphQL -> uri: String! (scalar)
        if (this.Uri != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uri\n" ;
            } else {
                s += ind + "uri\n" ;
            }
        }
        //      C# -> System.String? Urn
        // GraphQL -> urn: String! (scalar)
        if (this.Urn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "urn\n" ;
            } else {
                s += ind + "urn\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        if (ec.Includes("ip",true))
        {
            if(this.Ip == null) {

                this.Ip = "FETCH";

            } else {


            }
        }
        else if (this.Ip != null && ec.Excludes("ip",true))
        {
            this.Ip = null;
        }
        //      C# -> System.String? IpList
        // GraphQL -> ipList: String! (scalar)
        if (ec.Includes("ipList",true))
        {
            if(this.IpList == null) {

                this.IpList = "FETCH";

            } else {


            }
        }
        else if (this.IpList != null && ec.Excludes("ipList",true))
        {
            this.IpList = null;
        }
        //      C# -> List<System.String>? Ips6
        // GraphQL -> ips6: [String!]! (scalar)
        if (ec.Includes("ips6",true))
        {
            if(this.Ips6 == null) {

                this.Ips6 = new List<System.String>();

            } else {


            }
        }
        else if (this.Ips6 != null && ec.Excludes("ips6",true))
        {
            this.Ips6 = null;
        }
        //      C# -> System.String? Mac
        // GraphQL -> mac: String! (scalar)
        if (ec.Includes("mac",true))
        {
            if(this.Mac == null) {

                this.Mac = "FETCH";

            } else {


            }
        }
        else if (this.Mac != null && ec.Excludes("mac",true))
        {
            this.Mac = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? PortGroupName
        // GraphQL -> portGroupName: String! (scalar)
        if (ec.Includes("portGroupName",true))
        {
            if(this.PortGroupName == null) {

                this.PortGroupName = "FETCH";

            } else {


            }
        }
        else if (this.PortGroupName != null && ec.Excludes("portGroupName",true))
        {
            this.PortGroupName = null;
        }
        //      C# -> System.String? PortGroupUrn
        // GraphQL -> portGroupUrn: String! (scalar)
        if (ec.Includes("portGroupUrn",true))
        {
            if(this.PortGroupUrn == null) {

                this.PortGroupUrn = "FETCH";

            } else {


            }
        }
        else if (this.PortGroupUrn != null && ec.Excludes("portGroupUrn",true))
        {
            this.PortGroupUrn = null;
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (ec.Includes("sequenceNum",true))
        {
            if(this.SequenceNum == null) {

                this.SequenceNum = Int32.MinValue;

            } else {


            }
        }
        else if (this.SequenceNum != null && ec.Excludes("sequenceNum",true))
        {
            this.SequenceNum = null;
        }
        //      C# -> System.String? Uri
        // GraphQL -> uri: String! (scalar)
        if (ec.Includes("uri",true))
        {
            if(this.Uri == null) {

                this.Uri = "FETCH";

            } else {


            }
        }
        else if (this.Uri != null && ec.Excludes("uri",true))
        {
            this.Uri = null;
        }
        //      C# -> System.String? Urn
        // GraphQL -> urn: String! (scalar)
        if (ec.Includes("urn",true))
        {
            if(this.Urn == null) {

                this.Urn = "FETCH";

            } else {


            }
        }
        else if (this.Urn != null && ec.Excludes("urn",true))
        {
            this.Urn = null;
        }
    }


    #endregion

    } // class FusionComputeNicSpec
    
    #endregion

    public static class ListFusionComputeNicSpecExtensions
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
            this List<FusionComputeNicSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FusionComputeNicSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FusionComputeNicSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FusionComputeNicSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FusionComputeNicSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types