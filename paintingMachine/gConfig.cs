using System;
using System.Collections.Generic;
using System.Text;

namespace paintingMachine
{
    class gConfig
    {
        //                                        C:\Users\micha\Desktop\new paintings\staging
        public static string stagingDirectory = @"C:\Users\micha\Desktop\newpaintings\staging\";
        public static string lootStaging = @"C:\Users\micha\Desktop\newpaintings\appearance\";
        public static string finishedDirectory = @"C:\Users\micha\Desktop\newpaintings\done\";
        public static string outputDirectory = @"C:\Users\micha\Desktop\newpaintings\output\";
        public static string convoDirectory = @"C:\Users\micha\Desktop\newpaintings\conversations\";
        public static string redoDirectory = @"C:\Users\micha\Desktop\newpaintings\redo\object\tangible\painting\";
        public static string redoRootDirectory = @"C:\Users\micha\Desktop\newpaintings\redo\";
        public static string replaceFileNames = "qazqazqazqazqazqazqazqazqazqaz";// filenames
        public static string replaceStrings = "wsxwsxwsxwsxwsxwsxwsxwsxwsxwsx";// title/desc
        public static string replaceFrames = "edcedcedcedcedce";// frame art_frame_gld_01
        public static string lootAppearanceFiles = @"C:\Users\micha\Desktop\newpaintings\appearance\";
        public static string lootTemplates = @"C:\Users\micha\Desktop\newpaintings\lootTemplates\";
        public static string lua = @"xxx_lua\";
        public static string luaLoot = @"xxx_loot\";
        public static string shader = @"shader\";
        public static string texture = @"texture\";
        public static string paintings = @"object\tangible\painting\";
        public static string custom = @"object\tangible\custom\";
        public static string token = @"object\tangible\loot\misc\";
        public static string appear = @"appearance\";
        public static string mesh = @"appearance\mesh\";

        public static string[,] frames =
        {
            { "art_frame_blk_01", "f00", "blk 1t" },    //6
            { "art_frame_blk_02", "f07", "blk 2w" },    //6
            { "art_frame_brn_01", "f01", "brn 01" }, //6
            { "art_frame_gld_01", "f02", "gld 1p" }, //6
            { "art_frame_gld_02", "f03", "gld 2f" }, //6
            { "art_frame_gld_03", "f04", "gld 3f" }, //6
            { "art_frame_slv_01", "f05", "slv 1f" }, //6
            { "art_frame_slv_02", "f06", "slv 2p" }  //6
        };
        public static string[,] templates =
        {
            { "square large", "256sq_lg" },
            { "wide short", "256w_128h" },
            { "square small", "256sq_small" },
            { "square medium", "256sq_med" },
            { "tall skinny", "256h_128w" },
            { "drywall", "drywall" }
        };
        public static string petLuaFile = @"object_intangible_pet_xxxxxx_hue = object_intangible_pet_shared_xxxxxx_hue:new {

}

ObjectTemplates:addTemplate(object_intangible_pet_xxxxxx_hue, ""object/intangible/pet/xxxxxx_hue.iff"")";

        public static string petObjectsFile = @"object_intangible_pet_shared_xxxxxx_hue = SharedIntangibleObjectTemplate:new {
	clientTemplateFileName = ""object/intangible/pet/shared_xxxxxx_hue.iff""

}

    ObjectTemplates:addClientTemplate(object_intangible_pet_shared_xxxxxx_hue, ""object/intangible/pet/shared_xxxxxx_hue.iff"")
";



    }
}
