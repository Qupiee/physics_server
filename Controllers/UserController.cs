﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using server.Models;
using System.Web.Http.Results;

namespace server.Controllers
{
    public class UserController : ApiController //UserController - название файла UserController //RegistrationController - название файла RegistrationController
    {
        SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand _command = null;
        SqlDataAdapter _adapter = null;

        [HttpPost]
        [Route("Registration")]

        public string Registration(User user)
        {
            string result = string.Empty;
            try
            {                
                _command = new SqlCommand("uspRegistration", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@UserLogin", user.UserLogin);
                _command.Parameters.AddWithValue("@UserPassword", user.UserPassword);

                _connection.Open();
                int i = _command.ExecuteNonQuery();
                _connection.Close();
                if (i > 0)
                {
                    result = "Пользователь зарегистрирован";
                }
                else
                {
                    result = "Ошибка данных";
                }                
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        [HttpGet]
        [Route("Authorization")]

        public string Authorization(User user)
        {
            string result = string.Empty;
            try
            {
                _adapter = new SqlDataAdapter("uspAuthorization", _connection);
                _adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                _adapter.SelectCommand.Parameters.AddWithValue("@UserLogin", user.UserLogin);
                _adapter.SelectCommand.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                DataTable dt = new DataTable();
                _adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    result = "Добро пожаловать";
                }
                else
                {
                    result = "Ошибка данных";
                }
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}