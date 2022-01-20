using System;
using System.IO;
using System.Text;

    public class ReadText 
    {
        public static string getUsername()
    {
            // Console.WriteLine("Thong tin nguoi dung : ");
            // Debug.Log("Thong tin nguoi dung : ");
            // Console.WriteLine(username);
            // Debug.Log(username);
            string username = File.ReadAllText("user.txt");
            return username;
    }
      
}
