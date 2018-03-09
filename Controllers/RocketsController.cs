using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers {
    [Route("api/[controller]")]
    public class VideosMusicalesController : Controller {
        [HttpGet]
        public ActionResult Get() {
            return Ok(FakeData.Videos.Values.ToArray());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id) {
            if (FakeData.Videos.ContainsKey(id)) {
                return Ok(FakeData.Videos[id]);
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody]VideoMusical video) {
            if (!this.ModelState.IsValid || video == null) {
                return BadRequest();
            } else {
                var maxExistingID = 0;
                if (FakeData.Videos.Count > 0) {
                    maxExistingID = FakeData.Videos.Keys.Max();
                }

                video.ID = maxExistingID + 1;
                FakeData.Videos.Add(video.ID, video);

                return Created($"api/rockets/{video.ID}", video);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]VideoMusical video) {
            if (!this.ModelState.IsValid) {
                return BadRequest();
            } else if (FakeData.Videos.ContainsKey(id)) {
                FakeData.Videos[id] = video;
                return Ok();
            } else {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id) {
            if (FakeData.Videos.ContainsKey(id)) {
                FakeData.Videos.Remove(id);
                return Ok();
            } else {
                return NotFound();
            }
        }
    }
}