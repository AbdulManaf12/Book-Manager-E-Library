using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Project
{
    internal class SearchBooks
    {
        HomePageForm form;
        String bookSearchText;
        String option;
        int y = 2;
        public SearchBooks(HomePageForm form, String bookSearch, String option)
        {
            this.form = form;
            this.bookSearchText = bookSearch;
            this.option = option;
            form.search_flowlayut_panel.Controls.Clear();
            SeacrhBook(form.MyLibraryBooksList, new List<Book>());
            SeacrhBook(form.RecentBooksList, form.MyLibraryBooksList);
        }
        public static String[] getRandomFun(int i)
        {
            String[] text = null;
            try
            {
                String url = "https://www.beagreatteacher.com/daily-fun-fact/";
                if (i > 1)
                {
                    url += "page/" + i + "/";
                }
                HtmlAgilityPack.HtmlWeb html = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument d = html.Load(url);

                var output = d.DocumentNode.SelectNodes("//main[@class='content']");
                String temp = output.ToList().First().InnerText;

                text = new string[4];

                for (int j = 0; j < 100; j++)
                {
                    temp = temp.Replace(("&#82" + j + ";"), "");
                }
                text[0] = temp.Substring(temp.IndexOf("Thought of the Day:") + 19);
                text[0] = text[0].Substring(0, text[0].IndexOf("Joke of the Day:"));

                text[1] = temp.Substring(temp.IndexOf("Joke of the Day:") + 16);
                text[1] = text[1].Substring(0, text[1].IndexOf("Random Fact of the Day:"));

                text[2] = temp.Substring(temp.IndexOf("Random Fact of the Day:") + 23);
                text[2] = text[2].Substring(0, text[2].IndexOf("Journal Entry Idea:"));

                text[3] = temp.Substring(temp.IndexOf("Journal Entry Idea:") + 19);
                if (i == 1)
                    text[3] = text[3].Substring(0, text[3].IndexOf("&nbsp;Next"));
                else
                    text[3] = text[3].Substring(0, text[3].IndexOf("&nbsp;&laquo; Previous Page  Next Page &raquo;"));
            }
            catch (Exception ex) { }
            return text;
        }
        private void SeacrhBook(List<Book> list1, List<Book> list2)
        {
            foreach(Book b in list1)
            {
                if (isExists(b, list2))
                    continue;
                if(option == "Name")
                {
                    if(b.Name.Contains(bookSearchText))
                    {
                        form.search_flowlayut_panel.Controls.Add(new BookPanel(b,form,y));
                        y += 150;
                    }
                }
                else if (option == "Author")
                {
                    if (b.Author.Contains(bookSearchText))
                    {
                        form.search_flowlayut_panel.Controls.Add(new BookPanel(b, form, y));
                        y += 150;
                    }
                }
                else if (option == "Year")
                {
                    if ((b.year+"") == bookSearchText)
                    {
                        form.search_flowlayut_panel.Controls.Add(new BookPanel(b, form, y));
                        y += 150;
                    }
                }
            }
        }
        private bool isExists(Book target, List<Book> list)
        {
            foreach(Book b in list)
            {
                if(b.url == target.url)
                    return true;
            }
            return false;
        }
    }
}