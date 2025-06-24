using System.Diagnostics;

namespace PassByDelegateV1
{
    internal class Program
    {
        //challenge 1: in ra 2 lời bài hát nào đó của Taylor Swift: The 1, Lover
        //             làm theo style truyền thống

        //challenge 2: dùng delegate để in bài hát

        //challenge 3: in ra 2 bài hát k được tạo hàm lẻ có sẵn rồi gán má dùng ẩn danh và lambda 
        static void Main(string[] args)
        {
            //Console.WriteLine("Challenge 1: Call explicit method directly as normal - call hàm có sẵn");
            //PrintSongLyricsLover();
            //PrintSongLyricsThe1();

            //Console.WriteLine("Challenge 2: Call explicit method using delegate");
            //Action f = PrintSongLyricsThe1;
            //f += PrintSongLyricsLover;  //multicast delegates
            //f();
            ////hợp đồng ủy quyền

            Console.WriteLine("challenge 3: using anonymous func and labda");
            Action f = () => { Console.WriteLine("mot con vit xoe ra hai cai canh"); };
            f += () => { Console.WriteLine("No keu rang quac quac quac"); };
            f();
        }

        static void PrintSongLyricsThe1()
        {
            Console.WriteLine("the song The 1 - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"[Verse 11
lim doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
"); //verbatim
        }
        static void PrintSongLyricsLover()
        {
            Console.WriteLine("the song Lover - by Taylor Swift");
            Console.WriteLine();
            Console.WriteLine(@"(Verse II
We could leave the Christmas lights up •til January
And this is our place, we make the rules
And there's a dazzling haze, a mysterious way about you, dear
Have I known you twenty seconds or twenty yearsl
(Chorus)
Can I go where you go?
Can we always be this close?
Forever and ever, ah
fake me out and take me home
you're my, my, my, my lover
...
");
        }

    }
}
