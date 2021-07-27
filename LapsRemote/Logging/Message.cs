﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapsRemote.Logging
{
	public struct Message
	{
		public string LogMessage;
		public LogFrom LoggingFrom;
		public Level LogLevel;
		public DateTime LogTime;
	}
}
