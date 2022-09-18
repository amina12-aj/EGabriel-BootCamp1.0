namespace Blog.Models
{
    public class BlogRepository: list<BlogDetails>
    {
        private string rootPath;
        private string blogFile;

        public BlogRepository(string rootPath, string blogFile)
        {
            this.rootPath = rootPath;
            this.blogFile = blogFile;
            GetAllBlogArticles(false);
        }

        public void GetAllBlogArticles(bool? forceReload)
        {
            if (this.Count == 0 || (forceReload == true))
            {
                this.Clear();
                LoadBlogArticlesFromDataStore();
            }
        }

        private void LoadBlogArticlesFromDataStore()
        {
            string[] allLines = File.ReadAllLines(Path.Combine(rootPath, blogFile));
            foreach (string line in allLines)
            {
                try
                {
                    string[] allItems = line.Split('|');

                    BlogDetails blogInfo = new BlogDetails();
                    blogInfo.BlogId = Convert.ToInt32(allItems[0]); //id 1; newest first (top of file)
                    blogInfo.Title = allItems[1]; // "Biggest Tech Article Ever";
                    blogInfo.Description = allItems[1];
                    blogInfo.PublishedDate = DateTime.Parse(allItems[4]); // 2015-03-31
                    this.Add(blogInfo);
                }
                finally
                {
                    // if any fail, just move to the next one
                    // do not stop the app for any reason!
                }
            }
        }
    }
}
