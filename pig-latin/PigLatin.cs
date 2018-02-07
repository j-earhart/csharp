using System;

public static class PigLatin
{
    public static string Translate(string word)
    {
        if (word.Substring(0, 1) == "a")

        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "e")

        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "i")

        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "o")

        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "u")

        {
            return word + "ay";

        }


        else if (word.Substring(0, 1) == "a,e,i,o,u" + "qu")

        {
            return word + "ay";
        }


        else if (word.Substring(0, 2) == "ch")
        {
            string firstLetter = word.Substring(0, 2);
            string restWord = word.Substring(2);
            return restWord + firstLetter + "ay";
        }
        else if (word.Substring(0, 2) == "qu")
        {
            string firstLetter = word.Substring(0, 2);
            string restWord = word.Substring(2);
            return restWord + firstLetter + "ay";

        }
        else if (word.Substring(1, 1) == "y")
        {
            string firstLetter = word.Substring(0, 1);
            string restWord = word.Substring(1);
            return restWord + firstLetter + "ay";
        }

        else if (word.Substring(0, 3) == "squ")
        {
            string firstLetter = word.Substring(0, 3);
            string restWord = word.Substring(3);
            return restWord + firstLetter + "ay";

        }


        else if (word.Substring(0, 3) == "thr")
        {
            string firstLetter = word.Substring(0, 3);
            string restWord = word.Substring(3);
            return restWord + firstLetter + "ay";

        }
        else if (word.Substring(0, 2) == "th")
        {
            string firstLetter = word.Substring(0, 2);
            string restWord = word.Substring(2);
            return restWord + firstLetter + "ay";

        }
        else if (word.Substring(0, 3) == "sch")
        {
            string firstLetter = word.Substring(0, 3);
            string restWord = word.Substring(3);
            return restWord + firstLetter + "ay";

        }

        else if (word.Substring(0, 2) == "yt")

        {
            return word + "ay";
        }

        else if (word.Substring(0, 2) == "xr")

        {
            return word + "ay";
        }
        else if (word.Substring(0, 2) == "y")
        {
            string firstLetter = word.Substring(0, 2);
            string restWord = word.Substring(2);
            return restWord + firstLetter + "ay";

        }

        else if (word.Substring(0, 2) == "rh")
        {
            string firstLetter = word.Substring(0, 2);
            string restWord = word.Substring(2);
            return restWord + firstLetter + "ay";

        }





        else

        {
            string firstLetter = word.Substring(0, 1);
            string restWord = word.Substring(1);
            return restWord + firstLetter + "ay";
        }

    }
}
