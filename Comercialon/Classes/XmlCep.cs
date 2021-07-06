using System.Xml.Serialization;

namespace Comercialon.Classes
{
	[XmlRoot(ElementName = "xmlcep")]
	public class Xmlcep
	{

		[XmlElement(ElementName = "cep")]
		public string Cep { get; set; }

		[XmlElement(ElementName = "logradouro")]
		public string Logradouro { get; set; }

		[XmlElement(ElementName = "complemento")]
		public object Complemento { get; set; }

		[XmlElement(ElementName = "bairro")]
		public string Bairro { get; set; }

		[XmlElement(ElementName = "localidade")]
		public string Localidade { get; set; }

		[XmlElement(ElementName = "uf")]
		public string Uf { get; set; }

		[XmlElement(ElementName = "ibge")]
		public int Ibge { get; set; }

		[XmlElement(ElementName = "gia")]
		public int Gia { get; set; }

		[XmlElement(ElementName = "ddd")]
		public int Ddd { get; set; }

		[XmlElement(ElementName = "siafi")]
		public int Siafi { get; set; }
	}


}