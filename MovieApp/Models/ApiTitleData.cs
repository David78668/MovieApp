using static MovieApp.Models.ApiTitleData;

namespace MovieApp.Models
{
    public class ApiTitleData
    {
        public class Actor
        {
            public string Id { get; set; }
            public string Image { get; set; }
            public string Name { get; set; }
            public string AsCharacter { get; set; }
        }

        public class ActorList
        {
            public string Id { get; set; }
            public string Image { get; set; }
            public string Name { get; set; }
            public string AsCharacter { get; set; }
        }

        public class Backdrop
        {
            public string Id { get; set; }
            public string Link { get; set; }
            public int AspectRatio { get; set; }
            public string Language { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class BoxOffice
        {
            public string Budget { get; set; }
            public string OpeningWeekendUSA { get; set; }
            public string GrossUSA { get; set; }
            public string CumulativeWorldwideGross { get; set; }
        }

        public class CompanyList
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class CountryList
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public class CreatorList
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class DirectorList
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Directors
        {
            public string Job { get; set; }
            public List<Item> Items { get; set; }
        }

        public class FullCast
        {
            public string ImDbId { get; set; }
            public string Title { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public Directors Directors { get; set; }
            public Writers Writers { get; set; }
            public List<Actor> Actors { get; set; }
            public List<Other> Others { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class GenreList
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public class Images
        {
            public string ImDbId { get; set; }
            public string Title { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public List<Item> Items { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class Item
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Title { get; set; }
            public string Image { get; set; }
        }

        public class LanguageList
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public class Other
        {
            public string Job { get; set; }
            public List<Item> Items { get; set; }
        }

        public class PlotFull
        {
            public string PlainText { get; set; }
            public string Html { get; set; }
        }

        public class PlotShort
        {
            public string PlainText { get; set; }
            public string Html { get; set; }
        }

        public class Poster
        {
            public string Id { get; set; }
            public string Link { get; set; }
            public int AspectRatio { get; set; }
            public string Language { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public string ImDbId { get; set; }
            public string Title { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public List<Poster> Posters { get; set; }
            public List<Backdrop> Backdrops { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class Ratings
        {
            public string ImDbId { get; set; }
            public string Title { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public string ImDb { get; set; }
            public string Metacritic { get; set; }
            public string TheMovieDb { get; set; }
            public string RottenTomatoes { get; set; }
            public string FilmAffinity { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class TitleResponse
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string OriginalTitle { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public string Image { get; set; }
            public string ReleaseDate { get; set; }
            public string RuntimeMins { get; set; }
            public string RuntimeStr { get; set; }
            public string Plot { get; set; }
            public string PlotLocal { get; set; }
            public bool PlotLocalIsRtl { get; set; }
            public string Awards { get; set; }
            public string Directors { get; set; }
            public List<DirectorList> DirectorList { get; set; }
            public string Writers { get; set; }
            public List<WriterList> WriterList { get; set; }
            public string Stars { get; set; }
            public List<StarList> StarList { get; set; }
            public List<ActorList> ActorList { get; set; }
            public FullCast FullCast { get; set; }
            public string Genres { get; set; }
            public List<GenreList> GenreList { get; set; }
            public string Companies { get; set; }
            public List<CompanyList> CompanyList { get; set; }
            public string Countries { get; set; }
            public List<CountryList> CountryList { get; set; }
            public string Languages { get; set; }
            public List<LanguageList> LanguageList { get; set; }
            public string ContentRating { get; set; }
            public string ImDbRating { get; set; }
            public string ImDbRatingVotes { get; set; }
            public string MetacriticRating { get; set; }
            public Ratings Ratings { get; set; }
            public Wikipedia Wikipedia { get; set; }
            public Poster Posters { get; set; }
            public Images Images { get; set; }
            public Trailer Trailer { get; set; }
            public BoxOffice BoxOffice { get; set; }
            public string Tagline { get; set; }
            public string Keywords { get; set; }
            public List<string> KeywordList { get; set; }
            public List<Similar> Similars { get; set; }
            public TvSeriesInfo TvSeriesInfo { get; set; }
            public TvEpisodeInfo TvEpisodeInfo { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class Similar
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Image { get; set; }
            public string ImDbRating { get; set; }
        }

        public class StarList
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Trailer
        {
            public string ImDbId { get; set; }
            public string Title { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public string VideoId { get; set; }
            public string VideoTitle { get; set; }
            public string VideoDescription { get; set; }
            public string ThumbnailUrl { get; set; }
            public string UploadDate { get; set; }
            public string Link { get; set; }
            public string LinkEmbed { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class TvEpisodeInfo
        {
            public string SeriesId { get; set; }
            public string SeriesTitle { get; set; }
            public string SeriesFullTitle { get; set; }
            public string SeriesYear { get; set; }
            public string SeriesYearEnd { get; set; }
            public string SeasonNumber { get; set; }
            public string EpisodeNumber { get; set; }
            public string PreviousEpisodeId { get; set; }
            public string NextEpisodeId { get; set; }
        }

        public class TvSeriesInfo
        {
            public string YearEnd { get; set; }
            public string Creators { get; set; }
            public List<CreatorList> CreatorList { get; set; }
            public List<string> Seasons { get; set; }
        }

        public class Wikipedia
        {
            public string ImDbId { get; set; }
            public string Title { get; set; }
            public string FullTitle { get; set; }
            public string Type { get; set; }
            public string Year { get; set; }
            public string Language { get; set; }
            public string TitleInLanguage { get; set; }
            public string Url { get; set; }
            public PlotShort PlotShort { get; set; }
            public PlotFull PlotFull { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class WriterList
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Writers
        {
            public string Job { get; set; }
            public List<Item> Items { get; set; }
        }

    }
}
