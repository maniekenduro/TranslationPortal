using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class LogModel
	{
		public int ID { get; set; }
		public string API { get; set; }
		public string OriginalText { get; set; }
		public string NewText { get; set; }
		public DateTime SendTime { get; set; }


		public LogModel(int id, string api, string originalText, string newText, DateTime sendTime)
		{
			ID = id;
			API = api;
			OriginalText = originalText;
			NewText = newText;
			SendTime = sendTime;
		}
	}
}
