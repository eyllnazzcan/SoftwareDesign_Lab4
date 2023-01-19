using System;
using DotNetCRUD.Models;
using DotNetCRUD.Controllers;
using Xunit;

namespace lab2_tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var Test1 = new Music
        {
            PlaylistId = 0,

        };

        var sample = new Playlist(Test1);

        Assert.Equal(Test1.PlaylistId, sample.Id);
    }

    [Fact]
    public void Test2()
    {
        var Test2 = new Music
        {
            PlaylistName = "myTestingName"
        };

        var sample = new Playlist(Test2);

        Assert.NotEqual(Test2.PlaylistName, sample.PlaylistName);
    }

    [Fact]
    public void Test3()
    {
        var Test3 = new Music
        {
            PlaylistId = 7
        };

        var sample = new Playlist(Test3);

        Assert.NotEqual(Test3.PlaylistId, sample.Id);
    }

    [Fact]
    public void Test4()
    {
        var Test4 = new Music { };

        var sample = new Playlist(Test4);

        Assert.Null(sample.AlbumName);
        Assert.Null(sample.SingerName);
        Assert.Null(sample.Genre);

    }

}
