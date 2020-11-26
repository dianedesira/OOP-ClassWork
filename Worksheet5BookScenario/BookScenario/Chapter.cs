using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScenario
{
    class Chapter
    {
        List<Page> pages = new List<Page>();
        string title;
        int chapterNumber;
        public string Title { get => title; set => title = value; }
        public int ChapterNumber { get => chapterNumber; set => chapterNumber = value; }
        internal List<Page> Pages { get => pages; set => pages = value; }

        public Chapter(string title, int chapterNumber)
        {
            this.title = title;
            this.chapterNumber = chapterNumber;
        }

        public void AddPage()
        {
            /* We have a composition relationship between Chapter and Page since
             * the page instance is created in the chapter instance and without
             * the chapter instance, the page instance cannot be accessed.
             * Thus, if the chapter instance is deleted, the page instance is
             * deleted with it.
             */
            Page newPage = new Page(pages.Count + 1);
            pages.Add(newPage);

            //pages.Add(new Page(pages.Count + 1));
        }
    }
}
