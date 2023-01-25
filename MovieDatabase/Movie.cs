using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDatabase;

namespace MovieDatabase
{
	public class Movie
	{
		public string Title { get; set; }
		public string Category { get; set; }

		public Movie(string _title, string _category)
		{
			Title = _title;
			Category = _category;
		}

		public string GetDetail()
		{
			return String.Format("{0,-25}", $"{Title}");
		}

	}
}

