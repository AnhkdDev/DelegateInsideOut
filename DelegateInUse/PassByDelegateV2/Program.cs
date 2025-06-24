namespace PassByDelegateV2
{

    //ngang cơ nhau: delegate, class, interface, struct
    internal class ShowBiz
    {
        //_field, property {get; set; }, method: ctor, ToString()...
        //một constructor default nếu class/khuôn k có phễu sẵn được tạo
        //_field, properties, method: Public, Private, Protected, Static(thuộc về cộng đồng), Non-Static (thuộc về object)
        //                                                          . trực tiếp                 . qua new object
        public void PrintSongLyricsThe1()
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
");
        }
        public static void PrintSongLyricsLover()
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
    internal class Program
    {
        //challenge 4: in ra các lời bài hát nằm ở class khác, bắt buộc dùng delegate
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 4: call the method outside - in anotherclass");
            Action f1 = () => ShowBiz.PrintSongLyricsLover();

            ShowBiz song = new ShowBiz();//default constructor
            f1 += song.PrintSongLyricsThe1;

            Action f2 = () => new ShowBiz().PrintSongLyricsThe1();
            //nguyên lí dấu bằng, a = b
            //ở đâu dùng a được thì ở đó dùng b


            f1.Invoke();    //run, phát ngôn qua nickname
            f2();//in lại bài the 1
        }
    }
}
