using searchApp.Domain;

namespace searchApp.Service
{
    public interface ISearchService
    {
        Task<ImageResponse> GetImages();
        Task<NewsResponse> GetNews();
        Task<ScholarResponse> GetScholars();
        Task<SearchResponse> GetSearch();
        Task<VideoResponse> GetVideos();
        Task<Serp> AddSerp();
    }
}
