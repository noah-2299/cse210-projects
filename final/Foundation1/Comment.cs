using System;

public class Comment
    {
        private string _userName;
        private string _bodyText;

        public string GetBodyText()
        {
            return _bodyText;
        }
        public string GetUserName()
        {
            return _userName;
        }

        public Comment(string user, string body)
        {
            _userName = user;
            _bodyText = body;
        }
    }