using System;
using System.Collections.Generic;

namespace Proyecto
{
    public class User
    {
        public string name;
        public string email;
        public int password;
        public bool private_account;
        public List<User> followers;
        public List<Object> following;
        public List<Media> queue;
        Dictionary<object, List<object>> Favorites = new Dictionary<object, List<object>>();
        List<object> Likes = new List<object>();
        public bool premium; 

        public User(string name, string email, int password, bool private_account, Dictionary<object, List<object>> Favorites, List<object> Likes, bool premium)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.private_account = private_account;
            this.Favorites = Favorites;
            this.Likes = Likes;
            this.premium = premium;
        }

        public void Add_To_Queue(Media new_media)
        {

        }

        public void Add_To_Playlist()
        {

        }

        public void New_Playlist()
        {

        }

        public void Follow(object follow)
        {

        }

    }
}
