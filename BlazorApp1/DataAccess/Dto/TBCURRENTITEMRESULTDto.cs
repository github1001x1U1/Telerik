using FreeSql.DataAnnotations;
using Newtonsoft.Json;
using System;

namespace BlazorApp1.DataAccess.Dto
{
    public class TBCURRENTITEMRESULTDto
    {
		/// <summary>
		/// 检测平台代号
		/// </summary>
		[JsonProperty, Column(DbType = "varchar(20)", IsPrimary = true, IsNullable = false)]
		public string INSTRUMENT { get; set; }

		/// <summary>
		/// 项目代号
		/// </summary>
		[JsonProperty, Column(Name = "ITEM_CODE", DbType = "varchar(20)", IsPrimary = true, IsNullable = false)]
		public string ITEMCODE { get; set; }

		/// <summary>
		/// 标本日期
		/// </summary>
		[JsonProperty, Column(Name = "SAMPLE_DATE", IsPrimary = true)]
		public DateTime SAMPLEDATE { get; set; }

		/// <summary>
		/// 标本号
		/// </summary>
		[JsonProperty, Column(Name = "SAMPLE_NO", DbType = "varchar(20)", IsPrimary = true, IsNullable = false)]
		public string SAMPLENO { get; set; }

		/// <summary>
		/// 附加结果
		/// </summary>
		[JsonProperty, Column(Name = "ADDT_RESULT", DbType = "varchar(20)")]
		public string ADDTRESULT { get; set; }
	}
}
