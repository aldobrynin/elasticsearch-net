// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class AllField
	{
		[JsonPropertyName("analyzer")]
		public string Analyzer { get; set; }

		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }

		[JsonPropertyName("omit_norms")]
		public bool OmitNorms { get; set; }

		[JsonPropertyName("search_analyzer")]
		public string SearchAnalyzer { get; set; }

		[JsonPropertyName("similarity")]
		public string Similarity { get; set; }

		[JsonPropertyName("store")]
		public bool Store { get; set; }

		[JsonPropertyName("store_term_vector_offsets")]
		public bool StoreTermVectorOffsets { get; set; }

		[JsonPropertyName("store_term_vector_payloads")]
		public bool StoreTermVectorPayloads { get; set; }

		[JsonPropertyName("store_term_vector_positions")]
		public bool StoreTermVectorPositions { get; set; }

		[JsonPropertyName("store_term_vectors")]
		public bool StoreTermVectors { get; set; }
	}

	public partial class BinaryProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "binary";
	}

	public partial class BooleanProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? Fielddata { get; set; }

		[JsonPropertyName("null_value")]
		public bool? NullValue { get; set; }

		[JsonPropertyName("type")]
		public string Type => "boolean";
	}

	public partial class CompletionProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonPropertyName("contexts")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Mapping.SuggestContext>? Contexts { get; set; }

		[JsonPropertyName("max_input_length")]
		public int? MaxInputLength { get; set; }

		[JsonPropertyName("preserve_position_increments")]
		public bool? PreservePositionIncrements { get; set; }

		[JsonPropertyName("preserve_separators")]
		public bool? PreserveSeparators { get; set; }

		[JsonPropertyName("search_analyzer")]
		public string? SearchAnalyzer { get; set; }

		[JsonPropertyName("type")]
		public string Type => "completion";
	}

	public partial class ConstantKeywordProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "constant_keyword";
		[JsonPropertyName("value")]
		public object? Value { get; set; }
	}

	public partial class CorePropertyBase : Mapping.PropertyBase
	{
		[JsonPropertyName("copy_to")]
		public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }

		[JsonPropertyName("similarity")]
		public string? Similarity { get; set; }

		[JsonPropertyName("store")]
		public bool? Store { get; set; }
	}

	public partial class DateNanosProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("null_value")]
		public Elastic.Clients.Elasticsearch.DateString? NullValue { get; set; }

		[JsonPropertyName("precision_step")]
		public int? PrecisionStep { get; set; }

		[JsonPropertyName("type")]
		public string Type => "date_nanos";
	}

	public partial class DateProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? Fielddata { get; set; }

		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("null_value")]
		public Elastic.Clients.Elasticsearch.DateString? NullValue { get; set; }

		[JsonPropertyName("precision_step")]
		public int? PrecisionStep { get; set; }

		[JsonPropertyName("type")]
		public string Type => "date";
	}

	public partial class DateRangeProperty : Mapping.RangePropertyBase
	{
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonPropertyName("type")]
		public string Type => "date_range";
	}

	public partial class DocValuesPropertyBase : Mapping.CorePropertyBase
	{
		[JsonPropertyName("doc_values")]
		public bool? DocValues { get; set; }
	}

	public partial class DoubleRangeProperty : Mapping.RangePropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "double_range";
	}

	public partial class DynamicTemplate
	{
		[JsonPropertyName("mapping")]
		public Elastic.Clients.Elasticsearch.Mapping.PropertyBase? Mapping { get; set; }

		[JsonPropertyName("match")]
		public string? Match { get; set; }

		[JsonPropertyName("match_mapping_type")]
		public string? MatchMappingType { get; set; }

		[JsonPropertyName("match_pattern")]
		public Elastic.Clients.Elasticsearch.Mapping.MatchType? MatchPattern { get; set; }

		[JsonPropertyName("path_match")]
		public string? PathMatch { get; set; }

		[JsonPropertyName("path_unmatch")]
		public string? PathUnmatch { get; set; }

		[JsonPropertyName("unmatch")]
		public string? Unmatch { get; set; }
	}

	public partial class FieldAliasProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("path")]
		public Elastic.Clients.Elasticsearch.Field? Path { get; set; }

		[JsonPropertyName("type")]
		public string Type => "alias";
	}

	public partial class FieldMapping
	{
	}

	public partial class FieldNamesField
	{
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }
	}

	public partial class FlattenedProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("depth_limit")]
		public int? DepthLimit { get; set; }

		[JsonPropertyName("doc_values")]
		public bool? DocValues { get; set; }

		[JsonPropertyName("eager_global_ordinals")]
		public bool? EagerGlobalOrdinals { get; set; }

		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

		[JsonPropertyName("null_value")]
		public string? NullValue { get; set; }

		[JsonPropertyName("similarity")]
		public string? Similarity { get; set; }

		[JsonPropertyName("split_queries_on_whitespace")]
		public bool? SplitQueriesOnWhitespace { get; set; }

		[JsonPropertyName("type")]
		public string Type => "flattened";
	}

	public partial class FloatRangeProperty : Mapping.RangePropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "float_range";
	}

	public partial class GenericProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("analyzer")]
		public string Analyzer { get; set; }

		[JsonPropertyName("boost")]
		public double Boost { get; set; }

		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.IndexManagement.StringFielddata Fielddata { get; set; }

		[JsonPropertyName("ignore_malformed")]
		public bool IgnoreMalformed { get; set; }

		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions IndexOptions { get; set; }

		[JsonPropertyName("norms")]
		public bool Norms { get; set; }

		[JsonPropertyName("null_value")]
		public string NullValue { get; set; }

		[JsonPropertyName("position_increment_gap")]
		public int PositionIncrementGap { get; set; }

		[JsonPropertyName("search_analyzer")]
		public string SearchAnalyzer { get; set; }

		[JsonPropertyName("term_vector")]
		public Elastic.Clients.Elasticsearch.Mapping.TermVectorOption TermVector { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }
	}

	public partial class GeoPointProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("ignore_z_value")]
		public bool? IgnoreZValue { get; set; }

		[JsonPropertyName("null_value")]
		public Elastic.Clients.Elasticsearch.QueryDsl.GeoLocation? NullValue { get; set; }

		[JsonPropertyName("type")]
		public string Type => "geo_point";
	}

	public partial class GeoShapeProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("coerce")]
		public bool? Coerce { get; set; }

		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("ignore_z_value")]
		public bool? IgnoreZValue { get; set; }

		[JsonPropertyName("orientation")]
		public Elastic.Clients.Elasticsearch.Mapping.GeoOrientation? Orientation { get; set; }

		[JsonPropertyName("strategy")]
		public Elastic.Clients.Elasticsearch.Mapping.GeoStrategy? Strategy { get; set; }

		[JsonPropertyName("type")]
		public string Type => "geo_shape";
	}

	public partial class HistogramProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("type")]
		public string Type => "histogram";
	}

	public partial class IndexField
	{
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }
	}

	public partial class IntegerRangeProperty : Mapping.RangePropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "integer_range";
	}

	public partial class IpProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("null_value")]
		public string? NullValue { get; set; }

		[JsonPropertyName("type")]
		public string Type => "ip";
	}

	public partial class IpRangeProperty : Mapping.RangePropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "ip_range";
	}

	public partial class JoinProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("relations")]
		public Dictionary<Elastic.Clients.Elasticsearch.RelationName, Union<Elastic.Clients.Elasticsearch.RelationName, IEnumerable<Elastic.Clients.Elasticsearch.RelationName>>>? Relations { get; set; }

		[JsonPropertyName("type")]
		public string Type => "join";
	}

	public partial class KeywordProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("eager_global_ordinals")]
		public bool? EagerGlobalOrdinals { get; set; }

		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

		[JsonPropertyName("normalizer")]
		public string? Normalizer { get; set; }

		[JsonPropertyName("norms")]
		public bool? Norms { get; set; }

		[JsonPropertyName("null_value")]
		public string? NullValue { get; set; }

		[JsonPropertyName("split_queries_on_whitespace")]
		public bool? SplitQueriesOnWhitespace { get; set; }

		[JsonPropertyName("type")]
		public string Type => "keyword";
	}

	public partial class LongRangeProperty : Mapping.RangePropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "long_range";
	}

	public partial class Murmur3HashProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "murmur3";
	}

	public partial class NestedProperty : Mapping.CorePropertyBase
	{
		[JsonPropertyName("enabled")]
		public bool? Enabled { get; set; }

		[JsonPropertyName("include_in_parent")]
		public bool? IncludeInParent { get; set; }

		[JsonPropertyName("include_in_root")]
		public bool? IncludeInRoot { get; set; }

		[JsonPropertyName("type")]
		public string Type => "nested";
	}

	public partial class NumberProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("coerce")]
		public bool? Coerce { get; set; }

		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? Fielddata { get; set; }

		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("null_value")]
		public double? NullValue { get; set; }

		[JsonPropertyName("scaling_factor")]
		public double? ScalingFactor { get; set; }

		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.Mapping.NumberType Type { get; set; }
	}

	public partial class ObjectProperty : Mapping.CorePropertyBase
	{
		[JsonPropertyName("enabled")]
		public bool? Enabled { get; set; }

		[JsonPropertyName("type")]
		public string Type => "object";
	}

	public partial class PercolatorProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "percolator";
	}

	public partial class PointProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("ignore_z_value")]
		public bool? IgnoreZValue { get; set; }

		[JsonPropertyName("null_value")]
		public string? NullValue { get; set; }

		[JsonPropertyName("type")]
		public string Type => "point";
	}

	public partial class PropertyBase
	{
		[JsonPropertyName("dynamic")]
		public Union<bool, Elastic.Clients.Elasticsearch.Mapping.DynamicMapping>? Dynamic { get; set; }

		[JsonPropertyName("fields")]
		public Dictionary<Elastic.Clients.Elasticsearch.PropertyName, Elastic.Clients.Elasticsearch.Mapping.PropertyBase>? Fields { get; set; }

		[JsonPropertyName("ignore_above")]
		public int? IgnoreAbove { get; set; }

		[JsonPropertyName("index")]
		public bool? Index { get; set; }

		[JsonPropertyName("local_metadata")]
		public Elastic.Clients.Elasticsearch.Metadata? LocalMetadata { get; set; }

		[JsonPropertyName("meta")]
		public Dictionary<string, string>? Meta { get; set; }

		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.PropertyName? Name { get; set; }

		[JsonPropertyName("properties")]
		public Dictionary<Elastic.Clients.Elasticsearch.PropertyName, Elastic.Clients.Elasticsearch.Mapping.PropertyBase>? Properties { get; set; }
	}

	public partial class RangePropertyBase : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("coerce")]
		public bool? Coerce { get; set; }
	}

	public partial class RankFeatureProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("positive_score_impact")]
		public bool? PositiveScoreImpact { get; set; }

		[JsonPropertyName("type")]
		public string Type => "rank_feature";
	}

	public partial class RankFeaturesProperty : Mapping.PropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "rank_features";
	}

	public partial class RoutingField
	{
		[JsonPropertyName("required")]
		public bool Required { get; set; }
	}

	public partial class RuntimeField
	{
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldType Type { get; set; }
	}

	public partial class SearchAsYouTypeProperty : Mapping.CorePropertyBase
	{
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

		[JsonPropertyName("max_shingle_size")]
		public int? MaxShingleSize { get; set; }

		[JsonPropertyName("norms")]
		public bool? Norms { get; set; }

		[JsonPropertyName("search_analyzer")]
		public string? SearchAnalyzer { get; set; }

		[JsonPropertyName("search_quote_analyzer")]
		public string? SearchQuoteAnalyzer { get; set; }

		[JsonPropertyName("term_vector")]
		public Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVector { get; set; }

		[JsonPropertyName("type")]
		public string Type => "search_as_you_type";
	}

	public partial class ShapeProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("coerce")]
		public bool? Coerce { get; set; }

		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; set; }

		[JsonPropertyName("ignore_z_value")]
		public bool? IgnoreZValue { get; set; }

		[JsonPropertyName("orientation")]
		public Elastic.Clients.Elasticsearch.Mapping.ShapeOrientation? Orientation { get; set; }

		[JsonPropertyName("type")]
		public string Type => "shape";
	}

	public partial class SizeField
	{
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }
	}

	public partial class SourceField
	{
		[JsonPropertyName("compress")]
		public bool? Compress { get; set; }

		[JsonPropertyName("compress_threshold")]
		public string? CompressThreshold { get; set; }

		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }

		[JsonPropertyName("excludes")]
		public IEnumerable<string>? Excludes { get; set; }

		[JsonPropertyName("includes")]
		public IEnumerable<string>? Includes { get; set; }
	}

	public partial class SuggestContext
	{
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("path")]
		public Elastic.Clients.Elasticsearch.Field? Path
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("precision")]
		public int? Precision
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TextIndexPrefixes
	{
		[JsonPropertyName("max_chars")]
		public int MaxChars
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("min_chars")]
		public int MinChars
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TextProperty : Mapping.CorePropertyBase
	{
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("eager_global_ordinals")]
		public bool? EagerGlobalOrdinals { get; set; }

		[JsonPropertyName("fielddata")]
		public bool? Fielddata { get; set; }

		[JsonPropertyName("fielddata_frequency_filter")]
		public Elastic.Clients.Elasticsearch.IndexManagement.FielddataFrequencyFilter? FielddataFrequencyFilter { get; set; }

		[JsonPropertyName("index_options")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexOptions? IndexOptions { get; set; }

		[JsonPropertyName("index_phrases")]
		public bool? IndexPhrases { get; set; }

		[JsonPropertyName("index_prefixes")]
		public Elastic.Clients.Elasticsearch.Mapping.TextIndexPrefixes? IndexPrefixes { get; set; }

		[JsonPropertyName("norms")]
		public bool? Norms { get; set; }

		[JsonPropertyName("position_increment_gap")]
		public int? PositionIncrementGap { get; set; }

		[JsonPropertyName("search_analyzer")]
		public string? SearchAnalyzer { get; set; }

		[JsonPropertyName("search_quote_analyzer")]
		public string? SearchQuoteAnalyzer { get; set; }

		[JsonPropertyName("term_vector")]
		public Elastic.Clients.Elasticsearch.Mapping.TermVectorOption? TermVector { get; set; }

		[JsonPropertyName("type")]
		public string Type => "text";
	}

	public partial class TokenCountProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonPropertyName("boost")]
		public double? Boost { get; set; }

		[JsonPropertyName("enable_position_increments")]
		public bool? EnablePositionIncrements { get; set; }

		[JsonPropertyName("null_value")]
		public double? NullValue { get; set; }

		[JsonPropertyName("type")]
		public string Type => "token_count";
	}

	public partial class TypeMapping
	{
		[JsonPropertyName("all_field")]
		public Elastic.Clients.Elasticsearch.Mapping.AllField? AllField { get; set; }

		[JsonPropertyName("date_detection")]
		public bool? DateDetection { get; set; }

		[JsonPropertyName("dynamic")]
		public Union<bool, Elastic.Clients.Elasticsearch.Mapping.DynamicMapping>? Dynamic { get; set; }

		[JsonPropertyName("dynamic_date_formats")]
		public IEnumerable<string>? DynamicDateFormats { get; set; }

		[JsonPropertyName("dynamic_templates")]
		public Union<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>, IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>>>? DynamicTemplates { get; set; }

		[JsonPropertyName("_field_names")]
		public Elastic.Clients.Elasticsearch.Mapping.FieldNamesField? FieldNames { get; set; }

		[JsonPropertyName("index_field")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexField? IndexField { get; set; }

		[JsonPropertyName("_meta")]
		public Elastic.Clients.Elasticsearch.Metadata? Meta { get; set; }

		[JsonPropertyName("numeric_detection")]
		public bool? NumericDetection { get; set; }

		[JsonPropertyName("properties")]
		public Dictionary<Elastic.Clients.Elasticsearch.PropertyName, Elastic.Clients.Elasticsearch.Mapping.PropertyBase>? Properties { get; set; }

		[JsonPropertyName("_routing")]
		public Elastic.Clients.Elasticsearch.Mapping.RoutingField? Routing { get; set; }

		[JsonPropertyName("runtime")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? Runtime { get; set; }

		[JsonPropertyName("_size")]
		public Elastic.Clients.Elasticsearch.Mapping.SizeField? Size { get; set; }

		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.Mapping.SourceField? Source { get; set; }
	}

	public partial class VersionProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "version";
	}

	public partial class WildcardProperty : Mapping.DocValuesPropertyBase
	{
		[JsonPropertyName("type")]
		public string Type => "wildcard";
	}
}