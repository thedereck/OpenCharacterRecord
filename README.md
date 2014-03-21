#Open Character Record

For awhile now, I've had the idea of creating a generic XML definition for Role Playing Game character records. But those pesky copyrights of the game producers kept getting in the way. Then came the Open Gaming License, which applied open source concepts to role playing games.

So this is the *very* initial implementation of my grand idea using the Open Gaming License games. This initial version of the Open Character Record is based upon the [Basic Fantasy Role-Playing Game, 2nd Edition](http://basicfantasy.org/download.cgi/Basic-Fantasy-RPG-Rules-r75.pdf) game rules.

That being said, let's consider this a preview release. It's so preview, I'm not even giving a the XSD a version number higher than 0.0.0. Once I write some unit tests, I'll increment the version number accordingly. Once I have full unit test coverage, I'll increment the version to 1.0.0.

You'll find a XSD file in this repository that can be used to validate the character record. There is also a html file and directory of images to make it easier to understand the layout of the XSD file. If you just want to check out the generated HTML and images of the schema, you can find them at [https://thedereck.github.io/OpenCharacterRecord/OpenCharacterRecord.html](https://thedereck.github.io/OpenCharacterRecord/OpenCharacterRecord.html).

The XSD file was created by hand using Visual Studio 2013, and the HTML file and images were created using XMLSpy.

So here is the To Do List:
* Add annotations to the XSD.
* Create unit tests to thoroughly test the XSD.
* Add example XML character records to the GitHub repository.
* Add Basic Fantasy Role-Playing Game, 3rd Editition character records to the XSD. Refactor to use common elements, and hopefully fewer specific CompexTypes in the XSD.
* Add Spirit Of The Century character records to the XSD. Again, refactor the XSD.
* Add Pathfinder character records to the XSD. Refactor the XSD. (Do you see a pattern here?)

Please take a look and provide some feedback.

Thanks.
