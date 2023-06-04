namespace ChatRoom
{
   public class ChatRoomMediator
   {
      public List<Person> people = new List<Person>();

      public void Join(Person p)
      {
         string joinMessage = $"{p.Name} joins the chat";
         Broadcast("room", joinMessage);

         p.Room = this;
         people.Add(p);
      }

      public void Broadcast(string source, string message)
      {
         foreach (var p in people)
            if (p.Name != source)
               p.Receive(source, message);

      }

      public void Message(string sender, string receiver, string message)
      {
         people.FirstOrDefault(p => p.Name == receiver)?.Receive(sender, message);
      }
   }
}
