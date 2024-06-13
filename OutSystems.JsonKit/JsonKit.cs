using System.Security.Cryptography;
using System.Text;
using System;
using Newtonsoft.Json.Linq;

namespace OutSystems.JsonKit
{
	public class JsonKit : IJsonKit
	{
		public void Beautify(string jsonIn, out string jsonOut)
		{
			//Console.WriteLine(JToken.Parse(t).ToString(Newtonsoft.Json.Formatting.Indented));
			jsonOut = string.Empty;

			JToken jt = JToken.Parse(jsonIn);
			jsonOut = jt.ToString(Newtonsoft.Json.Formatting.Indented);
		}
	}
}