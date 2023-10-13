using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
                new MovieViewModel { Id = 1, Name = "Tom sawyer's The Quest for Gold", Rating = 4.1, ReleaseYear = 2022, Genre = "Adventure/family",imageUrl = "~/images/tom sawyer.jpg",trailer = "https://www.youtube.com/embed/EqjWKr8c-Bo?si=D70E3NSGgCCJ8epW",
                    description = "A risk-averse English teacher is forced to face her fears when several of her students venture alone into the southern wilderness in search of Tom Sawyer's long-lost gold.\r\nDirector: Kirk Harris" },
                new MovieViewModel { Id = 2, Name = "jujutsu kaisen 0", Rating = 4.9, ReleaseYear = 2021, Genre = "Fantasy/Action",imageUrl = "~/images/jjk0.jpeg",trailer = "https://www.youtube.com/embed/3CntN98B84g?si=eahwed-gvY-XRnfy" ,
                    description = "Yuta Okkotsu gains control of an extremely powerful, cursed spirit and gets enrolled in the Tokyo Prefectural Jujutsu High School by sorcerers to help him control his power and keep an eye on him." },
                new MovieViewModel { Id = 3, Name = "One piece: Film Red ", Rating = 4.9, ReleaseYear = 2022, Genre = "Adventure/Action" , imageUrl = "~/images/OP red.jpg",trailer = "https://www.youtube.com/embed/AmTUaFdTETc?si=6DOsQy2-VTMV11S5",
                    description = "Uta is a beloved singer, renowned for concealing her own identity when performing. Her voice is described as \"otherworldly.\" Now, for the first time ever, Uta will reveal herself to the world at a live concert." },
                new MovieViewModel { Id = 4, Name = "A Whisker Away", Rating = 4.7, ReleaseYear = 2020, Genre = "Fantasy/Romance" , imageUrl = "~/images/whisker.jpg",trailer = "https://www.youtube.com/embed/aXc9DVfLTGo?si=96BulClKquxJtRIf",
                    description = "The line between human and animal starts to blur when a peculiar girl transforms herself into a cat to gain the attention of her crush." },
                new MovieViewModel { Id = 5, Name = "Suzume", Rating = 4.7, ReleaseYear = 2022, Genre = "Adventure/Animation" , imageUrl = "~/images/suzume.jpg",trailer = "https://www.youtube.com/embed/5pTcio2hTSw?si=YM6kOjucoFnbqBmi",
                    description = "As the skies turn red and the planet trembles, Japan stands on the brink of disaster. However, a determined teenager named Suzume sets out on a mission to save her country. Able to see supernatural forces that others cannot, it's up to her to close the mysterious doors that are spreading chaos across the land. A perilous journey awaits as the fate of Japan rests on her shoulders." },
                new MovieViewModel { Id = 6, Name = "Weathering With You", Rating = 4.9, ReleaseYear = 2019, Genre = "Fantasy/Drama" , imageUrl = "~/images/Weathering.jpg",trailer = "https://www.youtube.com/embed/Q6iK6DjV_iE?si=rrmBITIYqMu2u3db",
                    description = "Set during a period of exceptionally rainy weather, high-school boy Hodaka Morishima runs away from his troubled rural home to Tokyo and befriends an orphan girl who can manipulate the weather." },
                new MovieViewModel { Id = 7, Name = "My Neighbor Totoro", Rating = 4.1, ReleaseYear = 1988, Genre = "Fantasy/Animation" , imageUrl = "~/images/totoro.jpg",trailer = "https://www.youtube.com/embed/92a7Hj0ijLs?si=fqcRbAzwJQHLcHNs",
                    description = "This acclaimed animated tale by director Hayao Miyazaki follows schoolgirl Satsuke and her younger sister, Mei, as they settle into an old country house with their father and wait for their mother to recover from an illness in an area hospital. As the sisters explore their new home, they encounter and befriend playful spirits in their house and the nearby forest, most notably the massive cuddly creature known as Totoro." },
                new MovieViewModel { Id = 8, Name = "The Tale of Princess Kaguya", Rating = 4.8, ReleaseYear = 2013, Genre = "Drama/Fantasy" , imageUrl = "~/images/kaguya.jpg",trailer = "https://www.youtube.com/embed/W71mtorCZDw?si=ppmHg5m_2G6AkYjk",
                    description = "A tiny nymph found inside a bamboo stalk grows into a beautiful and desirable young woman. She orders her suitors to prove their love by completing a series of near-impossible tasks." },
                new MovieViewModel { Id = 9, Name = "Grave of the Fireflies", Rating = 4.9, ReleaseYear = 1988, Genre = "Drama/War" , imageUrl = "~/images/grave.jpg",trailer = "https://www.youtube.com/embed/4vPeTSRd580?si=e6KiSSPxi5RDlI6T",
                    description = "A devastating meditation on the human cost of war, this animated tale follows Seita (Tsutomu Tatsumi), a teenager charged with the care of his younger sister, Setsuko (Ayano Shiraishi), after an American firebombing during World War II separates the two children from their parents. Their tale of survival is as heartbreaking as it is true to life. The siblings rely completely on each other and struggle against all odds to stay together and stay alive." },
                new MovieViewModel { Id = 10, Name = "Spirited Away", Rating = 4.8, ReleaseYear = 2001, Genre = "Fantasy/Adventure" , imageUrl = "~/images/spireted.png",trailer = "https://www.youtube.com/embed/ByXuk9QqQkk?si=PsPG8mJq-e_ko2v6",
                    description = "In this animated feature by noted Japanese director Hayao Miyazaki, 10-year-old Chihiro (Rumi Hiiragi) and her parents (Takashi Naitô, Yasuko Sawaguchi) stumble upon a seemingly abandoned amusement park. After her mother and father are turned into giant pigs, Chihiro meets the mysterious Haku (Miyu Irino), who explains that the park is a resort for supernatural beings who need a break from their time spent in the earthly realm, and that she must work there to free herself and her parents." },
                new MovieViewModel { Id = 11, Name = "Boruto: Naruto the Movie", Rating = 4.1, ReleaseYear = 2015, Genre = "Action/Adventure" , imageUrl = "~/images/boruto.png",trailer = "https://www.youtube.com/embed/Qyonn5Vbg7s?si=dTWRACM0j02RI2cx",
                    description = "Several years after the end of the Shinobi War, Naruto's son Boruto is about to enter the Chûnin exams alongside Sarada Uchiha and the mysterious Mitsuki." },
                new MovieViewModel { Id = 12, Name = "Howl's Moving Castle", Rating = 4.8, ReleaseYear = 2004, Genre = "Drama/Fantasy " , imageUrl = "~/images/moving castle.jpg",trailer = "https://www.youtube.com/embed/iwROgK94zcM?si=_58hYyJaH_cuUNwD",
                    description = "Sophie (Emily Mortimer) has an uneventful life at her late father's hat shop, but all that changes when she befriends wizard Howl (Christian Bale), who lives in a magical flying castle. However, the evil Witch of Waste (Lauren Bacall) takes issue with their budding relationship and casts a spell on young Sophie, which ages her prematurely. Now Howl must use all his magical talents to battle the jealous hag and return Sophie to her former youth and beauty." },
                new MovieViewModel { Id = 13, Name = "Kiki's Delivery Service", Rating = 4.8, ReleaseYear = 1989, Genre = "Drama/Adventure" , imageUrl = "~/images/kiki.jpg",trailer = "https://www.youtube.com/embed/4bG17OYs-GA?si=mSZV0w_mtwf4Czm8",
                    description = "In this anime feature, 13-year-old Kiki moves to a seaside town with her talking cat, Jiji, to spend a year alone, in accordance with her village's tradition for witches in training. After learning to control her broomstick, Kiki sets up a flying courier service and soon becomes a fixture in the community. But when the insecure young witch begins questioning herself and loses her magic abilities, she must overcome her self-doubt to get her powers back." },
                new MovieViewModel { Id = 14, Name = "Tangled", Rating = 4.8, ReleaseYear = 2010, Genre = "Family/Musical" , imageUrl = "~/images/tangled.jpg",trailer = "https://www.youtube.com/embed/ycoY201RTRo?si=HEOa_EAl63_1NQJs",
                    description = "Disney animation of a classic tale. Beautiful princess Rapunzel has been locked away in a tower since she was captured as a baby by an old hag. Her magical long blonde hair has the power to provide eternal youth, and the evil Gothel uses this power to keep her young. At the age of 18, Rapunzel becomes curious about the outside world, and when a prince uses her tower as a refuge, she asks him to help her escape." },
                new MovieViewModel { Id = 15, Name = "Rise of the Guardians", Rating = 4.8, ReleaseYear = 2012, Genre = "Family/Fantasy" , imageUrl = "~/images/rise.jpg",trailer = "https://www.youtube.com/embed/aPLiBxhoug0?si=Ivu9XjWqUNwdjcOA",
                    description = "Generation after generation, immortal Guardians like Santa Claus (Peter Ramsey), the Easter Bunny (Nancy Bernstein) and the Tooth Fairy (Christina Steinberg) protect the world's children from darkness and despair." },
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

