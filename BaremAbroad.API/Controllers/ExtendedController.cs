using BaremAbroad.Core.Helpers;
using BaremAbroad.Repository.DTOs.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtendedController : Controller
    {
        SqlConnection SqlConnection { get; set; }
        public ExtendedController(IConfiguration configuration)
        {
            SqlConnection = new SqlConnection(configuration.GetConnectionString("DbConnect"));
        }

        [HttpGet("[action]")]
        public IActionResult Sp_GetBlogArticles()
        {
            SqlConnection.Open();

            string query = "EXEC getAllBlogArticles @lang = @plang";

            var command = SqlConnection.CreateCommand();
            command.CommandText = query;

            command.Parameters.AddWithValue("@plang", "TR");

            var dataReader = command.ExecuteReader();
            List<object> output = new List<object>();
            while (dataReader.Read())
            {
                for (int i = 0; i < 21; i++)
                {
                    output.Add(dataReader.GetValue(i));
                }
            }
            dataReader.Close();
            command.Dispose();
            SqlConnection.Close();

            return Ok(output);
        }

        [HttpGet("[action]")]
        public IActionResult Sp_LoginCheck([FromQuery] LoginUserDTO user)
        {
            PasswordHashHelper.CreatePasswordHash(user.Password,
                out byte[] passwordHash,
                out byte[] passwordSalt);

            string hash = "";
            foreach (var item in passwordHash)
            {
                hash += item;
            }
            string salt = "";
            foreach (var item in passwordSalt)
            {
                salt += item;
            }


            SqlConnection.Open();

            string query = "EXEC loginCheck @loginEmail = @loginMail, @loginPasswordHashed = @passwordHashed, @loginPasswordSalt = @passwordSalt";

            var command = SqlConnection.CreateCommand();
            command.CommandText = query;

            command.Parameters.AddWithValue("@loginMail", user.Email);
            command.Parameters.AddWithValue("@passwordHashed", passwordHash);
            command.Parameters.AddWithValue("@passwordSalt", passwordSalt);

            var dataReader = command.ExecuteReader();
            List<object> output = new();

            while (dataReader.Read())
            {
                for (int i = 0; i < 10; i++)
                {
                    output.Add(dataReader.GetValue(i));
                }
            }

            dataReader.Close();
            command.Dispose();
            SqlConnection.Close();

            if (output.Count == 0)
            {
                return NoContent();
            }
            else
            {
                UserResponseDTO userResponse = new UserResponseDTO()
                {
                    Id = (int)output[0],
                    FirstName = (string)output[1],
                    LastName = (string)output[2],
                    MailAddress = (string)output[3],
                    PhoneNumber = (string)output[4],
                    LoginName = (string)output[5],
                    AdminLevel = (int)output[6],
                    CreateDate = (DateTime)output[8],
                    UpdateDate = (DateTime)output[9],
                };
                return Ok(userResponse);
            }
        }
    }
}
