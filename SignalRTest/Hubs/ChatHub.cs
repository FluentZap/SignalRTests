using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System;

namespace SignalRTest.Hubs
{
	public class ChatHub : Hub
	{
		public async Task SendMessage(string user, string message)
		{
			await Clients.All.SendAsync("ReceiveMessage", user, message);
			Console.WriteLine(Context.ConnectionId);
			Console.WriteLine(Context.User);
			Console.WriteLine(Context.UserIdentifier);
		}
	}
}
