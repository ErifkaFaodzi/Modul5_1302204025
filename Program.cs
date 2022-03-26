namespace Modul5_13022040205
{
    static void Main(String[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Vikins 1 ");
        video1.IncreaseplayCount(13);
        SayaTubeVideo video2 = new SayaTubeVideo("Vikins 2 ");
        video2.IncreaseplayCount(13);
        SayaTubeVideo video3 = new SayaTubeVideo("Vikins 3 ");
        video3.IncreaseplayCount(13);
        SayaTubeVideo video4 = new SayaTubeVideo("Vikins 4 ");
        video4.IncreaseplayCount(13);
        SayaTubeVideo video5 = new SayaTubeVideo("Vikins 5 ");
        video5.IncreaseplayCount(13);
        SayaTubeVideo video6 = new SayaTubeVideo("Vikins 6 ");
        video6.IncreaseplayCount(13);
        SayaTubeVideo video7 = new SayaTubeVideo("Vikins 7 ");
        video7.IncreaseplayCount(13);
        SayaTubeVideo video8 = new SayaTubeVideo("Vikins 8 ");
        video8.IncreaseplayCount(13);
        SayaTubeVideo video9 = new SayaTubeVideo("Vikins 9 ");
        video9.IncreaseplayCount(13);
        SayaTubeVideo video10 = new SayaTubeVideo("Vikins 10 ");
        video10.IncreaseplayCount(13);

        SayaTubeUser profile1 = new SayaTubeUser("Erifka Faodzi");

        SayaTubeUser profile2 = new SayaTubeUser("Erifka Faodzi");

        profile1.addVideo(video1);
        profile1.addVideo(video2);
        profile1.addVideo(video3);
        profile1.addVideo(video4);
        profile1.addVideo(video5);
        profile1.addVideo(video6);
        profile1.addVideo(video7);
        profile1.addVideo(video8);
        profile1.addVideo(video9);
        profile1.addVideo(video10);
        profile1.addVideo(null);
        profile1.printAllVideoPlayCount();
    }
}