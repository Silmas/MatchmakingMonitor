﻿using MatchMakingMonitor.config.Reflection;
using Newtonsoft.Json;

namespace MatchMakingMonitor.config
{
	public class LimitValue
	{
		[JsonProperty("value"), UiSetting]
		public double Value { get; set; }
	}
}
