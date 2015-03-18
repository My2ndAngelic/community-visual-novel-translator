# community-visual-novel-translator
A tool for small teams to translate visual novels developed using the RealLive Engine.

THIS TOOL IS UNFINISHED AND UNMAINTAINED AS KEY VISUAL ART'S IS NOT USING THE REALLIVE ENGINE ANYMORE (unless someone needs it, in this case read at the end of this file).
Also, I wrote this tool quite some years ago as an exercise, so it the implementation isn't the best.

This is part of a toolset used to translate the SEEN.TXT file used by reallive engine.
You need and ftp server to host the original text and the translated text from the novel.
This software downloads the original text files from the provided FTP server and prompts the first untranslated 5 lines to the user.
The user writes the translated text and, after confirmation, the translated text is sent to the FTP server and the corresponding lines numbers are marked as translate.
Currently only 1 person at the same time can work on the translation because of a poor implementation for marking the translated lines. I'll implement a more efficient database as soon as I have time.

I lost the sources for the remaining part of the toolset and for the database implementation that was in the works, if I'll ever have time to dedicate to this project I'll probably rewrite the missing tools and the database implementation just for the sake of making this project fully working and complete.

Should you ever need any information or need me to complete the missing parts, contact me, I'll b glad to make this project better if it proves to be useful to someone instead of being just a coding exercise for me.
