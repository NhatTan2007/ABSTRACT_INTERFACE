using System;
using System.Collections.Generic;
using System.Text;

namespace NEWS_MANAGEMENT_SYSTEM
{
    class News : INews
    {
        private int _id;
        private string _title;
        private DateTime _publishDate;
        private string _author;
        private string _content;
        private float _averageRate;
        private int[] _rateList = new int[3];
        private bool _isCalculateRate = false;
        public static int ID = 0;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public DateTime PublishDate { get => _publishDate; set => _publishDate = value; }
        public string Author { get => _author; set => _author = value; }
        public string Content { get => _content; set => _content = value; }
        public float AverageRate { get => _averageRate; }
        public int[] RateList { get => _rateList; set => _rateList = value; }
        public bool IsCalculateRate { get => _isCalculateRate;}

        public News()
        {

        }

        public News(string title, DateTime publishDate, string author, string content)
        {
            _id = ++ID; ;
            _title = title;
            _publishDate = publishDate;
            _author = author;
            _content = content;
        }

        public string Display()
        {
            if(_isCalculateRate)
            {
                return $"Title:\t{_title}\n\n" +
                    $"Publishdate:\t{_publishDate}\t" +
                    $"Written by:\t{_author}\n\n" +
                    $"{_content}\n\n" +
                    $"Average Rate: {_averageRate}";
            } else
            {
                return $"Title:\t{_title}\n\n" +
                    $"Publishdate:\t{_publishDate}\t" +
                    $"Written by:\t{_author}\n\n" +
                    $"{_content}\n\n" +
                    $"Average Rate: Not calculate yet";
            }
        }

        public void CalculateAverageRate()
        {
            int sumRate = 0;
            foreach (int value in _rateList)
            {
                sumRate += value;
            }
            _averageRate = (float)sumRate / 3;
            _isCalculateRate = true;
        }
    }
}
