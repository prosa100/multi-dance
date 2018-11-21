using System;
using System.Collections.Generic;
using System.Text;

namespace MultiDance
{
    class Network
    {
		/// <summary>
		/// handle incoming messages
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="topic"></param>
		/// <param name="body"></param>
		public void OnMessage(object sender, string topic, string body)
		{

		}

		public void Send(string message, object body)
		{
			// yolo?
		}
	}
}
