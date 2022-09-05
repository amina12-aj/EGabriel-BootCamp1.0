

namespace Blog.Models.DataAccess
{
    public class TestDb: DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var BlogInfo = new List<BlogDetails>
            {
            new BlogDetails{Title="Carson",Description="Alexander",PublishedDate=DateTime.Now},
            new BlogDetails{Title="C# for Dummies",Description="Learn brain friendly C#",PublishedDate=DateTime.Now},
            new BlogDetails{Title="The Life we know",Description="House can be built on rock",PublishedDate=DateTime.Now},

            };
            BlogInfo.ForEach(b => context.Blog.Add(b));
            context.SaveChanges();

            var user = new List<RoleDetails>
            {
            new RoleDetails{RoleId=1,RoleName="Admin",},
            new RoleDetails{RoleId=2,RoleName="User",}


            };
            user.ForEach(r => context.RoleDetail.Add(r));
            context.SaveChanges();
        }
    }
}
