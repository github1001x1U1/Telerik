namespace BlazorApp5.DataAccess.Model
{
    //血常规
    public class RoutineBloodTest
    {
        public string ProjectName { get; set; }//项目名称
        public string Result { get; set; }//结果
        public string Company { get; set; }//单位
        public string ReferenceValue { get; set; }//参考值
        public string Methodology { get; set; }//方法学
        public string TestingEquipment { get; set; }//检测设备
    }
}
