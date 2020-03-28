using System.Collections.Generic;
using System.Xml.Serialization;

namespace Project_Cars_Mod_Configurator.data.models

{
	[XmlRoot(ElementName = "Modifications")]
	public class Modifications
	{
		[XmlElement(ElementName = "Type")]
		public List<Type> Types { get; set; }
		[XmlAttribute(AttributeName = "vehicleName")]
		public string VehicleName { get; set; }
	}


	[XmlRoot(ElementName = "Type")]
	public class Type
	{
		[XmlElement(ElementName = "Part")]
		public List<Part> Parts { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName = "Part")]
	public class Part
	{
		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "ImagePath")]
		public string ImagePath { get; set; }
		[XmlElement(ElementName = "Items")]
		public Items Items { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}

	[XmlRoot(ElementName = "Items")]
	public class Items
	{
		[XmlElement(ElementName = "Path")]
		public List<Path> Paths { get; set; }
	}

	[XmlRoot(ElementName = "Path")]
	public class Path
	{
		[XmlAttribute(AttributeName = "target")]
		public string Target { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
