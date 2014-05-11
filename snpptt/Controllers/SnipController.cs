using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Drawing;
using snpptt.Models;

namespace snpptt.Controllers
{
    public class SnipController : ApiController
    {
        // Get all cached snips for a given user
        
        // Add snip for user

        // Update snip - needs to run in parallel

        private int getUserID (string username)
        {
            // for MVP, we are only having one user in our database - admin with userID of 1
            return 1;
        }
    }
}
