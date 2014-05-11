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
        Snip[] tempSnapshots = new Snip[]
        {
            new Snip {URL = "http://www.google.com", WindowHeight = 800, WindowWidth = 1200, ScrollPosition = 0, Snapshot = new Rectangle(200,200,300,200)},
            new Snip {URL = "http://www.bing.com", WindowHeight = 800, WindowWidth = 1200, ScrollPosition = 0, Snapshot = new Rectangle(200,200,100,100)}
        };

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
