using OutSystems.ExternalLibraries.SDK;
using System.Security.Cryptography;

namespace OutSystems.JsonKit
{
	/// <summary>
	/// 
	/// </summary>
	[OSInterface(Description = "JSON library in OutSystems Developer Cloud (ODC) apps.", IconResourceName = "OutSystems.JsonKit.resources.jsonkit.png")]
	public interface IJsonKit
	{

		void Beautify(string jsonIn, out string jsonOut);
	}
}