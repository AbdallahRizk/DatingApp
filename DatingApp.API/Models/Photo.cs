using System;

namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

        //The reason of those two prop is to tell enttity framework that if user is deleted delete the photo with it
        public User User { get; set; }
        public int UserId { get; set; }
    }
}