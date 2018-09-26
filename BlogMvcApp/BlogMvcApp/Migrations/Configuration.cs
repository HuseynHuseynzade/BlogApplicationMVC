namespace BlogMvcApp.Migrations
{
    using BlogMvcApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogMvcApp.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogMvcApp.Models.BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryName="C#" },
                new Category() { CategoryName="Asp.net MVC" },
                new Category() { CategoryName="Asp.net WebForm" },
                new Category() { CategoryName="Windows Form" },
            };

            foreach (var item in categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();


            List<Blog> blogs = new List<Blog>()
            {
                new Blog() { Header="C# Delegate", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=1 },
                new Blog() { Header="C# Generic  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=1 },
                new Blog() { Header="C# Lambda Expression", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-30), HomePage=false, Approval=false, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=1 },
                new Blog() { Header="C# Class  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-20), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="2.jpg", CategoryId=2 },
                new Blog() { Header="C# Async  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-5), HomePage=true, Approval=false, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=2 },
                new Blog() { Header="C# Method  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=false, Approval=false, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="2.jpg", CategoryId=2 },
                new Blog() { Header="C# Asp.Net  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=true, Approval=true, Content=" Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="2.jpg", CategoryId=3 },
                new Blog() { Header="C# Asp.Net MVC  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=false, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="2.jpg", CategoryId=3 },
                new Blog() { Header="C# Asp.Net MVC Core  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-15), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=3 },
                new Blog() { Header="C# Middleware  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-17), HomePage=true, Approval=false, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="2.jpg", CategoryId=4 },
                new Blog() { Header="C# Tag Helpers  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=4},
                new Blog() { Header="C# Globalization  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=4 },
                new Blog() { Header="C# Localization  ", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", UploadDate=DateTime.Now.AddDays(-10), HomePage=true, Approval=true, Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis velit enim, at venenatis nulla scelerisque et. Cras nibh nunc, ornare ut metus ac, varius fringilla nisl. Sed sit amet diam iaculis, congue magna nec, posuere risus. ", İmage="1.jpg", CategoryId=4 },
            };

            foreach (var item in blogs)
            {
                context.Blogs.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
