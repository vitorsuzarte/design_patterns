using ChatRoom;

public class Program
{
   static void Main(string[] args)
   {
      var room = new ChatRoomMediator();

      var john = new Person("John");
      var mary = new Person("Mary");

      room.Join(john);
      room.Join(mary);

      john.Say("hi");
      mary.Say("oh, hey john");

      var simon = new Person("Simon");
      room.Join(simon);
      simon.Say("hi everyone");

      mary.PrivateMessage("Simon", "glad you could join us!");
   }
}