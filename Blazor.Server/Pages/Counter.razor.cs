using Blazor.Server.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Pages
{
	public partial class Counter
	{
		private int currentCount = 0;

		private void IncrementCount()
		{
			currentCount++;
		}
	}
}
