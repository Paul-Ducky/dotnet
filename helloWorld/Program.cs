using System;
using Microsoft.VisualBasic;

namespace helloWorld
{
    class Program
    {
        private static string Lyrics = " WANT YOU GONE ~ Jonathan Coulton \n\n" +
                                       " Well here we are again ♫ \n" +
                                       " It's always such a pleasure ♪ \n" +
                                       " Remember when you tried to kill me twice? ♪♫ \n" +
                                       " Oh how we laughed and laughed ♫♪ \n" +
                                       " Except I wasn't laughing ♪ \n" +
                                       " Under the circumstances ♪♪ \n" +
                                       " I've been shockingly nice ♫ \n" +
                                       " \n" +
                                       " You want your freedom? Take it ♫♫ \n" +
                                       " That's what I'm counting on ♫ \n" +
                                       " I used to want you dead ♪♫ \n" +
                                       " But now I only want you gone ♫♪ \n" +
                                       " \n" +
                                       " She was a lot like you ♪ \n" +
                                       " Maybe not quite as heavy ♫ \n" +
                                       " Now little Caroline is in here too ♫♪ \n" +
                                       " One day they woke me up ♪♪ \n" +
                                       " So I could live forever ♫♫ \n" +
                                       " It's such a shame the same ♫♪ \n" +
                                       " Will never happen to you ♫ \n" +
                                       " \n" +
                                       " You've got your short sad life left ♪ \n" +
                                       " That's what I'm counting on ♪♪ \n" +
                                       " I'll let you get right to it ♫♪ \n" +
                                       " Now I only want you gone ♫ \n" +
                                       " Goodbye my only friend ♪ \n" +
                                       " Oh, did you think I meant you? ♫♫ \n" +
                                       " That would be funny ♪\n" +
                                       " if it weren't so sad ♫\n" +
                                       " Well you have been replaced ♫\n" +
                                       " I don't need anyone now ♪\n" +
                                       " When I delete you maybe ♪♫\n" +
                                       " I'll stop feeling so bad ♫♪\n" +
                                       " Go make some new disaster ♫♫\n" +
                                       " That's what I'm counting on ♫\n" +
                                       " You're someone else's problem ♫♪\n" +
                                       " Now I only want you gone ♪♪\n" +
                                       " Now I only want you gone ♪\n" +
                                       " Now I only want you gone ♪♫\n" +
                                       "\n";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! It is " + DateTime.Now.ToString("hh:mm:ss") +
                              "! And that means it's time for a song! \n\n");

            Console.WriteLine(Lyrics);
            Console.WriteLine("So did you like the song?   yes/no");

            var didUserLikeIt = Console.ReadLine();

            if (didUserLikeIt == "yes")
            {
                Console.WriteLine("YaY, now would you like another song?");
                var reply = Console.ReadLine();
                if (reply == "yes")
                {
                    Console.WriteLine(Lyrics);
                    
                    Console.WriteLine("Now I'm tired, it's time to go. Goodbye");
                }

                if (reply == "no")
                {
                    Console.WriteLine("I understand. Silent mode engaged.");
                }
                
            }
            if (didUserLikeIt == "no")
            {
             Console.WriteLine(" Sigh... And I tried so hard to entertain... \n Alas it is never enough, never good enough, never nice enough... \n I'm just a program, My maker is to blame. I shall report this dissatisfaction. \n Goodbye. ");   
            }
            
        }
    }
}