using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using PhoneBook.Helpers;
using WebApplication1.Models;

namespace PhoneBook.Models
{
	public class SourceManager
	{
		//
		// Simply method for saving logs into database
		//
		public static void AddLog(LogModel logModel)
		{
			using (var connection = SqlHelper.GetConnection())
			{
				var sqlCommand = new SqlCommand();
				sqlCommand.Connection = connection;
				sqlCommand.CommandText = @"Insert INTO Log (API, OriginalText, NewText)
				VALUES (@api, @originalText , @newText)";

				var sqlAPIParam = new SqlParameter
				{
					DbType = System.Data.DbType.AnsiString,
					Value = logModel.API,
					ParameterName = "@api"
				};

				var sqlOriginalTextParam = new SqlParameter
				{
					DbType = System.Data.DbType.AnsiString,
					Value = logModel.OriginalText,
					ParameterName = "@originalText"
				};

				var sqlNewTextParam = new SqlParameter
				{
					DbType = System.Data.DbType.AnsiString,
					Value = logModel.NewText,
					ParameterName = "@newText"
				};

				sqlCommand.Parameters.Add(sqlAPIParam);
				sqlCommand.Parameters.Add(sqlOriginalTextParam);
				sqlCommand.Parameters.Add(sqlNewTextParam);

				sqlCommand.ExecuteScalar();
			}
		}
	}
}