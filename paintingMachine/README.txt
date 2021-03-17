This tool generates paintings but there are some things that are still manual. 

Setup:
----------------------------------
1- create all the folders needed in the gConfig file. 
public static string stagingDirectory = @"C:\Users\micha\Desktop\newpaintings\staging\";
public static string finishedDirectory = @"C:\Users\micha\Desktop\newpaintings\done\";
public static string outputDirectory = @"C:\Users\micha\Desktop\newpaintings\output\";

2- create the staging folders
These are folders inside the stagingDirectory and the names of the folders must match all the template mesh files. The templates
array in gconfig has them in position [x,1]

Steps:
----------------------------------
1- create your DDS files, I use paint.net. There are three sizes to use, 256 x 256, 256 x 128 and 128 x 256. You can scale them up
for better details. For example, 512 x 512 will make a nicer looking painting but 1024x1024 is overkill.

2- Note on naming, I use "art_[some name][some version]_[some variation]" like art_endor1_1.dds The name cannot exceed 24 characters.
The underscores in the name of these files is important and you will see this in step 7.

3- Move the DDS files into the staging folder for the size you plan to use. They must be the right proportion, this app will not fail
but if you make them wrong, it will crash the server.

4- Run the application and enter "1" at the prompt to run the main app.

5- It will offer to wipe out all past runs. A backup of your DDS files will get stored on each run, this is not deleted.

6- Name the folder for your tre files, one will be auto generated you can use but there's no error check if it exists already.

7- The app will go through each staging folder looking for files. It uses the second position of an array split by underscore.
so in the above example, the name art_endor1_1.dds will mean the app will display endor1 as the file to be worked on.

8- Pick the frame(s) for the image. It will step through each of the 7+ frames in the gconfig.frames list

9- All files are then generated, only takes a couple seconds.

10- In the output folder you will then see a folder for the "tre" folder you made in step 6 and folders of files.
a) move the appearance, object, shader and texture folders into your main TRE directory tree.
b) open the CRC editor and add the object files.
c) open the string editor, the templates in this app expect the two string files: strings/en/art_d and art_n. 
d) using the strings file in the output directory, create the name and description for each string
e) copy all the lua files from xxxLua to the scripts/objects/tangible/paintings folder
f) open the serverobjects.txt file in output and copy/paste the contents to the bottom of scripts/objects/tangible/paintings/serverobjects.lua file
g) open the objects.txt file in output and copy/paste the contents to the bottom of scripts/objects/tangible/paintings/objects.lua file
h) (optional) open the froglist and then add this to the objects/tangible/terminal/terminal_characterbuilder.lua so they will show up on the frog

11- compile the tre and move it to the server

12- close the SIE tool and then re-open and load your new tre and all others. Check that in objects/tangible/paintings that your
paintings work there and are not just big question mark boxes. 

13- load the lua to the server

14- test each painting

Notes:
----------------------------------
what is going on is that I've create simple template files for each needed in the tre. The find/replace in these files
requires that the replacement strings are the same length as the find string. I've made them long to offer some flexibility
but it will end up making some long strings like the above might become something like art_endor1_1_0000000000000000 where the
zeros appended to the end are just filler. Without this, the tre files will not work properly.

I'm about 99% sure there's better ways to write the mesh, appearance, object and shader files so I consider this a lazy painting
making machine. But it works and i've little interest in making it perfect.

The template files are exports of other paintings, at this time I've no idea how make a custom size painting.

The reason there are two black frames is that for some reason black 1 doesn't work on all frames. If you use it and it looks
"choppy" and not just a smoother black frame, try the other one. I'm pretty sure it is because i shaded the frame a little
so it looks better. The reason I use custom frame shaders is so they are all the same length in characters for all the same
reasons of the find/replace setup.

You can use this app as a concept for making other tre files. Once you can do it manually, then you should be able to 
take the concepts of this application to take any repetitive TRE file editing, create templates here and then just use the
find/replace concept to automate tre file creation. 
