using System;

class Program
{
    static void Main(string[] args)
    {
        //Scripture test = new Scripture();
        //test._text = "How we doin";
        //    //test.Display();
        //Scripture FirstNephi1_2 = new Scripture();
        //FirstNephi1_2._text = "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.";
        //Reference ref1Nephi1_2 = new Reference();
        //ref1Nephi1_2._book = "1 Nephi";
        //ref1Nephi1_2._chapter = "1";
        //ref1Nephi1_2._verses = "2";
        //FirstNephi1_2.GetWordObjects();
        //    //FirstNephi1_2.DisplayFullList(ref1Nephi1_2.DisplayReference());
        //FirstNephi1_2.HideWords(3);
        //FirstNephi1_2.DisplayFullList(ref1Nephi1_2.DisplayReference());
        //confirmed to work! Clean it up, add a couple more, and a random picker, and your good to go.

        List<Scripture> enteredScriptures = new List<Scripture>();
        List<Reference> enteredReferences = new List<Reference>();
        
        Scripture scriptFirstNephi1_2 = new Scripture();
        scriptFirstNephi1_2._text = "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.";

        Reference refFirstNephi1_2 = new Reference();
        refFirstNephi1_2._book = "1 Nephi";
        refFirstNephi1_2._chapter = "1";
        refFirstNephi1_2._verses = "2";
        enteredScriptures.Add(scriptFirstNephi1_2);
        enteredReferences.Add(refFirstNephi1_2);

        Scripture scriptMatthew9_4thru7 = new Scripture();
        scriptMatthew9_4thru7._text = "And Jesus knowing their thoughts said, Wherefore think ye evil in your hearts? For whether is easier, to say, Thy sins be forgiven thee; or to say, Arise, and walk? But that ye may know that the Son of man hath power on earth to forgive sins, (then saith he to the sick of the palsy,) Arise, take up thy bed, and go unto thine house. And he arose, and departed to his house.";
        Reference refMatthew9_4thru7 = new Reference();
        refMatthew9_4thru7._book = "Matthew";
        refMatthew9_4thru7._chapter = "9";
        refMatthew9_4thru7._verses = "4-7";
        enteredScriptures.Add(scriptMatthew9_4thru7);
        enteredReferences.Add(refMatthew9_4thru7);

        //TEMPLATE TEMPLATE TEMPLATE TEMPLATE
        //Scripture scriptNAMEOFSCRIPTURE = new Scripture();
        //scriptNAMEOFSCRIPTURE._text = "";
        //Reference refREFERENCE = new Reference();
        //refREFERENCE._book = "";
        //refREFERENCE._chapter = "";
        //refREFERENCE._verses = "";
        //enteredScriptures.Add(scriptNAMEOFSCRIPTURE);
        //enteredReferences.Add(refREFERENCE);

        Scripture scriptEzra7 = new Scripture();
        scriptEzra7._text = "Now after these things, in the reign of Artaxerxes king of Persia, Ezra the son of Seraiah, the son of Azariah, the son of Hilkiah, The son of Shallum, the son of Zadok, the son of Ahitub, The son of Amariah, the son of Azariah, the son of Meraioth, The son of Zerahiah, the son of Uzzi, the son of Bukki, The son of Abishua, the son of Phinehas, the son of Eleazar, the son of Aaron the chief priest: This Ezra went up from Babylon; and he was a ready scribe in the law of Moses, which the Lord God of Israel had given: and the king granted him all his request, according to the hand of the Lord his God upon him. And there went up some of the children of Israel, and of the priests, and the Levites, and the singers, and the porters, and the Nethinims, unto Jerusalem, in the seventh year of Artaxerxes the king. And he came to Jerusalem in the fifth month, which was in the seventh year of the king. For upon the first day of the first month began he to go up from Babylon, and on the first day of the fifth month came he to Jerusalem, according to the good hand of his God upon him. For Ezra had prepared his heart to seek the law of the Lord, and to do it, and to teach in Israel statutes and judgments. Now this is the copy of the letter that the king Artaxerxes gave unto Ezra the priest, the scribe, even a scribe of the words of the commandments of the Lord, and of his statutes to Israel. Artaxerxes, king of kings, unto Ezra the priest, a scribe of the law of the God of heaven, perfect peace, and at such a time. I make a decree, that all they of the people of Israel, and of his priests and Levites, in my realm, which are minded of their own freewill to go up to Jerusalem, go with thee. Forasmuch as thou art sent of the king, and of his seven counsellors, to inquire concerning Judah and Jerusalem, according to the law of thy God which is in thine hand; And to carry the silver and gold, which the king and his counsellors have freely offered unto the God of Israel, whose habitation is in Jerusalem, And all the silver and gold that thou canst find in all the province of Babylon, with the freewill offering of the people, and of the priests, offering willingly for the house of their God which is in Jerusalem: That thou mayest buy speedily with this money bullocks, rams, lambs, with their meat offerings and their drink offerings, and offer them upon the altar of the house of your God which is in Jerusalem. And whatsoever shall seem good to thee, and to thy brethren, to do with the rest of the silver and the gold, that do after the will of your God. The vessels also that are given thee for the service of the house of thy God, those deliver thou before the God of Jerusalem. And whatsoever more shall be needful for the house of thy God, which thou shalt have occasion to bestow, bestow it out of the king’s treasure house. And I, even I Artaxerxes the king, do make a decree to all the treasurers which are beyond the river, that whatsoever Ezra the priest, the scribe of the law of the God of heaven, shall require of you, it be done speedily, Unto an hundred talents of silver, and to an hundred measures of wheat, and to an hundred baths of wine, and to an hundred baths of oil, and salt without prescribing how much. Whatsoever is commanded by the God of heaven, let it be diligently done for the house of the God of heaven: for why should there be wrath against the realm of the king and his sons? Also we certify you, that touching any of the priests and Levites, singers, porters, Nethinims, or ministers of this house of God, it shall not be lawful to impose toll, tribute, or custom, upon them. And thou, Ezra, after the wisdom of thy God, that is in thine hand, set magistrates and judges, which may judge all the people that are beyond the river, all such as know the laws of thy God; and teach ye them that know them not. And whosoever will not do the law of thy God, and the law of the king, let judgment be executed speedily upon him, whether it be unto death, or to banishment, or to confiscation of goods, or to imprisonment. Blessed be the Lord God of our fathers, which hath put such a thing as this in the king’s heart, to beautify the house of the Lord which is in Jerusalem: And hath extended mercy unto me before the king, and his counsellors, and before all the king’s mighty princes. And I was strengthened as the hand of the Lord my God was upon me, and I gathered together out of Israel chief men to go up with me.";
        Reference refEzra7 = new Reference();
        refEzra7._book = "Ezra";
        refEzra7._chapter = "7";
        refEzra7._verses = "";
        enteredScriptures.Add(scriptEzra7);
        enteredReferences.Add(refEzra7);

        Scripture scriptlol = new Scripture();
        scriptlol._text = "Brothers and sisters, I will now present the General Authorities, Area Seventies, and General Officers of The Church of Jesus Christ of Latter-day Saints for your sustaining vote. Please express your support in the usual way. If there are those who oppose any of the proposals, we ask that you contact your stake president. It is proposed that we sustain Russell Marion Nelson as prophet, seer, and revelator and President of The Church of Jesus Christ of Latter-day Saints; Dallin Harris Oaks as First Counselor in the First Presidency; and Henry Bennion Eyring as Second Counselor in the First Presidency. Those in favor may manifest it. Those opposed, if any, may manifest it. It is proposed that we sustain Dallin H. Oaks as President of the Quorum of the Twelve Apostles and Jeffrey R. Holland as Acting President of the Quorum of the Twelve Apostles. Those in favor, please signify. Any opposed may manifest it. It is proposed that we sustain the following as members of the Quorum of the Twelve Apostles: Jeffrey R. Holland, Dieter F. Uchtdorf, David A. Bednar, Quentin L. Cook, D. Todd Christofferson, Neil L. Andersen, Ronald A. Rasband, Gary E. Stevenson, Dale G. Renlund, Gerrit W. Gong, Ulisses Soares, and Patrick Kearon. Those in favor, please manifest it. Any opposed may so indicate. It is proposed that we sustain the counselors in the First Presidency and the Quorum of the Twelve Apostles as prophets, seers, and revelators. All in favor, please manifest it. Contrary, if there be any, by the same sign. The following General Authority Seventies will be released from their assignments and given emeritus status, effective on August 1, 2025: Elders David S. Baxter, Randall K. Bennett, Kevin S. Hamilton, Rafael E. Pino, and Jorge F. Zeballos. Those who wish to express gratitude to these brethren and to their wives and families for their years of dedicated service throughout the Church may do so by the uplifted hand. We also release Elder José A. Teixeira from serving as a member of the Presidency of the Seventy, effective on August 1, 2025. Those who wish to express appreciation to Elder Teixeira for his service in this capacity may do so. We note with gratitude the 65 Area Seventies who will complete their service and whose names can be found on the Church’s website. Those who wish to join in expressing appreciation to these brethren and to their families for their years of selfless service may manifest it. We extend releases to the Young Men General Presidency, effective on August 1, 2025, as follows: Steven J. Lund as President, Bradley R. Wilcox as First Counselor, and Michael T. Nelson as Second Counselor. All who wish to join in expressing appreciation to these brothers for their devoted service may manifest it. It is proposed that we sustain Elder Kevin R. Duncan as a member of the Presidency of the Seventy, effective on August 1, 2025. Those in favor may manifest it. Any opposed may manifest it. It is proposed that we sustain the following as new General Authority Seventies: John D. Amos, Ronald M. Barcellos, Steven C. Barlow, Kevin G. Brown, B. Corey Cuvelier, Michael Cziesla, James E. Evanson, Brik V. Eyre, Ozani Farias, Aaron T. Hall, Brian J. Holmes, Pedro X. Larreal, Clement M. Matswagothata, Eduardo F. Ortega, Edward B. Rowe, and Wan-Liang Wu. All in favor, please manifest it. Those opposed, by the same sign. We note that 78 new Area Seventies were sustained during the general conference leadership meetings on Thursday, April 3, and then announced on the Church’s website. We invite you to sustain these brethren in their new assignments. Those in favor, please manifest it. Any opposed, by the same sign. It is proposed that we sustain the following as the new Young Men General Presidency, effective on August 1, 2025: Timothy L. Farnes as President, David J. Wunderli as First Counselor, and Sean R. Dixon as Second Counselor. Those in favor may manifest it. Any opposed may so signify. It is proposed that we sustain the other General Authorities, Area Seventies, and General Officers as presently constituted. All in favor may do so by the uplifted hand. Those opposed, if any. Thank you, brothers and sisters, for your sustaining vote on behalf of the leadership of the Church. Changes to Area Seventies The following Area Seventies were sustained during a leadership session held as part of general conference: Emmanuel Rodantes G. Abraham, Jonah Akekere, Edmund L. Ang, Odilon Asevedo, Vladimir N. Astashov, Douglas W. Atwood, Ignatius K. Baidoo, Anthony John Balledos, Carlos A. Baptista, Timothy L. Barney, Marco A. Becegato, Steven L. Bodhaine, Thaddeus M. Brown, Gabriel A. Campos, Jose R. Cardenas Vanegas, Palmênio C. Castro, Robert M. Chaggares, David L. Chandler, Andrew J. Child, Carlton J. Christensen, William G. Coleman, Sean F. D. Collins, Bryan C. Crawley, Gustavo A. Cristales, Loren G. Dalton, M. Sidney Daniels, Robert L. Davis, Freeman Dickie, Moroni Dominguez Jimenez, Siale Matavaha ‘Eliesa, Robert K Ellis, James G. Fantone, Jacob C. Fish, Matthias A. Frost, W. Brett Graham, Jeremy B. Grisel, Rodney H. Hillam, Shane T. Holdaway, James A. Jarvis, Aaron R. Jenne, Jose A. Jimenez Alava, Nathan L. Johnson, H. Jason Joseph, Ronald M. Judd, Motoshige Karino, Natthapol Lattisophonkul, Roland E. Léporé, Samuel López, Ricard G. Manáhan, Arturo Martinez, Charles P. Martins, Kelend I. Mills, David E. Mouhsen, Luis Navarro, Mathias N. Niambe, Jeffery M. Nikoia, Prince S. Nyanforh, Kabemba F. Nyembo, Akingbade A. Ojo, G. Michael Ortiz, Huri Parata, Juan C. Quilantan, David A. Reyes, Matthew O. Richardson, Matthew L. Riggs, Jaime N. Rivera Jr., Stephen M. Sargent, David L. Smith, Todd B. Smith, Marco N. Sosa, Jared M. Spataro, Scott Spencer, Craig M. Teuscher, Mees Bulang-C. Tshiband, Francisco Valim, Jesus A. Vazquez Roman, Terry E. Welch, David A. Winters. The following Area Seventies will be released on or before August 1, 2025: John D. Amos (hey, he was my mission president), Jay D. Andersen, Faapito Auapaau, Frederick K. Balli, Steven C. Barlow, Kevin W. Birch, John W. Boswell, Kevin G. Brown, J. Francisco Bührer, Suchat Chaichana, Christian C. Chigbundu, Matthew R. Clarke, L. Guido Cristobal, B. Corey Cuvelier, Edmarc R. Dumas, Brik V. Eyre, Timothy L. Farnes, Carlos A. Gabaldón, M. Andrew Galt, Vladislav Y. Gornostaev, Aaron T. Hall, Thomas Hänni, Richard I. Heaton, Broc C. Hiatt, Brian J. Holmes, David H. Huntsman, Norman Insong, Daniel Kabason, Federico M. Kähnlein, Jeffrey J. Kerr, David G. LaFrance, Marcelo Louza, Jose G. Manarin, Jeremiah J. Morgan, Mark A. Mortensen, S. Ephraim Msane, R. Pepper Murray, Eduardo F. Ortega, Nathan D. Pace, Michael M. Packer, Jorge W. Pérez, Kyrylo Pokhylko, Sergio A. Poncio, Art Rascon, Miguel A. Reynoso, Gustavo G. Rezende, Robert G. Rivarola, Edward B. Rowe, Alexey V. Samaykin, Luciano Sankari, Henry Savstrom, J. Matthew Scott, James E. Slaughter, Robert T. Smith, Ricardo Spencer, Colin C. Stauffer, David C. Stewart, Konstantin Tolomeev, Arlen M. Tumaliuan, Martin J. Turvey, Yan Carlos Vega, Paul B. Whippy, Chad R. Wilkinson, Dow R. Wilson, Markus Zarse.\n \n SET YOUR TERMINAL TO FULL SCREEN AT THE SMALLEST POSSIBLE FONT SIZE LOL :)";
        Reference reflol = new Reference();
        reflol._book = "Dallin H. Oaks";
        reflol._chapter = "April 2025 General Conference";
        reflol._verses = "Sustaining of General Authorities, Area Seventies, and General Officers";
        enteredScriptures.Add(scriptlol);
        enteredReferences.Add(reflol);

        Random random = new Random();
        int randomIndex = random.Next(0, enteredScriptures.Count);
        //Console.WriteLine(randomIndex);
        //shownWords[randomIndex]._hidden = true; 
            //enteredScriptures[randomIndex].GetWordObjects();
            //enteredScriptures[randomIndex].DisplayFullList(enteredReferences[randomIndex].DisplayReference());
            //enteredScriptures[randomIndex].HideWords(3);
        
        enteredScriptures[randomIndex].GetWordObjects();

        
        bool GameState = true;
        while (GameState) {
            
            enteredScriptures[randomIndex].DisplayFullList(enteredReferences[randomIndex].DisplayReference());
            
            Console.Write("\n Press Enter to continue, type 'quit' to end the program: \n     ");
            if (Console.ReadLine().ToLower() == "quit") {
                GameState = false;
            }
            if (enteredScriptures[randomIndex].ExitGame() == false) {
                GameState = false;
            }
            enteredScriptures[randomIndex].HideWords(3);
            enteredScriptures[randomIndex]._havewordsbeenhiddenyet = true;
            
        }
        Console.WriteLine("Come Back Soon!"); 
        
    }
    
}