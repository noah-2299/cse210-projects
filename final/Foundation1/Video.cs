using System;

public class Video 
    {
        private string _title;

        private string _author;
        private int _durationInSec;
        private List<Comment> _commentsList = new List<Comment>();

        public int GetNumberOfComments()
            {
                int sum = 0;
                foreach(Comment comment in _commentsList)
                {
                    sum += 1;
                }
                return sum;
            }
        public string GetTitle()
        {
            return _title;
        }
        public Video(string title, int duration,string author)
        {
            _title = title;
            _durationInSec = duration;
            _author = author;
        }
        public void AddComment(string user, string body)
        {
            Comment comment = new Comment(user,body);
            _commentsList.Add(comment);
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Title: {_title} \n   Author: {_author} \n   Duration(sec): {_durationInSec}");
        }
        public void PrintComments()
        {
            for (int i=0; i< _commentsList.Count(); i++)
            {
                Console.WriteLine($"Comment {i+1}, Written by {_commentsList[i].GetUserName()}: {_commentsList[i].GetBodyText()}");
            }
        }
    }