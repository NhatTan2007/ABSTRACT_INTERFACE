using System;
using System.Collections.Generic;
using System.Text;

namespace NEWS_MANAGEMENT_SYSTEM
{
    interface INews
    {
        int Id { get;}
        string Title { get; set; }
        DateTime PublishDate { get; set; }
        string Author { get; set; }
        string Content { get; set; }
        float AverageRate { get;}

        string Display();
    }
}
