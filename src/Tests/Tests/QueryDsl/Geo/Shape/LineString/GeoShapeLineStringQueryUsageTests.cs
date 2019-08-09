﻿using System.Collections.Generic;
using Nest;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework.Integration;
using static Nest.Infer;

namespace Tests.QueryDsl.Geo.Shape.LineString
{
	public class GeoShapeLineStringQueryUsageTests : GeoShapeQueryUsageTestsBase
	{
		public GeoShapeLineStringQueryUsageTests(ReadOnlyCluster i, EndpointUsage usage) : base(i, usage) { }

		protected override ConditionlessWhen ConditionlessWhen =>
			new ConditionlessWhen<IGeoShapeLineStringQuery>(a => a.GeoShape as IGeoShapeLineStringQuery)
			{
				q => q.Field = null,
				q => q.Shape = null,
				q => q.Shape.Coordinates = null,
			};

		protected override QueryContainer QueryInitializer => new GeoShapeLineStringQuery
		{
			Name = "named_query",
			Boost = 1.1,
			Field = Field<Project>(p => p.LocationShape),
			Shape = new LineStringGeoShape(LineStringCoordinates),
			Relation = GeoShapeRelation.Intersects,
		};

		protected override object ShapeJson => new
		{
			type = "linestring",
			coordinates = LineStringCoordinates
		};

		protected override QueryContainer QueryFluent(QueryContainerDescriptor<Project> q) => q
			.GeoShapeLineString(c => c
				.Name("named_query")
				.Boost(1.1)
				.Field(p => p.LocationShape)
				.Coordinates(LineStringCoordinates)
				.Relation(GeoShapeRelation.Intersects)
			);
	}
}
