using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialI_ITVDN_01
{
    class Book
    {

        Title title=null;
        Content content=null;
        Author author=null;

         private void InitializeDoc()
        {
            this.title = new Title();
            this.content = new Content();
            this.author = new Author();
        }

        public Book(string title, string content, string author)
        {
            InitializeDoc();
            this.title.TitleFill = title;
            this.content.ContentFill = content;
            this.author.AuthorFill = author;
        
        }
        public Book() { }


        public void ShowBook()
        {

            this.title.Show();
            this.content.Show();
            this.author.Show();
        
        }


    }
}
