using BookReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReview.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbCon context)
        {
            context.Database.EnsureCreated();            

            if (context.Author.Any())
            {
                return;   // DB has been seeded
            }
            else
            {
                var authors = new Author[]
                {
                    new Author
                    {
                        FullName ="Unknown",
                        Birtdate = null,
                        DeathDate = null,
                        Books = new List<Book>()
                        {
                            new Book
                            {
                                Title = "The Epic of Gilgamesh",
                                Description = "Miraculously preserved on clay tablets dating back as far as four thousand years, the poem of Gilgamesh, King of Uruk, predates Homer by many centuries. The story tells of Gilgamesh's adventures with the wild man Enkidu, and of his arduous journey to the ends of the earth in quest of the Babylonian Noah and the secret of immortality. Alongside its themes of family, friendship and the duties of kings, the Epic of Gilgamesh is, above all, about mankind's eternal struggle with the fear of death. This new edition of Andrew George's translation has been extensively revised to include recently discovered fragments and new sources.",
                                ISBN = 9780140449198
                            },
                            new Book
                            {
                                Title = "Beowulf",
                                Description = "Beowulf is the greatest surviving work of literature in Old English, unparalleled in its epic grandeur and scope. It tells the story of the heroic Beowulf and of his battles, first with the monster Grendel, who has laid waste to the great hall of the Danish king Hrothgar, then with Grendel's avenging mother, and finally with a dragon that threatens to devastate his homeland. Through its blend of myth and history, Beowulf vividly evokes a twilight world in which men and supernatural forces live side by side. And it celebrates the endurance of the human spirit in a transient world.",
                                ISBN = 9780140449310
                            },
                            new Book
                            {
                                Title = "The Arabian Nights: Tales of 1,001 Nights",
                                Description = "Every night for three years the vengeful King Shahriyar sleeps with a different virgin, executing her the next morning. To end this brutal pattern and to save her own life, the vizier's daughter, Shahrazad, begins to tell the king stories of adventure, love, riches and wonder - tales of mystical lands peopled with princes and hunchbacks, the Angel of Death and magical spirits, tales of the voyages of Sindbad, of Ali Baba outwitting a band of forty thieves and of jinnis trapped in rings and in lamps. The sequence of stories will last 1,001 nights.",
                                ISBN = 9780140449389
                            }
                        }
                    },
                    new Author
                    {
                        FullName ="Paul Tannenberg",
                        Birtdate = new DateTime(1968,08,02),
                        DeathDate = null
                    },
                    new Author
                    {
                        FullName ="Émile Nestor",
                        Birtdate = new DateTime(1991,03,27),
                        DeathDate = null,
                        Books = new List<Book>()
                        {
                            new Book
                            {
                                Title = "Nestor och Whiskey",
                                Description = "En man. En katt. Ett äventyr.",
                                ISBN = 9780456789198
                            },
                            new Book
                            {
                                Title = "Satanism 101",
                                Description = "En praktisk handbok för systematisk användning av det fördolda.",
                                ISBN = 9780140449666
                            },
                            new Book
                            {
                                Title = "Stefan och Jag",
                                Description = "En skrämmande inblick i hur det kan vara att leva med en stalker.",
                                ISBN = 9780140412345
                            }
                        }
                    },
                    new Author
                    {
                        FullName ="George Orwell",
                        Birtdate = new DateTime(1903,06,25),
                        DeathDate = new DateTime(1950,01,21),
                        Books = new List<Book>()
                        {
                            new Book
                            {
                                Title = "1984",
                                Description = "Winston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities.",
                                ISBN = 9780141036144,
                                Reviews = new List<Review>()
                                {
                                    new Review
                                    {
                                        Title = "Big Brother",
                                        Description = "Over 70 years ago Orwell predicted exactly what is happening in the USA today. His brilliant instincts for our future were uncanny. Our country is under assault right now by “Big Brother” - ie. communism.",
                                        ReviewScore = 5
                                    },
                                    new Review
                                    {
                                        Title = "Where are the pictures?",
                                        Description = "I can't read.",
                                        ReviewScore = 1
                                    }
                                }
                            },
                            new Book
                            {
                                Title = "Animal Farm", 
                                Description = "Mr Jones of Manor Farm is so lazy and drunken that one day he forgets to feed his livestock. The ensuing rebellion under the leadership of the pigs Napoleon and Snowball leads to the animals taking over the farm. Vowing to eliminate the terrible inequities of the farmyard, the renamed Animal Farm is organised to benefit all who walk on four legs.", 
                                ISBN = 9780141036137,
                                Reviews = new List<Review>()
                                {
                                    new Review
                                    {
                                        Title = "A Warning",
                                        Description = "This book was truly phenomenal! This novel being both political and satirical, George Orwell proves knowingly why he was one of the best authors/writers in the past century, even so his work stands out today and more relevant than ever before.",
                                        ReviewScore = 5
                                    }
                                }
                            }
                        }
                    },
                    new Author
                    {
                        FullName ="Agatha Christie", 
                        Birtdate = new DateTime(1890,09,15), 
                        DeathDate = new DateTime(1976,01,12), 
                        Books = new List<Book>()
                        {
                            new Book
                            {
                                Title = "Cards on the Table", 
                                Description = "A flamboyant party host is murdered in full view of a roomful of bridge players...", 
                                ISBN = 9780008164898
                            },
                            new Book
                            {
                                Title = "Murder on the Orient Express", 
                                Description = "Agatha Christie's most famous murder mystery, reissued with a striking new cover with special finishes.", 
                                ISBN = 9780008226664,
                                Reviews = new List<Review>()
                                {
                                    new Review
                                    {
                                        Title = "Very Murder!",
                                        Description = "I like trains!",
                                        ReviewScore = 4
                                    }
                                }
                            }
                        }
                    },
                    new Author
                    {
                        FullName ="Oscar Wilde",
                        Birtdate = new DateTime(1854,10,16),
                        DeathDate = new DateTime(1900,11,30),
                        Books = new List<Book>()
                        {
                            new Book
                            {
                                Title = "The Picture of Dorian Gray",
                                Description = "Enthralled by his own exquisite portrait, Dorian Gray exchanges his soul for eternal youth and beauty. Influenced by his friend Lord Henry Wotton, he is drawn into a corrupt double life; indulging his desires in secret while remaining a gentleman in the eyes of polite society. Only his portrait bears the traces of his decadence. The novel was a succes de scandale and the book was later used as evidence against Wilde at the Old Bailey in 1895. It has lost none of its power to fascinate and disturb.",
                                ISBN = 9780141442464
                            }
                        }
                    }
                };

                foreach (Author a in authors)
                {
                    context.Author.Add(a);
                }

                context.SaveChanges();
            }
        }
    }
}
