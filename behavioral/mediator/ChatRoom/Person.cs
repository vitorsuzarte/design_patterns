namespace ChatRoom
{
   public class Person
   {
      public string Name { get; set; }
      public ChatRoomMediator Room { get; set; }
      private List<string> chatLog = new List<string>();

      public Person(string name)
      {
         Name = name;
      }

      public void Say(string message)
      {
         Room.Broadcast(Name, message);
      }

      public void PrivateMessage(string receiver, string message)
      {
         Room.Message(Name, receiver, message);
      }

      public void Receive(string sender, string message)
      {
         string s = $"{sender}: '{message}'";
         chatLog.Add(s);
         Console.WriteLine($"[{Name}'s chat session] {s}");
      }

   }


}
