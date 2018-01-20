namespace Common
{
    public class PaginationRequest
    {
        public PaginationRequest()
        {
        }

        public PaginationRequest(int pageSize)
        {
            PageSize = pageSize;
        }


        public PaginationRequest(int page, int pageSize)
        {
            PageSize = pageSize;
            Page = page;
        }

        private int _page = 1;

        public int Page
        {
            get => _page;
            set => _page = value > 1 ? value : 1;
        }

        public int PageIndex => Page > 0 ? Page - 1 : 0;

        public int PageSize { get; set; } = 2;

        public int From => SkipCount;

        public int SkipCount => PageIndex * PageSize;
    }
}
