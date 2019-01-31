using WebApplication.Models;

using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System;
using System.Collections.Generic;

namespace WebApplication.Controllers
{
    public class JoggingRecordsController : ApiController
    {

        List<JoggingRecord> JoggingRecords = new List<JoggingRecord> {
            new JoggingRecord { Id = 1, Description = "Friday Evening", Distance = 5.5f, CreatedAt = new DateTime(2018, 5, 1) },
            new JoggingRecord { Id = 2, Description = "Saturday morning", Distance = 6.15f, CreatedAt = new DateTime(2018, 4, 4) },
            new JoggingRecord { Id = 3, Description = "Marathon", Distance = 20, CreatedAt = new DateTime(2019, 5, 13) },
            new JoggingRecord { Id = 4, Description = "Short one", Distance = 3.5f, CreatedAt = new DateTime(2018, 6, 6) }
        };
        
        // GET: api/JoggingRecords
        [HttpGet]
        public IList<JoggingRecord> GetJoggingRecords() => JoggingRecords;

        // GET: api/JoggingRecords/[id number]
        [HttpGet]
        public JoggingRecord GetJoggingRecord(int id)
        {
            JoggingRecord joggingRecord = JoggingRecords.Where(r => r.Id == id).FirstOrDefault();

            return joggingRecord;
        }
    }
}