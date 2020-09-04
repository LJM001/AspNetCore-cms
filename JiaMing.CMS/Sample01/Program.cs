using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;


namespace Sample01
{
    class Program
    {
        //private  const  string sqlConnectionStr= "Data Source=.;Initial Catalog=Czar.Cms;Integrated Security = True;Pooling=true;Max Pool Size=100; MultipleActiveResultSets=true;";
        //public const string sqlConnectionStr2 = "Data Source =.; Initial Catalog =Czar.Cms; Integrated Security = True; MultipleActiveResultSets=true;";

        //private const string sqlConnectionStr = @"server=locahost;integrated security = true; MultipleActiveResultSets=true;database=Czar.Cms;Max Pool Size = 100;";
        private const string sqlConnectionStr = @"Data Source=.; Integrated Security = true;database=Czar.Cms;MultipleActiveResultSets=true;Max Pool Size=100";
        public Program()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            test_mul_insert();

            Console.ReadKey();
        }

        static void test_insert()
        {
            var content = new Content()
            {
                Title = "标题1",
                content = "内容1"
            };
            using (var conn = new SqlConnection(sqlConnectionStr))
            {
                string sql_insert = @"Insert into [Content]
                (title,[content],status,add_time,modify_time)
                values(@title,@content,@status,@add_time,@modify_time)";
                var result = conn.Execute(sql_insert, content);

                Console.WriteLine($"test_insert ：插入了{result}条数据!!!");
            }

        }


        static void test_mul_insert()
        {
            string sql_inserts = @"Insert into Content
            (title,[content],status,add_time,modify_time)
             values(@title,@content,@status,@add_time,@modify_time)";

            var list = new List<Content>()
            {
                new Content()
                {
                    Title = "一次添加多条数据的标题11111",
                    content = "一次添加多条数据的内容啊啊啊啊11111"
                },
                new Content()
                {
                    Title = "一次添加多条数据的标题22222",
                    content = "一次添加多条数据的内容啊啊啊啊22222"
                },
                new Content()
                {
                    Title = "一次添加多条数据的标题333333",
                    content = "一次添加多条数据的内容啊啊啊啊33333"
                }
            };
            using (var conn = new SqlConnection(sqlConnectionStr))
            {
                var result = conn.Execute(sql_inserts, list);

                Console.WriteLine($"test_insert ：插入了{result}条数据!!!");
            }

        }


    }
}
