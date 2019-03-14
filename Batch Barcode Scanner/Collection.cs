﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ScanSKU;
//
//    var collectionObject = CollectionObject.FromJson(jsonString);

namespace Batch_Barcode_Scanner
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class Collection
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("gps")]
        public Gps Gps { get; set; }

        [JsonProperty("batch")]
        public string batchnumber { get; set; }

        [JsonProperty("signatureimage")]
        public string SignatureImage { get; set; }

        [JsonProperty("signaturetext")]
        public string SignatureText { get; set; }

        [JsonProperty("scans")]
        public List<Scan> Scans { get; set; }


    }

    public partial class Gps
    {
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
    }

    public partial class Scan
    {
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("gps")]
        public Gps Gps { get; set; }
    }

    public partial class Collection
    {
        public static Collection FromJson(string json) => JsonConvert.DeserializeObject<Collection>(json, Batch_Barcode_Scanner.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Collection self) => JsonConvert.SerializeObject(self, Batch_Barcode_Scanner.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
