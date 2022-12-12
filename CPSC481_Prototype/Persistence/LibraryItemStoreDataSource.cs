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
                Genres = new List<string>() { "Science Fiction", "Adventure", "Fiction", "Fantasy", "Space Opera" },
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
                Genres = new List<string>() { "Classics", "Fiction", "Science Fiction", "Space", "Fantasy", "Adventure" },
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
                Genres = new List<string>() { "War", "Fiction", "Space Opera", "Action" },
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
                Genres = new List<string>() { "Fantasy", "Science Fiction", "Aliens", "Action" },
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
                Genres = new List<string>() { "Children", "Picture Books", "Kids" },
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
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids", "Adventure" },
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
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids", "Adventure" },
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
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids", "Adventure" },
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
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids", "Adventure" },
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
                Genres = new List<string>() { "Science Fiction", "Fiction", "Fantasy", "Space Opera", "Action" },
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
                Genres = new List<string>() { "Magic", "Fantasy", "Fiction", "Kids", "Adventure" },
                CopiesAvailable = 1,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Movie
            });
            _store.Add(20, new LibraryItem
            {
                Id = 20,
                ImageSource = "images/20.jpg",
                Title = "God: An Anatomy",
                Author = "Francesca Stavrakopoulou",
                Length = "155 Pages",
                Format = "Hardcover",
                Publisher = "XYZ Publishers",
                PublicationDate = "June 2020",
                Summary = "An astonishing and revelatory history that re-presents God as he was originally envisioned by ancient worshippers--with a distinctly male body, and with superhuman powers, earthly passions, and a penchant for the fantastic and monstrous.",
                Genres = new List<string>() { "Non-fiction", "Mystery", "Religion" },
                CopiesAvailable = 5,
                DeweyDecimal = 200.51,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(21, new LibraryItem
            {
                Id = 21,
                ImageSource = "images/21.jpg",
                Title = "Queen of Our Times: The Life of Elizabeth II",
                Author = "Robert Hardman",
                Length = "371 Pages",
                Format = "Paperback",
                Publisher = " The Ting Go Skraa Publishers",
                PublicationDate = "August 2022",
                Summary = "With original insights from those who know her best, new interviews with world leaders and access to unseen papers, bestselling author Robert Hardman explores the full, astonishing life of our longest reigning monarch in this compellingly authoritative yet intimate biography.",
                Genres = new List<string>() { "Non-fiction", "History", "UK", "United Kingdom", "Queen", "Elizabeth" },
                CopiesAvailable = 2,
                DeweyDecimal = 922.28,
                IsKids = false,
                ItemType = ItemType.Book
            });

            _store.Add(22, new LibraryItem
            {
                Id = 22,
                ImageSource = "images/22.jpg",
                Title = "Becoming",
                Author = "Michelle Obama",
                Length = "426 Pages",
                Format = "Paperback",
                Publisher = "Trump Publishing ",
                PublicationDate = "May 2017",
                Summary = "In her memoir, a work of deep reflection and mesmerizing storytelling, Michelle Obama invites readers into her world, chronicling the experiences that have shaped her—from her childhood on the South Side of Chicago to her years as an executive balancing the demands of motherhood and work, to her time spent at the world’s most famous address. With unerring honesty and lively wit, she describes her triumphs and her disappointments, both public and private, telling her full story as she has lived it—in her own words and on her own terms. Warm, wise, and revelatory, Becoming is the deeply personal reckoning of a woman of soul and substance who has steadily defied expectations—and whose story inspires us to do the same.",
                Genres = new List<string>() { "Non-fiction", "Politics", "Memoir", "History", "Queen", "Elizabeth" },
                CopiesAvailable = 2,
                DeweyDecimal = 0.28,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(23, new LibraryItem
            {
                Id = 23,
                ImageSource = "images/23.jpg",
                Title = "Freakonomics: A Rogue Economist Explores the Hidden Side of Everything",
                Author = "Steven D. Levitt and Stephen J. Dubner",
                Length = "1021 Pages",
                Format = "Hardcover",
                Publisher = "Socialist Books",
                PublicationDate = "September 2005",
                Summary = "The concept of Freakonomics looks at a variety of behavioral and social phenomena through an economic lens. This best seller, which sold more than four million copies worldwide, spawned numerous other books and a podcast that changed the way we look at the world. The authors discuss the everyday workings of everyday things, like how to catch a cheater or why your new car is worth so much less the moment you drive it off the lot. With a following of readers from the New York Times, economist Levitt received a wide range of queries from both ordinary people and the likes of a Tour de France champ and the CIA. Here, with the help of Dubner’s humorous writing, he provides the answers to life’s somewhat-pressing questions.",
                Genres = new List<string>() { "Non-fiction", "Economics", "Politics", "Education", "Economy" },
                CopiesAvailable = 2,
                DeweyDecimal = 311.69,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(24, new LibraryItem
            {
                Id = 24,
                ImageSource = "images/24.jpg",
                Title = "The Art of Horror: An Illustrated History",
                Author = "Stephen Jones",
                Length = "256 Pages",
                Format = "Paperback",
                Publisher = "Applause Books",
                PublicationDate = "October 2015",
                Summary = "Amazingly, there has never been a book quite like The Art of Horror a celebration of frightful images, compiled and presented by some of the genre's most respected names. While acknowledging the beginnings of horror-related art in legends and folk tales, the focus of the book is on how the genre has presented itself to the world since the creations of Bram Stoker and Mary Shelley first became part of the public consciousness in the 19th century. It's all here: from early engravings via dust jackets, book illustrations, pulp magazines, movie posters, comic books, and paintings to today's artists working entirely in the digital realm. Editor Stephen Jones and his stellar team of contributors have sourced visuals from archives and private collections (including their own) worldwide, ensuring an unprecedented selection that is accessible to those discovering the genre, while also including many images that will be rare and unfamiliar to even the most committed fan. From the shockingly lurid to the hauntingly beautiful including images of vampires, werewolves, zombies, ghosts, demons, serial killers, alien invaders, and more every aspect of the genre is represented in ten themed chapters. Quotes from artists/illustrators, and a selection from writers and filmmakers, are featured throughout.",
                Genres = new List<string>() { "Non-fiction", "Horror", "History" },
                CopiesAvailable = 7,
                DeweyDecimal = 700.09,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(25, new LibraryItem
            {
                Id = 25,
                ImageSource = "images/25.jpg",
                Title = "The Best of H.P. Lovecraft: Bloodcurdling Tales of Horror and the Macabre",
                Author = "H.P. Lovecraft",
                Length = "406 Pages",
                Format = "Paperback",
                Publisher = "Ballantine Books",
                PublicationDate = "October 2022",
                Summary = "This is the collection that true fans of horror fiction must have: sixteen of H.P. Lovecraft’s most horrifying visions, including:\n\nThe Call of Cthulu: The first story in the infamous Cthulhu mythos—a creature spawned in the stars brings a menace of unimaginable evil to threaten all mankind.\n\nThe Dunwich Horror: An evil man’s desire to perform an unspeakable ritual leads him in search of the fabled text of The Necronomicon.\n\nThe Colour Out of Space: A horror from the skies—far worse than any nuclear fallout—transforms a man into a monster.\n\nThe Shadow Over Innsmouth: Rising from the depths of the sea, an unspeakable horror engulfs a quiet New England town.\n\nPlus twelve more terrifying tales!.",
                Genres = new List<string>() { "Fiction", "Horror", "Classics", "Science Fiction" },
                CopiesAvailable = 1,
                DeweyDecimal = 700.21,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(26, new LibraryItem
            {
                Id = 26,
                ImageSource = "images/26.jpg",
                Title = "Uzumaki: Spiral into Horror, Vol. 1",
                Author = "Junji Ito",
                Length = "208 Pages",
                Format = "Hardcover",
                Publisher = "Konoha Publishing",
                PublicationDate = "October 2021",
                Summary = "Shortly after Shuichi Saito's father becomes obsessed with spirals -- snail shells, whirlpools, and man-made patterns -- he dies mysteriously, his body positioned in the shape of a twisted coil. Soon, the entire town is afflicted with a snail-like disease.",
                Genres = new List<string>() { "Fiction", "Horror", "Graphic Novel", "Fantasy", "Japan", "Manga" },
                CopiesAvailable = 3,
                DeweyDecimal = 51.21,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(27, new LibraryItem
            {
                Id = 27,
                ImageSource = "images/27.jpg",
                Title = "Twilight",
                Author = "Stephenie Meyer",
                Length = "498 Pages",
                Format = "Hardcover",
                Publisher = "Little, Brown and Company",
                PublicationDate = "September 2006",
                Summary = "About three things I was absolutely positive.\n\nFirst, Edward was a vampire.\n\nSecond, there was a part of him—and I didn't know how dominant that part might be—that thirsted for my blood.\n\nAnd third, I was unconditionally and irrevocably in love with him.\n\nDeeply seductive and extraordinarily suspenseful, Twilight is a love story with bite.",
                Genres = new List<string>() { "Fiction", "Teen", "Vampires", "Paranormal", "Romance", "Mystery" },
                CopiesAvailable = 8,
                DeweyDecimal = 68.21,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(28, new LibraryItem
            {
                Id = 28,
                ImageSource = "images/28.jpg",
                Title = "Fifty Shades of Grey",
                Author = "E.L. James",
                Length = "356 Pages",
                Format = "Softcover",
                Publisher = "Vintage Publishing",
                PublicationDate = "May 2011",
                Summary = "When literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him. Unable to resist Ana’s quiet beauty, wit, and independent spirit, Grey admits he wants her, too—but on his own terms.",
                Genres = new List<string>() { "Fiction", "Romance", "Erotica", "Adult", "Mystery" },
                CopiesAvailable = 20,
                DeweyDecimal = 11.11,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(29, new LibraryItem
            {
                Id = 29,
                ImageSource = "images/29.jpg",
                Title = "Crazy Rich Asians",
                Author = "Kevin Kwan",
                Length = "403 Pages",
                Format = "Softcover",
                Publisher = "Doubleday Publishing",
                PublicationDate = "June 2013",
                Summary = "When Rachel Chu agrees to spend the summer in Singapore with her boyfriend, Nicholas Young, she envisions a humble family home, long drives to explore the island, and quality time with the man she might one day marry. What she doesn't know is that Nick's family home happens to look like a palace, that she'll ride in more private planes than cars, and that with one of Asia's most eligible bachelors on her arm, Rachel might as well have a target on her back.",
                Genres = new List<string>() { "Fiction", "Romance", "Contemporary", "Adult", "Asia" },
                CopiesAvailable = 1,
                DeweyDecimal = 12.11,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(30, new LibraryItem
            {
                Id = 30,
                ImageSource = "images/30.jpg",
                Title = "China Rich Girlfriend",
                Author = "Kevin Kwan",
                Length = "378 Pages",
                Format = "Hardcover",
                Publisher = "Doubleday Publishing",
                PublicationDate = "June 2016",
                Summary = "On the eve of her wedding to Nicholas Young, heir to one of the greatest fortunes in Asia, Rachel should be over the moon. She has a flawless Asscher-cut diamond from JAR, a wedding dress she loves more than anything found in the salons of Paris, and a fiance willing to sacrifice his entire inheritance in order to marry her. But Rachel still mourns the fact that her birthfather, a man she never knew, won't be able to walk her down the aisle. Until: a shocking revelation draws Rachel into a world of Shanghai splendor beyond anything she has ever imagined. Here we meet Carlton, a Ferrari-crashing bad boy known for Prince Harry-like antics; Colette, a celebrity girlfriend chased by fevered paparazzi; and the man Rachel has spent her entire life waiting to meet: her father. Meanwhile, Singapore's It Girl, Astrid Leong, is shocked to discover that there is a downside to having a newly minted tech billionaire husband. A romp through Asia's most exclusive clubs, auction houses, and estates, China Rich Girlfriend brings us into the elite circles of Mainland China, introducing a captivating cast of characters, and offering an inside glimpse at what it's like to be gloriously, crazily, China-rich.",
                Genres = new List<string>() { "Fiction", "Romance", "Contemporary", "Adult", "Asia" },
                CopiesAvailable = 3,
                DeweyDecimal = 12.13,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(31, new LibraryItem
            {
                Id = 31,
                ImageSource = "images/31.jpg",
                Title = "Captivating: Unveiling the Mystery of a Woman's Soul",
                Author = "John Eldredge, Stasi Eldredge",
                Length = "243 Pages",
                Format = "Softcover",
                Publisher = "Nelson Books",
                PublicationDate = "April 2005",
                Summary = "Every woman was once a little girl. And every little girl holds in her heart her most precious dreams. She longs to be swept up into a romance, to play an irreplaceable role in a great adventure, to\" be\" the Beauty of the story. And yet―how many women do you know who ever find that life?\n\nMost women think they have to settle for a life of efficiency and duty, striving to be the women they \"ought\" to be but often feeling they have failed. Sadly, too many messages for Christian women add to the pressure. \"Do these ten things, and you will be a godly woman.\" The effect has not been good on the feminine soul.\n\nThe message of \"Captivating\" is this: Your heart matters more than anything else in all creation. The desires you had as a little girl and the longings you still feel are telling you of the life God created you to live. He offers to rescue your heart and release you to live as a fully alive and feminine woman. A woman who is truly captivating..",
                Genres = new List<string>() { "Religion", "Faith", "Non-fiction", "Self Help", "Adult" },
                CopiesAvailable = 4,
                DeweyDecimal = 202.99,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(32, new LibraryItem
            {
                Id = 32,
                ImageSource = "images/32.jpg",
                Title = "Artemis Fowl",
                Author = "Eoin Colfer",
                Length = "396 Pages",
                Format = "Softcover",
                Publisher = "Disney-Hyperion",
                PublicationDate = "April 2001",
                Summary = "Twelve-year-old Artemis Fowl is a millionaire, a genius, and above all, a criminal mastermind. But even Artemis doesn't know what he's taken on when he kidnaps a fairy, Captain Holly Short of the LEPrecon Unit. These aren't the fairies of bedtime stories—they're dangerous! Full of unexpected twists and turns, Artemis Fowl is a riveting, magical adventure.",
                Genres = new List<string>() { "Fiction", "Fantasy", "Teen", "Kids", "Science Fiction" },
                CopiesAvailable = 4,
                DeweyDecimal = 23.11,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(33, new LibraryItem
            {
                Id = 33,
                ImageSource = "images/33.jpg",
                Title = "Artemis Fowl: The Atlantis Complex",
                Author = "Eoin Colfer",
                Length = "357 Pages",
                Format = "Hardcover",
                Publisher = "Disney-Hyperion",
                PublicationDate = "July 2010",
                Summary = "Young Artemis has frequently used high-tech fairy magic to mastermind the most devious criminal activity of the new century. Now, at a conference in Iceland, Artemis has gathered the fairies to present his latest idea to save the world from global warming.\n\nBut Artemis is behaving strangely - he seems different. Something terrible has happened to him . . . Artemis Fowl has become nice.\n\nThe fairies diagnose Atlantis Complex (that’s obsessive compulsive disorder to you and I) - it seems dabbling in magic has damaged Artemis’ main weapon: his mind. Fairy ally Captain Holly Short doesn’t know what to do. The subterranean volcanoes are under attack from vicious robots and Artemis cannot fight them. Can Holly get the real Artemis back before the robot probes destroy every human and life form?",
                Genres = new List<string>() { "Fiction", "Fantasy", "Teen", "Kids", "Science Fiction" },
                CopiesAvailable = 8,
                DeweyDecimal = 2.21,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(34, new LibraryItem
            {
                Id = 34,
                ImageSource = "images/34.jpg",
                Title = "The Slim Shady LP",
                Author = "Eminem",
                Length = "59:39",
                Format = "Vinyl",
                Publisher = "Studio 8",
                PublicationDate = "February 1999",
                Summary = "The Slim Shady LP is the second studio album and major label debut by American rapper Eminem. It was released on February 23, 1999, by Aftermath Entertainment and Interscope Records. Recorded in Ferndale, Michigan following Eminem's recruitment by Dr. Dre and Jimmy Iovine, the album features production from Dr. Dre, the Bass Brothers, and Eminem himself.",
                Genres = new List<string>() { "Rap", "Profanity", "Hip-hop", "horrocore" },
                CopiesAvailable = 2,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Music
            });
            _store.Add(35, new LibraryItem
            {
                Id = 35,
                ImageSource = "images/35.jpg",
                Title = "Hybrid Theory",
                Author = "Linkin Park",
                Length = "37:45",
                Format = "Vinyl",
                Publisher = "Warner Bros",
                PublicationDate = "October 2000",
                Summary = "Hybrid Theory is the debut studio album by American rock band Linkin Park, released on October 24, 2000, through Warner Bros. Records. Recorded at NRG Recordings in North Hollywood, California, and produced by Don Gilmore, the album's lyrical themes deal with problems lead vocalist Chester Bennington experienced during his adolescence, including drug abuse and the constant fighting and divorce of his parents. Hybrid Theory takes its title from the previous name of the band as well as the concept of music theory and combining different styles. This is also the only album on which bassist Dave Farrell does not play.",
                Genres = new List<string>() { "Metal", "Rap Metal", "Alternative", "Rock" },
                CopiesAvailable = 5,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Music
            });
            _store.Add(36, new LibraryItem
            {
                Id = 36,
                ImageSource = "images/36.jpg",
                Title = "Love Yourself: Tear",
                Author = "BTS",
                Length = "44:02",
                Format = "Vinyl",
                Publisher = "Big Hit Entertainment",
                PublicationDate = "May 2018",
                Summary = "Love Yourself 轉 Tear (stylized in all caps) is the third Korean-language studio album by South Korean boy band BTS. The album was released on May 18, 2018, by Big Hit Entertainment. It is available in four versions and contains eleven tracks, with \"Fake Love\" as its lead single. The concept album explores themes relating to the pains and sorrows of separation.[4] On May 27, 2018, the album debuted at number one on the US Billboard 200, earning 135,000 album-equivalent units and becoming BTS' highest-charting album in a Western market at the time, as well as the first Korean album to top the US albums chart and the highest-charting album by an Asian act.[5]",
                Genres = new List<string>() { "Hip Hop", "Kpop", "EDM", "Pop" },
                CopiesAvailable = 6,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Music
            });
            _store.Add(37, new LibraryItem
            {
                Id = 37,
                ImageSource = "images/37.jpg",
                Title = "Justice",
                Author = "Justin Bieber",
                Length = "45:25",
                Format = "Vinyl",
                Publisher = "Henson Recording",
                PublicationDate = "March 2019",
                Summary = "Justice is the sixth studio album by Canadian singer Justin Bieber. It was released on March 19, 2021, by Def Jam Recordings. The album features guest appearances from Khalid, Chance the Rapper, the Kid Laroi, Dominic Fike, Daniel Caesar, Giveon, Beam, Burna Boy, and Benny Blanco. ",
                Genres = new List<string>() { "Pop", "Pop Rock", "Synth-pop" },
                CopiesAvailable = 11,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Music
            });
            _store.Add(38, new LibraryItem
            {
                Id = 38,
                ImageSource = "images/38.jpg",
                Title = "Avengers: Endgame",
                Author = "Anthony Russo, Joe Russo",
                Length = "3h1m",
                Format = "DVD",
                Publisher = "Disney",
                PublicationDate = "April 2019",
                Summary = "Avengers: Endgame is a 2019 American superhero film based on the Marvel Comics superhero team the Avengers. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the direct sequel to Avengers: Infinity War (2018) and the 22nd film in the Marvel Cinematic Universe (MCU).",
                Genres = new List<string>() { "Fiction", "Superhero", "Avengers", "Fantasy", "Action", "Science Fiction", "Marvel" },
                CopiesAvailable = 1,
                DeweyDecimal = -1,
                IsKids = true,
                ItemType = ItemType.Movie
            });
            _store.Add(39, new LibraryItem
            {
                Id = 39,
                ImageSource = "images/39.jpg",
                Title = "Top Gun: Maverick",
                Author = "Joseph Kosinski",
                Length = "2h20m",
                Format = "DVD",
                Publisher = "Paramount Pictures",
                PublicationDate = "April 2022",
                Summary = "Top Gun: Maverick is a 2022 American action drama film that is a sequel to the 1986 film Top Gun with Tom Cruise reprising his starring role as the naval aviator Maverick.",
                Genres = new List<string>() { "Fiction", "Action", "Army", "Planes", "America", "War" },
                CopiesAvailable = 2,
                DeweyDecimal = -1,
                IsKids = false,
                ItemType = ItemType.Movie
            });
            _store.Add(40, new LibraryItem
            {
                Id = 40,
                ImageSource = "images/40.jpg",
                Title = "Your Name",
                Author = "Makoto Shinkai",
                Length = "1h47m",
                Format = "DVD",
                Publisher = "CoMix Wave Films",
                PublicationDate = "July 2016",
                Summary = "Your Name (Japanese: 君の名は。, Hepburn: Kimi no Na wa) is a 2016 Japanese animated romantic fantasy film produced by CoMix Wave Films. It depicts a high school boy in Tokyo and a high school girl in the Japanese countryside who suddenly and inexplicably begin to swap bodies. The film was commissioned in 2014, written and directed by Makoto Shinkai.",
                Genres = new List<string>() { "Anime", "Romance", "Fiction", "Fantasy" },
                CopiesAvailable = 4,
                DeweyDecimal = -1,
                IsKids = true,
                ItemType = ItemType.Movie
            });
            _store.Add(41, new LibraryItem
            {
                Id = 41,
                ImageSource = "images/41.jpg",
                Title = "SPY X FAMILY, VOL. 1",
                Author = "Tatsuya Endo",
                Length = "220 Pages",
                Format = "Paperback",
                Publisher = "VIZ Media LLC",
                PublicationDate = "June 2020",
                Summary = "An action-packed comedy about a fake family that includes a spy, an assassin and a telepath!\n\nMaster spy Twilight is unparalleled when it comes to going undercover on dangerous missions for the betterment of the world. But when he receives the ultimate assignment—to get married and have a kid—he may finally be in over his head!\n\nNot one to depend on others, Twilight has his work cut out for him procuring both a wife and a child for his mission to infiltrate an elite private school. What he doesn’t know is that the wife he’s chosen is an assassin and the child he’s adopted is a telepath!",
                Genres = new List<string>() { "Fiction", "Manga", "Romance", "Comedy", "Action", "Mystery", "Graphic Novel" },
                CopiesAvailable = 4,
                DeweyDecimal = 72.87,
                IsKids = true,
                ItemType = ItemType.Book
            });
            _store.Add(42, new LibraryItem
            {
                Id = 42,
                ImageSource = "images/42.jpg",
                Title = "Solo Leveling, vol. 2",
                Author = "Chugong",
                Length = "304 Pages",
                Format = "Paperback",
                Publisher = "Redice Studio",
                PublicationDate = "January 2020",
                Summary = "Ever since he woke up in the hospital, Jinwoo’s been thrown into a world of cryptic messages, daily quests, and strange dungeons overflowing with creatures he’s never even heard of. As he tests out his new abilities, it starts to sink in that he is no longer the Weakest Hunter of All Mankind. Maybe he can finally attain what he’s always wanted—enough power to protect himself—but a run-in with an unexpected foe forces Jinwoo to consider just how far he’s willing to go to obtain it!",
                Genres = new List<string>() { "Fiction", "Manga", "Manhwa", "Action", "Adventure", "Action", "Mystery", "Graphic Novel" },
                CopiesAvailable = 4,
                DeweyDecimal = 75.07,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(43, new LibraryItem
            {
                Id = 43,
                ImageSource = "images/43.jpg",
                Title = "Death Note, Vol. 1: Boredom",
                Author = "Tsugumi Ohba",
                Length = "395 Pages",
                Format = "Paperback",
                Publisher = "VIZ Media LLC",
                PublicationDate = "October 2005",
                Summary = "Light Yagami is an ace student with great prospects - and he's bored out of his mind. But all that changes when he finds the Death Note, a notebook dropped by a rogue Shinigami, a death god. Any human whose name is written in the notebook dies, and now Light has vowed to use the power of the Death Note to rid the world of evil. But when criminals begin dropping dead, the authorities send the legendary detective L to track down the killer. With L hot on his heels, will Light lose sight of his noble goal... or his life?",
                Genres = new List<string>() { "Fiction", "Manga", "Fantasy", "Mystery", "Adventure", "Action", "Graphic Novel", "Horror" },
                CopiesAvailable = 3,
                DeweyDecimal = 809.17,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(44, new LibraryItem
            {
                Id = 44,
                ImageSource = "images/44.jpg",
                Title = "Batman: Shadow War",
                Author = "Joshua Williamson",
                Length = "272 Pages",
                Format = "Paperback",
                Publisher = "DC Comics",
                PublicationDate = "November 2022",
                Summary = "Ra's al Ghul is dead, and Talia is out for revenge! Batman is on the case to find Deathstroke before Talia's elite killers do! But Batman starts to piece together that not everything is what it seems in Ra's's death…and knows whom he must interrogate to get answers…Talia herself! Can the two former lovers ever work together again?",
                Genres = new List<string>() { "Fiction", "Comics", "Fantasy", "Mystery", "Adventure", "Action", "Graphic Novel", "Batman" },
                CopiesAvailable = 6,
                DeweyDecimal = 56.17,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(45, new LibraryItem
            {
                Id = 45,
                ImageSource = "images/45.jpg",
                Title = "Chinese For Dummies",
                Author = "Wendy Abraham",
                Length = "384 Pages",
                Format = "Paperback",
                Publisher = "Duo Lingo Publishing",
                PublicationDate = "October 14, 2005",
                Summary = "China has become a major influence in the world today. Not only is China full of opportunities in business and politics, but Chinese culture, such as movies and literature, are also making their way into the western world. And with Chinese as the second most widely- spoken foreign language in America, more and more Americans are exposed to its language and culture. This revised edition of \"Chinese for Dummies\" shows you the basics of Mandarin Chinese and culture points that will make great impressions while communicating.Many Americans are taking time to learn Chinese, especially since it is becoming one of the most widely used languages in the world. Currently, there are: Over 1 billion people speak some form of ChineseMore Chinese speakers in the United States than French or German speakers102.6 million internet users who obtain access using ChineseAt least 25 million people worldwide who are learning Chinese.",
                Genres = new List<string>() { "Non-fiction", "Language", "Education", "China" },
                CopiesAvailable = 1,
                DeweyDecimal = 400.27,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(46, new LibraryItem
            {
                Id = 46,
                ImageSource = "images/46.jpg",
                Title = "C# 5.0 All-in-One For Dummies",
                Author = "Bill Sempf",
                Length = "843 Pages",
                Format = "Paperback",
                Publisher = "CPSC 481",
                PublicationDate = "December, 2022",
                Summary = "800+ pages of top-notch coverage; perfect for learning the fundamentals of C#!\nC# is a complex programming language for building .NET-connected software for Microsoft Windows, cloud computing, the Web, and a wide range of devices. Today's developers use it to develop Azure and Windows Phone apps, and Android applications using Mono.  Novice programmers can get up and running quickly on C# using this practical guide. Crammed with 800+ pages of information, this all-in-one book helps you quickly create a C# program while learning C# and object-oriented programming fundamentals, Windows and Windows phone programming, and more.",
                Genres = new List<string>() { "Non-fiction", "Education", "Science", "Computer" },
                CopiesAvailable = 1,
                DeweyDecimal = 400.33,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(47, new LibraryItem
            {
                Id = 47,
                ImageSource = "images/47.jpg",
                Title = "A Brief History of Time",
                Author = "Stephen Hawking",
                Length = "213 Pages",
                Format = "Paperback",
                Publisher = "Bantam Books",
                PublicationDate = "September, 1998",
                Summary = "In the ten years since its publication in 1988, Stephen Hawking's classic work has become a landmark volume in scientific writing, with more than nine million copies in forty languages sold worldwide. That edition was on the cutting edge of what was then known about the origins and nature of the universe. But the intervening years have seen extraordinary advances in the technology of observing both the micro- and the macrocosmic worlds.",
                Genres = new List<string>() { "Non-fiction", "Education", "Science", "History", "Physics" },
                CopiesAvailable = 1,
                DeweyDecimal = 505.33,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(48, new LibraryItem
            {
                Id = 48,
                ImageSource = "images/48.jpg",
                Title = "Naruto, Vol. 1: Uzumaki Naruto",
                Author = "Masashi Kishimoto",
                Length = "187 Pages",
                Format = "Paperback",
                Publisher = "VIZ Media",
                PublicationDate = "February, 2014",
                Summary = "Naruto is a ninja-in-training with an incorrigible knack for mischief. His wild antics amuse his teammates, but Naruto is completely serious about one thing: becoming the world's greatest ninja! ",
                Genres = new List<string>() { "Fiction", "Manga", "Action", "Adventure", "Manga", "Graphic Novel", "Teen" },
                CopiesAvailable = 1,
                DeweyDecimal = 7.33,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(49, new LibraryItem
            {
                Id = 49,
                ImageSource = "images/49.jpg",
                Title = "The Story of Art",
                Author = "E.H Gombrich",
                Length = "688 Pages",
                Format = "Hardcover",
                Publisher = "Phaidon Press",
                PublicationDate = "April, 1995",
                Summary = "The Story of Art, one of the most famous and popular books on art ever written, has been a world bestseller for over four decades. Attracted by the simplicity and clarity of his writing, readers of all ages and backgrounds have found in Professor Gombrich a true master, and one who combines knowledge and wisdom with a unique gift for communicating his deep love of the subject. ",
                Genres = new List<string>() { "Art", "Non-fiction", "History", "Classics" },
                CopiesAvailable = 2,
                DeweyDecimal = 711.33,
                IsKids = false,
                ItemType = ItemType.Book
            });
            _store.Add(50, new LibraryItem
            {
                Id = 50,
                ImageSource = "images/50.jpg",
                Title = "The Adventures of Captain Underpants",
                Author = "Dav Pilkey",
                Length = "125 Pages",
                Format = "Paperback",
                Publisher = "Scholastic Children's books",
                PublicationDate = "January, 2000",
                Summary = "Pilkey plays with words and pictures, providing great entertainment. The story is immediately engaging—two fourth-grade boys who write comic books and love to pull pranks find themselves in big trouble. Mean Mr. Krupp, their principal, videotapes George and Harold setting up their stunts and threatens to expose them. The boys' luck changes when they send for a 3-D Hypno-Ring and hypnotize Krupp, turning him into Captain Underpants, their own superhero creation. Later, Pilkey includes several pages of flip-o-ramas that animate the action. The simple black-and-white illustrations on every page furnish comic-strip appeal. The cover features Captain Underpants, resplendent in white briefs, on top of a tall building. This book will fly off the shelves.",
                Genres = new List<string>() { "Fiction", "Humor", "Kids", "Children", "Action", "Adventure" },
                CopiesAvailable = 2,
                DeweyDecimal = 800.33,
                IsKids = true,
                ItemType = ItemType.Book
            });
        }

    }
}
