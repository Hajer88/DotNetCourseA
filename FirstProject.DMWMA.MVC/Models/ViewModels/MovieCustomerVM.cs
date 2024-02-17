using System;
namespace FirstProject.DMWMA.MVC.Models.ViewModels
{
	public class MovieCustomerVM
	{
		public MovieCustomerVM()
		{	
		}
		public Movie movie { get; set; }
		public List<Customer> customers{ get; set; }
	}
}

