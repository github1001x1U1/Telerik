using BlazorApp1.DataAccess.Dto;
using BlazorApp1.DataAccess.Models;
using System.Collections.Generic;

namespace BlazorApp1.DataAccess.AdoTool
{
    public class QueryTool
    {
        private static IFreeSql fsql = CustomFreeSql.Get();
        public List<TBCURRENTITEMRESULTDto> QueryAll()
        {
            var item= fsql.Select<TBCURRENTITEMRESULT>().ToOne();
            List<TBCURRENTITEMRESULTDto> result = new List<TBCURRENTITEMRESULTDto>() ;
            //result.Add(items);
            //foreach (var item in items)
            //{
            result.Add(new TBCURRENTITEMRESULTDto
            {
                INSTRUMENT = item.INSTRUMENT,
                ITEMCODE = item.ITEMCODE,
                SAMPLEDATE = item.SAMPLEDATE,
                SAMPLENO = item.SAMPLENO,
                ADDTRESULT = item.ADDTRESULT
            });
            //}
            return result;
        }
    }
}
