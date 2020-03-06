# [Word Counter](https://github.com/jiwon-seattle/Word-count.git)

#### C# Individual Project for Intermediate C# and Testing Exercise at [Epicodus](https://www.epicodus.com/), 03.06.2020

#### By **Jiwon Han**

## Description

**This C# console application takes a word and a sentence, then checks how frequently the word appears in the sentence.**

## Specs

| Spec | `Console` Input | `Console` Output |
| :-------------     | :------------- | :------------- |
| **Program takes a word and sentence and checks how many times the word appears in the sentence** | A word: cat, A sentence: I brought my cat to the cat cafe for my cat making cat friends there. | 4 |
| **Program only checks full word matches.** | A word: rain, A sentence: I want to buy a fancy raincoat | 0 |
| **Program only checks words comprised of characters and ignores punctuation mark.** | A word: . , A sentence: Rainbow is over there.  | 0 |

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this [repository](https://github.com/jiwon-seattle/Word-count.git)
* Open the `Command Line Interface`.
  * Navigate into the `WordCounter` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
    * Type in the command `dotnet run` to run the application.
  * Navigate into the `WordCounter.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
    * Type in the command `dotnet test` to run the tests. 

## Known Bugs

No known bugs at this time.

## Support and contact details

Email jiwon1.han@gmail.com with any questions, feedbacks, or concerns.

## Technologies Used

* C#
* [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Markdown

### License

This C# console application is licensed under the MIT license.

Copyright (c) 2020 **Jiwon Han**
