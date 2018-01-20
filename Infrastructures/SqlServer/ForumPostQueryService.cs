using System.Collections.Generic;
using System.Linq;
using Common;
using SqlServer.Models;

namespace SqlServer
{
    public class ForumPostQueryService
    {
        public List<ForumTopic> GetList(int page, int pageSize = 100)
        {
            var paginationRequest = new PaginationRequest(page, pageSize);

            using (var dbContext = new NiniSiteContext() )
            {
                var items = dbContext.ForumTopic
                    .OrderBy(e=>e.CreatedOn)
                    .Skip(paginationRequest.SkipCount)
                    .Take(paginationRequest.PageSize)
                    .ToList();

                return items;
            }
        }
    }
}
