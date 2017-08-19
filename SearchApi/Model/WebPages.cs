using System;
using System.Collections.Generic;

namespace SearchApi
{
	public class WebPages
	{
		public string webSearchUrl { get; set; }
		public int totalEstimatedMatches { get; set; }
		public IList<Value> value { get; set; }
	}
}
