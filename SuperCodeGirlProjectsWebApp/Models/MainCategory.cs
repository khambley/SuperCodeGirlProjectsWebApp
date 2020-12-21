using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCodeGirlProjectsWebApp.Models
{
	public class MainCategory
	{
		public int MainCategoryId { get; set; }
		public string MainCategoryName { get; set; }
		[NotMapped]
		public int BlogPostId { get; set; }
		[NotMapped]
		public int SubCategoryId { get; set; }
		public List<SubCategory> SubCategories { get; set; }


	}
}
