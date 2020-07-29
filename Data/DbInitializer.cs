using DWMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DWMS.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DefaultContext context)
        {
            context.Database.EnsureCreated();
            if (context.sysUsers.Any())
            {
                return;
            }
            var users = new SysUser[] { new SysUser { Name = "Jack" }, new SysUser { Name = "Musk" } };
            foreach (var item in users)
            {
                context.sysUsers.Add(item);
            }
            context.SaveChanges();
        }
    }
}
