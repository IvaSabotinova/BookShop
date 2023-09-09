namespace BooksShop.Infrastructure.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(this.CreateBooks());
        }

        private List<Book> CreateBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Title = "The economy today",
                    Author = "Bradley R. Schiller",
                    ISBN = "007100940X",
                    NumOfPages = 969,
                    Price = 25.8m,
                    CategoryId = 1,
                    Description = "The Economy Today is noted for three great strengths: currency, policy focus, and readability. The accessible writing style engages students and brings the excitement of domestic and global economic news into the classroom.\r\n\r\nSchiller/Gebhardt emphasizes how policymakers must choose between government intervention and market reliance to resolves the core issues of what, how, and for whom to produce. These strategic trade-offs are highlighted throughout the full range of micro, macro, and international issues, and every chapter ends with a policy issue that emphasizes the market versus government dilemma.\r\n\r\nThe authors teach economics in a current and relevant context, including the COVID Pandemic of 2020, filling chapters with the real facts and applications of economic life. Schiller/Gebhardt is also the only principles text that presents all macro theory in the single consistent context of the AS/AD framework and uniquely features a full supply-side economics chapter. You will also find the current Economist and Chief, Joe Biden, featured in the opening chapter. \r\n\r\nThe authors have worked to ensure The Economy Today, 16th edition, is tightly integrated with the adaptive digital tools and dynamic interactive resources available in Connect. Connect is proven to increase student engagement and success. For professors there is also an updated instructor guide to bring new ideas to your course, no matter the format.",
                    ImageUrl = "/images/books/90e0e436-1c66-41ad-88e6-e1a153404144.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 2,
                    Title = "Principles of political economy",
                    Author = "John Stuart Mill",
                    ISBN = "OL25914464M",
                    NumOfPages = 1013,
                    Price = 96.4m,
                    CategoryId = 1,
                    Description = "The Principles of Political Economy with some of their applications to Social Philosophy by John Stuart Mill. Principles of Political Economy (1848) by John Stuart Mill was one of the most important economics or political economy textbooks of the mid-nineteenth century. It was revised until its seventh edition in 1871, shortly before Mill's death in 1873, and republished in numerous other editions. In every department of human affairs, Practice long precedes Science systematic enquiry into the modes of action of the powers of nature, is the tardy product of a long course of efforts to use those powers for practical ends. The conception, accordingly, of Political Economy as a branch of science is extremely modern; but the subject with which its enquiries are conversant has in all ages necessarily constituted one of the chief practical interests of mankind, and, in some, a most unduly engrossing one. That subject is Wealth. Writers on Political Economy profess to teach, or to investigate, the nature of Wealth, and the laws of its production and distribution: including, directly or remotely, the operation of all the causes by which the condition of mankind, or of any society of human beings, in respect to this universal object of human desire, is made prosperous or the reverse. Not that any treatise on Political Economy can discuss or even enumerate all these causes; but it undertakes to set forth as much as is known of the laws and principles according to which they operate.",
                    ImageUrl = "/images/books/73174e87-d6b4-4604-9712-7330ab87ed72.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 3,
                    Title = "The social cancer",
                    Author = "Jose Rizal",
                    ISBN = "OL14042495M",
                    NumOfPages = 502,
                    Price = 38.2m,
                    CategoryId = 1,
                    Description = "One of the most popular novels of its day, this translation of The Social Cancer shows just why with a vibrant, lively translation that leaps off the page.",
                    ImageUrl = "/images/books/b8422c70-aebe-4333-8908-0a59b53e9ab3.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 4,
                    Title = "Computer networks",
                    Author = "Andrew S. Tanenbaum",
                    ISBN = "013162959X",
                    NumOfPages = 658,
                    Price = 99.9m,
                    CategoryId = 2,
                    Description = "In Computer Networks,Tanenbaum et al. explain how networks work from the inside out. They start with the physical layer of networking, computer hardware and transmission systems,then work their way up to network applications. Each chapter follows aconsistent approach: The book presents key principles, then illustrates them utilizing real-world example networks that run through the entire book – the Internet, and wireless networks, including Wireless LANs, broadband wireless,and Bluetooth. The 6th Edition is updated throughout to reflect the most current technologies, and the chapter on network security is rewritten to focus on modern security principles and actions.\r\n\r\nTutorial videos on key networking topics and techniques are available to students on the companion website at www.pearsonglobaleditions.com\r\n\r\nInstructors are supported with a SolutionsManual to end-of-chapter exercises featured in the book, LecturePowerPoint slides, and extracted art and figures featured in thebook.",
                    ImageUrl = "/images/books/0355b9fb-bf1b-4ae5-a3b9-a88ea551f1b5.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 5,
                    Title = "Computer concepts",
                    Author = "June Jamrich Parsons and Dan Oja",
                    ISBN = "0760034397",
                    NumOfPages = 313,
                    Price = 75.0m,
                    CategoryId = 2,
                    Description = "Helping you understand the technological foundations for a wide range of digital devices, New Perspectives Computer Concepts Comprehensive, 21st edition, presents what every learner should know about using technology to complete your education, launch a successful career and engage in issues that shape today's world. The book's proven learning path is structured with today's busy reader in mind. Leading tech author June Parsons combines the latest on emerging technology with detailed illustrations and interactive activities that help you quickly understand technical topics. This edition provides updated information on current operating systems, digital rights management, the deep web and dark web, videoconferencing, the pandemic's impact on tech jobs, work-at-home and more. A unique module provides a hands-on introduction to programming, while MindTap offers anywhere, anytime learning solutions.",
                    ImageUrl = "/images/books/e538ff43-dded-46c1-b7e9-f33cd2096314.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 6,
                    Title = "Introducing Computers",
                    Author = "Robert H. Blissmer",
                    ISBN = "0471617830",
                    NumOfPages = 445,
                    Price = 45.5m,
                    CategoryId = 2,
                    Description = "This annual edition offers up-to-the-minute information on technological innovation and change along with a built-in study guide. Outlines the essential skills needed to achieve computer literacy including key concepts, systems and applications. Accessible, yet technically accurate, each major concept is supported by an application and illustration. Numerous software exercises provide projects for students to practice on the computer.",
                    ImageUrl = "/images/books/e5089e94-d32f-43f0-9c85-25b5ecdfcd2e.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 7,
                    Title = "Elementary statistics",
                    Author = "Mario F. Triola",
                    ISBN = "0805393277",
                    NumOfPages = 581,
                    Price = 105.5m,
                    CategoryId = 3,
                    Description = "Best-selling author Marty Triola is committed to keeping Elementary Statistics relentlessly current - with an unprecedented amount of up-to-the-minute real data - so that readers of all backgrounds understand the role of statistics in the world around them. In addition to an abundance of new data sets, examples, and exercises, the 13th Edition is designed to be even more flexible, with the addition of learning objectives as an organizational tool, larger data sets, and new topics in line with advancements in statistics. In addition, readers will find more support in an all - new series of videos, more opportunities for practice, and improved support for statistical software. Elementary Statistics is part of a series that also includes an Essentials version as well as technology-specific texts, Elementary Statistics Using the TI 83/84 Plus Calculator and Elementary Statistics Using Excel.",
                    ImageUrl = "/images/books/04fe7e81-299e-4b26-b1fd-0e1a3149c9da.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 8,
                    Title = "Calculus",
                    Author = "Howard Anton",
                    ISBN = "0471153060",
                    NumOfPages = 1130,
                    Price = 80.0m,
                    CategoryId = 3,
                    Description = "Countless people have relied on Anton to learn the difficult concepts of calculus. The new ninth edition continues the tradition of providing an accessible introduction to the field. It improves on the carefully worked and special problems to increase comprehension. New applied exercises demonstrate the usefulness of mathematics. More summary tables and step-by-step summaries are included to offer additional support when learning the concepts. And Quick Check exercises have been revised to more precisely focus on the most important ideas. This book will help anyone who needs to learn calculus and build a strong mathematical foundation.",
                    ImageUrl = "/images/books/005f0140-65ad-4b24-8f05-b2d45f274f49.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 9,
                    Title = "Calculus made easy",
                    Author = "Silvanus Phillips Thompson",
                    ISBN = "0312114109",
                    NumOfPages = 250,
                    Price = 75.5m,
                    CategoryId = 3,
                    Description = "This major revision of the classic math text makes the subject at hand still more comprehensible to readers of all levels. With a new introduction, three new chapters, modernized language and methods throughout, and an appendix of challenging and enjoyable practice problems, Calculus Made Easy has been thoroughly updated for the modern reader.",
                    ImageUrl = "/images/books/8b457390-2df6-4f02-9a0b-6b3fe4890d85.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 10,
                    Title = "Molecularizing biology and medicine",
                    Author = "Soraya de Chadarevian and Harmke Kamminga",
                    ISBN = "9057022931",
                    NumOfPages = 304,
                    Price = 99.0m,
                    CategoryId = 4,
                    Description = "The contributors present a coherent set of case studies of practices, technologies and strategies aimed at the isolation, investigation, manipulation, production, and uses of molecules including vitamins, hormones, blood products, antibiotics, and vaccines. These case studies examine how processes of molecularization were set in motion in the inter-war period, how they were used as a resource in the biomedical 'mobilization' of World War II, and how new alliances and strategies created as part of the war effort played a central role in the reorganisation of biomedicine in the post-war period.",
                    ImageUrl = "/images/books/aa23bf8b-685c-430d-a256-7b684dd1cb90.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 11,
                    Title = "The price of health",
                    Author = "James A. Gillespie",
                    ISBN = "0521381835",
                    NumOfPages = 358,
                    Price = 85.0m,
                    CategoryId = 4,
                    Description = "This book provides background to the current debate on health policy by studying the political conflict over it in Australia from 1910 to 1960. It looks at both state and national levels to identify the main structures and forces that shaped the system of publicly-subsidized private practice, which is now most obvious in the fee-for-service scheme.",
                    ImageUrl = "/images/books/27486390-9981-468b-93ad-c4cb1c8087ab.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 12,
                    Title = "Creative malady",
                    Author = "Pickering, George White Sir",
                    ISBN = "019519800X",
                    NumOfPages = 327,
                    Price = 60.0m,
                    CategoryId = 4,
                    Description = "In this interesting and entertaining work, Sir George Pickering examines the lives and careers of six very remarkable people, three men and three women. He chose them to illustrate and develop his view, previously formed, that an illness, physical or mental, that is not debilitating or disabling may play a positive part in furthering creative work. For this purpose a mental illness is better than a physical one. It can be developed to suit the circumstances; and if they change the illness may cease to have a function and disappear.",
                    ImageUrl = "/images/books/3faa928e-f41d-4710-a469-b8b357eef1ba.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 13,
                    Title = "Economics",
                    Author = "Richard G. Lipsey",
                    ISBN = "0060440163",
                    NumOfPages = 927,
                    Price = 98.5m,
                    CategoryId = 1,
                    Description = "Building on the success of previous editions, Economics, Twelfth Edition, has been thoroughly updated and revised. Rigorous yet also accessible to beginners, it provides comprehensive coverage of both introductory macroeconomics and microeconomics. The authors balance in-depth explanations of key theoretical concepts with a wide range of real-world examples drawn from around the globe. They incorporate numerous pedagogical features including highlighted definitions of economic terms, short revision questions, and updated end-of-chapter questions.",
                    ImageUrl = "/images/books/fcc69c01-79fd-45b8-82cc-d7011b5493bc.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 14,
                    Title = "The wealth of nations",
                    Author = "Adam Smith and Andrew Skinner",
                    ISBN = "067940564X",
                    NumOfPages = 620,
                    Price = 68.5m,
                    CategoryId = 1,
                    Description = "A Masterpiece of Economic Analysis Firstly Published in 1776 by Adam Smith—The Wealth of Nations\r\nAn American statistic shows that, due to its significant global impact, \"The Wealth of Nations by Adam Smith\" was the most important document published in 1776. This book, long considered to be the magnum opus of the Scottish philosopher and economist Adam Smith, offers a deep analysis into the causes and nature of the wealth of nations.\r\n\r\nThough first published in 1776, many of Adam Smith's arguments for raising living standards are still relevant today. More than that, they form the fundamental basis for classical economic theory.\r\n\r\nBy reflecting upon the economics at the beginning of the industrial revolution, the book treats broad topics such as the division of labor, division of stock, the progress of opulence, and more.\r\n\r\nIn the early days, economics was about the king's interests, and the wealth of a nation was measured by the king's treasury or by the gold and silver in the country.\r\n\r\nHowever, Smith believed that if everyone did what was best for themselves, the result would be best for society.\r\n\r\nThe Wealth of Nations provides the first and most eloquent integrated description of the workings of a market economy.",
                    ImageUrl = "/images/books/b449a8b1-84f1-44dd-8c6d-e965b6efa90b.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 15,
                    Title = "The human condition",
                    Author = "Hannah Arendt",
                    ISBN = "0226025926",
                    NumOfPages = 365,
                    Price = 65.0m,
                    CategoryId = 1,
                    Description = "The past year has seen a resurgence of interest in the political thinker Hannah Arendt, “the theorist of beginnings,” whose work probes the logics underlying unexpected transformations — from totalitarianism to revolution.\r\n\r\nA work of striking originality, The Human Condition is in many respects more relevant now than when it first appeared in 1958. In her study of the state of modern humanity, Hannah Arendt considers humankind from the perspective of the actions of which it is capable. The problems Arendt identified then — diminishing human agency and political freedom, the paradox that as human powers increase through technological and humanistic inquiry, we are less equipped to control the consequences of our actions - continue to confront us today. This new edition, published to coincide with the sixtieth anniversary of its original publication, contains Margaret Canovan’s 1998 introduction and a new foreword by Danielle Allen.\r\n\r\nA classic in political and social theory, The Human Condition is a work that has proved both timeless and perpetually timely.",
                    ImageUrl = "/images/books/3f3d222a-2401-437c-81b0-7db157cef7af.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 16,
                    Title = "The Interactive Computing",
                    Author = "Kenneth C. Laudon",
                    ISBN = "0072472618",
                    NumOfPages = 632,
                    Price = 62.0m,
                    CategoryId = 2,
                    Description = "The Interactive Computing Series is the Visual, Interactive way to develop and apply software skills. This Skills based approach coupled with its highly illustrated, 2 page-spread design is ideal for the intro CIS course, the self-paced course or students in non-traditional education settings.",
                    ImageUrl = "/images/books/3f569900-cc2e-4f9d-ac96-54cddcd7e4e6.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 17,
                    Title = "Computers: Information Technology in Perspective",
                    Author = "Larry E. Long",
                    ISBN = "013156241X",
                    NumOfPages = 677,
                    Price = 78.0m,
                    CategoryId = 2,
                    Description = "Providing overview coverage of computing/IT concepts and applications, Computers meets the needs of contemporary IT knowledge in content, sequence, and depth of presentation. The material in this progressive edition reflects readers' interests and spans the world of information technology. It contains seven core chapters; plus an introduction to e-commerce, database management, and IT security; as well as emerging technologies such as artificial intelligence. Also included — three colorful IT Illustrated modules: computer history, the making of integrated circuits, and a PC buyer's guide. For a comprehensive introduction to computers.",
                    ImageUrl = "/images/books/22ec6be5-99cc-4e1b-91b8-0459f964cfdf.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 18,
                    Title = "Advances in Computers",
                    Author = "Marshall C. Yovits",
                    ISBN = "012012114X",
                    NumOfPages = 299,
                    Price = 69.0m,
                    CategoryId = 2,
                    Description = "Red hard cover with gilt lettering on spine and upper board in very good clean condition with small scrape on tail of spine. Pages are clean and bright throughout. Library plates on front endpapers. Library stamps on page block. Anti-theft device on back inside cover. Illustrated with numerous diagrams.",
                    ImageUrl = "/images/books/27cd64b2-01d7-4d33-bf31-ba2d9f5ef27a.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 19,
                    Title = "Blood & bone",
                    Author = "Angela Belli and John L. Coulehan",
                    ISBN = "0877456372",
                    NumOfPages = 160,
                    Price = 69.9m,
                    CategoryId = 4,
                    Description = "An anthology of 100 poems, written by physicians, exploring the connections between medicine and poetry.",
                    ImageUrl = "/images/books/e194f5d1-1914-4ab7-ba69-f2c24cd46e03.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 20,
                    Title = "Chinese medical modernization",
                    Author = "AnElissa Lucas",
                    ISBN = "0030594545",
                    NumOfPages = 188,
                    Price = 35.0m,
                    CategoryId = 4,
                    Description = null,
                    ImageUrl = "/images/books/6dff32cc-dcbc-425a-8406-6463b36678df.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 21,
                    Title = "The doctor stories",
                    Author = "Richard Selzer",
                    ISBN = "0312186878",
                    NumOfPages = 389,
                    Price = 40.0m,
                    CategoryId = 4,
                    Description = "A collection of short stories exploring what it means to tend to the sick and dying includes \"Avalanche,\" \"Whither thou goest,\" \"The Masked Marvel's last toehold,\" \"Pages from a wound dresser's diary,\" and \"Poe's lighthouse\".",
                    ImageUrl = "/images/books/3cc142ee-2ac0-4cee-8a63-d88d271d0c86.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 22,
                    Title = "The last physician",
                    Author = "Elliott, Carl and John D. Lantos",
                    ISBN = "0822323362",
                    NumOfPages = 167,
                    Price = 52.9m,
                    CategoryId = 5,
                    Description = "Walker Percy brought to his novels the perspective of both a doctor and a patient. Trained as a doctor at Columbia University, he contracted tuberculosis during his internship as a pathologist at Bellevue Hospital and spent the next three years recovering, primarily in TB sanitoriums. This collection of essays explores not only Percy’s connections to medicine but also the underappreciated impact his art has had and can have on medicine itself.\r\nThe contributors — physicians, philosophers, and literary critics — examine the relevance of Percy’s work to current dilemmas in medical education and health policy. They reflect upon the role doctors and patients play in his novels, his family legacy of depression, how his medical background influenced his writing style, and his philosophy of psychiatry. They contemplate the private ways in which Percy’s work affected their own lives and analyze the author’s tendency to contrast the medical-scientific worldview with a more spiritual one. Assessing Percy’s stature as an author and elucidating the many ways that reading and writing can combine with diagnosing and treating to offer an antidote to despair, they ask what it means to be a doctor, a writer, and a seeker of cures and truths — not just for the body but for the malaise and diseased spirituality of modern times.\r\nThis collection will appeal to lovers of literature as well as medical professionals — indeed, anyone concerned with medical ethics and the human side of doctoring.",
                    ImageUrl = "/images/books/3c0e44e3-4cb5-4c12-845e-5179e4b82717.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 23,
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    ISBN = "0060120355",
                    NumOfPages = 311,
                    Price = 30.0m,
                    CategoryId = 5,
                    Description = "Aldous Huxley's profoundly important classic of world literature, Brave New World is a searching vision of an unequal, technologically-advanced future where humans are genetically bred, socially indoctrinated, and pharmaceutically anesthetized to passively uphold an authoritarian ruling order – all at the cost of our freedom, full humanity, and perhaps also our souls. “A genius [who] who spent his life decrying the onward march of the Machine” (The New Yorker), Huxley was a man of incomparable talents: equally an artist, a spiritual seeker, and one of history’s keenest observers of human nature and civilization. Brave New World, his masterpiece, has enthralled and terrified millions of readers, and retains its urgent relevance to this day as both a warning to be heeded as we head into tomorrow and as thought - provoking, satisfying work of literature. Written in the shadow of the rise of fascism during the 1930s, Brave New World likewise speaks to a 21st-century world dominated by mass-entertainment, technology, medicine and pharmaceuticals, the arts of persuasion, and the hidden influence of elites.",
                    ImageUrl = "/images/books/86960c70-fd36-4ed1-94f9-3ecb8c47aa5a.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 24,
                    Title = "Il pastor fido",
                    Author = "Battista Guarini",
                    ISBN = "OL17974570M",
                    NumOfPages = 262,
                    Price = 32.5m,
                    CategoryId = 5,
                    Description = null,
                    ImageUrl = "/images/books/b977e8e1-30eb-44a8-b70b-88a87fb7bbe5.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 25,
                    Title = "Introductory mathematical analysis",
                    Author = "Ernest F. Haeussler and Richard Paul and Richard Wood",
                    ISBN = "0130338559",
                    NumOfPages = 822,
                    Price = 79.9m,
                    CategoryId = 3,
                    Description = "Haeussler, Paul, and Wood establish a strong algebraic foundation that sets this text apart from other applied mathematics texts, paving the way for readers to solve real-world problems that use calculus. Emphasis on developing algebraic skills is extended to the exercises ― including both drill problems and applications. The authors work through examples and explanations with a blend of rigor and accessibility. In addition, they have refined the flow, transitions, organization, and portioning of the content over many editions to optimize learning for readers. The table of contents covers a wide range of topics efficiently, enabling readers to gain a diverse understanding.",
                    ImageUrl = "/images/books/d31de0aa-e93a-4122-ae68-a894811f66d1.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 26,
                    Title = "Introduction to finite mathematics",
                    Author = "John G. Kemeny",
                    ISBN = "013468835X",
                    NumOfPages = 465,
                    Price = 59.9m,
                    CategoryId = 3,
                    Description = null,
                    ImageUrl = "/images/books/875ef8c0-31d5-476f-bd2c-0b1bd35aea0f.jpg",
                    CreatedOn = DateTime.Now,
                },
                new Book
                {
                    Id = 27,
                    Title = "Pro ASP .NET Core 6",
                    Author = "Adam Freeman",
                    ISBN = "OL5818599M",
                    NumOfPages = 264,
                    Price = 35.5m,
                    CategoryId = 2,
                    Description = "Professional developers will produce leaner applications for the ASP.NET Core platform using the guidance in this best-selling book, now in its 9th edition and updated for ASP.NET Core for .NET 6. It contains detailed explanations of the ASP.NET Core platform and the application frameworks it supports. This cornerstone guide puts ASP.NET Core for .NET 6 into context and dives deep into the tools and techniques required to build modern, extensible web applications. New features and capabilities such as MVC, Razor Pages, Blazor Server, and Blazor WebAssembly are covered, along with demonstrations of how they are applied.\r\n\r\nASP.NET Core for .NET 6 is the latest evolution of Microsoft’s ASP.NET web platform and provides a \"host-agnostic\" framework and a high-productivity programming model that promotes cleaner code architecture, test-driven development, and powerful extensibility.\r\n\r\nAuthor Adam Freeman has thoroughly revised this market-leading book and explains how to get the most from ASP.NET Core for .NET 6. He starts with the nuts-and-bolts topics, teaching you about middleware components, built-in services, request model binding, and more. As you gain knowledge and confidence, he introduces increasingly more complex topics and advanced features, including endpoint routing and dependency injection. He goes in depth to give you the knowledge you need.\r\n\r\nThis book follows the same format and style as the popular previous editions but brings everything up to date for the new ASP.NET Core for .NET 6 release and broadens the focus to include all of the ASP.NET Core platform. You will appreciate the fully worked case study of a functioning ASP.NET Core application that you can use as a template for your own projects.",
                    ImageUrl = "/images/books/b907a2b2-c4f3-4233-aef4-a0c46098a6df.jpg",
                    CreatedOn = DateTime.Now,
                },
            };

            return books;
        }
    }
}
