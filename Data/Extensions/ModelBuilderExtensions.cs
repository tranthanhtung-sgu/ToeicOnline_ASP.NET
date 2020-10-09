using System;
using Microsoft.EntityFrameworkCore;
using ToeicOnline.Models;

namespace ToeicOnline_ASP.NET.Data.Extensions
{
    public static class ModelBuilderExtensions
    {   
        public static void Seed(this ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().HasData(
                    new User () {id = 1,username = "tung", password = "123456", birthday=new DateTime(1999-03-22), phonenumber=0338915243},
                    new User () {id = 2, username = "anhtung", password = "123456", birthday=new DateTime(1999-03-22), phonenumber=0338915243},
                    new User () {id = 3, username = "tranthanhtung", password = "123456", birthday=new DateTime(1999-03-22), phonenumber=0338915243}
                );
            }
    }
}