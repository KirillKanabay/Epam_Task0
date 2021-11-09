﻿using Epam_Task_0.Interfaces;
using Epam_Task_0.Interfaces.Generic;
using Epam_Task_0.Models;
using Epam_Task_0.Models.Lists;
using Epam_Task_0.Models.Players;
using System.Collections.Generic;

namespace Epam_Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediateka mediateka = new Mediateka();

            Image img1 = new Image(1, "1.png", new Resolution(1920, 1080));
            Image img2 = new Image(2, "2.png", new Resolution(1920, 1080));
            Image img3 = new Image(3, "3.png", new Resolution(1920, 1080));

            mediateka.AddItem(img1);
            mediateka.AddItem(img2);
            mediateka.AddItem(img3);

            IMediatekaList<Image> images = new MediatekaList<Image>(id: 1);

            images.Add(img1);
            images.Add(img2);
            images.Add(img3);

            mediateka.AddList(images);

            IPlayer player = new MediatekaPlayer();

            player.Play(mediateka.FindListById(1));
        }
    }
}
