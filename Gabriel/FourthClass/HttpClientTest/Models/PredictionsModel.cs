using Newtonsoft.Json;

namespace HttpClientTest.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class _015
    {
        public object total { get; set; }
        public object percentage { get; set; }
    }

    public class _106120
    {
        public object total { get; set; }
        public object percentage { get; set; }
    }

    public class _1630
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class _3145
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class _4660
    {
        public object total { get; set; }
        public object percentage { get; set; }
    }

    public class _6175
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class _7690
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class _91105
    {
        public object total { get; set; }
        public object percentage { get; set; }
    }

    public class Against
    {
        public int total { get; set; }
        public string average { get; set; }
        public Minute minute { get; set; }
        public int home { get; set; }
        public int away { get; set; }
    }

    public class Att
    {
        public string home { get; set; }
        public string away { get; set; }
    }

    public class Average
    {
        public string home { get; set; }
        public string away { get; set; }
        public string total { get; set; }
    }

    public class Away
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public Last5 last_5 { get; set; }
        public League league { get; set; }
        public bool? winner { get; set; }
    }

    public class Biggest
    {
        public Streak streak { get; set; }
        public Wins wins { get; set; }
        public Loses loses { get; set; }
        public Goals goals { get; set; }
    }

    public class Cards
    {
        public Yellow yellow { get; set; }
        public Red red { get; set; }
    }

    public class CleanSheet
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Comparison
    {
        public Form form { get; set; }
        public Att att { get; set; }
        public Def def { get; set; }
        public PoissonDistribution poisson_distribution { get; set; }
        public H2h h2h { get; set; }
        public Goals goals { get; set; }
        public Total total { get; set; }
    }

    public class Def
    {
        public string home { get; set; }
        public string away { get; set; }
    }

    public class Draws
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Extratime
    {
        public object home { get; set; }
        public object away { get; set; }
    }

    public class FailedToScore
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Fixture
    {
        public int id { get; set; }
        public string referee { get; set; }
        public string timezone { get; set; }
        public DateTime date { get; set; }
        public int timestamp { get; set; }
        public Periods periods { get; set; }
        public Venue venue { get; set; }
        public Status status { get; set; }
    }

    public class Fixtures
    {
        public Played played { get; set; }
        public Wins wins { get; set; }
        public Draws draws { get; set; }
        public Loses loses { get; set; }
    }

    public class For
    {
        public int total { get; set; }
        public string average { get; set; }
        public Minute minute { get; set; }
        public int home { get; set; }
        public int away { get; set; }
    }

    public class Form
    {
        public string home { get; set; }
        public string away { get; set; }
    }

    public class Fulltime
    {
        public int home { get; set; }
        public int away { get; set; }
    }

    public class Goals
    {
        public string home { get; set; }
        public string away { get; set; }
        public For @for { get; set; }
        public Against against { get; set; }
    }

    public class H2h
    {
        public string home { get; set; }
        public string away { get; set; }
        public Fixture fixture { get; set; }
        public League league { get; set; }
        public Teams teams { get; set; }
        public Goals goals { get; set; }
        public Score score { get; set; }
    }

    public class Halftime
    {
        public int home { get; set; }
        public int away { get; set; }
    }

    public class Home
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public Last5 last_5 { get; set; }
        public League league { get; set; }
        public bool? winner { get; set; }
    }

    public class Last5
    {
        public string form { get; set; }
        public string att { get; set; }
        public string def { get; set; }
        public Goals goals { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string logo { get; set; }
        public string flag { get; set; }
        public int season { get; set; }
        public string form { get; set; }
        public Fixtures fixtures { get; set; }
        public Goals goals { get; set; }
        public Biggest biggest { get; set; }
        public CleanSheet clean_sheet { get; set; }
        public FailedToScore failed_to_score { get; set; }
        public Penalty penalty { get; set; }
        public List<object> lineups { get; set; }
        public Cards cards { get; set; }
        public string round { get; set; }
    }

    public class Loses
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Minute
    {
        [JsonProperty("0-15")]
        public _015 _015 { get; set; }

        [JsonProperty("16-30")]
        public _1630 _1630 { get; set; }

        [JsonProperty("31-45")]
        public _3145 _3145 { get; set; }

        [JsonProperty("46-60")]
        public _4660 _4660 { get; set; }

        [JsonProperty("61-75")]
        public _6175 _6175 { get; set; }

        [JsonProperty("76-90")]
        public _7690 _7690 { get; set; }

        [JsonProperty("91-105")]
        public _91105 _91105 { get; set; }

        [JsonProperty("106-120")]
        public _106120 _106120 { get; set; }
    }

    public class Missed
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class Parameters
    {
        public string fixture { get; set; }
    }

    public class Penalty
    {
        public Scored scored { get; set; }
        public Missed missed { get; set; }
        public int total { get; set; }
        public object home { get; set; }
        public object away { get; set; }
    }

    public class Percent
    {
        public string home { get; set; }
        public string draw { get; set; }
        public string away { get; set; }
    }

    public class Periods
    {
        public int first { get; set; }
        public int second { get; set; }
    }

    public class Played
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class PoissonDistribution
    {
        public string home { get; set; }
        public string away { get; set; }
    }

    public class Predictions
    {
        public Winner winner { get; set; }
        public bool win_or_draw { get; set; }
        public string under_over { get; set; }
        public Goals goals { get; set; }
        public string advice { get; set; }
        public Percent percent { get; set; }
    }

    public class Red
    {
        [JsonProperty("0-15")]
        public _015 _015 { get; set; }

        [JsonProperty("16-30")]
        public _1630 _1630 { get; set; }

        [JsonProperty("31-45")]
        public _3145 _3145 { get; set; }

        [JsonProperty("46-60")]
        public _4660 _4660 { get; set; }

        [JsonProperty("61-75")]
        public _6175 _6175 { get; set; }

        [JsonProperty("76-90")]
        public _7690 _7690 { get; set; }

        [JsonProperty("91-105")]
        public _91105 _91105 { get; set; }

        [JsonProperty("106-120")]
        public _106120 _106120 { get; set; }
    }

    public class Response
    {
        public Predictions predictions { get; set; }
        public League league { get; set; }
        public Teams teams { get; set; }
        public Comparison comparison { get; set; }
        public List<H2h> h2h { get; set; }
    }

    public class PredictionsModel
    {
        public string get { get; set; }
        public Parameters parameters { get; set; }
        public List<object> errors { get; set; }
        public int results { get; set; }
        public Paging paging { get; set; }
        public List<Response> response { get; set; }
    }

    public class Score
    {
        public Halftime halftime { get; set; }
        public Fulltime fulltime { get; set; }
        public Extratime extratime { get; set; }
        public Penalty penalty { get; set; }
    }

    public class Scored
    {
        public int total { get; set; }
        public string percentage { get; set; }
    }

    public class Status
    {
        public string @long { get; set; }
        public string @short { get; set; }
        public int elapsed { get; set; }
    }

    public class Streak
    {
        public int wins { get; set; }
        public int draws { get; set; }
        public int loses { get; set; }
    }

    public class Teams
    {
        public Home home { get; set; }
        public Away away { get; set; }
    }

    public class Total
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Venue
    {
        public object id { get; set; }
        public string name { get; set; }
        public object city { get; set; }
    }

    public class Winner
    {
        public int id { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
    }

    public class Wins
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Yellow
    {
        [JsonProperty("0-15")]
        public _015 _015 { get; set; }

        [JsonProperty("16-30")]
        public _1630 _1630 { get; set; }

        [JsonProperty("31-45")]
        public _3145 _3145 { get; set; }

        [JsonProperty("46-60")]
        public _4660 _4660 { get; set; }

        [JsonProperty("61-75")]
        public _6175 _6175 { get; set; }

        [JsonProperty("76-90")]
        public _7690 _7690 { get; set; }

        [JsonProperty("91-105")]
        public _91105 _91105 { get; set; }

        [JsonProperty("106-120")]
        public _106120 _106120 { get; set; }
    }


}