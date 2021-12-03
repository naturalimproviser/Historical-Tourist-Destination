﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("nhits")]
        public long Nhits { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        [JsonProperty("records")]
        public Record[] Records { get; set; }

        [JsonProperty("facet_groups")]
        public FacetGroup[] FacetGroups { get; set; }
    }

    public partial class FacetGroup
    {
        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Facet
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("state")]
        public State State { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Parameters
    {
        [JsonProperty("dataset")]
        public Dataset Dataset { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("rows")]
        public long Rows { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("facet")]
        public string[] Facet { get; set; }
    }

    public partial class Record
    {
        [JsonProperty("datasetid")]
        public Dataset Datasetid { get; set; }

        [JsonProperty("recordid")]
        public string Recordid { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("record_timestamp")]
        public DateTimeOffset RecordTimestamp { get; set; }
    }

    public partial class Fields
    {
        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("short_description_en")]
        public string ShortDescriptionEn { get; set; }

        [JsonProperty("continent_fr")]
        public ContinentFr ContinentFr { get; set; }

        [JsonProperty("name_fr")]
        public string NameFr { get; set; }

        [JsonProperty("continent_en")]
        public ContinentEn ContinentEn { get; set; }

        [JsonProperty("justification_fr", NullValueHandling = NullValueHandling.Ignore)]
        public string JustificationFr { get; set; }

        [JsonProperty("country_en")]
        public string CountryEn { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("justification_en", NullValueHandling = NullValueHandling.Ignore)]
        public string JustificationEn { get; set; }

        [JsonProperty("short_description_fr")]
        public string ShortDescriptionFr { get; set; }

        [JsonProperty("date_inscribed")]
        public DateTimeOffset DateInscribed { get; set; }

        [JsonProperty("country_fr")]
        public string CountryFr { get; set; }

        [JsonProperty("area_hectares", NullValueHandling = NullValueHandling.Ignore)]
        public double? AreaHectares { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("name_en")]
        public string NameEn { get; set; }

        [JsonProperty("geographical_coordinates")]
        public double[] GeographicalCoordinates { get; set; }

        [JsonProperty("danger_list", NullValueHandling = NullValueHandling.Ignore)]
        public string DangerList { get; set; }
    }

    public partial class Geometry
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public enum State { Displayed };

    public enum Dataset { WorldHeritageUnescoList };

    public enum Category { Cultural, Mixed, Natural };

    public enum ContinentEn { Africa, ArabStates, AsiaAndThePacific, EuropeAndNorthAmerica, LatinAmericaAndTheCaribbean };

    public enum ContinentFr { Afrique, AmériqueLatineEtCaraïbes, AsieEtPacifique, EuropeEtAmériqueDuNord, ÉtatsArabes };

    public enum TypeEnum { Point };

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StateConverter.Singleton,
                DatasetConverter.Singleton,
                CategoryConverter.Singleton,
                ContinentEnConverter.Singleton,
                ContinentFrConverter.Singleton,
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class StateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(State) || t == typeof(State?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "displayed")
            {
                return State.Displayed;
            }
            throw new Exception("Cannot unmarshal type State");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (State)untypedValue;
            if (value == State.Displayed)
            {
                serializer.Serialize(writer, "displayed");
                return;
            }
            throw new Exception("Cannot marshal type State");
        }

        public static readonly StateConverter Singleton = new StateConverter();
    }

    internal class DatasetConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dataset) || t == typeof(Dataset?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "world-heritage-unesco-list")
            {
                return Dataset.WorldHeritageUnescoList;
            }
            throw new Exception("Cannot unmarshal type Dataset");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Dataset)untypedValue;
            if (value == Dataset.WorldHeritageUnescoList)
            {
                serializer.Serialize(writer, "world-heritage-unesco-list");
                return;
            }
            throw new Exception("Cannot marshal type Dataset");
        }

        public static readonly DatasetConverter Singleton = new DatasetConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Cultural":
                    return Category.Cultural;
                case "Mixed":
                    return Category.Mixed;
                case "Natural":
                    return Category.Natural;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.Cultural:
                    serializer.Serialize(writer, "Cultural");
                    return;
                case Category.Mixed:
                    serializer.Serialize(writer, "Mixed");
                    return;
                case Category.Natural:
                    serializer.Serialize(writer, "Natural");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }

    internal class ContinentEnConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ContinentEn) || t == typeof(ContinentEn?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Africa":
                    return ContinentEn.Africa;
                case "Arab States":
                    return ContinentEn.ArabStates;
                case "Asia and the Pacific":
                    return ContinentEn.AsiaAndThePacific;
                case "Europe and North America":
                    return ContinentEn.EuropeAndNorthAmerica;
                case "Latin America and the Caribbean":
                    return ContinentEn.LatinAmericaAndTheCaribbean;
            }
            throw new Exception("Cannot unmarshal type ContinentEn");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ContinentEn)untypedValue;
            switch (value)
            {
                case ContinentEn.Africa:
                    serializer.Serialize(writer, "Africa");
                    return;
                case ContinentEn.ArabStates:
                    serializer.Serialize(writer, "Arab States");
                    return;
                case ContinentEn.AsiaAndThePacific:
                    serializer.Serialize(writer, "Asia and the Pacific");
                    return;
                case ContinentEn.EuropeAndNorthAmerica:
                    serializer.Serialize(writer, "Europe and North America");
                    return;
                case ContinentEn.LatinAmericaAndTheCaribbean:
                    serializer.Serialize(writer, "Latin America and the Caribbean");
                    return;
            }
            throw new Exception("Cannot marshal type ContinentEn");
        }

        public static readonly ContinentEnConverter Singleton = new ContinentEnConverter();
    }

    internal class ContinentFrConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ContinentFr) || t == typeof(ContinentFr?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Afrique":
                    return ContinentFr.Afrique;
                case "Amérique latine et Caraïbes":
                    return ContinentFr.AmériqueLatineEtCaraïbes;
                case "Asie et pacifique":
                    return ContinentFr.AsieEtPacifique;
                case "Europe et Amérique du nord":
                    return ContinentFr.EuropeEtAmériqueDuNord;
                case "États arabes":
                    return ContinentFr.ÉtatsArabes;
            }
            throw new Exception("Cannot unmarshal type ContinentFr");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ContinentFr)untypedValue;
            switch (value)
            {
                case ContinentFr.Afrique:
                    serializer.Serialize(writer, "Afrique");
                    return;
                case ContinentFr.AmériqueLatineEtCaraïbes:
                    serializer.Serialize(writer, "Amérique latine et Caraïbes");
                    return;
                case ContinentFr.AsieEtPacifique:
                    serializer.Serialize(writer, "Asie et pacifique");
                    return;
                case ContinentFr.EuropeEtAmériqueDuNord:
                    serializer.Serialize(writer, "Europe et Amérique du nord");
                    return;
                case ContinentFr.ÉtatsArabes:
                    serializer.Serialize(writer, "États arabes");
                    return;
            }
            throw new Exception("Cannot marshal type ContinentFr");
        }

        public static readonly ContinentFrConverter Singleton = new ContinentFrConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Point")
            {
                return TypeEnum.Point;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Point)
            {
                serializer.Serialize(writer, "Point");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
