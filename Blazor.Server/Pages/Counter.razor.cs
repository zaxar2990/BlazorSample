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
		[Inject] public ApplicationDbContext _db { get; set; }

		private int currentCount = 0;

		private void IncrementCount()
		{
			currentCount++;
		}

		

		protected override async Task OnInitializedAsync()
		{
			//верификация почты
			var v = await _db.Users.FirstOrDefaultAsync(u => u.Email == "2@2.ru");
			v.EmailConfirmed = true;
			_db.Update(v);
			await _db.SaveChangesAsync();
			var vv = await _db.Users.ToArrayAsync();



			await base.OnInitializedAsync();
		}
	}
}
