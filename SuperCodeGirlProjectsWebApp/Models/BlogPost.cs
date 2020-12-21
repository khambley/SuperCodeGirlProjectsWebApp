using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCodeGirlProjectsWebApp.Models
{
	public class BlogPost
	{
		public int BlogPostId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string BodyText { get; set; }
		public int MainCategoryId { get; set; }
		public virtual MainCategory MainCategory { get; set; }
		public int SubCategoryId { get; set; }
		public virtual SubCategory SubCategory { get; set; }
		public string Author { get; set; }
		public DateTime CreatedDate { get; set; }
		public string ImageFileName { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }

	}
}
