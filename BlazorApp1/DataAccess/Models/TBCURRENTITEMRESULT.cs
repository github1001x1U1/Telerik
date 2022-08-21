using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace BlazorApp1.DataAccess.Models
{

	/// <summary>
	/// 常规结果表
	/// </summary>
	[JsonObject(MemberSerialization.OptIn), Table(Name = "TB_CURRENT_ITEM_RESULT", DisableSyncStructure = true)]
	public partial class TBCURRENTITEMRESULT {

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

		/// <summary>
		/// 单位
		/// </summary>
		[JsonProperty, Column(DbType = "varchar(100)")]
		public string BK1 { get; set; }

		/// <summary>
		/// 危急值标志
		/// </summary>
		[JsonProperty, Column(DbType = "varchar(100)")]
		public string BK2 { get; set; }

		/// <summary>
		/// 报告结果
		/// </summary>
		[JsonProperty, Column(Name = "CURRENT_RESULT", StringLength = 100)]
		public string CURRENTRESULT { get; set; }

		/// <summary>
		/// 结果标志
		/// </summary>
		[JsonProperty, Column(Name = "custom_col1", DbType = "varchar(200)")]
		public string CustomCol1 { get; set; }

		/// <summary>
		/// 参考区间
		/// </summary>
		[JsonProperty, Column(Name = "custom_col2", DbType = "varchar(200)")]
		public string CustomCol2 { get; set; }

		[JsonProperty, Column(Name = "custom_col3", DbType = "varchar(200)")]
		public string CustomCol3 { get; set; }

		/// <summary>
		/// CUTOFF值
		/// </summary>
		[JsonProperty, Column(Name = "CUTOFF_VALUE", DbType = "varchar(20)")]
		public string CUTOFFVALUE { get; set; }

		[JsonProperty, Column(Name = "data_from", DbType = "char(1)")]
		public string DataFrom { get; set; }

		[JsonProperty, Column(Name = "group_code", DbType = "varchar(20)")]
		public string GroupCode { get; set; }

		/// <summary>
		/// 结果时间
		/// </summary>
		[JsonProperty, Column(Name = "LAST_MODIFIED")]
		public DateTime? LASTMODIFIED { get; set; }

		/// <summary>
		/// OD值
		/// </summary>
		[JsonProperty, Column(Name = "OD_VALUE", DbType = "varchar(20)")]
		public string ODVALUE { get; set; }

		/// <summary>
		/// 检测仪器
		/// </summary>
		[JsonProperty, Column(Name = "ORIGIN_INSTR", DbType = "varchar(40)")]
		public string ORIGININSTR { get; set; }

		/// <summary>
		/// 原始结果
		/// </summary>
		[JsonProperty, Column(Name = "ORIGION_RESULT", StringLength = 100)]
		public string ORIGIONRESULT { get; set; }

		[JsonProperty, Column(Name = "ORIGION_SAMPLENO", DbType = "varchar(20)", IsNullable = false)]
		public string ORIGIONSAMPLENO { get; set; }

		/// <summary>
		/// 打印标志
		/// </summary>
		[JsonProperty, Column(Name = "PRINT_FLAG", DbType = "char(1)")]
		public string PRINTFLAG { get; set; }

		[JsonProperty, Column(Name = "PRINT_RESULT", StringLength = 100)]
		public string PRINTRESULT { get; set; }

		/// <summary>
		/// 检测试剂批号
		/// </summary>
		[JsonProperty, Column(Name = "reagentnumber", DbType = "varchar(200)")]
		public string Reagentnumber { get; set; }

		[JsonProperty, Column(Name = "reference", DbType = "varchar(100)")]
		public string Reference { get; set; }

		[JsonProperty, Column(Name = "REFRESH_FLAG", DbType = "char(1)")]
		public string REFRESHFLAG { get; set; } = "0";

		[JsonProperty, Column(Name = "RESULT_FLAG", DbType = "char(1)")]
		public string RESULTFLAG { get; set; }

		/// <summary>
		/// 复查标志
		/// </summary>
		[JsonProperty, Column(Name = "RESULT_STATE", DbType = "varchar(20)")]
		public string RESULTSTATE { get; set; }

		[JsonProperty, Column(Name = "SERIAL_NO")]
		public int SERIALNO { get; set; }

	}

}
