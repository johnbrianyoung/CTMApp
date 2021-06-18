using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTMApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FizzBuzzController : ControllerBase
	{
		private readonly ILogger<FizzBuzzController> _logger;

		public FizzBuzzController(ILogger<FizzBuzzController> logger)
		{
			_logger = logger;
		}

		[HttpGet("{sizeFizzBuzzList}")]
		public string Get(int sizeFizzBuzzList)
		{
			//TODO: Add error checking code and create app messages for out of bounds sizes (less the 1 or greater than 100)
			// creat results list for FizzBuzz results
			List<string> lstResults = new List<string>(); // resultArr =  "";

			for (int i = 1; i <= sizeFizzBuzzList; i++)
			{
				if ((i % 3 == 0) && (i % 5 == 0)) //divisible by 3 and 5 with no remainer
				{
					lstResults.Add("FizzBuzz");
				}
				else if (i % 3 == 0) //divisible by 3 with no remainer
				{
					lstResults.Add("Fizz");
				}
				else if (i % 5 == 0) //divisible by 5 with no remainer
				{
					lstResults.Add("Buzz");
				}
				else //produces a remainder when divided by 3 or 5, just add item count to results
				{
					lstResults.Add(i.ToString());
				}
			}
			
			//add leading and trailing square brackets and surround each item with double quotes
			return "[\"" + String.Join("\",\"", lstResults) + "\"]";
		}
	}
}
