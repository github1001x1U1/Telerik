namespace BlazorApp1.DataAccess.AdoTool
{
    public class CustomFreeSql
    {
        private static IFreeSql fsql = new FreeSql.FreeSqlBuilder()
            .UseConnectionString(FreeSql.DataType.SqlServer,
            "Server=localhost;initial catalog=lis360;user id=sa;password=ms112244520@;connection timeout=5")
            .UseAutoSyncStructure(true) //自动同步实体结构到数据库
            .Build(); //请务必定义成 Singleton 单例模式
                        // 获取IFreeSql对象
        public static IFreeSql Get() => fsql;
    }
}
