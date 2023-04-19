using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Google.Apis.Drive.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using test_a_2;

namespace test_a_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleDriveController : ControllerBase
    {
        //Declare credentials to access Google Drive
        private string[] Scopes = { DriveService.Scope.Drive };
        private string ApplicationName = "Google Drive Configuration";

        //Constructor to initialize Google Drive service
        public GoogleDriveController()
        {
            //Creating credentials using json file
            var credentials = GoogleCredential.FromFile("credentials.json");

            //Creating Drive API service
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credentials,
                ApplicationName = ApplicationName,
            });
        }

        // GET: api/GoogleDrive
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Google Drive Configuration Service is running" };
        }
    }
}