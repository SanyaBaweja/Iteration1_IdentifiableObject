using System;
namespace Iteration1_IdentifiableObject
{
	public class Game_Object:Identifiable_object
	{
		private string _description;
		private string _name;
		public Game_Object(string[] ids, string name, string desc): base(ids)
		{
			_name = name;
			_description = desc;
		}
		public string Name
		{
			get
			{
				return _name;
			}
		}
		public string ShortDescription
		{
			get
			{
				return _name + " " + FirstId;
			}
		}
		public virtual string FullDescription
		{
			get
			{
				return _description;
			}
		}
	}
}

