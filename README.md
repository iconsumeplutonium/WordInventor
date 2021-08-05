# Word Inventor

#### Description

This program is designed to generate fake words/names, though the algorithm will occasionaly spit out an actual word. 

![Program in action](https://cdn.discordapp.com/attachments/690652979036028929/872934514467405904/githubgif2.gif)

#### Data used by the program

![The table of data, adapted from the code.  ](https://cdn.discordapp.com/attachments/690652979036028929/872653416126632046/unknown.png)

The above table is adapted from the data used in the code. 

The first column represents the index of that particular row, starting at 0 and going to 29.

The second column contains the 26 letters of the alphabet, A to Z, followed by 4 additional diagraphs common in the English language: sh, ch, th, and ph.

The third column contains the index of the acceptable letters that can follow its corresponding letter. For example, for the letter "M", its list of indexes are 0,
4, 6, 8, 14, and 20. This means the only acceptable letters that can come after an 
"M" are the letters in index 0 (A), index 4 (E), index 7 (H), index 8 (I), index 14
(O), and index 20 (U).  Ma, Me, Mh, Mi, Mo, and Mu.


#### How it works

I came up with the logic behind this word generator program while I was showering.


   * First it picks a random number between 0 and 29, which corresponds to the index of the first letter.
   * Next, it looks at that letter's list of acceptable following letters. 
   * From that list, it picks an index randomly. 
   * The letter that corresponds to that index becomes the second letter in the word.
   * From there, it looks at that letter's list of acceptable following letters and picks one randomly, which becomes the third letter.
   * This repeats until it reaches the maximum word length. 
   
<p>&nbsp</p>
  
  As an example, let's say that the program is tasked with generating a word whose maximum word 
  length is 5. Let's say it starts off by generating 17 as the index of the first letter. Index 17 corresponds to the letter "r", thus, our first letter is "r." Next, 
  it looks at the list of acceptable letters that can come after "r," which are 
  0, 4, 7, 8, 12, 13, 14, 19, 20, 24, 26, 27, 28, and 29. Our program picks one randomly, and let's say it picks 8. Index 8 corresponds to the letter "i" and thus, "i" becomes the second letter in the word. The list of acceptable letters that can come after "i" are numerous, as almost any letter can come after an "i." The program picks one randomly, and suppose it picks 2. Index 2 corresponds to the letter "c", making the 
  word so far "ric." Once more, it looks at the list of acceptable letters, and picks
  one randomly. This time, it picks 8, which is "i". Once more, it looks at the letters
  that can come after "i", and it picks 13, which is "n." Because we now have 5 letters
  in the word, the program ends and returns the final word. I'm not sure what "ricin" is but it sounds delicious. 
  
  
  ![Diagram of the example](https://cdn.discordapp.com/attachments/690652979036028929/872671616394465352/diagram.png)
  
  As a side note, the diagraphs sh, ch, th, and ph are considered one letter by the program if the chosen index is 26 through 29. However, the program may count them as two separate letters if through sheer luck it picks, say, "s", immediately followed by 
  an "h." 

#### The Project

After I thought of this idea and programmed it, I had made it in version 2020.3.12f1 of the Unity game engine using C#. However, after I had made it, I realized I wanted
to make it into a proper executable so others can use it themselves. Exporting that
Unity project would have given me a bloated .exe, as it would have included
Unity engine files and other video game specific tech that was unneccessary for my
purposes. As a result, I decided to convert my code into a .NET application in C#,
written in Visual Studio 2019. 

My program generates decent sounding words when the max word length is between 3 and 7 letters, 
however the program does still allow for users to generate words up to 18 letters long.
It will occasionally spit out words that don't seem to be pronouncable/have any vowels,
and occasionally spit out real words in the English dictionary. 

#### How to Run 
Once you have downloaded and unzipped the files, go to WordInventor/InventorExecutable.
Double click `WordInventor.exe` to run. 

Note: If Windows Defender blocks it from running ~~then click run anyways to run the file.~~ it is completely correct, as that executable is actually malware that will 
allow me to take control of your computer and stream Family Guy 24/7 Full Episodes Livestream (Hindi subtitles) on Youtube. 
