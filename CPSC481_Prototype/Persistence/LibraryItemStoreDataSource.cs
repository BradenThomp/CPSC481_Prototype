using CPSC481_Prototype.Models;

namespace CPSC481_Prototype.Persistence
{
    public class LibraryItemStoreDataSource
    {
        private Dictionary<int, LibraryItem> _store = new Dictionary<int, LibraryItem>();

        public LibraryItemStoreDataSource()
        {
            Populate();
        }

        public Dictionary<int, LibraryItem> GetData() => _store;

        private void Populate()
        {
            _store.Add(1, new LibraryItem
            {
                Id = 1,
                ImageSource = "images/Dune.jpg",
                Title = "Dune",
                Author = "Frank Herbert",
                Length = "658 Pages",
                Format = "Hardcover",
                Publisher = "Chilton Books",
                PublicationDate = "August 1965",
                Summary = "Set on the desert planet Arrakis, Dune is the story of the boy Paul Atreides, heir to a noble family tasked with ruling an inhospitable world where the only thing of value is the “spice” melange, a drug capable of extending life and enhancing consciousness. Coveted across the known universe, melange is a prize worth killing for....\r\n\r\n                    When House Atreides is betrayed, the destruction of Paul’s family will set the boy on a journey toward a destiny greater than he could ever have imagined. And as he evolves into the mysterious man known as Muad’Dib, he will bring to fruition humankind’s most ancient and unattainable dream.\r\n\r\n                    A stunning blend of adventure and mysticism, environmentalism and politics, Dune won the first Nebula Award, shared the Hugo Award, and formed the basis of what is undoubtedly the grandest epic in science fiction.\r\n",
                Genres = new List<string>() { "Science Fiction", "Fiction", "Fantasy", "Space Opera" },
                CopiesAvailable = 1,
                DeweyDecimal = 813.54,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(2, new LibraryItem
            {
                Id = 2,
                ImageSource = "images/1984.jpg",
                Title = "1984",
                Author = "George Orwell",
                Length = "368 Pages",
                Format = "Paperback",
                Publisher = "Secker & Warburg",
                PublicationDate = "January 1949",
                Summary = "The new novel by George Orwell is the major work towards which all his previous writing has pointed. Critics have hailed it as his \"most solid, most brilliant\" work. Though the story of Nineteen Eighty-Four takes place thirty-five years hence, it is in every sense timely. The scene is London, where there has been no new housing since 1950 and where the city-wide slums are called Victory Mansions. Science has abandoned Man for the State. As every citizen knows only too well, war is peace.\r\n\r\nTo Winston Smith, a young man who works in the Ministry of Truth (Minitru for short), come two people who transform this life completely. One is Julia, whom he meets after she hands him a slip reading, \"I love you.\" The other is O'Brien, who tells him, \"We shall meet in the place where there is no darkness.\" The way in which Winston is betrayed by the one and, against his own desires and instincts, ultimately betrays the other, makes a story of mounting drama and suspense.",
                Genres = new List<string>() { "Classics", "Fiction", "Science Fiction", "Dystopia" },
                CopiesAvailable = 0,
                DeweyDecimal = 823.912,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(3, new LibraryItem
            {
                Id = 3,
                ImageSource = "images/2001.jpg",
                Title = "2001: A Space Odyssey",
                Author = "Arthur C. Clarke",
                Length = "297 Pages",
                Format = "Paperback",
                Publisher = "Roc",
                PublicationDate = "April 1968",
                Summary = "So great are the implications of this discovery that for the first time men are sent out deep into our solar system.\r\n\r\nBut long before their destination is reached, things begin to go horribly, inexplicably wrong...\r\n\r\nOne of the greatest-selling science fiction novels of our time, this classic book will grip you to the very end.",
                Genres = new List<string>() { "Classics", "Fiction", "Science Fiction", "Space" },
                CopiesAvailable = 2,
                DeweyDecimal = 823.194,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(4, new LibraryItem
            {
                Id = 4,
                ImageSource = "images/451.jpg",
                Title = "Fahrenheit 451",
                Author = "Ray Bradbury",
                Length = "208 Pages",
                Format = "Paperback",
                Publisher = "Roc",
                PublicationDate = "October 1953",
                Summary = "Guy Montag is a fireman. His job is to destroy the most illegal of commodities, the printed book, along with the houses in which they are hidden. Montag never questions the destruction and ruin his actions produce, returning each day to his bland life and wife, Mildred, who spends all day with her television “family.” But when he meets an eccentric young neighbor, Clarisse, who introduces him to a past where people didn’t live in fear and to a present where one sees the world through the ideas in books instead of the mindless chatter of television, Montag begins to question everything he has ever known.",
                Genres = new List<string>() { "Classics", "Fiction", "Science Fiction", "Dystopia" },
                CopiesAvailable = 2,
                DeweyDecimal = 813.54,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(5, new LibraryItem
            {
                Id = 5,
                ImageSource = "images/BraveNewWorld.jpg",
                Title = "Brave New World",
                Author = "Aldous Huxley",
                Length = "268 Pages",
                Format = "Paperback",
                Publisher = "HarperPerennial",
                PublicationDate = "January 1932",
                Summary = "Brave New World is a dystopian novel by English author Aldous Huxley, written in 1931 and published in 1932. Largely set in a futuristic World State, inhabited by genetically modified citizens and an intelligence-based social hierarchy, the novel anticipates huge scientific advancements in reproductive technology, sleep-learning, psychological manipulation and classical conditioning that are combined to make a dystopian society which is challenged by only a single individual: the story's protagonist.",
                Genres = new List<string>() { "Classics", "Fiction", "Science Fiction", "Dystopia" },
                CopiesAvailable = 1,
                DeweyDecimal = 823.912,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(6, new LibraryItem
            {
                Id = 6,
                ImageSource = "images/Forever.jpg",
                Title = "The Forever War",
                Author = "Joe Haldeman",
                Length = "278 Pages",
                Format = "Paperback",
                Publisher = "Voyager",
                PublicationDate = "December 1974",
                Summary = "The Earth's leaders have drawn a line in the interstellar sand—despite the fact that the fierce alien enemy that they would oppose is inscrutable, unconquerable, and very far away. A reluctant conscript drafted into an elite Military unit, Private William Mandella has been propelled through space and time to fight in the distant thousand-year conflict; to perform his duties without rancor and even rise up through military ranks. Pvt. Mandella is willing to do whatever it takes to survive the ordeal and return home. But \"home\" may be even more terrifying than battle, because, thanks to the time dilation caused by space travel, Mandella is aging months while the Earth he left behind is aging centuries.",
                Genres = new List<string>() { "War", "Military Fiction", "Space Opera" },
                CopiesAvailable = 1,
                DeweyDecimal = 813.54,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(7, new LibraryItem
            {
                Id = 7,
                ImageSource = "images/Foundation.jpg",
                Title = "Foundation",
                Author = "Isaac Asimov",
                Length = "244 Pages",
                Format = "Hardcover",
                Publisher = "Bantam",
                PublicationDate = "August 1951",
                Summary = "For twelve thousand years the Galactic Empire has ruled supreme. Now it is dying. But only Hari Seldon, creator of the revolutionary science of psychohistory, can see into the future -- to a dark age of ignorance, barbarism, and warfare that will last thirty thousand years. To preserve knowledge and save mankind, Seldon gathers the best minds in the Empire -- both scientists and scholars -- and brings them to a bleak planet at the edge of the Galaxy to serve as a beacon of hope for a future generations. He calls his sanctuary the Foundation.\r\n\r\nBut soon the fledgling Foundation finds itself at the mercy of corrupt warlords rising in the wake of the receding Empire. Mankind's last best hope is faced with an agonizing choice: submit to the barbarians and be overrun -- or fight them and be destroyed.",
                Genres = new List<string>() { "Classics", "Fantasy", "Science Fiction", "Space Opera" },
                CopiesAvailable = 1,
                DeweyDecimal = 813.53,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(8, new LibraryItem
            {
                Id = 8,
                ImageSource = "images/gods.jpg",
                Title = "Waking Gods",
                Author = "Sylvain Neuvel",
                Length = "336 Pages",
                Format = "Hardcover",
                Publisher = "Del Rey",
                PublicationDate = "April 2017",
                Summary = "As a child, Rose Franklin made an astonishing discovery: a giant metallic hand, buried deep within the earth. As an adult, she’s dedicated her brilliant scientific career to solving the mystery that began that fateful day: Why was a titanic robot of unknown origin buried in pieces around the world? Years of investigation have produced intriguing answers—and even more perplexing questions. But the truth is closer than ever before when a second robot, more massive than the first, materializes and lashes out with deadly force.\r\n\r\nNow humankind faces a nightmare invasion scenario made real, as more colossal machines touch down across the globe. But Rose and her team at the Earth Defense Corps refuse to surrender. They can turn the tide if they can unlock the last secrets of an advanced alien technology. The greatest weapon humanity wields is knowledge in a do-or-die battle to inherit the Earth . . . and maybe even the stars.",
                Genres = new List<string>() { "Fantasy", "Science Fiction", "Aliens" },
                CopiesAvailable = 3,
                DeweyDecimal = 813.60,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(9, new LibraryItem
            {
                Id = 9,
                ImageSource = "images/Goodnightmoon.jpg",
                Title = "Goodnight Moon",
                Author = "Margaret Wise Brown, Clement Hurd (Illustrator)",
                Length = "32 Pages",
                Format = "Hardcover",
                Publisher = "HarperCollins",
                PublicationDate = "September 1943",
                Summary = "In a great green room, tucked away in bed, is a little bunny. \"Goodnight room, goodnight moon.\" And to all the familiar things in the softly lit room -- to the picture of the three little bears sitting on chairs, to the clocks and his socks, to the mittens and the kittens, to everything one by one -- the little bunny says goodnight.\r\n\r\nIn this classic of children's literature, beloved by generations of readers and listeners, the quiet poetry of the words and the gentle, lulling illustrations combine to make a perfect book for the end of the day.",
                Genres = new List<string>() { "Childrens", "Picture Books", "Kids" },
                CopiesAvailable = 3,
                DeweyDecimal = 811.54,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(10, new LibraryItem
            {
                Id = 10,
                ImageSource = "images/Harry_Potter_and_the_Chamber_of_Secrets.jpg",
                Title = "Harry Potter and the Chamber of Secrets",
                Author = "J.K. Rowling",
                Length = "341 Pages",
                Format = "Hardcover",
                Publisher = "Arthur A. Levine Books",
                PublicationDate = "July 1998",
                Summary = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange impish creature who says that if Harry returns to Hogwarts, disaster will strike.\r\n\r\nAnd strike it does. For in Harry’s second year at Hogwarts, fresh torments and horrors arise, including an outrageously stuck-up new professor and a spirit who haunts the girls’ bathroom. But then the real trouble begins – someone is turning Hogwarts students to stone. Could it be Draco Malfoy, a more poisonous rival than ever? Could it possibly be Hagrid, whose mysterious past is finally told? Or could it be the one everyone at Hogwarts most suspects… Harry Potter himself!",
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = 823.91,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(11, new LibraryItem
            {
                Id = 11,
                ImageSource = "images/Harry_Potter_and_the_Philosopher's_Stone_Book_Cover.jpg",
                Title = "Harry Potter and the Philosopher's Stone",
                Author = "J.K. Rowling",
                Length = "223 Pages",
                Format = "Hardcover",
                Publisher = "Bloomsbury Publishing",
                PublicationDate = "June 1997",
                Summary = "Harry Potter thinks he is an ordinary boy - until he is rescued by an owl, taken to Hogwarts School of Witchcraft and Wizardry, learns to play Quidditch and does battle in a deadly duel. The Reason ... HARRY POTTER IS A WIZARD!",
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = 823.91,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(12, new LibraryItem
            {
                Id = 12,
                ImageSource = "images/Harry_Potter_and_the_Prisoner_of_Azkaban.jpg",
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = "J.K. Rowling",
                Length = "435 Pages",
                Format = "Hardcover",
                Publisher = "Scholastic Inc.",
                PublicationDate = "May 2004",
                Summary = "Harry Potter, along with his best friends, Ron and Hermione, is about to start his third year at Hogwarts School of Witchcraft and Wizardry. Harry can't wait to get back to school after the summer holidays. (Who wouldn't if they lived with the horrible Dursleys?) But when Harry gets to Hogwarts, the atmosphere is tense. There's an escaped mass murderer on the loose, and the sinister prison guards of Azkaban have been called in to guard the school...",
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = 823.91,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(13, new LibraryItem
            {
                Id = 13,
                ImageSource = "images/Holes.jpg",
                Title = "Holes",
                Author = "Louis Sachar",
                Length = "233 Pages",
                Format = "Hardcover",
                Publisher = "Scholastic Inc.",
                PublicationDate = "August 1998",
                Summary = "Stanley Yelnats is under a curse. A curse that began with his no-good-dirty-rotten-pig-stealing-great-great-grandfather and has since followed generations of Yelnats. Now Stanley has been unjustly sent to a boys’ detention center, Camp Green Lake, where the boys build character by spending all day, every day digging holes exactly five feet wide and five feet deep. There is no lake at Camp Green Lake. But there are an awful lot of holes.\r\n",
                Genres = new List<string>() { "Shia Labeouf", "Young Adult", "Childrens", "Fiction", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = 813.54,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(14, new LibraryItem
            {
                Id = 14,
                ImageSource = "images/Hyperion.jpeg",
                Title = "Hyperion",
                Author = "Dan Simmons",
                Length = "500 Pages",
                Format = "Hardcover",
                Publisher = "Bantam Doubleday Dell Publishing Group",
                PublicationDate = "May 1989",
                Summary = "On the world called Hyperion, beyond the law of the Hegemony of Man, there waits the creature called the Shrike. There are those who worship it. There are those who fear it. And there are those who have vowed to destroy it. In the Valley of the Time Tombs, where huge, brooding structures move backward through time, the Shrike waits for them all. On the eve of Armageddon, with the entire galaxy at war, seven pilgrims set forth on a final voyage to Hyperion seeking the answers to the unsolved riddles of their lives. Each carries a desperate hope—and a terrible secret. And one may hold the fate of humanity in his hands.",
                Genres = new List<string>() { "Science Fiction", "Fiction", "Fantasy", "Space Opera" },
                CopiesAvailable = 1,
                DeweyDecimal = 823.54,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(15, new LibraryItem
            {
                Id = 15,
                ImageSource = "images/TheTwits.jpg",
                Title = "The Twits",
                Author = "Roald Dahl, Quentin Blake (Illustrator)",
                Length = "96 Pages",
                Format = "Hardcover",
                Publisher = "Puffin Books",
                PublicationDate = "January 1980",
                Summary = "How do you outwit a Twit? Mr. and Mrs. Twit are the smelliest, ugliest people in the world. They hate everything -- except playing mean jokes on each other, catching innocent birds to put in their Bird Pies, and making their caged monkeys, the Muggle-Wumps, stand on their heads all day. But the Muggle-Wumps have had enough. They don't just want out, they want revenge.",
                Genres = new List<string>() { "Childrens", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = 811.54,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(16, new LibraryItem
            {
                Id = 16,
                ImageSource = "images/TheWitches.jpg",
                Title = "The Witches",
                Author = "Roald Dahl, Quentin Blake (Illustrator)",
                Length = "208 Pages",
                Format = "Hardcover",
                Publisher = "Puffin Books",
                PublicationDate = "October 1983",
                Summary = "This is not a fairy-tale. This is about real witches. Real witches don't ride around on broomsticks. They don't even wear black cloaks and hats. They are vile, cunning, detestable creatures who disguise themselves as nice, ordinary ladies. So how can you tell when you're face to face with one? Well, if you don't know yet you'd better find out quickly-because there's nothing a witch loathes quite as much as children and she'll wield all kinds of terrifying powers to get rid of them.",
                Genres = new List<string>() { "Childrens", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = 811.54,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(17, new LibraryItem
            {
                Id = 17,
                ImageSource = "images/King_Gizzard_and_the_Lizard_Wizard_-_Fishing_for_Fishies.png",
                Title = "Fishing for Fishies",
                Author = "King Gizzard and the Lizard Wizard",
                Length = "41:56",
                Format = "Vinyl",
                Publisher = "Flightless",
                PublicationDate = "April 2019",
                Summary = "Fishing for Fishies is the fourteenth studio album by Australian psychedelic rock band King Gizzard & the Lizard Wizard. It was released on 26 April 2019 by Flightless and ATO Records.[4] The announcement of the album was accompanied by the release of the title track and its video.[5] ",
                Genres = new List<string>() { "Boogie Rock", "Blues Rock" },
                CopiesAvailable = 1,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Music
            });
            _store.Add(18, new LibraryItem
            {
                Id = 18,
                ImageSource = "images/lz2.jpg",
                Title = "Led Zeppelin II",
                Author = "Led Zeppelin",
                Length = "41:38",
                Format = "Vinyl",
                Publisher = "Atlantic",
                PublicationDate = "October 1969",
                Summary = "Led Zeppelin II is the second studio album by the English rock band Led Zeppelin, released on 22 October 1969 in the United States and on 31 October 1969 in the United Kingdom by Atlantic Records. Recording sessions for the album took place at several locations in both the United Kingdom and North America from January to August 1969. The album's production was credited to the band's lead guitarist and songwriter Jimmy Page, and it was also Led Zeppelin's first album on which Eddie Kramer served as engineer.",
                Genres = new List<string>() { "Hard Rock", "Heavy Metal", "Blues Rock" },
                CopiesAvailable = 1,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Music
            });
            _store.Add(19, new LibraryItem
            {
                Id = 19,
                ImageSource = "images/AzkbnMovie.jpg",
                Title = "Harry Potter and the Prisoner of Azkaban",
                Author = "Alfonso Cuarón",
                Length = "2h19m",
                Format = "DVD",
                Publisher = "Warner Bros. Pictures",
                PublicationDate = "June 2004",
                Summary = "Harry Potter's (Daniel Radcliffe) third year at Hogwarts starts off badly when he learns deranged killer Sirius Black (Gary Oldman) has escaped from Azkaban prison and is bent on murdering the teenage wizard. While Hermione's (Emma Watson) cat torments Ron's (Rupert Grint) sickly rat, causing a rift among the trio, a swarm of nasty Dementors is sent to protect the school from Black. A mysterious new teacher helps Harry learn to defend himself, but what is his secret tie to Sirius Black?",
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids" },
                CopiesAvailable = 1,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Movie
            });
        }
    }
}
